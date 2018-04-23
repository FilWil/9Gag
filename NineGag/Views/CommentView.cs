using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;
using NineGag.Core.ViewModels;

namespace NineGag.Views
{
    [Activity(Label = "Comments")]
    public class CommentView : MvxActivity<PhotoDetailsViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.CommentView);
        }
    }
}