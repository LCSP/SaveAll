Public Class Main_Form

    'Sincronizador de teclas
    <System.Runtime.InteropServices.DllImport("user32.dll")> _
    Private Shared Function GetAsyncKeyState(ByVal vkey As System.Windows.Forms.Keys) As Short
    End Function
    'Load Form
    Private Sub Main_Form_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Interval = 100
        Randomize()
        For Each foundFile As String In My.Computer.FileSystem.GetFiles("Imagenes")
            lst_archivosImg.Items.Add(foundFile)
        Next

    End Sub
    'Timer para fuera de focus
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dim Help As Boolean
        Dim TXT As Boolean
        Dim IMG As Boolean
        Help = GetAsyncKeyState(Keys.F4)
        TXT = GetAsyncKeyState(Keys.F2)
        IMG = GetAsyncKeyState(Keys.F3)
        If TXT = True Then
            Action_text()
        End If

        If IMG = True Then
            Action_Image()
        End If

        If Help = True Then
            MsgBox("F2 par capturar texto del portapapeles" + vbCr + "F3 para capturar imagen del portapapeles" + vbCr + vbCr + vbCr + vbCr + "SaveAll By Lucio Carrera", MsgBoxStyle.Information, "SaveAll Help")
        End If

    End Sub
    'Limpiar portapapeles
    Private Sub btn_limpiarClip_Click(sender As System.Object, e As System.EventArgs) Handles btn_limpiarClip.Click
        My.Computer.Clipboard.Clear()
        icon_notif.BalloonTipIcon = ToolTipIcon.Info
        icon_notif.BalloonTipText = "Portapapeles Vacio"
        icon_notif.BalloonTipTitle = "SaveAll"
        My.Computer.Audio.Play("Sounds\mlg.wav")
        icon_notif.ShowBalloonTip(15)
    End Sub
    'abrir imagnes
    Private Sub lst_archivosImg_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lst_archivosImg.SelectedIndexChanged
        Dim dir_image As String
        Dim index = lst_archivosImg.FocusedItem.Index
        dir_image = lst_archivosImg.Items(index).Text
        If dir_image <> "" Then
            Dim lngLaunch As Long
            lngLaunch = Shell("rundll32.exe shell32.dll,OpenAs_RunDLL " + dir_image)

        End If
    End Sub
    'Abrir Carpeta imagenes
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            Process.Start("explorer.exe", "Imagenes")
        Catch ex As Exception

        End Try

    End Sub
    'Guardar Texto
    Private Sub btn_guardar_txt_Click(sender As System.Object, e As System.EventArgs) Handles btn_guardar_txt.Click
        save_dialog.Filter = "Archivo de texto|*.txt"
        save_dialog.Title = "Guardar Texto"
        save_dialog.ShowDialog()

        If save_dialog.FileName <> "" Then
            System.IO.File.WriteAllText(save_dialog.FileName, txt_rich.Text)
            icon_notif.BalloonTipIcon = ToolTipIcon.Info
            icon_notif.BalloonTipText = "Texto guardado en: " + save_dialog.FileName
            icon_notif.BalloonTipTitle = "SaveAll"
            My.Computer.Audio.Play("Sounds\mlg.wav")
            icon_notif.ShowBalloonTip(15)
        End If
    End Sub
    'Accion texto
    Public Function Action_text()
        If My.Computer.Clipboard.ContainsText Then
            txt_rich.Text = txt_rich.Text & vbCrLf & My.Computer.Clipboard.GetText
            icon_notif.BalloonTipIcon = ToolTipIcon.Info
            icon_notif.BalloonTipText = "TextoGuardado"
            icon_notif.BalloonTipTitle = "SaveAll"
            My.Computer.Audio.Play("Sounds\mlg.wav")
            icon_notif.ShowBalloonTip(15)
        Else
            icon_notif.BalloonTipIcon = ToolTipIcon.Error
            icon_notif.BalloonTipText = "No hay texto copiado"
            icon_notif.BalloonTipTitle = "Error"
            My.Computer.Audio.Play("Sounds\mlg.wav")
            icon_notif.ShowBalloonTip(15)
        End If
    End Function
    'Accion Imagen
    Public Function Action_Image()
        If My.Computer.Clipboard.ContainsImage Then
            Dim Img_copiada As Image = My.Computer.Clipboard.GetImage
            pb_img.Image = Img_copiada
            Img_copiada.Save("Imagenes\img" + HoraMod() + ".png", System.Drawing.Imaging.ImageFormat.Png)
            icon_notif.BalloonTipIcon = ToolTipIcon.Info
            icon_notif.BalloonTipText = "Imagen Guardada!"
            icon_notif.BalloonTipTitle = "SaveAll"
            My.Computer.Audio.Play("Sounds\mlg.wav")
            icon_notif.ShowBalloonTip(15)
            lst_archivosImg.Clear()
            For Each foundFile As String In My.Computer.FileSystem.GetFiles("Imagenes")
                lst_archivosImg.Items.Add(foundFile)
            Next
        Else
            icon_notif.BalloonTipIcon = ToolTipIcon.Error
            icon_notif.BalloonTipText = "No hay imagen"
            icon_notif.BalloonTipTitle = "Error"
            My.Computer.Audio.Play("Sounds\mlg.wav")
            icon_notif.ShowBalloonTip(15)
        End If
    End Function
    'Obtener hora "Fixeada"
    Public Function HoraMod()
        Dim random As Integer = CInt(Int((9999 * Rnd()) + 1))
        Dim ahora As String = DateAndTime.Now.ToString
        Dim ahora1 As String
        Dim ahora2 As String
        Dim ahora3 As String

        ahora1 = Replace(ahora, "/", "_")
        ahora2 = Replace(ahora1, " ", "_")
        ahora3 = Replace(ahora2, ":", "_")
        Return ahora3 + random.ToString

    End Function
    'Abrir del tray
    Private Sub AbrirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AbrirToolStripMenuItem.Click
        Me.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub
    'Salir Del Tray
    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub
    'Handler minimisar tray
    Private Sub Main_Form_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Minimized
            Me.Visible = False
            icon_notif.BalloonTipIcon = ToolTipIcon.Info
            icon_notif.BalloonTipText = "SaveAll esta aqui"
            icon_notif.BalloonTipTitle = "SaveAll"
            My.Computer.Audio.Play("Sounds\mlg.wav")
            icon_notif.ShowBalloonTip(15)
        End If
    End Sub
End Class
