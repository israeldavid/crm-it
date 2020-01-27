Public Class catPlanFijo
    Inherits System.Web.UI.Page
    Dim libreria As New libreria
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cargarDatos()
    End Sub

    Protected Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If libreria.grabarPlanFijo(txtnombreProducto.Text) Then
            lblerror.Text = "El Ingreso de la descripcion fue Exitosa"
            cargarDatos()
        Else
            lblerror.Text = "Error al ingresar, contactarse al info@misoporteinformatico.com"
        End If
    End Sub
    Private Sub cargarDatos()
        grdProducto.DataSource = libreria.consultarPlanFijoCatalogo()
        grdProducto.DataBind()
    End Sub
End Class