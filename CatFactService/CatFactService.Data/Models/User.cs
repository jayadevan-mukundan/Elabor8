using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CatFactService.Data.Models
{
    public class User
    {
        [JsonPropertyName("_id")]
        public Guid UserId { get; set; }

        [JsonPropertyName("first")]
        public string? FirstName { get; set; }

        [JsonPropertyName("last")]
        public string? LastName { get; set; }
    }
}
