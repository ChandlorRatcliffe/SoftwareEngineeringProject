using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashewWeb.Models
{
    public interface ITestRunnerRepository
    {
        IEnumerable<TestRunner> GetAll();
        TestRunner Get(int Id);
        TestRunner Add(TestRunner testRunner);
    }
}
