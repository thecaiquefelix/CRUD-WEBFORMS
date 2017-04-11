<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="crud_webforms.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

			<div>
				<label for="txtUsuario">Usuario</label>
				<asp:TextBox runat="server" ID="txtUsuario"></asp:TextBox>
			</div>

			<div>
				<label for="txtSenha">Senha</label>
				<asp:TextBox runat="server" ID="txtSenha" TextMode="Password"></asp:TextBox>
			</div>

			<div>
				<asp:Label Text="" runat="server" ID="lblMsg"></asp:Label>
			</div>


			<asp:Button runat="server" Text="Entrar" ID="btnLogin"  OnClick="btnLogin_Click"/>

        </div>
    </form>
</body>
</html>
