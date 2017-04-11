using crud_webforms.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace crud_webforms
{
	public partial class Exclusao : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (IsPostBack == false)
			{
				int id;
				if (int.TryParse(Request.QueryString["id"], out id) == false)
				{
					lblMsg.Text = "Id inválido!";
					btnSim.Visible = false;
					btnNao.Text = "Voltar";
					return;
				}

				// Cria e abre a conexão com o banco de dados
				using (SqlConnection conn = Sql.OpenConnection())
				{

					// Cria um comando para selecionar registros da tabela
					using (SqlCommand cmd = new SqlCommand("SELECT Nome FROM tbPessoa WHERE Id = @id", conn))
					{
						cmd.Parameters.AddWithValue("@id", id);

						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							// Tenta obter o registro
							if (reader.Read() == true)
							{
								lblMsg.Text = "Deseja mesmo excluir " + reader.GetString(0) + "?";
							}
							else
							{
								lblMsg.Text = "Id não encontrado!";
								btnSim.Visible = false;
								btnNao.Text = "Voltar";
							}
						}
					}
				}
			}
		}

		protected void btnSim_Click(object sender, EventArgs e)
		{
			int id;
			if (int.TryParse(Request.QueryString["id"], out id) == false)
			{
				lblMsg.Text = "Id inválido!";
				btnSim.Visible = false;
				btnNao.Text = "Voltar";
				return;
			}

			// Cria e abre a conexão com o banco de dados
			using (SqlConnection conn = Sql.OpenConnection())
			{

				// Cria um comando para excluir o registro
				using (SqlCommand cmd = new SqlCommand("DELETE FROM tbPessoa WHERE Id = @id", conn))
				{
					cmd.Parameters.AddWithValue("@id", id);

					cmd.ExecuteNonQuery();
				}
			}

			lblMsg.Text = "Pessoa excluída com sucesso!";
			btnSim.Visible = false;
			btnNao.Text = "Voltar";
		}

		protected void btnNao_Click(object sender, EventArgs e)
		{
			Response.Redirect("Listagem.aspx");
		}
	}
}