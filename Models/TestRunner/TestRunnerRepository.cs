using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashewWeb.Models
{
    public class TestRunnerRepository : ITestRunnerRepository
    {
        private readonly List<TestRunner> _xyzList;

        public TestRunnerRepository()
        {
            _xyzList = new List<TestRunner>()
            {
                new TestRunner() { Id = 1 },
                new TestRunner() { Id = 2 },
                new TestRunner() { Id = 3 },
            };
        }

        public IEnumerable<TestRunner> GetAll()
        {
            return _xyzList;
        }

        public TestRunner Get(int Id)
        {
            return _xyzList.FirstOrDefault(e => e.Id == Id);
        }

        public TestRunner Add(TestRunner xyz)
        {
            xyz.Id = _xyzList.Max(e => e.Id) + 1;
            _xyzList.Add(xyz);
            return xyz;
        }


    }
}
