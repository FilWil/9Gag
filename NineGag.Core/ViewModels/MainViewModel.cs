using System.Diagnostics;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using System.Windows.Input;

namespace NineGag.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        public MvxObservableCollection<PhotoViewModel> Photos { get; }
        public MvxObservableCollection<CommentViewModel> Comments { get; }

        public MainViewModel()
        {
            Photos = new MvxObservableCollection<PhotoViewModel>
            {
                new PhotoViewModel
                {
                    Url = "https://www.cosslodkiego.com.pl/pol_pl_Coca-Cola-Vanilla-549_1.png",
                    Likes = 0,
                    CommentsCounter = 0
                },
                new PhotoViewModel
                {
                    Url = "https://www.pepsi.com/en-us/uploads/images/can-pepsi.png",
                    Likes = 0,
                    CommentsCounter = 0
                }
            };
        }

        public override Task Initialize()
        {
            //TODO: Add starting logic here
		    
            return base.Initialize();
        }

    }
}