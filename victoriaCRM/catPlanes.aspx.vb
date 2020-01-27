Public Class catPlanes
    Inherits System.Web.UI.Page
    Dim libreria As New libreria

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            cargarPlanes()
            cargarProductos()
            cargarCiclos()
        End If

    End Sub

    Protected Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If libreria.ingresarTipoPlanes(txtnombrePlan.Text, ddlproducto.SelectedValue, txttarifa.Text, txtbeneficios.Text, ddlciclofacturacion.SelectedValue) Then
            lblerror.Text = "Tipo de plan Ingresado correctamente"
            cargarPlanes()
        Else
            lblerror.Text = "Ocurrió un error favor comunicarse al info@misoporteinformatico.com"
        End If
    End Sub
    Private Sub cargarPlanes()
        Dim tbplanes As DataTable = libreria.consultarTiposPlanes

        grdPlanes.DataSource = tbplanes
        grdPlanes.DataBind()

    End Sub
    Private Sub cargarProductos()
        Dim tbProductos As DataTable = libreria.consultarProductos()

        ddlproducto.DataSource = tbProductos
        ddlproducto.DataTextField = "descripcion"
        ddlproducto.DataValueField = "id"
        ddlproducto.DataBind()

    End Sub
    Private Sub cargarCiclos()
        Dim tbCiclos As DataTable = libreria.consultarCiclos

        ddlciclofacturacion.DataSource = tbCiclos
        ddlciclofacturacion.DataTextField = "descripcion"
        ddlciclofacturacion.DataValueField = "idCiclo"
        ddlciclofacturacion.DataBind()

    End Sub

End Class