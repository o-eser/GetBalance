using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetBalance.DATA.Enums
{
    public enum ActivityLevel
    {
        [Description("Hareketsiz")]
        Sedentary,
        [Description("Hafif Aktif")]
        LightlyActive,
        [Description("Orta Hareketli")]
        ModeratelyActive,
        [Description("Çok Hareketli")]
        HighlyActive,
        [Description("Son Derece Aktif")]
        ExtremelyActive


    }

}
