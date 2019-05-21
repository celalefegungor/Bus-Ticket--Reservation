using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyager.Entities
{
    public enum Gender
    {
        [Display(Name = "Belirsiz")]
        None = 0,
        [Display(Name = "Kadın")]
        Female = 1,
        [Display(Name = "Erkek")]
        Male = 2
    }
    public enum LicenseType
    {
        None = 0,
        NormalLicense,
        HighLicense
    }
}
