<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NuevoJToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FacilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MedioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DificilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InstruccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(463, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoJToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'NuevoJToolStripMenuItem
        '
        Me.NuevoJToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacilToolStripMenuItem, Me.MedioToolStripMenuItem, Me.DificilToolStripMenuItem})
        Me.NuevoJToolStripMenuItem.Name = "NuevoJToolStripMenuItem"
        Me.NuevoJToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.NuevoJToolStripMenuItem.Text = "Nuevo Juego"
        '
        'FacilToolStripMenuItem
        '
        Me.FacilToolStripMenuItem.Name = "FacilToolStripMenuItem"
        Me.FacilToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.FacilToolStripMenuItem.Text = "Facil"
        '
        'MedioToolStripMenuItem
        '
        Me.MedioToolStripMenuItem.Name = "MedioToolStripMenuItem"
        Me.MedioToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.MedioToolStripMenuItem.Text = "Medio"
        '
        'DificilToolStripMenuItem
        '
        Me.DificilToolStripMenuItem.Name = "DificilToolStripMenuItem"
        Me.DificilToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.DificilToolStripMenuItem.Text = "Dificil"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InstruccionesToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'InstruccionesToolStripMenuItem
        '
        Me.InstruccionesToolStripMenuItem.Name = "InstruccionesToolStripMenuItem"
        Me.InstruccionesToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.InstruccionesToolStripMenuItem.Text = "Instrucciones"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 412)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoJToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InstruccionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MedioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DificilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
