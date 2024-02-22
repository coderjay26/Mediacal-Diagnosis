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
    public class SymptomsRequestModel
    {
        public string module { get; set; }
        public string request { get; set; }
        public CategoryData data { get; set; }
    }
}