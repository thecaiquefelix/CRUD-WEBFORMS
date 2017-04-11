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
	public partial class Edicao : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (IsPostBack == false)
			{
				int id;

				if (int.TryParse(Request.QueryString["id"], out id) == false)
				{
					lblMsg.Text = "Id inválido!";
					return;
				}

				// Cria e abre a conexão com o banco de dados
				using (SqlConnection conn = Sql.OpenConnection())
				{

					// Cria um comando para selecionar registros da tabela
					using (SqlCommand cmd = new SqlCommand("SELECT Nome, Email, Nascimento, Peso, Endereco FROM tbPessoa WHERE Id = @id", conn))
					{
						cmd.Parameters.AddWithValue("@id", id);

						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							// Tenta obter o registro
							if (reader.Read() == true)
							{
								txtNome.Text = reader.GetString(0);
								txtEmail.Text = reader.GetString(1);
								txtNascimento.Text = reader.GetDateTime(2).ToString("dd/MM/yyyy");
								txtPeso.Text = reader.GetDouble(3).ToString("0.00");
								txtEndereco.Text = reader.GetString(4);
							}
							else
							{
								lblMsg.Text = "Id não encontrado!";
							}
						}
					}
				}
			}
		}

		protected void btnSalvar_Click(object sender, EventArgs e)
		{

			string nome = txtNome.Text.Trim();
			if (nome.Length == 0)
			{
				lblMsg.Text = "Nome inválido!";
				return;
			}

			
			string email = txtEmail.Text.Trim();
			int arroba, arroba2, ponto;

			arroba = email.IndexOf('@');
			arroba2 = email.LastIndexOf('@');
			ponto = email.LastIndexOf('.');

			if (arroba <= 0 || ponto <= (arroba + 1) || ponto == (email.Length - 1) || arroba2 != arroba)
			{
				lblMsg.Text = "E-mail inválido!";
				return;
			}

			//Vamos forçar o uso das regras de data utilizadas no Brasil
			DateTime nascimento;
			if (DateTime.TryParse(txtNascimento.Text, System.Globalization.CultureInfo.GetCultureInfo("pt-br"), System.Globalization.DateTimeStyles.None, out nascimento) == false)
			{
				lblMsg.Text = "Nascimento inválido!";
				return;
			}

			double peso;
			if (double.TryParse(txtPeso.Text, out peso) == false)
			{
				lblMsg.Text = "Peso inválido!";
				return;
			}

			string endereco = txtEndereco.Text.Trim();
			if (endereco.Length == 0)
			{
				lblMsg.Text = "Endereço inválido!";
				return;
			}

			// Cria e abre a conexão com o banco de dados
			using (SqlConnection conn = Sql.OpenConnection())
			{

				// Cria um comando para atualizar um registro da tabela
				using (SqlCommand cmd = new SqlCommand("UPDATE tbPessoa SET Nome = @nome, Email = @email, Nascimento = @nascimento, Peso = @peso, Endereco = @endereco WHERE Id = @id", conn))
				{
					cmd.Parameters.AddWithValue("@nome", nome);
					cmd.Parameters.AddWithValue("@email", email);
					cmd.Parameters.AddWithValue("@nascimento", nascimento);
					cmd.Parameters.AddWithValue("@peso", peso);
					cmd.Parameters.AddWithValue("@endereco", endereco);

					cmd.ExecuteNonQuery();
				}
			}

			lblMsg.Text = "Alterado com sucesso!";

		}

		protected void btnVoltar_Click(object sender, EventArgs e)
		{
			Response.Redirect("Listagem.aspx");
		}
	}
}