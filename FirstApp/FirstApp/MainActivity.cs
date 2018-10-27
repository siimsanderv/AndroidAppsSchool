using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace FirstApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            //var firstTextView = FindViewById<TextView>(Resource.Id.textView1);
            var toSecondActivity = FindViewById<Button>(Resource.Id.button1);

            //var toWebViewActivity = FindViewById<Button>(Resource.Id.webView);

            toSecondActivity.Click += delegate
            {
                var secondActivity = new Intent(this, typeof(SecondActivity));
                secondActivity.PutExtra("MyData", "Hello world!");
                StartActivity(secondActivity);
            };

            /*toWebViewActivity.Click += delegate{
            var webViewActivity = new Intent*/


           
        }
    }
}