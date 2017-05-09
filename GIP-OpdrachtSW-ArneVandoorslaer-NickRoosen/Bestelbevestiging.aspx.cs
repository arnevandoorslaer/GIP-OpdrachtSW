using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GIP_OpdrachtSW_ArneVandoorslaer_NickRoosen
{
    public partial class Bestelbevestiging : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Uw bestelling met ordernummer " + Session["OrderNr"] + " werd door ons goed ontvangen.";
            Label2.Text = "Na betaling van " + Session["Totaal"] + " op rekeningnummer BE91 5612 1236 7595 zullen wij overgaan tot de verzending van de laptops.";
            Label3.Text = "Gelieve het ordernummer als betalingsreferentie mee te geven.";
            Label4.Text = "Bedankt voor uw vertrouwen!";

        }

        protected void btnTerug_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }
    }
}