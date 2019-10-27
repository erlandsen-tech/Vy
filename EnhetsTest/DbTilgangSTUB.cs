using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VyBillettBestilling.BLL;

namespace EnhetsTest
{
    class DbTilgangSTUB : IVyDbTilgang
    {
        /* testdatametoder testes ikke*/
        public void addPassasjertyper() {}
        public void addPris() { }
        public void ByggBanedata() { }
        /* Slutt testdatametoder */    
        public bool fjernHovedstrekning(int hovstrId)
        {
            if(hovstrId > 0 && hovstrId < int.MaxValue) {
                return true;
            }
            else return false;
        }
        bool fjernNett(int nettId);
        bool fjernStasjon(int stasjId);
        bool fjernStasjonerFraHovedstrekning(int hovstrId, IEnumerable<int> stasjonIder);
        List<Hovedstrekning> HentAlleHovedstrekninger();
        List<Nett> HentAlleNett();
        List<Stasjon> HentAlleStasjoner();
        List<string> HentAlleStasjonNavn();
        Hovedstrekning HentHovedstrekning(int hovstrId);
        List<Hovedstrekning> HentHovedstrekningerEtterBegKortNavn(string begNavn);
        List<Hovedstrekning> HentHovedstrekningerEtterBegNavn(string begNavn);
        List<Hovedstrekning> HentHovedstrekningerPaNett(int nettId);
        List<Hovedstrekning> HentHovedstrekningerTilStasjon(int stasjId);
        Nett HentNett(int nettId);
        List<Nett> HentNettEtterBegNavn(string begNavn);
        Passasjer HentPassasjer(int id);
        List<Passasjer> HentPassasjerTyper();
        Pris HentPris();
        Stasjon HentStasjon(int stasjId);
        List<Stasjon> HentStasjoner(string stasjNavn, string optSted = "");
        List<Stasjon> HentStasjonerEtterBegNavn(string begNavn);
        List<Stasjon> HentStasjonerPaHovedstrekning(int hovstrId);
        List<Stasjon> HentStasjonerPaNett(int nettId);
        int leggTilHovedstrekning(Hovedstrekning hovst);
        int leggTilNett(Nett nett);
        int leggTilNett(string navn);
        int leggTilStasjon(Stasjon stas);
        int leggTilStasjon(string navn, string sted, double breddegrad, double lengdegrad);
        bool OppdaterPassasjer(Passasjer passasjer);
        bool OppdaterStasjon(Stasjon stasjon);
        bool OppdaterStrekning(Hovedstrekning hvst);
        Passasjer Passasjertype(int typeId);
        bool settInnStasjonerIHovedstrekning(int hovstrId, IList<int> stasjonIder, int plassering);
        bool settNyeHovedstrekningNavn(int hovstrId, string nyttNavn, string nyttKortnavn);
        bool settNyeStasjonKoordinater(int stasjId, double breddegrad, double lengdegrad);
        bool settNyeStasjonNavnOgSted(int stasjId, string nyttNavn, string nyttSted);
        bool settNyttNettnavn(int nettId, string nyttNavn);
        bool SettPris(double nyPris);
        List<List<Stasjon>> stierMellomStasjoner(int ida, int idb);
    }
}
