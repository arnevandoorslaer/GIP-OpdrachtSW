﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bestelbevestiging.aspx.cs" Inherits="GIP_OpdrachtSW_ArneVandoorslaer_NickRoosen.Bestelbevestiging" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h2>ONLINE LAPTOPSHOP - BESTELBEVESTIGING</h2>
    
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
