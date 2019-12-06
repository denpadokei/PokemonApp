using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp.Core.Enums
{
    public enum TypeAttribute
    {
        [Description("不明")]
        None = 0,
        [Description("物理")]
        Physics,
        [Description("特殊")]
        Special,
        [Description("変化")]
        change
    }
}
