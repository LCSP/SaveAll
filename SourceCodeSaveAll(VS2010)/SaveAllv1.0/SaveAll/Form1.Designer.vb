<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Form))
        Me.icon_notif = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.menu_tray = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Pestañas = New System.Windows.Forms.TabControl()
        Me.tab_texto = New System.Windows.Forms.TabPage()
        Me.btn_guardar_txt = New System.Windows.Forms.Button()
        Me.txt_rich = New System.Windows.Forms.RichTextBox()
        Me.tab_img = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_limpiarClip = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lst_archivosImg = New System.Windows.Forms.ListView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pb_img = New System.Windows.Forms.PictureBox()
        Me.save_dialog = New System.Windows.Forms.SaveFileDialog()
        Me.menu_tray.SuspendLayout()
        Me.Pestañas.SuspendLayout()
        Me.tab_texto.SuspendLayout()
        Me.tab_img.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pb_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'icon_notif
        '
        Me.icon_notif.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.icon_notif.ContextMenuStrip = Me.menu_tray
        Me.icon_notif.Icon = CType(resources.GetObject("icon_notif.Icon"), System.Drawing.Icon)
        Me.icon_notif.Text = "SaveAll"
        Me.icon_notif.Visible = True
        '
        'menu_tray
        '
        Me.menu_tray.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.menu_tray.Name = "menu_tray"
        Me.menu_tray.Size = New System.Drawing.Size(101, 48)
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Timer1
        '
        '
        'Pestañas
        '
        Me.Pestañas.Controls.Add(Me.tab_texto)
        Me.Pestañas.Controls.Add(Me.tab_img)
        Me.Pestañas.Location = New System.Drawing.Point(0, 1)
        Me.Pestañas.Name = "Pestañas"
        Me.Pestañas.SelectedIndex = 0
        Me.Pestañas.Size = New System.Drawing.Size(921, 656)
        Me.Pestañas.TabIndex = 0
        '
        'tab_texto
        '
        Me.tab_texto.Controls.Add(Me.btn_guardar_txt)
        Me.tab_texto.Controls.Add(Me.txt_rich)
        Me.tab_texto.Location = New System.Drawing.Point(4, 22)
        Me.tab_texto.Name = "tab_texto"
        Me.tab_texto.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_texto.Size = New System.Drawing.Size(913, 630)
        Me.tab_texto.TabIndex = 0
        Me.tab_texto.Text = "Texto"
        Me.tab_texto.UseVisualStyleBackColor = True
        '
        'btn_guardar_txt
        '
        Me.btn_guardar_txt.Location = New System.Drawing.Point(378, 52)
        Me.btn_guardar_txt.Name = "btn_guardar_txt"
        Me.btn_guardar_txt.Size = New System.Drawing.Size(153, 23)
        Me.btn_guardar_txt.TabIndex = 1
        Me.btn_guardar_txt.Text = "Guardar Texto"
        Me.btn_guardar_txt.UseVisualStyleBackColor = True
        '
        'txt_rich
        '
        Me.txt_rich.Location = New System.Drawing.Point(3, 130)
        Me.txt_rich.Name = "txt_rich"
        Me.txt_rich.Size = New System.Drawing.Size(907, 497)
        Me.txt_rich.TabIndex = 0
        Me.txt_rich.Text = "Texto Guardado:"
        '
        'tab_img
        '
        Me.tab_img.Controls.Add(Me.GroupBox3)
        Me.tab_img.Controls.Add(Me.GroupBox2)
        Me.tab_img.Controls.Add(Me.GroupBox1)
        Me.tab_img.Location = New System.Drawing.Point(4, 22)
        Me.tab_img.Name = "tab_img"
        Me.tab_img.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_img.Size = New System.Drawing.Size(913, 630)
        Me.tab_img.TabIndex = 1
        Me.tab_img.Text = "Imagenes"
        Me.tab_img.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.btn_limpiarClip)
        Me.GroupBox3.Location = New System.Drawing.Point(339, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(564, 216)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Acciones"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(176, 109)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(242, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Abrir carpeta de imagenes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_limpiarClip
        '
        Me.btn_limpiarClip.Location = New System.Drawing.Point(176, 80)
        Me.btn_limpiarClip.Name = "btn_limpiarClip"
        Me.btn_limpiarClip.Size = New System.Drawing.Size(242, 23)
        Me.btn_limpiarClip.TabIndex = 5
        Me.btn_limpiarClip.Text = "Limpiar Portapapeles"
        Me.btn_limpiarClip.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lst_archivosImg)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 228)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(898, 396)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Imagenes Guardadas"
        '
        'lst_archivosImg
        '
        Me.lst_archivosImg.Location = New System.Drawing.Point(6, 19)
        Me.lst_archivosImg.Name = "lst_archivosImg"
        Me.lst_archivosImg.Size = New System.Drawing.Size(886, 371)
        Me.lst_archivosImg.TabIndex = 3
        Me.lst_archivosImg.UseCompatibleStateImageBehavior = False
        Me.lst_archivosImg.View = System.Windows.Forms.View.List
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pb_img)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(327, 216)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vista Previa"
        '
        'pb_img
        '
        Me.pb_img.Location = New System.Drawing.Point(6, 19)
        Me.pb_img.Name = "pb_img"
        Me.pb_img.Size = New System.Drawing.Size(314, 187)
        Me.pb_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pb_img.TabIndex = 0
        Me.pb_img.TabStop = False
        '
        'save_dialog
        '
        Me.save_dialog.InitialDirectory = "Imagenes"
        '
        'Main_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 657)
        Me.Controls.Add(Me.Pestañas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SaveAll"
        Me.menu_tray.ResumeLayout(False)
        Me.Pestañas.ResumeLayout(False)
        Me.tab_texto.ResumeLayout(False)
        Me.tab_img.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.pb_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents icon_notif As System.Windows.Forms.NotifyIcon
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Pestañas As System.Windows.Forms.TabControl
    Friend WithEvents tab_texto As System.Windows.Forms.TabPage
    Friend WithEvents tab_img As System.Windows.Forms.TabPage
    Friend WithEvents txt_rich As System.Windows.Forms.RichTextBox
    Friend WithEvents btn_guardar_txt As System.Windows.Forms.Button
    Friend WithEvents pb_img As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lst_archivosImg As System.Windows.Forms.ListView
    Friend WithEvents save_dialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btn_limpiarClip As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents menu_tray As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
