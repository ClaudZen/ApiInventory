using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Api.Models.Category
{
    public class CategorySelectViewModel
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }
        [JsonPropertyName("Nombre")]
        public string Name { get; set; }
        [JsonPropertyName("Orden")]
        public int Order { get; set; }
    }
}
