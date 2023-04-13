<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default1.aspx.cs" Inherits="EstudoWebService.Default1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="cssStyle/StyleBase.css" type="text/css" rel="stylesheet" />
</head>
<body>
    <div class="card-wrapper">
        <div class="card">
            <h2>Informações de Entrada</h2>
            <table>
                <tr>
                    <td>Empresa:</td>
                    <td>
                        <asp:Label Text="Renault" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Unidade:</td>
                    <td>
                        <asp:Label Text="Creative Lab" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Tag:</td>
                    <td>
                        <asp:Label ID="tagLabel" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Nome:</td>
                    <td>
                        <asp:Label ID="NomeLabel" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Data:</td>
                    <td>
                        <asp:Label ID="DataLabel" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Temperatura:</td>
                    <td>
                        <asp:Label ID="temperaturaLabel" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>Umidade:</td>
                    <td>
                        <asp:Label ID="umidadeLabel" runat="server"></asp:Label></td>
                </tr>
            </table>
            <button class="btn-report" onclick="window.location.href='RelatorioSaida.aspx';" id="btnRelatorio">Relatório de Saída</button>
        </div>
    </div>
</body>
</html>




