using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CatFactService.Data.Models
{
    public class CatFact
    {
        [JsonPropertyName("_id")]
        public Guid CatFactId { get; set; }

        public string? Text { get; set; }

        public int SourceId { get; set; }

        public int TypeId { get; set; }

        public Guid UserId { get; set; }

        public bool Verified { get; set; }

        public int? SentCount { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public bool Deleted { get; set; }

        public bool Used { get; set; }

        public int Votes { get; set; }

        public User User { get; set; } = new User();

        public Source Source { get; set; } = new Source();

        public Type Type { get; set; } = new Type();
    }
}
