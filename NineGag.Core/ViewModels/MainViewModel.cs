using System.Diagnostics;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace NineGag.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        public MvxObservableCollection<Photo> Photos { get; }

        public MainViewModel()
        {
            Photos = new MvxObservableCollection<Photo>
            {
                new Photo
                {
                    Url = "https://www.cosslodkiego.com.pl/pol_pl_Coca-Cola-Vanilla-549_1.png",
                    Likes = 0
                },
                new Photo
                {
                    Url = "https://www.pepsi.com/en-us/uploads/images/can-pepsi.png",
                    Likes = 0
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