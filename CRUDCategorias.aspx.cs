using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clase03_04
{
    public partial class CRUDCategorias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(cadenaConexion); // Fixed variable name typo
            sqlConnection.Open(); // Corrected variable name
            string addCategoria = $"INSERT INTO Categorias (nombreCategoria) VALUES ('{TextBox1.Text}')";
            SqlCommand comando = new SqlCommand(addCategoria, sqlConnection);
            comando.ExecuteNonQuery();

            sqlConnection.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(cadenaConexion); // Fixed variable name typo
            sqlConnection.Open(); // Corrected variable name
            LabelMostrar.Text = ""; // Clear the label before displaying new data
            LabelMostrar.Text = string.Empty;
            string readCategoria = $"SELECT nombreCategoria FROM Categorias";
            SqlCommand comando = new SqlCommand(readCategoria, sqlConnection);
            SqlDataReader registros = comando.ExecuteReader();
            while (registros.Read())
            {
                LabelMostrar.Text += registros["nombreCategoria"].ToString() + " - " ; // Displaying the category names in a label
                //ListBox1.Items.Add(registros["nombreCategoria"].ToString());
            }   

            sqlConnection.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(cadenaConexion); // Fixed variable name typo
            sqlConnection.Open(); // Corrected variable name
            string delCategoria = $"DELETE FROM Categorias WHERE idCategoria = {DropDownList1.SelectedValue.ToString()}";
            SqlCommand comando = new SqlCommand(delCategoria, sqlConnection);
            comando.ExecuteNonQuery();
            sqlConnection.Close();
            //DropDownList1.Items.Clear();borra la lista
            DropDownList1.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(cadenaConexion); // Fixed variable name typo
            sqlConnection.Open(); // Corrected variable name
            string upCategoria = $"UPDATE Categorias SET nombreCategoria = '{TextBox2.Text}' WHERE idCategoria = {DropDownList2.SelectedValue}";
            SqlCommand comando = new SqlCommand(upCategoria, sqlConnection);
            comando.ExecuteNonQuery();
            sqlConnection.Close();
            DropDownList2.DataBind();

        }

        
        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(cadenaConexion); // Fixed variable name typo
            sqlConnection.Open(); // Corrected variable name
            string readCategoria = $"SELECT idCategoria, nombreCategoria FROM Categorias WHERE idCategoria = {DropDownList2.SelectedValue}";
            SqlCommand comando = new SqlCommand(readCategoria, sqlConnection);
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                TextBox2.Text = registro["nombreCategoria"].ToString();
                //ListBox1.Items.Add(registros["nombreCategoria"].ToString());
            }


            sqlConnection.Close();
            
        }
    }
}