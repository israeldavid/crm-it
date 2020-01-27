Public Class login
    Inherits System.Web.UI.Page
    Public libreria As New libreria
    Public usuario As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim tbusuarios As New DataTable
        Dim opciones As String

        If txtusuario.Text = "" Or txtpassword.Text = "" Then
            lblError.Text = "El usuario o la clave no puede estar en blanco"
        Else
            tbusuarios = libreria.validarConexion(txtusuario.Text, txtpassword.Text)
            If tbusuarios Is Nothing Then
                lblError.Text = "Error no se ecnontró el usuario Comuníquese con el administrador"
            Else
                If tbusuarios.Rows.Count > 0 Then
                    Session("nick") = txtusuario.Text
                    Session("usuario") = tbusuarios.Rows(0)("nombresCompletos").ToString
                    Session("tipo") = tbusuarios.Rows(0)("tipo").ToString
                    Response.Redirect("menu.aspx")

                End If
            End If

        End If
    End Sub
End Class