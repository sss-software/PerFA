﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerFA.Model
{
    class TransactionPresentation
    {
        public DateTime? Date { get; set; }
        public string Description { get; set; }
        public decimal? Sum { get; set; }
        public string AuthorName { get; set; }

    }
}