Public Class catMarcas
    Inherits System.Web.UI.Page
    Dim libreria As New libreria
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cargarDatos()
    End Sub

    Protected Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Dim id As Integer = hdid.value
        If hdestado.Value = "M" Then
            'modificar
            If libreria.modificarMarca(id, txtmarca.Text) Then
                lblerror.Text = "La Modificación de la marca fue Exitosa"
                cargarDatos()
            Else
                lblerror.Text = "Error al modificar la marca contactarse al info@misoporteinformatico.com"
            End If
        Else
            'grabar
            If libreria.grabarMarca(txtmarca.Text) Then
                lblerror.Text = "El Ingreso de la marca fue Exitosa"
                cargarDatos()
            Else
                lblerror.Text = "Error al ingresar la marca contactarse al info@misoporteinformatico.com"
            End If
        End If

    End Sub
    Private Sub cargarDatos()
        grdMarcas.DataSource = libreria.consultarMarcas()
        grdMarcas.DataBind()
    End Sub
    Private Sub grdMarcas_RowCommand(sender As Object, e As GridViewCommandEventArgs) Handles grdMarcas.RowCommand
        Dim fila As Integer = e.CommandArgument
        btnGrabar.Text = "Modificar"
        btnGrabar.CssClass = "btn-danger btn-block"
        hdestado.Value = "M"
        hdid.Value = grdMarcas.Rows(fila).Cells(1).Text
        txtmarca.Text = grdMarcas.Rows(fila).Cells(2).Text
    End Sub
End Class