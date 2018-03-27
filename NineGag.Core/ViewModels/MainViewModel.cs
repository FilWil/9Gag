using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace NineGag.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        public MainViewModel()
        {
            Photos = new MvxObservableCollection<Photo>
            {
                new Photo
                {
                    Url = "https://www.cosslodkiego.com.pl/pol_pl_Coca-Cola-Vanilla-549_1.png",
                    Likes = 10,
                    Dislikes = 5
                },
                new Photo
                {
                    Url = "https://www.pepsi.com/en-us/uploads/images/can-pepsi.png",
                    Likes = 20,
                    Dislikes = 10
                }
            };
        }

        public MvxObservableCollection<Photo> Photos{get;}

        public override Task Initialize()
        {
            //TODO: Add starting logic here
		    
            return base.Initialize();
        }
        
        public IMvxCommand ResetTextCommand => new MvxCommand(ResetText);
        private void ResetText()
        {
            Text = "Hello MvvmCross";
        }

        private string _text = "Hello MvvmCross";
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }
    }
}