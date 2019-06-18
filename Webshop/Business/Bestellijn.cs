using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GIP_OpdrachtSW_ArneVandoorslaer_NickRoosen.Business
{
    public class Bestellijn
    {
        private int _orderNr;
        private int _artnr;
        private int _aantal;
        private double _prijs;

        public int OrderNr
        {
            get { return _orderNr; }
            set { _orderNr = value; }
        }

        public int ArtNr
        {
            get { return _artnr; }
            set { _artnr = value; }
        }

        public int Aantal
        {
            get { return _aantal; }
            set { _aantal = value; }
        }

        public double Prijs
        {
            get { return _prijs; }
            set { _prijs = value; }
        }
    }
}