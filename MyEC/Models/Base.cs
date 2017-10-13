using MyEC.Models.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyEC.Models
{
    public class Base
    {
        public string Title { get; set; }
        public List<LinkParameter> HeaderLinkList { get; set; }
        public List<Footer> FooterLinkList { get; set; }

        public Base()
        {
            this.Title = "MyEC";

            this.HeaderLinkList = new List<LinkParameter>(){
                new LinkParameter() { Title = "aa", Url = "#" },
                new LinkParameter() { Title = "bb", Url = "#" },
                new LinkParameter() { Title = "cc", Url = "#" }
            };

            this.FooterLinkList = new List<Footer>()
            {
                new Footer() {
                    Title ="aa",LinkChildren = new List<LinkParameter> {
                        new LinkParameter() { Title = "a1", Url = "#" },
                        new LinkParameter() { Title = "a2", Url = "#" },
                        new LinkParameter() { Title = "a3", Url = "#" },
                    }
                },
                new Footer() {
                    Title ="bb",LinkChildren = new List<LinkParameter> {
                        new LinkParameter() { Title = "b1", Url = "#" },
                        new LinkParameter() { Title = "b2", Url = "#" },
                        new LinkParameter() { Title = "b3", Url = "#" },
                    }
                },
                new Footer() {
                    Title ="cc",LinkChildren = new List<LinkParameter> {
                        new LinkParameter() { Title = "c1", Url = "#" },
                        new LinkParameter() { Title = "c2", Url = "#" },
                        new LinkParameter() { Title = "c3", Url = "#" },
                    }
                },
            };
        }
    }
}