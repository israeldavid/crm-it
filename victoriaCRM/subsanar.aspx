<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/home.Master" CodeBehind="subsanar.aspx.vb" Inherits="victoriaCRM.subsanar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <section class="content-header">
      <h1>  Subsanación de Documentos Scaneados
        <small>Legalizar</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Home</a></li>
        <li><a href="#">Legalizar</a></li>
        <li class="active">Subsanación Archivos Scaneados</li>
      </ol>
    </section>

    <section class="content">
        <div class="box box-default">
            <div class="box-header with-border">
                <h3 class="box-title">Subsanación de Documentos</h3>

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
                <div class="col-lg-12 col-md-12 col-sm-12">
                    <%=Session("webTable") %>
                </div>
            </div>
            <hr />
            <div class="row">
                <div class="col-lg-4 col-md-4 col-sm-4">
                    <asp:Label ID="lblobervacion" runat="server" Text="Observación" Font-Bold="True"></asp:Label></div>
                <div class="col-lg-8 col-md-8 col-sm-8">
                    <asp:TextBox ID="txtobservacion" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox></div>
            </div>
           
          <hr />

            <div class="row">
                <div class="col-lg-6 col-md-6 col-sm-6">
                    <asp:Button ID="btnSubsanar" runat="server" Text="Enviar a CNT" CssClass="btn btn-block btn-success" />
                </div>
                <div class="col-lg-6 col-md-6 col-sm-6">
                    <asp:Button ID="btnReingresa" runat="server" Text="Enivar correccion" CssClass="btn btn-block btn-danger" />
                </div>
            </div>

        <div class="row">
            <div class="col-md-12">
                <asp:Label ID="lblerror" runat="server" Font-Bold="True" ForeColor="Blue"></asp:Label>
            </div>
        </div>

        </div>

        </div>

        </div>
    </section>
</form>
</asp:Content>
