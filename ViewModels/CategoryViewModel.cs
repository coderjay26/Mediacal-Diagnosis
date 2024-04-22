using Android.App;
using Android.Content;
using Android.Nfc;
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
using Newtonsoft.Json.Linq;
using Org.Json;

namespace Mediacal_Diagnosis.ViewModels
{
    public class CategoryViewModel
    {
        string TAG = "JAY:";
        string url = "http://192.168.254.148:8080/";
        public async Task<string> getSymptoms(CategoryModel categories)
        {
            if (categories == null || string.IsNullOrEmpty(categories.Category))
            {
                Console.WriteLine("Failed");
                return "failed"; // or throw an exception, depending on your logic
            }
            Console.WriteLine(categories.Category);
            using (var client = new HttpClient())
            {

                SymptomsRequestModel content = new SymptomsRequestModel()
                {
                    module = "diagnose",
                    request = "symptoms",
                    data = new CategoryData()
                    {
                        category = categories.Category
                    }

                };

                //serialize the object
                string requestData = Newtonsoft.Json.JsonConvert.SerializeObject(content);
                //create a string content
                requestData = requestData.Trim('"');
                var stringContent = new StringContent(requestData, Encoding.UTF8, "application/json");
                
                //request
                try
                {
                    var response = await client.PostAsync(url, stringContent);

                    if (response.IsSuccessStatusCode)
                    {
                       Console.WriteLine("Sulodddddddddddddddddddddd");
                        // Read the response content as a byte array
                        byte[] contentBytes = await response.Content.ReadAsByteArrayAsync();

                        // Convert the byte array to a string using UTF-8 encoding
                        string jsonResponse = Encoding.UTF8.GetString(contentBytes);

                       
                        var result = JsonConvert.DeserializeObject<CategoryResponse>(jsonResponse);

                        foreach (var symptomsData in result.data)
                        {
                            // Access the symptoms property of each SymptomsDataByCategory object
                            foreach (var symptom in symptomsData.Symptoms)
                            {
                                Console.WriteLine(symptom);
                            }
                        }
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
        public async Task<string> getRecommendation(SymptomsModel symptomsModel)
        {
            using (var client = new HttpClient())
            {
                RecommendationRequestModel request = new RecommendationRequestModel
                {
                    module = "diagnose",
                    request = "diagnose",
                    data = symptomsModel
                };
                string requestData = Newtonsoft.Json.JsonConvert.SerializeObject(request);
                var stringContent = new StringContent(requestData, Encoding.UTF8, "application/json");
                //request
              
                try
                {
                    var response = await client.PostAsync(url, stringContent);

                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Sulodddddddddddddddddddddd");
                        // Read the response content as a byte array
                        byte[] contentBytes = await response.Content.ReadAsByteArrayAsync();

                        // Convert the byte array to a string using UTF-8 encoding
                        string jsonResponse = Encoding.UTF8.GetString(contentBytes);

                        //Console.WriteLine($"Response {jsonResponse}");
                        return jsonResponse;
                        var result = JsonConvert.DeserializeObject<CategoryResponse>(jsonResponse);

                        foreach (var symptomsData in result.data)
                        {
                            // Access the symptoms property of each SymptomsDataByCategory object
                            foreach (var symptom in symptomsData.Symptoms)
                            {
                                Console.WriteLine(symptom);
                            }
                        }
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
    }
}