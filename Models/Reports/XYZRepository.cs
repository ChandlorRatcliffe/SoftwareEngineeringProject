using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashewWeb.Models
{
    public class ReportsRepository : IReportsRepository
    {
        private readonly List<Reports> _reportsList;

        public ReportsRepository()
        {
            _reportsList = new List<Reports>()
            {
                new Reports() { Id = 1 },
                new Reports() { Id = 2 },
                new Reports() { Id = 3 },
            };
        }

        public IEnumerable<Reports> GetAll()
        {
            return _reportsList;
        }

        public Reports Get(int Id)
        {
            return _reportsList.FirstOrDefault(e => e.Id == Id);
        }

        public Reports Add(Reports reports)
        {
            reports.Id = _reportsList.Max(e => e.Id) + 1;
            _reportsList.Add(reports);
            return reports;
        }


    }
}
