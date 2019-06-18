using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GIP_OpdrachtSW_ArneVandoorslaer_NickRoosen.Business
{
    public class WinkelmandItem
    {
        private int _artnr;
        private int _aantal;
        private string _naam;
        private string _foto;
        private double _prijs;
        private double _totaal;

        public int ArtNr
        {
            get { return _artnr; }
            set { _artnr = value; }
        }

        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        public string Foto
        {
            get { return _foto; }
            set { _foto = value; }
        }

        public double Prijs
        {
            get { return _prijs; }
            set { _prijs = value; }
        }

        public int Aantal
        {
            get { return _aantal; }
            set { _aantal = value; }
        }

        public double Totaal
        {
            get { return _totaal; }
            set { _totaal = value; }
        }
    }
}