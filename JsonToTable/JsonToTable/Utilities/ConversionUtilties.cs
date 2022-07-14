using JsonToTable.Models.JsonObject;
using JsonToTable.Models.TableRecord;

namespace JsonToTable.Utilities
{
    public class ConversionUtilties
    {
        public List<ItemsRecord> ConvertToTableRecords(Item item)
        {

            List<ItemsRecord> mainItemsList = new List<ItemsRecord>
            {
                new ItemsRecord
                {
                    Id = item.Id,
                    Type = item.Type,
                    Name = item.Name
                }
            };

            var battersList = item?.Batters?.Batter;

            var toppingsList = item?.Topping;

#pragma warning disable CS8603 // Possible null reference return.
            var query = from x in mainItemsList
                        from y in battersList
                        from z in toppingsList
                        select new ItemsRecord { Id = x.Id, Type = x.Type, Name = x.Name, Batter = y.Type, Topping = z.Type };
#pragma warning restore CS8603 // Possible null reference return.

            return query.ToList<ItemsRecord>();

        }

    }
}
