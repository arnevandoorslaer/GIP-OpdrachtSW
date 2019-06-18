<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Toevoegen.aspx.cs" Inherits="GIP_OpdrachtSW_ArneVandoorslaer_NickRoosen.Toevoegen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Toevoegen</title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:right">
<script id="tui-ux98"> 
(function(t){t.ux98={ 
"cid":"a9eb9831-50c5-4353-aa3a-6e0f7db77452",
"pid":"d10cf98f-c4e4-4e28-9582-bb7972c194b0", 
"width":"1920", 
"height":"75" 
}}(window.tweenui=window.tweenui||{}));</script> 
<script src="https://s3-eu-west-1.amazonaws.com/display.tweenui.com/s.js" async></script>
<asp:LinkButton ID="lbAfmelden" runat="server" OnClick="LinkButton1_Click" Font-Size="X-Large" ForeColor="Black">Afmelden</asp:LinkButton>
        </div>
        <div id="page-wrap">
        <table class="toevoegtabel">
            <tr>
                <td class="toevoegFoto">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
                    <asp:Image ID="imgFoto" runat="server" class="toevoegFoto"/>
                </td>
                <td class="toevoegCel">
                    <br />
                    ArtNr:<br />
                    <br />
                    Naam:<br />
                    <br />
                    Verkoopprijs:<br />
                    <br />
                    Voorraad:</td>
                <td class="toevoegCel">
                    <br />
                    <asp:Label ID="lblArtNr" runat="server"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="lblNaam" runat="server" width="500px" ></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="lblPrijs" runat="server"></asp:Label>
                    <br />
                    <br />
                    <asp:Label ID="lblVoorraad" runat="server"></asp:Label>
                </td>
            </tr>
            </table>
        <p style="text-align: right">
            Aantal te bestellen exemplaren van dit item:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAantal" runat="server" Width="106px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="txtToevoegen" runat="server" OnClick="txtToevoegen_Click" Text="Voeg toe aan mandje..." />
            <asp:Button ID="btnTerug" runat="server" OnClick="btnTerug_Click" Text="Terug naar Catalogus..." />
        </p>
            <asp:UpdatePanel style="text-align:left" ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Label ID="lblFout" runat="server" ForeColor="Red"></asp:Label>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="txtToevoegen" EventName="Click" />
                </Triggers>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
