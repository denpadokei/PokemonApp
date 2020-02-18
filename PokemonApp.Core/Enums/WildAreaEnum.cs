using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp.Core.Enums
{
    public enum AreaName
    {
        [Description("うららか草原")]
        Uraraka,
        [Description("こもれび林")]
        Komorebi,
        [Description("キバ湖・東")]
        KibakoEast,
        [Description("キバ湖・西")]
        KibakoWest,
        [Description("キバ湖・瞳")]
        KibakoCenter,
        [Description("見張りの塔跡地")]
        Mihari,
        [Description("ミロカロ湖・南")]
        MirokarokoSause,
        [Description("ミロカロ湖・北")]
        MirokarokoNose,
        [Description("巨人の腰かけ")]
        BigManChar,
        [Description("エンジンリバーサイド")]
        Engine,
        [Description("ハノシマ原っぱ")]
        Hashinoma,
        [Description("ストーンズ原野")]
        Storns,
        [Description("砂塵の窪地")]
        SandMist,
        [Description("巨人の防止")]
        BigManHat,
        [Description("巨人の鏡池")]
        BigManMirrer,
        [Description("逆鱗の湖")]
        Nackle,
        [Description("ナックル丘陵")]
        Gekirin,
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

    public enum AppearanceType
    {

    }
}
