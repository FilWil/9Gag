using System.Diagnostics;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using System.Windows.Input;
using NineGag.Core.Models;

namespace NineGag.Core.ViewModels
{
 
    public class MainViewModel : BaseViewModel<string>
    {
        public MvxObservableCollection<Photo> Photos { get; }

        public IMvxCommand PhotoSelectedCommand => new MvxCommand<Photo>(photo =>
            {
                this.Navigate<PhotoDetailsViewModel, PhotoId>(new PhotoId {Id = photo.Id});
            });

        public MainViewModel()
        {
            Photos = new MvxObservableCollection<Photo>
            {
                new Photo
                {
                    Url = "https://www.cosslodkiego.com.pl/pol_pl_Coca-Cola-Vanilla-549_1.png",
                    Likes = 0,
                    Id = 1,
                    CommentsCounter = 0
                },
                new Photo
                {
                    Url = "https://www.pepsi.com/en-us/uploads/images/can-pepsi.png",
                    Likes = 0,
                    Id = 2,
                    CommentsCounter = 0
                }
            };
        }



        public override Task Initialize()
        {
            //TODO: Add starting logic here
		    
            return base.Initialize();
        }

        public override void Prepare(string parameter)
        {
            
        }
    }

}