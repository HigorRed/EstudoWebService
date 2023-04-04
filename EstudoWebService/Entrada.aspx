<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Entrada.aspx.cs" Inherits="EstudoWebService.Entrada" Async="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <p>
                    <asp:Label ID="lblTag"> Tag </asp:Label>
                    <asp:TextBox ID="txtTag" runat="server" />
                </p>
            </div>
            <div>
                <p>
                    <asp:Label ID="lblNome"> Nome </asp:Label>
                    <asp:TextBox ID="txtNome" runat="server" />
                </p>
            </div>
            <div>
                <p>
                    <asp:Label ID="lblTemp"> Temperatura </asp:Label>
                    <asp:TextBox ID="txtTemp" runat="server" />
                </p>
            </div>
            <div>
                <p>
                    <asp:Label ID="lblUmid"> Umidade </asp:Label>
                    <asp:TextBox ID="txtUmid" runat="server" />
                </p>
            </div>
            <asp:Button ID="btnSimularEnvioParamentos" Text="Simular" runat="server" OnClick="SimularEnvioParamentos_Click" />
            <asp:Label ID="lblResultado" Text="" runat="server" />
        </div>
    </form>
</body>
</html>
