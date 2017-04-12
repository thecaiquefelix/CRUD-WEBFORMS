<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listagem.aspx.cs" Inherits="crud_webforms.Listagem" MasterPageFile="~/LayoutMaster.Master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container">

			<div>
				<a href="Criacao.aspx">Cadastrar novo...</a>
			</div>

			<table class="table table-stripe">
					<tr>
						<th>Nome</th>
						<th>E-mail</th>
						<th>Nascimento</th>
						<th>Peso</th>
						<th>Endereço</th>
						<th></th>
						<th></th>
					</tr>
				<tbody>
					<asp:Repeater runat="server" ID="listRepeater">
						<ItemTemplate>
							<tr>
								<td><%#Eval("Nome") %></td>
								<td><%#Eval("Email") %></td>
								<td><%#((DateTime)Eval("Nascimento")).ToString("dd/MM/yyyy") %></td>
								<td><%#((double)Eval("Peso")).ToString("0.00") %></td>
								<td><%#Eval("Endereco") %></td>
								<td><a href="Edicao.aspx?id=<%#Eval("Id") %>">Editar</a></td>
								<td><a href="Exclusao.aspx?id=<%#Eval("Id") %>">Excluir</a></td>
							</tr>
						</ItemTemplate>
					</asp:Repeater>
				</tbody>
			</table>

		</div>

</asp:Content>


    
