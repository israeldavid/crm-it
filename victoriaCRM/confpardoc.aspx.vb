Public Class confpardoc
    Inherits System.Web.UI.Page
    Dim libreria As New libreria
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack() Then
            cargarDatos()
        End If
        cargarRegistros()
    End Sub

    Protected Sub cmdgrabar_Click(sender As Object, e As EventArgs) Handles cmdgrabar.Click
        lblerror.Text = libreria.ingresarParametrodoc(ddlTitulos.SelectedValue, txtitems.Text)
        cargarRegistros()
    End Sub
    Private Sub cargarDatos()
        Dim tbTitulos As DataTable = libreria.consultarTituloParametro()
        ddlTitulos.DataSource = tbTitulos
        ddlTitulos.DataTextField = "descripcion"
        ddlTitulos.DataValueField = "idparametros"
        ddlTitulos.DataBind()
    End Sub
    Private Sub cargarRegistros()
        grdDatos.DataSource = libreria.consultarParametros()
        grdDatos.DataBind()
    End Sub
End Class