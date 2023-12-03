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
using System.Text;

namespace Mediacal_Diagnosis.ViewModels
{
    public interface IProfileDataListener
    {
        void OnProfileDataChanged(List<ProfileModel> updateList);
    }
}