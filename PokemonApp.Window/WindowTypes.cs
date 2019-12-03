using PokemonApp.Damage.Views;
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
        public WindowType PictuerBook => new WindowType("種族値一覧", nameof(PictureBookView));
        public WindowType DamageSim => new WindowType("ダメージ計算", nameof(DamageView));
        public WindowType WildArea => new WindowType("ワイルドエリア一覧", nameof(WildAreaView));

    }
}
