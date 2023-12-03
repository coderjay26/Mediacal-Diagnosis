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

namespace Mediacal_Diagnosis
{
    internal class ProfileAdapter : BaseAdapter<ProfileModel>
    {

        Context context;
        private List<ProfileModel> _profiles;

        public ProfileAdapter(Context context, List<ProfileModel> _profiles)
        {
            this.context = context;
            this._profiles = _profiles;
        }


        public override Java.Lang.Object GetItem(int position)
        {
            return position;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView ?? LayoutInflater.From(context).Inflate(Resource.Layout.profile_list_view, null);
            TextView name = view.FindViewById<TextView>(Resource.Id.profile_list_name);
            TextView description = view.FindViewById<TextView>(Resource.Id.profile_list_description);

            ProfileModel profile = _profiles[position];
            name.Text = profile.Name;
            description.Text = profile.Description;


            return view;
        }

        //Fill in cound here, currently 0
        public override int Count => _profiles.Count;

        public override ProfileModel this[int position] => _profiles[position];
    }

    internal class ProfileAdapterViewHolder : Java.Lang.Object
    {
        //Your adapter views to re-use
        //public TextView Title { get; set; }
    }
}