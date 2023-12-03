using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Java.Util;
using Mediacal_Diagnosis.Activities;
using Mediacal_Diagnosis.Database;
using Mediacal_Diagnosis.Model;
using Mediacal_Diagnosis.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediacal_Diagnosis.Resources.layout
{
    [Obsolete]
    public class ProfileFragment : AndroidX.Fragment.App.Fragment, IProfileDataListener
    {
        string TAG = "JAy";
        private ProfileAdapter profileAdapter;
        private List<ProfileModel> profiles;
        DatabaseHelper databaseHelper;
        ListView listView;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Additional initialization code if needed
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.profile_screen, container, false);

            ImageButton btn = view.FindViewById<ImageButton>(Resource.Id.add_profile_btn);
            listView = view.FindViewById<ListView>(Resource.Id.profile_list_view);
            databaseHelper = new DatabaseHelper(Activity);
            profiles = databaseHelper.GetAllProfiles();

            // Initialize the profile adapter
            profileAdapter = new ProfileAdapter(Activity, profiles);
            listView.Adapter = profileAdapter;
            profileAdapter.NotifyDataSetChanged();

            btn.Click += AddProfile;

            return view;
        }

        // This method will be called from AddModalFragment when data changes
        public void OnProfileDataChanged(List<ProfileModel> updatedProfiles)
        {
            // Update the data and refresh the adapter
            Log.Debug(TAG, "TAGGAGAG");
            profiles.AddRange(updatedProfiles);
            profileAdapter.NotifyDataSetChanged();
            profileAdapter = new ProfileAdapter(Activity, profiles);
            listView.Adapter = profileAdapter;
        }

        private void AddProfile(object sender, EventArgs e)
        {
            AddModalFragment modalFragment = new AddModalFragment(profiles, this);
            modalFragment.Show(ChildFragmentManager, "modal_fragment_manager");
        }
    }

}