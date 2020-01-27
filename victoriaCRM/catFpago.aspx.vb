Public Class catFpago
    Inherits System.Web.UI.Page
    Dim libreria As New libreria
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cargarfpago()
    End Sub

    Protected Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        lblerror.Text = libreria.ingresarfpago(txtdescripcion.Text, ddlestado.SelectedValue)
        cargarfpago()
    End Sub
    Private Sub cargarfpago()
        grdEquipos.DataSource = libreria.cargarfpagos()
        grdEquipos.DataBind()
    End Sub

End Class