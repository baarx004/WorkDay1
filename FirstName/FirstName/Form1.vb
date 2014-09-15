Option Strict On

Public Class Form1

    Private Sub btnFirstName_Click(sender As System.Object, e As System.EventArgs) Handles btnFirstName.Click
        Dim FN As String
        FN = txtFullName.Text

        Dim FN2 As String
        FN2 = FN.Trim()

        Dim FirstSpace As Integer
        FirstSpace = FN2.IndexOf(" ")

        Dim FirstName As String
        FirstName = FN2.Substring(0, FirstSpace)

        txtFirstName.Text = FirstName

    End Sub
End Class
