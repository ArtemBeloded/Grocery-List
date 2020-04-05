using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GroceryList.DAL.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Units
    {
        pcs = 0,
        kg = 1,
        g,
        l,
        ml
    }
}
