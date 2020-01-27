Public Class catplanesscore
    Inherits System.Web.UI.Page
    Dim libreria As New libreria
    Public rubros As Integer = 10
    Public tbScore As New DataTable
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cargarPlanes()
        cargarScore()
    End Sub

    Protected Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        'lblerror.Text = libreria.grabarScorePolitica(ddlscore.SelectedValue, ddlplan.SelectedValue)
    End Sub
    Private Sub cargarPlanes()
        Dim tbplanes As DataTable = libreria.consultarTiposPlanes
        'them wordpress bakan
        ddlplan.DataSource = tbplanes
        ddlplan.DataTextField = "nombreplantarifa"
        ddlplan.DataValueField = "idplan"
        ddlplan.DataBind()

    End Sub
    Private Sub cargarScore()

        tbScore = libreria.cargarScore
        For Each fila As DataRow In tbScore.Rows

        Next
    End Sub

End Class