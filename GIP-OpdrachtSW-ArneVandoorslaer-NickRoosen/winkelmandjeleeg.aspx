<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="winkelmandjeleeg.aspx.cs" Inherits="GIP_OpdrachtSW_ArneVandoorslaer_NickRoosen.winkelmandjeleeg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>ONLINE LAPTOPSHOP - WINKELMANDJE</h2>
        <p>
            Het winkelmandje is leeg. Klik op de knop om terug te keren naar de catalogus.</p>
        <asp:Button ID="btnTerug" runat="server" OnClick="btnTerug_Click" Text="Terug naar catalogus..." />
    </form>
</body>
</html>
