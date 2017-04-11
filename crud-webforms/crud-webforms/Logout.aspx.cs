using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace crud_webforms
{
	public partial class Logout : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			HttpCookie cookie = new HttpCookie("login");
			cookie.Expires = DateTime.Now.AddYears(-1);
			Response.Cookies.Add(cookie);
			Response.Redirect("Default.aspx");
		}
	}
}