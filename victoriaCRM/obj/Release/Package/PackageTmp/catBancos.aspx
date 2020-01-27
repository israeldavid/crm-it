<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/home.Master" CodeBehind="catBancos.aspx.vb" Inherits="victoriaCRM.catBancos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <section class="content-header">
      <h1>
        Administración de Entidades Financieras
        <small>Catalogo</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Home</a></li>
        <li><a href="#">Catalogos</a></li>
        <li class="active">Administración de Entidades Financieras</li>
      </ol>
    </section>

    <section class="content">
        <div class="box box-default">
            <div class="box-header with-border">
                <h3 class="box-title">Catalogo de Entidades Financieras</h3>

                <div class="box-tools pull-right">
                <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i></button>
                <button type="button" class="btn btn-box-tool" data-widget="remove"><i class="fa fa-remove"></i></button>
            </div>
            <!-- /.box-header -->

        <div class="box-body">

            <div class="row">

                <div class="col-md-3">
                    <label>Entidad Financiera</label>
                </div>

                <div class="col-md-9">
                    <asp:textbox id="txtentidad" runat="server" CssClass="btn-block"></asp:textbox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtentidad" ErrorMessage="Error el campo no puede estar en blanco" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
                <hr />
           </div>

           <div class="row">
               <div class="col-md-3">
                    &nbsp;</div>
               <div class="col-md-9">
               </div>
           </div>

            <div class="row">
               <div class="col-md-3">
                   
               </div>
               <div class="col-md-9">

               </div>
           </div>

            <div class="row">
               <div class="col-md-3">
                     <label>Estado</label>
               </div>
               <div class="col-md-9">
                    <asp:dropdownlist id="ddlestado" runat="server">
                        <asp:ListItem>Activo</asp:ListItem>
                        <asp:ListItem>Inactivo</asp:ListItem>
                    </asp:dropdownlist>
                </div>
           </div>

            <div class="row">
               <div class="col-md-6">
                    <asp:Button ID="btnconsbanco" runat="server" CssClass="btn btn-block btn-warning" Text="Consultar Entidad Financiera" CausesValidation="False" />
                </div>
               <div class="col-md-6">
                    <asp:Button ID="btnconstc" runat="server" CssClass="btn btn-block btn-primary" Text="Consultar Tarjeta Credito" CausesValidation="False" />
                </div>
           </div>

           <div class="row">
               <div class="col-md-6">
                    <asp:Button ID="btnGrabar" runat="server" CssClass="btn btn-block btn-danger" Text="Grabar Entidad Financiera" />
                </div>
               <div class="col-md-6">
                    <asp:Button ID="btnTarjeta" runat="server" CssClass="btn btn-block btn-success" Text="Grabar Tarjeta Credito" />
                </div>
           </div>

            <div class="row">
                <div class="col-lg-12">
                    <asp:Label ID="lblerror" runat="server" Text="" Font-Bold="True" ForeColor="Red"></asp:Label>
                </div>
            </div>

        <div class="row">
            <div class="col-lg-12">
                <asp:GridView ID="grdEquipos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" AutoGenerateColumns="False">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="idbanco" HeaderText="IdBanco" />
                        <asp:BoundField DataField="descripcion" HeaderText="Nombre" />
                        <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
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
