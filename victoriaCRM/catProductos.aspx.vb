Public Class catProductos
    Inherits System.Web.UI.Page
    Dim libreria As New libreria
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cargarDatos()
    End Sub

    Protected Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If libreria.grabarProducto(txtnombreProducto.Text) Then
            lblerror.Text = "El Ingreso del producto fue Exitosa"
            cargarDatos()
        Else
            lblerror.Text = "Error al ingresar el producto contactarse al info@misoporteinformatico.com"
        End If
    End Sub
    Private Sub cargarDatos()
        grdProducto.DataSource = libreria.consultarProductos()
        grdProducto.DataBind()
    End Sub
End Class