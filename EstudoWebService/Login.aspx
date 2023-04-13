<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EstudoWebService.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="cssStyle/styleLogin.css" type="text/css" rel="stylesheet" />
</head>
<body>
    <div class="login-bg">
        <div>
            <form id="formLogin" runat="server">
                <div>
                    <label for="txtUsuario">Usuário: </label>
                    <input type="text" id="txtUsuario" name="txtUsuario" runat="server" />
                </div>
                <div>
                    <label for="txtSenha">Senha:</label>
                    <input type="password" id="txtSenha" name="txtSenha" runat="server" />
                </div>
                <div>
                    <button type="submit" id="btnEntrar" onserverclick="btnEntrar_ServerClick" runat="server">Entrar</button>
                </div>
            </form>
        </div>
    </div>
</body>
</html>
