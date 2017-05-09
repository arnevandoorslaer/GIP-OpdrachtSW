using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GIP_OpdrachtSW_ArneVandoorslaer_NickRoosen.Business;

namespace GIP_OpdrachtSW_ArneVandoorslaer_NickRoosen
{
    public partial class _default : System.Web.UI.Page
    {
        Controller _controller = new Controller();
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["KlantNr"] = 1;

            //Hier worden de artikels geladen in de gridview.
            gvCatalogus.DataSource = _controller.getArtikels();
            gvCatalogus.DataBind();

            //Hier wordt de voorraad per rij opgevraagd en op basis daarvan wordt gekeken of je het product kan toevoegen aan het winkelmandje of niet.
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
    }
}