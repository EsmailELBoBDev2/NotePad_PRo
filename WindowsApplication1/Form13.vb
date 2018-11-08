Public Class Form13

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("I Spoke With AVAST Support Team About My Program & My Site, & AVAST Support Team Said It's Not Have Virus (Press Ok To Show Next Message)")
        Dim result As DialogResult
        result = MessageBox.Show("You will go now to GOOGLE SCAN to know if my site clear/clean or no", "Open Google Scan Sites Link", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Me.Hide()
        ElseIf result = DialogResult.Yes Then
            Process.Start("https://www.google.com/transparencyreport/safebrowsing/diagnostic/index.html?hl=en#url=www.esmailelbobpro.tk") ' vb.net
            Me.Close()
        End If
    End Sub

    Private Sub Form13_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Form15.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim result As DialogResult
        result = MessageBox.Show("You will go now to AVAST Tickets to see by your eyes", "Open Google Scan Sites Link", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Me.Hide()
        ElseIf result = DialogResult.Yes Then
            Process.Start("https://support.avast.com/support/tickets/892934") ' vb.net
            Me.Close()
        End If
    End Sub
End Class