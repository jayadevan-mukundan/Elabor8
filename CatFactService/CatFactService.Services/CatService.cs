using CatFactService.Data;
using CatFactService.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatFactService.Services
{
    public class CatService : ICatService
    {
        private readonly CatFactContext _context;
        public CatService(CatFactContext context)
        {
            _context = context;
        }

        public CatFactView GetFactById(Guid catFactId)
        {
            return new Logic.CatFact(_context).GetFactById(catFactId);
        }

        public List<CatFactDetailView> GetFacts()
        {
            return new Logic.CatFact(_context).GetFacts();
        }
    }
}
