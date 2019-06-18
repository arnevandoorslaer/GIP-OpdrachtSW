using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GIP_OpdrachtSW_ArneVandoorslaer_NickRoosen.Business
{
    public class GetalChecker
    {
        public int Check(string _getal)
        {
            Controller _controller = new Controller();
            int iftrue = 0;
            if (int.TryParse(_getal, out iftrue) == true)
            {
                if(iftrue > 0)
                {
                    //positief getal + geheel
                    return 0;
                }
                //negatief getal + geheel
                else return 1;
            }
            //niet geheel
            else return 2;
        }
    }
}