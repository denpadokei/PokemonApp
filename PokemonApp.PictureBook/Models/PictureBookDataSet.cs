using Microsoft.VisualBasic.FileIO;
using NLog;
using PokemonApp.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonApp.PictureBook.Models
{
    static class PictureBookDataSet
    {
        static public List<PokemonEntity> FindPokemon(string csv_file_path = @".\Static\pokemon_status.csv")
        {
            var csvData = new DataTable();
            var list = new List<PokemonEntity>();
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
                        if (int.TryParse(fieldData[13], out var sumAll)) {
                            entity.SumAll = sumAll;
                        }
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
