using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GIP_OpdrachtSW_ArneVandoorslaer_NickRoosen.Business
{
    public class Bestelling
    {
        private int _orderNr;
        private int _klantNr;
        private DateTime _datum;

        public int KlantNr
        {
            get { return _klantNr; }
            set { _klantNr = value; }
        }

        public int OrderNr
        {
            get { return OrderNr; }
            set { OrderNr = value; }
        }

        public DateTime Datum
        {
            get { return _datum; }
            set { _datum = value; }
        }
    }
}