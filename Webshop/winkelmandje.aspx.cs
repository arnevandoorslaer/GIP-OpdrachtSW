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
    public partial class winkelmandje : System.Web.UI.Page
    {
        Controller _controller = new Controller();
        protected void Page_Load(object sender, EventArgs e)
        {
            int KlantNr = Convert.ToInt32(Session["KlantNr"]);

            if (!IsPostBack)
            {
                gvMandje.DataSource = _controller.getWinkelmand(KlantNr);
                gvMandje.DataBind();

                if (gvMandje.Rows.Count == 0)
                {
                    Response.Redirect("winkelmandjeleeg.aspx");
                }
                else
                {
                    lblKlantNr.Text = KlantNr.ToString();
                    lblNaam.Text = _controller.getKlant(KlantNr).Voornaam + " " + _controller.getKlant(KlantNr).Naam;
                    lblAdres.Text = _controller.getKlant(KlantNr).Adres;
                    lblPCGemeente.Text = _controller.getKlant(KlantNr).PC + " " + _controller.getKlant(KlantNr).Gemeente;
                    lblDatum.Text = DateTime.Today.ToLongDateString().ToString();

                    lblExclBtw.Text = _controller.getTotalen(KlantNr).Excl.ToString("c");
                    lblInclBtw.Text = _controller.getTotalen(KlantNr).Incl.ToString("c");
                    lblBTW.Text = _controller.getTotalen(KlantNr).BTW.ToString("c");
                }
            }
        }

        protected void btnTerug_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }

        protected void btnBestellen_Click(object sender, EventArgs e)
        {
            int KlantNr = Convert.ToInt32(Session["KlantNr"]);

            _controller.saveBestelling(KlantNr);
            int OrderID = _controller.getOrderNr();


            for (int i = 0; i < gvMandje.Rows.Count; i++)
            {
                int ArtNr = int.Parse(gvMandje.Rows[i].Cells[2].Text);
                int Aantal = int.Parse(gvMandje.Rows[i].Cells[4].Text);
                double prijs = double.Parse(_controller.getTotalen(KlantNr).Excl.ToString());

                _controller.setMand(ArtNr, KlantNr);
                _controller.deleteMand();
                _controller.saveBestellijn(OrderID, ArtNr, Aantal, prijs);                
            }

            Session["Totaal"] = lblInclBtw.Text;
            Session["OrderNr"] = OrderID;
            Response.Redirect("Bestelbevestiging.aspx");
        }

        protected void gvMandje_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int klantnr = Convert.ToInt32(Session["KlantNr"]);
            int artnr = Convert.ToInt32(gvMandje.Rows[e.RowIndex].Cells[2].Text);
            int aantal = Convert.ToInt32(gvMandje.Rows[e.RowIndex].Cells[4].Text);

            if (_controller.CheckMand(klantnr, artnr) == true)
            {
                _controller.setMand(artnr, klantnr);
                _controller.deleteMand();

                _controller.setVoorraad(artnr, aantal);

            }

            gvMandje.DataSource = _controller.getWinkelmand(klantnr);
            gvMandje.DataBind();
            if (gvMandje.Rows.Count == 0)
            {
                Response.Redirect("winkelmandjeleeg.aspx");
            }
            else
            {
                lblExclBtw.Text = _controller.getTotalen(klantnr).Excl.ToString("c");
                lblInclBtw.Text = _controller.getTotalen(klantnr).Incl.ToString("c");
                lblBTW.Text = _controller.getTotalen(klantnr).BTW.ToString("c");
            }

        }

        protected void gvMandje_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("Login.aspx");
        }
    }
}