Public Class lstClientes
    Inherits System.Web.UI.Page
    Dim libreria As New libreria

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtfechaingreso.Text = Now()
    End Sub

    Protected Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click

        If txtfechaingreso.Text <> "" Then
            Dim tbClientes As DataTable = libreria.lstClientes(txtfechaingreso.Text)
            grdClientes.DataSource = tbClientes
            grdClientes.DataBind()
        Else
            Dim tbClientes As DataTable = libreria.lstClientesxApellido(txtapellidos.Text)
            grdClientes.DataSource = tbClientes
            grdClientes.DataBind()
        End If


    End Sub
End Class