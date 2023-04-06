<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default1.aspx.cs" Inherits="EstudoWebService.Default1" %>

<link href="cssStyle/StyleSheet2.css" type="text/css" rel="stylesheet" />

<div class="card-wrapper">
    <div class="card">
        <h2>Informações de Entrada</h2>
        <table>
            <tr>
                <td>Empresa:</td>
                <td><asp:Label text="Renault" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>Unidade:</td>
                <td><asp:Label text="Creative Lab" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>Tag:</td>
                <td><asp:Label ID="tagLabel" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>Nome:</td>
                <td><asp:Label ID="NomeLabel" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>Data:</td>
                <td><asp:Label ID="DataLabel" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>Temperatura:</td>
                <td><asp:Label ID="temperaturaLabel" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td>Umidade:</td>
                <td><asp:Label ID="umidadeLabel" runat="server"></asp:Label></td>
            </tr>
        </table> 
    </div>
</div>




