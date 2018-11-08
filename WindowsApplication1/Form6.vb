Public Class Form6

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'Discord Button
        Dim result As DialogResult
        result = MessageBox.Show("Are You Sure You Want Open This Link ?", "Open Discord Link", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Me.Hide()
        ElseIf result = DialogResult.Yes Then
            Process.Start("https://discord.gg/wus7H") ' vb.net
            Me.Close()
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Insta Button
        Dim result As DialogResult
        result = MessageBox.Show("Are You Sure You Want Open This Link ?", "Open Instagram Link", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Me.Close()
        ElseIf result = DialogResult.Yes Then
            Process.Start("https://instagram.com/esmailelbob01") ' vb.net
            Me.Close()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'My Website Button
        Dim result As DialogResult
        result = MessageBox.Show("Are You Sure You Want Open This Link ?", "Open My Websites Link", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Me.Hide()
        ElseIf result = DialogResult.Yes Then
            MessageBox.Show("Websites OutOfSupport Now!")
            Process.Start("https://esmailelbobpro.blogspot.com") ' vb.net
            Me.Close()
        End If
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'Github Button
        Dim result As DialogResult
        result = MessageBox.Show("Are You Sure You Want Open This Link ?", "Open Github Link", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Me.Hide()
        ElseIf result = DialogResult.Yes Then
            Process.Start("https://github.com/EsmailELBoBDev2/") ' vb.net
            Me.Close()
        End If
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        'Fb Button
        Dim result As DialogResult
        result = MessageBox.Show("Are You Sure You Want Open This Link ?", "Open FB Link", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Me.Hide()
        ElseIf result = DialogResult.Yes Then
            Process.Start("https://fb.com/esmailelbob01") ' vb.net
            Process.Start("https://www.facebook.com/NotePadPRo/") ' vb.net
            Me.Close()
        End If
    End Sub
End Class