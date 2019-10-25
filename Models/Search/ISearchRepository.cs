using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NimbleWeb.Models
{
    public interface ISearchRepository
    {
        IEnumerable<Search> GetAll();


    }
}
