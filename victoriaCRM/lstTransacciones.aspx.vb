Public Class lstTransacciones
    Inherits System.Web.UI.Page
    Dim libreria As New libreria
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


    End Sub

    Protected Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim tbTransacciones As New DataTable
        tbTransacciones = libreria.consultarTransacciones(txtfechaingreso.Text)
        grdClientes.DataSource = tbTransacciones
        grdClientes.DataBind()

    End Sub
End Class