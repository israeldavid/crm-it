<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/home.Master" CodeBehind="activador_movil.aspx.vb" Inherits="victoriaCRM.activador_movil" %>
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
                <div class="col-lg-12">
                   <h3 class="text-center">HOJA DE DATOS CONEXINT CNT FIJOS</h3>
                </div>
               </div>

            <div class="row">
                   <div class="col-lg-3 col-md-3 col-sm-2"><b>Ciudad de destino</b></div>
                   <div class="col-lg-5 col-md-5 col-sm-6">
                       <asp:DropDownList ID="ddlciudad" CssClass="form-horizontal" runat="server"></asp:DropDownList></div>
               </div>

            <div class="row">
                <div class="col-lg-4"><b>Contrato</b></div>
                <div class="col-lg-8">
                    <asp:TextBox ID="txtcontrato" CssClass="form-group" runat="server"></asp:TextBox></div>
            </div>

            <div class="row">
                <div class="col-lg-4"><b>Producto:</b></div>
                <div class="col-lg-8">
                    Viene de la pagina de producto, se selecciona? o se busca por codigo</div>
            </div>

            <div class="row">
                <div class="col-lg-4"><b>Nombre del cliente:</b></div>
                <div class="col-lg-8">
                    <asp:TextBox ID="txtNombrecliente" runat="server"></asp:TextBox>
                </div>
            </div>

            <div class="row">
                <div class="col-lg-4"><b>Cedula:</b></div>
                <div class="col-lg-8">
                    <asp:TextBox ID="txtcedula" CssClass="form-group" MaxLength="13" runat="server"></asp:TextBox>
                    <asp:Button ID="btnbuscar" runat="server" Text="!" CssClass="btn-success" />
                </div>

            </div>

            <div class="row">
                <div class="col-lg-4"><b>Fecha de Exp:</b></div>
                <div class="col-lg-8">
                    Viene de la pagina de cliente, se selecciona? o se busca por cedula</div>
            </div>

            <div class="row">
                <div class="col-lg-4"><b>Fecha de Nac:</b></div>
                <div class="col-lg-8">
                    Viene de la pagina de cliente, se selecciona? o se busca por cedula</div>
            </div>

            <div class="row">
                <div class="col-lg-4"><b>Dirección:</b></div>
                <div class="col-lg-8">
                    <asp:TextBox ID="txtdireccion" runat="server"></asp:TextBox>
                </div>
            </div>

            <div class="row">
                <div class="col-lg-3"><b>Telf Domicilio:</b></div>
                <div class="col-lg-3">
                    <asp:TextBox ID="txtTelfDireccion" Enabled="true" runat="server"></asp:TextBox></div>
                <div class="col-lg-3">Telf:</div>
                <div class="col-lg-3">
                    <asp:TextBox ID="txtCelular" Enabled="true" runat="server"></asp:TextBox></div>
            </div>

            <div class="row">
                <div class="col-lg-4"><b>Dirección de Trabajo:</b></div>
                <div class="col-lg-8">
                    Viene de la pagina de cliente, se selecciona? o se busca por cedula</div>
            </div>

            <div class="row">
                <div class="col-lg-3"><b>Telf trabajo:</b></div>
                <div class="col-lg-3">Viene de la pagina Cliente?</div>
                <div class="col-lg-3">Telf:</div>
                <div class="col-lg-3">????</div>
            </div>

            <div class="row">
                <div class="col-lg-3"><b>Ref Personal:</b></div>
                <div class="col-lg-3">
                    <asp:TextBox ID="txtrefpersonal" CssClass="form-group" runat="server"></asp:TextBox></div>
                <div class="col-lg-3">Telf:</div>
                <div class="col-lg-3">
                    <asp:TextBox ID="txttelfpersonal" CssClass="form-group" runat="server"></asp:TextBox></div>
            </div>

            <div class="row">
                <div class="col-lg-3"><b>Correo Electrónico:</b></div>
                <div class="col-lg-8">
                    <asp:TextBox ID="txtemail" CssClass="form-group" runat="server"></asp:TextBox></div>
            </div>

            <div class="row">
                <div class="col-lg-12">
                   <h3 class="text-center">FORMA DE PAGO</h3>
                </div>
            </div>

            <div class="row">
                <div class="col-lg-4"><b>Nombre del Banco:</b></div>
                <div class="col-lg-8">
                    <asp:Label ID="lblNombreBanco" runat="server" Text=""></asp:Label></div>
            </div>

            <div class="row">
                <div class="col-lg-4"><b>Tipo de Cuenta:</b></div>
                <div class="col-lg-8">
                    <asp:Label ID="lbltipoCta" runat="server" Text=""></asp:Label></div>
            </div>

            <div class="row">
                <div class="col-lg-4"><b>Numero Cta / Tarjeta Credito:</b></div>
                <div class="col-lg-8">
                    <asp:TextBox ID="txtCuenta" runat="server"></asp:TextBox>
                    </div>
            </div>

            <div class="row">
                <div class="col-lg-4"><b>Fecha de Expiración:</b></div>
                <div class="col-lg-8">
                    <asp:Label ID="lblfechaexpiracion" runat="server" Text=""></asp:Label></div>
            </div>

            <div class="row">
                <div class="col-lg-12">
                   <h3 class="text-center">PORTABILIDAD</h3>
                </div>
               </div>

            <div class="row">
                <div class="col-lg-4"><b>a ser Portado:</b></div>
                <div class="col-lg-3">Esto viene de la pantalla de transacciones???</div>
                <div class="col-lg-3">MOVISTAR</div>
            </div>

            <div class="row">
                <div class="col-lg-12">
                   <h3 class="text-center">PLAN ADQUIRIR</h3>
                </div>
               </div>

             <div class="row">
                <div class="col-lg-4"><b>STO DEL PLAN:</b></div>
                <div class="col-lg-8">
                    <asp:Label ID="lblnombrePlan" runat="server" Text=""></asp:Label></div>
            </div>

             <div class="row">
                <div class="col-lg-4"><b>CODIGO PLAN:</b></div>
                <div class="col-lg-8">
                    <asp:Label ID="lblcodigoPlan" runat="server" Text=""></asp:Label></div>
            </div>

             <div class="row">
                <div class="col-lg-4"><b>CODIGO NIP:</b></div>
                <div class="col-lg-8">
                    <asp:Label ID="lblcodigoNIP" runat="server" Text=""></asp:Label></div>
            </div>

             <div class="row">
                <div class="col-lg-4"><b>Equipo Adquirido en CNT:</b></div>
                <div class="col-lg-8">
                    <asp:Label ID="lblEquipo" runat="server" Text=""></asp:Label></div>
            </div>


             <div class="row">
                <div class="col-lg-4"><b>Marca de equipo portado:</b></div>
                <div class="col-lg-8">
                    <asp:Label ID="lblmarcaEquipo" runat="server" Text=""></asp:Label></div>
            </div>

             <div class="row">
                <div class="col-lg-4"><b>Vendedor:</b></div>
                <div class="col-lg-8">
                    <asp:Label ID="lblvendedor" runat="server" Text=""></asp:Label></div>
            </div>

             <div class="row">
                <div class="col-lg-4"><b>Calificación Buro:</b></div>
                <div class="col-lg-8">
                    <asp:Label ID="lblburo" runat="server" Text="Label"></asp:Label></div>
            </div>

             <div class="row">
                <div class="col-lg-4"><b>Fecha:</b></div>
                <div class="col-lg-8">
                    <asp:TextBox ID="txtfechaingreso" runat="server"></asp:TextBox></div>
            </div>

            <div class="row"><div class="col-lg-12">
                    <asp:Button ID="btngrabar" runat="server" Text="Grabar" CssClass="btn-danger btn-block" /></div>

            </div>
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
