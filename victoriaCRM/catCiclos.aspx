<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/home.Master" CodeBehind="catCiclos.aspx.vb" Inherits="victoriaCRM.catCiclos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Content Header (Page header) -->
    <form id="form1" runat="server">
    <section class="content-header">
      <h1>
        Administración de Tipos de Ciclos
        <small>Catalogo</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Home</a></li>
        <li><a href="#">Catalogos</a></li>
        <li class="active">Administración de tipos de Ciclos</li>
      </ol>
    </section>

    <section class="content">
        <div class="box box-default">
            <div class="box-header with-border">
                <h3 class="box-title">Inventario de Ciclos</h3>

                <div class="box-tools pull-right">
                <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i></button>
                <button type="button" class="btn btn-box-tool" data-widget="remove"><i class="fa fa-remove"></i></button>
            </div>
            <!-- /.box-header -->

        <div class="box-body">

            <div class="row">
                <div class="col-md-2">
                    <label>Nombre del Ciclo</label>
                </div>

                <div class="col-md-4">
                    <asp:TextBox ID="txtnombreCiclo" runat="server" Width="100%"></asp:TextBox>
                </div>

                <div class="col-md-3">
                    
                </div>

                <div class="col-md-3">
                    
                </div>
           </div>

        <hr />

          <div class="row">
            <div class="col-md-2">
                 <label>Fecha de Debito</label>
            </div>
            <div class="col-md-4">
                <asp:TextBox ID="txtfechaDebito" runat="server" TextMode="Date" Width="100%"></asp:TextBox>
            </div>
            <div class="col-md-3">
                
            </div>
            <div class="col-md-3">
                
            </div>
          </div>
          
        <hr />

       <div class="row">
           <div class="col-md-3">
               <label>Fecha de Acreditación</label>
           </div>

           <div class="col-md-3">
               <asp:textbox id="txtfechaAcreditacion"  runat="server" TextMode="Date"></asp:textbox>
           </div>
       </div>

            <hr />

       <div class="row">
           <div class="col-md-3">
                <label>Fecha Máximo de pago</label>
                
           </div>
           <div class="col-md-9">
               <asp:TextBox ID="txtfechaMaxPago" TextMode="Date" runat="server"></asp:TextBox>
           </div>
       </div>

            <hr />

       <div class="row">
           <div class="col-md-12">
               <asp:button runat="server" text="Grabar" class="btn btn-danger btn-block" ID="btnGrabar" />
           </div>
       </div>
<hr />
        <div class="row">
            <div class="col-md-12">
                <asp:Label ID="lblerror" runat="server" Text="" Font-Bold="True" ForeColor="Red"></asp:Label>
            </div>
        </div>

        </div>

       <div class="row">
            <div class="col-lg-12">
                <asp:GridView ID="grdCiclos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%">
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
        </div>
    </section>
</form>
</asp:Content>
