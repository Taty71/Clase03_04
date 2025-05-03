<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CRUDCategorias.aspx.cs" Inherits="Clase03_04.CRUDCategorias" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                <h3>Alta</h3>
            <asp:Label ID="Label1" runat="server" Text="Categoría"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Width="179px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar" />
            <br />
            <br />
                <h3>Consulta</h3>
            <br/>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Mostrar" />
            <br />
             <asp:Label runat="server" Text=" " ForeColor="#660066" ID="LabelMostrar"></asp:Label>
            <br />
                <h3>Eliminación</h3>
            <br/>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="nombreCategoria" DataValueField="idCategoria">
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Text="Borrar" OnClick="Button3_Click" />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:cadena %>" SelectCommand="SELECT * FROM [Categorias]"></asp:SqlDataSource>
             <br />
             <br />
                 <h3>Actualización</h3>
                <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="nombreCategoria" DataValueField="idCategoria" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                </asp:DropDownList>
                <br />
                <br />
                <asp:TextBox ID="TextBox2" runat="server" Width="170px"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Actualizar" />
             <br/>

        </div>
    </form>
</body>

</html>
