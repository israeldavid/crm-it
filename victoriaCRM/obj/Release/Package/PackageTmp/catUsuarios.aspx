﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/home.Master" CodeBehind="catUsuarios.aspx.vb" Inherits="victoriaCRM.catUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Content Header (Page header) -->
    <form id="form1" runat="server">
    <section class="content-header">
      <h1>
        Administración del Inventario de Usuarios
        <small>Catalogo</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Home</a></li>
        <li><a href="#">Catalogos</a></li>
        <li class="active">Administración de Usuarios</li>
      </ol>
    </section>

    <section class="content">
        <div class="box box-default">
            <div class="box-header with-border">
                <h3 class="box-title">Catalogo de Usuarios</h3>

                <div class="box-tools pull-right">
                <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i></button>
                <button type="button" class="btn btn-box-tool" data-widget="remove"><i class="fa fa-remove"></i></button>
            </div>
            <!-- /.box-header -->

        <div class="box-body">

            <div class="row">
                <div class="col-md-3">
                    <label>Nick:</label>
                </div>

                <div class="col-md-9">
                    <asp:TextBox ID="txtNick" runat="server"></asp:TextBox>
                    <asp:Button ID="btnbuscar" runat="server" CssClass="btn-success" Text="!" CausesValidation="False" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNick" ErrorMessage="Error el campo no puede estar en blanco" ForeColor="Red"></asp:RequiredFieldValidator>                    
                </div>
           </div>
            <hr />

           <div class="row">
                <div class="col-md-3">
                    <label>Nombres Completos</label>
                </div>

                <div class="col-md-9">
                    <asp:textbox id="txtnombres" runat="server" CssClass="btn-block"></asp:textbox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtnombres" ErrorMessage="Error el campo no puede estar en blanco" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
                <hr />
           </div>

           <div class="row">
               <div class="col-md-3">
                   <label>Tipo de Usuario</label>
               </div>

               <div class="col-md-6">
                   <asp:DropDownList ID="ddlTipoUsuario" runat="server">
                   </asp:DropDownList>
               </div>

               <div class="col-md-3">
                    
                </div>
           </div>

           <div class="row">
               <div class="col-md-3">
                   <asp:Label ID="lblClave" runat="server" Text="Clave" Font-Bold="True"></asp:Label>
               </div>

               <div class="col-md-6">
                   <asp:TextBox ID="txtclave" runat="server" MaxLength="10" TextMode="Password"></asp:TextBox>
               </div>

               <div class="col-md-3">
                   
               </div>

           </div>

            <div class="row">
                <div class="col-md-3">
                    <asp:Label ID="lblemail" runat="server" Text="email" Font-Bold="True"></asp:Label>
               </div>

                <div class="col-md-6">
                    <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Correo Inválido" ControlToValidate="txtemail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
               </div>

                <div class="col-md-3">
                    <asp:Button ID="btnActualizar" runat="server" CssClass="btn btn-block btn-success" Text="Actualizar" Enabled="false" />
                    <asp:Button ID="btnGrabar" runat="server" CssClass="btn btn-block btn-danger" Text="Grabar" />
                    <asp:Button ID="btnBorrar" runat="server" CssClass="btn btn-block btn-warning" Text="Eliminar" />
               </div>
            </div>

            <div class="row">
                <div class="col-lg-12">
                    <asp:Label ID="lblerror" runat="server" Text="" Font-Bold="True" ForeColor="Red"></asp:Label>
                </div>
            </div>

            <hr />

        <div class="row">
            <div class="col-lg-12">
                <asp:GridView ID="grdUsuarios" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%">
                    <AlternatingRowStyle BackColor="White" />
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
            </div>
        </div>
        </div>

        </div>
    </section>
</form>
</asp:Content>
