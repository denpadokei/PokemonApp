using PokemonApp.AbilityValueConverter.Views;
using PokemonApp.Damage.Views;
using PokemonApp.Json.Views;
using PokemonApp.PictureBook.Views;
using PokemonApp.WildArea.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp.WindowManage
{
    public partial class WindowType
    {
        static public WindowType PictuerBook => new WindowType("ポケモンのデータあれこれ", nameof(PokemonDataView));
        static public WindowType DamageSim => new WindowType("ダメージ計算", nameof(DamageView));
        static public WindowType WildArea => new WindowType("ワイルドエリア一覧", nameof(WildAreaView));
        static public WindowType AbilityValueConverter => new WindowType("能力値計算機", nameof(AbilityValueConverterView));
        static public WindowType JsonSerch => new WindowType("JSONデータ検索", nameof(JsonSerchView));

    }
}
