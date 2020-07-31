Imports System.ComponentModel
Public Class detalleVentas



    Dim DataT As DataTable
        Dim conexion As Conexion = New Conexion()
        Dim idanterior As Integer

        Public sumatotal As Integer
        Public restarsuma As Integer

        Private Sub detalleproducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            conexion.conectar()
            idnuevo()
            mostrarServicios()
            mostrarProductos()


        End Sub
        Public Sub mostrarServicios()
            conexion.consulta("select id as 'Codigo', tiposervicio as 'Tipo del Servicio', nombre as 'Nombre',precio as 'Precio', estado as 'Estado' from  servicios
", "servicios")

            DataGridView3.DataSource = conexion.ds.Tables("servicios")

        End Sub
        Public Sub mostrarProductos()
            conexion.consulta("select id as Id ,codigobarra as 'codigo de barra',[tipoproducto] as 'tipo de Producto',[nombre] as 'Nombre',  [precioventa] as 'precio de venta' ,[cantidad] as 'cantidad disponible' ,[caracteristica] as 'Caracteristica' from  productos
", "productos")

            DataGridView1.DataSource = conexion.ds.Tables("productos")

        End Sub
        Private Sub idnuevo()

            ' If conexion.retornarventa() Then

            'txtidventa.Text = conexion.retornarventa()


            'Else
            'MessageBox.Show("error")
            'End If

            For i = 0 To 5 Step 1
                Select Case i
                    Case 0
                        txtidventa.Text = conexion.retornarventa(0)
                    Case 1
                        txtidcliente.Text = conexion.retornarventa(1)
                    Case 2
                        txtnombrecliente.Text = conexion.retornarventa(2)
                    Case 3
                        txt1.Text = conexion.retornarventa(3)
                    Case 4
                        txtdocumento.Text = conexion.retornarventa(4)
                    Case 5
                        txtnumerodoc.Text = conexion.retornarventa(5)

                End Select
            Next
        End Sub

        Function idnuevodetalle()

            If conexion.retornarIddetalleproducto() = 0 Then
                idanterior = 1


            Else
                idanterior = conexion.retornarIddetalleproducto() + 1
                Return idanterior
            End If
        End Function
        Private Sub insertardetalle()
            Dim id As Integer, idventa As String, idproducto As String, cantidad As Integer, precio As Decimal, suma As Integer

            id = idnuevodetalle()
            idventa = txtidventa.Text
            idproducto = txtnombrecliente.Text
            cantidad = txtcantllevar.Text
            precio = txtprecio.Text

            Try
                If conexion.agregardetalle(id, idventa, idproducto, cantidad, precio) Then
                    MessageBox.Show("Guardado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    idnuevo()
                    modificarstock()
                    suma = cantidad * precio
                    sumatotal = suma + sumatotal

                    txttotal.Text = sumatotal
                    txtidproducto.Clear()
                    txtnombreproducto.Clear()
                    txtprecio.Clear()
                    txtsctok.Clear()
                    txtcantllevar.Clear()

                    cantidad = txtcantllevar.Text
                    precio = txtprecio.Text

                Else
                    MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    conexion.conexion.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            buscarProductosdetalle()
        End Sub
        Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

        End Sub

        Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
            Dim dgv As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            txtidproducto.Text = dgv.Cells(0).Value.ToString()
            txtnombreproducto.Text = dgv.Cells(3).Value.ToString()
            txtprecio.Text = dgv.Cells(4).Value.ToString()
            txtsctok.Text = dgv.Cells(5).Value.ToString()
            txtprecio.Text = dgv.Cells(4).Value.ToString()

        End Sub

        Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

        End Sub
        Private Sub BuscarProducto()
            Dim nombreproducto As String
            nombreproducto = txtbuscar.Text

            Try


                DataT = conexion.BuscarDetalleProducto(nombreproducto)

                If DataT.Rows.Count <> 0 Then

                    DataGridView1.DataSource = DataT

                Else
                    MessageBox.Show("Usuario no encontrado", "Buscando", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    DataGridView1.DataSource = Nothing
                    txtbuscar.Text = " "
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
        Private Sub Buscarservicio()
            Dim nombreservice As String
            nombreservice = txtlookservice.Text

            Try


                DataT = conexion.buscarservicedet(nombreservice)

                If DataT.Rows.Count <> 0 Then

                    DataGridView3.DataSource = DataT

                Else
                    MessageBox.Show("Servicio  no encontrado", "Buscando", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    DataGridView3.DataSource = Nothing
                    txtbuscar.Text = " "
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
        Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
            BuscarProducto()
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Dim suma As Integer
            Dim cantidad As Integer
            Dim precio As Integer

            cantidad = Val(txtcantllevar.Text)
            precio = Val(txtprecio.Text)
            If Len(txtsctok.Text) = 0 Then
                suma = cantidad * precio
                sumatotal = suma + sumatotal

                txttotal.Text = sumatotal
                insertardetalle()
            ElseIf Len(txtsctok.Text) <> 0 Then
                stockproductos()


            End If



        End Sub
        Public Sub stockproductos()
            Dim stock As Integer
            Dim cantidadllevar As Integer

            If cantidadllevar > stock Then
                MessageBox.Show("Su cantidad a llevar es mayor a la que existe en el Stock", "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtcantllevar.Text = ""
            Else

                insertardetalle()


            End If

        End Sub


        Private Sub modificarstock()


            Dim stock As Integer
            Dim cantidadllevar As Integer

            Dim stockintermediario As Integer
            Dim id As Integer
            id = txtidproducto.Text
            stock = txtsctok.Text
            cantidadllevar = txtcantllevar.Text
            stockintermediario = stock - cantidadllevar



            Try
                If (conexion.modificardetalleProducto(id, stockintermediario)) Then
                    MsgBox("Modificado correctamente")
                    ' conexion.conexion.Close()
                    mostrarProductos()

                Else
                    MsgBox("Error al modificar producto")
                    ' conexion.conexion.Close()

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                mostrarProductos()
            End Try
            mostrarProductos()

        End Sub


        Private Sub buscarProductosdetalle()
            Dim idventa As Integer
            idventa = txtidventa.Text

            Try


                DataT = conexion.selectdeproductos(idventa)

                If DataT.Rows.Count <> 0 Then

                    DataGridView2.DataSource = DataT

                Else
                    MessageBox.Show("YA no hay productos", "Buscando", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    DataGridView2.DataSource = Nothing
                    txtbuscar.Text = ""
                    txttotal.Text = ""
                    sumatotal = 0
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub


        Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
            Dim dgv As DataGridViewRow = DataGridView2.Rows(e.RowIndex)

            txtnombreproducto.Text = dgv.Cells(0).Value.ToString()
            txtcantllevar.Text = dgv.Cells(1).Value.ToString()
            txtprecio.Text = dgv.Cells(2).Value.ToString()
            restarsuma = dgv.Cells(3).Value

        End Sub

        Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
            Dim id As Integer
            Dim restarmientras As Integer
            Dim sumaactual As Integer

            sumaactual = Val(txttotal.Text)
            id = idnuevodetalle() - 1
            MsgBox(idnuevodetalle())

            Dim Pregunta As Integer

            Pregunta = MsgBox("Deseas Eliminar el producto del articulo ?", vbYesNoCancel + vbInformation, "Eliminar producto")

            Select Case Pregunta
                Case Is = 6

                    Try
                        If conexion.EliminardetalleProducto(id) Then
                            MsgBox("Se elimino")
                            restarmientras = sumaactual - restarsuma
                            txttotal.Text = restarmientras
                            buscarProductosdetalle()
                            sumarstock()
                            mostrarProductos()
                        End If
                    Catch ex As Exception

                    End Try
                Case Is = 7

                Case Else

            End Select
        End Sub

        Private Sub sumarstock()


            Dim stock As Integer
            Dim cantidadllevar As Integer
            Dim stockintermediario As Integer
            Dim id As Integer
            id = txtidproducto.Text
            stock = txtsctok.Text
            cantidadllevar = txtcantllevar.Text
            stockintermediario = stock + cantidadllevar



            Try
                If (conexion.modificardetalleProducto(id, stockintermediario)) Then
                    MsgBox("Modificado correctamente")
                    ' conexion.conexion.Close()
                    mostrarProductos()

                Else
                    MsgBox("Error al modificar producto")
                    ' conexion.conexion.Close()

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                mostrarProductos()
            End Try
            mostrarProductos()

        End Sub

        Private Sub ImpresionFactura_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles ImpresionFactura.PrintPage
            Dim fuente As System.Drawing.Font = New Font("consolas", 15)
            Dim topMargin As Double = e.MarginBounds.Top
            Dim yPos As Double = 120
            Dim count As Integer = 0
            Dim texto As String = ""
            Dim unidad As Byte = 0
            Dim detalle As String = ""
            Dim valor As String = ""
            Dim tabulacion As String = ""
            Dim compensador As Integer = 0
            Dim total As Decimal = 0
            Dim Lvalor As Integer
            Dim lineaTotal As String
            Dim totaltotal As String
            conexion.selectdeproductos(idnuevodetalle())

            'Dim printFont As System.Drawing.Font = New Font("consolas", 12)
            'For Each row As DataGridViewRow In conexion.tabladatosg.Rows
            '    detalle = row.Cells(0).Value : unidad = row.Cells(1).Value : valor = row.Cells(2).FormattedValue
            '    Lvalor = Len(row.Cells(2).FormattedValue.ToString)


            '    texto = detalle & "    " & unidad & tabulacion & StrDup(8 - Lvalor, " ") & valor 'Configura la linea
            '    yPos = 120 + topMargin + (count * printFont.GetHeight(e.Graphics)) ' Calcula la posición en la que se escribe la línea
            '    ' Imprime la línea con el objeto Graphics
            '    If Not row.IsNewRow Then
            '        e.Graphics.DrawString(texto, printFont, System.Drawing.Brushes.Black, 10, yPos)
            '        total += valor
            '    End If
            '    count += 1
            'Next
            'yPos += 10
            'e.Graphics.DrawString("                           _______", printFont, System.Drawing.Brushes.Black, 10, yPos)

            'Dim nombreEncargado As String = conexion.obtenerVariableCadena("select nombres from DATOS_PERSONAS where numeroIdentidad = '" & identidadPersonalEntro & "'", "nombres")
            'Dim datos(7) As Object
            'Dim cantRows As Integer = tablaDatosG.Rows.Count - 1
            'If tablaDatosG.Rows.Count > 0 Then
            '    For i As Integer = 0 To tablaDatosG.Columns.Count - 1
            '        datos(i) = tablaDatosG.Rows(cantRows)(i)
            '    Next
            'End If
            ' Imprime la cabecera

            Dim printFont As System.Drawing.Font = New Font("consolas", 12)
            e.Graphics.DrawString(("Salon De Belleza "), fuente, Brushes.Black, 100, 40)
            e.Graphics.DrawString(("Fecha De Compra :") & txt1.Text, printFont, Brushes.Black, 10, 60)
            e.Graphics.DrawString(("Nombre Cliente :") & txtnombrecliente.Text, printFont, Brushes.Black, 10, 80)
            e.Graphics.DrawString(("N.0 Factura :") & txtnumerodoc.Text, printFont, Brushes.Black, 10, 100)

            '' If conexion.tabladatosg.Rows.Count > 0 Then
            For i As Integer = 0 To conexion.tabladatosg.Rows.Count - 1


                Dim nombreProd As String = conexion.tabladatosg.Rows(i)(0).ToString

                Dim cantidad As String = conexion.tabladatosg.Rows(i)(1).ToString

                Dim precio As String = conexion.tabladatosg.Rows(i)(2).ToString

                Dim totalproducto As String = conexion.tabladatosg.Rows(i)(3).ToString




                e.Graphics.DrawString(nombreProd + "   " + cantidad + "    " + precio, printFont, System.Drawing.Brushes.Black, 10, yPos + 1)

                count = +1
                yPos += 15
            Next
            e.Graphics.DrawString(("Total :") & txttotal.Text, printFont, Brushes.Black, 10, yPos + 20)

            ''End If

            'e.Graphics.DrawString("Tiket N. 4", printFont, Brushes.Black, 10, 100)
            ''e.Graphics.DrawString("Fecha: " & Date.Now, printFont, Brushes.Black, 10, 120)
            'e.Graphics.DrawString("Articulos: 4", printFont, Brushes.Black, 10, 140)
            'e.Graphics.DrawString("Mesa N. 5", printFont, Brushes.Black, 10, 160)
            'e.Graphics.DrawString("---------------------------------", printFont, Brushes.Black, 10, 180)





            'For Each row As DataGridViewRow In DataGridView2.Rows
            '    unidad = row.Cells(0).Value : detalle = row.Cells(1).Value : valor = row.Cells(2).FormattedValue
            '    Lvalor = Len(row.Cells(2).FormattedValue.ToString)
            '    compensador = Len(row.Cells(1).Value)
            '    tabulacion = StrDup(22 - compensador, " ")

            '    texto = unidad & "    " & detalle & tabulacion & StrDup(8 - Lvalor, " ") & valor 'Configura la linea
            '    yPos = 120 + topMargin + (count * printFont.GetHeight(e.Graphics)) ' Calcula la posición en la que se escribe la línea
            '    ' Imprime la línea con el objeto Graphics
            '    If Not row.IsNewRow Then
            '        e.Graphics.DrawString(texto, printFont, System.Drawing.Brushes.Black, 10, yPos)
            '        total += valor
            '    End If
            '    count += 1
            'Next
            'yPos += 10
            'e.Graphics.DrawString("                           ___", printFont, System.Drawing.Brushes.Black, 10, yPos)
            'Dim XXX As Integer = 0
            'XXX = Len(total.ToString)
            'lineaTotal = StrDup(28 - XXX, ".")
            'yPos += 20
            'e.Graphics.DrawString("Total" & lineaTotal & total, printFont, System.Drawing.Brushes.Black, 10, yPos)
            'yPos += 30
            'e.Graphics.DrawString("Servido por: Hola", printFont, System.Drawing.Brushes.Black, 10, yPos)
            'e.Graphics.DrawString(("Coletilla"), printFont, Brushes.Black, 10, yPos + 20)
        End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ImpresionFactura.Print()
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

        End Sub

        Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        End Sub

        Private Sub DataGridView3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellClick
            Dim dgv As DataGridViewRow = DataGridView3.Rows(e.RowIndex)
            txtidproducto.Text = dgv.Cells(0).Value.ToString()
            txtnombreproducto.Text = dgv.Cells(2).Value.ToString()
            txtprecio.Text = dgv.Cells(3).Value.ToString()


        End Sub

        Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

        End Sub

        Private Sub txtlookservice_TextChanged(sender As Object, e As EventArgs) Handles txtlookservice.TextChanged
            Buscarservicio()
        End Sub

        Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

        End Sub

    Private Sub GroupBox2_Enter_1(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub GroupBox3_Enter_1(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class
