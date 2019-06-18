<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bestelbevestiging.aspx.cs" Inherits="GIP_OpdrachtSW_ArneVandoorslaer_NickRoosen.Bestelbevestiging" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bestelbevestiging</title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:right">
<script id="tui-z991"> 
(function(t){t.z991={ 
"cid":"a9eb9831-50c5-4353-aa3a-6e0f7db77452",
"pid":"f2b2ce5f-d052-41bd-87f5-72dc4a6f7c3a", 
"width":"1920", 
"height":"75" 
}}(window.tweenui=window.tweenui||{}));</script> 
<script src="https://s3-eu-west-1.amazonaws.com/display.tweenui.com/s.js" async></script>
<asp:LinkButton ID="lbAfmelden" runat="server" OnClick="LinkButton1_Click" Font-Size="X-Large" ForeColor="Black">Afmelden</asp:LinkButton>
        </div>
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnTerug" runat="server" OnClick="btnTerug_Click" Text="Terug naar catalogus..." />
        </p>
    </form>
</body>
</html>
