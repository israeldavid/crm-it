<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/home.Master" CodeBehind="activador_fijo.aspx.vb" Inherits="victoriaCRM.activador_fijo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .borderTabla{
            border: black 2px solid;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content">

      <!-- Default box -->
      <div class="box">
        <div class="box-header with-border">
          <h3 class="box-title">Activador Fijo</h3>

          <div class="box-tools pull-right">
            <button type="button" class="btn btn-box-tool" data-widget="collapse" data-toggle="tooltip"
                    title="Collapse">
              <i class="fa fa-minus"></i></button>
            <button type="button" class="btn btn-box-tool" data-widget="remove" data-toggle="tooltip" title="Remove">
              <i class="fa fa-times"></i></button>
          </div>
        </div>
        <div class="box-body">
            <form id="Form1" method="post" enctype="multipart/form-data" runat="server">
               <div class="row borderTabla">
                <div class="col-lg-12 ">
                   <h3 class="text-center">HOJA DE DATOS CONEXINT CNT FIJOS</h3>
                </div>
               </div>
                <hr />
               <div class="row">
                   <div class="col-lg-3 col-md-3 col-sm-2"><b>Ciudad de destino</b></div>
                   <div class="col-lg-5 col-md-5 col-sm-6">
                       <asp:DropDownList ID="ddlciudad" CssClass="form-horizontal" runat="server"></asp:DropDownList></div>
               </div>

                <div class="row">
                   <div class="col-lg-3 col-md-3 col-sm-1"><b>Secuencia:</b></div>
                    <div class="col-lg-3 col-md-3 col-sm-2">
                        <asp:TextBox ID="txtSecuencia" CssClass="form-horizontal" runat="server"></asp:TextBox></div>
                    <div class="col-lg-3 col-md-3 col-sm-1"><b>Estado</b></div>
                    <div class="col-lg-3 col-md-3 col-sm-2">
                        <asp:DropDownList ID="ddlEstadosActivador" CssClass="form-horizontal" runat="server"></asp:DropDownList></div>
                </div>

                <div class="row">
                    <div class="col-lg-3 col-md-3 col-sm-1"><b>Suscripción</b></div>
                    <div class="col-lg-3 col-md-3 col-sm-2">
                        <asp:TextBox ID="txtsuscripcion" CssClass="form-horizontal" runat="server"></asp:TextBox></div>
                    <div class="col-lg-3 col-md-3 col-sm-1"><b>Fecha Atendido</b></div>
                    <div class="col-lg-3 col-md-3 col-sm-2">
                        <asp:TextBox ID="txtfecha" CssClass="form-horizontal" type="date" runat="server"></asp:TextBox></div>
                </div>
                <hr />
                <div class="row">
                    <div class="col-lg-2 col-md-2">
                        <p>-----</p>
                    </div>
                    <div class="col-lg-2 col-md-2">
                        <p><b>Telefonía</b></p>
                    </div>
                    <div class="col-lg-2 col-md-2">
                        <p><b>Internet</b></p>
                    </div>
                    <div class="col-lg-2 col-md-2">
                        <p><b>TV DTH</b></p>
                    </div>
                    <div class="col-lg-1 col-md-1">
                        <div><b>Prov:</b></div>
                    </div>
                    <div class="col-lg-3 col-md-3" >
                        <asp:TextBox ID="txtProvincia" CssClass="form-horizontal" runat="server"></asp:TextBox>
                    </div>
                </div>

                <div class="row">
                    <div class="col-lg-2 col-md-2">
                        <p><b>Contrato:</b></p>
                    </div>
                    <div class="col-lg-2 col-md-2">
                        <p><asp:TextBox ID="txtContratoTelefonia" Width="80%" CssClass="form-horizontal" runat="server"></asp:TextBox></p>
                    </div>
                    <div class="col-lg-2 col-md-2">
                        <p><asp:TextBox ID="txtContratoInternet" Width="80%" CssClass="form-horizontal" runat="server"></asp:TextBox></p>
                    </div>
                    <div class="col-lg-2 col-md-2">
                        <p><asp:TextBox ID="txtContratoTV" Width="80%" CssClass="form-horizontal" runat="server"></asp:TextBox></p>
                    </div>
                    <div class="col-lg-1 col-md-1">
                        <p><b>Localid:</b></p>
                    </div>
                    <div class="col-lg-3 col-md-3">
                        <asp:DropDownList ID="ddlLocalidad" CssClass="form-horizontal" runat="server"></asp:DropDownList>
                    </div>
                </div>

                <div class="row">
                    <div class="col-lg-2 col-md-2">
                        <p><b>Petición:</b></p>
                    </div>
                    <div class="col-lg-2 col-md-2">
                        <p><asp:TextBox ID="txtPeticionTelefonia" Width="90%" CssClass="form-horizontal" runat="server"></asp:TextBox></p>
                    </div>
                    <div class="col-lg-2 col-md-2">
                        <p><asp:TextBox ID="txtPeticionInternet"  Width="90%" CssClass="form-horizontal" runat="server"></asp:TextBox></p>
                    </div>
                    <div class="col-lg-2 col-md-2">
                        <p><asp:TextBox ID="txtPeticionTV"  Width="90%" CssClass="form-horizontal" runat="server"></asp:TextBox></p>
                    </div>
                    <div class="col-lg-1 col-md-1">
                        <p><b>Central:</b></p>
                    </div>
                    <div class="col-lg-3 col-md-3">
                        <p><asp:TextBox ID="txtCentral"  Width="90%" CssClass="form-horizontal" runat="server"></asp:TextBox></p>
                    </div>
                </div>

                <div class="row">
                    <div class="col-lg-2 col-md-2">
                        <p><b># Servicio:</b></p>
                    </div>
                    <div class="col-lg-2 col-md-2">
                        <p><asp:TextBox ID="txtServicioTelefonia" Width="90%" CssClass="form-horizontal" runat="server"></asp:TextBox></p>
                    </div>
                    <div class="col-lg-2 col-md-2">
                        <p><asp:TextBox ID="txtServicioInternet" Width="90%" CssClass="form-horizontal" runat="server"></asp:TextBox></p>
                    </div>
                    <div class="col-lg-2 col-md-2">
                        <p><asp:TextBox ID="txtServicioTV" Width="90%" CssClass="form-horizontal" runat="server"></asp:TextBox></p>
                    </div>
                    <div class="col-lg-1 col-md-1">
                        <p><b>Distrib:</b></p>
                    </div>
                    <div class="col-lg-3 col-md-3">
                        <p><asp:TextBox ID="txtDistribucion" Width="90%" CssClass="form-horizontal" runat="server"></asp:TextBox></p>
                    </div>
                </div>
                <hr />
                <div class="row borderTabla">
                <div class="col-lg-12">
                   <h3 class="text-center">DATOS DEL CLIENTE</h3>
                </div>
               </div>

                <div class="row">
                   <div class="col-lg-4 col-md-4"><b>Nombre del cliente:</b></div>
                   <div class="col-lg-8 col-md-8">
                       <asp:Label ID="lblnombreCliente" CssClass="text-center" runat="server" Font-Bold="True" Font-Size="Large"></asp:Label>
                   </div>
               </div>

                <div class="row">
                   <div class="col-lg-3 col-md-3"><b>Cedula de Identidad:</b></div>
                   <div class="col-lg-3 col-md-3">
                       <asp:TextBox ID="txtCedula" CssClass="form-horizontal" MaxLength="10" runat="server"></asp:TextBox>
                       <asp:Button ID="btnbuscar" runat="server" Text="!" CssClass="btn btn-success" />
                   </div>
                    <div class="col-lg-3 col-md-3"><b>Correo electrónico:</b></div>
                    <div class="col-lg-3 col-md-3">
                        <asp:TextBox ID="txtemail" CssClass="form-horizontal" runat="server" Enabled="False"></asp:TextBox></div>
               </div>

                <div class="row">
                   <div class="col-lg-4 col-md-4"><b>Dirección del Domicilio:</b></div>
                   <div class="col-lg-8 col-md-8">
                       <asp:Label ID="lblDireccion" runat="server" Text=""></asp:Label>
                   </div>
               </div>

                <div class="row">
                   <div class="col-lg-3 col-md-3"><b>Telf Domicilio:</b></div>
                   <div class="col-lg-3 col-md-3">
                       <asp:Label ID="lblTelfDomicilio" runat="server" Text=""></asp:Label>
                       </div>
                    <div class="col-lg-3 col-md-3"><b>Telf Celular:</b></div>
                    <div class="col-lg-3 col-md-3">
                        <asp:TextBox ID="txtcelular" CssClass="form-horizontal" runat="server"></asp:TextBox></div>
               </div>

                <div class="row">
                   <div class="col-lg-4 col-md-4"><b>Telf Area Referencial</b></div>
                   <div class="col-lg-8 col-md-8">
                       <asp:Label ID="lbltelfArea" runat="server" Text=""></asp:Label>
                   </div>
               </div>
                <hr />
                <div class="row borderTabla">
                <div class="col-lg-12 col-md-12">
                   <h3 class="text-center">FORMA DE PAGO</h3>
                </div>
               </div>

                <div class="row">
                   <div class="col-lg-4 col-md-4"><b>Ventanilla</b></div>
                   <div class="col-lg-8 col-md-8">
                       <asp:Label ID="lblVentanilla" runat="server" Text=""></asp:Label>
                   </div>
               </div>

               <div class="row">
                   <div class="col-lg-3 col-md-3"><b>Nombre del Banco:</b></div>
                   <div class="col-lg-3 col-md-3">
                       <asp:Label ID="lblNombreBanco" runat="server" Text=""></asp:Label>
                   </div>
                    <div class="col-lg-3 col-md-3"><b>Numero Cta:</b></div>
                    <div class="col-lg-3 col-md-3">
                        <asp:TextBox ID="txtCuenta" Width="90%" CssClass="form-horizontal" runat="server" Enabled="False"></asp:TextBox></div>
               </div>
                <hr />
                <div class="row borderTabla">
                <div class="col-lg-12 col-md-12">
                   <h3 class="text-center">SERVICIO A CONTRATAR</h3>
                </div>
               </div>

                <div class="row">
                   <div class="col-lg-3 col-md-3">----</div>
                   <div class="col-lg-3 col-md-3"><b>Nombre del Plan</b></div>
                    <div class="col-lg-3 col-md-3"><b>COBRE / GPON:</b></div>
                    <div class="col-lg-3 col-md-3"><b>VALOR</b></div>
               </div>

                <div class="row">
                   <div class="col-lg-3 col-md-3"><b>Telefonia Fija</b></div>
                   <div class="col-lg-3 col-md-3">
                       <asp:Label ID="lblnombrePlan" runat="server" Text=""></asp:Label></div>
                    <div class="col-lg-3 col-md-3"></div>
                    <div class="col-lg-3 col-md-3">
                        <asp:Label ID="lblvalorPlan" runat="server" Text=""></asp:Label>
                    </div>
               </div>

                <div class="row">
                   <div class="col-lg-3 col-md-3"><b>Internet Fijo</b></div>
                   <div class="col-lg-3 col-md-3">
                       <asp:Label ID="lblproducto" runat="server" Text=""></asp:Label></div>
                    <div class="col-lg-3 col-md-3"></div>
                    <div class="col-lg-3 col-md-3">
                        <asp:Label ID="lblvalorproducto" runat="server" Text=""></asp:Label></div>
               </div>

                <div class="row">
                   <div class="col-lg-3 col-md-3"><b>TV</b></div>
                   <div class="col-lg-3 col-md-3">
                       <asp:Label ID="lbltv" runat="server" Text=""></asp:Label>
                   </div>
                    <div class="col-lg-3 col-md-3">
                        <asp:Label ID="lbltvgpon" runat="server" Text=""></asp:Label>
                    </div>
                    <div class="col-lg-3 col-md-3">
                        <asp:Label ID="lbltvvalor" runat="server" Text=""></asp:Label>
                    </div>
               </div>

               <div class="row">
                   <div class="col-lg-4 col-md-4"><b>Vendedor</b></div>
                   <div class="col-lg-8 col-md-8">
                       <asp:Label ID="lblvendedor" runat="server" Text=""></asp:Label></div>
               </div>

                <div class="row">
                   <div class="col-lg-4 col-md-4"><b>Fecha:</b></div>
                   <div class="col-lg-8 col-md-8">
                       <asp:TextBox ID="txtfechaingreso" type="date" CssClass="form-group" runat="server" Enabled="False"></asp:TextBox></div>
               </div>

               <div class="row">
                   <div class="col-lg-4 col-md-4"><b>Plan Fijo:</b></div>
                   <div class="col-lg-8 col-md-8">
                       <asp:DropDownList ID="ddlPlanFijo" runat="server"></asp:DropDownList>
                       </div>
               </div>

             <div class="row">
                   <div class="col-lg-12 col-md-12">
                    <h3 class="text-center">DATOS TECNICOS</h3>
                   </div>
             </div>

             <div class="row">
                   <div class="col-lg-3 col-md-3">
                        <b>No. de Servicio</b>
                   </div>
                   <div class="col-lg-3 col-md-3">
                        <b>Central</b>
                   </div>
                    <div class="col-lg-3 col-md-3">
                        <b>Armario</b>
                   </div>
                    <div class="col-lg-3 col-md-3">
                        <b>Caja</b>
                   </div>
             </div>

                <div class="row">
                   <div class="col-lg-3 col-md-3">
                       <asp:TextBox ID="txtnoservicio" runat="server" CssClass="form-group"></asp:TextBox>
                   </div>
                   <div class="col-lg-3 col-md-3">
                       <asp:TextBox ID="txtcentrals" runat="server" CssClass="form-group"></asp:TextBox> 
                   </div>
                    <div class="col-lg-3 col-md-3">
                        <asp:TextBox ID="txtarmario" runat="server" CssClass="form-group"></asp:TextBox>
                   </div>
                    <div class="col-lg-3 col-md-3">
                        <asp:TextBox ID="txtcaja" runat="server" CssClass="form-group"></asp:TextBox>
                   </div>
             </div>

             

                <div class="row"><div class="col-lg-12 col-md-12">
                    <asp:Button ID="btngrabar" runat="server" Text="Grabar" CssClass="btn-danger btn-block" /></div></div>
            </form>
        </div>
        <!-- /.box-body -->
        <div class="box-footer">
          
        </div>
        <!-- /.box-footer-->
      </div>
      <!-- /.box -->

    </section>
</asp:Content>
