using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CatFactApp.Models
{
    public class CatFactView
    {
        [JsonProperty("_id")]
        public Guid CatFactId { get; set; }

        public string? Text { get; set; }

        public string? Source { get; set; }

        public string? Type { get; set; }

        public Guid User { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public bool Deleted { get; set; }

        public bool Used { get; set; }

        [JsonProperty("__v")]
        public int Votes { get; set; }

        public Status Status { get; set; } = new Status();
    }

    public class Status
    {
        public bool Verified { get; set; }

        public int? SentCount { get; set; }
    }
}
