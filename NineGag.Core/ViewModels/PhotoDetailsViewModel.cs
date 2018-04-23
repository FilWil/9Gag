using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using NineGag.Core.Models;

namespace NineGag.Core.ViewModels
{
    public class PhotoDetailsViewModel : BaseViewModel<PhotoId>
    {
        private string _newComment;
        public MvxObservableCollection<Comment> Comments { get; }

        public PhotoDetailsViewModel()
        {
            Comments = new MvxObservableCollection<Comment>();
        }

        public string NewComment
        {
            get => _newComment;
            set => SetProperty(ref _newComment, value);
        }

        public IMvxCommand SendCommentCommand => new MvxCommand(() =>
        {
            var comment = new Comment
            {
                Id = 0,
                Content = NewComment,
                Points = 0,
                PostDate = DateTimeOffset.Now,
                Author = new User
                {
                    Id = 0,
                    AvatarUrl = "https://www.pepsi.com/en-us/uploads/images/can-pepsi.png",
                    Name = "Filip",
                    Surname = "Wilczura",
                    Nickname = "Filip"
                }
            };

            NewComment = string.Empty;
            Comments.Add(comment);
        });

        public override void Prepare(PhotoId parameter)
        {
            
        }
    }
}
