using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Clase03_04
{
    public partial class CRUDCategoriasDataSource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int resultado = SqlDataSource1.Insert();
            if (resultado > 0)
            {
                LabelMensaje.Text = "Insertado correctamente";
            }
            else
            {
                LabelMensaje.Text = "Error al insertar";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            LabelMensaje.Text = "";
            // Limpiar el contenido del Label antes de mostrar los nuevos datos
            LabelMostrar.Text = string.Empty;

            DataView dv = (DataView) SqlDataSource1.Select(DataSourceSelectArguments.Empty);//no paso argumentos
            foreach (DataRowView row in dv)
            {
                LabelMostrar.Text += row["nombreCategoria"].ToString() + " - ";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int resultado = SqlDataSource1.Delete();
            if (resultado > 0)
            {
                LabelMensaje.Text = "Se borró correctamente";
            }
            else
            {
                LabelMensaje.Text = "Error al borrar";
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int resultado = SqlDataSource1.Update();
            if (resultado > 0)
            {
                LabelMensaje.Text = "Se actualizó correctamente";
            }
            else
            {
                LabelMensaje.Text = "Error al actualizar";
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox2.Text = DropDownList2.SelectedItem.Text;
        }
    }
}