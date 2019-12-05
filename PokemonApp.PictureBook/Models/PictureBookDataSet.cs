using Microsoft.VisualBasic.FileIO;
using NLog;
using PokemonApp.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
                    csvReader1.SetDelimiters(new string[] { "," });
                    csvReader1.HasFieldsEnclosedInQuotes = true;
                    string[] col1Fields = csvReader1.ReadFields();
                    foreach (string column in col1Fields) {
                        DataColumn datecolumn = new DataColumn(column);
                        datecolumn.AllowDBNull = true;
                        csvData.Columns.Add(datecolumn);
                    }
                    while (!csvReader1.EndOfData) {
                        string[] fieldData = csvReader1.ReadFields();
                        //Making empty value as null
                        //for (int i = 0; i < fieldData.Length; i++) {
                        //    if (fieldData[i] == "") {
                        //        fieldData[i] = null;
                        //    }
                        //}
                        var entity = new PokemonEntity()
                        {
                            No = fieldData[0],
                            Name = fieldData[1],
                            Type1 = fieldData[2],
                            Type2 = fieldData[3],
                            Characteristic1 = fieldData[4],
                            Characteristic2 = fieldData[5],
                            DreamCharacteristic = fieldData[6],
                            Hp = int.Parse(fieldData[7]),
                            Attack = int.Parse(fieldData[8]),
                            Block = int.Parse(fieldData[9]),
                            Contact = int.Parse(fieldData[10]),
                            Defence = int.Parse(fieldData[11]),
                            Speed = int.Parse(fieldData[12])
                        };
                        //if (int.TryParse(fieldData[13], out var sumAll)) {
                        //    entity.SumAll = sumAll;
                        //}
                        list.Add(entity);
                    }
                    #endregion
                    #region
                    csvReader2.SetDelimiters(new string[] { "," });
                    csvReader2.HasFieldsEnclosedInQuotes = true;
                    string[] col2Fields = csvReader2.ReadFields();
                    foreach (string column in col2Fields) {
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
                        //var entity = new PokemonEntity()
                        //{
                        //    No = fieldData[0],
                        //    Name = fieldData[1],
                        //    Type1 = fieldData[2],
                        //    Type2 = fieldData[3],
                        //    Characteristic1 = fieldData[4],
                        //    Characteristic2 = fieldData[5],
                        //    DreamCharacteristic = fieldData[6],
                        //    Hp = int.Parse(fieldData[7]),
                        //    Attack = int.Parse(fieldData[8]),
                        //    Block = int.Parse(fieldData[9]),
                        //    Contact = int.Parse(fieldData[10]),
                        //    Defence = int.Parse(fieldData[11]),
                        //    Speed = int.Parse(fieldData[12])
                        //};
                        //if (int.TryParse(fieldData[13], out var sumAll)) {
                        //    entity.SumAll = sumAll;
                        //}
                        //list.Add(entity);
                        var heightstr = Regex.Replace(fieldData[6], @"[a-z]", "");
                        var weightstr = Regex.Replace(fieldData[7], @"[a-z]", "");

                        if (double.TryParse(heightstr, out var height) && list.FirstOrDefault(x => x.Name == fieldData[0]) != null) {
                            list.FirstOrDefault(x => x.Name == fieldData[0]).Height = height;
                        }
                        if (double.TryParse(weightstr, out var weight) && list.FirstOrDefault(x => x.Name == fieldData[0]) != null) {
                            list.FirstOrDefault(x => x.Name == fieldData[0]).Weight = weight;
                        }
                    }
                    #endregion
                    return list;
                }
            }
            catch (Exception e) {
                var logger = LogManager.GetCurrentClassLogger();
                logger.Error(e);
                throw e;
            }
        }


        static public List<List<string>> FindTrick(string csv_file_path = @".\Static\PokemonData.csv")
        {
            var csvData = new DataTable();
            var list = new List<List<string>>();
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
                        var entity = fieldData[8].Split('/').ToList();
                        list.Add(entity);
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
