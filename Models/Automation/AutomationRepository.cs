using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashewWeb.Models
{
    public class AutomationRepository : IAutomationRepository
    {
        private readonly List<Automation> _automationList;

        public AutomationRepository()
        {
            _automationList = new List<Automation>()
            {
                new Automation() { Id = 1 },
                new Automation() { Id = 2 },
                new Automation() { Id = 3 },
            };
        }

        public IEnumerable<Automation> GetAll()
        {
            return _automationList;
        }

        public Automation Get(int Id)
        {
            return _automationList.FirstOrDefault(e => e.Id == Id);
        }

        public Automation Add(Automation automation)
        {
            automation.Id = _automationList.Max(e => e.Id) + 1;
            _automationList.Add(automation);
            return automation;
        }


    }
}
