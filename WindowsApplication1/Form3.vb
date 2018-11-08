Public Class Form3

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        'Folder Locker Button
        Form8.Show()
        Me.Hide()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show("Coming Soon")
    End Sub
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Calculator Button
        Form7.Show()
        Me.Hide()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'crypt Words Button
        Form8.Show()
        Me.Hide()
    End Sub
    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'Screen Shot Button
        Form4.Show()
        Me.Hide()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form5.Show()
        Me.Hide()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MessageBox.Show("for some reasons all proxy websites stopped work on my pc so i can't test new features so i removed it & added website give you the same service")
        MessageBox.Show("yeah! because this reason & gliths so browser in our labs to fix")
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Button1.Text = "المتصفح"
        Button4.Text = "تشفير الكلمات"
        Button15.Text = "مغلق الملفات"
        Button3.Text = "ترجمه جوجل"
        Button7.Text = "المفكره"
        Button2.Text = "الأله الحاسبه"
        Button5.Text = "تصوير الشاشة"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Button1.Text = "Browser"
        Button4.Text = "En-Crypt Words"
        Button15.Text = "Foloder Locker"
        Button3.Text = "Google Translate"
        Button7.Text = "Notepad"
        Button2.Text = "Calculator"
        Button5.Text = "Screen Shots Program"
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Button1.BackColor = Color.Black
        Button1.ForeColor = Color.White
        Button4.BackColor = Color.Black
        Button4.ForeColor = Color.White
        Button15.BackColor = Color.Black
        Button15.ForeColor = Color.White
        Button3.BackColor = Color.Black
        Button3.ForeColor = Color.White
        Button7.BackColor = Color.Black
        Button7.ForeColor = Color.White
        Button2.BackColor = Color.Black
        Button2.ForeColor = Color.White
        Button5.BackColor = Color.Black
        Button5.ForeColor = Color.White
        RadioButton2.ForeColor = Color.White
        RadioButton2.BackColor = Color.Black
        RadioButton1.ForeColor = Color.White
        RadioButton1.BackColor = Color.Black
        RadioButton3.ForeColor = Color.White
        RadioButton3.BackColor = Color.Black
        RadioButton4.ForeColor = Color.White
        RadioButton4.BackColor = Color.Black
        Me.BackColor = Color.Black
        Me.ForeColor = Color.White
        GroupBox1.ForeColor = Color.White
        GroupBox1.BackColor = Color.Black
        GroupBox2.ForeColor = Color.White
        GroupBox2.BackColor = Color.Black
        GroupBox3.ForeColor = Color.White
        GroupBox3.BackColor = Color.Black
        GroupBox4.ForeColor = Color.White
        GroupBox4.BackColor = Color.Black
        GroupBox5.ForeColor = Color.White
        GroupBox5.BackColor = Color.Black
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        Button1.BackColor = Color.White
        Button1.ForeColor = Color.Black
        Button4.BackColor = Color.White
        Button4.ForeColor = Color.Black
        Button15.BackColor = Color.White
        Button15.ForeColor = Color.Black
        Button3.BackColor = Color.White
        Button3.ForeColor = Color.Black
        Button7.BackColor = Color.White
        Button7.ForeColor = Color.Black
        Button2.BackColor = Color.White
        Button2.ForeColor = Color.Black
        Button5.BackColor = Color.White
        Button5.ForeColor = Color.Black
        RadioButton2.ForeColor = Color.Black
        RadioButton2.BackColor = Color.White
        RadioButton1.ForeColor = Color.Black
        RadioButton1.BackColor = Color.White
        RadioButton3.ForeColor = Color.Black
        RadioButton3.BackColor = Color.White
        RadioButton4.ForeColor = Color.Black
        RadioButton4.BackColor = Color.White
        Me.BackColor = Color.White
        Me.ForeColor = Color.Black
        GroupBox1.ForeColor = Color.Black
        GroupBox1.BackColor = Color.White
        GroupBox2.ForeColor = Color.Black
        GroupBox2.BackColor = Color.White
        GroupBox3.ForeColor = Color.Black
        GroupBox3.BackColor = Color.White
        GroupBox4.ForeColor = Color.Black
        GroupBox4.BackColor = Color.White
        GroupBox5.ForeColor = Color.Black
        GroupBox5.BackColor = Color.White
    End Sub
End Class