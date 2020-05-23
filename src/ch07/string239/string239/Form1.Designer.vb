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
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'textBox3
        '
        Me.textBox3.Location = New System.Drawing.Point(138, 122)
        Me.textBox3.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(319, 25)
        Me.textBox3.TabIndex = 17
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(138, 73)
        Me.textBox2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(319, 25)
        Me.textBox2.TabIndex = 16
        Me.textBox2.Text = "映画"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(29, 127)
        Me.label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(48, 18)
        Me.label6.TabIndex = 15
        Me.label6.Text = "結果:"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(29, 77)
        Me.label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(55, 18)
        Me.label5.TabIndex = 14
        Me.label5.Text = "Text2:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(29, 29)
        Me.label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(55, 18)
        Me.label4.TabIndex = 13
        Me.label4.Text = "Text1:"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(26, 185)
        Me.button1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(433, 80)
        Me.button1.TabIndex = 12
        Me.button1.Text = "文字列内に別の文字列を挿入する"
        Me.button1.UseVisualStyleBackColor = True
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(138, 25)
        Me.textBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(319, 25)
        Me.textBox1.TabIndex = 11
        Me.textBox1.Text = "恐竜を見た"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 292)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.textBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents textBox3 As TextBox
    Private WithEvents textBox2 As TextBox
    Private WithEvents label6 As Label
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents button1 As Button
    Private WithEvents textBox1 As TextBox
End Class
