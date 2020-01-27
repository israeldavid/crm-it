Public Class transacciones
    Inherits System.Web.UI.Page
    Dim libreria As New libreria
    Dim fpago As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack Then
            Session("fpago") = ddlformapago.SelectedValue
        Else
            cargarPlanes()
            cargarVendedores()
            cargarOperadoras()
            cargarProductos()
            cargarFormaPago()
            cargarBancos()
        End If
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim tbClientes As DataTable = libreria.buscarCliente(txtcedula.Text)
        'Table.Columns[i].ColumnName
        If tbClientes.Rows.Count = 0 Then
            lblErrorCliente.Text = "No existe Cliente, Favor Ingresarlo"
        Else
            txtnombres.Text = tbClientes.Rows(0)("nombres").ToString
            hfIDCliente.Value = tbClientes.Rows(0)("idCliente").ToString
            lblErrorCliente.Text = ""
        End If

    End Sub
    Private Sub cargarPlanes()
        Dim tbplanes As DataTable = libreria.consultarTiposPlanes

        ddlplan.DataSource = tbplanes
        ddlplan.DataTextField = "nombreplantarifa"
        ddlplan.DataValueField = "idplan"
        ddlplan.DataBind()

    End Sub
    Private Sub cargarVendedores()
        Dim tbvendedores As DataTable = libreria.consultarUsuariosXTipo("V")

        ddlVendedor.DataSource = tbvendedores
        ddlVendedor.DataTextField = "nombresCompletos"
        ddlVendedor.DataValueField = "idusuario"
        ddlVendedor.DataBind()
    End Sub
    Private Sub cargarOperadoras()
        Dim tboperadoras As DataTable = libreria.cargarOperadoras()
        ddlOperadora.DataSource = tboperadoras
        ddlOperadora.DataTextField = "nombres"
        ddlOperadora.DataValueField = "idOperadora"
        ddlOperadora.DataBind()
    End Sub

    Private Sub cargarProductos()
        Dim tbProductos As DataTable = libreria.consultarProductos()

        ddlEquipos.DataSource = tbProductos
        ddlEquipos.DataTextField = "descripcion"
        ddlEquipos.DataValueField = "id"
        ddlEquipos.DataBind()

    End Sub

    Private Sub cargarBancos()

        Dim tbBancos As DataTable = libreria.consultarBancos()

        ddlbancos.DataSource = tbBancos
        ddlbancos.DataTextField = "descripcion"
        ddlbancos.DataValueField = "idBanco"
        ddlbancos.DataBind()

    End Sub

    Private Sub cargarFormaPago()
        Dim tbformaPago As DataTable = libreria.consultarFormasPago()

        ddlformapago.DataSource = tbformaPago
        ddlformapago.DataTextField = "descripcion"
        ddlformapago.DataValueField = "idformapago"
        ddlformapago.DataBind()

    End Sub

    Protected Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        'primero se debe grabar los datos pago para que se grabe la forma de datos pago
        Dim numero As Integer
        Dim fecha As Date

        'aqui hay que ver como se llenan los campos de numero de tarjeta o de papeleta segun el combo
        If txtfecha.Text = "" Then
            fecha = Now()
        Else
            fecha = txtfecha.Text
        End If

        numero = libreria.ingresarDatosPago(hfIDCliente.Value, ddlformapago.SelectedValue, ddlbancos.SelectedValue, RadioButtonList1.SelectedValue, txtnumero.Text, txtNumeroTC.Text, fecha, ddlbancos.SelectedValue, txtnumero.Text, txtfechaDeposito.Text)
        If numero <> 0 Then

            lblerror.Text = libreria.ingresarTransaccion(hfIDCliente.Value, ddlplan.SelectedValue, ddlVendedor.SelectedValue, numero, ddlOperadora.SelectedValue, ddlEquipos.SelectedValue, txtnumeroLineaNueva.Text, ddlestados.SelectedValue, ddlProcedencia.SelectedValue, txtPortabilidad.Text)
        End If

        cargarTransacciones()

    End Sub
    Public Sub cargarTransacciones()
        Dim tbtransacciones As DataTable = libreria.consultarTransacciones
        grdTransacciones.DataSource = tbtransacciones
        grdTransacciones.DataBind()

    End Sub
    Protected Sub ddlformapago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlformapago.SelectedIndexChanged

        ddlformapago.SelectedValue = Session("fpago")

        If ddlformapago.SelectedValue = "4" Then 'significa q es debito

            deshabilitarPapeleta()
            deshabilitarTarjetaCredito()
            habilitarDebito()
        ElseIf ddlformapago.SelectedValue = "2" Then 'significa que paga con tarjeta de credito

            deshabilitarDebito()
            deshabilitarPapeleta()
            habilitarTarjetaCredito()
        Else

            deshabilitarDebito()
            deshabilitarTarjetaCredito()
            habilitarPapeleta()
        End If
    End Sub
    Private Sub habilitarPapeleta()
        lblbanco.Visible = True
        ddlbancos.Visible = True
        lblnumeropapeleta.Visible = True
        txtnumero.Visible = True
        lblfechadeposito.Visible = True
        txtfechaDeposito.Visible = True
    End Sub
    Private Sub habilitarDebito()
        lblbanco.Visible = True
        ddlbancos.Visible = True
        lblcuenta.Visible = True
        txtcuenta.Visible = True
        lbltipo.Visible = True
        RadioButtonList1.Visible = True
    End Sub
    Private Sub habilitarTarjetaCredito()
        lbltarjeta.Visible = True
        ddltarjeta.Visible = True
        lblnumerotarjeta.Visible = True
        txtNumeroTC.Visible = True
        lblFecha.Visible = True
        txtfecha.Visible = True
        'lblccv.Visible = True
        'txtccv.Visible = True
        cargarTarjetas()

    End Sub
    Private Sub deshabilitarPapeleta()
        lblbanco.Visible = False
        ddlbancos.Visible = False
        lblnumeropapeleta.Visible = False
        txtnumero.Visible = False
        lblfechadeposito.Visible = False
        txtfechaDeposito.Visible = False
    End Sub
    Private Sub deshabilitarTarjetaCredito()
        lblbanco.Visible = False
        ddlbancos.Visible = False
        lbltarjeta.Visible = false
        ddltarjeta.Visible = False
        lblnumerotarjeta.Visible = false
        txtNumeroTC.Visible = false
        lblFecha.Visible = false
        txtfecha.Visible = False
        'lblccv.Visible = false
        'txtccv.Visible = False
    End Sub
    Private Sub deshabilitarDebito()
        lblbanco.Visible = False
        ddlbancos.Visible = False
        lblcuenta.Visible = False
        txtcuenta.Visible = False
        lbltipo.Visible = False
        RadioButtonList1.Visible = False
    End Sub

    Private Sub ddlformapago_DataBound(sender As Object, e As EventArgs) Handles ddlformapago.DataBound
        If IsPostBack Then
            lblerror.Text = "databound"
        End If
    End Sub

    Private Sub ddlformapago_Load(sender As Object, e As EventArgs) Handles ddlformapago.Load
        If IsPostBack Then
            Session("fpago") = ddlformapago.SelectedValue
        End If
    End Sub
    Private Sub cargarTarjetas()
        Dim tbtarjetas As DataTable = libreria.cargarTarjetas()

        ddltarjeta.DataSource = tbtarjetas
        ddltarjeta.DataTextField = "descripcion"
        ddltarjeta.DataValueField = "idBanco"
        ddltarjeta.DataBind()
    End Sub
End Class