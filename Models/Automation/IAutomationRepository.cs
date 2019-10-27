﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CashewWeb.Models
{
    public interface IAutomationRepository
    {
        IEnumerable<Automation> GetAll();
        Automation Get(int Id);
        Automation Add(Automation automation);
    }
}
