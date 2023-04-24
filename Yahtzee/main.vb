Public Class frmMain
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click

        txtName.ForeColor = Color.Black

        If IsNumeric(txtName.Text) Or txtName.Text = "" Or txtName.Text = "Name" Then
            MessageBox.Show("Please enter your name.")
            txtName.Focus()
            txtName.Text = ""
        Else
            frmGame.Show()
            Me.Hide()
            frmGame.lblName.Text = txtName.Text
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub txtName_Click(sender As Object, e As EventArgs) Handles txtName.Click
        txtName.Text = ""
        txtName.ForeColor = Color.Black

    End Sub
End Class
