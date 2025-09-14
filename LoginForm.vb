Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Username As String
        Dim Password As String

        Username = TextUser.Text.Trim().ToLower() 'we use Trim() and ToLower() to avoid case sensitivity and extra spaces
        Password = TextPass.Text.Trim().ToLower()


        'If TextUser.Text.Equals("admin") And TextPass.Text.Equals("123") Then
        '    MessageBox.Show("Login Successful", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Else
        '    MessageBox.Show("Error", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)")
        'End If



        'If TextUser.Text = "admin" And TextPass.Text = "123" Then
        '    MessageBox.Show("Login Successful", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Else
        '    MessageBox.Show("Error", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)")
        'End If


        If Username.Equals("admin") And Password.Equals("123") Then
            MessageBox.Show("Login Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error", "information", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        TextUser.Clear()
        TextPass.Clear()



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
