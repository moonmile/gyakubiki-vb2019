<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.button1 = New System.Windows.Forms.Button()
        Me.textBox6 = New System.Windows.Forms.TextBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(32, 67)
        Me.button1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(432, 57)
        Me.button1.TabIndex = 17
        Me.button1.Text = "送信"
        Me.button1.UseVisualStyleBackColor = True
        '
        'textBox6
        '
        Me.textBox6.Location = New System.Drawing.Point(32, 132)
        Me.textBox6.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox6.Multiline = True
        Me.textBox6.Name = "textBox6"
        Me.textBox6.Size = New System.Drawing.Size(431, 247)
        Me.textBox6.TabIndex = 16
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(32, 25)
        Me.textBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(431, 25)
        Me.textBox1.TabIndex = 11
        Me.textBox1.Text = "http://localhost:5000/api/Books/1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 409)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.textBox6)
        Me.Controls.Add(Me.textBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents button1 As Button
    Private WithEvents textBox6 As TextBox
    Private WithEvents textBox1 As TextBox
End Class
