Public Class Form18

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are You Sure You Want Open This Link ?", "Open Live Chat Link", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Me.Hide()
        ElseIf result = DialogResult.Yes Then
            Process.Start("https://tawk.to/esmailelbobpro") ' vb.net
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are You Sure You Want Open This Link ?", "Open Tickets Link", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Me.Hide()
        ElseIf result = DialogResult.Yes Then
            Process.Start("http://www.esmailelbobpro.tk/p/import-urlhttpassets.html") ' vb.net
            Me.Close()
        End If
    End Sub

    Private Sub Form18_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Form15.Show()
    End Sub
End Class