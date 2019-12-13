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
using PokemonApp.Core.Collections;

namespace PokemonApp.PictureBook.Models
{
    public class PictureBookDomain : BindableBase
    {
        //ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*ﾟ+｡｡+ﾟ*｡+ﾟ ﾟ+｡*
        #region // プロパティ
        /// <summary>コレクション を取得、設定</summary>
        private MTObservableCollection<PokemonEntity> collection_;
        /// <summary>コレクション を取得、設定</summary>
        public MTObservableCollection<PokemonEntity> Collection
        {
            get { return this.collection_; }
            set { this.SetProperty(ref collection_, value); }
        }

        /// <summary>覚える技コレクション を取得、設定</summary>
        private MTObservableCollection<TrickEntity> trickCollection_;
        /// <summary>覚える技コレクション を取得、設定</summary>
        public MTObservableCollection<TrickEntity> TrickCollection
        {
            get { return this.trickCollection_; }
            set { this.SetProperty(ref trickCollection_, value); }
        }


        /// <summary>選択中のポケモン を取得、設定</summary>
        private PokemonEntity currentPokemon_;
        /// <summary>選択中のポケモン を取得、設定</summary>
        public PokemonEntity CurrentPokemon
        {
            get { return this.currentPokemon_ ?? (this.currentPokemon_ = new PokemonEntity()); }
            set { this.SetProperty(ref currentPokemon_, value); }
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
            get { return this.filter_ ?? (this.filter_ = new PictureBookFilter()); }
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
            this.Collection.AddRange(list.Where(x => x.Name.Contains(this.Filter.PokemonName ?? "")));
        }

        public void Serch()
        {
            this.Collection.Clear();
            using (var repository = new Repository()) {
                this.Collection.AddRange(PictureBookDataBase.FindPokemon(repository.Context));
                //this.Collection.AddRange(PictureBookDataSet.FindPokemon());
                //foreach (var pokemon in this.Collection) {
                //    var trickListList = PictureBookDataSet.FindTrick(pokemon.Name);
                //    foreach (var trickList in trickListList) {
                //        pokemon.LeanTrickList.AddRange(trickList);
                //    }
                //    pokemon.LearnTrickList.AddRange(PictureBookDataBase.FindLearnTrick(repository.Context, pokemon.Id));
                //}
            }
            
        }

        public void SerchLearnTrick()
        {
            this.TrickCollection.Clear();
            if (!this.CurrentPokemon.LearnTrickList.Any()) {
                using (var repository = new Repository()) {
                    this.TrickCollection.AddRange(PictureBookDataBase.FindLearnTrick(repository.Context, this.CurrentPokemon.Id).Select(x => x.TrickEntity));
                }
            }
        }

        public bool Regist()
        {
            using (var repositoty = new Repository()) {
                foreach (var pokemon in this.Collection.Where(x => x.Id >= 810)) {
                    if (!repositoty.Context.pokemons.Where(x => x.name == pokemon.Name).Any()) {
                        var type1 = repositoty.Context.types.FirstOrDefault(x => x.type_name == pokemon.Type1) != null ? repositoty.Context.types.FirstOrDefault(x => x.type_name == pokemon.Type1).type_id : 1;
                        var type2 = repositoty.Context.types.FirstOrDefault(x => x.type_name == pokemon.Type2)?.type_id;
                        var characteristic1 = repositoty.Context.characteristics.FirstOrDefault(x => x.characteristic_name == pokemon.Characteristic1);
                        var characteristic2 = repositoty.Context.characteristics.FirstOrDefault(x => x.characteristic_name == pokemon.Characteristic2);
                        var dCharacteristic = repositoty.Context.characteristics.FirstOrDefault(x => x.characteristic_name == pokemon.DreamCharacteristic);
                        var addpokemon = new pokemon()
                        {
                            pokemon_no = pokemon.No,
                            name = pokemon.Name,
                            height = pokemon.Height,
                            weight = pokemon.Weight,
                            type_1_id = type1,
                            type_2_id = type2,
                            //characteristic1_id = characteristic1 != null ? characteristic1.characteristic_id : 0,
                            //characteristic2_id = characteristic2.characteristic_id,
                            //dream_characteristic_id = dCharacteristic.characteristic_id,
                            //hp = pokemon.Hp,
                            //attack = pokemon.Attack,
                            //block = pokemon.Block,
                            //contact = pokemon.Contact,
                            //defence = pokemon.Defence,
                            //speed = pokemon.Speed,
                        };
                        repositoty.Context.pokemons.Add(addpokemon);
                        foreach (var trick in pokemon.LearnTrickList) {
                            repositoty.Context.link_tricks.Add(new link_trick()
                            {
                                pokemon_id = addpokemon.pokemon_id,
                                trick_id = repositoty.Context.tricks.FirstOrDefault(x => x.trick_name == trick.Name).trick_id
                            });
                        }
                    }
                    else {
                        //var updatePokemons = repositoty.Context.pokemons.Where(x => x.name == pokemon.Name);
                        //foreach (var updatePokemon in updatePokemons) {
                        //    var charachter1 = repositoty.Context.characteristics.FirstOrDefault(x => x.characteristic_name == pokemon.Characteristic1)?.characteristic_id;
                        //    updatePokemon.characteristic1_id = charachter1 != null ? (int)charachter1 : 0;
                        //    foreach (var trick in pokemon.LearnTrickList) {
                        //        repositoty.Context.link_tricks.Add(new link_trick()
                        //        {
                        //            pokemon_id = updatePokemon.pokemon_id,
                        //            trick_id = repositoty.Context.tricks.FirstOrDefault(x => x.trick_name == trick.Name).trick_id
                        //        });
                        //    }
                        //}
                        
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
            this.Collection = new MTObservableCollection<PokemonEntity>();
            this.TrickCollection = new MTObservableCollection<TrickEntity>();
            this.PokemonList = new List<PokemonEntity>();
        }
        #endregion
    }
}
