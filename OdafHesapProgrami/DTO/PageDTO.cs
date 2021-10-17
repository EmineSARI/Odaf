using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdafHesapProgrami.DTO
{
    public class PageDTO<T>
    {
        public List<T> Entity { get; set; }
        public decimal TotalCount { get; set; }
        public int ActivePage { get; set; }
    }
}