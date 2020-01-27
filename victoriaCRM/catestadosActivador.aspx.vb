Public Class catestadosActivador
    Inherits System.Web.UI.Page
    Dim libreria As New libreria
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack() Then
            cargarEstados()
        End If
    End Sub

    Protected Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If hdestado.Value = "M" Then
            'modificar
            If libreria.modificarEstado(hdid.Value, txtdescripcion.Text) Then
                lblerror.Text = "La Modificación del Estado OK"
                cargarEstados()
            Else
                lblerror.Text = "Error al modificar el estado contactarse al info@misoporteinformatico.com"
            End If
        Else
            'grabar
            If libreria.grabarEstado(txtdescripcion.Text) Then
                lblerror.Text = "El Ingreso del Estado fue Exitoso"
                cargarEstados()
            Else
                lblerror.Text = "Error al ingresar el estado contactarse al info@misoporteinformatico.com"
        End If
        End If
    End Sub
    Private Sub cargarEstados()
        grdEstados.DataSource = libreria.consultarEstados()
        grdEstados.DataBind()
    End Sub
    Private Sub grdEstados_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles grdEstados.RowCommand
        Dim fila As Integer = e.CommandArgument
        btnGrabar.Text = "Modificar"
        btnGrabar.CssClass = "btn-danger btn-block"
        hdestado.Value = "M"
        hdid.Value = grdEstados.Rows(fila).Cells(1).Text
        txtdescripcion.Text = grdEstados.Rows(fila).Cells(2).Text
    End Sub
End Class