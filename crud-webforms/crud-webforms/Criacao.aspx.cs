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
	public partial class Criacao : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			HttpCookie cookie = Request.Cookies["login"];
			if (cookie == null || cookie.Value != "ok")
			{
				Response.Redirect("Default.aspx");
				return;
			}
		}

		protected void btnCriar_Click(object sender, EventArgs e)
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


			//Criando e abrindo a conexao com o banco de dados
			using (SqlConnection conn = Sql.OpenConnection())
			{

				//Criando o comando para inserir um novo registro 
				using (SqlCommand cmd = new SqlCommand("INSERT INTO tbPessoa (Nome, Email, Nascimento, Peso, Endereco) VALUES (@nome, @email, @nascimento, @peso, @endereco)", conn))
				{
					cmd.Parameters.AddWithValue("@nome", nome);
					cmd.Parameters.AddWithValue("@email", email);
					cmd.Parameters.AddWithValue("@nascimento", nascimento);
					cmd.Parameters.AddWithValue("@peso", peso);
					cmd.Parameters.AddWithValue("@endereco", endereco);

					cmd.ExecuteNonQuery();
				}
			}

			//Limpa todos os campos ao final
			txtNome.Text = "";
			txtEmail.Text = "";
			txtNascimento.Text = "";
			txtPeso.Text = "";
			txtEndereco.Text = "";

			lblMsg.Text = "Criado com sucesso!";
		}

		protected void btnVoltar_Click(object sender, EventArgs e)
		{
			Response.Redirect("Listagem.aspx");
		}
	}
}