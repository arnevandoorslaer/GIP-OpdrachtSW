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
    public partial class _default : System.Web.UI.Page
    {
        Controller _controller = new Controller();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Artikels worden geladen in de gridview.
            gvCatalogus.DataSource = _controller.getArtikels();
            gvCatalogus.DataBind();

            //De voorraad wordt opgehaald en er wordt gekeken of het product nog in voorraad zit.
            for (int i = 0;i < gvCatalogus.Rows.Count; i++)
            {
                if(int.Parse(gvCatalogus.Rows[i].Cells[4].Text) == 0) gvCatalogus.Rows[i].Cells[5].Text = "Niet op voorraad";
            }
        }

        protected void btnInhoud_Click(object sender, EventArgs e)
        {
            Response.Redirect("winkelmandje.aspx");
        }

        protected void gvCatalogus_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Wordt op de volgende pagina gebruikt om het artikel op te vragen.
            Session["ArtNr"] = gvCatalogus.SelectedRow.Cells[0].Text;
            Response.Redirect("Toevoegen.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("Login.aspx");  
        }
    }
}