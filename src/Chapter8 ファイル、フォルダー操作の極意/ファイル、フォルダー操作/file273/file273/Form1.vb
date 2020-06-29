Imports System.Runtime.InteropServices

Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim path = textBox1.Text
        If path = String.Empty Then
            Return
        End If
        Dim br As BLOCK
        br.X = 100
        br.Y = 200
        br.Z = 0
        br.color = Color.Red
        Dim fs As New System.IO.BinaryWriter(
            System.IO.File.Create(path))
        ' 構造体のデータを byte配列 に変換する
        Dim Data = New Byte(Marshal.SizeOf(GetType(BLOCK))) {}
        Dim h = GCHandle.Alloc(Data, GCHandleType.Pinned)
        Try
            Marshal.StructureToPtr(br, h.AddrOfPinnedObject(), False)
        Finally
            h.Free()
        End Try
        For i = 0 To 1024 * 100 - 1
            fs.Write(Data)
        Next
        fs.Close()
        MessageBox.Show("構造体のファイルを作成しました")
    End Sub
End Class

Public Structure BLOCK
    Public X As System.Int32
    Public Y As System.Int32
    Public Z As System.Int32
    Public color As Color
End Structure
