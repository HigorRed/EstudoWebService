<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Saida.aspx.cs" Inherits="EstudoWebService.Saida" Async="true" %>

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
            <asp:Button ID="btnSimularEnvioSaida" Text="Confirmar" runat="server" OnClick="btnSimularEnvioSaida_Click" />
            <asp:Label ID="lblResultado" Text="" runat="server" />
        </div>
    </form>
</body>
</html>
