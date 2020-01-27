Public Class catBancos
    Inherits System.Web.UI.Page
    Dim libreria As New libreria
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cargarBancos()
    End Sub

    Protected Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        lblerror.Text = libreria.grabarEntidadesFinancieras(txtentidad.Text, ddlestado.SelectedValue)
        cargarBancos()
    End Sub
    Private Sub cargarBancos()
        grdEquipos.DataSource = libreria.cargarBancos
        grdEquipos.DataBind()
    End Sub

    Protected Sub btnTarjeta_Click(sender As Object, e As EventArgs) Handles btnTarjeta.Click
        lblerror.Text = libreria.ingresarTarjeta(txtentidad.Text, ddlestado.SelectedValue)
        cargarTarjetas()
    End Sub
    Private Sub cargarTarjetas()
        grdEquipos.DataSource = libreria.cargarTarjetas
        grdEquipos.DataBind()
    End Sub

    Protected Sub btnconstc_Click(sender As Object, e As EventArgs) Handles btnconstc.Click
        cargarTarjetas()
    End Sub

    Protected Sub btnconsbanco_Click(sender As Object, e As EventArgs) Handles btnconsbanco.Click
        cargarBancos()
    End Sub

    Private Sub grdEquipos_RowDeleting(sender As Object, e As GridViewDeleteEventArgs) Handles grdEquipos.RowDeleting
        Dim fila As GridViewRow = grdEquipos.Rows(e.RowIndex)

        lblerror.Text = libreria.eliminarBanco(fila.Cells(0).Text)
        cargarBancos()
    End Sub
End Class