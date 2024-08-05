<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Tbx_Nombre = New System.Windows.Forms.TextBox()
        Me.Tbx_Apellido = New System.Windows.Forms.TextBox()
        Me.Tbx_Cedula = New System.Windows.Forms.TextBox()
        Me.Tbx_item = New System.Windows.Forms.TextBox()
        Me.Tbx_Fecha = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cb_nombre_item = New System.Windows.Forms.ComboBox()
        Me.Fuente_de_sodasDataSet = New Se_me_perdio_el_codigo.Fuente_de_sodasDataSet()
        Me.Fuente_de_sodaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Fuente_de_sodaTableAdapter = New Se_me_perdio_el_codigo.Fuente_de_sodasDataSetTableAdapters.Fuente_de_sodaTableAdapter()
        Me.TableAdapterManager = New Se_me_perdio_el_codigo.Fuente_de_sodasDataSetTableAdapters.TableAdapterManager()
        Me.Fuente_de_sodaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Fuente_de_sodaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FuenteDeSodaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.Fuente_de_sodasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fuente_de_sodaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fuente_de_sodaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Fuente_de_sodaBindingNavigator.SuspendLayout()
        CType(Me.FuenteDeSodaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TIENDA R:C"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 353)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cedula"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(306, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Producto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(319, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Precio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(543, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Fecha"
        '
        'Tbx_Nombre
        '
        Me.Tbx_Nombre.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.Fuente_de_sodaBindingSource, "Nombre", True))
        Me.Tbx_Nombre.Location = New System.Drawing.Point(110, 116)
        Me.Tbx_Nombre.Multiline = True
        Me.Tbx_Nombre.Name = "Tbx_Nombre"
        Me.Tbx_Nombre.Size = New System.Drawing.Size(147, 25)
        Me.Tbx_Nombre.TabIndex = 8
        '
        'Tbx_Apellido
        '
        Me.Tbx_Apellido.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.Fuente_de_sodaBindingSource, "Apellido", True))
        Me.Tbx_Apellido.Location = New System.Drawing.Point(122, 233)
        Me.Tbx_Apellido.Multiline = True
        Me.Tbx_Apellido.Name = "Tbx_Apellido"
        Me.Tbx_Apellido.Size = New System.Drawing.Size(147, 25)
        Me.Tbx_Apellido.TabIndex = 9
        '
        'Tbx_Cedula
        '
        Me.Tbx_Cedula.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.Fuente_de_sodaBindingSource, "Cedula", True))
        Me.Tbx_Cedula.Location = New System.Drawing.Point(110, 350)
        Me.Tbx_Cedula.Multiline = True
        Me.Tbx_Cedula.Name = "Tbx_Cedula"
        Me.Tbx_Cedula.Size = New System.Drawing.Size(147, 25)
        Me.Tbx_Cedula.TabIndex = 10
        '
        'Tbx_item
        '
        Me.Tbx_item.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.Fuente_de_sodaBindingSource, "Precio", True))
        Me.Tbx_item.Location = New System.Drawing.Point(396, 230)
        Me.Tbx_item.Multiline = True
        Me.Tbx_item.Name = "Tbx_item"
        Me.Tbx_item.Size = New System.Drawing.Size(147, 25)
        Me.Tbx_item.TabIndex = 12
        '
        'Tbx_Fecha
        '
        Me.Tbx_Fecha.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.Fuente_de_sodaBindingSource, "Fecha", True))
        Me.Tbx_Fecha.Location = New System.Drawing.Point(607, 28)
        Me.Tbx_Fecha.Multiline = True
        Me.Tbx_Fecha.Name = "Tbx_Fecha"
        Me.Tbx_Fecha.Size = New System.Drawing.Size(147, 25)
        Me.Tbx_Fecha.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(404, 347)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 26)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cb_nombre_item
        '
        Me.cb_nombre_item.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.Fuente_de_sodaBindingSource, "Producto", True))
        Me.cb_nombre_item.FormattingEnabled = True
        Me.cb_nombre_item.Location = New System.Drawing.Point(397, 115)
        Me.cb_nombre_item.Name = "cb_nombre_item"
        Me.cb_nombre_item.Size = New System.Drawing.Size(146, 24)
        Me.cb_nombre_item.TabIndex = 15
        '
        'Fuente_de_sodasDataSet
        '
        Me.Fuente_de_sodasDataSet.DataSetName = "Fuente_de_sodasDataSet"
        Me.Fuente_de_sodasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Fuente_de_sodaBindingSource
        '
        Me.Fuente_de_sodaBindingSource.DataMember = "Fuente de soda"
        Me.Fuente_de_sodaBindingSource.DataSource = Me.Fuente_de_sodasDataSet
        '
        'Fuente_de_sodaTableAdapter
        '
        Me.Fuente_de_sodaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Fuente_de_sodaTableAdapter = Me.Fuente_de_sodaTableAdapter
        Me.TableAdapterManager.UpdateOrder = Se_me_perdio_el_codigo.Fuente_de_sodasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Fuente_de_sodaBindingNavigator
        '
        Me.Fuente_de_sodaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Fuente_de_sodaBindingNavigator.BindingSource = Me.Fuente_de_sodaBindingSource
        Me.Fuente_de_sodaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Fuente_de_sodaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Fuente_de_sodaBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Fuente_de_sodaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Fuente_de_sodaBindingNavigatorSaveItem, Me.ToolStripTextBox1})
        Me.Fuente_de_sodaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Fuente_de_sodaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Fuente_de_sodaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Fuente_de_sodaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Fuente_de_sodaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Fuente_de_sodaBindingNavigator.Name = "Fuente_de_sodaBindingNavigator"
        Me.Fuente_de_sodaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Fuente_de_sodaBindingNavigator.Size = New System.Drawing.Size(934, 27)
        Me.Fuente_de_sodaBindingNavigator.TabIndex = 16
        Me.Fuente_de_sodaBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 28)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'Fuente_de_sodaBindingNavigatorSaveItem
        '
        Me.Fuente_de_sodaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Fuente_de_sodaBindingNavigatorSaveItem.Image = CType(resources.GetObject("Fuente_de_sodaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Fuente_de_sodaBindingNavigatorSaveItem.Name = "Fuente_de_sodaBindingNavigatorSaveItem"
        Me.Fuente_de_sodaBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 28)
        Me.Fuente_de_sodaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'FuenteDeSodaBindingSource
        '
        Me.FuenteDeSodaBindingSource.DataMember = "Fuente de soda"
        Me.FuenteDeSodaBindingSource.DataSource = Me.Fuente_de_sodasDataSet
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 31)
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(412, 421)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(135, 40)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(934, 514)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Fuente_de_sodaBindingNavigator)
        Me.Controls.Add(Me.cb_nombre_item)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Tbx_Fecha)
        Me.Controls.Add(Me.Tbx_item)
        Me.Controls.Add(Me.Tbx_Cedula)
        Me.Controls.Add(Me.Tbx_Apellido)
        Me.Controls.Add(Me.Tbx_Nombre)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Ayuda dios"
        CType(Me.Fuente_de_sodasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fuente_de_sodaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fuente_de_sodaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Fuente_de_sodaBindingNavigator.ResumeLayout(False)
        Me.Fuente_de_sodaBindingNavigator.PerformLayout()
        CType(Me.FuenteDeSodaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Tbx_Nombre As TextBox
    Friend WithEvents Tbx_Apellido As TextBox
    Friend WithEvents Tbx_Cedula As TextBox
    Friend WithEvents Tbx_item As TextBox
    Friend WithEvents Tbx_Fecha As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents cb_nombre_item As ComboBox
    Friend WithEvents Fuente_de_sodasDataSet As Fuente_de_sodasDataSet
    Friend WithEvents Fuente_de_sodaBindingSource As BindingSource
    Friend WithEvents Fuente_de_sodaTableAdapter As Fuente_de_sodasDataSetTableAdapters.Fuente_de_sodaTableAdapter
    Friend WithEvents TableAdapterManager As Fuente_de_sodasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Fuente_de_sodaBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Fuente_de_sodaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents FuenteDeSodaBindingSource As BindingSource
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents Button2 As Button
End Class
