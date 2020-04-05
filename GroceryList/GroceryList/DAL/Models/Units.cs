using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
