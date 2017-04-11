using crud_webforms.Models;
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
	public partial class Listagem : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			// Carrega os dados da tabela apenas da primeira vez que a página abrir
			// (ao recarregar a página por causa de cliques em botões, ou outros
			// eventos, os dados não serão recarregados, e serão utilizados os dados
			// anteriormente carregados)
			if (IsPostBack == false)
			{
				List<Pessoa> pessoas = new List<Pessoa>();

				// Cria e abre a conexão com o banco de dados
				using (SqlConnection conn = Sql.OpenConnection())
				{

					// Cria um comando para selecionar registros da tabela
					using (SqlCommand cmd = new SqlCommand("SELECT Id, Nome, Email, Nascimento, Peso, Endereco FROM tbPessoa ORDER BY Nome ASC", conn))
					{

						using (SqlDataReader reader = cmd.ExecuteReader())
						{
							// Obtém os registros, um por vez
							while (reader.Read() == true)
							{
								Pessoa p = new Pessoa();
								p.Id = reader.GetInt32(0);
								p.Nome = reader.GetString(1);
								p.Email = reader.GetString(2);
								p.Nascimento = reader.GetDateTime(3);
								p.Peso = reader.GetDouble(4);
								p.Endereco = reader.GetString(5);

								pessoas.Add(p);
							}
						}
					}
				}

				listRepeater.DataSource = pessoas;
				listRepeater.DataBind();
			}
		}
	}
}