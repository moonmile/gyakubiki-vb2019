﻿Public Class Form1

    Private Sub Form1_Load(sender As Object,
            e As EventArgs) Handles MyBase.Load
        TextBox1.Visible = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object,
            e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox1.Visible = True
        Else
            TextBox1.Visible = False
        End If
    End Sub


End Class
