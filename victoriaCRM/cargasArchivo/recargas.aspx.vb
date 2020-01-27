Imports System.Data.OleDb
Imports System.Globalization
Imports ClosedXML.Excel



Public Class recargas
    Inherits System.Web.UI.Page
    Public clslibreria As New libreria
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

    Protected Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        ':::Declaramos nuestra variable Sql que almacenara nuestra consuta
        Dim culturaEcuatoriana = CultureInfo.GetCultureInfo("en-US")
        Dim Sql As String = ""
        ':::Usamos un ciclo For Each para recorrer nuestro DataGridView llamado DGTabla
        For i = 1 To grdDatosaCargar.Rows.Count - 2
            Dim codProducto As String = grdDatosaCargar.Rows(i).Cells(0).Text
            Dim pcs As String = grdDatosaCargar.Rows(i).Cells(1).Text
            Dim codigoDistribuidor As Integer = grdDatosaCargar.Rows(i).Cells(2).Text
            Dim das As String = HttpUtility.HtmlDecode(grdDatosaCargar.Rows(i).Cells(3).Text)
            Dim valorCargado As Integer = grdDatosaCargar.Rows(i).Cells(4).Text
            Dim anio As Integer = grdDatosaCargar.Rows(i).Cells(5).Text
            Dim mesactivacion As Integer = grdDatosaCargar.Rows(i).Cells(6).Text
            Dim fechaActivacion As Date = CDate(grdDatosaCargar.Rows(i).Cells(7).Text)
            Sql = "Insert into recargas (codigoProducto, pcs, codigoDistribuidor, das, valorCargado, anio,mes, fechaActivacion) values ('" & codProducto & "', '" & pcs & "', '" & codigoDistribuidor & "', '" & das & "'," & valorCargado & ", '" & anio & "', " & mesactivacion & ", STR_TO_DATE('" & fechaActivacion & "', '%m/%d/%Y'))"
            lblmensaje.Text = clslibreria.Exportar_MySQL(Sql)
        Next

        MsgBox("Registros exportados exitosamente", MsgBoxStyle.Information, ":: David Ortega M::")
        lblmensaje.Text = "Total registros importados: " & grdDatosaCargar.Rows.Count

    End Sub
End Class