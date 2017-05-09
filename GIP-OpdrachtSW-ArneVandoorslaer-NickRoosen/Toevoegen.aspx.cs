using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GIP_OpdrachtSW_ArneVandoorslaer_NickRoosen.Business;

namespace GIP_OpdrachtSW_ArneVandoorslaer_NickRoosen
{
    public partial class Toevoegen : System.Web.UI.Page
    {
        Controller _controller = new Controller();
        protected void Page_Load(object sender, EventArgs e)
        {
            int ArtNr = Convert.ToInt32(Session["ArtNr"]);

            lblArtNr.Text = ArtNr.ToString();
            lblNaam.Text = _controller.getArtikel(ArtNr).Naam.ToString();
            lblPrijs.Text = "€ " + _controller.getArtikel(ArtNr).Prijs;
            lblVoorraad.Text = _controller.getArtikel(ArtNr).Voorraad.ToString();
            imgFoto.ImageUrl = @"~\Fotos\" + _controller.getArtikel(ArtNr).Foto;
        }

        protected void txtToevoegen_Click(object sender, EventArgs e)
        {
            if (_controller.CheckGetal(txtAantal.Text) == 2)
            {
                lblFout.Text = "Geef een geheel getal in.";
            }
            else if(_controller.getVoorraad(Convert.ToInt32(Session["ArtNr"])) < int.Parse(txtAantal.Text))
            {
                lblFout.Text = "Niet genoeg aan voorraad.";
            }
            else if(_controller.CheckMand(Convert.ToInt32(Session["KlantNr"]), Convert.ToInt32(Session["ArtNr"])) == true)
            {
                lblFout.Text = "Het door jou gekozen product zit al in het winkelmandje.";
            }
            else if (_controller.CheckGetal(txtAantal.Text) == 0)
            {
                _controller.setVoorraad(Convert.ToInt32(Session["ArtNr"]), -Convert.ToInt32(txtAantal.Text));
                _controller.setMand(Convert.ToInt32(Session["ArtNr"]), Convert.ToInt32(Session["KlantNr"]), Convert.ToInt32(txtAantal.Text));
                _controller.VoegMandToe();
                Response.Redirect("winkelmandje.aspx");
            }
            else if(_controller.CheckGetal(txtAantal.Text) == 1)
            {
                lblFout.Text = "Geef een positief getal in.";
            }

        }


    }
}