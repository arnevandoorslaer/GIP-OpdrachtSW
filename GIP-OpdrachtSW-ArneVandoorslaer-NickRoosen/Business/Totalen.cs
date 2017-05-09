using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GIP_OpdrachtSW_ArneVandoorslaer_NickRoosen.Business
{
    public class Totalen
    {
        private double _incl;
        private double _excl;
        private double _btw;

        public double Incl
        {
            get { return _incl; }
            set { _incl = value; }
        }

        public double Excl
        {
            get { return _excl; }
            set { _excl = value; }
        }

        public double BTW
        {
            get { return _btw; }
            set { _btw = value; }
        }
    }
}