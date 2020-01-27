<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/home.Master" CodeBehind="recargas.aspx.vb" Inherits="victoriaCRM.recargas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Main content -->
    <section class="content">

      <!-- Default box -->
      <div class="box">
        <div class="box-header with-border">
          <h3 class="box-title">Carga del archivo</h3>

          <div class="box-tools pull-right">
            <button type="button" class="btn btn-box-tool" data-widget="collapse" data-toggle="tooltip"
                    title="Collapse">
              <i class="fa fa-minus"></i></button>
            <button type="button" class="btn btn-box-tool" data-widget="remove" data-toggle="tooltip" title="Remove">
              <i class="fa fa-times"></i></button>
          </div>
        </div>
        <div class="box-body">
            Por favor cargar el archivo de Excel con la siguiente estructura.
            <table class="table">
                <thead class="thead-dark">
                    <tr>
                        <th scope="col">Cod Producto</th>
                        <th scope="col">PCs</th>
                        <th scope="col">Cod Distribuidor</th>
                        <th scope="col">DAS</th>
                        <th scope="col">Valor Cargado</th>
                        <th scope="col">Año</th>
                        <th scope="col">Mes</th>
                        <th scope="col">Fecha Activación</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <th scope="row">66666666</th>
                        <td>999999</td>
                        <td>8340</td>
                        <td>Comercial</td>
                        <td>3</td>
                        <td>2019</td>
                        <td>04</td>
                        <td>Fecha Acti</td>
                    </tr>
                </tbody>
            </table>
            <form id="Form1" method="post" enctype="multipart/form-data" runat="server">
                <div class="container">
                    <div class="row">
                        <div class="col-lg-3">
                            <asp:Label ID="lblSubir" runat="server" CssClass="text-bold" Text="Subir el archivo:"></asp:Label>
                        </div>
                        <div class="col-lg-6">
                            <asp:FileUpload ID="fileSubir" runat="server" />
                        </div>
                        <div class="col-lg-3">
                            <asp:Button ID="btnSubir" runat="server" Text="Subir" CssClass="btn-danger" />
                        </div>
                    </div>
                    <div class="row">
                        <asp:Label ID="lblmensaje" CssClass="text-danger" runat="server" Text=""></asp:Label>
                    </div>
                </div>
            <hr />
            <div>
                <asp:GridView ID="grdDatosaCargar" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
                <hr />
                <div class="container">
                    <div class="row">
                        <div class="col-lg-1">
                            <asp:Button ID="btnCargar" runat="server" Text="Cargar" CssClass="btn-block btn-danger" Visible="False" />
                        </div>
                    </div>
                </div>
            </form>
        </div>
        <!-- /.box-body -->
        <div class="box-footer">
          Datos para cargar en la base
        </div>
        <!-- /.box-footer-->
      </div>
      <!-- /.box -->

    </section>
</asp:Content>
