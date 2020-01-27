Public Class catChips
    Inherits System.Web.UI.Page
    Dim libreria As New libreria
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cargarOperadoras()
        cargarChips()
    End Sub

    Protected Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If libreria.ingresarChips(txtidentificador.Text, txtnumero.Text, ddlOperadora.SelectedValue, txtfecha.Text) Then
            lblerror.Text = "El Ingreso del chip"
            cargarChips()
        Else
            lblerror.Text = "Error al ingresar la marca contactarse al info@misoporteinformatico.com"
        End If
    End Sub
    Private Sub cargarOperadoras()
        Dim tbOperadoras As DataTable = libreria.cargarOperadoras

        ddlOperadora.DataSource = tbOperadoras
        ddlOperadora.DataTextField = "nombres"
        ddlOperadora.DataValueField = "idOperadora"
        ddlOperadora.DataBind()

    End Sub
    Private Sub cargarChips()
        grdChips.DataSource = libreria.consultarChips()
        grdChips.DataBind()
    End Sub

End Class