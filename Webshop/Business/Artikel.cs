using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GIP_OpdrachtSW_ArneVandoorslaer_NickRoosen.Business
{
    public class Artikel
    {
        private int _artnr;
        private string _naam;
        private string _foto;
        private double _prijs;
        private int _voorraad;

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

        public int Voorraad
        {
            get { return _voorraad; }
            set { _voorraad = value; }
        }
    }
}