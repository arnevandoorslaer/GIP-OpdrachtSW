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
            int ArtNr = Convert.ToInt32(Session["ArtNr"]);
            int KlantNr = Convert.ToInt32(Session["KlantNr"]);

            if (_controller.CheckMand(KlantNr, ArtNr) == true)
            {
                lblFout.Text = "Dit product zit al in het mandje. Als u het aantal wilt wijzigen verwijder het dan uit het mandje en voeg het correcte aantal toe.";
            }
            else if (_controller.CheckGetal(txtAantal.Text) == 2)
            {
                lblFout.Text = "Geef een geheel getal in.";
            }
            else if(_controller.getVoorraad(ArtNr) < int.Parse(txtAantal.Text))
            {
                lblFout.Text = "Niet genoeg aan voorraad.";
            }
            else if (_controller.CheckGetal(txtAantal.Text) == 0)
            {
                _controller.setVoorraad(ArtNr, -Convert.ToInt32(txtAantal.Text));
                _controller.setMand(ArtNr, KlantNr, Convert.ToInt32(txtAantal.Text));
                _controller.VoegMandToe();
                Response.Redirect("winkelmandje.aspx");
            }
            else if(_controller.CheckGetal(txtAantal.Text) == 1)
            {
                lblFout.Text = "Geef een positief getal in.";
            }

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("Login.aspx");
        }

        protected void btnTerug_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }
    }
}