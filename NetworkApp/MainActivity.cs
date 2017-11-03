using Android.App;
using Android.Widget;
using Android.OS;
using Core;

namespace NetworkApp
{
    [Activity(Label = "NetworkApp", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            EditText text = FindViewById<EditText>(Resource.Id.addressField);
            Button button = FindViewById<Button>(Resource.Id.myButton);
            TextView txtView = FindViewById<TextView>(Resource.Id.textView1);

            button.Click += (sender, e) =>
            {
                string newtext = Core.TextChanger.ChangeText(text.Text);
                txtView.Text = newtext;
            };
        }
    }
}

