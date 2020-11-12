using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using System.Drawing;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Color = Xamarin.Forms.Color;

namespace ProjetoItau.Droid
{
    [Activity(Label = "ProjetoItau", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        WindowManagerFlags _originalFlags;

        protected override void OnCreate(Bundle savedInstanceState)
        {            

            var attrs = this.Window.Attributes;
            var hide = true;

            if (hide)
            {
                _originalFlags = attrs.Flags;
                attrs.Flags |= Android.Views.WindowManagerFlags.Fullscreen;
                this.Window.Attributes = attrs;
            }
            else
            {
                attrs.Flags = _originalFlags;
                this.Window.Attributes = attrs;
            }



            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}