using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CatFactService.Data.Models
{
    public class CatFactDetailView
    {
        [JsonPropertyName("_id")]
        public Guid CatFactId { get; set; }

        public string? Text { get; set; }

        public string? Type { get; set; }

        public User? User { get; set; }

        [JsonPropertyName("upvotes")]
        public int Votes { get; set; }

        [JsonPropertyName("userUpvoted")]
        public int? UserVote { get; set; }
    }
}
