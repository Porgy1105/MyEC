using MyEC.Models.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyEC.Models
{
    public class Footer
    {
        public string Title { get; set; }
        public List<LinkParameter> LinkChildren { get; set; }
}
}