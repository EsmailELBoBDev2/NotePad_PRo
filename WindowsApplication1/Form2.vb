Public Class Form2

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Copy Button
        TextBox1.Copy()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Cut Button
        TextBox1.Cut()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        'Paste Button
        TextBox1.Paste()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'Clear Button
        TextBox1.Clear()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'Font Button
        Try
            Dim dlg As FontDialog = New FontDialog
            dlg.Font = TextBox1.Font
            If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                TextBox1.Font = dlg.Font
            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'Color Button
        Try
            Dim dlg As ColorDialog = New ColorDialog
            dlg.Color = TextBox1.ForeColor
            If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                TextBox1.ForeColor = dlg.Color
            End If
        Catch ex As Exception : End Try
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        TextBox1.TextAlign = HorizontalAlignment.Center
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        TextBox1.TextAlign = HorizontalAlignment.Right
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        TextBox1.TextAlign = HorizontalAlignment.Left
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim file As String = Command$()
        If Not file = "" Then
            file = Replace(file, Chr(34), "")
            Dim objreader As New System.IO.StreamReader(file.ToString)
            TextBox1.Text = objreader.ReadToEnd
            objreader.Close()
            Me.Text = file
        End If
        Dim BuildNumber As String = My.Application.Info.Version.Build.ToString
        Me.Text = "NotePad PRo - Build Number " + BuildNumber
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label2.Text = TimeOfDay
        Label3.Text = DateString
    End Sub
    Private Sub Button8_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        'Open Button
        Dim OpenDLG As New OpenFileDialog

        OpenDLG.Filter = "Text Files (*.txt)|*.txt|All Files|*.*"
        OpenDLG.Title = "Open File"
        OpenDLG.InitialDirectory = "C:\"
        OpenDLG.RestoreDirectory = True

        DialogResult = OpenDLG.ShowDialog

        If DialogResult = Windows.Forms.DialogResult.OK Then

            Dim objreader As New System.IO.StreamReader(OpenDLG.FileName)

            TextBox1.Text = objreader.ReadToEnd

            objreader.Close()

            Me.Text = "Notepad | " + OpenDLG.FileName


        ElseIf DialogResult = Windows.Forms.DialogResult.Cancel Then

        End If

    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Save Button
        Dim savefile As New SaveFileDialog
        savefile.FileName = ""
        savefile.Filter = "TXT Files (*.txt*)|*.txt"
        savefile.Title = "Save"
        savefile.ShowDialog()
        Try
            Dim write As New System.IO.StreamWriter(savefile.FileName)
            write.Write(TextBox1.Text)
            write.Close()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Convert.ToChar(1) Then
            DirectCast(sender, TextBox).SelectAll()
            e.Handled = True
        End If
    End Sub
    Private Sub Button10_Click_4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.SelectAll()
    End Sub
    Private Sub Button10_Click_5(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        'New Button
        TextBox1.Clear()
    End Sub
    Private Sub NotifyIcon1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotifyIcon1.DoubleClick
        Try
            Me.Visible = True
            Me.WindowState = FormWindowState.Normal
            NotifyIcon1.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form2_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Try
            If Me.WindowState = FormWindowState.Minimized Then
                Me.Visible = False
                NotifyIcon1.Visible = True
                NotifyIcon1.ShowBalloonTip(1, "NotePad PRo", "Runnin Minimized", ToolTipIcon.Info)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Try
            Me.Visible = True
            Me.WindowState = FormWindowState.Normal
            NotifyIcon1.Visible = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub
    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form3.Show()
        Me.Hide()
    End Sub
End Class
