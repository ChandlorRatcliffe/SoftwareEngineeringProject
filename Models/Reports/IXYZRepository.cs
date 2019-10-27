using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashewWeb.Models
{
    public interface IReportsRepository
    {
        IEnumerable<Reports> GetAll();
        Reports Get(int Id);
        Reports Add(Reports reports);
    }
}
