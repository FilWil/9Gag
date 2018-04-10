using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using NineGag.Core.Annotations;

namespace NineGag.Core.ViewModels
{
    public class Photo : INotifyPropertyChanged
    {
        private int _likes;

        public string Url { get; set; }

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

        public void VoteUp()
        {
            Likes++;
        }

        public void VoteDown()
        {
            Likes--;
        }

        public IMvxCommand VoteUpCommand => new MvxCommand(VoteUp);
        public IMvxCommand VoteDownCommand => new MvxCommand(VoteDown);
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
