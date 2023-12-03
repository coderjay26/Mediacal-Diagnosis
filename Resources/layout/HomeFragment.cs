using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Mediacal_Diagnosis.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediacal_Diagnosis.Resources.layout
{
    [Obsolete]
    public class HomeFragment : AndroidX.Fragment.App.Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            View view = inflater.Inflate(Resource.Layout.home_screen, container, false);

            Button button = view.FindViewById<Button>(Resource.Id.start_assesment);

            button.Click += (s, e) =>
            {
                Intent u = new Intent(Activity, typeof(Assessment));

                StartActivity(u);
            };

            return view;

            //return base.OnCreateView(inflater, container, savedInstanceState);

        }
    }
}