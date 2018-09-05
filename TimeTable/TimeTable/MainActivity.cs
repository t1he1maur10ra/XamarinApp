using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace TimeTable
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var btnMon11 = FindViewById<Button>(Resource.Id.btnMon11);
            btnMon11.Click += BtnMon11_Click;
            var btnMon10 = FindViewById<Button>(Resource.Id.btnMon10);
            btnMon10.Click += BtnMon10_Click;

        }

        private void BtnMon10_Click(object sender, System.EventArgs e)
        {
            FindViewById<TextView>(Resource.Id.txtRooms).Text = "DT308 | Jake the Muss";
        }

        private void BtnMon11_Click(object sender, System.EventArgs e)
        {
            FindViewById<TextView>(Resource.Id.txtRooms).Text = "DT308 | Jacob Van Silfhout";
        }
    }
}