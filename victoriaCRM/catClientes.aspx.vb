Imports System.IO
Imports System.Data
Imports System.Collections.Generic
Imports ClosedXML.Excel
Imports System.Globalization
Imports System.Data.OleDb

Public Class catClientes
    Inherits System.Web.UI.Page
    Dim libreria As New libreria
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-ES")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "yyyy/MM/dd"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","
        'cargarDatos()
        btnGrabar.Visible = False
        cargarCiudades()
        cargarEstadosClientes()
        cargarDatos()
    End Sub
    Protected Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If hdestado.Value = "N" Then
            'esta mierda es por el Blas
            If txtfechanac.Text = "" Then
                lblerror.Text = libreria.grabarCliente(ddlTipoCliente.SelectedValue, txtnombres.Text, txtapellidos.Text, txtempresa.Text, txtcedula.Text, Now(), Now(), txttelefono.Text, txtemail.Text, txtdirtrabajo.Text, txtteltrabajo.Text, txtreferencia.Text, txttelefonoRef.Text, ddlCiudad.SelectedValue, ddlestado.SelectedValue)
                cargarDatos()
                limpiarCampos()
            Else
                lblerror.Text = libreria.grabarCliente(ddlTipoCliente.SelectedValue, txtnombres.Text, txtapellidos.Text, txtempresa.Text, txtcedula.Text, txtfechanac.Text, txtfechaexp.Text, txttelefono.Text, txtemail.Text, txtdirtrabajo.Text, txtteltrabajo.Text, txtreferencia.Text, txttelefonoRef.Text, ddlCiudad.SelectedValue, ddlestado.SelectedValue)
                limpiarCampos()
                cargarDatos()
            End If
        Else
            'aqui va el codigo de modificacion
        End If
    End Sub
    Private Sub cargarDatos()
        grdDatos.DataSource = libreria.traerClientes()
        grdDatos.DataBind()
    End Sub
    Private Sub limpiarCampos()
        ddlTipoCliente.SelectedValue = 1
        txtnombres.Text = ""
        txtapellidos.Text = ""
        txtempresa.Text = ""
        txtcedula.Text = ""
        txttelefono.Text = ""
        txtemail.Text = ""
        txtdirtrabajo.Text = ""
        txtteltrabajo.Text = ""
        txtreferencia.Text = ""
        txttelefonoRef.Text = ""
        ddlCiudad.SelectedValue = 1
        ddlestado.SelectedValue = 1
    End Sub
    Private Sub cargarCiudades()
        Dim tbCiudades As DataTable = libreria.traerCiudades()

        ddlCiudad.DataSource = tbCiudades
        ddlCiudad.DataTextField = "descripcion"
        ddlCiudad.DataValueField = "idCiudad"
        ddlCiudad.DataBind()
    End Sub
    Public Sub cargarEstadosClientes()
        Dim tbestados As DataTable = libreria.traerEstadosClientes()

        ddlestado.DataSource = tbestados
        ddlestado.DataTextField = "descripcion"
        ddlestado.DataValueField = "idEstado"
        ddlestado.DataBind()
    End Sub

    Protected Sub btnSubir_Click(sender As Object, e As EventArgs) Handles btnSubir.Click
        Dim filePath As String = Server.MapPath("~/data/") + Path.GetFileName(fileSubir.PostedFile.FileName)
        fileSubir.SaveAs(filePath)

        Dim conexion As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=;Data Source=" & filePath & ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1'"
        'Dim conexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & filePath & ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1'"
        Dim dt As New DataTable
        Dim cnn = New OleDbConnection(conexion)
        cnn.Open()
        Dim Sql As String = "SELECT * FROM [Hoja1$]"
        Dim Command As New OleDbCommand(Sql, cnn)
        Dim da As New OleDbDataAdapter(Command)
        da.Fill(dt)

        grdDatos.DataSource = dt
        grdDatos.DataBind()

        'btnGrabar.Visible = True

        Dim culturaEcuatoriana = CultureInfo.GetCultureInfo("en-US")
        Dim SqlInserta As String = ""
        Try
            For i = 0 To grdDatos.Rows.Count - 1
                Dim idTipoCliente As String = grdDatos.Rows(i).Cells(0).Text
                Dim nombres As String = grdDatos.Rows(i).Cells(1).Text
                Dim apellidos As String = grdDatos.Rows(i).Cells(2).Text
                Dim nombreEmpresa As String = HttpUtility.HtmlDecode(grdDatos.Rows(i).Cells(3).Text)
                Dim ruc As String = grdDatos.Rows(i).Cells(4).Text
                'Dim fechanacimiento As Date = Year(CDate(grdDatos.Rows(i).Cells(5).Text)) & "-" & Month(CDate(grdDatos.Rows(i).Cells(5).Text)) & "-" & Day(CDate(grdDatos.Rows(i).Cells(5).Text))
                'Dim fechaExpedicion As Date = Year(CDate(grdDatos.Rows(i).Cells(6).Text)) & "-" & Month(CDate(grdDatos.Rows(i).Cells(6).Text)) & "-" & Day(CDate(grdDatos.Rows(i).Cells(6).Text))
                Dim telefono1 As String = grdDatos.Rows(i).Cells(5).Text
                Dim score As Decimal = CDec(grdDatos.Rows(i).Cells(6).Text) 'este es segun el system globalizatio para cambiar el , por .
                Dim calificacionBuro As String = grdDatos.Rows(i).Cells(7).Text
                Dim email As String = grdDatos.Rows(i).Cells(8).Text
                Dim direccionTrabajo As String = grdDatos.Rows(i).Cells(9).Text
                Dim telefonoTrabajo As String = grdDatos.Rows(i).Cells(10).Text
                Dim referenciaPersonal As String = grdDatos.Rows(i).Cells(11).Text
                Dim telefonoReferencia As String = grdDatos.Rows(i).Cells(12).Text
                'Dim fechaIngreso As Date = CDate(Year(Now()) & "-" & Month(Now()) & "-" & Day(Now()))
                'SqlInserta = "INSERT INTO clientes (idTipoCliente,nombres,apellidos,nombreEmpresa,ruc,telefono1,calificacionBuro,email,direccionTrabajo,telefonoTrabajo,referenciaPersonal,telefonoReferencia,fechaIngreso) VALUES ('" & idTipoCliente & "','" & nombres & "','" & apellidos & "','" & nombreEmpresa & "','" & ruc & "','" & telefono1 & "','" & calificacionBuro & "','" & email & "','" & direccionTrabajo & "','" & telefonoTrabajo & "','" & referenciaPersonal & "','" & telefonoReferencia & "','" & fechaIngreso & "')"
                'SqlInserta = "INSERT INTO clientes (idTipoCliente,nombres,apellidos,nombreEmpresa,ruc,telefono1,calificacionBuro,email,direccionTrabajo,telefonoTrabajo,referenciaPersonal,telefonoReferencia,fechaIngreso) VALUES ('" & idTipoCliente & "','" & nombres & "','" & apellidos & "','" & nombreEmpresa & "','" & ruc & "','" & telefono1 & "','" & calificacionBuro & "','" & email & "','" & direccionTrabajo & "','" & telefonoTrabajo & "','" & referenciaPersonal & "','" & telefonoReferencia & "'," & "curdate())"
                'Ahora Jaime quiere que le añada estos dos campos score y calificación buro. Arriba era el primer cambio
                SqlInserta = "INSERT INTO clientes (idTipoCliente,nombres,apellidos,nombreEmpresa,ruc,telefono1,score,calificacionBuro,email,direccionTrabajo,telefonoTrabajo,referenciaPersonal,telefonoReferencia,fechaIngreso) VALUES ('" & idTipoCliente & "','" & nombres & "','" & apellidos & "','" & nombreEmpresa & "','" & ruc & "','" & telefono1 & "'," & score & ",'" & calificacionBuro & "','" & email & "','" & direccionTrabajo & "','" & telefonoTrabajo & "','" & referenciaPersonal & "','" & telefonoReferencia & "'," & "curdate())"
                lblerror.Text = libreria.Exportar_MySQL(SqlInserta)
            Next

            'MsgBox("Registros exportados exitosamente", MsgBoxStyle.Information, ":: It Support Team::")
            lblerror.Text = "Total registros importados: " & grdDatos.Rows.Count
            '& SqlInserta

            grdDatos.DataSource = dt
            grdDatos.DataBind()
        Catch ex As Exception
            lblerror.Text = "Espere un momento, y revise el reporte de clientes cargados por fecha"
        End Try

    End Sub
    Private Sub grdDatos_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles grdDatos.RowCommand
        Dim fila As Integer = e.CommandArgument
        btnAgregar.Text = "Modificar"
        btnAgregar.CssClass = "btn-danger btn-block"
        hdestado.Value = "M"
        txtcedula.Text = grdDatos.Rows(fila).Cells(1).Text
        txtempresa.Text = grdDatos.Rows(fila).Cells(2).Text
        txtnombres.Text = grdDatos.Rows(fila).Cells(3).Text  'nombres
        txtapellidos.Text = grdDatos.Rows(fila).Cells(4).Text
        txtfechanac.Text = grdDatos.Rows(fila).Cells(5).Text
        txtfechaexp.Text = grdDatos.Rows(fila).Cells(6).Text
        txttelefono.Text = grdDatos.Rows(fila).Cells(7).Text
        txtteltrabajo.Text = grdDatos.Rows(fila).Cells(8).Text
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim tbClientes As DataTable = libreria.buscarClienteModificar(txtcedula.Text)
        If tbClientes.Rows.Count > 0 Then
            btnAgregar.Text = "Modificar"
            btnAgregar.CssClass = "btn-danger btn-block"
            hdestado.Value = "M"
            txtempresa.Text = tbClientes.Rows(0)("nombreEmpresa").ToString
            txtnombres.Text = tbClientes.Rows(0)("nombres").ToString
            txtapellidos.Text = tbClientes.Rows(0)("apellidos").ToString
            txtfechanac.Text = tbClientes.Rows(0)("fechanacimiento").ToString
            txtfechaexp.Text = tbClientes.Rows(0)("fechaexpedicion").ToString
            txttelefono.Text = tbClientes.Rows(0)("telefono1").ToString
            txtteltrabajo.Text = tbClientes.Rows(0)("telefonoTrabajo").ToString
            ddlestado.SelectedValue = tbClientes.Rows(0)("idEstado").ToString
            txtemail.Text = tbClientes.Rows(0)("email").ToString
            txtdirtrabajo.Text = tbClientes.Rows(0)("direccionTrabajo").ToString
            txtteltrabajo.Text = tbClientes.Rows(0)("telefonoTrabajo").ToString
            ddlCiudad.SelectedValue = tbClientes.Rows(0)("idCiudad").ToString
            txtreferencia.Text = tbClientes.Rows(0)("referenciaPersonal").ToString
            txttelefonoRef.Text = tbClientes.Rows(0)("telefonoReferencia").ToString
        Else
            lblerror.Text = "Cliente no existe proceder a crearlo"
            txtnombres.Focus()
        End If

    End Sub
End Class