using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashewWeb.Models
{
    public class SearchRepository : ISearchRepository
    {
        private readonly List<Search> _searchList;

        public SearchRepository()
        {
            _searchList = new List<Search>()
            {
                new Search() { Id = 1 },
                new Search() { Id = 2 },
                new Search() { Id = 3 },
            };
        }

        public IEnumerable<Search> GetAll()
        {
            return _searchList;
        }

    }
}
