Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblhello.Text = "Hello world"
    End Sub

    Private Sub btnLabel_Click(sender As Object, e As EventArgs) Handles btnLabel.Click
        lblhello.Text = txthello.Text
    End Sub
End Class