using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CatFactApp.Models
{
    public class User
    {
        [JsonProperty("_id")]
        public Guid UserId { get; set; }

        [JsonProperty("first")]
        public string? FirstName { get; set; }

        [JsonProperty("last")]
        public string? LastName { get; set; }

        public string? FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
            set { }
        }
    }
}
