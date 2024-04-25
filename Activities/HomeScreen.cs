using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Hardware.Lights;
using Android.Nfc;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.RecyclerView.Widget;
using Google.Android.Material.BottomNavigation;
using Google.Android.Material.Button;
using Google.Android.Material.FloatingActionButton;
using Google.Android.Material.TextField;
using Mediacal_Diagnosis.Model;
using Mediacal_Diagnosis.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlertDialog = Android.App.AlertDialog;
using Orientation = Android.Widget.Orientation;

namespace Mediacal_Diagnosis.Activities
{
    [Activity(Label = "HomeScreen")]
    [Obsolete]
    public class HomeScreen : AppCompatActivity
    {
        Animation anim;
        Animation animation;
        LinearLayout newLinearLayout;
        ListView listView;
        private ScrollView scrollView;
        bool isCategory = true;
        bool isShow = true;
        private System.Timers.Timer timer;
        private System.Timers.Timer times;
        private TextInputEditText textInputEditText;
        private LinearLayout inputMsg;
        private PopupWindow popupWindow;
        const string message = "To start please select category (gastrointestinal, respiratory, allergic, dental, dermatology, infectious)";
        private string[] options = { "Gastrointestinal", "Respiratory", "Allergic", "Dental", "Dermatology", "Infectious" };
        const string category_error_message = "Sorry category selected is not recognize";
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
           
            
        }
        protected async override void OnResume()
        {
            base.OnResume();
            
            SetContentView(Resource.Layout.home_screen);
            anim = AnimationUtils.LoadAnimation(this, Resource.Animation.typing_in);
            scrollView = FindViewById<ScrollView>(Resource.Id.messagesScroll);
            inputMsg = FindViewById<LinearLayout>(Resource.Id.inputMsg);
            animation = AnimationUtils.LoadAnimation(this, Resource.Animation.slide_up);
           

            if(isCategory)
            {
                timer = new System.Timers.Timer();
                timer.Interval = 5500; // 5 seconds
                timer.Elapsed += Timer_Elapsed;
                timer.AutoReset = false; // Only fire once
                timer.Start();
            }

            // Call the method to create and add the LinearLayout
            AddNewLinearLayoutWithAnimation();
        }
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (isCategory)
            {
                RunOnUiThread(() =>
                {
                    ShowPopup(options);
                });
            }
        }

        private void ShowPopup(string[] options)
        {
            // Create ListView for options
            listView = new ListView(this);
            listView.LayoutParameters = new ListView.LayoutParams(
                ListView.LayoutParams.MatchParent,
                ListView.LayoutParams.WrapContent
            );

            // Set margins
            var layoutParams = (ListView.LayoutParams)listView.LayoutParameters;
            listView.LayoutParameters = layoutParams;
            listView.Bottom = 0;
            CategoryViewModel categoryViewModel = new CategoryViewModel();
            listView.Adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, options);
            listView.ItemClick += async (s, e) =>
            {
                string selectedOption = options[e.Position];
                CreateUserMessage(selectedOption);
                var category = createCategoryModel(selectedOption);
                isCategory = false;
                HidePopup();
                var categories = new CategoryModel
                {
                    Category = selectedOption
                };
                var result = await categoryViewModel.getSymptoms(categories);
                try
                {
                    var jsonResult = JsonConvert.DeserializeObject<CategoryResponse>(result);

                    if (jsonResult != null && jsonResult.success)
                    {
                        CreateChatBotResponse("Please select your symptoms");
                        // Inflate the popup layout
                        View popupView = LayoutInflater.FromContext(this).Inflate(Resource.Layout.popup_layout, null);

                        // Create the popup window
                        PopupWindow popupWindow = new PopupWindow(
                            popupView,
                            ViewGroup.LayoutParams.MatchParent,
                            ViewGroup.LayoutParams.WrapContent,
                            true);
                        popupWindow.OutsideTouchable = false;
                        popupWindow.Focusable = false;
                        isCategory = true;
                        await Task.Delay(600);
                        
                        // Show the popup window at the center of the screen
                        popupWindow.ShowAtLocation(popupView, GravityFlags.Bottom, 0, 0);
                        // Get the LinearLayout container for checkboxes
                        LinearLayout checkboxContainer = popupView.FindViewById<LinearLayout>(Resource.Id.checkbox_container);
                        //Dismiss the popup window when a button is clicked
                        Button dismissButton = popupView.FindViewById<Button>(Resource.Id.dismiss_button);
                        List<string> selectedSymptoms = new List<string>();
                        dismissButton.Click += async (sender, args) =>
                        {
                            // Iterate over all checkboxes to get selected symptoms
                            for (int i = 0; i < checkboxContainer.ChildCount; i++)
                            {
                                View childView = checkboxContainer.GetChildAt(i);
                                if (childView is CheckBox checkBox && checkBox.Checked)
                                {
                                    selectedSymptoms.Add(checkBox.Text);
                                }
                            }
                            popupWindow.Dismiss();
                            string selectedSymptomsString = string.Join(",", selectedSymptoms);
                            CreateUserMessage(selectedSymptomsString);
                            var symptoms = new SymptomsModel
                            {
                                symptoms = selectedSymptomsString
                            };
                            await Task.Delay(2000);
                            var response = await categoryViewModel.getRecommendation(symptoms);
                            CreateChatBotResponse(response);
                            await Task.Delay(2000);
                            isCategory = true;
                            await Task.Delay(2000);
                            CreateChatBotResponse(message);
                            await Task.Delay(500);
                            ShowPopup(options);
                        };

                        

                        // Populate the checkboxes with symptoms data
                        foreach (var symptoms in jsonResult.data)
                        {
                            foreach (var symptom in symptoms.Symptoms)
                            {
                                CheckBox checkBox = new CheckBox(this);
                                checkBox.Text = symptom;
                                checkboxContainer.AddView(checkBox);
                            }

                        }
                    }
                }
                catch (JsonReaderException ex)
                {
                    Toast.MakeText(this, "Login Failed!", ToastLength.Long).Show();
                    ShowPopup(options);
                }
            };
          
            var parentLinearLayout = FindViewById<LinearLayout>(Resource.Id.inputMsg);

            // Start animation
            listView.StartAnimation(animation);

            // Add the new LinearLayout to the parent LinearLayout
            parentLinearLayout.AddView(listView);
            scrollView.Post(() =>
            {
                scrollView.SmoothScrollTo(0, newLinearLayout.Top);
            });


        }


        private void HidePopup()
        {
            if (listView != null )
            {
                listView.Visibility = ViewStates.Gone;
                listView = null;
            }
        }
        private async void AddNewLinearLayoutWithAnimation()
        {
            // Delay for animation
            await Task.Delay(1000);
            // Create a new LinearLayout
            CreateChatBotResponse(Resources.GetString(Resource.String.home_text));
            await Task.Delay(2000);
            CreateChatBotResponse(message);
            await Task.Delay(500);
        }

        private async void CreateChatBotResponse(string Message)
        {
            // Create a new LinearLayout
            newLinearLayout = new LinearLayout(this);
            newLinearLayout.Orientation = Orientation.Horizontal;
            newLinearLayout.LayoutParameters = new LinearLayout.LayoutParams(
                LinearLayout.LayoutParams.WrapContent,
                LinearLayout.LayoutParams.WrapContent
            );

            // Set margins
            var layoutParams = (LinearLayout.LayoutParams)newLinearLayout.LayoutParameters;
            layoutParams.SetMargins(0, 8, 0, 8); // Left, Top, Right, Bottom
            layoutParams.Gravity = GravityFlags.Left;
            newLinearLayout.LayoutParameters = layoutParams;
            layoutParams.RightMargin = 150;
            // Create TextView
            var textView = new TextView(this);
            textView.Text = Message;
            textView.SetTextAppearance(this, Android.Resource.Style.TextAppearanceDeviceDefaultSmall);

            // Create ImageView
            var imageView = new ImageView(this);
            imageView.SetImageResource(Resource.Drawable.trendy_ai_circle);

            // Set layout parameters for ImageView
            var imageLayoutParam = new LinearLayout.LayoutParams(100, 100);
            imageLayoutParam.SetMargins(0, 0, 5, 0); // Left, Top, Right, Bottom
            imageView.LayoutParameters = imageLayoutParam;

            // Create inner LinearLayout
            var innerLinearLayout = new LinearLayout(this);
            innerLinearLayout.LayoutParameters = new LinearLayout.LayoutParams(
                0,
                LinearLayout.LayoutParams.WrapContent,
                1
            );
            innerLinearLayout.SetPadding(24, 24, 24, 24);
            innerLinearLayout.SetBackgroundResource(Resource.Drawable.rounded_corner);
            innerLinearLayout.AddView(textView);

            // Add views to the new LinearLayout
            newLinearLayout.AddView(imageView);
            newLinearLayout.AddView(innerLinearLayout);

            // Load animation
            Animation anim = AnimationUtils.LoadAnimation(this, Resource.Animation.typing_in);

            // Get a reference to the parent LinearLayout
            var parentLinearLayout = FindViewById<LinearLayout>(Resource.Id.linearLayout2);

            // Start animation
            newLinearLayout.StartAnimation(anim);
            
            // Add the new LinearLayout to the parent LinearLayout
            parentLinearLayout.AddView(newLinearLayout);

            scrollView.Post(() =>
            {
                scrollView.SmoothScrollTo(0, newLinearLayout.Top);
            }); 


        }
        private void CreateUserMessage(string Message)
        {
            // Create a new LinearLayout
            newLinearLayout = new LinearLayout(this);
            newLinearLayout.Orientation = Orientation.Horizontal;
            newLinearLayout.LayoutParameters = new LinearLayout.LayoutParams(
                LinearLayout.LayoutParams.WrapContent,
                LinearLayout.LayoutParams.WrapContent
            );

            // Set margins
            var layoutParams = (LinearLayout.LayoutParams)newLinearLayout.LayoutParameters;
            layoutParams.SetMargins(0, 8, 0, 8); // Left, Top, Right, Bottom
            layoutParams.Gravity = GravityFlags.Right;
            newLinearLayout.LayoutParameters = layoutParams;
            layoutParams.LeftMargin = 150;
            // Create TextView
            var textView = new TextView(this);
            textView.Text = Message;
            textView.SetTextAppearance(this, Android.Resource.Style.TextAppearanceDeviceDefaultSmall);


            // Create inner LinearLayout
            var innerLinearLayout = new LinearLayout(this);
            innerLinearLayout.LayoutParameters = new LinearLayout.LayoutParams(
                0,
                LinearLayout.LayoutParams.WrapContent,
                1
            );
            innerLinearLayout.SetPadding(24, 24, 24, 24);
            innerLinearLayout.SetBackgroundResource(Resource.Drawable.rounded_corner_blue) ;
            innerLinearLayout.AddView(textView);

            // Add views to the new LinearLayout
            newLinearLayout.AddView(innerLinearLayout);


            // Get a reference to the parent LinearLayout
            var parentLinearLayout = FindViewById<LinearLayout>(Resource.Id.linearLayout2);

            // Start animation
            newLinearLayout.StartAnimation(anim);


            // Add the new LinearLayout to the parent LinearLayout
           parentLinearLayout.AddView(newLinearLayout);
            scrollView.Post(() =>
            {
                scrollView.SmoothScrollTo(0, newLinearLayout.Top);
            });

        }
        public static CategoryModel createCategoryModel(string categorys)
        {
           var categories = new CategoryModel
            {
                Category = categorys
            };
            return categories;
        }
    }
}