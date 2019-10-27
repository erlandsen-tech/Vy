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

        Pris pris = new Pris
        {
            Id = 1,
            prisPrKm = 3
        };
        Hovedstrekning strekk = new Hovedstrekning
        {
            hovstr_kortnavn = "test",
            hovstr_navn = "t",
            id = 1,
            nett_id = 1,
            stasjon_Ider = { 1 }
        };

        Nett nett = new Nett
        {

            hovedstrekning_Ider = { 1  },
            id = 1,
            nett_navn = "testnett",
            stasjon_Ider = { 1 }
        };

        Stasjon stasjon = new Stasjon
        {
            hovedstrekning_Ider = { 1 },
            id = 1,
            lengdegrad = 0,
            nett_id = 1,
            stasjon_navn = "test",
            stasjon_sted = "Hamar",
            breddegrad = 3
        };
        Passasjer passasjer = new Passasjer
        {
            nedreAlder = 0,
            ovreAlder = 90,
            ptypId = 1,
            typenavn = "test",
            rabatt = 50
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
        public List<Hovedstrekning> HentAlleHovedstrekninger()
        {
            var hvst = new List<Hovedstrekning>();
            hvst.Add(strekk);
            return hvst;
        }
        public List<Nett> HentAlleNett()
        {
            var nettListe = new List<Nett>();
            nettListe.Add(nett);
            return nettListe;
        }
        public List<Stasjon> HentAlleStasjoner()
        {
            var stasjonListe = new List<Stasjon>();
            stasjonListe.Add(stasjon);
            return stasjonListe;
        }
        public List<string> HentAlleStasjonNavn()
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
                return strekninger;
            }
            else return null;
        }
        public List<Hovedstrekning> HentHovedstrekningerPaNett(int nettId)
        {
            var strekninger = new List<Hovedstrekning>();
            strekninger.Add(strekk);
            if (nettId == 1)
            {
                return strekninger;
            }
            else return null;
        }
        public List<Hovedstrekning> HentHovedstrekningerTilStasjon(int stasjId)
        {
            var strekkListe = new List<Hovedstrekning>();
            strekkListe.Add(strekk);
            if (stasjId == 1)
            {
                return strekkListe;
            }
            else return null;
        }

        public int leggTilHovedstrekning(Hovedstrekning hovst)
        {
            return (hovst != null)? 1 : 0;
        }
        public int leggTilNett(Nett nett)
        {
            return (nett != null) ? 1 : 0;
        }
        public int leggTilNett(string navn)
        {
            return (navn != null && navn.Length > 0) ? 1 : 0;
        }
        public int leggTilStasjon(Stasjon stas)
        {
            return (stas != null) ? 1 : 0;
        }
        public int leggTilStasjon(string navn, string sted, double breddegrad, double lengdegrad)
        {
            return (navn != null && navn.Length > 0 && sted != null && sted.Length > 0
                && breddegrad >= -90 && breddegrad <= 90 && lengdegrad >= -180 && lengdegrad <= 180) ? 1 : 0;
        }

        public bool OppdaterPassasjer(Passasjer passasjer)
        {
            return (passasjer != null);
        }
        public bool OppdaterStasjon(Stasjon stasjon)
        {
            return (stasjon != null) ? true : false;
        }
        public bool OppdaterStrekning(Hovedstrekning hvst)
        {
            return (hvst != null) ? true  : false;
        }
        public Passasjer Passasjertype(int typeId)
        {
            if (typeId == 1)
            {
                return passasjer;
            }
            else return null;
        }
        public bool settInnStasjonerIHovedstrekning(int hovstrId, IList<int> stasjonIder, int plassering)
        {
            return (hovstrId == 1 && stasjonIder.Contains(1) && plassering == 1);
        }
        public bool settNyeHovedstrekningNavn(int hovstrId, string nyttNavn, string nyttKortnavn)
        {
            return (hovstrId == 1 && nyttNavn != null && nyttKortnavn != null);
        }
        public bool settNyeStasjonKoordinater(int stasjId, double breddegrad, double lengdegrad)
        {
            return (stasjId == 1
                && breddegrad >= -90 && breddegrad <= 90 && lengdegrad >= -180 && lengdegrad <= 180);
        }
        public bool settNyeStasjonNavnOgSted(int stasjId, string nyttNavn, string nyttSted)
        {
            return (stasjId == 1 && nyttNavn != null && nyttSted != null);
        }
        public bool settNyttNettnavn(int nettId, string nyttNavn)
        {
            return (nettId == 1 && nyttNavn != null);
        }
        public bool SettPris(double nyPris)
        {
            return (nyPris >= 0);
        }
        public List<List<Stasjon>> stierMellomStasjoner(int ida, int idb)
        {
            List<Stasjon> lili = new List<Stasjon> { stasjon, stasjon, stasjon };
            List<List<Stasjon>> lilili = new List<List<Stasjon>>();
            lilili.Add(lili);
            lilili.Add(lili);
            lilili.Add(lili);
            return lilili;
        }

        public Nett HentNett(int nettId)
        {
            if (nettId == 1)
            {
                return nett;
            }
            else return null;
        }
        public List<Nett> HentNettEtterBegNavn(string begNavn)
        {
            var nettListe = new List<Nett>();
            nettListe.Add(nett);
            if (begNavn == "testnett")
            {
                return nettListe;
            }
            else return null;
        }
        public Passasjer HentPassasjer(int id)
        {
            if (id == 1)
            {
                return passasjer;
            }
            else return null;
        }
        public List<Passasjer> HentPassasjerTyper()
        {
            var passasjerTypeListe = new List<Passasjer>();
            passasjerTypeListe.Add(passasjer);
            return passasjerTypeListe;
        }
        public Pris HentPris()
        {
            return pris;
        }
        public Stasjon HentStasjon(int stasjId)
        {
            if (stasjId == 1)
            {
                return stasjon;
            }
            else return null;
        }
        public List<Stasjon> HentStasjoner(string stasjNavn, string optSted = "")
        {
            var sL = new List<Stasjon>();
            if(stasjNavn == "test")
            {
                sL.Add(stasjon);
                return sL;
            }
            return null;
        }
        public List<Stasjon> HentStasjonerEtterBegNavn(string begNavn)
        {
            var sL = new List<Stasjon>();
            if(begNavn == "test")
            {
                sL.Add(stasjon);
                return sL;
            }
            return null;
        }
        public List<Stasjon> HentStasjonerPaHovedstrekning(int hovstrId)
        {
            var sL = new List<Stasjon>();
            if (hovstrId == 1)
            {
                sL.Add(stasjon);
                return sL;
            }
            else return null;
        }
        public List<Stasjon> HentStasjonerPaNett(int nettId)
        {
            var sL = new List<Stasjon>();
            if(nettId == 1)
            {
                sL.Add(stasjon);
                return sL;
            }
            else return null;
        }
        public int leggTilHovedstrekning(Hovedstrekning hovst);
        public int leggTilNett(Nett nett);
        public int leggTilNett(string navn);
        public int leggTilStasjon(Stasjon stas);
        public int leggTilStasjon(string navn, string sted, double breddegrad, double lengdegrad);
        public bool OppdaterPassasjer(Passasjer passasjer);
        public bool OppdaterStasjon(Stasjon stasjon);
        public bool OppdaterStrekning(Hovedstrekning hvst);
        public Passasjer Passasjertype(int typeId);
        public bool settInnStasjonerIHovedstrekning(int hovstrId, IList<int> stasjonIder, int plassering);
        public bool settNyeHovedstrekningNavn(int hovstrId, string nyttNavn, string nyttKortnavn);
        public bool settNyeStasjonKoordinater(int stasjId, double breddegrad, double lengdegrad);
        public bool settNyeStasjonNavnOgSted(int stasjId, string nyttNavn, string nyttSted);
        public bool settNyttNettnavn(int nettId, string nyttNavn);
        public bool SettPris(double nyPris);
        public List<List<Stasjon>> stierMellomStasjoner(int ida, int idb);

    }
}
