using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GIP_OpdrachtSW_ArneVandoorslaer_NickRoosen.Business;

namespace GIP_OpdrachtSW_ArneVandoorslaer_NickRoosen
{
    public partial class winkelmandje : System.Web.UI.Page
    {
        Controller _controller = new Controller();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvMandje.DataSource = _controller.getWinkelmand();
                gvMandje.DataBind();

                if (gvMandje.Rows.Count == 0)
                {
                    Response.Redirect("winkelmandjeleeg.aspx");
                }
                else
                {
                    lblKlantNr.Text = Session["KlantNr"].ToString();
                    lblNaam.Text = _controller.getKlant(Convert.ToInt32(Session["KlantNr"])).Naam + " " + _controller.getKlant(Convert.ToInt32(Session["KlantNr"])).Voornaam;
                    lblAdres.Text = _controller.getKlant(Convert.ToInt32(Session["KlantNr"])).Adres;
                    lblPCGemeente.Text = _controller.getKlant(Convert.ToInt32(Session["KlantNr"])).PC + " " + _controller.getKlant(Convert.ToInt32(Session["KlantNr"])).Gemeente;
                    lblDatum.Text = DateTime.Today.ToLongDateString().ToString();

                    lblExclBtw.Text = _controller.getTotalen().Excl.ToString("c");
                    lblInclBtw.Text = _controller.getTotalen().Incl.ToString("c");
                    lblBTW.Text = _controller.getTotalen().BTW.ToString("c");
                }
            }
        }

        protected void btnTerug_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }

        protected void btnBestellen_Click(object sender, EventArgs e)
        {
            _controller.maakOrder(Convert.ToInt32(Session["KlantNr"]));
            int OrderID = _controller.getOrderID(Convert.ToInt32(Session["KlantNr"]));

            for (int i = 0; i < gvMandje.Rows.Count; i++)
            {
                int ArtNr = int.Parse(gvMandje.Rows[i].Cells[2].Text);
                int Aantal = int.Parse(gvMandje.Rows[i].Cells[4].Text);
                double prijs = double.Parse(_controller.getTotalen().Excl.ToString());

                _controller.setMand(ArtNr, Convert.ToInt32(Session["KlantNr"]));
                _controller.deleteMand();
                _controller.saveBestelling(OrderID, ArtNr, Aantal, prijs);                
            }
            Session["Totaal"] = lblExclBtw.Text = _controller.getTotalen().Excl.ToString("c");
            Session["OrderNr"] = OrderID;
            Response.Redirect("Bestelbevestiging.aspx");
        }

        protected void gvMandje_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int artnr = Convert.ToInt32(gvMandje.Rows[e.RowIndex].Cells[2].Text);
            int klantnr = Convert.ToInt32(Session["KlantNr"]);
            int aantal = Convert.ToInt32(gvMandje.Rows[e.RowIndex].Cells[4].Text);

            _controller.setMand(artnr, klantnr);
            _controller.deleteMand();

            _controller.setVoorraad(artnr, aantal);

            gvMandje.DataSource = _controller.getWinkelmand();
            gvMandje.DataBind();

            gvMandje.DataSource = _controller.getWinkelmand();
            gvMandje.DataBind();

            if (gvMandje.Rows.Count == 0)
            {
                Response.Redirect("winkelmandjeleeg.aspx");
            }
            else
            {
                lblExclBtw.Text = _controller.getTotalen().Excl.ToString("c");
                lblInclBtw.Text = _controller.getTotalen().Incl.ToString("c");
                lblBTW.Text = _controller.getTotalen().BTW.ToString("c");
            }
        }
    }
}