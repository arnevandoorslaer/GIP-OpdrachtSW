<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="GIP_OpdrachtSW_ArneVandoorslaer_NickRoosen._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Catalogus</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h2 style="height: 32px">ONLINE LAPTOPSHOP - Catalogus<br />
        </h2>
    
    </div>
        <asp:GridView ID="gvCatalogus" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvCatalogus_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="ArtNr" HeaderText="ArtNr">
                <ItemStyle Width="50px" HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="Naam" HeaderText="Naam">
                <ItemStyle Width="200px" />
                </asp:BoundField>
                <asp:ImageField DataImageUrlField="Foto" DataImageUrlFormatString="~/Fotos/{0}" HeaderText="Foto">
                    <ControlStyle Height="70px" Width="100px" />
                    <ItemStyle Width="150px" HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:ImageField>
                <asp:BoundField DataField="Prijs" DataFormatString="{0:c}" HeaderText="Verkoopprijs">
                <ItemStyle Width="100px" HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:BoundField DataField="Voorraad" HeaderText="Voorraad">
                <ItemStyle Width="50px" HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                <asp:CommandField ShowSelectButton="True" SelectText="Voeg toe aan winkelmandje...">
                <ItemStyle Width="200px" />
                </asp:CommandField>
            </Columns>
        </asp:GridView>
        <br />
        <asp:Button ID="btnInhoud" runat="server" Text="Bekijk de inhoud van het winkelmandje..." Width="799px" OnClick="btnInhoud_Click" />
        <p>
            <asp:HyperLink ID="hlAfmelden" runat="server">Afmelden</asp:HyperLink>
        </p>
    </form>
</body>
</html>
