Imports System.IO
Imports System.IO.Directory

Public Class cargaDocumentos
    Inherits System.Web.UI.Page
    Dim libreria As New libreria
    Dim totalParametros As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack Then
            Session("ddlListado") = ddlListado.SelectedValue
        Else
            cargarCombo()
        End If
    End Sub

    Protected Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim tbClientes As DataTable = libreria.buscarCliente(txtcedula.Text)

        'Table.Columns[i].ColumnName
        If tbClientes.Rows.Count = 0 Then
            lblerror.Text = "No existe Cliente, Favor Ingresarlo"
        Else
            lblnombreCliente.Text = tbClientes.Rows(0)("nombres").ToString
            hfIDCliente.Value = tbClientes.Rows(0)("idCliente").ToString
            Dim tbdatos As DataTable = libreria.datosPlanesPortabilidad(hfIDCliente.Value)
            'aqui busco los datos de planes y portabilidad
            If tbdatos.Rows.Count = 0 Then
                lblerror.Text = "No hay planes asociados a ese cliente, Ingrese un producto."
            Else
                lblplan.Text = tbdatos.Rows(0)("nombrePlan").ToString
                lblportabilidad.Text = tbdatos.Rows(0)("portabilidad").ToString
                lblerror.Text = ""
            End If
        End If
    End Sub
    Private Sub cargarCombo()
        Dim tbListado As DataTable = libreria.consultarTituloParametro()
        totalParametros = tbListado.Rows.Count

        ddlListado.DataSource = tbListado
        ddlListado.DataTextField = "descripcion"
        ddlListado.DataValueField = "idparametros"
        ddlListado.DataBind()
    End Sub
    Private Sub cargarElementos()
        'este numero depende los registros de la tabla que dependen del valor seleccionado en el combo
        Dim tbElementos As DataTable = libreria.cargarElementos(ddlListado.SelectedValue)
        Dim parametros As Integer
        parametros = tbElementos.Rows.Count

        If parametros = 0 Then
            lblerror.Text = "no existen parametros asociados"
        Else
            Select Case parametros
                Case 1
                    Label1.Visible = True
                    Label1.Text = tbElementos.Rows(0)(0).ToString
                    Session("parametroUno") = tbElementos.Rows(0)(1).ToString
                    FileUpload1.Visible = True
                Case 2
                    Label1.Visible = True
                    Label1.Text = tbElementos.Rows(0)(0).ToString
                    Session("parametroUno") = tbElementos.Rows(0)(1).ToString
                    Session("parametrodos") = tbElementos.Rows(1)(1).ToString
                    FileUpload1.Visible = True

                    Label2.Visible = True
                    Label2.Text = tbElementos.Rows(1)(0).ToString
                    FileUpload2.Visible = True
                Case 3
                    Label1.Visible = True
                    Label1.Text = tbElementos.Rows(0)(0).ToString
                    FileUpload1.Visible = True

                    Label2.Visible = True
                    Label2.Text = tbElementos.Rows(1)(0).ToString
                    FileUpload2.Visible = True

                    Label3.Visible = True
                    Label3.Text = tbElementos.Rows(2)(0).ToString
                    FileUpload3.Visible = True

                    Session("parametroUno") = tbElementos.Rows(0)(1).ToString
                    Session("parametrodos") = tbElementos.Rows(1)(1).ToString
                    Session("parametroTres") = tbElementos.Rows(2)(1).ToString

                Case 4
                    Label1.Visible = True
                    Label1.Text = tbElementos.Rows(0)(0).ToString
                    FileUpload1.Visible = True

                    Label2.Visible = True
                    Label2.Text = tbElementos.Rows(1)(0).ToString
                    FileUpload2.Visible = True

                    Label3.Visible = True
                    Label3.Text = tbElementos.Rows(2)(0).ToString
                    FileUpload3.Visible = True

                    Label4.Visible = True
                    Label4.Text = tbElementos.Rows(3)(0).ToString
                    FileUpload4.Visible = True

                    Session("parametroUno") = tbElementos.Rows(0)(1).ToString
                    Session("parametrodos") = tbElementos.Rows(1)(1).ToString
                    Session("parametroTres") = tbElementos.Rows(2)(1).ToString
                    Session("parametroCuatro") = tbElementos.Rows(3)(1).ToString

                Case 5
                    Label1.Visible = True
                    Label1.Text = tbElementos.Rows(0)(0).ToString
                    FileUpload1.Visible = True

                    Label2.Visible = True
                    Label2.Text = tbElementos.Rows(1)(0).ToString
                    FileUpload2.Visible = True

                    Label3.Visible = True
                    Label3.Text = tbElementos.Rows(2)(0).ToString
                    FileUpload3.Visible = True

                    Label4.Visible = True
                    Label4.Text = tbElementos.Rows(3)(0).ToString
                    FileUpload4.Visible = True

                    Label5.Visible = True
                    Label5.Text = tbElementos.Rows(4)(0).ToString
                    FileUpload5.Visible = True

                    Session("parametroUno") = tbElementos.Rows(0)(1).ToString
                    Session("parametrodos") = tbElementos.Rows(1)(1).ToString
                    Session("parametroTres") = tbElementos.Rows(2)(1).ToString
                    Session("parametroCuatro") = tbElementos.Rows(3)(1).ToString
                    Session("parametroCinco") = tbElementos.Rows(4)(1).ToString

            End Select

        End If
        Session("parametros") = parametros
    End Sub
    Protected Sub ddlListado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlListado.SelectedIndexChanged
        cargarElementos()
    End Sub

    Protected Sub cmdgrabar_Click(sender As Object, e As EventArgs) Handles cmdgrabar.Click

        Dim strServerPath As String

        strServerPath = Server.MapPath(".") & "\documentosScaneados\" & txtcedula.Text & "\"
        'crear carpeta para la subida de archivos

        If Not System.IO.Directory.Exists(strServerPath) Then
            System.IO.Directory.CreateDirectory(strServerPath)
        End If

        If Session("parametros") <> 0 Then
            Select Case Session("parametros")
                Case 1
                    If FileUpload1.HasFile Then
                        FileUpload1.PostedFile.SaveAs(strServerPath & FileUpload1.FileName)
                        lblerror.Text = "Archivo subido con exito"
                        grabarDocumentosTabla(Session("parametroUno"), strServerPath)
                    End If
                Case 2
                    If FileUpload1.HasFile Then
                        FileUpload1.PostedFile.SaveAs(strServerPath & FileUpload2.FileName)
                        lblerror.Text = "Archivo subido con exito"
                        grabarDocumentosTabla(Session("parametroUno"), strServerPath)
                    End If

                    If FileUpload2.HasFile Then
                        FileUpload2.PostedFile.SaveAs(strServerPath & FileUpload2.FileName)
                        lblerror.Text = "Archivo subido con exito"
                        grabarDocumentosTabla(Session("parametroDos"), strServerPath)
                    End If
                Case 3
                    If FileUpload1.HasFile Then
                        FileUpload1.PostedFile.SaveAs(strServerPath & FileUpload2.FileName)
                        lblerror.Text = "Archivo subido con exito"
                        grabarDocumentosTabla(Session("parametroUno"), strServerPath)
                    End If

                    If FileUpload3.HasFile Then
                        FileUpload3.PostedFile.SaveAs(strServerPath & FileUpload3.FileName)
                        lblerror.Text = "Archivo subido con exito"
                        grabarDocumentosTabla(Session("parametroTres"), strServerPath)
                    End If

                    If FileUpload2.HasFile Then
                        FileUpload2.PostedFile.SaveAs(strServerPath & FileUpload1.FileName)
                        lblerror.Text = "Archivo subido con exito"
                        grabarDocumentosTabla(Session("parametroDos"), strServerPath)
                    End If
                Case 4
                    If FileUpload1.HasFile Then
                        FileUpload1.PostedFile.SaveAs(strServerPath & FileUpload1.FileName)
                        lblerror.Text = "Archivo subido con exito"
                        grabarDocumentosTabla(Session("parametroUno"), strServerPath)
                    End If

                    If FileUpload2.HasFile Then
                        FileUpload2.PostedFile.SaveAs(strServerPath & FileUpload2.FileName)
                        lblerror.Text = "Archivo subido con exito"
                        grabarDocumentosTabla(Session("parametroDos"), strServerPath)
                    End If

                    If FileUpload3.HasFile Then
                        FileUpload3.PostedFile.SaveAs(strServerPath & FileUpload3.FileName)
                        lblerror.Text = "Archivo subido con exito"
                        grabarDocumentosTabla(Session("parametroTres"), strServerPath)
                    End If

                    If FileUpload4.HasFile Then
                        FileUpload4.PostedFile.SaveAs(strServerPath & FileUpload4.FileName)
                        lblerror.Text = "Archivo subido con exito"
                        grabarDocumentosTabla(Session("parametroCuatro"), strServerPath)
                    End If
                Case 5
                    If FileUpload1.HasFile Then
                        FileUpload1.PostedFile.SaveAs(strServerPath & FileUpload1.FileName)
                        lblerror.Text = "Archivo subido con exito"
                        grabarDocumentosTabla(Session("parametroUno"), strServerPath)
                    End If

                    If FileUpload2.HasFile Then
                        FileUpload2.PostedFile.SaveAs(strServerPath & FileUpload2.FileName)
                        lblerror.Text = "Archivo subido con exito"
                        grabarDocumentosTabla(Session("parametroDos"), strServerPath)
                    End If

                    If FileUpload3.HasFile Then
                        FileUpload3.PostedFile.SaveAs(strServerPath & FileUpload3.FileName)
                        lblerror.Text = "Archivo subido con exito"
                        grabarDocumentosTabla(Session("parametroTres"), strServerPath)
                    End If

                    If FileUpload4.HasFile Then
                        FileUpload4.PostedFile.SaveAs(strServerPath & FileUpload4.FileName)
                        lblerror.Text = "Archivo subido con exito"
                        grabarDocumentosTabla(Session("parametroCuatro"), strServerPath)
                    End If

                    If FileUpload5.HasFile Then
                        FileUpload5.PostedFile.SaveAs(strServerPath & FileUpload5.FileName)
                        lblerror.Text = "Archivo subido con exito"
                        grabarDocumentosTabla(Session("parametroCinco"), strServerPath)
                    End If
            End Select
        Else
            lblerror.Text = "Error no hay parametros creados"
        End If

    End Sub
    Private Sub grabarDocumentosTabla(ByVal idDoc As Integer, ByVal strServerPath As String)
        If libreria.grabarDocumentos(txtcedula.Text, idDoc, strServerPath, "I") Then
            lblerror.Text = "Documentos Registrados"
        Else
            lblerror.Text = "Erro al registrar Documentos"
        End If
    End Sub
End Class