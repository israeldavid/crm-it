Public Class contratos
    Inherits System.Web.UI.Page
    Dim libreria As New libreria

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim tbClientes As DataTable = libreria.buscarCliente(txtcedula.Text)
        'Table.Columns[i].ColumnName
        If tbClientes.Rows.Count = 0 Then
            lblerror.Text = "No existe Cliente, Favor Ingresarlo"
        Else
            'txtnombres.Text = tbClientes.Rows(0)("nombres").ToString
            'hfIDCliente.Value = tbClientes.Rows(0)("idCliente").ToString
            'lblErrorCliente.Text = ""
        End If
    End Sub

    Protected Sub cmdgrabar_Click(sender As Object, e As EventArgs) Handles cmdgrabar.Click

    End Sub
End Class