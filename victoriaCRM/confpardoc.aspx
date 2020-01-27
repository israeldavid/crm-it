<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/home.Master" CodeBehind="confpardoc.aspx.vb" Inherits="victoriaCRM.confpardoc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <section class="content-header">
      <h1>
        Administración de Parámetros
        <small>Catalogo</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Home</a></li>
        <li><a href="#">Catalogos</a></li>
        <li class="active">Administración de Parámetros</li>
      </ol>
    </section>

    <section class="content">
        <div class="box box-default">
            <div class="box-header with-border">
                <h3 class="box-title">Catalogo de Parámetros de Configuración</h3>

                <div class="box-tools pull-right">
                <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i></button>
                <button type="button" class="btn btn-box-tool" data-widget="remove"><i class="fa fa-remove"></i></button>
            </div>
            <!-- /.box-header -->

        <div class="box-body">

            <div class="row">

                <div class="col-md-3">
                    <label>Tipo:</label>
                </div>

                <div class="col-md-3">
                    <asp:DropDownList ID="ddlTitulos" runat="server"></asp:DropDownList>
                </div>

                <div class="col-md-3">
                </div>

                <div class="col-md-3">
                    
                </div>
          </div>
 
          <hr />

            <div class="row">
                <div class="col-md-3">
                    <label>Documentos:</label>
                </div>

                <div class="col-md-3">
                    <asp:TextBox ID="txtitems" runat="server"></asp:TextBox>
                </div>

                <div class="col-md-3">
                    <asp:Button ID="cmdgrabar" runat="server" CssClass="btn-danger" Text="Grabar" />
                </div>

                <div class="col-md-3">
                    <asp:Button ID="cmdEditar" runat="server" CssClass="btn-success" Text="Editar" />
                </div>
          </div>

        
        <div class="row">
            <div class="col-md-12">
                <asp:Label ID="lblerror" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
            </div>
        </div>

        </div>

        </div>

        <div class="row">
            <div class="col-lg-12">
                <asp:GridView ID="grdDatos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
            </div>
        </div>

        </div>
    </section>
</form>
</asp:Content>
