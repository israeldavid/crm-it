<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/home.Master" CodeBehind="score_actualizacion.aspx.vb" Inherits="victoriaCRM.score_actualizacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <section class="content-header">
      <h1>
        Actualización de Score
        <small>Catalogo</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Home</a></li>
        <li><a href="#">Catalogos</a></li>
        <li class="active">Actualización de Score</li>
      </ol>
    </section>

    <section class="content">
        <div class="box box-default">
            <div class="box-header with-border">
                <h3 class="box-title">Actualización de Score</h3>

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
            <div class="row">
                <div class="col-md-3">
                    <asp:Label ID="lblPlan" runat="server" Text="Tarifa Plan aplicado:" Font-Bold="True"></asp:Label>
                </div>
                <div class="col-md-3">
                    <asp:Label ID="lbltarifa" runat="server" Text=""></asp:Label>
                </div>
                <div class="col-md-3">
                    <asp:Label ID="lblnombre" runat="server" Text="Nombre del Plan:" Font-Bold="True"></asp:Label>
                </div>
                <div class="col-md-3">
                    <asp:Label ID="lblnombreplan" runat="server" Text=""></asp:Label>
                </div>
            </div>

        <hr />

          <div class="row">
            <div class="col-md-2">
                 <label>Seleccione la Calificación</label>
            </div>
            <div class="col-md-4">
                <asp:DropDownList ID="ddlcalificacion" runat="server"></asp:DropDownList>
            </div>
            <div class="col-md-2">
                <label>Score</label>
            </div>
            <div class="col-md-4">
                <asp:TextBox ID="txtScore" runat="server"></asp:TextBox>
            </div>
          </div>

        <hr />

            <div class="row">
                <div class="col-12">
                    <h3>Ingreso de Planes Contratados</h3>
                </div>
            </div>

            <div class="row">           
                <div class="col-lg-3">
                    <asp:Label ID="lblvalordelplan" runat="server" Text="Valor del Plan" Font-Bold="True"></asp:Label>
                </div>
                <div class="col-lg-3">
                    <asp:TextBox ID="txtvalorplan" runat="server"></asp:TextBox>
                </div>
                <div class="col-lg-3">
                    <asp:Label ID="lblfechacontrato" runat="server" Text="Fecha de Ingreso" Font-Bold="True"></asp:Label>
                </div>
                <div class="col-lg-3">
                    <asp:TextBox ID="txtfechaingreso"  runat="server" TextMode="Date"></asp:TextBox>
                </div>
            </div>

            <hr />

            <div class="row">
                <div class="col-lg-3">
                    <asp:Button ID="btnGrabarHistorico" CssClass="btn-danger" runat="server" Text="Grabar Historico" />
                </div>
                <div class="col-lg-9">
                    <asp:Label ID="lblerroContrato" runat="server" Text="" Font-Bold="True" ForeColor="Red"></asp:Label>
                </div>
            </div>
            <hr />
            <div class="row">
                <div class="col-12">
                    <asp:GridView ID="grdscore" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="valorscore" HeaderText="Valor del Score" />
                            <asp:BoundField DataField="fecha1" HeaderText="Fecha de Inicio" />
                            <asp:BoundField DataField="fecha2" HeaderText="Fecha de Vigencia" />
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
              
        <div class="row">

            <div class="col-md-3">
                
            </div>

           <div class="col-md-6">
                  <asp:Button ID="btnGrabar" runat="server" Text="Grabar" CssClass="btn-danger btn-block" />
              </div>
        </div>
            
        <hr />
        
        <div class="row">
            <div class="col-md-12">
                <asp:Label ID="lblerror" runat="server" Text="" Font-Bold="True" ForeColor="Red"></asp:Label>
            </div>
        </div>
        </div>

        </div>
    </section>
</form>
</asp:Content>
