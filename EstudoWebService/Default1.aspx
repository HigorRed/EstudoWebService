<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default1.aspx.cs" Inherits="EstudoWebService.Default1" %>

<link href="cssStyle/StyleSheet2.css" type="text/css" rel="stylesheet" />

<div class=" card-wrapper">

    <div class="card">
        <h2>Informações </h2>
        <table>
            <tr>
                <td>Empresa:</td>
                <td>
                    <asp:Label ID="empresaLabel" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Unidade:</td>
                <td>
                    <asp:Label ID="unidadeLabel" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Data:</td>
                <td>
                    <asp:Label ID="dataLabel" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Temperatura:</td>
                <td>
                    <asp:Label ID="temperaturaLabel" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Umidade:</td>
                <td>
                    <asp:Label ID="umidadeLabel" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <td>Presentes na Sala:</td>
        <ul>
            <asp:Repeater ID="presentesList" runat="server">
                <itemtemplate>
                    <li><%# Container.DataItem.ToString() %></li>
                </itemtemplate>
            </asp:Repeater>
        </ul>
    </div>
</div>



