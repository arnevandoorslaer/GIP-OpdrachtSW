using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GIP_OpdrachtSW_ArneVandoorslaer_NickRoosen.Business
{
    public class Winkelmand
    {
        private int _klantnr;
        private int _artnr;
        private int _aantal;

        public int KlantNr
        {
            get { return _klantnr; }
            set { _klantnr = value; }
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


    }
}