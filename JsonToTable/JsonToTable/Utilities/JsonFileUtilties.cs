using JsonToTable.Models.JsonObject;
using JsonToTable.Models.TableRecord;
using Newtonsoft.Json;

namespace JsonToTable.Utilities
{
    public class JsonFileUtilties
    {
        public ItemsList? ReadJsonFile(string filePath)
        {
            ItemsList? itemsListObj;
            using (StreamReader sr = new StreamReader(filePath))
            {
                var jsonInText = sr.ReadToEnd();
                itemsListObj = JsonConvert.DeserializeObject<ItemsList>(jsonInText);
            }
            return itemsListObj;
        }

        public void WriteTableFile(string filePath, List<Item> items)
        {

            ConversionUtilties conversion = new ConversionUtilties();
            using (TextWriter tw = new StreamWriter(filePath))
            {
                tw.WriteLine(new ItemsRecord().GetHeader(","));
                foreach (var item in items)
                {
                    var recs = conversion.ConvertToTableRecords(item);
                    foreach (var rec in recs)
                    {
                        tw.WriteLine(rec.ToCsvString(","));
                    }

                }

            }
        }
    }

    
}
