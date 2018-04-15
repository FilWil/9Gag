using Android.App;
using Android.OS;
using MvvmCross.Droid.Support.V7.RecyclerView;
using MvvmCross.Droid.Views;

namespace NineGag.Views
{
    [Activity(Label = "NineGag")]
    public class MainActivity : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainView);
        }
    }
}
