using System;
using System.Collections.Generic;

namespace ViEdu.Models
{
    public class PageResult<T>
    {
        public List<T> Items { get; set; }
    }
}
