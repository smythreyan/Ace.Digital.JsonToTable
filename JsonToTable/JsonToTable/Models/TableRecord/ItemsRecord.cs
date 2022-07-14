using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonToTable.Models.TableRecord
{
    public class ItemsRecord
    {
        public string? Id { get; set; }
        public string? Type { get; set; }
        public string? Name { get; set; }
        public string? Batter { get; set; }
        public string? Topping { get; set; }

        public string ToCsvString(string del)
        {
            return $"{Id}{del}{Type}{del}{Name}{del}{Batter}{del}{Topping}";
        }

        public string GetHeader(string del)
        {
            return $"{nameof(Id)}{del}{nameof(Type)}{del}{nameof(Name)}{del}{nameof(Batter)}{del}{nameof(Topping)}{del}";
        }
    }
}
