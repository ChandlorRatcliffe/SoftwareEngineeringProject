using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashewWeb.Models
{
    public class BugRepository : IBugRepository
    {
        private readonly List<Bug> _bugList;

        public BugRepository()
        {
            _bugList = new List<Bug>()
            {
                new Bug() { Id = 1, Name = "Error", Priority = "Medium", Description = "This is a bug", User = 1},
                new Bug() { Id = 2, Name = "Error", Priority = "High", Description = "This is a bad bug", User = 2},
                new Bug() { Id = 3, Name = "Warning", Priority = "Low", Description = "This is a possible bug", User = 1},
            };
        }

        public IEnumerable<Bug> GetAllBugs()
        {
            return _bugList;
        }

        public Bug GetBug(int Id)
        {
            return _bugList.FirstOrDefault(e => e.Id == Id);
        }

        public Bug Add(Bug bug)
        {
            bug.Id = _bugList.Max(e => e.Id) + 1;
            _bugList.Add(bug);
            return bug;
        }


    }
}
