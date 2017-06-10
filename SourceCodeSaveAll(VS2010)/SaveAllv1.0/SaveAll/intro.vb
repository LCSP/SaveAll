Public Class intro

    Private Sub intro_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 10
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Me.Hide()
            Main_Form.Show()

        End If
    End Sub
End Class