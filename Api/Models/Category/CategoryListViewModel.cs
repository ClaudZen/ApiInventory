using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Api.Models.Category
{
    public class CategoryListViewModel
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }
        [JsonPropertyName("Estado")]
        public string State { get; set; }
        [JsonPropertyName("Fecha_creacion")]
        public DateTime RegistrationDate { get; set; }
        [JsonPropertyName("Nombre")]
        public string Name { get; set; }
    }
}
