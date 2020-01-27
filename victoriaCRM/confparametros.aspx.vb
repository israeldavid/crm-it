Public Class confparametros
    Inherits System.Web.UI.Page
    Dim libreria As New libreria
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cargarparametros()
    End Sub

    Protected Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        lblerror.Text = libreria.grabarTituloParametro(txttitulo.Text)
        cargarparametros()
    End Sub
    Private Sub cargarparametros()
        grdDatos.DataSource = libreria.consultarTituloParametro()
        grdDatos.DataBind()
    End Sub
End Class