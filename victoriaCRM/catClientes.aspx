<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/home.Master" CodeBehind="catClientes.aspx.vb" Inherits="victoriaCRM.catClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Content Header (Page header) -->
    <div class="container-fluid">
    <form id="form1" runat="server">
    <section class="content-header">
      <h1>
        Administración de los datos de Clientes
        <small>Catalogo</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Home</a></li>
        <li><a href="#">Catalogos</a></li>
        <li class="active">Administración Clientes</li>
      </ol>
    </section>

    <section class="content">
        <asp:HiddenField ID="hdestado" Value="N" runat="server" />
        <div class="box box-default">
            <div class="box-header with-border">
                <h3 class="box-title">Catalogo de Clientes</h3>

                <div class="box-tools pull-right">
                <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i></button>
                <button type="button" class="btn btn-box-tool" data-widget="remove"><i class="fa fa-remove"></i></button>
            </div>
            <!-- /.box-header -->

        <div class="box-body">

            <div class="row">
                <div class="form-group">
                <div class="col-sm-2 col-md-2 col-lg-2">
                    <label>Tipo de Cliente</label>
                </div>

                <div class="col-sm-3 col-md-3 col-lg-3" >
                    <asp:DropDownList ID="ddlTipoCliente" class="form-control" runat="server">
                        <asp:ListItem Value="N">Natural</asp:ListItem>
                        <asp:ListItem Value="J">Juridica</asp:ListItem>
                    </asp:DropDownList>
                </div>

                <div class="col-sm-2 col-md-2 col-lg-2">
                    <label>Nombre de Empresa</label>                    
                </div>

                <div class="col-sm-4 col-md-4 col-lg-4">
                    <asp:textbox id="txtempresa" class="form-control" runat="server"></asp:textbox>
                </div>
                </div>
          </div>
 <hr />
          <div class="row">
              <div class="form-group">
            <div class="col-md-1">
                 <label>Cedula / RUC</label>
           </div>
              <div class="col-md-3">
                <asp:textbox id="txtcedula" runat="server" class="form-control" MaxLength="13"></asp:textbox>
                  <asp:Button ID="btnBuscar" runat="server" Text="!" CssClass="btn-danger" CausesValidation="False" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtcedula" ErrorMessage="Campo de Cedula es necesario" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>

            <div class="col-md-1">
                <label>Nombres:</label>
                </div>
           <div class="col-md-3">
                <asp:TextBox ID="txtnombres" runat="server" class="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtnombres" ErrorMessage="Campo de Nombre es necesario" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>

            <div class="col-md-1">
                <label>Apellidos:</label>
            </div>
            
            <div class="col-md-3">
                <asp:textbox ID="txtapellidos" class="form-control" runat="server"></asp:textbox>
            </div>
            </div>
          </div>

        <hr />

        <div class="row">
            <div class="form-group">
              <div class="col-md-1">
                 <label>Fecha de Nacimiento</label>
              </div>
              <div class="col-md-2">
                 <i class="fa fa-calendar">
                     <asp:textbox id="txtfechanac" class="form-control" runat="server"></asp:textbox>
                 </i>
              </div>

              <div class="col-md-1">
                 <label>Fecha de Expedición Cedula</label>
               </div>

              <div class="col-md-2">
                 <i class="fa fa-calendar">
                     <asp:textbox id="txtfechaexp" class="form-control" runat="server"></asp:textbox>
                 </i>
              </div>

              <div class="col-md-1">
                 <label># Telf. Personal</label>
              </div>

              <div class="col-md-2">
                 <asp:textbox id="txttelefono" class="form-control" runat="server" MaxLength="10"></asp:textbox>
              </div>

              <div class="col-md-1">
                 <label>Estado</label>
              </div>

              <div class="col-md-2">
                  <asp:DropDownList ID="ddlestado" class="form-control" runat="server"></asp:DropDownList>
              </div>
                </div>
          </div>
          
        <hr />

        <div class="row">
            <div class="form-group">
                <div class="col-md-1">
                 <label>email</label>
                 
                 </div>
                
                <div class="col-md-2">
                    <asp:textbox id="txtemail" runat="server"  class="form-control" TextMode="Email" MaxLength="100"></asp:textbox>
                </div>

                <div class="col-md-1">
                 <label>Dir. trabajo:</label>     
                </div>

                <div class="col-md-2">
                    <asp:textbox id="txtdirtrabajo" class="form-control" runat="server" MaxLength="120"></asp:textbox>
                </div>

                <div class="col-md-1">
                    <label>Telf. Trabajo</label>               
                </div>

            <div class="col-md-2">
                <asp:textbox id="txtteltrabajo" class="form-control" runat="server" MaxLength="10"></asp:textbox>
            </div>

              <div class="col-md-1">
                  <label>Ciudad:</label>  
              </div>

              <div class="col-md-2">
                <asp:DropDownList ID="ddlCiudad" class="form-control" runat="server"></asp:DropDownList>
              </div>
                </div>
            </div>
        <hr />
        <div class="row">
            <div class="form-group">
            <div class="col-md-2">
                <label>Ref. Personal</label>               
            </div>

            <div class="col-md-4">
                <asp:textbox id="txtreferencia" class="form-control" runat="server"></asp:textbox>
            </div>

            <div class="col-md-2">
                <label>Telf. Ref. Personal</label>
            </div>

            <div class="col-md-4">
                <asp:textbox id="txttelefonoRef" class="form-control" runat="server"></asp:textbox>
            </div>
                </div>
        </div>
            
        <hr />

            <div class="row">
                <div class="col-md-12">
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btn btn-block btn-primary" />
            </div>
        </div>
            
        </div>

             <hr />

        <div class="row">
            <div class="col-md-3">
                <asp:Label ID="lblcargar" runat="server" Text="Cargar Archivo de Excel" Font-Bold="True"></asp:Label>
            </div>
            <div class="col-md-3">
                <asp:FileUpload ID="fileSubir" runat="server" />
            </div>
            <div class="col-md-3">
                <asp:Button ID="btnSubir" runat="server" Text="Subir Archivo" CssClass="btn-success btn-block" CausesValidation="False" />
            </div>
            <div class="col-md-3">
                <asp:Button ID="btnGrabar" runat="server" Text="Grabar Registros" CssClass="btn-danger btn-block" CausesValidation="False" />
            </div>
        </div>

        <hr />
        
        <div class="row">
            <div class="col-md-12">
                <asp:Label ID="lblerror" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
            </div>
        </div>

        </div>

        <div class="row">
            <div class="col-lg-12">
                <asp:GridView ID="grdDatos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" AutoGenerateColumns="False">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:ButtonField ButtonType="Button" Text="Editar" />
                        <asp:BoundField DataField="ruc" HeaderText="Cedula/RUC" />
                        <asp:BoundField DataField="nombreEmpresa" HeaderText="Empresa" />
                        <asp:BoundField DataField="nombres" HeaderText="Nombres" />
                        <asp:BoundField DataField="apellidos" HeaderText="Apellidos" />
                        <asp:BoundField DataField="fechanacimiento" HeaderText="Fecha Nacimiento" />
                        <asp:BoundField DataField="fechaExpedicion" HeaderText="Fecha Expedicion" />
                        <asp:BoundField DataField="telefono1" HeaderText="Telf" />
                        <asp:BoundField DataField="telefonoTrabajo" HeaderText="Telf. Trabajo" />
                    </Columns>
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
    </section>
</form>
        </div>
</asp:Content>
