<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="lstPassword.aspx.vb" Inherits="victoriaCRM.lstPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Recuperación de Clave</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport" />
    <!-- Bootstrap 3.3.7 -->
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <!-- Font Awesome -->
    <link href="Content/font-awesome.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="jumbotron">
                <h1>Reinicio de Clave</h1>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <p>Ingrese por favor su usuario</p>
                </div>
            </div>
            <div class="row">
                <div class="col-md-4">
                    <asp:Label ID="lblusuario" runat="server" Text="Usuario:" Font-Bold="True"></asp:Label>
                </div>
                <div class="col-md-8">
                    <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="El campo Usuario no puede estar vacio" ControlToValidate="txtUsuario" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <asp:Button ID="btnReiniciar" runat="server" CssClass="btn-danger btn-block" Text="Reiniciar Clave" />
                </div>
            </div>
            <hr />
            <div class="row">
                <div class="col-md-12">
                    <asp:Label ID="lblerror" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <a href="login.aspx">Regresar al Login</a>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
