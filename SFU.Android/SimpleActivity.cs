using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using SFU.Services;

namespace SFU.Android
{
    [Activity(Label = "SFU.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class SimpleActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //reach into the linked shared code to create a service!
            var service = new SimpleService();

            // Get our button from the layout resource,
            // and attach an event to it
            var button = FindViewById<Button>(Resource.Id.MyButton);
            button.Click += delegate { button.Text = string.Format("{0} clicks!", service.SimpleProp++); };
        }
    }
}

