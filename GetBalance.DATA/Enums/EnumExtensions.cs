using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetBalance.DATA.Enums
{
    public static class EnumExtensions
    {
        public static string DisplayName(this Enum value)
        {
            var displayAttribute = value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(DisplayAttribute), false) as DisplayAttribute[];

            return displayAttribute != null && displayAttribute.Length > 0 ? displayAttribute[0].Name : value.ToString();
        }
    }
}
