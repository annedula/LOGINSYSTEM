Imports System.IO
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim role As String = Login(txtUser.Text, txtPass.Text)

        If role = "Admin" Then
            MessageBox.Show("Welcome Admin!")
            Form2.Show()
            Me.Hide()

        ElseIf role = "User" Then
            MessageBox.Show("Welcome User!")
            Form3.Show()
            Me.Hide()

        Else
            MessageBox.Show("Invalid User Name or Password")
            txtPass.Text = ""
            txtUser.Text = ""
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Function Login(user As String, pass As String) As String
        Try
            Dim reader As New StreamReader("credentials.csv")
            reader.ReadLine() ' Skip header

            Do While reader.Peek() >= 0
                Dim parts() As String = reader.ReadLine().Split(",")

                If parts(0) = user AndAlso parts(1) = pass Then
                    reader.Close()
                    Return parts(2) ' Return role
                End If
            Loop

            reader.Close()
            Return "" ' login failed

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return ""
        End Try
    End Function
End Class
