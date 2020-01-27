Public Class activador_fijo
    Inherits System.Web.UI.Page
    Dim libreria As New libreria
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack Then

        Else
            cargarCiudades()
            cargarEstados()
            cargarPlanFijo()
        End If
    End Sub
    Private Sub cargarCiudades()
        Dim tbCiudades As DataTable = libreria.consultarCiudades
        ddlciudad.DataSource = tbCiudades
        ddlciudad.DataTextField = "descripcion"
        ddlciudad.DataValueField = "idciudad"
        ddlciudad.DataBind()

        ddlLocalidad.DataSource = tbCiudades
        ddlLocalidad.DataTextField = "descripcion"
        ddlLocalidad.DataValueField = "idciudad"
        ddlLocalidad.DataBind()
    End Sub

    Protected Sub btngrabar_Click(sender As Object, e As EventArgs) Handles btngrabar.Click

    End Sub
    Private Sub cargarEstados()
        Dim tbEstados As DataTable = libreria.consultarEstados
        ddlEstadosActivador.DataSource = tbEstados
        ddlEstadosActivador.DataTextField = "descripcion"
        ddlEstadosActivador.DataValueField = "idEstado"
        ddlEstadosActivador.DataBind()
    End Sub
    Private Sub cargarPlanFijo()
        Dim tbPlanesfijos As DataTable = libreria.consultarPlanFijoCatalogo
        ddlPlanFijo.DataSource = tbPlanesfijos
        ddlPlanFijo.DataTextField = "descripcion"
        ddlPlanFijo.DataValueField = "idPlanfijo"
        ddlPlanFijo.DataBind()
    End Sub
    Protected Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim tbcliente As DataTable = libreria.buscarClienteModificar(txtCedula.Text)
        Dim tbTransacciones As DataTable = libreria.consultarTransaccionesIdCliente(tbcliente.Rows(0)("idcliente").ToString)
        Dim tbPagos As DataTable = libreria.consultarDatosPago(tbTransacciones.Rows(0)("iddatospago").ToString)
        Dim fecha As Date = Now()

        lblnombreCliente.Text = tbcliente.Rows(0)("nombres").ToString & " " & tbcliente.Rows(0)("nombres").ToString
        txtemail.Text = tbcliente.Rows(0)("email").ToString
        'lblDireccion.Text = tbcliente.Rows(0)("direccionDomicilio").ToString no hay el campo
        txtcelular.Text = tbcliente.Rows(0)("telefono1").ToString
        lbltelfArea.Text = tbcliente.Rows(0)("telefonoreferencia").ToString
        ddlciudad.SelectedValue = tbcliente.Rows(0)("idciudad").ToString
        'aqui hay que ir a buscar la forma de pago
        Select Case tbPagos.Rows(0)("descripcion").ToString
            Case "Efectivo"
                lblVentanilla.Text = "Efectivo"
            Case "T/C"
                lblNombreBanco.Text = tbPagos.Rows(0)("banco").ToString
                lblVentanilla.Text = "Tarjeta Credito"
                txtCuenta.Text = tbPagos.Rows(0)("numerotc").ToString
            Case "Ventanilla"
                lblNombreBanco.Text = tbPagos.Rows(0)("banco").ToString
                lblVentanilla.Text = "Ventanilla"
                txtCuenta.Text = tbPagos.Rows(0)("numerocuenta").ToString
            Case "Debito"
                lblNombreBanco.Text = tbPagos.Rows(0)("banco").ToString
                lblVentanilla.Text = "Debito"
                txtCuenta.Text = tbPagos.Rows(0)("numerocuenta").ToString

        End Select
        lblnombrePlan.Text = tbTransacciones.Rows(0)("nombrePlan").ToString
        lblvalorPlan.Text = tbTransacciones.Rows(0)("valorPlan").ToString
        lblvendedor.Text = tbTransacciones.Rows(0)("vendedor").ToString
        fecha.ToString("dd/MMM/yy")
        txtfechaingreso.Text = Now()
    End Sub
End Class