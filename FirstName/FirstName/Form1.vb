Option Strict On

Public Class Form1

    Private Sub btnFirstName_Click(sender As System.Object, e As System.EventArgs) Handles btnFirstName.Click
        Dim St As String
        St = txtFullName.Text

        Dim St2 As String
        St2 = St.Trim()

        Dim FirstSpace As Integer
        FirstSpace = St2.IndexOf(" ")

        Dim FirstName As String
        FirstName = St2.Substring(0, FirstSpace)

        txtFirstName.Text = FirstName

    End Sub
End Class
