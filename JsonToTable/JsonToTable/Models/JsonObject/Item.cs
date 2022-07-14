using JsonToTable.Models.JsonObject.Shared;
using Newtonsoft.Json;

namespace JsonToTable.Models.JsonObject
{
    public class Item
    {
        public string? Id { get; set; }
        public string? Type { get; set; }
        public string? Name { get; set; }
        public string? Ppu { get; set; }
        public Batters? Batters { get; set; }
        public List<Option>? Topping { get; set; }

    }
}