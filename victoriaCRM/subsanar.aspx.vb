Public Class subsanar
    Inherits System.Web.UI.Page
    Dim libreria As New libreria
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack Then
        Else
            Session("webTable") = ""
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
        'busqueda de los documentos ingresados
        Dim tbDocumento As DataTable = libreria.ConsultarDocumentosIngresados(txtcedula.Text)
        'crear la data table en memoria

        Dim miDataTable As New DataTable
        miDataTable.Columns.Add("Parametro")
        miDataTable.Columns.Add("documento")
        miDataTable.Columns.Add("Estado")

        'cargar los parametros
        Dim tbparametros As DataTable = libreria.consultarTituloParametro
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim documento As String
        Dim estadoTabla, verDocumento, verDescripcion As String

        For Each fila As DataRow In tbparametros.Rows
            Dim Renglon As DataRow = miDataTable.NewRow()
            Renglon("Parametro") = tbparametros.Rows(i)("descripcion").ToString
            'aqui tengo que ver como le pongo si esta ingresado o no
            documento = libreria.ConsultarDocScaneadosXID(tbparametros.Rows(i)("idparametros").ToString, txtcedula.Text)
            If documento <> "" Then
                Renglon("documento") = documento
                Renglon("Estado") = "Ingresado"
            Else
                Renglon("documento") = ""
                Renglon("Estado") = "No Ingresado"
            End If
            miDataTable.Rows.Add(Renglon)
            i = i + 1
        Next
        'Crear la tabla para mostrar en pagina
        Session("webTable") = "<table class='table'><thead class='thead-dark'><tr><th scope='col'>#</th><th scope='col'>Parametro</th><th scope='col'>Documento</th><th scope='col'>Estado</th></tr></thead><tbody>"
        For Each filita As DataRow In miDataTable.Rows
            If miDataTable.Rows(j)("estado") = "Ingresado" Then
                estadoTabla = "success"
            Else
                estadoTabla = "danger"
            End If

            If miDataTable.Rows(j)("documento") <> "" Then
                verDocumento = miDataTable.Rows(j)("documento")
                verDescripcion = "Descargar Doc"
            Else
                verDocumento = "#"
                verDescripcion = "No hay Doc"
            End If
            Session("webTable") = Session("webTable") & "<tr><th scope ='row'>" & j & "</th><td>" & miDataTable.Rows(j)("parametro") & "</td><td><a href='" & verDocumento & "'>" & verDescripcion & "</a></td><td class='" & estadoTabla & "'>" & miDataTable.Rows(j)("estado") & "</td></tr>"
            j = j + 1
        Next
        Session("webTable") = Session("webTable") & "</tbody></table>"


    End Sub

    Protected Sub btnSubsanar_Click(sender As Object, e As EventArgs) Handles btnSubsanar.Click

    End Sub
End Class