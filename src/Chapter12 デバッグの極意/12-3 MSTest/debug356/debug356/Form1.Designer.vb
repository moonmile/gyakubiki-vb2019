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
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'button3
        '
        Me.button3.Cursor = System.Windows.Forms.Cursors.Default
        Me.button3.Location = New System.Drawing.Point(14, 316)
        Me.button3.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(432, 82)
        Me.button3.TabIndex = 11
        Me.button3.Text = "オブジェクト作成"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Cursor = System.Windows.Forms.Cursors.Default
        Me.button2.Location = New System.Drawing.Point(12, 225)
        Me.button2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(432, 82)
        Me.button2.TabIndex = 10
        Me.button2.Text = "文字列の連結"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.button1.Location = New System.Drawing.Point(14, 134)
        Me.button1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(432, 82)
        Me.button1.TabIndex = 9
        Me.button1.Text = "数値で計算"
        Me.button1.UseVisualStyleBackColor = True
        '
        'textBox3
        '
        Me.textBox3.Location = New System.Drawing.Point(14, 94)
        Me.textBox3.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(429, 25)
        Me.textBox3.TabIndex = 8
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(14, 57)
        Me.textBox2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(429, 25)
        Me.textBox2.TabIndex = 7
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(14, 20)
        Me.textBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(429, 25)
        Me.textBox1.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 418)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.textBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents textBox3 As TextBox
    Private WithEvents textBox2 As TextBox
    Private WithEvents textBox1 As TextBox
End Class
