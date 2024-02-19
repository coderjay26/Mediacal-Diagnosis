using Android.App;
using Android.Content;
using Android.Nfc;
using Android.OS;
using Android.Preferences;
using Android.Runtime;
using Android.Util;
using AndroidX.AppCompat.App;
using Mediacal_Diagnosis.Activities;
using System.Threading;
using System.Threading.Tasks;

namespace Mediacal_Diagnosis
{
    [Activity(Label = "@string/app_name", Theme = "@style/Theme.Splash", MainLauncher = true, NoHistory =true)]
    public class MainActivity : Activity
    {
        static readonly string TAG = "X:" + typeof(MainActivity).Name;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        protected override void OnResume()
        {
            base.OnResume();
            SetContentView(Resource.Layout.splash_view);
            Task startupWork = new Task(() => { SimulateStartup(); });
            startupWork.Start();
        }

        [System.Obsolete]
        async void SimulateStartup()
        {
            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(this);
            bool isFirstTIme = prefs.GetBoolean("firstTime", true);

            Intent intent;
            if (isFirstTIme)
            {
                ISharedPreferencesEditor editor = prefs.Edit();
                editor.PutBoolean("firstTime", false);
                editor.Apply();

                intent = new Intent(this, typeof(HomeScreen));
            }
            else
            {
                intent = new Intent(this, typeof(HomeScreen));
            }
            Log.Debug(TAG, "Performing some startup work that takes a bit of time.");
            await Task.Delay(3000); 
            Log.Debug(TAG, "Startup work is finished - starting MainActivity.");

            StartActivity(intent);
        }
    }
}