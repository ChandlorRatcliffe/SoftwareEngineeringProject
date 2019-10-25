using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NimbleWeb.Models
{
    public interface IHomeRepository
    {
        Home GetHome(int Id);
    }
}
