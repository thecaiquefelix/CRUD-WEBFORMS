<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="crud_webforms.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">
	<link href="Style/css/login.css" rel="stylesheet" />
</head>
<body>

<form id="form1" runat="server">
	<div class="container">
		<div class="row caique">
			<div class="col-sm-6 col-md-4 col-md-offset-4">
				<h1 class="text-center login-title">Efetue o Login</h1>
				<img class="profile-img" src="https://lh5.googleusercontent.com/-b0-k99FZlyE/AAAAAAAAAAI/AAAAAAAAAAA/eu7opA4byxI/photo.jpg?sz=120" alt="">
				<div class="account-wall">                
					<div class="form-signin">
						<asp:TextBox runat="server" ID="txtUsuario" class="form-control" placeholder="Usuario"></asp:TextBox>
						<asp:TextBox runat="server" ID="txtSenha" TextMode="Password" class="form-control" placeholder="Senha"></asp:TextBox>
						<asp:Button runat="server" Text="Entrar" ID="btnLogin"  class="btn btn-lg btn-primary btn-block"  OnClick="btnLogin_Click"/>						
					</div>
					<asp:Label runat="server" ID="lblMsg" Text="" class="text-center login-title"></asp:Label>
					<br />
				</div>
			</div>
		</div>
	</div>
</form>

</body>
</html>
