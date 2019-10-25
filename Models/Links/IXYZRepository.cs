﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NimbleWeb.Models
{
    public interface ILinksRepository
    {
        IEnumerable<Links> GetAll();
        Links Get(int Id);
        Links Add(Links links);
    }
}
