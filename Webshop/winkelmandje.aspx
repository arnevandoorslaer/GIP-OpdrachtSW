<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="winkelmandje.aspx.cs" Inherits="GIP_OpdrachtSW_ArneVandoorslaer_NickRoosen.winkelmandje" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Winkelmandje</title>
    <link href="StyleSheet.css" rel="stylesheet" />
    </head>
<body>
    <form id="form1" runat="server">

    <div style="text-align:right">
<script id="tui-ni6r"> 
(function(t){t.ni6r={ 
"cid":"a9eb9831-50c5-4353-aa3a-6e0f7db77452",
"pid":"cd1cb310-4533-4f21-81dc-f98200eea270", 
"width":"1920", 
"height":"75" 
}}(window.tweenui=window.tweenui||{}));</script> 
<script src="https://s3-eu-west-1.amazonaws.com/display.tweenui.com/s.js" async></script>
<asp:LinkButton ID="lbAfmelden" runat="server" OnClick="LinkButton1_Click" Font-Size="X-Large" ForeColor="Black">Afmelden</asp:LinkButton>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    </div>
        <div id="page-wrap">
        <table>
            <tr>
                <td class="align">Klantnummer:</td>
                <td class="align"><asp:Label ID="lblKlantNr" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td class="align">Naam:</td>
                <td class="align"><asp:Label ID="lblNaam" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td class="align">Adres:</td>
                <td class="align"><asp:Label ID="lblAdres" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td class="align" rowspan="2">&nbsp;</td>
                <td class="align"><asp:Label ID="lblPCGemeente" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="align">Besteldatum:</td>
                <td class="align"><asp:Label ID="lblDatum" runat="server"></asp:Label></td>
            </tr>
        </table>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:GridView ID="gvMandje" runat="server" AutoGenerateColumns="False" OnRowDeleting="gvMandje_RowDeleting" OnSelectedIndexChanged="gvMandje_SelectedIndexChanged" Width="750px">
                        <Columns>
                            <asp:CommandField ButtonType="Image" DeleteImageUrl="~/Fotos/Bin.png" ShowDeleteButton="True">
                            <ControlStyle cssClass="gridDelete" />
                            <ItemStyle />
                            </asp:CommandField>
                            <asp:ImageField DataImageUrlField="Foto" DataImageUrlFormatString="~/Fotos/{0}" HeaderText="Foto">
                                <ControlStyle CssClass="gridFoto" />
                                <ItemStyle CssClass="gridFoto" />
                            </asp:ImageField>
                            <asp:BoundField DataField="ArtNr" HeaderText="ArtNr">
                            <ItemStyle cssClass="gridGetal" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Naam" HeaderText="Naam">
                            <ItemStyle cssClass="gridNaam" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Aantal" HeaderText="Aantal">
                            <ItemStyle cssClass="gridGetal" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Prijs" DataFormatString="{0:c}" HeaderText="Prijs">
                            <ItemStyle cssClass="gridValuta" />
                            </asp:BoundField>
                            <asp:BoundField DataField="Totaal" DataFormatString="{0:c}" HeaderText="Totaal">
                            <ItemStyle cssClass="gridValuta" />
                            </asp:BoundField>
                        </Columns>
                    </asp:GridView>
                </ContentTemplate>
            </asp:UpdatePanel>
        <table style="Width: 750px">
            <tr>
                <td style="text-align: right;Width: 610px">Totaal excl BTW:</td>
                <td style="text-align: right">
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                        <ContentTemplate>
                            <asp:Label ID="lblExclBtw" runat="server"></asp:Label>
                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="gvMandje" EventName="RowDeleting" />
                        </Triggers>
                    </asp:UpdatePanel>
                </td>
            </tr>
            <tr>
                <td style="text-align: right;Width: 610px"" class="auto-style13">BTW:</td>
                <td style="text-align: right">
                    <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                        <ContentTemplate>
                            <asp:Label ID="lblBTW" runat="server"></asp:Label>
                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="gvMandje" EventName="RowDeleting" />
                        </Triggers>
                    </asp:UpdatePanel>
                </td>
            </tr>
            <tr>
                <td style="text-align: right;Width: 610px"" class="auto-style13">Totaal incl BTW:</td>
                <td style="text-align: right">
                    <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                        <ContentTemplate>
                            <asp:Label ID="lblInclBtw" runat="server"></asp:Label>
                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="gvMandje" EventName="RowDeleting" />
                        </Triggers>
                    </asp:UpdatePanel>
                </td>
            </tr>
        </table>
        <table style="Width: 750px">
            <tr>
                <td style="text-align: center; width: 375px">
                    <asp:Button ID="btnBestellen" runat="server" OnClick="btnBestellen_Click" cssClass="WinkelmandButton" Text="Bestellen..."/>
                </td>
                <td style="text-align: center; width: 375px">
                    <asp:Button ID="btnTerug" runat="server" OnClick="btnTerug_Click" cssClass="WinkelmandButton" Text="Terug naar catalogus..." />
                </td>
            </tr>
        </table>
            </div>
    </form>
</body>
</html>
