<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/home.Master" CodeBehind="transacciones.aspx.vb" Inherits="victoriaCRM.transacciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Content Header (Page header) -->
    <form id="form1" runat="server">
    <section class="content-header">
      <h1>
        Transacciones
        <small>Ventas</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Home</a></li>
        <li><a href="#">Transacciones</a></li>
        <li class="active">Administración Transacciones</li>
      </ol>
    </section>

    <section class="content">
        <div class="box box-default">
            <div class="box-header with-border">
                <h3 class="box-title">Transacciones</h3>

                <div class="box-tools pull-right">
                <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i></button>
                <button type="button" class="btn btn-box-tool" data-widget="remove"><i class="fa fa-remove"></i></button>
            </div>
            <!-- /.box-header -->

        <div class="box-body">

            <div class="row">
                <div class="col-md-2">
                    <label>Cedula/Ruc</label>
                </div>

                <div class="col-md-2">
                    <asp:TextBox ID="txtcedula" runat="server" Width="100%" MaxLength="13"></asp:TextBox>
                    <asp:Label ID="lblErrorCliente" runat="server" Text=""></asp:Label>
                </div>

                <div class="col-md-1">
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn-success" />
                    <asp:HiddenField ID="hfIDCliente" runat="server" />
                </div>

                <div class="col-md-2">
                    <label>Cliente:</label>
                </div>

                <div class="col-md-5">
                    <asp:textbox id="txtnombres" runat="server" Width="100%" ReadOnly="true"></asp:textbox>
                </div>
           </div>

        <hr />

          <div class="row">
            <div class="col-md-2">
                 <label>Seleccione el Plan</label>
            </div>
            <div class="col-md-4">
                <asp:DropDownList ID="ddlplan" runat="server"></asp:DropDownList>
            </div>
            <div class="col-md-2">
                <label>Seleccione Vendedor</label>
            </div>
            <div class="col-md-4">
                <asp:DropDownList ID="ddlVendedor" runat="server"></asp:DropDownList>
            </div>
          </div>

        <hr />

        <div class="row">
              <div class="col-md-3">
                 <label>Operadora</label>
              </div>
              <div class="col-md-3">
                  <asp:DropDownList ID="ddlOperadora" runat="server"></asp:DropDownList>
              </div>

              <div class="col-md-3">
                <label>Procedencia</label>
              </div>

              <div class="col-md-3">
                  <asp:DropDownList ID="ddlProcedencia" runat="server">
                      <asp:ListItem Value="B">Bodega</asp:ListItem>
                      <asp:ListItem Value="C">Cliente</asp:ListItem>
                      <asp:ListItem Value="O">Operadora</asp:ListItem>
                  </asp:DropDownList>
              </div>
         </div>
            
         <hr />

         <div class="row">

             <div class="col-md-3">
                 <label># de Celular</label>
             </div>
             <div class="col-md-3">
                 <asp:TextBox ID="txtcelular" runat="server"></asp:TextBox>
             </div>
             
             <div class="col-md-3">
                 <label># Contrato</label>
             </div>

             <div class="col-md-3">
                <asp:textbox id="txtcontrato" runat="server"></asp:textbox>
             </div>
         </div>

        <hr />

         <div class="row">
             
              <div class="col-md-2">
                 <label>Equipo:</label>
                  <asp:DropDownList ID="ddlEquipos" runat="server"></asp:DropDownList>
              </div>

              <div class="col-md-1">
                  <asp:Label ID="lbllinea" runat="server" Text="Linea Nueva:" Font-Bold="true"></asp:Label>
              </div>
             <div class="col-md-3">
                 <asp:textbox id="txtnumeroLineaNueva" runat="server"></asp:textbox>
              </div>

              <div class="col-md-3">
                 <label>Estado</label>
                  <asp:DropDownList ID="ddlestados" runat="server" Width="60%">
                      <asp:ListItem Value="A">Activo</asp:ListItem>
                      <asp:ListItem Value="S">Suspendido</asp:ListItem>
                      <asp:ListItem Value="C">Cancelado</asp:ListItem>
                  </asp:DropDownList>
              </div>

             <div class="col-md-1">
                 <asp:Label ID="lblportabilidad" runat="server" Text="Portabilidad" Font-Bold="true"></asp:Label>
             </div>
             <div class="col-md-2 col-sm-1">
                 <asp:textbox id="txtPortabilidad" runat="server" Width="80%"></asp:textbox>
             </div>
        </div>
          
        <hr />

        <div class="row"> 
            <div class="col-lg-12">
                <h3>Datos para el Pago</h3>
            </div>
        </div>

        <hr />
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <div class="row">
                        <div class="col-lg-2">
                            <label>Forma de Pago</label>
                        </div>
                        <div class="col-lg-4">
                            <asp:DropDownList ID="ddlformapago" runat="server" AutoPostBack="True" AppendDataBoundItems="true">
                                <asp:ListItem Value="0">Seleccione un Item</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <!-- este es la parte de debito automatico -->
                    <div class="row">
                        <div class="col-lg-2">
                            <asp:Label ID="lblcuenta" runat="server" Text="Cuenta" Font-Bold="True" Visible="false"></asp:Label>
                        </div>
                        <div class="col-lg-4">
                            <asp:TextBox ID="txtcuenta" runat="server" CssClass="form-group" Visible="false"></asp:TextBox>
                        </div>
                        <div class="col-lg-3">
                            <asp:Label ID="lbltipo" runat="server" Text="Tipo de Cuenta:" Font-Bold="True" Visible="false"></asp:Label>
                        </div>
                        <div class="col-lg-3">
                            <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" Visible="false">
                                <asp:ListItem Value="A">Ahorros</asp:ListItem>
                                <asp:ListItem Value="C">Corriente</asp:ListItem>
                            </asp:RadioButtonList>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-lg-2">
                            <asp:Label ID="lblbanco" runat="server" Text="Banco" Font-Bold="True" Visible="false"></asp:Label>                          
                        </div>
                        <div class="col-lg-10">
                            <asp:DropDownList ID="ddlbancos" runat="server" Visible="false"></asp:DropDownList>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-lg-2">
                            <asp:Label ID="lbltarjeta" runat="server" Text="Tarjeta:" Visible="False" Font-Bold="True"></asp:Label>
                        </div>
                        <div class="col-lg-4">
                            <asp:DropDownList ID="ddltarjeta" runat="server" Visible="false"></asp:DropDownList>
                        </div>
                        <div class="col-lg-2">
                            <asp:Label ID="lblnumerotarjeta" runat="server" Text="Num. Tarjeta:" Visible="False" Font-Bold="True"></asp:Label>
                        </div>
                        <div class="col-lg-4">
                            <asp:TextBox ID="txtNumeroTC" runat="server" CssClass="form-group" Visible="false"></asp:TextBox>
                        </div>
                    </div>
                    <div class="row">                 
                        <div class="col-lg-2">
                            <asp:Label ID="lblFecha" runat="server" Text="Fecha:" Visible="False" Font-Bold="True"></asp:Label>
                        </div>
                        <div class="col-lg-10">
                            <asp:TextBox ID="txtfecha" runat="server" TextMode="Date" Visible="false"></asp:TextBox>
                            <!-- <asp:Label ID="lblccv" runat="server" Text="CCV:" Visible="false"> </asp:Label>
                            <asp:TextBox ID="txtccv" runat="server" Visible="false"></asp:TextBox>!-->
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-lg-2">
                            <asp:Label ID="lblnumeropapeleta" runat="server" Text="Num. Papeleta" Visible="False" Font-Bold="True"></asp:Label>
                        </div>
                         <div class="col-lg-4">
                            <asp:TextBox ID="txtnumero"  CssClass="form-group" runat="server" Visible="false"></asp:TextBox>     
                        </div>
                        <div class="col-lg-2">
                            <asp:Label ID="lblfechadeposito" runat="server" Text="Fecha deposito:" Visible="False" Font-Bold="True"></asp:Label>
                        </div>
                        <div class="col-lg-4">
                            <asp:TextBox ID="txtfechaDeposito" CssClass="form-group" runat="server" TextMode="Date" Visible="false"></asp:TextBox>
                        </div>
                    </div>
             </ContentTemplate>
                 </asp:UpdatePanel>
        <div class="row">
           <div class="col-lg-12">
                  <asp:Button ID="btnGrabar" runat="server" Text="Grabar" CssClass="btn-danger btn-block" />
           </div>
        </div>
            
        <hr />
        
        <div class="row">
            <div class="col-lg-12">
                <asp:Label ID="lblerror" runat="server" Text="" Font-Bold="True" ForeColor="Red"></asp:Label>
            </div>
        </div>

        </div>

       <div class="row">
            <div class="col-lg-12">
                <asp:GridView ID="grdTransacciones" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%">
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
