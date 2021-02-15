using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TatilSeyahatSitesiMVc.Models.Sinflar
{
    public class Blog
    {
        [Key]
        public int id { get; set; }
        public string Baslik { get; set; }
        public DateTime Tarih { get; set; }
        public String Blokimg { get; set; }
        public string Aciklama { get; set; }
        public ICollection<Yorumlar> Yorumlars { get; set; }
    }
}