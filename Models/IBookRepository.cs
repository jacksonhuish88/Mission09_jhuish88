﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_jhuish88.Models
{
    public interface IBookRepository
    {
        IQueryable<Book> Books { get; }

    }
}
