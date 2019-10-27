using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashewWeb.Models
{
    public interface ISqlScriptsRepository
    {
        IEnumerable<SqlScripts> GetAll();
        SqlScripts Get(int Id);
        SqlScripts Add(SqlScripts sqlScripts);
    }
}
