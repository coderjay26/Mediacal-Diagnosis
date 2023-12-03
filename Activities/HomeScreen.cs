using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.BottomNavigation;
using Mediacal_Diagnosis.Resources.layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediacal_Diagnosis.Activities
{
    [Activity(Label = "HomeScreen")]
    [Obsolete]
    public class HomeScreen : AppCompatActivity, BottomNavigationView.IOnNavigationItemSelectedListener
    {
        FrameLayout fragmentContainer;
        BottomNavigationView navigation;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
           
            
        }
        protected override void OnResume()
        {
            base.OnResume();
            SetContentView(Resource.Layout.tab);

            fragmentContainer = FindViewById<FrameLayout>(Resource.Id.fragmentContainer);
            navigation = FindViewById<BottomNavigationView>(Resource.Id.navigation);
            navigation.SetOnNavigationItemSelectedListener(this);
            LoadFragment(new HomeFragment());

        }
        public bool OnNavigationItemSelected(IMenuItem item)
        {

            switch (item.ItemId)
            {
                case Resource.Id.navigation_home:
                    LoadFragment(new HomeFragment());
                    return true;
                case Resource.Id.navigation_profile:
                    LoadFragment(new ProfileFragment());
                    return true;
            }
            return false;
        }
        private void LoadFragment(AndroidX.Fragment.App.Fragment fragment)
        {
            if(fragment != null)
            {
                SupportFragmentManager.BeginTransaction()
                    .Replace(Resource.Id.fragmentContainer, fragment) 
                    .Commit();
            }
        }
    }
}