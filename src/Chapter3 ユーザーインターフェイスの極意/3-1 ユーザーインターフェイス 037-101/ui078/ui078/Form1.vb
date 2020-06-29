Public Class Form1
    Private Sub Form1_Load(sender As Object,
            e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Value = DateTime.Now
        DateTimePicker1.MinDate = #1/1/2000#
        DateTimePicker1.MaxDate = #12/31/2030#
    End Sub

    Private Sub Button1_Click(sender As Object,
            e As EventArgs) Handles Button1.Click
        Label1.Text = DateTimePicker1.Value.ToLongDateString
    End Sub
End Class
