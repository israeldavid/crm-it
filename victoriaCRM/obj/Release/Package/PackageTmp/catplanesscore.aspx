<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/home.Master" CodeBehind="catplanesscore.aspx.vb" Inherits="victoriaCRM.catplanesscore" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <section class="content-header">
      <h1>
        Políticas de Score vs Planes
        <small>Catalogo</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Home</a></li>
        <li><a href="#">Catalogos</a></li>
        <li class="active">Políticas de Score vs Planes</li>
      </ol>
    </section>

    <section class="content">
        <div class="box box-default">
            <div class="box-header with-border">
                <h3 class="box-title">Políticas de Score vs Planes</h3>

                <div class="box-tools pull-right">
                <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i></button>
                <button type="button" class="btn btn-box-tool" data-widget="remove"><i class="fa fa-remove"></i></button>
            </div>
            <!-- /.box-header -->

        <div class="box-body">

            <div class="row">
                <div class="col-md-2">
                    <label>Plan:</label>
                </div>

                <div class="col-md-4">
                    <asp:dropdownlist runat="server" ID="ddlplan"></asp:dropdownlist>
                </div>

                <div class="col-md-2">
                    
                </div>

                <div class="col-md-4">
                    
                </div>
           </div>
          
           <hr />

        <div class="row">
            <div class="col-12">
                <div class="box-header with-border">
                    Rubros
                </div>          
            </div>
        </div>
              
        <div class="row">

            <div class="col-md-3">
                <%For i = 1 To rubros%> 
                   <% response.Write(i) %> 
                <%Next %>
                <%For each fila As DataRow In tbScore.Rows %>

                <%Next %>
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
