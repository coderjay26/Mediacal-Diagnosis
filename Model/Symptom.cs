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
    public class Symptom
    {
        public string question { get; set; }
        public Dictionary<string, Symptom> responses { get; set; }
        public string diagnosis { get; set; }
        public string recommendation { get; set; }
    }
}