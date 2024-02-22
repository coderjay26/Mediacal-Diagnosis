using Android.App;
using Android.Content;
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

namespace Mediacal_Diagnosis.Activities
{
    [Activity(Label = "HomeScreen")]
    [Obsolete]
    public class HomeScreen : AppCompatActivity
    {
        Animation anim;
        bool isCategory = true;
        private System.Timers.Timer timer;
        private TextInputEditText textInputEditText;
        private PopupWindow popupWindow;
        const string message = "To start please select category (gastrointestinal, respiratory, allergic, dental, dermatology, infectious)";
        private string[] options = { "gastrointestinal", "Respiratory", "allergic", "dental", "dermatology", "infectious" };
        const string category_error_message = "Sorry category selected is not recognize";
        string Tag = "Jay";
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
           
            
        }
        protected async override void OnResume()
        {
            base.OnResume();
            
            SetContentView(Resource.Layout.home_screen);
            anim = AnimationUtils.LoadAnimation(this, Resource.Animation.typing_in);
            
            var sendbtn = FindViewById<MaterialButton>(Resource.Id.sendButton);

            textInputEditText = FindViewById<TextInputEditText>(Resource.Id.userMessage);

            textInputEditText.TextChanged += TextInputEditText_TextChanged;

            if(isCategory)
            {
                timer = new System.Timers.Timer();
                timer.Interval = 5500; // 5 seconds
                timer.Elapsed += Timer_Elapsed;
                timer.AutoReset = false; // Only fire once
                timer.Start();
            }
            // Start the timer when the activity is created
            
            sendbtn.Click += (s, e) =>
            {
                TextInputEditText mes = FindViewById<TextInputEditText>(Resource.Id.userMessage);

                string userMessage = mes.Text;
                if (!string.IsNullOrWhiteSpace(userMessage))
                {
                    CreateUserMessage(userMessage);

                }
                mes.Text = "";
            };

            // Call the method to create and add the LinearLayout
            AddNewLinearLayoutWithAnimation();
        }
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (isCategory)
            {
                RunOnUiThread(() =>
                {
                    ShowPopupIfNeeded();
                });
            }
        }

        private void TextInputEditText_TextChanged(object sender, Android.Text.TextChangedEventArgs e)
        {
            // Restart the timer whenever text changes
            timer.Stop();
            timer.Start();
        }

        private void ShowPopupIfNeeded()
        {
            string filterText = textInputEditText.Text.ToLower();
            string[] filteredOptions = options.Where(option => option.ToLower().Contains(filterText)).ToArray();

            if (filteredOptions.Length > 0)
            {
                ShowPopup(filteredOptions);
            }
            else
            {
                HidePopup();
            }
        }

        private void ShowPopup(string[] options)
        {
            // Create ListView for options
            ListView listView = new ListView(this);
            CategoryViewModel categoryViewModel = new CategoryViewModel();
            listView.Adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, options);
            listView.ItemClick += async (s, e) =>
            {
                string selectedOption = options[e.Position];
                CreateUserMessage(selectedOption);
                var category = createCategoryModel(selectedOption);
                textInputEditText.Text = "";
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
                            ViewGroup.LayoutParams.WrapContent,
                            ViewGroup.LayoutParams.WrapContent,
                            true);

                        await Task.Delay(600);
                        // Show the popup window at the center of the screen
                        popupWindow.ShowAtLocation(popupView, GravityFlags.Center, 0, 0);
                        // Get the LinearLayout container for checkboxes
                        LinearLayout checkboxContainer = popupView.FindViewById<LinearLayout>(Resource.Id.checkbox_container);
                        // Example: Dismiss the popup window when a button is clicked
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
                            Console.WriteLine(selectedSymptomsString);
                            var response = await categoryViewModel.getRecommendation(symptoms);
                            CreateChatBotResponse(response);
                           
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

                }
            };

            // Calculate the height of the PopupWindow
            int height = options.Length * 150;

            // Create PopupWindow
            popupWindow = new PopupWindow(listView, textInputEditText.Width, height, true);
            popupWindow.Focusable = true;
            popupWindow.SetBackgroundDrawable(new ColorDrawable(Color.White));

            textInputEditText.RequestFocus();
            // Show the PopupWindow above the TextInputEditText
            popupWindow.ShowAsDropDown(textInputEditText, 0, -height);
        }


        private void HidePopup()
        {
            if (popupWindow != null && popupWindow.IsShowing)
            {
                popupWindow.Dismiss();
                popupWindow = null;
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
            var newLinearLayout = new LinearLayout(this);
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
        }
        private void CreateUserMessage(string Message)
        {
            // Create a new LinearLayout
            var newLinearLayout = new LinearLayout(this);
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