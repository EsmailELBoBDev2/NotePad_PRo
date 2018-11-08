Imports System.Timers

Public Class Form4
    Public Shared Image As Image
    Public Shared Bounds As Rectangle
    Public Shared TimerCount As Integer
    Shared Function GetDesktopImage(Optional ByVal Width As Integer = 0, Optional ByVal Height As Integer = 0, Optional ByVal ShowCursor As Boolean = True) As Image
        Dim W As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim H As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim DesktopBitmap As New Bitmap(W, H)
        Dim g As Graphics = Graphics.FromImage(DesktopBitmap)
        g.CopyFromScreen(0, 0, 0, 0, New Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height), CopyPixelOperation.SourceCopy)
        If ShowCursor Then Cursors.Default.Draw(g, New Rectangle(Cursor.Position, New Size(32, 32)))
        g.Dispose()
        If Width = 0 And Height = 0 Then
            Image = DesktopBitmap
            Return DesktopBitmap

        Else
            Dim ScaledBitmap As Image = DesktopBitmap.GetThumbnailImage(Width, Height, Nothing, IntPtr.Zero)
            DesktopBitmap.Dispose()
            Image = ScaledBitmap
            Return ScaledBitmap
        End If
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Take Screen Shot Button
        Me.WindowState = FormWindowState.Minimized
        TimerCount = 0
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TimerCount += 1

        If TimerCount = 1 And Me.WindowState = FormWindowState.Minimized Then
            PictureBox1.Image = GetDesktopImage()

        End If
        If TimerCount = 2 And Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Save Button
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Open Button
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.ImageLocation = OpenFileDialog1.FileName
    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        PictureBox1.Image.Save(SaveFileDialog1.FileName + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim BuildNumber As String = My.Application.Info.Version.Build.ToString
        Me.Text = "ScreenShot Program - Build Number " + BuildNumber
    End Sub
    Private Sub Form4_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Form3.Show()
    End Sub
End Class
