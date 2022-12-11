using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CatFactApp.Models
{
    public class CatFactDetailView
    {
        [JsonProperty("_id")]
        public Guid CatFactId { get; set; }

        public string? Text { get; set; }

        public string? Type { get; set; }

        [JsonProperty("user")]
        public User? User { get; set; }

        [JsonProperty("upvotes")]
        public int Votes { get; set; }

        [JsonProperty("userUpvoted")]
        public int? UserVote { get; set; }
    }
}
