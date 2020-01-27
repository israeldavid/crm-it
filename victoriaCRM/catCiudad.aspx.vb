Public Class catCiudad
    Inherits System.Web.UI.Page
    Dim libreria As New libreria
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cargarCiudades()
    End Sub

    Protected Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If libreria.grabarCiudad(txtciudad.Text) Then
            cargarCiudades()
        End If
    End Sub
    Private Sub cargarCiudades()
        grdMarcas.DataSource = libreria.consultarCiudades()
        grdMarcas.DataBind()
    End Sub
End Class