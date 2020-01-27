Public Class transaccionesInternet
    Inherits System.Web.UI.Page
    Dim libreria As New libreria
    Dim fpago As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack Then
            Session("fpago") = ddlformapago.SelectedValue
        Else
            cargarFormaPago()
            cargarBancos()
            cargarVendedores()
        End If
    End Sub

    Protected Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click

    End Sub
    Private Sub cargarFormaPago()
        Dim tbformaPago As DataTable = libreria.consultarFormasPago()

        ddlformapago.DataSource = tbformaPago
        ddlformapago.DataTextField = "descripcion"
        ddlformapago.DataValueField = "idformapago"
        ddlformapago.DataBind()

    End Sub
    Private Sub cargarVendedores()

        ddlVendedores.DataSource = libreria.consultarUsuariosXTipo("V")
        ddlVendedores.DataTextField = "nombresCompletos"
        ddlVendedores.DataValueField = "idusuario"
        ddlVendedores.DataBind()
    End Sub
    Private Sub cargarBancos()

        Dim tbBancos As DataTable = libreria.consultarBancos()

        ddlbancos.DataSource = tbBancos
        ddlbancos.DataTextField = "descripcion"
        ddlbancos.DataValueField = "idBanco"
        ddlbancos.DataBind()

    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim tbClientes As DataTable = libreria.buscarCliente(txtcedula.Text)
        'Table.Columns[i].ColumnName
        If tbClientes.Rows.Count = 0 Then
            lblErrorCliente.Text = "No existe Cliente, Favor Ingresarlo"
        Else
            txtnombres.Text = tbClientes.Rows(0)("nombres").ToString
            hfIDCliente.Value = tbClientes.Rows(0)("idCliente").ToString
            lblemail.Text = tbClientes.Rows(0)("email").ToString
            lbltelefono1.Text = tbClientes.Rows(0)("telefono1").ToString
            lbltelefonoref.Text = tbClientes.Rows(0)("telefonoTrabajo").ToString
            lblErrorCliente.Text = ""
        End If
    End Sub
End Class