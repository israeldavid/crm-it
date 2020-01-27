<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/home.Master" CodeBehind="confwebmail.aspx.vb" Inherits="victoriaCRM.confwebmail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <section class="content-header">
      <h1>
        Configuración de cliente de correo
        <small>Catalogo</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Home</a></li>
        <li><a href="#">Correo</a></li>
        <li class="active">Configuración de cliente de correo</li>
      </ol>
    </section>

    <section class="content">
        <div class="box box-default">
            <div class="box-header with-border">
                <h3 class="box-title">Configuración de cliente de correo</h3>

                <div class="box-tools pull-right">
                <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i></button>
                <button type="button" class="btn btn-box-tool" data-widget="remove"><i class="fa fa-remove"></i></button>
            </div>
            <!-- /.box-header -->

        <div class="box-body">

            <div class="row">
                <div class="col-md-2">
                    <label>Usuario de Email</label>
                </div>

                <div class="col-md-5">
                    <asp:TextBox ID="txtemail" runat="server" Width="100%" TextMode="Email"></asp:TextBox>
                    <asp:Label ID="lblErrorCliente" runat="server" Text=""></asp:Label>
                </div>

                <div class="col-md-2">
                    <label>Clave:</label>
                </div>

                <div class="col-md-3">
                    <asp:textbox id="txtclave" runat="server" Width="100%" TextMode="Password"></asp:textbox>
                </div>
           </div>
            <div class="row">
                <div class="col-md-2">
                    <asp:Label ID="lblPlan" runat="server" Text="Host:" Font-Bold="True"></asp:Label>
                </div>
                <div class="col-md-3">
                    <asp:TextBox ID="txtdominio" runat="server"></asp:TextBox>
                </div>
                <div class="col-md-2">
                    <asp:Label ID="lbldominio" runat="server" Text="Puerto:" Font-Bold="True"></asp:Label>
                </div>
                <div class="col-md-5">
                    <asp:TextBox ID="txtpuerto" runat="server"></asp:TextBox>
                </div>
            </div>
              
        <div class="row">

            <div class="col-md-3">
                
            </div>

           <div class="col-md-6">
                  <asp:Button ID="btnGrabar" runat="server" Text="Grabar" CssClass="btn-danger btn-block" />

              </div>
        </div>
            
        <hr />
        
        <div class="row">
            <div class="col-md-12">
                <asp:Label ID="lblerror" runat="server" Text="" Font-Bold="True" ForeColor="Red"></asp:Label>
            </div>
        </div>

        </div>

        </div>

        </div>
    </section>
</form>
</asp:Content>
