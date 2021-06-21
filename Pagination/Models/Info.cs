using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Pagination.Models
{
    public class Info
    {
        [Description("編號")]
        public string Num { get; set; }

        [Description("名稱")]
        public string Name { get; set; }
    }
}