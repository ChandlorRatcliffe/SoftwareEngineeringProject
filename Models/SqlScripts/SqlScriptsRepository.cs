using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashewWeb.Models
{
    public class SqlScriptsRepository : ISqlScriptsRepository
    {
        private readonly List<SqlScripts> _sqlScriptsList;

        public SqlScriptsRepository()
        {
            _sqlScriptsList = new List<SqlScripts>()
            {
                new SqlScripts() { Id = 1 },
                new SqlScripts() { Id = 2 },
                new SqlScripts() { Id = 3 },
            };
        }

        public IEnumerable<SqlScripts> GetAll()
        {
            return _sqlScriptsList;
        }

        public SqlScripts Get(int Id)
        {
            return _sqlScriptsList.FirstOrDefault(e => e.Id == Id);
        }

        public SqlScripts Add(SqlScripts sqlScripts)
        {
            sqlScripts.Id = _sqlScriptsList.Max(e => e.Id) + 1;
            _sqlScriptsList.Add(sqlScripts);
            return sqlScripts;
        }


    }
}
