using Microsoft.VisualBasic.FileIO;
using NLog;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PokemonApp.PictureBook.Models
{
    static class PictureBookDataSet
    {
        static public List<PokemonEntity> FindPokemon(string csv_file_path_1 = @".\Static\pokemon_status.csv", string csv_file_path_2 = @".\Static\PokemonData.csv")
        {
            var csvData = new DataTable();
            var list = new List<PokemonEntity>();
            try {
                using (TextFieldParser csvReader1 = new TextFieldParser(csv_file_path_1, Encoding.GetEncoding("shift_jis")))
                using (TextFieldParser csvReader2 = new TextFieldParser(csv_file_path_2, Encoding.GetEncoding("shift_jis"))) {
                    #region
                    csvReader2.SetDelimiters(new string[] { "," });
                    csvReader2.HasFieldsEnclosedInQuotes = true;
                    string[] col1Fields = csvReader2.ReadFields();
                    foreach (string column in col1Fields) {
                        DataColumn datecolumn = new DataColumn(column);
                        datecolumn.AllowDBNull = true;
                        csvData.Columns.Add(datecolumn);
                    }
                    while (!csvReader2.EndOfData) {
                        string[] fieldData = csvReader2.ReadFields();
                        //Making empty value as null
                        //for (int i = 0; i < fieldData.Length; i++) {
                        //    if (fieldData[i] == "") {
                        //        fieldData[i] = null;
                        //    }
                        //}
                        var entity = new PokemonEntity()
                        {
                            Id = int.Parse(fieldData[2]),
                            No = fieldData[2],
                            Name = fieldData[0],
                        };
                        //if (int.TryParse(fieldData[13], out var sumAll)) {
                        //    entity.SumAll = sumAll;
                        //}
                        var type = new List<string>(fieldData[5].Split('/'));
                        entity.Type1 = type[0];
                        entity.Type2 = type.Count == 2 ? type[1] : null;
                        var characteristic = new List<string>(fieldData[4].Split('/'));
                        entity.Characteristic1 = characteristic[0];
                        var heightstr = Regex.Replace(fieldData[6], @"[a-z]", "");
                        var weightstr = Regex.Replace(fieldData[7], @"[a-z]", "");

                        if (double.TryParse(heightstr, out var height)) {
                            entity.Height = height;
                        }
                        if (double.TryParse(weightstr, out var weight)) {
                            entity.Weight = weight;
                        }
                        var trickList = new List<TrickEntity>();
                        foreach (var trick in fieldData[8].Split('/')) {
                            trickList.Add(new TrickEntity() { Name = trick });
                        }
                        entity.LearnTrickList.AddRange(trickList);
                        list.Add(entity);
                    }
                    #endregion
                    #region
                    //csvReader2.SetDelimiters(new string[] { "," });
                    //csvReader2.HasFieldsEnclosedInQuotes = true;
                    //string[] col2Fields = csvReader2.ReadFields();
                    //foreach (string column in col2Fields) {
                    //    DataColumn datecolumn = new DataColumn(column);
                    //    datecolumn.AllowDBNull = true;
                    //    csvData.Columns.Add(datecolumn);
                    //}
                    //while (!csvReader2.EndOfData) {
                    //    string[] fieldData = csvReader2.ReadFields();
                    //    Making empty value as null
                    //    for (int i = 0; i < fieldData.Length; i++) {
                    //        if (fieldData[i] == "") {
                    //            fieldData[i] = null;
                    //        }
                    //    }
                    //    var entity = new PokemonEntity()
                    //    {
                    //        No = fieldData[0],
                    //        Name = fieldData[1],
                    //        Type1 = fieldData[2],
                    //        Type2 = fieldData[3],
                    //        Characteristic1 = fieldData[4],
                    //        Characteristic2 = fieldData[5],
                    //        DreamCharacteristic = fieldData[6],
                    //        Hp = int.Parse(fieldData[7]),
                    //        Attack = int.Parse(fieldData[8]),
                    //        Block = int.Parse(fieldData[9]),
                    //        Contact = int.Parse(fieldData[10]),
                    //        Defence = int.Parse(fieldData[11]),
                    //        Speed = int.Parse(fieldData[12])
                    //    };
                    //    if (int.TryParse(fieldData[13], out var sumAll)) {
                    //        entity.SumAll = sumAll;
                    //    }
                    //    list.Add(entity);
                    //    var heightstr = Regex.Replace(fieldData[6], @"[a-z]", "");
                    //    var weightstr = Regex.Replace(fieldData[7], @"[a-z]", "");

                    //    if (double.TryParse(heightstr, out var height) && list.FirstOrDefault(x => x.Name == fieldData[0]) != null) {
                    //        list.FirstOrDefault(x => x.Name == fieldData[0]).Height = height;
                    //    }
                    //    if (double.TryParse(weightstr, out var weight) && list.FirstOrDefault(x => x.Name == fieldData[0]) != null) {
                    //        list.FirstOrDefault(x => x.Name == fieldData[0]).Weight = weight;
                    //    }
                    //}
                    #endregion
                    return list.OrderBy(x => x.Id).ToList();
                }
            }
            catch (Exception e) {
                var logger = LogManager.GetCurrentClassLogger();
                logger.Error(e);
                throw e;
            }
        }


        static public List<List<TrickEntity>> FindTrick(string pokemonName = "", string csv_file_path = @".\Static\PokemonData.csv")
        {
            var csvData = new DataTable();
            var list = new List<List<TrickEntity>>();
            try {
                using (TextFieldParser csvReader = new TextFieldParser(csv_file_path, Encoding.GetEncoding("shift_jis"))) {
                    csvReader.SetDelimiters(new string[] { "," });
                    csvReader.HasFieldsEnclosedInQuotes = true;
                    string[] colFields = csvReader.ReadFields();
                    foreach (string column in colFields) {
                        DataColumn datecolumn = new DataColumn(column);
                        datecolumn.AllowDBNull = true;
                        csvData.Columns.Add(datecolumn);
                    }
                    while (!csvReader.EndOfData) {
                        string[] fieldData = csvReader.ReadFields();
                        //Making empty value as null
                        //for (int i = 0; i < fieldData.Length; i++) {
                        //    if (fieldData[i] == "") {
                        //        fieldData[i] = null;
                        //    }
                        //}
                        var entity = new List<TrickEntity>();
                        foreach (var trick in fieldData[8].Split('/')) {
                            entity.Add(new TrickEntity()
                            {
                                Name = trick,
                            });
                        }
                        if (pokemonName == fieldData[0]) {
                            list.Add(entity);
                        }
                    }
                    return list;
                }
            }
            catch (Exception e) {
                var logger = LogManager.GetCurrentClassLogger();
                logger.Error(e);
                throw e;
            }
        }
    }
}
