<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Toevoegen.aspx.cs" Inherits="GIP_OpdrachtSW_ArneVandoorslaer_NickRoosen.Toevoegen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1213px;
            height: 353px;
        }
        .auto-style2 {
            width: 29px;
        }
        .auto-style3 {
            width: 4px;
        }
        .auto-style4 {
            text-align: justify;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h2>ONLINE LAPTOPSHOP - Item toevoegen aan winkelmandje</h2>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" rowspan="4">
                    <asp:Image ID="imgFoto" runat="server" Height="322px" Width="434px" />
                </td>
                <td class="auto-style3">ArtNr:</td>
                <td>
                    <asp:Label ID="lblArtNr" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Naam:</td>
                <td>
                    <asp:Label ID="lblNaam" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Verkoopprijs:</td>
                <td>
                    <asp:Label ID="lblPrijs" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">Voorraad</td>
                <td>
                    <asp:Label ID="lblVoorraad" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <p class="auto-style4">
            Aantal te bestellen exemplaren van dit item:
            <asp:TextBox ID="txtAantal" runat="server" Height="16px" Width="118px"></asp:TextBox>
            <asp:Button ID="txtToevoegen" runat="server" Height="25px" OnClick="txtToevoegen_Click" Text="Voeg toe aan mandje..." Width="178px" />
        </p>
        <asp:Label ID="lblFout" runat="server" ForeColor="Red"></asp:Label>
    </form>
</body>
</html>
