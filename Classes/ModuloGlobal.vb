''Para trabajar con una base de datos en ORACLE
Imports Oracle.DataAccess.Client

Module ModuloGlobal
    'Esta es la variable de conexión global
    Public cnx As OracleConnection
    'Datos del usuario
    Public idUsuario As Integer
    Public nombreRol As String
    Public nombreUsuario As String
    Public paternoUsuario As String
    Public maternoUsuario As String
    Public nombreCompletoUser As String
    Public modoSuperUsuario As Boolean = False
    Public abiertoDesde As String
    Public cerradoDesde As String
    Public idTurnoActual As Integer
    Public sinTurno As Boolean
    Public cantidadActualEnCaja As Double
    Public cantidadFondoEnCaja As Double
    Public cantidadRetiroEnCaja As Double
    Public encriptada As String = "Si"
    Public cancelada As String = "No"

    Private strSql As String
    Private xCnx As New Oracle
    Private xDT As DataTable

    'Este método permite checar si un formulario se encuentra abierto o esta cerrado
    Public Function BuscarFormularioActivo(nombreFormulario As String) As Boolean
        BuscarFormularioActivo = False
        Dim nFormulario As Form
        For Each nFormulario In Application.OpenForms
            If StrComp(nFormulario.Name, nombreFormulario) = 0 Then
                BuscarFormularioActivo = True
                Exit For
            End If
        Next
    End Function

    'Método que guarda datos del usuario que ingresa al sistema
    Public Sub consultaNombreDeUsuario()
        Try
            Dim xDT As New DataTable
            Dim nombreUs As New OracleDataAdapter("SELECT id_usuario, nombre_rol, nombre_usuario, paterno_usuario, materno_usuario FROM Usuario, Rol WHERE Usuario.id_rol = Rol.id_rol AND usuario = '" & FrmInicioSesión.TxtUsuario.Text & "'", cnx)

            nombreUs.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                idUsuario = registro("id_usuario")
                nombreRol = registro("nombre_rol").ToString
                nombreUsuario = registro("nombre_usuario").ToString
                paternoUsuario = registro("paterno_usuario").ToString
                maternoUsuario = registro("materno_usuario").ToString
            Next
            nombreCompletoUser = nombreUsuario + " " + paternoUsuario + " " + maternoUsuario
        Catch ex As Exception

        End Try

    End Sub

    'Método que recarga los CBGenero de todos los formularios que dependen de el, esto al hacer una modificacion en Géneros
    Public Sub RecargarCBGenero()
        'Formulario de Usuario
        FrmAdministracionUsuarios.usuario.PoblarComboBoxGenero()
        'Formulario de Cliente
        FrmAdministracionClientes.cliente.PoblarComboBoxGenero()
        FrmRegistroCliente.cliente.PoblarComboBoxGenero()
    End Sub

    'Método que recarga los CBRol de todos los formularios que dependen de el, esto al hacer una modificacion en Rol
    Public Sub RecargarCBRol()
        'Formulario de Usuario
        FrmAdministracionUsuarios.usuario.PoblarComboBoxRoles()
    End Sub

    'Método que recarga los CBPermiso de todos los formularios que dependen de el, esto al hacer una modificacion en Rol
    Public Sub RecargarCBPermiso()
        'Formulario de Rol
        FrmRol.rol.PoblarComboBoxPermiso()
    End Sub

    'Método que cierra todos los formularios al dar clic al FrmMenuPrincipal
    Public Sub CierraTodoNoMenuPrincip()
        FrmGenero.Hide()
        FrmAviso.Hide()
        FrmAdministracionClientes.Hide()
        FrmAdministracionUsuarios.Hide()
        FrmCerrarSesion.Hide()
        FrmCorrecto.Hide()
        FrmListadoClientes.Hide()
        FrmListadoUsuarios.Hide()
        FrmMenuAdministracion.Hide()
        FrmMetodoPago.Hide()
        FrmNota.Hide()
        FrmPermiso.Hide()
        FrmRegistroCliente.Hide()
        FrmRol.Hide()
        FrmSalida.Hide()
        FrmTurno.Hide()
    End Sub

    'Método que obliga a las cajas de texto a solo recibir numeros con decimal
    Public Sub SoloNumeroYDecimal(ByVal CajaTexto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    'Método que obliga a las cajas de texto a solo recibir numeros enteros
    Public Sub SoloNumero(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    'Método que obliga a las cajas de texto a solo recibir LETRAS, numeros y caracteres especiales sin apostrofe
    Public Sub SoloLetrasYNumerosSinApostrofe(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub

    'Método que obliga a las cajas de texto a solo recibir LETRAS sin apostrofe
    Public Sub SoloLetrasSinApostrofe(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = "'" Then
            e.Handled = True
        End If

        If Not Char.IsLetter(e.KeyChar) _
                     AndAlso Not Char.IsControl(e.KeyChar) _
                     AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'Método de autorizacion de administracion
    Public Sub AutorizacionAdministrativa(nombreFormularioAbrir As Form, nombreFormularioOcultar As Form, nombreFormularioCerrar As Form)
        If FrmAutorizacion.TxtUsuario.Text = "" And FrmAutorizacion.TxtContrasena.Text = "" Then
            FrmAviso.LbMensaje.Text = "El campo USUARIO Y CONTRASEÑA están vacíos"
            FrmAviso.Show()
        ElseIf FrmAutorizacion.TxtUsuario.Text = "" Then
            FrmAviso.LbMensaje.Text = "El campo EMPLEADO está vacío"
            FrmAviso.Show()
        ElseIf FrmAutorizacion.TxtContrasena.Text = "" Then
            FrmAviso.LbMensaje.Text = "El campo CONTRASEÑA está vacío"
            FrmAviso.Show()
        Else
            Dim acceso As New InicioSesion(FrmAutorizacion.TxtUsuario.Text, FrmAutorizacion.TxtContrasena.Text)

            If acceso.ConsultaUsuario() = False Then
                FrmAviso.LbMensaje.Text = "El usuario NO EXISTE"
                FrmAviso.Show()
            ElseIf acceso.ConsultaUsuario() = True Then
                If acceso.ConsultaSiEstaActivo Then
                    If acceso.ConsultaSiTieneAcceso Then
                        If acceso.ConsultaUsuarioContrasena() = False Then
                            FrmAviso.LbMensaje.Text = "La contraseña ESTÁ INCORRECTA"
                            FrmAviso.Show()
                        Else
                            If acceso.ConsultaSiTieneAccesoAdmin Or acceso.ConsultaSiTieneAccesoEncarg Then
                                FrmAutorizacion.Close()
                                FrmCorrecto.LbMensaje.Text = "AUTORIZACIÓN CONCEBIDA"
                                FrmCorrecto.Show()

                                If nombreFormularioAbrir IsNot Nothing Then
                                    nombreFormularioAbrir.Show()
                                    If nombreFormularioAbrir.Name = "FrmMenuAdministracion" Then
                                        modoSuperUsuario = True
                                    End If
                                End If

                                If nombreFormularioOcultar IsNot Nothing Then
                                    nombreFormularioOcultar.Hide()
                                End If

                                If nombreFormularioCerrar IsNot Nothing Then
                                    nombreFormularioCerrar.Close()
                                End If
                            Else
                                FrmAviso.LbMensaje.Text = "EL USUARIO NO TIENE ACCESO ADMINISTRATIVO"
                                FrmAviso.Show()
                            End If
                        End If
                    Else
                        FrmAviso.LbMensaje.Text = "ESTE USUARIO NO TIENE ACCESO AL SISTEMA"
                        FrmAviso.Show()
                    End If
                Else
                    FrmAviso.LbMensaje.Text = "ESTE USUARIO ESTA DESACTIVADO"
                    FrmAviso.Show()
                End If
            End If
        End If
    End Sub

    Public Sub CerrarEnCascada()
        FrmListadoUsuarios.Close()
        FrmListadoClientes.Close()
        FrmAcercaDe.Close()
        FrmAdministracionClientes.Close()
        FrmAdministracionFolio.Close()
        FrmAdministrarHabitacion.Close()
        FrmAdministracionUsuarios.Close()
        FrmAutorizacion.Close()
        FrmAviso.Close()
        FrmCalendarioReservaciones.Close()
        FrmCambio.Close()
        FrmCantidadPagar.Close()
        FrmCargando.Close()
        FrmCargoExtra.Close()
        FrmCorrecto.Close()
        FrmEgreso.Close()
        FrmGenero.Close()
        FrmHabitacionesAsignadas.Close()
        FrmInicioTurno.Close()
        FrmListadoClientes.Close()
        FrmListadoCobros.Close()
        FrmListadoEgreso.Close()
        FrmListadoFolio.Close()
        FrmListadoClientes.Close()
        FrmListadoHabitaciones.Close()
        FrmListadoReservaciones.Close()
        FrmListadoUsuarios.Close()
        FrmMetodoPago.Close()
        FrmNota.Close()
        FrmPago.Close()
        FrmPermiso.Close()
        FrmRegistroCliente.Close()
        FrmRegistroReservacion.Close()
        FrmReportes.Close()
        FrmRol.Close()
        FrmSalida.Close()
        FrmSeleccionarCliente.Close()
        FrmSeleccionarFolio.Close()
        FrmTipoHabitacion.Close()
        FrmTurno.Close()
        FrmMenuAdministracion.Close()
        FrmMenuPrincipal.Close()
    End Sub

    Public Sub OcultarEnCascada()

        FrmListadoUsuarios.Hide()
        FrmListadoClientes.Hide()
        FrmAcercaDe.Hide()
        FrmAdministracionClientes.Hide()
        FrmAdministracionFolio.Hide()
        FrmAdministrarHabitacion.Hide()
        FrmAdministracionUsuarios.Hide()
        FrmAutorizacion.Hide()
        FrmAviso.Hide()
        FrmCalendarioReservaciones.Hide()
        FrmCambio.Hide()
        FrmCantidadPagar.Hide()
        FrmCargando.Close()
        FrmCargoExtra.Hide()
        FrmCorrecto.Hide()
        FrmEgreso.Hide()
        FrmGenero.Hide()
        FrmHabitacionesAsignadas.Hide()
        FrmInicioTurno.Hide()
        FrmListadoClientes.Hide()
        FrmListadoCobros.Hide()
        FrmListadoEgreso.Hide()
        FrmListadoFolio.Hide()
        FrmListadoClientes.Hide()
        FrmListadoHabitaciones.Hide()
        FrmListadoReservaciones.Hide()
        FrmListadoUsuarios.Hide()
        FrmMetodoPago.Hide()
        FrmNota.Hide()
        FrmPago.Hide()
        FrmPermiso.Hide()
        FrmRegistroCliente.Hide()
        FrmRegistroReservacion.Hide()
        FrmReportes.Hide()
        FrmRol.Hide()
        FrmSalida.Hide()
        FrmSeleccionarCliente.Hide()
        FrmSeleccionarFolio.Hide()
        FrmTipoHabitacion.Hide()
        FrmTurno.Hide()
        FrmMenuAdministracion.Hide()
        FrmMenuPrincipal.Hide()
    End Sub

    'RECURSO NECESARIO PARA IMPRESION
    Public Sub ComprobarEstadoIncial()
        'Dim logoFavela As Image
        'logoFavela = New Bitmap(My.Resources.habitacion)
        Try

            'Se checa no si existe el directorio
            If Not System.IO.Directory.Exists("C:\IDEA Software\imgLogo\") Then
                'Si no existe el directorio, se crea uno nuevo y se procede a guardar la imagen de la habitacion
                My.Computer.FileSystem.CreateDirectory("C:\IDEA Software\imgLogo\")

                'Si la imagen nO existe entonces guarda la nueva imagen correspondiente
                If Not System.IO.File.Exists("C:\IDEA Software\imgLogo\logo.png") Then
                    'Si existe el directorio, y la imagen NO existe entonces guarda la imagen correspondiente

                    Try
                        'Guarda la imagen seleccionada con el nombre igual al numero de la habitacion
                        My.Resources.logoFavela.Save("C:\IDEA Software\imgLogo\logo.png")
                    Catch ex As Exception

                    End Try
                End If
            Else
                'Si la imagen nO existe entonces guarda la nueva imagen correspondiente
                If Not System.IO.File.Exists("C:\IDEA Software\imgLogo\logo.png") Then
                    'Si existe el directorio, y la imagen NO existe entonces guarda la imagen correspondiente

                    Try
                        'Guarda la imagen seleccionada con el nombre igual al numero de la habitacion
                        My.Resources.logoFavela.Save("C:\IDEA Software\imgLogo\logo.png")
                    Catch ex As Exception
                        '  MsgBox("Error al guardar: " & ex.Message)
                    End Try
                End If
            End If
        Catch ex As Exception
            '  MsgBox("Error al guardar: " & ex.Message)
        End Try
    End Sub

    'Actualizar DGV de Menu Principal
    Public Sub ActualizarDGVMenuPrincipal()
        FrmMenuPrincipal.ReservacionesDelDiaCI()
        FrmMenuPrincipal.ReservacionesDelDiaCO()
    End Sub

    'Encriptar BD
    Public Sub EncriptarBD()
        Try
            'USUARIO
            strSql = "UPDATE Usuario SET nombre_usuario=cryptit.encrypt_data(nombre_usuario)"
            xCnx.objetoCommand(strSql)
            strSql = "UPDATE Usuario SET paterno_usuario=cryptit.encrypt_data(paterno_usuario)"
            xCnx.objetoCommand(strSql)
            strSql = "UPDATE Usuario SET materno_usuario=cryptit.encrypt_data(materno_usuario)"
            xCnx.objetoCommand(strSql)
            strSql = "UPDATE Usuario SET telefono_usuario=cryptit.encrypt_data(telefono_usuario)"
            xCnx.objetoCommand(strSql)
            strSql = "UPDATE Usuario SET identificacion_usuario=cryptit.encrypt_data(identificacion_usuario)"
            xCnx.objetoCommand(strSql)
            strSql = "UPDATE Usuario SET direccion_usuario=cryptit.encrypt_data(direccion_usuario)"
            xCnx.objetoCommand(strSql)
            strSql = "UPDATE Usuario SET usuario=cryptit.encrypt_data(usuario)"
            xCnx.objetoCommand(strSql)
            strSql = "UPDATE Usuario SET contrasena=cryptit.encrypt_data(contrasena)"
            xCnx.objetoCommand(strSql)
            strSql = "UPDATE Usuario SET estado_usuario=cryptit.encrypt_data(estado_usuario)"
            xCnx.objetoCommand(strSql)

            'CLIENTE
            strSql = "UPDATE Cliente SET nombre_cliente=cryptit.encrypt_data(nombre_cliente)"
            xCnx.objetoCommand(strSql)
            strSql = "UPDATE Cliente SET paterno_cliente=cryptit.encrypt_data(paterno_cliente)"
            xCnx.objetoCommand(strSql)
            strSql = "UPDATE Cliente SET materno_cliente=cryptit.encrypt_data(materno_cliente)"
            xCnx.objetoCommand(strSql)
            strSql = "UPDATE Cliente SET telefono_cliente=cryptit.encrypt_data(telefono_cliente)"
            xCnx.objetoCommand(strSql)
            strSql = "UPDATE Cliente SET identificacion_cliente=cryptit.encrypt_data(identificacion_cliente)"
            xCnx.objetoCommand(strSql)
            strSql = "UPDATE Cliente SET nota_cliente=cryptit.encrypt_data(nota_cliente)"
            xCnx.objetoCommand(strSql)

            'EGRESO
            strSql = "UPDATE Egreso SET concepto=cryptit.encrypt_data(concepto)"
            xCnx.objetoCommand(strSql)

            'CARGO EXTRA
            strSql = "UPDATE Cargo_extra SET concepto=cryptit.encrypt_data(concepto)"
            xCnx.objetoCommand(strSql)
        Catch ex As Exception

        End Try

    End Sub

    'Desencriptar BD
    Public Sub DesencriptarBD()
        Try
            'USUARIO
            strSql = "UPDATE Usuario SET nombre_usuario=cryptit.decrypt_data(nombre_usuario)"
            xCnx.objetoCommand(strSql)
            strSql = "UPDATE Usuario SET paterno_usuario=cryptit.decrypt_data(paterno_usuario)"
            xCnx.objetoCommand(strSql)
            strSql = "UPDATE Usuario SET materno_usuario=cryptit.decrypt_data(materno_usuario)"
            xCnx.objetoCommand(strSql)
            strSql = "UPDATE Usuario SET telefono_usuario=cryptit.decrypt_data(telefono_usuario)"
            xCnx.objetoCommand(strSql)
            strSql = "UPDATE Usuario SET identificacion_usuario=cryptit.decrypt_data(identificacion_usuario)"
            xCnx.objetoCommand(strSql)
            strSql = "UPDATE Usuario SET direccion_usuario=cryptit.decrypt_data(direccion_usuario)"
            xCnx.objetoCommand(strSql)
            strSql = "UPDATE Usuario SET usuario=cryptit.decrypt_data(usuario)"
            xCnx.objetoCommand(strSql)
            strSql = "UPDATE Usuario SET contrasena=cryptit.decrypt_data(contrasena)"
            xCnx.objetoCommand(strSql)
            strSql = "UPDATE Usuario SET estado_usuario=cryptit.decrypt_data(estado_usuario)"
            xCnx.objetoCommand(strSql)

            'CLIENTE
            strSql = "UPDATE Cliente SET nombre_cliente=cryptit.decrypt_data(nombre_cliente)"
            xCnx.objetoCommand(strSql)
            strSql = "UPDATE Cliente SET paterno_cliente=cryptit.decrypt_data(paterno_cliente)"
            xCnx.objetoCommand(strSql)
            strSql = "UPDATE Cliente SET materno_cliente=cryptit.decrypt_data(materno_cliente)"
            xCnx.objetoCommand(strSql)
            strSql = "UPDATE Cliente SET telefono_cliente=cryptit.decrypt_data(telefono_cliente)"
            xCnx.objetoCommand(strSql)
            strSql = "UPDATE Cliente SET identificacion_cliente=cryptit.decrypt_data(identificacion_cliente)"
            xCnx.objetoCommand(strSql)
            strSql = "UPDATE Cliente SET nota_cliente=cryptit.decrypt_data(nota_cliente)"
            xCnx.objetoCommand(strSql)

            'EGRESO
            strSql = "UPDATE Egreso SET concepto=cryptit.decrypt_data(concepto)"
            xCnx.objetoCommand(strSql)

            'CARGO EXTRA
            strSql = "UPDATE Cargo_extra SET concepto=cryptit.decrypt_data(concepto)"
            xCnx.objetoCommand(strSql)
        Catch ex As Exception

        End Try


    End Sub
End Module
