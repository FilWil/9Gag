using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineGag.Core.Models
{
    public class User
    {
        #region Properties

        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Nickname { get; set; }

        public string AvatarUrl { get; set; }

        #endregion
    }
}
