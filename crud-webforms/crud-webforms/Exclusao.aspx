<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exclusao.aspx.cs" Inherits="crud_webforms.Exclusao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
		<div>
			<asp:Label Text="" runat="server" ID="lblMsg" />
		</div>
		<div>
			<asp:Button Text="Sim" runat="server" ID="btnSim" OnClick="btnSim_Click" />
			<asp:Button Text="Não" runat="server" ID="btnNao" OnClick="btnNao_Click" />
		</div>
	</div>
    </form>
</body>
</html>
