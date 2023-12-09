using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Mediacal_Diagnosis.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Mediacal_Diagnosis.ViewModels
{
    public class AuthViewModel
    {
        public async Task<string> AuthenticateUserAsync(ProfileModel profile)
        {
            using (var client = new HttpClient())
            {   
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("username", profile.Email),
                    new KeyValuePair<string, string>("password", profile.Password)
                });
                var response = await client.PostAsync("https://ccsandroidapplication.000webhostapp.com/login.php", content);

                if(response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    return result.Trim();
                }else { return "failed"; }

            }
        }
        public async Task<string> RegisterUserAsync(ProfileModel profileModel)
        {
            using (var client = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string> ("fullname", profileModel.Name), 
                    new KeyValuePair<string, string>("username", profileModel.Email),
                    new KeyValuePair<string, string>("phone", profileModel.Phone),
                    new KeyValuePair<string, string> ( "password", profileModel.Password )
                });
                var response = await client.PostAsync("https://ccsandroidapplication.000webhostapp.com/register.php", content);
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content?.ReadAsStringAsync();
                    return result.Trim() ;
                }
                else
                {
                    return "failed";
                }
            }
        }
    }
}