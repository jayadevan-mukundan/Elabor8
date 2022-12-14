using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CatFactService.Data.Models
{
    public class CatFactView
    {
        [JsonPropertyName("_id")]
        public Guid CatFactId { get; set; }

        public string? Text { get; set; }

        public string? Source { get; set; }

        public string? Type { get; set; }

        public Guid User { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public bool Deleted { get; set; }

        public bool Used { get; set; }

        [JsonPropertyName("__v")]
        public int Votes { get; set; }

        public Status Status { get; set; } = new Status();
    }

    public class Status
    {
        public bool Verified { get; set; }

        public int? SentCount { get; set; }
    }
}
