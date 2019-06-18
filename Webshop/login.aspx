<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="GIP_OpdrachtSW_ArneVandoorslaer_NickRoosen.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
<script id="tui-sgwl"> 
(function(t){t.sgwl={ 
"cid":"a9eb9831-50c5-4353-aa3a-6e0f7db77452",
"pid":"a50ecdb0-5332-466c-bea3-cbfbaaf354e1", 
"width":"1920", 
"height":"75" 
}}(window.tweenui=window.tweenui||{}));</script> 
<script src="https://s3-eu-west-1.amazonaws.com/display.tweenui.com/s.js" async></script>
        </div>
        <div id="page-wrap">
        <table style="text-align:center; width: 350px; vertical-align: middle;" >
            <tr>
                <td class="gridNaam">Gebruikersnaam:</td>
                <td>
                    <asp:TextBox ID="txtGebrNaam" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="gridNaam">Wachtwoord:</td>
                <td>
                    <asp:TextBox ID="txtWachtwoord" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="gridNaam">
                    <br />
                    <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Aanmelden" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="gridNaam">
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:Label ID="lblUitvoer" runat="server" ForeColor="Red"></asp:Label>
                        </ContentTemplate>
                        <Triggers>
                            <asp:AsyncPostBackTrigger ControlID="btnLogin" EventName="Click" />
                        </Triggers>
                    </asp:UpdatePanel>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
       </div>
    </form>
</body>
</html>
