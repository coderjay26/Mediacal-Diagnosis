using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediacal_Diagnosis.Activities
{

    [Activity(Label = "HomeAcivity")]
    public class HomeAcivity : Activity
    {
        ImageView _imageView;
        private int currIndex = 1;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //SetContentView  
            SetContentView(Resource.Layout.slide_screen_1);
           _imageView = FindViewById<ImageView>(Resource.Id.nxtbtn);
            _imageView.Click += SwitchLayout;
        }
        private async void SwitchLayout(object sender, EventArgs e)
        {
            currIndex = (currIndex % 4) + 1;
            int indexLayout = Resource.Layout.slide_screen_1;
            if(currIndex == 2)
            {
                indexLayout = Resource.Layout.slide_screen_2;
            }else if(currIndex == 3)
            {
                indexLayout = Resource.Layout.slide_screen_final;
            }
            else if(currIndex == 4)
            {
                Intent intent = new Intent(this,typeof(LoginActivity));
                StartActivity(intent);
                await Task.Delay(1000);
            }
            SetContentView(indexLayout);
            ImageView imageView = FindViewById<ImageView>(Resource.Id.nxtbtn);
            imageView.Click += SwitchLayout;
        }
        public override void OnConfigurationChanged(Android.Content.Res.Configuration newConfig)
        {
            base.OnConfigurationChanged(newConfig);
            RequestedOrientation = ScreenOrientation.Portrait;
        }
    }

}