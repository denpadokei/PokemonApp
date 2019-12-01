using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp.Core.Enum
{
    public enum AreaName
    {
        [Description("うららか草原")]
        Uraraka
    }

    public enum WildAreaEnum
    {
        [Description("西")]
        East = 0,
        [Description("東")]
        West,
        [Description("南")]
        Sause,
        [Description("北")]
        Nose,
        [Description("中央")]
        Center,
        [Description("ランダム")]
        Random,
    }

    public enum Wether
    {
        [Description("晴れ")]
        Sunny = 0,
        [Description("曇り")]
        Cloudy,
        [Description("雨")]
        Rainy,
        [Description("雷雨")]
        SanderRainy,
        [Description("日照")]
        HeveySunny,
        [Description("雪")]
        Snow,
        [Description("吹雪")]
        HevySnow,
        [Description("砂嵐")]
        SandStorm,
        [Description("霧")]
        Fog
    }
}
