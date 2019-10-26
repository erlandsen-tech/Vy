using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VyBillettBestilling.Model
{
    public class Passasjer
    {
        public int ptypId { get; set; }
        public double rabatt { get; set; }
        public string typenavn { get; set; }
        public int ovreAlder { get; set; }
        public int nedreAlder { get; set; }
    }
}