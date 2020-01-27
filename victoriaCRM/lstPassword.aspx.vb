Public Class lstPassword
    Inherits System.Web.UI.Page
    Dim libreria As New libreria
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Aqui tengo que hacer la consulta del usuario y su email para enviar una clave randomica y actualizar la clave

    End Sub

    Protected Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        lblerror.Text = libreria.CambiarClave(txtUsuario.Text)
    End Sub
End Class