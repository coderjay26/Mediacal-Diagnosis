using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Views;
using Android.Widget;
using Google.Android.Material.TextField;
using Mediacal_Diagnosis.Model;
using Mediacal_Diagnosis.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediacal_Diagnosis.Activities
{
    [Activity(Label = "RegisterActivity", NoHistory = true)]
    public class RegisterActivity : Activity
    {
        TextView login;
        Button regBtn;
        TextInputEditText name, email, phone, password;
        AuthViewModel authViewModel;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.register_screen);
            login = FindViewById<TextView>(Resource.Id.login_now);
            regBtn = FindViewById<Button>(Resource.Id.regBtn);
            name = FindViewById<TextInputEditText>(Resource.Id.fullNameRegister);
            email = FindViewById<TextInputEditText> (Resource.Id.emailRegister);
            phone = FindViewById<TextInputEditText>(Resource.Id.phoneRegister);
            password = FindViewById<TextInputEditText>(Resource.Id.passwordRegister);


            email.TextChanged += TextChange;
            password.TextChanged += TextChange;
            name.TextChanged += TextChange;
            phone.TextChanged += TextChange;

            //Initialize authViewModel
            authViewModel = new AuthViewModel();

            regBtn.Click += async (sender, e) =>
            {
                regBtn.Enabled = false;

                var user = new ProfileModel
                {
                    Name = name.Text,
                    Email = email.Text,
                    Phone = phone.Text,
                    Password = password.Text
                };
                var result = await authViewModel.RegisterUserAsync(user);

                if (result == "success")
                { 
                    Intent intent = new Intent(this, typeof(HomeScreen));
                    StartActivity(intent);
                }
                else
                {
                    Toast.MakeText(this, "Register Failed!", ToastLength.Short).Show();
                    regBtn.Enabled = true;
                }
            };

            login.Click += (object sender, EventArgs e) =>
            {
                Intent intent = new Intent(this, typeof(LoginActivity));
                StartActivity(intent);
            };
        }
        private async void TextChange(object sender, TextChangedEventArgs e)
        {
            bool isEmailEmpty = string.IsNullOrEmpty(email.Text);
            bool isPasswordEmpty = string.IsNullOrEmpty(password.Text);
            bool isNameEmpty = string.IsNullOrEmpty(name.Text);
            bool isPhoneEmty = string.IsNullOrEmpty(phone.Text);

            regBtn.Enabled = !(isEmailEmpty && isPasswordEmpty && isNameEmpty && isPhoneEmty);
        }
    }
}