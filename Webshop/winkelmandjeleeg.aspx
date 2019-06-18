<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="winkelmandjeleeg.aspx.cs" Inherits="GIP_OpdrachtSW_ArneVandoorslaer_NickRoosen.winkelmandjeleeg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Winkelmandjeleeg</title>
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
        </div>
        <p></p>
        <p>Het winkelmandje is leeg. Klik op de knop om terug te keren naar de catalogus.</p>
        <asp:Button ID="btnTerug" runat="server" OnClick="btnTerug_Click" Text="Terug naar catalogus..." />
    </form>
</body>
</html>
