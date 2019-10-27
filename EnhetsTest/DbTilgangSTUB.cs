using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VyBillettBestilling.BLL;
using VyBillettBestilling.Model;

namespace EnhetsTest
{
    class DbTilgangSTUB : IVyDbTilgang
    {

        Hovedstrekning strekk = new Hovedstrekning
        {
            hovstr_kortnavn = "test",
            hovstr_navn = "t",
            id = 1,
            nett_id = 1,
            stasjon_Ider = { 1, 2, 3 }
        };

        Nett nett = new Nett
        {

            hovedstrekning_Ider = { 1, 2, 3 },
            id = 1,
            nett_navn = "testnett",
            stasjon_Ider = { 1, 2, 3 }
        };

        Stasjon stasjon = new Stasjon
        {
            hovedstrekning_Ider = { 1, 2, 3 },
            id = 1,
            lengdegrad = 0,
            nett_id = 2,
            stasjon_navn = "test",
            stasjon_sted = "Hamar",
            breddegrad = 3
        };
        /* testdatametoder testes ikke*/
        public void addPassasjertyper() { }
        public void addPris() { }
        public void ByggBanedata() { }
        /* Slutt testdatametoder */
        public bool fjernHovedstrekning(int hovstrId)
        {
            if (hovstrId > 0 && hovstrId < int.MaxValue)
            {
                return true;
            }
            else return false;
        }
        public bool fjernNett(int nettId)
        {
            if (nettId > 0 && nettId < int.MaxValue)
            {
                return true;
            }
            else return false;
        }
        public bool fjernStasjon(int stasjId)
        {
            if (stasjId == 0)
            {
                return false;
            }
            else return true;
        }
        public bool fjernStasjonerFraHovedstrekning(int hovstrId, IEnumerable<int> stasjonIder)
        {
            if (hovstrId != 0)
            {
                if (stasjonIder.Count() > 0)
                {
                    return true;
                }
            }
            return false;
        }
        List<Hovedstrekning> HentAlleHovedstrekninger()
        {
            var hvst = new List<Hovedstrekning>();
            hvst.Add(strekk);
            hvst.Add(strekk);
            hvst.Add(strekk);
            return hvst;
        }
        List<Nett> HentAlleNett()
        {
            var nettListe = new List<Nett>();
            nettListe.Add(nett);
            nettListe.Add(nett);
            nettListe.Add(nett);
            return nettListe;
        }
        public List<Stasjon> HentAlleStasjoner()
        {
            var stasjonListe = new List<Stasjon>();
            stasjonListe.Add(stasjon);
            stasjonListe.Add(stasjon);
            stasjonListe.Add(stasjon);
            return stasjonListe;
        }
        List<string> HentAlleStasjonNavn()
        {
            var stasjNavn = new List<String>();
            var stasjListe = HentAlleStasjoner();
            foreach (Stasjon stasjon in stasjListe)
            {
                stasjNavn.Add(stasjon.stasjon_navn);
            }
            return stasjNavn;
        }
        public Hovedstrekning HentHovedstrekning(int hovstrId)
        {
            if (hovstrId == 1)
            {
                return strekk;
            }
            else return null;
        }
        public List<Hovedstrekning> HentHovedstrekningerEtterBegKortNavn(string begNavn)
        {
            if (begNavn == "t")
            {
                var strekninger = new List<Hovedstrekning>();
                strekninger.Add(strekk);
                strekninger.Add(strekk);
                strekninger.Add(strekk);
                return strekninger;
            }
            else return null;
        }
        public List<Hovedstrekning> HentHovedstrekningerEtterBegNavn(string begNavn)
        {
            if (begNavn == "test")
            {
                var strekninger = new List<Hovedstrekning>();
                strekninger.Add(strekk);
                strekninger.Add(strekk);
                strekninger.Add(strekk);
                return strekninger;
            }
            else return null;
        }
        public List<Hovedstrekning> HentHovedstrekningerPaNett(int nettId)
        {
            var strekninger = new List<Hovedstrekning>();
            strekninger.Add(strekk);
            strekninger.Add(strekk);
            strekninger.Add(strekk);
            if (nettId == 2)
            {
                return strekninger;
            }
            else return null;
        }
        public List<Hovedstrekning> HentHovedstrekningerTilStasjon(int stasjId)
        {
            var strekkListe = new List<HovedStrekning>();
            strekkListe.Add(stekk);
            if (stasjId == 1)
            {
                return strekkListe;
            }
            else return null;
        }
        public Nett HentNett(int nettId)
        {
            if(nettId == )
        }
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
