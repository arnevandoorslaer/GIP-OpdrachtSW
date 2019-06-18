using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GIP_OpdrachtSW_ArneVandoorslaer_NickRoosen.Business
{
    public class Klant
    {
        private int _klantNr;
        private string _naam;
        private string _voornaam;
        private string _adres;
        private string _pc;
        private string _gemeente;
        private string _mail;
        private string _gebrnaam;
        private string _wachtwoord;

        public int KlantNr
        {
            get { return _klantNr; }
            set { _klantNr = value; }
        }

        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        public string Voornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }

        public string Adres
        {
            get { return _adres; }
            set { _adres = value; }
        }

        public string PC
        {
            get { return _pc; }
            set { _pc = value; }
        }

        public string Gemeente
        {
            get { return _gemeente; }
            set { _gemeente = value; }
        }

        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }

        public string GebrNaam
        {
            get { return _gebrnaam; }
            set { _gebrnaam = value; }
        }

        public string Wachtwoord
        {
            get { return _wachtwoord; }
            set { _wachtwoord = value; }
        }
    }
}