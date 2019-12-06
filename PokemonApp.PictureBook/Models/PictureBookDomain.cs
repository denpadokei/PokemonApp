using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonApp.DataBase.Models;
using NLog;
using System.Diagnostics;
using PokemonApp.PictureBook.DataBase;

namespace PokemonApp.PictureBook.Models
{
    public class PictureBookDomain : BindableBase
    {
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // プロパティ
        /// <summary>コレクション を取得、設定</summary>
        private ObservableCollection<PokemonEntity> collection_;
        /// <summary>コレクション を取得、設定</summary>
        public ObservableCollection<PokemonEntity> Collection
        {
            get { return this.collection_; }
            set { this.SetProperty(ref collection_, value); }
        }

        /// <summary>初期リスト を取得、設定</summary>
        private IReadOnlyList<PokemonEntity> pokemonList_;
        /// <summary>初期リスト を取得、設定</summary>
        public IReadOnlyList<PokemonEntity> PokemonList
        {
            get { return this.pokemonList_; }
            set { this.SetProperty(ref pokemonList_, value); }
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
        public void Filtering()
        {
            var list = new List<PokemonEntity>(this.PokemonList);
            this.Collection.Clear();
            this.Collection.AddRange(list.Where(x => x.Name.Contains(this.Filter.PokemonName)));
        }

        public void Serch()
        {
            this.Collection.Clear();
            using (var repository = new Repository()) {
                this.Collection.AddRange(PictureBookDataBase.FindPokemon(repository.Context));
                foreach (var pokemon in this.Collection) {
                    //var trickListList = PictureBookDataSet.FindTrick(pokemon.Name);
                    //foreach (var trickList in trickListList) {
                    //    pokemon.LeanTrickList.AddRange(trickList);
                    //}
                    pokemon.LearnTrickList.AddRange(PictureBookDataBase.FindLearnTrick(repository.Context, pokemon.Id));
                }
            }
            
        }

        public bool Regist()
        {
            using (var repositoty = new Repository()) {
                foreach (var pokemon in this.Collection) {
                    if (repositoty.Context.pokemons.FirstOrDefault(x => x.name == pokemon.Name) == null) {
                        var type1 = repositoty.Context.types.FirstOrDefault(x => x.type_name == pokemon.Type1);
                        var type2 = repositoty.Context.types.FirstOrDefault(x => x.type_name == pokemon.Type2);
                        var characteristic1 = repositoty.Context.characteristics.FirstOrDefault(x => x.characteristic_name == pokemon.Characteristic1);
                        var characteristic2 = repositoty.Context.characteristics.FirstOrDefault(x => x.characteristic_name == pokemon.Characteristic2);
                        var dCharacteristic = repositoty.Context.characteristics.FirstOrDefault(x => x.characteristic_name == pokemon.DreamCharacteristic);
                        repositoty.Context.pokemons.Add(new pokemon()
                        {
                            pokemon_no = pokemon.No,
                            name = pokemon.Name,
                            height = pokemon.Height,
                            weight = pokemon.Weight,
                            type_1_id = type1 != null ? type1.type_id : 1,
                            type_2_id = type2.type_id,
                            characteristic1_id = characteristic1 != null ? characteristic1.characteristic_id : 1,
                            characteristic2_id = characteristic2.characteristic_id,
                            dream_characteristic_id = dCharacteristic.characteristic_id,
                            hp = pokemon.Hp,
                            attack = pokemon.Attack,
                            block = pokemon.Block,
                            contact = pokemon.Contact,
                            defence = pokemon.Defence,
                            speed = pokemon.Speed,
                        });
                        foreach (var trick in pokemon.LearnTrickList) {
                            repositoty.Context.link_tricks.Add(new link_trick()
                            {
                                pokemon_id = repositoty.Context.pokemons.FirstOrDefault(x => x.name == pokemon.Name).pokemon_id,
                                trick_id = repositoty.Context.tricks.FirstOrDefault(x => x.trick_name == trick.Name).trick_id
                            });
                        }
                    }
                }
                if (repositoty.Context.ChangeTracker.HasChanges()) {
                    repositoty.Context.SaveChanges();
                    return true;
                }
                else {
                    return false;
                }
            };
        }

        public bool CharComit()
        {
            //var logger = LogManager.GetCurrentClassLogger();
            //using (var repository = new Repository()) {
            //    repository.SQLiteConnection.Open();
            //    var pokemontable = repository.Context.GetTable<pokemon>();
            //    var charastable = repository.Context.GetTable<characteristic>();
            //    foreach (var pokemon in this.Collection) {
            //        var pokemonRecords = pokemontable.ToArray().Where(x => x.name == pokemon.Name);
            //        foreach (var pokemonRecord in pokemonRecords) {
            //            var chars1 = pokemon.Characteristic1;
            //            var id1 = charastable.ToArray().Where(x => x.characteristic_name == chars1);
            //            foreach (var chars in id1) {
            //                pokemonRecord.characteristic1_id = chars.characteristic_id;
            //            }
            //            if (pokemon.Characteristic2 != "") {
            //                var chars2 = pokemon.Characteristic2;
            //                var id2 = charastable.ToArray().Where(x => x.characteristic_name == chars2);
            //                foreach (var chars in id2) {
            //                    pokemonRecord.characteristric2_id = chars.characteristic_id;
            //                }
            //            }
            //            if (pokemon.DreamCharacteristic != "") {
            //                var chars3 = pokemon.DreamCharacteristic;
            //                var id3 = charastable.ToArray().Where(x => x.characteristic_name == chars3);
            //                foreach (var chars in id3) {
            //                    pokemonRecord.dream_characteristic_id = chars.characteristic_id;
            //                }
            //            }
            //        }
            //    }
            //    repository.Context.SubmitChanges();
            //    repository.SQLiteConnection.Close();
            //}
            return true;
        }

        public bool TypeComit()
        {
            //var logger = LogManager.GetCurrentClassLogger();
            //using (var repository = new Repository()) {
            //    repository.SQLiteConnection.Open();
            //    var pokemontable = repository.Context.GetTable<pokemon>();
            //    var charastable = repository.Context.GetTable<type>();
            //    foreach (var pokemon in this.Collection) {
            //        var pokemonRecords = pokemontable.ToArray().Where(x => x.name == pokemon.Name);
            //        foreach (var pokemonRecord in pokemonRecords) {
            //            var type1 = pokemon.Type1;
            //            var id1 = charastable.ToArray().Where(x => x.type_name == type1);
            //            foreach (var chars in id1) {
            //                pokemonRecord.type_1_id = chars.type_id;
            //            }
            //            if (pokemon.Type2 != "") {
            //                var type2 = pokemon.Type2;
            //                var id2 = charastable.ToArray().Where(x => x.type_name == type2);
            //                foreach (var chars in id2) {
            //                    pokemonRecord.type_2_id = chars.type_id;
            //                }
            //            }
            //        }
            //    }
            //    repository.Context.SubmitChanges();
            //    repository.SQLiteConnection.Close();
            //}
            return true;
        }
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // メンバ変数
        #endregion
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // 構築・破棄
        public PictureBookDomain()
        {
            this.Collection = new ObservableCollection<PokemonEntity>();
            this.PokemonList = new List<PokemonEntity>();
            this.Filter = new PictureBookFilter();
        }
        #endregion
    }
}
