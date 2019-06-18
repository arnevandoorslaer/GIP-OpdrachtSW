using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GIP_OpdrachtSW_ArneVandoorslaer_NickRoosen.Business;
using System.Web.Security;

namespace GIP_OpdrachtSW_ArneVandoorslaer_NickRoosen
{
    public partial class Login : System.Web.UI.Page
    {
        Controller _controller = new Controller();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            _controller.setKlant(txtGebrNaam.Text, txtWachtwoord.Text);
            Session["KlantNr"] = _controller.getKlant().KlantNr;

            if (_controller.controleerCredentials() == true)
            {
                FormsAuthentication.RedirectFromLoginPage(txtGebrNaam.Text, false);
            }
            else
            {
                lblUitvoer.Text = "Ongeldige login.";   
            }
        }
    }
}