
Public Class Form15
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Exit Button
        End
    End Sub
    Private Sub LinkLabel1_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Process.Start("https://goo.gl/forms/lcRepQKVWn3xufVy1") ' vb.net
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Bug Button
        Process.Start("https://goo.gl/forms/QcJu8hMWQlUcut3v2") ' vb.net
    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        MessageBox.Show("Dev By: Esmail EL BoB (Press Ok For More Info)")
        MessageBox.Show("Built In: 21/10/2017 (Press Ok To Close)")
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form13.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form18.Show()
        Me.Hide()
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        End
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        LinkLabel1.Text = "لا تقلق (أضغط هنا)"
        TextBox1.Visible = False
        TextBox2.Visible = True
        CheckBox1.Text = "انا اوافق"
        CheckBox2.Text = "انا لا اوافق"
        Label2.Text = "إسم التحديث: الشكل الجديد"
        Label1.Text = "الإصدار 1.13 (إضغط هنا للمزيد من المعلومات)"
        Button1.Text = "احتاج للمساعده"
        Button3.Text = "إقتراح او إبلاغ عن خطأ"
        Button2.Text = "ساعدنى فى اضافه لغتك"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        LinkLabel1.Text = "Don't Worry, See This."
        TextBox1.Visible = True
        TextBox2.Visible = False
        CheckBox1.Text = "I Agree"
        CheckBox2.Text = "I Disagree"
        Label2.Text = "Update Name: New look"
        Label1.Text = "Verison: 1.13 (Click Me For More Info)"
        Button1.Text = "I NEED HELP!!!"
        Button3.Text = "Suggestion or Report bug"
        Button2.Text = "Help me to add your language"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("https://goo.gl/forms/dyCtDHPFL2a77jxm2") ' vb.net
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form6.ShowDialog()
    End Sub
End Class
