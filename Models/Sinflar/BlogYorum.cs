using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TatilSeyahatSitesiMVc.Models.Sinflar
{
    public class BlogYorum
    {
        public IEnumerable<Blog> degerB { get; set; }
        public IEnumerable<Yorumlar> degerY { get; set; }

        public IEnumerable<Blog> degerS { get; set; }
    }
}