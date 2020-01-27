Public Class cambiarclave
    Inherits System.Web.UI.Page
    Public libreria As New libreria
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Dim usuario As String = Session("nick")
        Dim clave As String

        If usuario = "" Then
            lblerror.Text = "Error el usuario no tiene permisos para cambiar su clave"
        Else
            'vamos a ver si tiene la misma contraseña anterior
            'consultamos la clave actual para comparar
            Dim tbusuario As DataTable = libreria.consultarClave(usuario)
            clave = tbusuario.Rows(0)(0).ToString
            If clave = txtpassword.Text Then
                'ahora si podemos cambiar la clave
                If txtnuevaclave.Text = txtclave.Text Then
                    'ahora si cambiar
                    If libreria.actualizarClave(usuario, txtnuevaclave.Text) Then
                        lblerror.Text = "Se acrualizo correctamente la clave"
                        Response.Redirect("../login.aspx")
                    Else
                        lblerror.Text = "Error en la base de datos NO SE ACTUALIZO LA CLAVE"
                    End If
                End If
                Else
                lblerror.Text = "No es igual la calve anterior"
            End If
        End If
    End Sub
End Class