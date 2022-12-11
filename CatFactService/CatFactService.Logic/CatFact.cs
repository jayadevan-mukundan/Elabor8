

using CatFactService.Data;
using CatFactService.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace CatFactService.Logic
{
    public class CatFact
    {
        private readonly CatFactContext _context;

        public CatFact(CatFactContext context)
        {
            _context = context;
        }

        public List<Data.Models.CatFactDetailView> GetFacts()
        {
            var catFactDetails = _context.CatFacts
                .Include(i => i.User)
                .Include(i => i.Source)
                .Include(i => i.Type).Select(x => new CatFactDetailView
                {
                    CatFactId = x.CatFactId,
                    Text = x.Text,
                    Type = x.Type.Name,
                    User = new User { UserId = x.User.UserId, FirstName = x.User.FirstName, LastName = x.User.LastName },
                    Votes = x.Votes,
                    UserVote = null
                });

            return catFactDetails.ToList();
        }

        public Data.Models.CatFactView GetFactById(Guid catFactId)
        {
            var fact = _context.CatFacts
                .Include(i => i.User)
                .Include(i => i.Source)
                .Include(i => i.Type)
                .Where(c => c.CatFactId == catFactId)
                .FirstOrDefault();

            if (fact == null)
            {
                return new Data.Models.CatFactView();
            }

            return new CatFactView
            {
                Used = fact.Used,
                Source = fact.Source.Name,
                Type = fact.Type.Name,
                Deleted = fact.Deleted,
                CatFactId = fact.CatFactId,
                UpdatedAt = fact.UpdatedAt,
                CreatedAt = fact.CreatedAt,
                User = fact.UserId,
                Text = fact.Text,
                Votes = fact.Votes,
                Status = new Status { SentCount = fact.SentCount, Verified = fact.Verified }
            }; ;
        }

    }
}