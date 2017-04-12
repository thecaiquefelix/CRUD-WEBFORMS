<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exclusao.aspx.cs" Inherits="crud_webforms.Exclusao" MasterPageFile="~/LayoutMaster.Master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

	<div class="container">
		<div class="form-group row">
			<asp:Label Text="" runat="server" ID="lblMsg" />
		</div>
		<div class="form-group row">
			<asp:Button Text="Sim" runat="server" ID="btnSim" OnClick="btnSim_Click" class="btn btn-success"/>
			<asp:Button Text="Não" runat="server" ID="btnNao" OnClick="btnNao_Click" class="btn btn-danger"/>		
		</div>
	</div>

</asp:Content>

