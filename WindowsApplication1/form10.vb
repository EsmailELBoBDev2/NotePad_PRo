Imports System.Text
Public Class form10
    Function SniperText(ByRef text As String)
        Dim X As String
        Dim a As Byte() = Encoding.UTF8.GetBytes(text)
        X = Convert.ToBase64String(a)
        Return X
    End Function
    Function DesertText(ByRef text As String)
        Dim X As String
        Dim a As Byte() = Convert.FromBase64String(text)
        X = Encoding.UTF8.GetString(a)
        Return X
    End Function
    Private Sub form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton4.AutoCheck = True
        Timer1.Start()
        Dim BuildNumber As String = My.Application.Info.Version.Build.ToString
        Me.Text = "En-Crypt Words - Build Number " + BuildNumber
        RadioButton2.AutoCheck = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            TextBox2.Text = SniperText(TextBox1.Text)
            TextBox6.Text = DesertText(TextBox5.Text)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Convert.ToChar(1) Then
            DirectCast(sender, TextBox).SelectAll()
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Convert.ToChar(1) Then
            DirectCast(sender, TextBox).SelectAll()
            e.Handled = True
        End If
    End Sub

    Private Sub form10_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form3.Show()
    End Sub
    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If e.KeyChar = Convert.ToChar(1) Then
            DirectCast(sender, TextBox).SelectAll()
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If e.KeyChar = Convert.ToChar(1) Then
            DirectCast(sender, TextBox).SelectAll()
            e.Handled = True
        End If
    End Sub

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

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TabPage1.Text = "تشفير الكلمات"
        TabPage2.Text = "فك تشفير الكلمات"
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        TabPage1.Text = "En-crypt Words"
        TabPage2.Text = "De-crypt Words"
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        TextBox1.BackColor = Color.Black
        TextBox1.ForeColor = Color.White
        TextBox2.BackColor = Color.Black
        TextBox2.ForeColor = Color.White
        TextBox5.BackColor = Color.Black
        TextBox5.ForeColor = Color.White
        TextBox6.BackColor = Color.Black
        TextBox6.ForeColor = Color.White
        RadioButton1.BackColor = Color.Black
        RadioButton1.ForeColor = Color.White
        RadioButton2.BackColor = Color.Black
        RadioButton2.ForeColor = Color.White
        RadioButton5.BackColor = Color.Black
        RadioButton5.ForeColor = Color.White
        RadioButton6.BackColor = Color.Black
        RadioButton6.ForeColor = Color.White
        RadioButton3.BackColor = Color.Black
        RadioButton3.ForeColor = Color.White
        RadioButton4.BackColor = Color.Black
        RadioButton4.ForeColor = Color.White
        GroupBox2.ForeColor = Color.White
        GroupBox2.BackColor = Color.Black
        GroupBox5.ForeColor = Color.White
        GroupBox5.BackColor = Color.Black
        GroupBox4.ForeColor = Color.White
        GroupBox4.BackColor = Color.Black
        TabControl1.ForeColor = Color.White
        TabControl1.BackColor = Color.Black
        Me.BackColor = Color.Black
        Me.ForeColor = Color.White
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        TextBox1.BackColor = Color.White
        TextBox1.ForeColor = Color.Black
        TextBox2.BackColor = Color.White
        TextBox2.ForeColor = Color.Black
        TextBox5.BackColor = Color.White
        TextBox5.ForeColor = Color.Black
        TextBox6.BackColor = Color.White
        TextBox6.ForeColor = Color.Black
        RadioButton1.ForeColor = Color.Black
        RadioButton1.BackColor = Color.White
        RadioButton2.ForeColor = Color.Black
        RadioButton2.BackColor = Color.White
        RadioButton5.ForeColor = Color.Black
        RadioButton5.BackColor = Color.White
        RadioButton6.ForeColor = Color.Black
        RadioButton6.BackColor = Color.White
        RadioButton3.ForeColor = Color.Black
        RadioButton3.BackColor = Color.White
        RadioButton4.ForeColor = Color.Black
        RadioButton4.BackColor = Color.White
        GroupBox2.ForeColor = Color.Black
        GroupBox2.BackColor = Color.White
        GroupBox5.ForeColor = Color.Black
        GroupBox5.BackColor = Color.White
        GroupBox4.ForeColor = Color.Black
        GroupBox4.BackColor = Color.White
        TabControl1.ForeColor = Color.Black
        TabControl1.BackColor = Color.White
        Me.BackColor = Color.White
        Me.ForeColor = Color.Black
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        TextBox6.TextAlign = HorizontalAlignment.Center
    End Sub
End Class


