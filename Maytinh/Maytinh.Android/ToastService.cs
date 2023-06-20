using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Graphics;
using Android.Widget;
using Maytinh.Droid;
using Xamarin.Forms;
using Color = Android.Graphics.Color;

[assembly: Dependency(typeof(ToastService))]

namespace Maytinh.Droid
{
    public class ToastService : IToastService
    {
        public void ShowToast(string message)
        {
            //Toast.MakeText(Android.App.Application.Context, message, ToastLength.Short).Show();
            Toast t = Toast.MakeText(Android.App.Application.Context, message, ToastLength.Short);
            Color c = Color.Gray;
            ColorMatrixColorFilter CM = new ColorMatrixColorFilter(new float[]
                {
                    0,0,0,0,c.R,
                    0,0,0,0,c.G,
                    0,0,0,0,c.B,
                    0,0,0,1,0
                });
            t.View.Background.SetColorFilter(CM);
            t.Show();
        }
    }
}