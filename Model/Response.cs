using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediacal_Diagnosis.Model
{
    public class Response
    {
        public string question { get; set; }
        public Dictionary<string, Response> responses { get; set; }
        public string diagnosis { get; set; }
        public string recommendation { get; set; }
    }
}