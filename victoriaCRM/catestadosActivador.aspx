<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/home.Master" CodeBehind="catestadosActivador.aspx.vb" Inherits="victoriaCRM.catestadosActivador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <section class="content-header">
      <h1>
        Administración de los Estados de Activador
        <small>Catalogo</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Home</a></li>
        <li><a href="#">Catalogos</a></li>
        <li class="active">Administración de Estados</li>
      </ol>
    </section>

    <section class="content">
        <div class="box box-default">
            <div class="box-header with-border">
                <h3 class="box-title">Catalogo de Estados</h3>
                <asp:HiddenField ID="hdestado" runat="server" />
                <asp:HiddenField ID="hdid" runat="server" />
                <div class="box-tools pull-right">
                <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i></button>
                <button type="button" class="btn btn-box-tool" data-widget="remove"><i class="fa fa-remove"></i></button>
            </div>
            <!-- /.box-header -->

        <div class="box-body">

            <div class="row">

                <div class="col-md-3">
                    <label>Descripción:</label>
                </div>

                <div class="col-md-6">
                    <asp:textbox id="txtdescripcion" runat="server" class="form-control"></asp:textbox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtdescripcion" ErrorMessage="Error el campo no puede estar en blanco" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>

                <div class="col-md-3">
                    <asp:Button ID="btnGrabar" runat="server" CssClass="btn btn-block btn-danger" Text="Grabar" />
                </div>

        <hr />

        </div>

            <div class="row">
                <div class="col-lg-12">
                    <asp:Label ID="lblerror" runat="server" Text="" Font-Bold="True" ForeColor="Red"></asp:Label>
                </div>
            </div>

        <div class="row">
            <div class="col-lg-12">
                <asp:GridView ID="grdEstados" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" AutoGenerateColumns="False">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:ButtonField ButtonType="Button" Text="Editar" />
                        <asp:BoundField DataField="idEstado" HeaderText="Codigo" />
                        <asp:BoundField DataField="descripcion" HeaderText="Estado" />
                    </Columns>
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

        </div>
    </section>
</form>
</asp:Content>
