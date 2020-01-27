Public Class score_actualizacion
    Inherits System.Web.UI.Page
    Dim libreria As New libreria
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cargarScore()
    End Sub

    Protected Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        Dim valorScore As Integer
        Dim valorsolicitado As Integer

        valorsolicitado = lbltarifa.Text

        'validacion de negocio
        ' pide un plan de 40 y mete dos contratos uno de 20 y otro de 25 si se suma 40+20+25 85 es menor q 90 entonces si cumple si aplica se graba el core y se actualiza la transacccion y se envia un email al puto vendedor
        ' y si no aplica email de no aplico pendiente venta y se actualiza la transaccion
        valorScore = libreria.consultarvalorscore(txtScore.Text)
        valorScore = valorScore + valorsolicitado
        If valorScore < txtScore.Text Then
            'graba y aplica y correo
            If libreria.actualizarScore(txtcedula.Text, ddlcalificacion.SelectedValue, txtScore.Text) Then
                'enviar correo
                lblerror.Text = "Score Ingresado"
            Else
                'enviar correo
                lblerror.Text = "Score no se pudo Ingresar por error técnico"
            End If
        Else
            lblerror.Text = "Score no cumple con la politica de la empresa"
            'enviar correo
        End If
    End Sub
    Private Sub cargarScore()
        Dim tbScore As DataTable
        tbScore = libreria.cargarScore
        ddlcalificacion.DataSource = tbScore
        ddlcalificacion.DataTextField = "calificacion"
        ddlcalificacion.DataValueField = "calificacion"
        ddlcalificacion.DataBind()
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim tbClientes As DataTable = libreria.buscarClienteEnTransaccion(txtcedula.Text)
        'Table.Columns[i].ColumnName
        If tbClientes.Rows.Count = 0 Then
            lblErrorCliente.Text = "No existe Cliente, Favor Ingresarlo"
        Else
            txtnombres.Text = tbClientes.Rows(0)("nombres").ToString
            hfIDCliente.Value = tbClientes.Rows(0)("idCliente").ToString
            lbltarifa.Text = tbClientes.Rows(0)("tarifa").ToString
            lblnombreplan.Text = tbClientes.Rows(0)("nombrePlan").ToString
            lblErrorCliente.Text = ""
        End If
    End Sub
    Protected Sub btnGrabarHistorico_Click(sender As Object, e As EventArgs) Handles btnGrabarHistorico.Click
        lblerroContrato.Text = libreria.grabarScoreHistorico(hfIDCliente.Value, txtvalorplan.Text, txtfechaingreso.Text, Now(), "")
    End Sub
    Private Sub cargarMiniTabla()
        grdscore.DataSource = libreria.consultarScoreHistorico()
        grdscore.DataBind()
    End Sub
End Class