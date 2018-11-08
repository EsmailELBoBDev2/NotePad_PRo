Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Timers
Public Class Form12
    Public status As String
    Private arr As String() = New String(5) {}
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RadioButton4.AutoCheck = True
        RadioButton2.AutoCheck = True
        Dim BuildNumber As String = My.Application.Info.Version.Build.ToString
        Me.Text = "Folder Locker PRo - Build Number " + BuildNumber
        status = ""
        arr(0) = ".{2559a1f2-21d7-11d4-bdaf-00c04f60b9f0}"
        arr(1) = ".{21EC2020-3AEA-1069-A2DD-08002B30309D}"
        arr(2) = ".{2559a1f4-21d7-11d4-bdaf-00c04f60b9f0}"
        arr(3) = ".{645FF040-5081-101B-9F08-00AA002F954E}"
        arr(4) = ".{2559a1f1-21d7-11d4-bdaf-00c04f60b9f0}"
        arr(5) = ".{7007ACC7-3202-11D1-AAD2-00805FC1270E}"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Lock Button
        status = arr(0)



        If FolderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then



            Dim d As DirectoryInfo = New DirectoryInfo(FolderBrowserDialog1.SelectedPath)

            Dim selectedpath As String = d.Parent.FullName + d.Name

            ProgressBar1.Value = 35

            If FolderBrowserDialog1.SelectedPath.LastIndexOf(".{") = -1 Then



                If (Not d.Root.Equals(d.Parent.FullName)) Then

                    d.MoveTo(d.Parent.FullName & "\" & d.Name & status)

                Else

                    d.MoveTo(d.Parent.FullName + d.Name & status)

                End If

                TextBox1.Text = FolderBrowserDialog1.SelectedPath
                ProgressBar1.Value = 70

                ' PictureBox1.Image = Image.FromFile(Application.StartupPath & "\lock.jpg")
                ProgressBar1.Value = 100
            Else

                status = getstatus(status)



                d.MoveTo(FolderBrowserDialog1.SelectedPath.Substring(0, FolderBrowserDialog1.SelectedPath.LastIndexOf(".")))

                TextBox1.Text = FolderBrowserDialog1.SelectedPath.Substring(0, FolderBrowserDialog1.SelectedPath.LastIndexOf("."))

                ' PictureBox1.Image = Image.FromFile(Application.StartupPath & "\unlock.jpg")



            End If

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'UnLock Button
        status = arr(1)



        If FolderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then



            Dim d As DirectoryInfo = New DirectoryInfo(FolderBrowserDialog1.SelectedPath)

            Dim selectedpath As String = d.Parent.FullName + d.Name



            If FolderBrowserDialog1.SelectedPath.LastIndexOf(".{") = -1 Then



                If (Not d.Root.Equals(d.Parent.FullName)) Then

                    d.MoveTo(d.Parent.FullName & "\" & d.Name & status)

                Else

                    d.MoveTo(d.Parent.FullName + d.Name & status)

                End If

                TextBox1.Text = FolderBrowserDialog1.SelectedPath

                'PictureBox1.Image = Image.FromFile(Application.StartupPath & "\lock.jpg")

            Else

                status = getstatus(status)



                d.MoveTo(FolderBrowserDialog1.SelectedPath.Substring(0, FolderBrowserDialog1.SelectedPath.LastIndexOf(".")))

                TextBox1.Text = FolderBrowserDialog1.SelectedPath.Substring(0, FolderBrowserDialog1.SelectedPath.LastIndexOf("."))

                ' PictureBox1.Image = Image.FromFile(Application.StartupPath & "\unlock.jpg")



            End If

        End If
    End Sub
    Private Function getstatus(ByVal stat As String) As String

        For i As Integer = 0 To 5

            If stat.LastIndexOf(arr(i)) <> -1 Then

                stat = stat.Substring(stat.LastIndexOf("."))

            End If

        Next i

        Return stat

    End Function

    Private Sub RadioButton2_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            TopMost = True
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            TopMost = False
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
    End Sub
    Private Sub Form12_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Form3.Show()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Button1.Text = "قفل"
        Button2.Text = "فك القفل"
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        Button1.Text = "Lock"
        Button2.Text = "UnLock"
    End Sub
End Class

