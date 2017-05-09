<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="winkelmandje.aspx.cs" Inherits="GIP_OpdrachtSW_ArneVandoorslaer_NickRoosen.winkelmandje" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Winkelmandje</title>
    <style type="text/css">
        .auto-style1 {
            width: 46%;
        }
        .auto-style2 {
            width: 241px;
        }
        .auto-style3 {
            width: 794px;
        }
        .auto-style4 {
            width: 386px;
        }
        .auto-style5 {
            width: 794px;
            height: 23px;
        }
        .auto-style6 {
            width: 386px;
            height: 23px;
        }
        .auto-style7 {
            width: 46%;
        }
        .auto-style8 {
            width: 788px;
        }
        .auto-style9 {
            width: 415px;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h2>ONLINE LAPTOPSHOP - Winkelmandje</h2>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Klantnummer:</td>
                <td>
                    <asp:Label ID="lblKlantNr" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Naam:</td>
                <td>
                    <asp:Label ID="lblNaam" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Adres:</td>
                <td>
                    <asp:Label ID="lblAdres" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" rowspan="2">&nbsp;</td>
                <td>
                    <asp:Label ID="lblPCGemeente" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Besteldatum:</td>
                <td>
                    <asp:Label ID="lblDatum" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <asp:GridView ID="gvMandje" runat="server" AutoGenerateColumns="False" Width="602px" OnRowDeleting="gvMandje_RowDeleting">
            <Columns>
                <asp:CommandField DeleteText="" ShowDeleteButton="True" ButtonType="Image" DeleteImageUrl="~/Fotos/Bin.png">
                <ControlStyle Height="40px" Width="35px" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="75px" />
                </asp:CommandField>
                <asp:ImageField DataImageUrlField="Foto" DataImageUrlFormatString="~/Fotos/{0}" HeaderText="Foto">
                    <ControlStyle Height="70px" Width="100px" />
                    <ItemStyle Width="150px" HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:ImageField>
                <asp:BoundField DataField="ArtNr" HeaderText="ArtNr">
                <ItemStyle Width="50px" HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="Naam" HeaderText="Naam">
                <ItemStyle Width="500px" HorizontalAlign="Left" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField HeaderText="Aantal" DataField="Aantal" >
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="50px" />
                </asp:BoundField>
                <asp:BoundField DataField="Prijs" DataFormatString="{0:c}" HeaderText="Prijs">
                <ItemStyle Width="150px" HorizontalAlign="Right" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="Totaal" DataFormatString="{0:c}" HeaderText="Totaal" >
                <ItemStyle HorizontalAlign="Right" VerticalAlign="Middle" Width="150px" />
                </asp:BoundField>
            </Columns>
        </asp:GridView>
        <table class="auto-style1">
            <tr>
                <td class="auto-style5" style="text-align: right">Totaal excl BTW:</td>
                <td class="auto-style6" style="text-align: right">
                    <asp:Label ID="lblExclBtw" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" style="text-align: right">BTW:</td>
                <td class="auto-style4" style="text-align: right">
                    <asp:Label ID="lblBTW" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" style="text-align: right">Totaal incl BTW:</td>
                <td class="auto-style4" style="text-align: right">
                    <asp:Label ID="lblInclBtw" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <table class="auto-style7">
            <tr>
                <td class="auto-style9" style="text-align: center; width: 600px;">
                    <asp:Button ID="btnBestellen" runat="server" OnClick="btnBestellen_Click" Text="Bestellen..." Width="231px" />
                </td>
                <td class="auto-style8" style="text-align: center; width: 600px;">
                    <asp:Button ID="btnTerug" runat="server" OnClick="btnTerug_Click" Text="Terug naar catalogus..." />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
