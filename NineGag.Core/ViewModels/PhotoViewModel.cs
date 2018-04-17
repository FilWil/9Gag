using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;
using NineGag.Core.Annotations;

namespace NineGag.Core.ViewModels
{
    public class PhotoViewModel : MvxViewModel, INotifyPropertyChanged
    {
        #region Commands
        public IMvxCommand VoteUpCommand => new MvxCommand(VoteUp);
        public IMvxCommand VoteDownCommand => new MvxCommand(VoteDown);
        public IMvxCommand GoCommentsCommand => new MvxCommand(() => ShowViewModel<CommentViewModel>());
        #endregion

        #region Events
        public new event PropertyChangedEventHandler PropertyChanged;
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

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }
}
