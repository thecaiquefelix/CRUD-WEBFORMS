<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Criacao.aspx.cs" Inherits="crud_webforms.Criacao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

			<div>
				<label for="txtNome">Nome</label>
				<asp:TextBox runat="server" ID="txtNome"></asp:TextBox>
			</div>


			<div>
				<label for="txtEmail">Email</label>
				<asp:TextBox runat="server" ID="txtEmail"></asp:TextBox>
			</div>

			<div>
				<label for="txtNascimento">Nascimento</label>
				<asp:TextBox runat="server" ID="txtNascimento"></asp:TextBox>
			</div>


			<div>
				<label for="txtPeso">Peso</label>
				<asp:TextBox runat="server" ID="txtPeso"></asp:TextBox>
			</div>

			<div>
				<label for="txtEndereco">Endereco</label>
				<asp:TextBox runat="server" ID="txtEndereco"></asp:TextBox>
			</div>

			<div>
				<asp:Label runat="server" ID="lblMsg" Text=""></asp:Label>
			</div>

			<asp:Button runat="server" Text="Criar" ID="btnCriar" OnClick="btnCriar_Click" />

			<asp:Button runat="server" Text="Voltar" ID="btnVoltar" OnClick="btnVoltar_Click" />

        </div>
    </form>
</body>
</html>
