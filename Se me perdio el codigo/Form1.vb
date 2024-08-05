Imports Se_me_perdio_el_codigo.Fuente_de_sodasDataSetTableAdapters

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Compra As New Punto(Tbx_Nombre.Text, Tbx_Apellido.Text, Tbx_Cedula.Text, Tbx_Fecha.Text, cb_nombre_item.Text, Tbx_item.Text)
        'mostramos la factura a travez de un message box usando vbCrLf para dar saltos de linea y "  " para dar espacios entre palabras
        MessageBox.Show("--------------------------------------------" & vbCrLf & Compra.Fecha & vbCrLf & "--------------------------------------------" & vbCrLf & Compra.Nombre & " " & Compra.Apellido & vbCrLf & "--------------------------------------------" & vbCrLf & Compra.NombreProducto & "-------------------------" & Compra.PrecioItem & vbCrLf & "--------------------------------------------" & vbCrLf & "Total:" & "                                        " & Compra.PrecioItem & vbCrLf & "--------------------------------------------")
    End Sub
    Private Sub Fuente_de_sodaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Fuente_de_sodaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Fuente_de_sodaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Fuente_de_sodasDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Fuente_de_sodasDataSet.Fuente_de_soda' Puede moverla o quitarla según sea necesario.
        Me.Fuente_de_sodaTableAdapter.Fill(Fuente_de_sodasDataSet.Fuente_de_soda)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Fuente_de_sodaTableAdapter.recordset.Update
    End Sub
End Class
