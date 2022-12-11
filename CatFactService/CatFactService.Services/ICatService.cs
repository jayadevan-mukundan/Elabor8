using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatFactService.Data;


namespace CatFactService.Services
{
    public interface ICatService
    {
        List<Data.Models.CatFactDetailView> GetFacts();

        Data.Models.CatFactView GetFactById(Guid catFactId);
    }
}
