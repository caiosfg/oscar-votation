using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace Introducao
{
    public partial class Banco : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CheckMysqlConnection();
            }
        }
        public void CheckMysqlConnection()
        {
            string connectionString = @"Data Source=localhost; Database=cadastro; User ID=root; Password='root'";
            using (MySqlConnection cn = new MySqlConnection(connectionString))
            {
                cn.Open();
                Response.Write("Conexão com sucesso ao Banco de Dados");
            }
        }
    }
}