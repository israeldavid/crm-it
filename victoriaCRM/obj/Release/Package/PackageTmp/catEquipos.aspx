<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/home.Master" CodeBehind="catEquipos.aspx.vb" Inherits="victoriaCRM.catEquipos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Content Header (Page header) -->
    <form id="form1" runat="server">
    <section class="content-header">
      <h1>
        Administración del Inventario de Equipos
        <small>Catalogo</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Home</a></li>
        <li><a href="#">Catalogos</a></li>
        <li class="active">Administración de Equipos</li>
      </ol>
    </section>
        
    <section class="content">
        <!-- falta un script manager -->
        <div class="box box-default">
            <div class="box-header with-border">
                <h3 class="box-title">Catalogo de Equipos</h3>

                <div class="box-tools pull-right">
                <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i></button>
                <button type="button" class="btn btn-box-tool" data-widget="remove"><i class="fa fa-remove"></i></button>
            </div>
            <!-- /.box-header -->

        <div class="box-body">

            <div class="row">

                <div class="col-md-3">
                    <label>Model del Equipo</label>

                </div>

                <div class="col-md-9">
                    <asp:textbox id="txtdescripcion" runat="server" CssClass="btn-block"></asp:textbox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtdescripcion" ErrorMessage="Error el campo no puede estar en blanco" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
                <hr />
           </div>

           <div class="row">
               <div class="col-md-3">
                    <label>Marca:</label>
               </div>
               <div class="col-md-9">
                    <asp:dropdownlist id="ddlmarca" runat="server"></asp:dropdownlist></div>
           </div>

            <div class="row">
               <div class="col-md-3">
                    <label>IMEI</label>
               </div>
               <div class="col-md-9">
                    <asp:textbox id="txtimei" runat="server" CssClass="btn-block"></asp:textbox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtimei" ErrorMessage="Error el campo no puede estar en blanco" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
           </div>

            <div class="row">
               <div class="col-md-3">
                     <label>Codigo NIP</label>
               </div>
               <div class="col-md-9">
                    <asp:TextBox ID="txtcodigonip" runat="server"></asp:TextBox>
                    
                </div>
           </div>

            <div class="row">
               <div class="col-md-3">
                     <label>IMSI</label> 
               </div>
               <div class="col-md-9">
                    <asp:textbox id="txtimsi" runat="server"></asp:textbox>
                    
                </div>
           </div>

           <div class="row">
               <div class="col-md-3">
                   <label>Estado:</label>
               </div>
               <div class="col-md-6">
                   <asp:dropdownlist runat="server" id="ddlEstado">
                       <asp:ListItem Value="S">En Stock</asp:ListItem>
                       <asp:ListItem Value="P">Pendiente de Entrega</asp:ListItem>
                       <asp:ListItem Value="K">Sin Stock</asp:ListItem>
                   </asp:dropdownlist>
               </div>
               <div class="col-md-3">
                    
                </div>
           </div>
           <div class="row">
               <div class="col-md-6"><asp:Button ID="btnGrabar" runat="server" CssClass="btn btn-block btn-danger" Text="Grabar" /></div>
               <div class="col-md-6"><asp:Button ID="btnExcel" runat="server" CssClass="btn btn-block btn-success" Text="Exportar Excel" CausesValidation="False" /></div>
           </div>
            <div class="row">
                <div class="col-lg-12">
                    <asp:Label ID="lblerror" runat="server" Text="" Font-Bold="True" ForeColor="Red"></asp:Label>
                </div>
            </div>

        <div class="row">
            <div class="col-lg-12">           
                <asp:GridView ID="grdEquipos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%">
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

        </div>
    </section>
</form>

</asp:Content>
