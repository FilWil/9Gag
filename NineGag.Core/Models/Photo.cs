using System.ComponentModel;
using System.Runtime.CompilerServices;
using MvvmCross.Core.ViewModels;
using NineGag.Core.Annotations;

namespace NineGag.Core.Models
{
    public class Photo : BindableObject
    {
        #region Commands
        public IMvxCommand VoteUpCommand => new MvxCommand(VoteUp);
        public IMvxCommand VoteDownCommand => new MvxCommand(VoteDown);        
        #endregion

        #region Variables
        private int _likes;
        private int _commentsCounter;
        #endregion

        #region Properties
        public string Url { get; set; }

        public int Id { get; set; }

        public int Likes
        {
            get => _likes;
            set
            {
                if (value == _likes) return;
                _likes = value;
                OnPropertyChanged();
            }
        }

        public int CommentsCounter
        {
            get => _commentsCounter;
            set
            {
                if (value == _commentsCounter) return;
                _commentsCounter = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Methods
        public void VoteUp()
        {
            Likes++;
        }

        public void VoteDown()
        {
            Likes--;
        }
        #endregion  

    }
}
