Imports System.IO

Public Class catEquipos
    Inherits System.Web.UI.Page
    Dim libreria As New libreria

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack Then
            lblerror.Text = ""
        Else
            cargarMarcas()
            cargarEquipos()
        End If


    End Sub
    Public Overrides Sub VerifyRenderingInServerForm(ByVal control As Control)
        'este metodo es necesario para q se exporte el excel
    End Sub
    Protected Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        If libreria.ingresarEquipos(txtdescripcion.Text, ddlmarca.SelectedValue, txtimei.Text, ddlEstado.SelectedValue) Then
            lblerror.Text = "Se ingreso correctamente el Equipo"
            cargarEquipos()
        Else
            lblerror.Text = "No se pudo ingresar el equipo comunicquese al info@misoporteinformatico.com"
        End If
    End Sub
    Private Sub cargarMarcas()
        Dim tbmarcas As New DataTable

        tbmarcas = libreria.consultarMarcas()

        ddlmarca.DataSource = tbmarcas
        ddlmarca.DataTextField = "descripcion"
        ddlmarca.DataValueField = "idmarca"
        ddlmarca.DataBind()
    End Sub
    Private Sub cargarEquipos()
        Dim tbequipos As New DataTable

        tbequipos = libreria.consultarEquipos()

        grdEquipos.DataSource = tbequipos
        grdEquipos.DataBind()

    End Sub

    Protected Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        Response.Clear()
        Response.AddHeader("Content-Disposition", "attachment;filename=data.xls")
        Response.ContentType = "application/vnd.ms-excel"
        Dim sw As StringWriter = New StringWriter()
        Dim htw As HtmlTextWriter = New HtmlTextWriter(sw)
        grdEquipos.RenderControl(htw)
        Response.Write(sw.ToString())
        Response.End()


    End Sub
End Class