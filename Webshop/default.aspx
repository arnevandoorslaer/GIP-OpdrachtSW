<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="GIP_OpdrachtSW_ArneVandoorslaer_NickRoosen._default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Catalogus</title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
        <form id="form1" runat="server">
        <div style="text-align:right">
<script id="tui-r581"> 
(function(t){t.r581={ 
"cid":"a9eb9831-50c5-4353-aa3a-6e0f7db77452",
"pid":"1e6d9feb-9a5f-4495-b1af-ab0afb761ac1", 
"width":"1920", 
"height":"75" 
}}(window.tweenui=window.tweenui||{}));</script> 
<script src="https://s3-eu-west-1.amazonaws.com/display.tweenui.com/s.js" async></script>
    <asp:LinkButton ID="lbAfmelden" runat="server" OnClick="LinkButton1_Click" Font-Size="X-Large" ForeColor="Black">Afmelden</asp:LinkButton>
    </div>
        <div id="page-wrap">
        <asp:GridView ID="gvCatalogus" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvCatalogus_SelectedIndexChanged" CssClass="divCenter" Width="745px">
            <Columns>
                <asp:BoundField DataField="ArtNr" HeaderText="ArtNr">
                <ItemStyle cssClass="gridGetal"/>
                </asp:BoundField>
                <asp:BoundField DataField="Naam" HeaderText="Naam">
                <ItemStyle cssClass="gridNaam" />
                </asp:BoundField>
                <asp:ImageField DataImageUrlField="Foto" DataImageUrlFormatString="~/Fotos/{0}" HeaderText="Foto">
                    <ControlStyle cssClass="gridFoto" />
                    <ItemStyle cssClass="gridFoto" />
                </asp:ImageField>
                <asp:BoundField DataField="Prijs" DataFormatString="{0:c}" HeaderText="Verkoopprijs">
                <ItemStyle cssClass="gridValuta" />
                </asp:BoundField>
                <asp:BoundField DataField="Voorraad" HeaderText="Voorraad">
                <ItemStyle cssClass="gridGetal" />
                </asp:BoundField>
                <asp:CommandField ShowSelectButton="True" SelectText="Voeg toe aan winkelmandje...">
                <ItemStyle cssClass="gridNaam" />
                </asp:CommandField>
            </Columns>
        </asp:GridView>
        <p style="text-align: left">
        <asp:Button ID="btnInhoud" runat="server" Text="Bekijk de inhoud van het winkelmandje..." Width="745px"  OnClick="btnInhoud_Click" />
        </p>
        </div>
    </form>
</body>
</html>
