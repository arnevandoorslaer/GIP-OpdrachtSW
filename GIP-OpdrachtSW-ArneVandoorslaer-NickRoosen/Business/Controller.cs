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
        //Object aanmaken van de class artikel.
        Artikel _artikel = new Artikel();
        //Object aanmaken van de class Getalchecker.
        GetalChecker _gc = new GetalChecker();
        //Object aanmaken van de class Winkelmand.
        Winkelmand _wm = new Winkelmand();
        //Object aanmaken van de class Klant.
        Klant _klant = new Klant();
        //Object aanmaken van de class Totalen.
        Totalen _totalen = new Totalen();

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

        //Controleren of een getal een positief geheel getal is.
        public int CheckGetal(string Getal)
        {
            return _gc.Check(Getal);
        }
        //Voorraad van één artikel opvragen
        public int getVoorraad(int ArtNr)
        {
            return _pc.GetVoorraad(ArtNr);
        }

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

        //Eén klant ophalen.
        public Klant getKlant(int KlantNr)
        {
            return _pc.GetKlant(KlantNr);
        }

        //Winkelmand ophalen
        public List<WinkelmandItem> getWinkelmand()
        {
            return _pc.Getwinkelmanditem();
        }

        //Totalen ophalen
        public Totalen getTotalen()
        {
            return _pc.GetTotalen();
        }

        //Voorraad aanpassen
        public void setVoorraad(int ArtNr, int Aantal)
        {
            _pc.SetVoorraad(ArtNr, Aantal);
        }

        public bool CheckMand(int KlantNr, int ArtNr)
        {
            return _pc.CheckMand(KlantNr,ArtNr);
        }

        public void maakOrder(int KlantNr)
        {
            _pc.maakOrder(KlantNr, DateTime.Now);
        }

        public int getOrderID(int KlantNr)
        {
            return _pc.getOrderNr(KlantNr);
        }

        public void saveBestelling(int OrderNr, int ArtNr, int Aantal, double Prijs)
        {
            _pc.saveBestelling(OrderNr, ArtNr, Aantal, Prijs);
        }
    }
}