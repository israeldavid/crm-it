<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/home.Master" CodeBehind="transaccionesInternet.aspx.vb" Inherits="victoriaCRM.transaccionesInternet" %>
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
                <h3 class="box-title">Transacciones Internet</h3>

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
                 <label>Correo electrónico:</label>
            </div>
            <div class="col-md-4">
                <asp:Label ID="lblemail" runat="server" Text=""></asp:Label>
            </div>
            <div class="col-md-2">
                <label>Telefono de Domicilio:</label>
            </div>
            <div class="col-md-4">
                <asp:Label ID="lbltelefono1" runat="server" Text=""></asp:Label>
            </div>
          </div>

        <hr />

        <div class="row">
              <div class="col-md-3">
                 <label>Telf. Referencia</label>
              </div>
              <div class="col-md-3">
                  <asp:Label ID="lbltelefonoref" runat="server" Text=""></asp:Label>
              </div>

              <div class="col-md-3">
                <label>Procedencia</label>
              </div>

              <div class="col-md-3">
              </div>
         </div>
            
         <hr />

         <div class="row">
             <div class="col-lg-12">
                 <h2 class="text-center">SERVICIO A CONTRATAR</h2>
             </div>
         </div>

        <hr />

        <div class="row">
            <div class="col-lg-3 col-md-3 col-sm-2"></div>
            <div class="col-lg-3 col-md-3 col-sm-2"><b>Nombre del Plan</b></div>
            <div class="col-lg-3 col-md-3 col-sm-2"><b>Cobre/GPON</b></div>
            <div class="col-lg-3 col-md-3 col-sm-2"><b>Valor</b></div>
        </div>
        
        <div class="row">
            <div class="col-lg-3 col-md-3 col-sm-2"><b>TELEFONIA FIJA</b></div>
            <div class="col-lg-3 col-md-3 col-sm-2">
                <asp:CheckBox ID="chknombre" runat="server" /></div>
            <div class="col-lg-3 col-md-3 col-sm-2">
                <asp:CheckBox ID="chkgpon" runat="server" /></div>
            <div class="col-lg-3 col-md-3 col-sm-2">
                <asp:TextBox ID="txtvalor" runat="server"></asp:TextBox></div>
        </div>

        <div class="row">
            <div class="col-lg-3 col-md-3 col-sm-2" ><b>INTERNET FIJO</b></div>
            <div class="col-lg-3 col-md-3 col-sm-2">
                <asp:TextBox ID="txtinternet" runat="server"></asp:TextBox>
                </div>
            <div class="col-lg-3 col-md-3 col-sm-2">
                <asp:CheckBox ID="chkgponinternet" runat="server" /></div>
            <div class="col-lg-3 col-md-3 col-sm-2">
                <asp:TextBox ID="txtvalorinternet" runat="server"></asp:TextBox></div>
        </div>

<hr />

        <div class="row">
            <div class="col-lg-2 col-md-2 col-sm-2"><b>Vendedor:</b></div>
            <div class="col-lg-10 col-md-10 col-sm-8">
                <asp:DropDownList ID="ddlVendedores" runat="server">
                </asp:DropDownList>
            </div>
        </div>

        <div class="row">
            <div class="col-lg-2 col-md-2 col-sm-2"><b>Fecha:</b></div>
            <div class="col-lg-10 col-md-10 col-sm-8">
                <asp:TextBox ID="txtfechainternet" runat="server"></asp:TextBox>
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

        </div>
        </div>
    </section>
</form>
</asp:Content>
