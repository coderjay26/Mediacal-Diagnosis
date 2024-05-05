using Android.App;
using Android.Content.Res;
using Android.OS;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.TextField;
using Mediacal_Diagnosis.Model;
using Mediacal_Diagnosis.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Orientation = Android.Widget.Orientation;

namespace Mediacal_Diagnosis.Activities
{
    [Activity(Label = "HomeScreen")]
    [Obsolete]
    public class HomeScreen : AppCompatActivity
    {
         private Dictionary<string, Symptom> categories;
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

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
           InitializeCategories();
            
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
                timer.Interval = 4000; // 5 seconds
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
            askDetails();

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
            await Task.Delay(800);
            CreateChatBotResponse("Let's start with the symptom that's troubling you the most. ");
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

        public async void askDetails()
        {
            listView = new ListView(this);
            listView.LayoutParameters = new LinearLayout.LayoutParams(
                LinearLayout.LayoutParams.MatchParent,
                LinearLayout.LayoutParams.WrapContent
            );

            // Set margins
            var layoutParams = (LinearLayout.LayoutParams)listView.LayoutParameters;
            listView.LayoutParameters = layoutParams;
            listView.Bottom = 0;
            CategoryViewModel categoryViewModel = new CategoryViewModel();

            // Check if categories is not null
            if (categories != null)
            {
                var categoryNames = new List<string>(categories.Keys);
                listView.Adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, categoryNames);
            }
            else
            {
                // Handle the case where categories is null
                Console.WriteLine("Categories is null");
                return;
            }

            var parentLinearLayout = FindViewById<LinearLayout>(Resource.Id.inputMsg);

            // Start animation
            listView.StartAnimation(animation);

            // Add the new LinearLayout to the parent LinearLayout
            parentLinearLayout.AddView(listView);
            scrollView.Post(() =>
            {
                scrollView.SmoothScrollTo(0, newLinearLayout.Top);
            });

            listView.ItemClick += (sender, args) =>
            {
                var selectedCategory = categories.ElementAt(args.Position).Key;
                CreateUserMessage(selectedCategory);
                var currentNode = categories[selectedCategory];
                HidePopup();
                UpdateQuestionAndAnswers(currentNode);
            };
        }

        private async void UpdateQuestionAndAnswers(Symptom symptom)
        {
            listView = new ListView(this);
            listView.LayoutParameters = new LinearLayout.LayoutParams(
                LinearLayout.LayoutParams.MatchParent,
                LinearLayout.LayoutParams.WrapContent
            );

            // Set margins
            var layoutParams = (LinearLayout.LayoutParams)listView.LayoutParameters;
            listView.LayoutParameters = layoutParams;
            listView.Bottom = 0;
            await Task.Delay(800);
            CreateChatBotResponse(symptom.question);

            if (symptom.responses != null)
            {
                var responseList = new List<string>(symptom.responses.Keys);
                listView.Adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, responseList);

                var parentLinearLayout = FindViewById<LinearLayout>(Resource.Id.inputMsg);
                // Start animation
                listView.StartAnimation(animation);
                await Task.Delay(800);
                // Add the new LinearLayout to the parent LinearLayout
                parentLinearLayout.AddView(listView);
                scrollView.Post(() =>
                {
                    scrollView.SmoothScrollTo(0, newLinearLayout.Top);
                });

                listView.ItemClick += async (sender, args) =>
                {
                    var selectedResponse = responseList[args.Position];
                    CreateUserMessage(selectedResponse);
                    var selectedNode = symptom.responses[selectedResponse];
                    HidePopup();
                    if (selectedNode != null)
                    {
                        if (selectedNode.responses != null)
                        {
                            UpdateQuestionAndAnswers(selectedNode);
                        }
                        else
                        {
                            var diagnosis = selectedNode.diagnosis;
                            var recommendation = selectedNode.recommendation;
                            await Task.Delay(500);
                            CreateChatBotResponse($"Diagnosis: {diagnosis}");
                            await Task.Delay(500);
                            CreateChatBotResponse($"Recommendation: {recommendation}");
                            await Task.Delay(800);
                            CreateChatBotResponse("Let's start with the symptom that's troubling you the most. ");
                            await Task.Delay(500);
                            askDetails();
                        }
                    }
                };
            }
        }

        private async Task InitializeCategories()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync("http://192.168.254.148:8080/admin/api.php");
                    response.EnsureSuccessStatusCode();
                    var json = await response.Content.ReadAsStringAsync();
                    //Console.WriteLine(json);
                    categories = JsonConvert.DeserializeObject<Dictionary<string, Symptom>>(json);
                    Console.WriteLine(categories.Count);
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}