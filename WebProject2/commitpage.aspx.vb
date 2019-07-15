Public Class commitpage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            lblText.Text = "Hello There! How are you ?"
        Catch ex As Exception

        End Try
    End Sub
End Class