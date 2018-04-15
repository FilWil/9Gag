using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace NineGag.Views
{
    [Activity(Label = "Comments")]
    public class CommentView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.CommentView);
        }
    }
}