<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="Equipos.aspx.cs" Inherits="Examen2_Progra2.Equipos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="text-center">
   <h1>EQUIPOS</h1> 
</div>
      <br />
    <br />
<asp:GridView runat="server" ID="datagrid" HorizontalAlign="Center"
    CssClass="mydatagrid" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header"
    RowStyle-CssClass="rows" AllowPaging="True" />

<br />
    <br />
    <br />



<div class="container text-center">
    Equipo:
    EquipoID: <asp:TextBox ID="tEID" class="form-control" runat="server"></asp:TextBox>
    Tipo:
    TipoEquipo: <asp:TextBox ID="tTipEquip" class="form-control" runat="server"></asp:TextBox>
    Modelo:
    Modelo: <asp:TextBox ID="tmodelo" class="form-control" runat="server"></asp:TextBox>
</div>
<div class="container text-center">

    <asp:Button ID="Button1" class="btn btn-outline-primary" runat="server" Text="Consultar"  />
    <asp:Button ID="Button2" class="btn btn-outline-secondary" runat="server" Text="Borrar"  />
    <asp:Button ID="Button3" runat="server" class="btn btn-outline-danger" Text="Agregar" />
    <asp:Button ID="Bconsulta" runat="server" class="btn btn-outline-danger" Text="Actualizar"  />
 </div>
</asp:Content>
