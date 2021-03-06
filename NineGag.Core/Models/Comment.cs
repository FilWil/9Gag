﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;
using NineGag.Core.Annotations;

namespace NineGag.Core.Models
{
    public class Comment : MvxViewModel, INotifyPropertyChanged
    {
        public IMvxCommand SendCommentCommand => new MvxCommand(() =>
        {

        });
        
        #region Events
        public new event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Variables
        private int _points;
        #endregion

        #region Properties

        public int Id { get; set; }

        public User Author { get; set; }

        public int Points
        {
            get => _points;
            set
            {
                if (value == _points) return;
                _points = value;
                OnPropertyChanged();
            }
        }

        public string Content { get; set; }

        public DateTimeOffset PostDate { get; set; }


        #endregion

        #region Methods

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

    }
}
