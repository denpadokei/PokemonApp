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
		public static WindowType PictuerBook => new WindowType("ポケモンのデータあれこれ", "PokemonDataView");
		public static WindowType DamageSim => new WindowType("ダメージ計算", "DamageSimView");
		public static WindowType WildArea => new WindowType("ワイルドエリア一覧", "WildAreaView");
		public static WindowType AbilityValueConverter => new WindowType("能力値計算機", "AbilityValueConverterView");
		public static WindowType JsonSerch => new WindowType("JSONデータ探索", "JsonSerchBaseView");
		public static WindowType Settings => new WindowType("設定", "SettingsView");
	}
}