Public Class rptEquipos
    Inherits System.Web.UI.Page
    Dim libreria As New libreria
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim tbDatos As New DataTable
        tbDatos = libreria.rptEquipos(txtfechaingreso.Text)
        grdClientes.DataSource = tbDatos
        grdClientes.DataBind()

    End Sub
End Class