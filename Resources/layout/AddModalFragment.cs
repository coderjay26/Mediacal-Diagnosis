using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using AndroidX.Lifecycle;
using Google.Android.Material.TextField;
using Mediacal_Diagnosis.Database;
using Mediacal_Diagnosis.Model;
using Mediacal_Diagnosis.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Android.Provider.ContactsContract;

namespace Mediacal_Diagnosis.Resources.layout
{
    
    [Obsolete]
    public class AddModalFragment : AndroidX.Fragment.App.DialogFragment
    {
       
        public List<ProfileModel> Profiles;
        public List<ProfileModel> Profiless;
        ProfileAdapter adapter;
        DatabaseHelper databaseHelper;
        IProfileDataListener profileDataListener;
        TextInputEditText name, description;
        public AddModalFragment(List<ProfileModel> profiles, IProfileDataListener listener)
        {
            Profiles = profiles;
            profileDataListener = listener;
        }
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            databaseHelper = new DatabaseHelper(Activity);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.add_profile_view, container, false);

            Button addProfile = view.FindViewById<Button>(Resource.Id.add_profile);
            name = view.FindViewById<TextInputEditText>(Resource.Id.fullNameCreate);
            description = view.FindViewById<TextInputEditText>(Resource.Id.description);
            Profiless ??= new List<ProfileModel>();

            adapter = new ProfileAdapter(Activity, Profiles);
            addProfile.Click += AddProf;
            return view;
        }
        private void AddProf(object sender, EventArgs e)
        {
            string profileName = name.Text;
            string profileDescription = description.Text;

            SaveProfile(new ProfileModel { Name = profileName, Description = profileDescription });
            // Add the profile to the list
            Profiless.Add(new ProfileModel { Name = profileName, Description = profileDescription });

            profileDataListener.OnProfileDataChanged(Profiless);
            adapter.NotifyDataSetChanged();
            Task.Delay(1000);
            Dismiss();
        }
        private void SaveProfile(ProfileModel profileModel)
        {
            databaseHelper.InsertProfile(profileModel);
        }
    }
}