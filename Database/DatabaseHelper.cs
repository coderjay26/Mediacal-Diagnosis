using Android.App;
using Android.Content;
using Android.Database;
using Android.Database.Sqlite;
using Android.Nfc;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Mediacal_Diagnosis.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mediacal_Diagnosis.Database
{
    public class DatabaseHelper : SQLiteOpenHelper
    {
        static readonly string TAG = "X:" + typeof(MainActivity).Name;
        public DatabaseHelper(Context context) : base(context, Medical.DbName, null, 1) 
        {
        }
        public override void OnCreate(SQLiteDatabase db)
        {
            db.ExecSQL("CREATE TABLE IF NOT EXISTS Profiles (Id INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT, Description TEXT);");
        }
        public void InsertProfile(ProfileModel profile)
        {
            SQLiteDatabase db = this.WritableDatabase;
            ContentValues contentValues = new ContentValues();
            contentValues.Put("Name", profile.Name);
            contentValues.Put("Description", profile.Description);

            db.Insert("Profiles", null, contentValues);
            db.Close();
            Log.Debug(TAG, "Success");
            Console.WriteLine(profile.Name);
        }

        public override void OnUpgrade(SQLiteDatabase db, int oldVersion, int newVersion)
        {
            throw new NotImplementedException();
        }
        public List<ProfileModel> GetAllProfiles() 
        {
            List<ProfileModel> profiles = new List<ProfileModel>();
            SQLiteDatabase db = this.ReadableDatabase;

            ICursor cursor = db.RawQuery("SELECT * FROM Profiles", null);
            cursor.MoveToFirst();

            while (!cursor.IsAfterLast)
            {
                ProfileModel profileModel = new ProfileModel
                {
                    Id = cursor.GetInt(cursor.GetColumnIndex("Id")),
                    Name = cursor.GetString(cursor.GetColumnIndex("Name")),
                    Description =  cursor.GetString(cursor.GetColumnIndex("Description")),
                };
                profiles.Add(profileModel);
                cursor.MoveToNext();
            }
            cursor.Close();
            db.Close();

            return profiles;
        }
    }
}