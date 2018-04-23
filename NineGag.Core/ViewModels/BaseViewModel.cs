using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace NineGag.Core.ViewModels
{
    public abstract class BaseViewModel<TParameter> : MvxViewModel<TParameter>, INavigatingObject
    {
        public bool Navigate<TViewModel, TParameter1>
            (TParameter1 parameter, IMvxBundle presentationBundle = null)
            where TViewModel : IMvxViewModel<TParameter1>
            where TParameter1 : class
        {
            return ShowViewModel<TViewModel, TParameter1>(parameter, presentationBundle);
        }
    }
}
