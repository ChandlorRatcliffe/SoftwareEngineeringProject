using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashewWeb.Models
{
    public class LinksRepository : ILinksRepository
    {
        private readonly List<Links> _linksList;

        public LinksRepository()
        {
            _linksList = new List<Links>()
            {
                new Links() { Id = 1 },
                new Links() { Id = 2 },
                new Links() { Id = 3 },
            };
        }

        public IEnumerable<Links> GetAll()
        {
            return _linksList;
        }

        public Links Get(int Id)
        {
            return _linksList.FirstOrDefault(e => e.Id == Id);
        }

        public Links Add(Links links)
        {
            links.Id = _linksList.Max(e => e.Id) + 1;
            _linksList.Add(links);
            return links;
        }


    }
}
