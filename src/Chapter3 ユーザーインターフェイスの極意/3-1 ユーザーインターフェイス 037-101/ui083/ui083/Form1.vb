﻿Public Class Form1
    Dim futoji As FontStyle
    Dim syatai As FontStyle
    Private Sub 太字ToolStripMenuItem_Click(sender As Object,
            e As EventArgs) Handles 太字ToolStripMenuItem.Click
        If 太字ToolStripMenuItem.Checked Then
            futoji = FontStyle.Regular
            太字ToolStripMenuItem.Checked = False
        Else
            futoji = FontStyle.Bold
            太字ToolStripMenuItem.Checked = True
        End If
        TextBox1.Font = New Font(TextBox1.Font, futoji + syatai)

    End Sub

    Private Sub 斜体ToolStripMenuItem_Click(sender As Object,
            e As EventArgs) Handles 斜体ToolStripMenuItem.Click
        If 斜体ToolStripMenuItem.Checked Then
            syatai = FontStyle.Regular
            斜体ToolStripMenuItem.Checked = False
        Else
            syatai = FontStyle.Italic
            斜体ToolStripMenuItem.Checked = True
        End If
        TextBox1.Font = New Font(TextBox1.Font, futoji + syatai)
    End Sub
End Class
