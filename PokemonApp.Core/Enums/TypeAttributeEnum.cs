using System.ComponentModel;

namespace PokemonApp.Core.Enums
{
    public enum CategoryAttribute
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
