<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/home.Master" CodeBehind="cambiarclave.aspx.vb" Inherits="victoriaCRM.cambiarclave" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <section class="content-header">
      <h1>
        Perfil de Usuarios
        <small>Cambiar clave</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Home</a></li>
        <li><a href="#">Perfil</a></li>
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
                    <label>Contraseña Actual</label>
                </div>

                <div class="col-md-9">
                    <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtpassword" ErrorMessage="Error el campo no puede estar en blanco" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
           </div>
            <hr />

           <div class="row">
                <div class="col-md-3">
                    <label>Usuario</label>
                </div>

                <div class="col-md-9">
                    <input type="text" name="txtusuario" value=" <%= Session("nick")%>" readonly >
                    
                </div>
                <hr />
           </div>

           <div class="row">
               <div class="col-md-3">
                   <label>Nueva clave</label>
               </div>

               <div class="col-md-6">
                   <asp:textbox id="txtnuevaclave" runat="server"></asp:textbox>
               </div>

               <div class="col-md-3">
                    
                </div>
           </div>

           <div class="row">
               <div class="col-md-3">
                   <asp:Label ID="lblClave" runat="server" Text="Repita la Clave" maxlength="10" Font-Bold="True"></asp:Label>
               </div>

               <div class="col-md-6">
                   <asp:TextBox ID="txtclave" runat="server" MaxLength="10"></asp:TextBox>
               </div>

               <div class="col-md-3">
                   
               </div>

           </div>

            <div class="row">
                <div class="col-md-3">
                   
               </div>

                <div class="col-md-6">
                   <asp:Button ID="btnGrabar" runat="server" CssClass="btn btn-block btn-danger" Text="Grabar" />
               </div>

                <div class="col-md-3">
                   
               </div>
            </div>

            <div class="row">
                <div class="col-lg-12">
                    <asp:Label ID="lblerror" runat="server" Text="" Font-Bold="True" ForeColor="Red"></asp:Label>
                </div>
            </div>

            <hr />

        </div>

        </div>
    </section>
</form>
</asp:Content>
