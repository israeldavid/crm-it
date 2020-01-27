<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/home.Master" CodeBehind="cargaDocumentos.aspx.vb" Inherits="victoriaCRM.cargaDocumentos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <section class="content-header">
      <h1>
        Ingreso de Documentos Scaneados
        <small>Legalizar</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Home</a></li>
        <li><a href="#">Legalizar</a></li>
        <li class="active">Subir Archivos Scaneados</li>
      </ol>
    </section>

    <section class="content">
        <div class="box box-default">
            <div class="box-header with-border">
                <h3 class="box-title">Legalización de Documentos</h3>

                <div class="box-tools pull-right">
                <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i></button>
                <button type="button" class="btn btn-box-tool" data-widget="remove"><i class="fa fa-remove"></i></button>
            </div>
            <!-- /.box-header -->

        <div class="box-body">

            <div class="row">

                <div class="col-sm-3 col-md-3">
                    <label>Cedula:</label><asp:HiddenField ID="hfIDCliente" runat="server" />
                </div>

                <div class="col-sm-4 col-md-4 col-lg-auto col-xl-auto">
                    <asp:TextBox ID="txtcedula" runat="server" MaxLength="10"></asp:TextBox>
                    <asp:Button ID="btnbuscar" runat="server" CssClass="btn-success" Text="!" CausesValidation="False" />
                </div>

                <div class="col-sm-5 col-md-5 col-lg-5" >
                    <asp:Label ID="lblnombre" runat="server" Text="Cliente:" Font-Bold="True"></asp:Label>
                    <asp:Label ID="lblnombreCliente" runat="server" Text=""></asp:Label>
                </div>

            </div>

                <div class="row">
                    <div class="col-sm-3 col-md-3 col-lg-3"><b>Plan:</b></div>
                    <div class="col-sm-3 col-md-3 col-lg-3" >
                        <asp:Label ID="lblplan" runat="server" Text=""></asp:Label></div>
                    <div class="col-sm-3 col-md-3 col-lg-3" ><b>Portabilidad:</b></div>
                    <div class="col-sm-3 col-md-3 col-lg-3" >
                        <asp:Label ID="lblportabilidad" runat="server" Text=""></asp:Label>
                    </div>
                </div>
 
          <hr />

                    <div class="row">
                        <div class="col-md-3">
                            <label>Listado de Activación</label>
                        </div>
                         <div class="col-md-9">
                            <asp:DropDownList ID="ddlListado" runat="server" AutoPostBack="True" AppendDataBoundItems="true">
                                <asp:ListItem Value="">Seleccione un plan</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <hr />
                    
                        <div class="row">
                            <div class="col-lg-4 col-md-4 col-sm-4">
                                <asp:Label ID="Label1" runat="server" Font-Bold="true" Text="" Visible="false"></asp:Label>
                            </div>
                            <div class="col-lg-8 col-md-8 col-sm-8">
                                <asp:FileUpload ID="FileUpload1" Visible="false" runat="server" />
                            </div>
                        </div>

                       <div class="row">
                            <div class="col-lg-4 col-md-4 col-sm-4">
                                <asp:Label ID="Label2" runat="server" Font-Bold="true" Text="" Visible="false"></asp:Label>
                            </div>
                            <div class="col-lg-8 col-md-8 col-sm-8">
                                <asp:FileUpload ID="FileUpload2"  Visible="false" runat="server" />
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-lg-4 col-md-4 col-sm-4">
                                <asp:Label ID="Label3" runat="server" Font-Bold="true" Text="" Visible="false"></asp:Label>
                            </div>
                            <div class="col-lg-8 col-md-8 col-sm-8">
                                <asp:FileUpload ID="FileUpload3"  Visible="false" runat="server" />
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-lg-4 col-md-4 col-sm-4">
                                <asp:Label ID="Label4" runat="server" Font-Bold="true" Text="" Visible="false"></asp:Label>
                            </div>
                            <div class="col-lg-8 col-md-8 col-sm-8">
                                <asp:FileUpload ID="FileUpload4"  Visible="false" runat="server" />
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-lg-4 col-md-4 col-sm-4">
                                <asp:Label ID="Label5" runat="server" Font-Bold="true" Text="" Visible="false"></asp:Label>
                            </div>
                            <div class="col-lg-8 col-md-8 col-sm-8">
                                <asp:FileUpload ID="FileUpload5"  Visible="false" runat="server" />
                            </div>
                        </div>


                    <div class="row">
                        <div class="col-md-12">
                            <asp:Button ID="cmdgrabar" runat="server" CssClass="btn-danger" Text="Grabar" />
                        </div>
                    </div>


            <hr />       
             

            <div class="row">
                 <div class="col-lg-12 col-md-12">
                      <asp:Label ID="lblerror" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
                 </div>
            </div>

        </div>

        </div>

        <div class="row">
            <div class="col-lg-12">
                <asp:GridView ID="grdDatos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%">
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
    </section>
</form>
</asp:Content>
