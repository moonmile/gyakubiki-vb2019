﻿Public Class Form1
    Private Sub Button1_Click(sender As Object,
            e As EventArgs) Handles Button1.Click
        Dim newForm As New Form2
        newForm.StartPosition = FormStartPosition.Manual
        newForm.Location = New Point(0, 0)
        newForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object,
            e As EventArgs) Handles Button2.Click
        Dim newForm As New Form2
        newForm.StartPosition = FormStartPosition.CenterScreen
        newForm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object,
            e As EventArgs) Handles Button3.Click
        Dim newForm As New Form2
        newForm.StartPosition = FormStartPosition.WindowsDefaultLocation
        newForm.Show()
    End Sub

    Private Sub Button4_Click(sender As Object,
            e As EventArgs) Handles Button4.Click
        Dim newForm As New Form2
        newForm.StartPosition = FormStartPosition.WindowsDefaultBounds
        newForm.Show()
    End Sub

    Private Sub Button5_Click(sender As Object,
            e As EventArgs) Handles Button5.Click
        Dim newForm As New Form2
        newForm.StartPosition = FormStartPosition.CenterParent
        newForm.Show()
    End Sub
End Class
