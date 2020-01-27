Public Class activador_movil
    Inherits System.Web.UI.Page
    Dim libreria As New libreria
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack Then
        Else
            cargarCiudades()
        End If
    End Sub
    Private Sub cargarCiudades()
        Dim tbCiudades As DataTable = libreria.consultarCiudades
        ddlciudad.DataSource = tbCiudades
        ddlciudad.DataTextField = "descripcion"
        ddlciudad.DataValueField = "idciudad"
        ddlciudad.DataBind()
    End Sub

    Protected Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim tbcliente As DataTable = libreria.buscarClienteModificar(txtcedula.Text)
        Dim tbTransacciones As DataTable = libreria.consultarTransaccionesIdCliente(tbcliente.Rows(0)("idcliente").ToString)
        Dim tbPagos As DataTable = libreria.consultarDatosPago(tbTransacciones.Rows(0)("iddatospago").ToString)
        Dim fecha As Date = Now()

        txtNombrecliente.Text = tbcliente.Rows(0)("nombres").ToString & " " & tbcliente.Rows(0)("nombres").ToString
        txtemail.Text = tbcliente.Rows(0)("email").ToString
        txtdireccion.Text = tbcliente.Rows(0)("direccionDomicilio").ToString
        txtCelular.Text = tbcliente.Rows(0)("telefono1").ToString
        txttelfpersonal.Text = tbcliente.Rows(0)("telefonoreferencia").ToString
        ddlciudad.SelectedValue = tbcliente.Rows(0)("idciudad").ToString
        'aqui hay que ir a buscar la forma de pago
        Select Case tbPagos.Rows(0)("descripcion").ToString
            Case "Efectivo"
                lbltipoCta.Text = "Efectivo"
            Case "T/C"
                lblNombreBanco.Text = tbPagos.Rows(0)("banco").ToString
                lbltipoCta.Text = "Tarjeta Credito"
                txtCuenta.Text = tbPagos.Rows(0)("numerotc").ToString
                lblfechaexpiracion.Text = tbPagos.Rows(0)("fechaExpiracion").ToString
            Case "Ventanilla"
                lblNombreBanco.Text = tbPagos.Rows(0)("banco").ToString
                If tbPagos.Rows(0)("tipocuenta").ToString = "A" Then
                    lbltipoCta.Text = "Ahorros"
                Else
                    lbltipoCta.Text = "Corriente"
                End If
                txtCuenta.Text = tbPagos.Rows(0)("numerocuenta").ToString
            Case "Debito"
                lblNombreBanco.Text = tbPagos.Rows(0)("banco").ToString
                If tbPagos.Rows(0)("tipocuenta").ToString = "A" Then
                    lbltipoCta.Text = "Ahorros"
                Else
                    lbltipoCta.Text = "Corriente"
                End If
                txtCuenta.Text = tbPagos.Rows(0)("numerocuenta").ToString

        End Select
        lblnombrePlan.Text = tbTransacciones.Rows(0)("nombrePlan").ToString
        lblcodigoNIP.Text = ""
        lblvendedor.Text = tbTransacciones.Rows(0)("vendedor").ToString
        fecha.ToString("dd/MMM/yy")
        txtfechaingreso.Text = Now()
    End Sub
End Class