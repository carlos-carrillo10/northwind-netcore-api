﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Response
{
    public class PaginationResponse<T>
    {
        public IEnumerable<T> Result { get; set; }
        public bool HasMore { get; set; }
        public int Total { get; set; }
        public int TotalFiltered { get; set; }
        public int QuantityPages { get; set; }
        public int QuantityPagesFiltered { get; set; }
    }
}
