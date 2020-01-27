Imports System.Web.Mail
Imports MySql.Data.MySqlClient
Public Class libreria
    Public usuario As String

    Dim Conexion As New MySql.Data.MySqlClient.MySqlConnection
    'Dim CadenaConexion As String = "Data Source=localhost;Database=victoriacrm;User Id=root;Password=; Allow Zero Datetime=True"
    Dim CadenaConexion As String = "Data Source=localhost;Database=victoriacrm;User Id=root;Password=Conexint$2019;Allow Zero Datetime=True"
    Public Sub Vconexion()
        Conexion = New MySqlConnection(CadenaConexion)
        Try
            Conexion.Open()
        Catch ex As Exception
            ex.ToString()
        End Try

    End Sub

    Public Function validarConexion(usuario As String, clave As String) As DataTable
        Dim tbusuario As New DataTable
        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter

        Vconexion()

        sql.Connection = Conexion
        sql.CommandText = "select nombresCompletos,tipo from usuarios where usuario='" & usuario & "' and clave='" & clave & "'"
        sql.CommandType = CommandType.Text

        da.SelectCommand = sql
        da.Fill(tbusuario)

        If tbusuario.Rows.Count > 0 Then
            Return tbusuario
        Else
            Return Nothing
        End If
        Conexion.Close()

    End Function
    Public Function Exportar_MySQL(ByVal Sql As String) As String
        ':::Declaramos nuestro objeto de tipo MySQLCommand para ejecutar la consulta
        Vconexion()
        Dim cmd As New MySqlCommand(Sql, Conexion)
        Try
            cmd.ExecuteNonQuery()
            Conexion.Close()
            Return "Ok"
        Catch ex As Exception
            Return ex.ToString()
        End Try
    End Function

    Public Function cargarClientes_MySQL(ByVal Sql As String) As String
        ':::Declaramos nuestro objeto de tipo MySQLCommand para ejecutar la consulta
        Vconexion()
        Dim cmd As New MySqlCommand(Sql, Conexion)
        Try
            cmd.ExecuteNonQuery()
            Conexion.Close()
            Return "Ok"
        Catch ex As Exception
            Return ex.ToString()
        End Try
    End Function

    Public Function grabarCliente(ByVal idtipoCliente As Char, ByVal nombre As String, ByVal apellidos As String, ByVal nombreEmpresa As String, ByVal ruc As String, ByVal fechaNac As Date, ByVal fechaExp As Date, ByVal telefono1 As String, ByVal email As String, ByVal direccionTrabajo As String, ByVal telefonoTrabajo As String, ByVal referenciaPersonal As String, ByVal telefonoReferencia As String, ByVal estadoc As Integer, ByVal idciudad As Integer) As String

        Dim fecha_actual As Date = Now()

        Vconexion()
        Dim cmd = New MySqlCommand("ingresarCliente", Conexion)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_idTipoCliente", idtipoCliente)
        cmd.Parameters.AddWithValue("@p_nombres", nombre)
        cmd.Parameters.AddWithValue("@p_apellidos", apellidos)
        cmd.Parameters.AddWithValue("@p_nombreEmpresa", nombreEmpresa)
        cmd.Parameters.AddWithValue("@p_ruc", ruc)
        cmd.Parameters.AddWithValue("@p_fechaNacimiento", fechaNac)
        cmd.Parameters.AddWithValue("@p_fechaExpedicion", fechaExp)
        cmd.Parameters.AddWithValue("@p_telefono1", telefono1)
        cmd.Parameters.AddWithValue("@p_email", email)
        cmd.Parameters.AddWithValue("@p_direccionTrabajo", direccionTrabajo)
        cmd.Parameters.AddWithValue("@p_telefonoTrabajo", telefonoTrabajo)
        cmd.Parameters.AddWithValue("@p_referenciaPersonal", referenciaPersonal)
        cmd.Parameters.AddWithValue("@p_telefonoReferencia", telefonoReferencia)
        cmd.Parameters.AddWithValue("@p_ciudad", idciudad)
        cmd.Parameters.AddWithValue("@p_estadoc", estadoc)
        cmd.Parameters.AddWithValue("@p_fechaIngreso", fecha_actual)

        Try
            cmd.ExecuteNonQuery()
            Conexion.Close()

            Return "Cliente ingresado con Exito"
        Catch ex As Exception
            Return "Error: " & ex.ToString()
        End Try

    End Function

    Public Function traerClientes() As DataTable
        Vconexion()

        Dim tbClientes As New DataTable
        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter

        sql.CommandText = "SELECT nombres,apellidos,nombreEmpresa,ruc,telefono1,fechanacimiento,email,fechaExpedicion,telefono1,telefonotrabajo,direccionTrabajo,referenciaPersonal  FROM clientes ORDER BY apellidos limit 100"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbClientes)

        Conexion.Close()
        Try
            Return tbClientes
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try


    End Function
    Public Function grabarMarca(ByVal descripcion As String) As Boolean
        Vconexion()

        Dim cmd = New MySqlCommand("ingresarMarca", Conexion)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_descripcion", descripcion)

        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return False
        End Try
        Conexion.Close()
    End Function
    Public Function modificarMarca(ByVal id As Integer, ByVal descripcion As String) As Boolean
        Vconexion()

        Dim cmd = New MySqlCommand("modificarMarca", Conexion)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", id)
        cmd.Parameters.AddWithValue("@p_descripcion", descripcion)

        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return False
        End Try
        Conexion.Close()
    End Function
    Public Function grabarEstado(ByVal descripcion As String) As Boolean
        Vconexion()

        Dim cmd = New MySqlCommand("ingresarEstado", Conexion)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_descripcion", descripcion)

        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return False
        End Try
        Conexion.Close()
    End Function
    Public Function modificarEstado(ByVal id As Integer, ByVal descripcion As String) As Boolean
        Vconexion()

        Dim cmd = New MySqlCommand("modificarEstado", Conexion)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_id", id)
        cmd.Parameters.AddWithValue("@p_descripcion", descripcion)

        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return False
        End Try
        Conexion.Close()
    End Function
    Public Function grabarCiudad(ByVal descripcion As String) As Boolean
        Vconexion()

        Dim cmd = New MySqlCommand("ingresarCiudad", Conexion)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_descripcion", descripcion)

        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return False
        End Try
        Conexion.Close()
    End Function
    Public Function consultarMarcas() As DataTable
        Vconexion()

        Dim tbMarcas As New DataTable
        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter


        sql.CommandText = "SELECT idmarca,descripcion FROM marcas ORDER BY descripcion"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbMarcas)

        Conexion.Close()
        Try
            Return tbMarcas
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function consultarEstados() As DataTable
        Vconexion()

        Dim tbEstados As New DataTable
        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter


        sql.CommandText = "SELECT idEstado,descripcion FROM estadosActivador ORDER BY descripcion"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbEstados)

        Conexion.Close()
        Try
            Return tbEstados
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function consultarCiudades() As DataTable
        Vconexion()

        Dim tbMarcas As New DataTable
        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter


        sql.CommandText = "SELECT idCiudad,descripcion FROM ciudad ORDER BY descripcion"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbMarcas)

        Conexion.Close()
        Try
            Return tbMarcas
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function grabarProducto(ByVal descripcion As String) As Boolean
        Vconexion()

        Dim cmd = New MySqlCommand("ingresarProducto", Conexion)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_descripcion", descripcion)

        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return False
        End Try
        Conexion.Close()
    End Function
    Public Function consultarProductos() As DataTable
        Vconexion()

        Dim tbProductos As New DataTable
        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter


        sql.CommandText = "SELECT descripcion,id FROM productos ORDER BY descripcion"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbProductos)

        Conexion.Close()
        Try
            Return tbProductos
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function cargarOperadoras() As DataTable
        Dim tbOperadoras As New DataTable
        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter

        Vconexion()

        Try
            sql.CommandText = "SELECT idOperadora,nombres FROM operadoras ORDER BY nombres"
            sql.CommandType = CommandType.Text

            sql.Connection = Conexion
            da.SelectCommand = sql
            da.Fill(tbOperadoras)
            Return tbOperadoras

        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try
        Conexion.Close()

    End Function
    Public Function ingresarChips(ByVal identificador As String, ByVal numero As String, ByVal idoperadora As Integer, ByVal fecha As Date) As Boolean
        Vconexion()
        Dim cmd = New MySqlCommand("ingresarChips", Conexion)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_identificador", identificador)
        cmd.Parameters.AddWithValue("@p_numero", numero)
        cmd.Parameters.AddWithValue("@p_idoperadora", idoperadora)
        cmd.Parameters.AddWithValue("@p_fecha", fecha)

        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return False
        End Try
        Conexion.Close()
    End Function

    Public Function consultarChips() As DataTable
        Vconexion()

        Dim tbChips As New DataTable
        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter

        sql.CommandText = "SELECT identificador,numero, b.nombres FROM chips a, operadoras b where a.idoperadora = b.idOperadora"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbChips)

        Conexion.Close()
        Try
            Return tbChips
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function ingresarEquipos(ByVal descripcion As String, ByVal marca As Integer, ByVal imei As String, ByVal estado As Char) As Boolean
        Vconexion()

        Dim cmd = New MySqlCommand("ingresarEquipos", Conexion)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_descripcion", descripcion)
        cmd.Parameters.AddWithValue("@p_idmarca", marca)
        cmd.Parameters.AddWithValue("@p_imei", imei)
        cmd.Parameters.AddWithValue("@estado", estado)

        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return False
        End Try

        Conexion.Close()

    End Function

    Public Function consultarEquipos() As DataTable
        Vconexion()

        Dim tbEquipos As New DataTable
        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter

        sql.CommandText = "SELECT idequipo, a.descripcion as Equipo, b.descripcion as Marca, imei,estado from equipos a, marcas b where a.idmarca=b.idmarca"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbEquipos)

        Conexion.Close()
        Try
            Return tbEquipos
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Function ingresarVendedores(ByVal usuario As String, ByVal clave As String, ByVal nombrescompletos As String, ByVal estado As Char, ByVal email As String) As Boolean
        Vconexion()

        Dim cmd = New MySqlCommand("ingresarUsuarios", Conexion)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_usuario", usuario)
        cmd.Parameters.AddWithValue("@p_clave", clave)
        cmd.Parameters.AddWithValue("@p_nombrescompletos", nombrescompletos)
        cmd.Parameters.AddWithValue("@p_tipo", estado)
        cmd.Parameters.AddWithValue("@p_email", email)

        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return False
        End Try

        Conexion.Close()

    End Function
    Public Function consultarUsuariosXTipo(ByVal tipo As Char) As DataTable
        Vconexion()

        Dim tbUsuarios As New DataTable
        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter

        sql.CommandText = "SELECT idusuario,usuario,nombresCompletos from usuarios where tipo='" & tipo & "'"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbUsuarios)

        Conexion.Close()
        Try
            Return tbUsuarios
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function consultarUsuarios() As DataTable
        Vconexion()

        Dim tbUsuarios As New DataTable
        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter

        sql.CommandText = "SELECT usuario,nombresCompletos,email,tipo from usuarios"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbUsuarios)

        Conexion.Close()
        Try
            Return tbUsuarios
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function ingresarTipoPlanes(ByVal nombrePlan As String, ByVal p_producto As Integer, ByVal p_tarifa As String, ByVal p_beneficios As String, ByVal p_ciclo As Integer) As Boolean
        Vconexion()

        Dim cmd = New MySqlCommand("ingresarTiposPlanes", Conexion)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_nombrePlan", nombrePlan)
        cmd.Parameters.AddWithValue("@p_idproducto", p_producto)
        cmd.Parameters.AddWithValue("@p_tarifa", p_tarifa)
        cmd.Parameters.AddWithValue("@p_beneficios", p_beneficios)
        cmd.Parameters.AddWithValue("@p_ciclo", p_ciclo)


        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return False
        End Try

        Conexion.Close()

    End Function
    Public Function consultarTiposPlanes() As DataTable
        Vconexion()

        Dim tbTiposPlanes As New DataTable
        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter

        sql.CommandText = "SELECT idplan,nombrePlan,tarifa,concat(nombrePlan , '-' , tarifa) as nombreplantarifa,beneficios,b.descripcion from tiposplanes a,productos b where a.idProducto=b.id"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbTiposPlanes)

        Conexion.Close()
        Try
            Return tbTiposPlanes
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try
    End Function

    Public Function buscarCliente(ByVal cedula As String) As DataTable
        Vconexion()

        'devuelve una tabla porque de pronto por alguna regla de negocio de va a denegar un plan u otro
        Dim tbCliente As New DataTable
        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter

        sql.CommandText = "SELECT concat(apellidos,' ',nombres) as nombres,idCliente,email,telefono1,telefonoTrabajo from clientes where ruc='" & cedula & "'"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbCliente)

        Conexion.Close()

        Try
            Return tbCliente
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function buscarClienteModificar(ByVal cedula As String) As DataTable
        Vconexion()

        'devuelve una tabla porque de pronto por alguna regla de negocio de va a denegar un plan u otro
        Dim tbCliente As New DataTable
        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter

        sql.CommandText = "SELECT * from clientes where ruc='" & cedula & "'"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbCliente)

        Conexion.Close()

        Try
            Return tbCliente
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function consultarBancos() As DataTable
        Vconexion()

        Dim tbBancos As New DataTable
        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter

        sql.CommandText = "SELECT idBanco,descripcion from bancos"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbBancos)

        Conexion.Close()
        Try
            Return tbBancos
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function consultarFormasPago() As DataTable
        Vconexion()

        Dim tbFormasPAgo As New DataTable
        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter

        sql.CommandText = "SELECT idformapago,descripcion from formaspago order by idformapago"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbFormasPAgo)

        Conexion.Close()
        Try
            Return tbFormasPAgo
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function grabarVenta(ByVal idVendedor As Integer, ByVal idplan As Integer, ByVal idoperadora As Integer, ByVal idequipo As Integer, ByVal lineanueva As String, ByVal estado As Char, ByVal proceso As Char, ByVal portabilidad As String, ByVal idcliente As Integer, ByVal idFormaPago As Integer, ByVal idBanco As Integer, ByVal idTipocta As Char, ByVal numcuenta As String, ByVal numcta As String, ByVal numerotc As String, ByVal fechaExp As Date, ByVal idbancotc As Integer, ByVal numpapleta As String, ByVal observacion As String) As Boolean
        Vconexion()
        'ingresar la forma de pago
        Dim cmd = New MySqlCommand("ingresarDatosPago", Conexion)

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_idCliente", idcliente)
        cmd.Parameters.AddWithValue("@p_idformaPago", idFormaPago)
        cmd.Parameters.AddWithValue("@p_idBanco", idBanco)
        cmd.Parameters.AddWithValue("@p_idTipoCuenta", idTipocta)
        cmd.Parameters.AddWithValue("@p_numeroCuenta", numcuenta)
        cmd.Parameters.AddWithValue("@p_numeroTC", numerotc)
        cmd.Parameters.AddWithValue("@p_fechaExpiracion", fechaExp)
        cmd.Parameters.AddWithValue("@p_numeroPapeleta", numpapleta)
        cmd.Parameters.AddWithValue("@p_observacion", observacion)

        'consultar el id de la forma de pago
        Dim iddatospago As Integer = 0

        'ingresar la venta 
        Dim cmdFP = New MySqlCommand("ingresarVenta", Conexion)


        cmdFP.CommandType = CommandType.StoredProcedure
        cmdFP.Parameters.AddWithValue("@p_idCliente", idcliente)
        cmdFP.Parameters.AddWithValue("@p_idPlan", idplan)
        cmdFP.Parameters.AddWithValue("@p_idVendedor", idVendedor)
        cmdFP.Parameters.AddWithValue("@p_iddatospago", iddatospago)
        cmdFP.Parameters.AddWithValue("@p_idoperadora", idoperadora)
        cmdFP.Parameters.AddWithValue("@p_idequipo", idequipo)
        cmdFP.Parameters.AddWithValue("@p_lineanueva", lineanueva)
        cmdFP.Parameters.AddWithValue("@p_estado", estado)
        cmdFP.Parameters.AddWithValue("@p_procesoOperadora", proceso)
        cmdFP.Parameters.AddWithValue("@p_portabilidad", portabilidad)

        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return False
        End Try
        Conexion.Close()
    End Function
    Public Function consultarNumeroDatosPago() As Integer
        Vconexion()

        Try
            Return 3
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.ToString)
            Return 0
        End Try
        Conexion.Close()
    End Function
    Public Function ingresarCiclo(ByVal nombreciclo As String, ByVal fechaAcreditacion As Date, ByVal fechaDebito As Date, ByVal fechaMaximo As Date) As Boolean
        Vconexion()

        Dim cmdFP = New MySqlCommand("ingresarCiclos", Conexion)


        cmdFP.CommandType = CommandType.StoredProcedure
        cmdFP.Parameters.AddWithValue("@p_descripcion", nombreciclo)
        cmdFP.Parameters.AddWithValue("@p_fechaAcreditacion", fechaAcreditacion)
        cmdFP.Parameters.AddWithValue("@p_fechaDebito", fechaDebito)
        cmdFP.Parameters.AddWithValue("@p_fechaMaximo", fechaMaximo)

        Try
            cmdFP.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.ToString)
            Return False
        End Try
        Conexion.Close()
    End Function
    Public Function consultarCiclos() As DataTable
        Vconexion()

        Dim tbCiclos As New DataTable
        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter

        sql.CommandText = "SELECT idCiclo,descripcion,fechaAcreditacion,fechaDebito,fechaMaximo from ciclos"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbCiclos)

        Conexion.Close()
        Try
            Return tbCiclos
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try

        Conexion.Close()

    End Function
    Public Function consultarClave(ByVal usuario As String) As DataTable

        Dim tbusuario As New DataTable
        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter

        Vconexion()

        sql.Connection = Conexion
        sql.CommandText = "select clave from usuarios where usuario='" & usuario & "'"
        sql.CommandType = CommandType.Text

        da.SelectCommand = sql
        da.Fill(tbusuario)

        If tbusuario.Rows.Count > 0 Then
            Return tbusuario
        Else
            Return Nothing
        End If
        Conexion.Close()
    End Function
    Public Function actualizarClave(ByVal usuario As String, ByVal clave As String) As Boolean
        Vconexion()

        Dim cmdFP = New MySqlCommand("actualizarClave", Conexion)


        cmdFP.CommandType = CommandType.StoredProcedure
        cmdFP.Parameters.AddWithValue("@p_usuario", usuario)
        cmdFP.Parameters.AddWithValue("@p_clave", clave)

        Try
            cmdFP.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.ToString)
            Return False
        End Try
        Conexion.Close()

    End Function
    Public Function traerCiudades() As DataTable
        Vconexion()

        Dim tbCiudades As New DataTable
        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter


        sql.CommandText = "SELECT idciudad,descripcion FROM ciudad ORDER BY descripcion"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbCiudades)

        Conexion.Close()
        Try
            Return tbCiudades
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function traerEstadosClientes() As DataTable
        Vconexion()

        Dim tbestados As New DataTable
        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter


        sql.CommandText = "SELECT idestado,descripcion FROM estadosClientes ORDER BY descripcion"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbestados)

        Conexion.Close()
        Try
            Return tbestados
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function lstClientes(ByVal fecha As Date) As DataTable

        Vconexion()

        Dim tbclientes As New DataTable

        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim vfecha As String = Year(fecha) & "-" & Month(fecha) & "-" & Day(fecha)

        sql.CommandText = "SELECT idtipoCliente,nombres,apellidos, ruc,telefono1,email FROM Clientes where fechaIngreso='" & vfecha & "'"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbclientes)

        Conexion.Close()

        Try
            Return tbclientes
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try

    End Function
    Public Function lstClientesXApellido(ByVal apellidos As String) As DataTable

        Vconexion()

        Dim tbclientes As New DataTable

        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter

        sql.CommandText = "SELECT idtipoCliente,nombres,apellidos, ruc,telefono1,email FROM Clientes where apellidos='%" & apellidos & "%'"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbclientes)

        Conexion.Close()

        Try
            Return tbclientes
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try

    End Function
    Public Function ingresarDatosPago(ByVal p_idCliente As Integer, ByVal p_idFormaPago As Integer, ByVal p_IdBanco As Integer, ByVal p_tipoCuenta As Char, ByVal p_numeroCuenta As String, ByVal p_numeroTC As String, ByVal p_fechaExpiracion As Date, ByVal p_IdBancoTC As Char, ByVal p_numeroPapeleta As Char, ByVal p_Observacion As String) As Integer
        Vconexion()

        Dim cmdFP = New MySqlCommand("datosPago", Conexion)
        Dim cmdNumero As MySqlCommand = New MySqlCommand
        Dim numero As Integer

        cmdFP.CommandType = CommandType.StoredProcedure
        cmdFP.Parameters.AddWithValue("@p_idCliente", p_idCliente)
        cmdFP.Parameters.AddWithValue("@p_idFormaPago", p_idFormaPago)
        cmdFP.Parameters.AddWithValue("@p_IdBanco", p_IdBanco)
        cmdFP.Parameters.AddWithValue("@p_tipoCuenta", p_tipoCuenta)
        cmdFP.Parameters.AddWithValue("@p_numeroCuenta", p_numeroCuenta)
        cmdFP.Parameters.AddWithValue("@p_numeroTC", p_numeroTC)
        cmdFP.Parameters.AddWithValue("@p_fechaExpiracion", p_fechaExpiracion)
        cmdFP.Parameters.AddWithValue("@p_IdBancoTC", p_IdBancoTC)
        cmdFP.Parameters.AddWithValue("@p_numeroPapeleta", p_numeroPapeleta)
        cmdFP.Parameters.AddWithValue("@p_Observacion", p_Observacion)

        Try
            cmdFP.ExecuteNonQuery()
            'aqui consultar el ultimo registro
            cmdNumero.CommandText = "SELECT @@identity AS id from datospago"
            cmdNumero.CommandType = CommandType.Text

            cmdNumero.Connection = Conexion
            numero = cmdNumero.ExecuteScalar()

            Return numero
        Catch ex As Exception
            ex.ToString()
            Return 0
        End Try

        Conexion.Close()
    End Function
    Public Function consultarDatosPago(ByVal IdPago As Integer) As DataTable
        Vconexion()

        Dim tbDatosPago As New DataTable
        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter


        sql.CommandText = "SELECT *,b.descripcion, (select descripcion from bancos where idBanco=a.idbanco) as banco,tipocuenta,fechaExpiracion FROM datosPago a, formasPago b where a.formapago=b.idFormaPago and iddatospago=" & IdPago
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbDatosPago)

        Conexion.Close()
        Try
            Return tbDatosPago
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function ingresarTransaccion(ByVal p_idCliente As Integer, ByVal p_idPlan As Integer, ByVal p_IdVendedor As Integer, ByVal p_IdDatosPago As Integer, ByVal p_IdOperadora As Integer, ByVal p_IdEquipo As Integer, ByVal p_lineaNueva As String, ByVal p_estado As Char, ByVal p_procesoOperadora As Char, ByVal p_portabilidad As String) As String
        Vconexion()

        Dim cmdFP = New MySqlCommand("ingresarTransacciones", Conexion)

        cmdFP.CommandType = CommandType.StoredProcedure
        cmdFP.Parameters.AddWithValue("@p_idCliente", p_idCliente)
        cmdFP.Parameters.AddWithValue("@p_idPlan", p_idPlan)
        cmdFP.Parameters.AddWithValue("@p_IdVendedor", p_IdVendedor)
        cmdFP.Parameters.AddWithValue("@p_IdDatosPago", p_IdDatosPago)
        cmdFP.Parameters.AddWithValue("@p_IdOperadora", p_IdOperadora)
        cmdFP.Parameters.AddWithValue("@p_IdEquipo", p_IdEquipo)
        cmdFP.Parameters.AddWithValue("@p_lineaNueva", p_lineaNueva)
        cmdFP.Parameters.AddWithValue("@p_estado", p_estado)
        cmdFP.Parameters.AddWithValue("@p_procesoOperadora", p_procesoOperadora)
        cmdFP.Parameters.AddWithValue("@p_portabilidad", p_portabilidad)

        Try
            cmdFP.ExecuteNonQuery()
            Return "Registro OK"

        Catch ex As Exception
            Return ex.ToString
        End Try
        Conexion.Close()
    End Function
    Public Function consultarTransacciones() As DataTable

        Vconexion()

        Dim tbTransacciones As New DataTable

        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter

        sql.CommandText = "SELECT b.nombres,b.apellidos,a.portabilidad, (SELECT nombrePlan FROM tiposplanes WHERE idPlan=a.idplan  ) AS TipoPlan,a.lineanueva,estado,procesoOperadora FROM transacciones a, clientes b WHERE a.idcliente=b.idcliente"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbTransacciones)

        Conexion.Close()

        Try
            Return tbTransacciones
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try

    End Function
    Public Function consultarTransacciones(ByVal fecha As Date) As DataTable
        Vconexion()

        Dim transacciones As New DataTable

        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter

        Dim fechaFormateada As String = Year(fecha) & "-" & Month(fecha) & "-" & Day(fecha)

        sql.CommandText = "SELECT b.nombres,b.apellidos,a.portabilidad, (SELECT nombrePlan FROM tiposplanes WHERE idPlan=a.idplan  ) AS TipoPlan,a.lineanueva,estado,procesoOperadora FROM transacciones a, clientes b WHERE a.idcliente=b.idcliente AND a.fechaIngreso='" & fechaFormateada & "'"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(transacciones)

        Conexion.Close()

        Try
            Return transacciones
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function consultarTransaccionesIdCliente(ByVal idCliente) As DataTable

        Vconexion()

        Dim tbTransacciones As New DataTable

        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter

        sql.CommandText = "SELECT b.nombres,b.apellidos,a.portabilidad, (SELECT nombrePlan FROM tiposplanes WHERE idPlan=a.idplan  ) AS NombrePlan, (SELECT tarifa FROM tiposplanes WHERE idPlan=a.idplan  ) AS ValorPlan, (SELECT nombresCompletos FROM usuarios WHERE idusuario=a.idVendedor  ) AS Vendedor, a.lineanueva,estado,procesoOperadora,a.iddatospago FROM transacciones a, clientes b WHERE a.idcliente=" & idCliente
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbTransacciones)

        Conexion.Close()

        Try
            Return tbTransacciones
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try

    End Function
    Public Function actualizarScore(ByVal cedula As String, ByVal calificacion As String, ByVal score As Decimal) As Boolean
        Vconexion()

        Dim sql As MySqlCommand = New MySqlCommand

        sql.CommandText = "update clientes set score=" & score & ",calificacionBuro='" & calificacion & "',fechaIngresoScore=curdate() where ruc='" & cedula & "'"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion

        Try
            sql.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try
        Conexion.Close()
    End Function
    Public Function cargarScore() As DataTable
        Vconexion()

        Dim tbScore As New DataTable
        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter

        sql.CommandText = "select calificacion,descripcion,idscore from score_catalogo"
        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbScore)

        Try
            Return tbScore
        Catch ex As Exception
            Return Nothing
        End Try
        Conexion.Close()

    End Function
    Public Function buscarClienteEnTransaccion(ByVal cedula As String) As DataTable
        Vconexion()

        Dim tbScore As New DataTable
        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter

        Try
            sql.CommandText = "Select a.idcliente, idPlan,(Select tarifa from tiposplanes c where c.idPlan=a.idplan) As tarifa, (select nombrePlan from tiposplanes c where c.idPlan=a.idplan) as nombrePlan, b.nombres,b.apellidos FROM `transacciones` a,clientes b WHERE a.idcliente=b.idcliente And b.ruc='" & cedula & "'"
            sql.Connection = Conexion
            da.SelectCommand = sql
            da.Fill(tbScore)
            Return tbScore
        Catch ex As Exception
            Return Nothing
        End Try
        Conexion.Close()
    End Function
    Public Function grabarScorePolitica(ByVal idScore As Integer, ByVal idPlan As Integer) As String
        Vconexion()

        Dim sql As MySqlCommand = New MySqlCommand

        sql.CommandText = "insert into planesscore (idScore,idplan,fecha) values(" & idScore & "," & idPlan & ",curdate())"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion

        Try
            sql.ExecuteNonQuery()
            Return "Registro Ingresado OK"
        Catch ex As Exception
            Return ex.ToString()
        End Try

        Conexion.Close()

    End Function
    Public Function grabarScoreHistorico(ByVal idcliente As Integer, ByVal valorscore As Decimal, ByVal fecha1 As Date, ByVal fecha2 As Date, ByVal destinatario As String) As String

        Dim sql As MySqlCommand = New MySqlCommand
        Dim fechavalidada As Integer
        Dim fechauno, fechados As String

        'validacion que debe tener menos de tres meses de vigencia
        fechavalidada = DateDiff(DateInterval.Day, fecha1, fecha2)
        'aqui va el parametro 
        If fechavalidada <= 90 Then
            fechauno = Year(fecha1) & "/" & Month(fecha1) & "/" & Day(fecha1)
            fechados = Year(fecha2) & "/" & Month(fecha2) & "/" & Day(fecha2)


            sql.CommandText = "insert into historicostore (valorscore,fecha1,fecha2,idcliente) values(" & valorscore & ",'" & fechauno & "','" & fechados & "'," & idcliente & ")"
            sql.CommandType = CommandType.Text

            sql.Connection = Conexion

            Try
                sql.ExecuteNonQuery()
                envioCorreo(destinatario, "Score", "Score Ok")
                Return "Registro Ingresado OK - Correo Enviado"
            Catch ex As Exception
                Return ex.ToString()
            End Try
        Else
            Return "Contrato es mayor del tiempo requerido"
        End If

        Conexion.Close()
    End Function

    Public Function consultarScoreHistorico() As DataTable
        Vconexion()

        Dim tbhistoricostore As New DataTable
        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter

        sql.CommandText = "select valorscore,fecha1,fecha2 from historicostore"
        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbhistoricostore)

        Try
            Return tbhistoricostore
        Catch ex As Exception
            Return Nothing
        End Try
        Conexion.Close()
    End Function
    Public Function consultarvalorscore(ByVal idcliente As Integer) As Integer
        Dim numero As Integer
        Vconexion()

        Dim tbhistoricostore As New DataTable
        Dim sql As MySqlCommand = New MySqlCommand


        sql.CommandText = "Select Case sum(valorscore) FROM historicostore WHERE idcliente=" & idcliente
        sql.Connection = Conexion
        sql.CommandType = CommandType.Text

        Try
            numero = sql.ExecuteScalar()
            Return numero
        Catch ex As Exception
            Return 0
        End Try
        Conexion.Close()
    End Function
    Public Function envioCorreo(ByVal destinatario As String, ByVal asunto As String, ByVal mensaje As String) As String
        Dim _Message As New System.Net.Mail.MailMessage()
        Dim _SMTP As New System.Net.Mail.SmtpClient
        'Itst$2019

        'lectura de los datos de la configuracion
        Vconexion()
        Dim tbDatos As New DataTable
        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter


        sql.CommandText = "Select usuarioemail,claveemail,puerto,dominio from datosempresa"
        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbDatos)


        'CONFIGURACIÓN DEL STMP
        _SMTP.Credentials = New System.Net.NetworkCredential(tbDatos.Rows(0)("usuarioemail").ToString, tbDatos.Rows(0)("claveemail").ToString)
        _SMTP.Host = tbDatos.Rows(0)("dominio").ToString '"mail.misoporteinformatico.com" 'smtp.misoporteinformatico.com
        _SMTP.Port = tbDatos.Rows(0)("puerto").ToString '587
        _SMTP.EnableSsl = True

        ' CONFIGURACION DEL MENSAJE
        _Message.[To].Add(destinatario) 'Cuenta de Correo al que se le quiere enviar el e-mail
        _Message.From = New System.Net.Mail.MailAddress(tbDatos.Rows(0)("usuarioemail").ToString, "Sistema de Call Center", System.Text.Encoding.UTF8) 'Quien lo envía
        _Message.Subject = mensaje ' "No paso el Score" 'Sujeto del e-mail
        _Message.SubjectEncoding = System.Text.Encoding.UTF8 'Codificacion
        _Message.Body = mensaje '"No paso el score" 'contenido del mail
        _Message.BodyEncoding = System.Text.Encoding.UTF8
        _Message.Priority = System.Net.Mail.MailPriority.Normal
        _Message.IsBodyHtml = False

        Try
            _SMTP.Send(_Message)
            Return "Envio correcto"
        Catch ex As System.Net.Mail.SmtpException
            Return "Envio con este error: " & ex.ToString
        End Try
    End Function
    Public Function confwebmail(ByVal usuarioemail As String, ByVal claveemail As String, ByVal puerto As Integer, ByVal dominio As String) As String
        Dim sql As MySqlCommand = New MySqlCommand

        Vconexion()

        sql.CommandText = "insert into datosempresa (usuarioemail, claveemail,puerto,dominio) values('" & usuarioemail & "','" & claveemail & "'," & puerto & ",'" & dominio & "')"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion

        Try
            sql.ExecuteNonQuery()
            Return "Configuración Ingresada OK"
        Catch ex As Exception
            Return ex.ToString()
        End Try

        Return "No se pudo ingresar la configuración"

        Conexion.Close()
    End Function
    Public Function buscarUsuario(ByVal nombre As String) As DataTable
        Vconexion()

        'devuelve una tabla porque de pronto por alguna regla de negocio de va a denegar un plan u otro
        Dim tbUsuario As New DataTable
        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter

        sql.CommandText = "SELECT usuario,clave,nombrescompletos,email,tipo from usuarios where usuario='" & nombre & "'"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbUsuario)

        Conexion.Close()

        Try
            Return tbUsuario
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function perfilesdeUsuarios()
        Vconexion()

        'devuelve una tabla porque de pronto por alguna regla de negocio de va a denegar un plan u otro
        Dim tbPerfiles As New DataTable
        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter

        sql.CommandText = "SELECT idperfil,descripcion,nivel from perfilesusuarios"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbPerfiles)

        Conexion.Close()

        Try
            Return tbPerfiles
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function actualizarUsuario(ByVal usuario As String, ByVal nombres As String, ByVal email As String, ByVal tipoUsuario As Char) As String
        Dim sql As MySqlCommand = New MySqlCommand

        Vconexion()

        sql.CommandText = "update usuarios set nombrescompletos='" & nombres & "',email='" & email & "',tipo='" & tipoUsuario & "' where usuario='" & usuario & "'"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion

        Try
            sql.ExecuteNonQuery()
            Return "Informacion actualizada correctamente"
        Catch ex As Exception
            Return ex.ToString()
        End Try

        Conexion.Close()
    End Function
    Public Function eliminarUsuario(ByVal usuario As String) As String
        Dim sql As MySqlCommand = New MySqlCommand

        Vconexion()

        sql.CommandText = "delete usuarios where usuario='" & usuario & "'"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion

        Try
            sql.ExecuteNonQuery()
            Return "usuario eliminado correctamente"
        Catch ex As Exception
            Return ex.ToString()
        End Try

        Conexion.Close()
    End Function
    Public Function grabarTituloParametro(ByVal parametro As String) As String
        Dim sql As MySqlCommand = New MySqlCommand

        Vconexion()

        sql.CommandText = "insert into parametros (descripcion) values('" & parametro & "')"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion

        Try
            sql.ExecuteNonQuery()
            Return "Grabación Ok"
        Catch ex As Exception
            Return ex.ToString()
        End Try

        Return "No se pudo ingresar el título del parámetro"

        Conexion.Close()

    End Function
    Public Function consultarTituloParametro() As DataTable
        Vconexion()

        'devuelve una tabla porque de pronto por alguna regla de negocio de va a denegar un plan u otro
        Dim tbtitulosparametros As New DataTable
        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter

        sql.CommandText = "SELECT * from parametros"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbtitulosparametros)

        Conexion.Close()

        Try
            Return tbtitulosparametros
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function ingresarParametrodoc(ByVal idtitulo As Integer, ByVal titulo As String) As String
        Dim sql As MySqlCommand = New MySqlCommand

        Vconexion()

        sql.CommandText = "insert into parametrosdocumentos (idparametro,descripcion) values(" & idtitulo & ",'" & titulo & "')"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion

        Try
            sql.ExecuteNonQuery()
            Return "Grabación Ok"
        Catch ex As Exception
            Return ex.ToString()
        End Try

        Return "No se pudo ingresar el título del parámetro"

        Conexion.Close()

    End Function
    Public Function consultarParametros() As DataTable
        Vconexion()

        'devuelve una tabla porque de pronto por alguna regla de negocio de va a denegar un plan u otro
        Dim tbtitulosparametros As New DataTable
        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter

        sql.CommandText = "Select a.descripcion as Documento ,b.descripcion as Accion from parametrosdocumentos a, parametros b where a.idparametro = b.idparametros"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbtitulosparametros)

        Conexion.Close()

        Try
            Return tbtitulosparametros
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function grabarEntidadesFinancieras(ByVal entidad As String, ByVal estado As Char) As String
        Vconexion()

        Dim sql As MySqlCommand = New MySqlCommand

        sql.CommandText = "insert into bancos (descripcion,estado) values('" & entidad & "','" & estado & "')"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion

        Try
            sql.ExecuteNonQuery()
            Return "Registro Ingresado OK"
        Catch ex As Exception
            Return ex.ToString()
        End Try

        Conexion.Close()

    End Function
    Public Function cargarBancos() As DataTable
        Dim tbBancos As New DataTable
        Vconexion()

        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter

        sql.CommandText = "Select * from bancos"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbBancos)

        Conexion.Close()

        Try
            Return tbBancos
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try

    End Function
    Public Function ingresarTarjeta(ByVal descripcion As String, ByVal estado As String)
        Vconexion()

        Dim sql As MySqlCommand = New MySqlCommand

        sql.CommandText = "insert into tarjetas (descripcion,estado) values('" & descripcion & "','" & estado & "')"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion

        Try
            sql.ExecuteNonQuery()
            Return "Registro Ingresado OK"
        Catch ex As Exception
            Return ex.ToString()
        End Try

        Conexion.Close()
    End Function
    Public Function cargarTarjetas() As DataTable
        Dim tbTarjetas As New DataTable
        Vconexion()

        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter

        sql.CommandText = "Select idTarjeta as IdBanco, descripcion from tarjetas"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbTarjetas)

        Conexion.Close()

        Try
            Return tbTarjetas
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try

    End Function
    Public Function cargarfpagos() As DataTable
        Dim tbTarjetas As New DataTable
        Vconexion()

        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter

        sql.CommandText = "Select * from formaspago"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbTarjetas)

        Conexion.Close()

        Try
            Return tbTarjetas
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try

    End Function
    Public Function ingresarfpago(ByVal descripcion As String, ByVal estado As String) As String
        Vconexion()
        Dim sql As MySqlCommand = New MySqlCommand

        sql.CommandText = "insert into formaspago (descripcion,estado) values('" & descripcion & "','" & estado & "')"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion

        Try
            sql.ExecuteNonQuery()
            Return "Registro Ingresado OK"
        Catch ex As Exception
            Return ex.ToString()
        End Try

        Conexion.Close()

    End Function
    Public Function eliminarBanco(ByVal id As Integer) As String
        Vconexion()
        Dim sql As MySqlCommand = New MySqlCommand

        sql.CommandText = "delete from bancos where idbanco=" & id
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion

        Try
            sql.ExecuteNonQuery()
            Return "Registro Eliminado OK"
        Catch ex As Exception
            Return ex.ToString()
        End Try

        Conexion.Close()
    End Function
    Public Function cargarListado() As DataTable
        Dim tbListados As New DataTable
        Vconexion()

        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter

        sql.CommandText = "Select a.descripcion as Documento ,b.descripcion as Accion from parametrosdocumentos a, parametros b where a.idparametro = b.idparametros"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbListados)

        Conexion.Close()

        Try
            Return tbListados
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try

    End Function
    Public Function cargarElementos(ByVal elemento As Integer) As DataTable
        Dim tbelementos As New DataTable
        Vconexion()
        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter
        sql.CommandText = "Select descripcion,idparametro from parametrosdocumentos where idParametro=" & elemento
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbelementos)

        Conexion.Close()

        Try
            Return tbelementos
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function rptEquipos(ByVal fecha As Date) As DataTable
        Dim tbelementos As New DataTable
        Dim fechareporte As String = Year(fecha) & "/" & Month(fecha) & "/" & Day(fecha)

        Vconexion()
        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter
        sql.CommandText = "Select a.descripcion as Equipo, b.descripcion as Marca, codigonip,imsi,imei,stockActual, estado from equipos a,marcas b where a.idMarca=b.idmarca and fecha>='" & fechaReporte & "'"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbelementos)

        Conexion.Close()

        Try
            Return tbelementos
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function CambiarClave(ByVal usuario As String) As String
        Vconexion()
        Dim tbUsuarios As New DataTable
        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter
        Dim numero As New Random()
        Dim valorAleatorio As Integer = numero.Next(100, 1000)
        Dim email As String
        Dim cuerpo As String



        cuerpo = "Su clave es: " & System.Convert.ToString(valorAleatorio)

        Vconexion()

        sql.CommandText = "select usuario,email from usuarios where usuario='" & usuario & "'"
        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbUsuarios)
        email = tbUsuarios.Rows(0)(1).ToString
        envioCorreo(email, "Reinicio de Clave", cuerpo)

        sql.CommandText = "update usuarios set clave='" & System.Convert.ToString(valorAleatorio) & "' where usuario='" & usuario & "'"
        sql.CommandType = CommandType.Text
        sql.ExecuteNonQuery()

        Try
            sql.ExecuteNonQuery()
            Return "La clave fue enviada al email"
        Catch ex As Exception
            Return "Usuario Inválido"
        End Try

        Conexion.Close()
    End Function
    Public Function datosPlanesPortabilidad(ByVal idcliente As Integer) As DataTable
        Vconexion()
        Dim tbUsuarios As New DataTable
        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter

        sql.CommandText = "SELECT a.idPlan,b.nombrePlan,portabilidad FROM transacciones a, tiposplanes b where idcliente=" & idcliente & " and a.idplan=b.idPlan"
        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbUsuarios)

        Conexion.Close()

        Try
            Return tbUsuarios
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try

    End Function
    Public Function grabarDocumentos(ByVal cedula As String, ByVal iddocumento As Integer, ByVal direccion As String, ByVal estado As Char) As Boolean
        Vconexion()
        Dim sql As MySqlCommand = New MySqlCommand
        Dim ndireccion As String = Replace(direccion, "\", "\\")

        sql.CommandText = "insert into documentosescaneados (cedula,idparametro,direccionDocScaneado,estado) values('" & cedula & "'," & iddocumento & ",'" & ndireccion & "','" & estado & "')"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion

        Try
            sql.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Return False
        End Try

        Conexion.Close()

    End Function
    Function ConsultarDocumentosIngresados(ByVal cedula As String) As DataTable
        Dim tbDocumentos As New DataTable
        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter

        Vconexion()

        sql.CommandText = "SELECT direccionDocScaneado, estado from documentosescaneados where cedula='" & cedula & "'"
        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbDocumentos)

        Conexion.Close()

        Try
            Return tbDocumentos
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try
    End Function
    Function ConsultarDocScaneadosXID(ByVal id As Integer, ByVal cedula As String) As String
        Dim tbDocumentos As New DataTable
        Dim sql As MySqlCommand = New MySqlCommand
        Dim documento As String


        Vconexion()

        sql.CommandText = "SELECT direccionDocScaneado from documentosescaneados where idparametro=" & id & " and cedula='" & cedula & "'"
        sql.Connection = Conexion
        documento = sql.ExecuteScalar
        Conexion.Close()

        Try
            Return documento
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Function consultarPlanFijoCatalogo() As DataTable
        Vconexion()

        Dim tbPlanFijo As New DataTable
        Dim sql As MySqlCommand = New MySqlCommand
        Dim da As New MySqlDataAdapter


        sql.CommandText = "SELECT idplanfijo,descripcion,estado FROM catPlanFijo ORDER BY descripcion"
        sql.CommandType = CommandType.Text

        sql.Connection = Conexion
        da.SelectCommand = sql
        da.Fill(tbPlanFijo)

        Conexion.Close()
        Try
            Return tbPlanFijo
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function grabarPlanFijo(ByVal descripcion As String) As Boolean
        Vconexion()

        Dim cmd = New MySqlCommand("ingresarCatPlanFijo", Conexion)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@p_planfijo", descripcion)

        Try
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Return False
        End Try
        Conexion.Close()
    End Function
End Class
