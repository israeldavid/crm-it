<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/home.Master" CodeBehind="cargaEquipos.aspx.vb" Inherits="victoriaCRM.cargaEquipos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
                        <th scope="col">Descripcion</th>
                        <th scope="col">IdMarca</th>
                        <th scope="col">IMEI</th>
                        <th scope="col">Estado</th>
                        <th scope="col">Fecha</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <th scope="row">Samsung S7 Edge</th>
                        <td>*1</td>
                        <td>83400000</td>
                        <td>8555555</td>
                        <td>A</td>
                        <td>2019/09/29</td>
                    </tr>
                </tbody>
            </table>
            <form id="Form1" method="post" enctype="multipart/form-data" runat="server">
                <div class="container">
                    <div class="row">
                        <div class="col-md-1 col-lg-3">
                            <asp:Label ID="lblSubir" runat="server" CssClass="text-bold" Text="Subir el archivo:"></asp:Label>
                        </div>
                        <div class="col-md-4 col-lg-6">
                            <asp:FileUpload ID="fileSubir" runat="server" />
                        </div>
                        <div class="col-md-2 col-lg-3">
                            <asp:Button ID="btnSubir" runat="server" Text="Subir" CssClass="btn-success" />
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
          * El Id de la marca lo puedes sacar del catalogo de marcas, y en excel usar la formula buscarv. Descarga la plantilla desde <a href="plantilla.xlsx">aquí</a>
        </div>
        <!-- /.box-footer-->
      </div>
      <!-- /.box -->

    </section>
</asp:Content>
