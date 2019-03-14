using System;
using System.Collections.Generic;
using System.Text;

namespace Superbear.Common.Contract
{
    public class PageResult<T>
    {
        public PageResult()
        {
        }
        public int TotalRecords { get; set; }
        public int PageIndex { get; set; }
        public int SizePerPage { get; set; }
        public IList<T> ResultList { get; set; }
    }
}
