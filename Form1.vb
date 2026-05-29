Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
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
            Dim reader As New StreamReader("credential.csv")
            reader.ReadLine() ' Skip header

            Do While reader.Peek() >= 0
                Dim parts() As String = reader.ReadLine().Split(",")

                Dim hashedPass As String =
                HashPassword(pass)

                If parts(0) = user AndAlso parts(1) = hashedPass Then
                    reader.Close()
                    Return parts(2) ' Return role
                End If
            Loop

            reader.Close()
            Return "" ' login failed

        Catch ex As Exception

            LogError(ex.Message)

            MessageBox.Show("Error: " & ex.Message)

            Return ""

        End Try

        Try

            Dim username As String = txtUser.Text

            If username = "" Then
                Throw New Exception("Username is empty")
            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

            LogError(ex.Message)

        End Try
    End Function

    Private Sub TxtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

    End Sub
End Class
