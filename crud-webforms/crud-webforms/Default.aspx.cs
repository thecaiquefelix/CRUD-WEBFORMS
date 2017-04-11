using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace crud_webforms
{
	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			HttpCookie cookie = Request.Cookies["login"];
			if (cookie != null && cookie.Value == "ok")
			{
				Response.Redirect("Listagem.aspx");
			}
		}

		protected void btnLogin_Click(object sender, EventArgs e)
		{
			if (txtUsuario.Text == "admin" && txtSenha.Text == "admin")
			{
				HttpCookie cookie = new HttpCookie("login", "ok");
				cookie.Expires = DateTime.Now.AddYears(1);
				Response.Cookies.Add(cookie);
				Response.Redirect("Listagem.aspx");
			}
			else
			{
				lblMsg.Text = "Usuario ou senha inválida!";
			}

		}
	}
}