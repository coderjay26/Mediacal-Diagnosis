﻿using Android.App;
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
    public class CategoryResponse
    {
        public bool success { get; set; }
        public List<SymptomsDataByCategory> data { get; set; }
    }
}