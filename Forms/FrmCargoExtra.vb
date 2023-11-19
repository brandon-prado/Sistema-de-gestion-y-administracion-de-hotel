Imports Oracle.DataAccess.Client
Public Class FrmCargoExtra
    Public cargo As New CargoExtra
    Public idCargoExtra As Integer
    Public idFolio As Integer
    Public numeroHabitacion As Integer

    Private strSql As String
    Private xCnx As New Oracle
    Private xDT As DataTable

    Private Sub BtnBuscarReservacion_Click(sender As Object, e As EventArgs) Handles BtnBuscarReservacion.Click
        FrmCargando.MostarConTiempoEnCargar(300)
        abiertoDesde = "CargoExtra"
        FrmSeleccionarFolio.Activate()
        FrmSeleccionarFolio.Show()
    End Sub

    Private Sub FrmCargoExtra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Activar doble buffer para evitar parpadeo con lo graficos del formulario
        Me.DoubleBuffered = True
        'Hora y fecha del sistema
        FechaHora.Enabled = True
        'Mostrar nombre completo del usuario
        LbUsuario.Text = nombreUsuario.ToString & vbCr & paternoUsuario.ToString & " " & maternoUsuario.ToString
        LbRol.Text = nombreRol.ToString
        'Cargar primero el formulario y luego seguir
        Application.DoEvents()

        'ToolTip para mostrar información de referencia al momento de colocar el mouse 
        'encima de un botón, imagen, etc.
        Me.ToolTip1.SetToolTip(Me.BtnRegresar, "Clic para regresar a la ventana anterior")
        Me.ToolTip1.SetToolTip(Me.BtnRegistrar, "Registar o actualizar género")
        Me.ToolTip1.SetToolTip(Me.BtnEliminar, "Eliminar el género")
        Me.ToolTip1.SetToolTip(Me.BtnLimpiar, "Limpiar caja de texto")

        TxtCantidad.Text = 0.0
        TxtPrecioUnitario.Text = 0
        TxtPrecioTotal.Text = 0.0


    End Sub

    Private Sub DGVCargoExtra_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCargoExtra.CellContentClick
        Dim renglon As Integer
        renglon = DGVCargoExtra.CurrentCellAddress.Y
        Try
            'Llenar las cajas de texto al seleccionar un resgistro del DGV
            idCargoExtra = DGVCargoExtra.Rows(renglon).Cells(0).Value
            idFolio = DGVCargoExtra.Rows(renglon).Cells(1).Value
            TxtFecha.Text = DGVCargoExtra.Rows(renglon).Cells(2).Value
            TxtNumHab.Text = DGVCargoExtra.Rows(renglon).Cells(4).Value
            TxtConceptoCargoExtra.Text = DGVCargoExtra.Rows(renglon).Cells(3).Value
            TxtCantidad.Text = DGVCargoExtra.Rows(renglon).Cells(5).Value
            TxtPrecioUnitario.Text = DGVCargoExtra.Rows(renglon).Cells(6).Value
            TxtPrecioTotal.Text = DGVCargoExtra.Rows(renglon).Cells(7).Value
            BtnRegistrar.Enabled = True
            BtnEliminar.Enabled = True
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        idCargoExtra = 0
        TxtConceptoCargoExtra.Text = ""
        TxtCantidad.Text = 0.0
        TxtPrecioUnitario.Text = 0
        TxtPrecioTotal.Text = 0.0
    End Sub

    Private Function ComprobarDatos() As Boolean
        ComprobarDatos = False
        If idFolio = 0 Or TxtConceptoCargoExtra.Text = "" Or TxtCantidad.Text = "" Or TxtConceptoCargoExtra.Text = "" Or TxtPrecioUnitario.Text = "" Or TxtPrecioTotal.Text = "" Or TxtNumHab.Text = "Todas" Then
            FrmAviso.LbMensaje.Text = "FALTAN DATOS, COMPRUEBA LOS CAMPOS CORRESPONDIENTES"
            FrmAviso.Show()
        ElseIf TxtCantidad.Text = 0 And TxtPrecioUnitario.Text = "." Then
            TxtPrecioUnitario.Text = ""
            TxtCantidad.Text = ""
            ComprobarDatos = False
            FrmAviso.LbMensaje.Text = "ESPECÍFICA LA CANTIDAD Y EL PRECIO UNITARIO CORRECTAMENTE"
            FrmAviso.Show()
        ElseIf TxtCantidad.Text = 0 Then
            TxtCantidad.Text = ""
            ComprobarDatos = False
            FrmAviso.LbMensaje.Text = "ESPECÍFICA LA CANTIDAD CORRECTAMENTE (DEBE SER MAYOR A 0)"
            FrmAviso.Show()
        ElseIf TxtPrecioUnitario.Text = "." Then
            TxtPrecioUnitario.Text = ""
            ComprobarDatos = False
            FrmAviso.LbMensaje.Text = "ESPECÍFICA EL PRECIO UNITARIO CORRECTAMENTE"
            FrmAviso.Show()
        Else
            If Val(TxtCantidad.Text) > 1000 Then
                'TxtCantidad.Text = ""
                FrmAviso.LbMensaje.Text = "NO SE PUEDE UNA CANTIDAD MAYOR A 1000 PIEZAS/ARTÍCULOS"
                FrmAviso.Show()
            ElseIf Val(TxtPrecioUnitario.Text) > 9999999 Then
                FrmAviso.LbMensaje.Text = "PRECIO UNITARIO EXCEDIDO, NO PUEDE SUPERAR LOS $9,999,999.00"
                FrmAviso.Show()
            Else
                ComprobarDatos = True
            End If
        End If
    End Function

    'Funcion que consulta todos los cargos extra a un folio en especifico
    Public Function ConsultaCargosExtraTodo() As Object
        strSql = "SELECT id_cargo_extra AS ""ID CARGO EXTRA"", id_folio AS ""ID FOLIO"", fecha_hora AS ""FECHA"", concepto AS ""CONCEPTO"",
                    numero_habitacion AS ""NÚMERO DE HABITACIÓN"", cantidad AS ""CANTIDAD"",  precio_unitario AS ""PRECIO UNITARIO $"", precio_total AS ""PRECIO TOTAL $""
                    FROM Cargo_extra
                    WHERE id_folio = " & idFolio & " 
                    ORDER BY fecha_hora DESC"

        ConsultaCargosExtraTodo = xCnx.objetoDataAdapter(strSql)
    End Function

    'Funcion que consulta todos los cargos extra a un folio en especifico
    Public Function ConsultaCargosExtraHabitacion() As Object
        strSql = "SELECT id_cargo_extra AS ""ID CARGO EXTRA"", id_folio AS ""ID FOLIO"", fecha_hora AS ""FECHA"", concepto AS ""CONCEPTO"",
                    numero_habitacion AS ""NÚMERO DE HABITACIÓN"", cantidad AS ""CANTIDAD"",  precio_unitario AS ""PRECIO UNITARIO $"", precio_total AS ""PRECIO TOTAL $""
                    FROM Cargo_extra
                    WHERE id_folio = " & idFolio & "
                    AND numero_habitacion = " & numeroHabitacion & "
                    ORDER BY fecha_hora DESC"

        ConsultaCargosExtraHabitacion = xCnx.objetoDataAdapter(strSql)
    End Function

    'Método que llena el DGV de cargos todos
    Public Sub PoblarDataGridCargosExtraTodo(ByVal DGVCargosExtra As DataGridView)
        'Llama a la función ConsultacargosExtra para llenar el DGV
        DGVCargosExtra.DataSource = ConsultaCargosExtraTodo()
        'Ocultar columna de ID
        DGVCargosExtra.Columns(0).Visible = False
        DGVCargosExtra.Columns(1).Visible = False
        'DGVCargosExtra.Columns(2).Visible = False
        DGVCargosExtra.Refresh()
        'Cambiar la anchura de una columna de la tabla del DGV
        'DGUsuarios.Columns.Item(4).Width = 240

    End Sub

    ''Método para poblar el ComboBox de numero habitacion
    'Public Sub PoblarComboHabitacion()
    '    Dim xDT As New DataTable
    '    Dim conector = New OracleDataAdapter

    '    strSql = "SELECT numero_habitacion 
    '                FROM Reservacion_has_habitacion 
    '                WHERE id_reservacion = " & idFolio & "
    '                AND estado_reservacion <> 'Cancelada'"
    '    conector = New OracleDataAdapter(strSql, cnx)

    '    conector.Fill(xDT)
    '    With CBNumHabitacion
    '        .DataSource = xDT
    '        .DisplayMember = "id_reservacion"
    '        .ValueMember = "numero_habitacion"
    '    End With
    'End Sub

    'Método que llena el DGV de cargos habitacion
    Public Sub PoblarDataGridCargosExtraHab(ByVal DGVCargosExtra As DataGridView)
        'Llama a la función ConsultacargosExtra para llenar el DGV
        DGVCargosExtra.DataSource = ConsultaCargosExtraHabitacion()
        'Ocultar columna de ID
        DGVCargosExtra.Columns(0).Visible = False
        DGVCargosExtra.Columns(1).Visible = False
        'DGVCargosExtra.Columns(2).Visible = False
        DGVCargosExtra.Refresh()
        'Cambiar la anchura de una columna de la tabla del DGV
        'DGUsuarios.Columns.Item(4).Width = 240

    End Sub

    Public Sub CargarDGVCargoTodo()
        'Actualizar DGV
        PoblarDataGridCargosExtraTodo(DGVCargoExtra)
    End Sub

    Public Sub CargarDGVCargoHab()
        'Actualizar DGV
        PoblarDataGridCargosExtraHab(DGVCargoExtra)
    End Sub

    Public Sub ActualizarFolioAbierto()
        If BuscarFormularioActivo("FrmAdministracionFolio") Then
            FrmAdministracionFolio.ConsultaHabLigadasAFolio()
            FrmAdministracionFolio.folio.CantidadTotalHabitaciones()
            FrmAdministracionFolio.folio.CantidadTotalCargosExtra()
            FrmAdministracionFolio.AsignarCantidadALabel()
            FrmAdministracionFolio.ConsultaCargosExtraHabitacion()
            FrmAdministracionFolio.EstadoCuenta()
        End If
    End Sub

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        Try
            If ComprobarDatos() Then
                'Instanciar el objeto
                Dim cargo As New CargoExtra(idCargoExtra, idFolio, TxtConceptoCargoExtra.Text, TxtCantidad.Text, TxtPrecioUnitario.Text, TxtPrecioTotal.Text, TxtNumHab.Text)
                If cargo.ConsultaUnCargoExtra() Then
                    'Si el cargo se encuentra registrado, se modifica la información
                    cargo.ActualizaCargoExtra()
                    FrmCorrecto.LbMensaje.Text = "CARGO EXTRA MODIFICADO CORRECTAMENTE"
                    FrmCorrecto.Show()

                    'Actualizar DGV
                    PoblarDataGridCargosExtraHab(DGVCargoExtra)
                    'Actualiar foli abierto
                    ActualizarFolioAbierto()
                    'Limpiamos caja de texto
                    'Call BtnLimpiar_Click(sender, e)
                Else
                    'Si el CARGO NO está registrado, lo inserta como uno nuevO
                    cargo.InsertaCargoExtra()
                    FrmCorrecto.LbMensaje.Text = "REGISTRADO CORRECTAMENTE"
                    FrmCorrecto.Show()
                    'Actualizar DGV
                    PoblarDataGridCargosExtraHab(DGVCargoExtra)
                    'Actualiar foli abierto
                    ActualizarFolioAbierto()
                    'Limpiamos caja de texto
                    Call BtnLimpiar_Click(sender, e)

                End If
            End If
        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            If ComprobarDatos() Then
                'Instanciar el objeto
                'Dim cargo As New CargoExtra(idCargoExtra, idFolio, TxtConceptoCargoExtra.Text, TxtPrecioUnitario.Text, TxtCantidad.Text, TxtPrecioTotal.Text)
                cargo.GetSetIdCargoExtra = idCargoExtra
                If cargo.ConsultaUnCargoExtra() Then
                    'Sí ningún usuario depende del rol se pide confirmar la acción de borrado
                    If MessageBox.Show("¿ESTÁ SEGURO DE QUE QUIERE BORRAR EL CARGO?", "CONFIRMAR", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                        'Llamamos al método que elimina el registro
                        cargo.EliminarCargoExtra()
                        FrmCorrecto.LbMensaje.Text = "CARGO ELIMINADO CORRECTAMENTE!"
                        FrmCorrecto.Show()
                        'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
                        PoblarDataGridCargosExtraHab(DGVCargoExtra)
                        'Actualiar foli abierto
                        ActualizarFolioAbierto()
                        'Limpiamos caja de texto
                        Call BtnLimpiar_Click(sender, e)
                    Else

                    End If
                End If
            Else
                FrmAviso.LbMensaje.Text = "NO EXISTE EL CARGO"
                FrmAviso.Show()
            End If
        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Close()
        'Limpiamos caja de texto
        Call BtnLimpiar_Click(sender, e)
    End Sub

    Private Sub FechaHora_Tick(sender As Object, e As EventArgs) Handles FechaHora.Tick
        LbHora.Text = DateTime.Now.ToString("hh:mm:ss")
        LbFecha.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub BtnPantallaFolios_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoFolio.Show()
        Me.Close()
        FrmSeleccionarFolio.Close()
    End Sub

    Private Sub BtnPantallaReservaciones_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoReservaciones.Show()
        Me.Close()
        FrmSeleccionarFolio.Close()
    End Sub

    Private Sub BtnPantallaInicio_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmMenuPrincipal.Show()
        Me.Close()
        FrmSeleccionarFolio.Close()
    End Sub

    Private Sub BtnPantallaUsuarios_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        If ModuloGlobal.nombreRol = "Administrador" Or ModuloGlobal.nombreRol = "Encargado" Or ModuloGlobal.modoSuperUsuario = True Then
            FrmListadoUsuarios.Show()
            Me.Close()
            FrmSeleccionarFolio.Close()
        Else
            FrmAutorizacion.Formulario(FrmListadoUsuarios, Nothing, Me)
            FrmAutorizacion.Show()
            FrmSeleccionarFolio.Close()
        End If
    End Sub

    Private Sub BtnPantallaHabitaciones_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoHabitaciones.Show()
        Me.Close()
        FrmSeleccionarFolio.Close()
    End Sub

    Private Sub BtnPantallaClientes_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoClientes.Show()
        Me.Close()
        FrmSeleccionarFolio.Close()
    End Sub

    Private Sub DateTimeCargoExtra_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnMostrarDeTodas_Click(sender As Object, e As EventArgs) Handles BtnMostrarDeTodas.Click
        FrmCargando.MostarConTiempoEnCargar(400)
        TxtNumHab.Text = "Todo"
        CargarDGVCargoTodo()
        BtnRegistrar.Enabled = False
        BtnEliminar.Enabled = False
    End Sub

    Private Sub TxtCantidad_TextChanged(sender As Object, e As EventArgs) Handles TxtCantidad.TextChanged
        If TxtPrecioTotal.Text <> "" Then
            TxtPrecioTotal.Text = Val(TxtPrecioUnitario.Text) * Val(TxtCantidad.Text)
        End If
    End Sub

    Private Sub TxtPrecioUnitario_TextChanged(sender As Object, e As EventArgs) Handles TxtPrecioUnitario.TextChanged
        'Dim cantidad As Integer = Val(TxtCantidad.Text)
        'Dim PrecioUnitario As Double = Val(TxtPrecioUnitario.Text)
        'Dim precioTotal As Double = cantidad * PrecioUnitario
        'TxtPrecioTotal.Text = precioTotal
        If TxtPrecioUnitario.Text <> "" Then
            TxtPrecioTotal.Text = Val(TxtPrecioUnitario.Text) * Val(TxtCantidad.Text)
        End If
    End Sub

    Private Sub TxtConceptoCargoExtra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtConceptoCargoExtra.KeyPress
        SoloLetrasYNumerosSinApostrofe(e)
    End Sub

    Private Sub TxtPrecioUnitario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPrecioUnitario.KeyPress
        SoloNumeroYDecimal(TxtPrecioUnitario, e)
    End Sub

    Private Sub TxtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCantidad.KeyPress
        SoloNumero(e)
    End Sub

    Private Sub TxtPrecioTotal_TextChanged(sender As Object, e As EventArgs) Handles TxtPrecioTotal.TextChanged

    End Sub

    Private Sub TimerOcultar_Tick(sender As Object, e As EventArgs) Handles TimerOcultar.Tick
        If TimerOcultar.Interval = 8000 Then
            PBAlt.Visible = False
            LabelAlt.Visible = False
        End If
    End Sub

    Private Sub FrmCargoExtra_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnRegistrar.PerformClick()
        End If
    End Sub

    Private Sub BtnCerrarSesion_Click(sender As Object, e As EventArgs)
        FrmCerrarSesion.LbMensaje.Text = "¿Estás seguro/a de cerrar sesión " & nombreUsuario & "?"
        FrmCerrarSesion.Show()
    End Sub

    Private Sub CerrarVentanasCascada()
        FrmSeleccionarFolio.Close()
    End Sub

    Private Sub FrmCargoExtra_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If abiertoDesde = "AdminFolio" Then
            FrmAdministracionFolio.Show()
        ElseIf abiertoDesde = "MenuPrincipal" Then
            FrmMenuPrincipal.Show()
        End If
        CerrarVentanasCascada()
        abiertoDesde = ""
    End Sub

    'Private Sub CBNumHabitacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBNumHabitacion.SelectedIndexChanged

    'End Sub

    'Private Sub CBNumHabitacion_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CBNumHabitacion.SelectionChangeCommitted
    '    numeroHabitacion = Val(CBNumHabitacion.Text)
    '    ConsultaCargosExtraHabitacion()
    'End Sub

    'Private Sub TxtPrecioUnitario_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtPrecioUnitario.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        BtnRegistrar.PerformClick()
    '    End If
    'End Sub

    'Private Sub TxtCantidad_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtCantidad.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        BtnRegistrar.PerformClick()
    '    End If
    'End Sub

    'Private Sub TxtConceptoCargoExtra_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtConceptoCargoExtra.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        BtnRegistrar.PerformClick()
    '    End If
    'End Sub
End Class