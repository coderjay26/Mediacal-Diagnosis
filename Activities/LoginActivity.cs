using Android.App;
using Android.Content;
using Android.Nfc;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Util;
using Android.Views;
using Android.Widget;
using Google.Android.Material.TextField;
using Mediacal_Diagnosis.Model;
using Mediacal_Diagnosis.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Mediacal_Diagnosis.Activities
{
    [Activity(Label = "LoginActivity", NoHistory = true)]
    public class LoginActivity : Activity
    {
        string TAG = "Log: ";
        TextView loginBtn;
        TextInputEditText email, password;
        Button btn;
        private AuthViewModel viewModel;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


            // Create your application here
            SetContentView(Resource.Layout.login_screen);
            loginBtn = FindViewById<TextView>(Resource.Id.reg_now);
            email = FindViewById<TextInputEditText>(Resource.Id.emailLogin);
            password = FindViewById<TextInputEditText> (Resource.Id.passwordLogin);

            //Initialize the AuthViewModel
            viewModel = new AuthViewModel();

            email.TextChanged += TextChange;
            password.TextChanged += TextChange;

            loginBtn.Click += RegisterNow;

            btn = FindViewById<Button>(Resource.Id.btnLogin);
            btn.Click += async(object sender, EventArgs e) =>
            {
                btn.Enabled = false;
                var user = new ProfileModel
                {
                    Email = email.Text,
                    Password = password.Text,
                };
                var result = await viewModel.AuthenticateUserAsync(user);

               try
{
                    var jsonResult = JsonConvert.DeserializeObject<ApiResponse>(result);


                    if (jsonResult.success)
                    {
                        Log.Debug(TAG, result);
                        Intent intent = new Intent(this, typeof(HomeScreen));
                        StartActivity(intent);
                    }
                    else
                    {
                        Toast.MakeText(this, "Login Failed!", ToastLength.Long).Show();
                        btn.Enabled = true;
                    }
                }catch (JsonReaderException ex)
                {
                    Toast.MakeText(this, "Login Failed!", ToastLength.Long).Show();
                    btn.Enabled = true;
                }
                
            };
        }


        private async void TextChange(object sender, TextChangedEventArgs e)
        {
            bool isEmailEmpty = string.IsNullOrEmpty(email.Text);
            bool isPasswordEmpty = string.IsNullOrEmpty(password.Text);

            btn.Enabled = !(isEmailEmpty && isPasswordEmpty);
        }

        private void RegisterNow(object sender, EventArgs e)
        {
           Intent intent = new Intent(this, typeof(RegisterActivity));
           StartActivity(intent);
        }
    }
}