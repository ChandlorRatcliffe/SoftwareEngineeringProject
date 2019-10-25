using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NimbleWeb.Models
{
    public class HomeRepository : IHomeRepository
    {

        private readonly List<Home> _homeList;

        public HomeRepository()
        {
            _homeList = new List<Home>()
            {
                new Home() { Id = 1, Name = "This is the home Content!"},
            };

        }

        public Home GetHome(int Id)
        {
            return _homeList.FirstOrDefault(e => e.Id == Id);
        }

    }
}
