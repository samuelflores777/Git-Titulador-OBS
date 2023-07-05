Imports System.IO
Public Class Form1
    Dim ruta As String = "c:/samueltxt/"
    Dim archivo1 As String = "B1txt1.txt"
    Dim archivo12 As String = "B1txt2.txt"
    Dim archivo21 As String = "B2txt1.txt"
    Dim archivo22 As String = "B2txt2.txt"
    Dim archivo31 As String = "B3txt1.txt"
    Dim archivo32 As String = "B3txt2.txt"
    Dim archivo33 As String = "B3txt3.txt"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim escribir As New StreamWriter(ruta & archivo1)
            escribir.WriteLine(TextBox1.Text)
            escribir.Close()
        Catch ex As Exception
            MsgBox("DIRECTORIO NO EXISTE", MsgBoxStyle.Critical, ":::SAMNET:::")
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim escribir21 As New StreamWriter(ruta & archivo21)
            Dim escribir22 As New StreamWriter(ruta & archivo22)
            escribir21.WriteLine(TextBox2.Text)
            escribir22.WriteLine(TextBox3.Text)
            escribir21.Close()
            escribir22.Close()
        Catch ex As Exception
            MsgBox("DIRECTORIO NO EXISTE", MsgBoxStyle.Critical, ":::SAMNET:::")
        End Try
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Dim escribir31 As New StreamWriter(ruta & archivo31)
            Dim escribir32 As New StreamWriter(ruta & archivo32)
            Dim escribir33 As New StreamWriter(ruta & archivo33)
            escribir31.WriteLine(TextBox4.Text)
            escribir32.WriteLine(TextBox5.Text)
            escribir33.WriteLine(TextBox6.Text)
            escribir31.Close()
            escribir32.Close()
            escribir33.Close()
        Catch ex As Exception
            MsgBox("DIRECTORIO NO EXISTE", MsgBoxStyle.Critical, ":::SAMNET:::")
        End Try
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try

            If File.Exists(ruta) Then
                MsgBox("EXISTE", MsgBoxStyle.Information, ":::SAMNET:::")
            Else
                Directory.CreateDirectory(ruta)
                MsgBox("DIRECTORIO CREADO EN c:samueltxt ", MsgBoxStyle.Information, ":::SAMNET:::")
            End If
        Catch ex As Exception
            MsgBox("Se presento un problema al momento de crear el archivo: " & ex.Message, MsgBoxStyle.Critical, ":::SAMNET:::")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim escribir As New StreamWriter(ruta & archivo12)
            escribir.WriteLine(TextBox7.Text)
            escribir.Close()
        Catch ex As Exception
            MsgBox("DIRECTORIO NO EXISTE", MsgBoxStyle.Critical, ":::SAMNET:::")
        End Try
    End Sub
End Class
