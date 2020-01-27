Public Class confwebmail
    Inherits System.Web.UI.Page
    Dim libreria As New libreria

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        lblerror.Text = libreria.confwebmail(txtemail.Text, txtclave.Text, txtpuerto.Text, txtdominio.Text)
    End Sub
End Class