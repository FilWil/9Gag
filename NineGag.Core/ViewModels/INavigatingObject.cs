using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace NineGag.Core.ViewModels
{
    public interface INavigatingObject
    {
        bool Navigate<TViewModel, TParameter>
            (TParameter parameter, IMvxBundle presentationBundle = null)
            where TViewModel : IMvxViewModel<TParameter>
            where TParameter : class;
    }
}
