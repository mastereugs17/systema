Public Class frmChoose

    Dim ad As New ArrayList
    Private Sub frmChoose_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Enabled = True

        ad.Add("ADMIN")
        ad.Add("USER")
        ComboBox1.DataSource = ad
        ComboBox1.Text = Nothing

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label2.Text = Date.Now.ToString("dd-MM-yyyy     hh:mm:ss")


    End Sub
End Class
