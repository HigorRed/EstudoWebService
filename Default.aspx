<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EstudoWebService.Default" Async="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtTemp" runat="server" />
            <asp:TextBox ID="txtUmid" runat="server" />
            <asp:Button ID="btnSimularEnvioParamentos" Text="Simular" runat="server" OnClick="SimularEnvioParamentos_Click" />
            <asp:Label ID="lblResultado" Text="" runat="server"  />
        </div>
    </form>
</body>
</html>
