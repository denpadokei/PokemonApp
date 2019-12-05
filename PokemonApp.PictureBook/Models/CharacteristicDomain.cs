using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Linq;
//using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonApp.DataBase.Models;
using NLog;

namespace PokemonApp.PictureBook.Models
{
    public class CharacteristicDomain : BindableBase
    {
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // プロパティ
        /// <summary>コレクション を取得、設定</summary>
        private ObservableCollection<CharacteristicEntity> collection_;
        /// <summary>コレクション を取得、設定</summary>
        public ObservableCollection<CharacteristicEntity> Collection
        {
            get { return this.collection_; }
            set { this.SetProperty(ref collection_, value); }
        }

        /// <summary>初期リスト を取得、設定</summary>
        private List<CharacteristicEntity> charsList_;
        /// <summary>初期リスト を取得、設定</summary>
        public List<CharacteristicEntity> CharsList
        {
            get { return this.charsList_; }
            set { this.SetProperty(ref charsList_, value); }
        }

        /// <summary>検索条件 を取得、設定</summary>
        private PictureBookFilter filter_;
        /// <summary>検索条件 を取得、設定</summary>
        public PictureBookFilter Filter
        {
            get { return this.filter_; }
            set { this.SetProperty(ref filter_, value); }
        }

        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // コマンド
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // コマンド用メソッド
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // リクエスト
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // オーバーライドメソッド
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // プライベートメソッド
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // パブリックメソッド
        public void Serch()
        {
            this.Collection.Clear();
            var pokemons = PictureBookDataSet.FindPokemon();
            var chars = new HashSet<string>();
            foreach (var pokemon in pokemons) {
                chars.Add(pokemon.Characteristic1);
            }
            foreach (var pokemon in pokemons.Where(x => x.Characteristic2 != "")) {
                chars.Add(pokemon.Characteristic2);
            }
            foreach (var pokemon in pokemons.Where(x => x.DreamCharacteristic != "")) {
                chars.Add(pokemon.DreamCharacteristic);
            }
            var list = chars.ToList().OrderBy(x => x);
            foreach (var item in list) {
                this.Collection.Add(new CharacteristicEntity() { Name = item });
            }
        }

        public void Filtering()
        {
            var list = new List<CharacteristicEntity>(this.CharsList);
            this.Collection.Clear();
            this.Collection.AddRange(list.Where(x => x.Name.Contains(this.Filter.PokemonName)));
        }

        public void Regist()
        {
            //var logger = LogManager.GetCurrentClassLogger();
            //using (var connection = new SQLiteConnection("DataSource=" + @".\localdb.db")) {
            //    var context = new DataContext(connection);
            //    var table = context.GetTable<characteristic>();
            //    var i = 1;
            //    foreach (var charact in this.Collection) {
            //        table.InsertOnSubmit(new characteristic()
            //        {
            //            characteristic_id = i,
            //            characteristic_name = charact.Name
            //        });
            //        ++i;
            //        logger.Info($"{i}行目が終わりました。");

            //    }
            //    try {
            //        context.SubmitChanges();
            //    }
            //    catch (Exception e) {
            //        logger.Error(e);
            //        //throw e;
            //    }
            //    finally {
            //    }

            //};
        }
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // メンバ変数
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // 構築・破棄
        public CharacteristicDomain()
        {
            this.Collection = new ObservableCollection<CharacteristicEntity>();
            this.CharsList = new List<CharacteristicEntity>();
            this.Filter = new PictureBookFilter();
        }
        #endregion
    }
}
