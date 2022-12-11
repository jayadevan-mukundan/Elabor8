using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CatFactWepApp.Models
{
    public class User
    {
        public Guid UserId { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }
    }
}
