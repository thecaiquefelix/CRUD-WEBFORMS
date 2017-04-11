<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listagem.aspx.cs" Inherits="crud_webforms.Listagem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
		<div>
			<a href="Logout.aspx">Logout</a>
		</div>
		<div>
			<a href="Criacao.aspx">Cadastrar novo...</a>
		</div>
		<table>
			<thead>
				<tr>
					<th>Nome</th>
					<th>E-mail</th>
					<th>Nascimento</th>
					<th>Peso</th>
					<th>Endereço</th>
					<th></th>
					<th></th>
				</tr>
			</thead>
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
    </form>
</body>
</html>
