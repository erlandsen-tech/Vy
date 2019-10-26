using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VyBillettBestilling.Model
{
    public class HovedstrekningCreateView
    {

        public string hovstr_navn { get; set; }
        public string hovstr_kortnavn { get; set; }
        public String nettid { get; set; }
        public List<string> stasjonsliste{ get; set; }
    }
}