﻿Public Class Form1
    Dim obj As TextBox
    Private Sub 左揃えToolStripMenuItem_Click(sender As Object,
            e As EventArgs) Handles 左揃えToolStripMenuItem.Click
        obj = ContextMenuStrip1.SourceControl
        obj.TextAlign = HorizontalAlignment.Left
    End Sub

    Private Sub 中央揃えToolStripMenuItem_Click(sender As Object,
            e As EventArgs) Handles 中央揃えToolStripMenuItem.Click
        obj = ContextMenuStrip1.SourceControl
        obj.TextAlign = HorizontalAlignment.Center
    End Sub

    Private Sub 右揃えToolStripMenuItem_Click(sender As Object,
            e As EventArgs) Handles 右揃えToolStripMenuItem.Click
        obj = ContextMenuStrip1.SourceControl
        obj.TextAlign = HorizontalAlignment.Right
    End Sub
End Class
