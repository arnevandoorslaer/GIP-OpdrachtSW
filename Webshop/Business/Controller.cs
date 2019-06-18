using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GIP_OpdrachtSW_ArneVandoorslaer_NickRoosen.Persistence;

namespace GIP_OpdrachtSW_ArneVandoorslaer_NickRoosen.Business
{
    public class Controller
    {
        //Object aanmaken van de class persistencecode.
        PersistenceCode _pc = new PersistenceCode();


        //Object aanmaken van de class Getalchecker.
        GetalChecker _gc = new GetalChecker();
        //Controleren of een getal een positief geheel getal is.
        public int CheckGetal(string Getal)
        {
            return _gc.Check(Getal);
        }


        //Object aanmaken van de class Totalen.
        Totalen _totalen = new Totalen();
        //Totalen ophalen
        public Totalen getTotalen(int KlantNr)
        {
            return _pc.GetTotalen(KlantNr);
        }


        //Object aanmaken van de class Klant.
        Klant _klant = new Klant();
        //Een klant zijn aanmeldgegevens doorsturen.
        public void setKlant(string GN, string WW)
        {
            _klant.GebrNaam = GN;
            _klant.Wachtwoord = WW;
        }
        //Een klant zijn credentials controleren.
        public bool controleerCredentials()
        {
            if (_pc.controleerCredentials(_klant).GebrNaam == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //Eén klant ophalen.
        public Klant getKlant()
        {
            return _pc.controleerCredentials(_klant);
        }
        //Eén klant ophalen aan de hand van zijn klantennummer.
        public Klant getKlant(int KlantNr)
        {
            return _pc.getKlant(KlantNr);
        }


        //Alle artikels opvragen en doorsturen.
        public List<Artikel> getArtikels()
        {
            return _pc.GetArtikels();
        }
        //Eén artikel wordt opgevraagd op basis van het artikelnummer
        public Artikel getArtikel(int ArtNr)
        {
            return _pc.GetArtikel(ArtNr);
        }
        //Voorraad van één artikel opvragen
        public int getVoorraad(int ArtNr)
        {
            return _pc.GetVoorraad(ArtNr);
        }
        //Voorraad aanpassen
        public void setVoorraad(int ArtNr, int Aantal)
        {
            _pc.SetVoorraad(ArtNr, Aantal);
        }


        //Object aanmaken van de class Winkelmand.
        Winkelmand _wm = new Winkelmand();
        //Zet de attributen van een mand in een object om het daarna toe te voegen in de database.
        public void setMand(int ArtNr, int KlantNr, int Aantal)
        {
            _wm.Aantal = Aantal;
            _wm.ArtNr = ArtNr;
            _wm.KlantNr = KlantNr;
        }
        //Zet de attributen van een mand in een object om het daarna te verwijderen uit de database.
        public void setMand(int ArtNr, int KlantNr)
        {
            _wm.ArtNr = ArtNr;
            _wm.KlantNr = KlantNr;
        }
        //Mandje toevoegen in de database
        public void VoegMandToe()
        {
            _pc.SetMand(_wm);
        }
        //Mandje verwijderen uit de database
        public void deleteMand()
        {
            _pc.DeleteMand(_wm);
        }
        //Winkelmand ophalen
        public List<WinkelmandItem> getWinkelmand(int KlantNr)
        {
            return _pc.Getwinkelmanditem(KlantNr);
        }
        //Controleert of het gekozen product niet al in het mandje zit.
        public bool CheckMand(int KlantNr, int ArtNr)
        {
            return _pc.CheckMand(KlantNr, ArtNr);
        }


        //Object aanmaken van de class Bestelling.
        Bestelling _bestelling = new Bestelling();
        //Een bestelling wordt opgeslagen.
        public void saveBestelling(int KlantNr)
        {
            _bestelling.KlantNr = KlantNr;
            _bestelling.Datum = DateTime.Now;
            _pc.maakBestelling(_bestelling);
        }
        //OrderNr ophalen
        public int getOrderNr()
        {
            return _pc.getOrderNr(_bestelling);
        }

        //Object aanmaken van de class Bestellijn.
        Bestellijn _bestellijn = new Bestellijn();
        public void saveBestellijn(int OrderNr, int ArtNr, int Aantal, double Prijs)
        {
            _bestellijn.Prijs = Prijs;
            _bestellijn.OrderNr = OrderNr;
            _bestellijn.ArtNr = ArtNr;
            _bestellijn.Aantal = Aantal;
            _pc.saveBestellijn(_bestellijn);
        }
    }
}