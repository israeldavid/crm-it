Imports ClosedXML.Excel

Public Class cargaEquipos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnSubir_Click(sender As Object, e As EventArgs) Handles btnSubir.Click
        If (fileSubir.PostedFile IsNot Nothing) AndAlso (fileSubir.PostedFile.ContentLength > 0) Then
            Dim fn As String = System.IO.Path.GetFileName(fileSubir.PostedFile.FileName)
            Dim SaveLocation As String = Server.MapPath("data") & "\" & fn
            'Dim file As String = "C:\Users\David\source\repos\victoriaCRM\victoriaCRM\cargasArchivo\data\carga.xlsx"

            Try
                fileSubir.PostedFile.SaveAs(SaveLocation)
                lblmensaje.Text = "Archivo Subido vamos a Procesarlo"
                subirArchivoExcel(SaveLocation)
                btnCargar.Visible = True
            Catch ex As Exception
                lblmensaje.Text = "Archivo no se subió por: " & ex.ToString
            End Try
        End If
    End Sub
    Private Sub subirArchivoExcel(ByVal fileName As String)
        Using workBook As New XLWorkbook(fileName)
            'Read the first Sheet from Excel file.
            Dim workSheet As IXLWorksheet = workBook.Worksheet(1)

            'Create a new DataTable.
            Dim dt As New DataTable()

            'Loop through the Worksheet rows.
            Dim firstRow As Boolean = True
            For Each row As IXLRow In workSheet.Rows()
                'Use the first row to add columns to DataTable.
                If firstRow Then
                    For Each cell As IXLCell In row.Cells()
                        dt.Columns.Add(cell.Value.ToString())
                    Next
                    firstRow = False
                Else
                    'Add rows to DataTable.
                    dt.Rows.Add()
                    Dim i As Integer = 0
                    For Each cell As IXLCell In row.Cells()
                        dt.Rows(dt.Rows.Count - 1)(i) = cell.Value.ToString()
                        i += 1
                    Next
                End If

                grdDatosaCargar.DataSource = dt
                grdDatosaCargar.DataBind()

            Next
        End Using

    End Sub
End Class