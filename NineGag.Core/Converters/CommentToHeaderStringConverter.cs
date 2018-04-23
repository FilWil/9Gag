using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Platform.Converters;
using NineGag.Core.Models;

namespace NineGag.Core.Converters
{
    public class CommentToHeaderStringConverter : MvxValueConverter<Comment, string>
    {
        protected override string Convert(Comment value, Type targetType, object parameter, CultureInfo culture)
        {
            return $"Author: {value.Author.Nickname} Posted on: {value.PostDate.LocalDateTime.ToLocalTime()}";
        }
    }
}
