<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edicao.aspx.cs" Inherits="crud_webforms.Edicao" MasterPageFile="~/LayoutMaster.Master" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

	<div class="container">

		<div class="form-group row">
		  <label for="txtNome" class="col-2 col-form-label">Nome</label>
		  <div class="col-10">
			<asp:TextBox runat="server" ID="txtNome" class="form-control"></asp:TextBox>
		  </div>
		</div>

		<div class="form-group row">
		  <label for="txtEmail" class="col-2 col-form-label">Email</label>
		  <div class="col-10">
			  <asp:TextBox runat="server" ID="txtEmail" class="form-control"></asp:TextBox>
		  </div>
		</div>

		<div class="form-group row">
		  <label for="txtNascimento" class="col-2 col-form-label">Nascimento</label>
		  <div class="col-10">
			<asp:TextBox runat="server" ID="txtNascimento" class="form-control"></asp:TextBox>
		  </div>
		</div>

		<div class="form-group row">
		  <label for="txtPeso" class="col-2 col-form-label">Peso</label>
		  <div class="col-10">
			  <asp:TextBox runat="server" ID="txtPeso" class="form-control"></asp:TextBox>
		  </div>
		</div>

		<div class="form-group row">
		  <label for="txtEndereco" class="col-2 col-form-label">Endereço</label>
		  <div class="col-10">
			<asp:TextBox runat="server" ID="txtEndereco" class="form-control"></asp:TextBox>
		  </div>
		</div>

		<div class="form-group row">
			<asp:Button runat="server" Text="Salvar" ID="btnSalvar" OnClick="btnSalvar_Click" class="btn btn-success" />
			<asp:Button runat="server" Text="Voltar" ID="btnVoltar" OnClick="btnVoltar_Click" class="btn btn-secondary" />
		</div>

		<div class="form-group row">
			<asp:Label runat="server" ID="lblMsg" Text=""></asp:Label>
		</div>
		
</div>

</asp:Content>






