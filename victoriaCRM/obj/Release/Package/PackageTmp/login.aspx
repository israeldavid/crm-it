<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="login.aspx.vb" Inherits="victoriaCRM.login" %>

<!DOCTYPE html>
<html>
<head>
  <meta charset="utf-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <title>Victoria CRM | Log in</title>
  <!-- Tell the browser to be responsive to screen width -->
  <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
  <!-- Bootstrap 3.3.7 -->
  <link href="Content/bootstrap.min.css" rel="stylesheet" />
  <!-- Font Awesome -->
  <link href="Content/font-awesome.min.css" rel="stylesheet" />

  <!-- Ionicons -->
  <link href="admin-lte/css/Ionicons/css/ionicons.min.css" rel="stylesheet" />

  <!-- Theme style -->
  <link href="admin-lte/css/AdminLTE.min.css" rel="stylesheet" />

  <!-- Google Font -->
  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700,300italic,400italic,600italic">
</head>
<body class="hold-transition login-page">
<div class="login-box">
  <div class="login-logo">
    <a href="../../index2.html"><b>Victoria</b>CRM</a>
  </div>
<!-- /.login-logo -->
<div class="login-box-body">
    <form id="form1" runat="server">
    <p class="login-box-msg">Ingrese los datos para iniciar Sesion</p>
      <div class="form-group has-feedback">
        <asp:TextBox ID="txtusuario" runat="server" class="form-control" placeholder="Email"></asp:TextBox>
        <span class="glyphicon glyphicon-envelope form-control-feedback"></span>
      </div>
      <div class="form-group has-feedback">
        <asp:TextBox ID="txtpassword" class="form-control" placeholder="Password" runat="server" TextMode="Password"></asp:TextBox>
        <span class="glyphicon glyphicon-lock form-control-feedback"></span>
      </div>
      <div class="row">
        <!-- /.col -->
        <div class="col-xs-4">
            <asp:Button ID="btnLogin" class="btn btn-primary btn-block btn-flat" runat="server" Text="Ingresar" />
        </div>
        <!-- /.col -->
      </div>
    </form>
    <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
    <a href="lstPassword.aspx">Olvidé mi clave</a><br>

  </div>
  <!-- /.login-box-body -->
</div>
<!-- /.login-box -->

<!-- jQuery 3 -->
<script src="Scripts/jquery-3.1.1.min.js"></script>
<!-- Bootstrap 3.3.7 -->
<script src="Scripts/bootstrap.min.js"></script>
</body>
</html>