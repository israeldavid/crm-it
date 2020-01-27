Public Class catUsuarios
    Inherits System.Web.UI.Page
    Dim libreria As New libreria
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack Then

        Else
            cargarVendedores()
            cargarPerfilesUsuarios()
        End If

    End Sub

    Protected Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If libreria.ingresarVendedores(txtNick.Text, txtclave.Text, txtnombres.Text, ddlTipoUsuario.SelectedValue, txtemail.Text) Then
            lblerror.Text = "Vendedor ingresado correctamente"
            cargarVendedores()
        Else
            lblerror.Text = "No se ingreso el vendedor, por favor comunicarse al info@misoporteinformatico.com"
        End If
    End Sub
    Private Sub cargarVendedores()
        Dim tbusuarios As DataTable = libreria.consultarUsuarios()

        grdUsuarios.DataSource = tbusuarios
        grdUsuarios.DataBind()


    End Sub

    Protected Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim tbusuarios As DataTable = libreria.buscarUsuario(txtNick.Text)
        txtnombres.Text = tbusuarios.Rows(0)("nombrescompletos").ToString
        txtemail.Text = tbusuarios.Rows(0)("email").ToString
        txtclave.Text = tbusuarios.Rows(0)("clave").ToString
        ddlTipoUsuario.SelectedValue = tbusuarios.Rows(0)("tipo").ToString
        btnActualizar.Enabled = True
        btnGrabar.Enabled = False
        txtclave.Enabled = False

    End Sub

    Protected Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        lblerror.Text = libreria.actualizarUsuario(txtNick.Text, txtnombres.Text, txtemail.Text, ddlTipoUsuario.SelectedValue)
        cargarVendedores()
    End Sub
    Private Sub cargarPerfilesUsuarios()
        Dim tbperfiles As DataTable = libreria.perfilesdeUsuarios()
        ddlTipoUsuario.DataSource = tbperfiles
        ddlTipoUsuario.DataTextField = "descripcion"
        ddlTipoUsuario.DataValueField = "nivel"
        ddlTipoUsuario.DataBind()
    End Sub

    Protected Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        lblerror.Text = libreria.eliminarUsuario(txtNick.Text)
        cargarVendedores()
    End Sub
End Class