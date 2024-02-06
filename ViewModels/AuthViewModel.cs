using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Javax.Net.Ssl;
using Mediacal_Diagnosis.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Mediacal_Diagnosis.ViewModels
{
    public class AuthViewModel
    {
        string TAG = "Log:";
        string url = "http://192.168.254.148:8000/";
        public async Task<string> AuthenticateUserAsync(ProfileModel profile)
        {

            using (var client = new HttpClient())
            {
                //Instantiate LoginRequestModel and Create Json to use in body for Login Request
                LoginRequestModel content = new LoginRequestModel()
                {
                    module = "user",
                    request = "login",
                    data = new UserDataModel()
                    {
                        username = profile.Email,
                        password = profile.Password
                    }
                   
                };
                //serialize the object
                string requestData = Newtonsoft.Json.JsonConvert.SerializeObject(content);
                //create a string content
                var stringContent = new StringContent(requestData, Encoding.UTF8, "application/json");

                //request
                try
                {
                    var response = await client.PostAsync(url, stringContent);

                    if (response.IsSuccessStatusCode)
                    {
                        Log.Debug(TAG, "MISULOD");
                        // Read the response content as a byte array
                        byte[] contentBytes = await response.Content.ReadAsByteArrayAsync();

                        // Convert the byte array to a string using UTF-8 encoding
                        string jsonResponse = Encoding.UTF8.GetString(contentBytes);

                        var result = JsonConvert.DeserializeObject<ApiResponse>(jsonResponse);

                        if (result != null && result.success)
                        {
                            return jsonResponse;
                        }
                        else
                        {
                            Log.Debug(TAG, "Walay success");
                            return "failed";
                        }
                    }
                    else
                    {
                        Log.Debug(TAG, "Error statuscode");
                        return "failed";
                    }
                }
                catch (Exception ex)
                {
                    Log.Debug(TAG, ex.ToString());
                    return "failed";
                }

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