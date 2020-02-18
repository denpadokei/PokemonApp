using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp.Core.Enums
{
    public enum TrickCategory
    {
        /// <summary>
        /// レベルアップで覚える
        /// </summary>
        [Description("レベル技")]
        Normal,
        /// <summary>
        /// 技マシンで覚える
        /// </summary>
        [Description("技マシン技")]
        Machine,
        /// <summary>
        /// たまごわざで覚える
        /// </summary>
        [Description("たまご技")]
        Egg,
        /// <summary>
        /// その他
        /// </summary>
        [Description("その他")]
        Other = 99
    }
}
