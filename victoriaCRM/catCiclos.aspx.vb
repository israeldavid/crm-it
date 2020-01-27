Public Class catCiclos
    Inherits System.Web.UI.Page
    Dim librerias As New libreria
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cargarCiclos()
    End Sub

    Protected Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If librerias.ingresarCiclo(txtnombreCiclo.Text, txtfechaAcreditacion.Text, txtfechaDebito.Text, txtfechaMaxPago.Text) Then
            lblerror.Text = "Ingresado el Ciclo correctamente"
            cargarCiclos()
        Else
            lblerror.Text = "Favor comunicarse con el email info@misoporteinformatico.com Para solucionar el Problema"
        End If


    End Sub
    Private Sub cargarCiclos()
        grdCiclos.DataSource = librerias.consultarCiclos()
        grdCiclos.DataBind()

    End Sub
End Class