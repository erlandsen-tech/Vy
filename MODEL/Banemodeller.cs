using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VyBillettBestilling.Model
{
    public class Stasjon
    {
        public int id { get; set; }

        public String stasjon_navn { get; set; }
        public String stasjon_sted { get; set; }

        public double breddegrad { get; set; }
        public double lengdegrad { get; set; }

        public int nett_id { get; set; }
        public IList<int> hovedstrekning_Ider { get; set; } // De fleste stasjoner har en i denne lista.
        // De som har >= 2 utgjor sammenknytninger mellom DbHovedstrekninger,
        // og er samtidig endepunkt for de tilknyttede hovedstrekningene
    }

    public class Hovedstrekning
    {
        public int id { get; set; }

        public String hovstr_navn { get; set; }

        public String hovstr_kortnavn { get; set; }
        public int nett_id { get; set; }
        public IList<int> stasjon_Ider { get; set; }
    }

    public class Nett
    {
        public int id { get; set; }
        public String nett_navn { get; set; }
        public IList<int> hovedstrekning_Ider { get; set; }
        public IList<int> stasjon_Ider { get; set; }
    }

}