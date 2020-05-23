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
        Me.label1 = New System.Windows.Forms.Label()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'textBox3
        '
        Me.textBox3.Location = New System.Drawing.Point(189, 19)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(60, 19)
        Me.textBox3.TabIndex = 12
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(97, 19)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(60, 19)
        Me.textBox2.TabIndex = 11
        Me.textBox2.Text = "7.0"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!)
        Me.label1.Location = New System.Drawing.Point(163, 22)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(11, 12)
        Me.label1.TabIndex = 10
        Me.label1.Text = "="
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(14, 19)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(60, 19)
        Me.textBox1.TabIndex = 9
        Me.textBox1.Text = "10.25"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("MS UI Gothic", 9.0!)
        Me.label2.Location = New System.Drawing.Point(80, 22)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(11, 12)
        Me.label2.TabIndex = 8
        Me.label2.Text = "+"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(12, 88)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(259, 53)
        Me.button1.TabIndex = 7
        Me.button1.Text = "文字列から数値型に変換する"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 160)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents textBox3 As TextBox
    Private WithEvents textBox2 As TextBox
    Private WithEvents label1 As Label
    Private WithEvents textBox1 As TextBox
    Private WithEvents label2 As Label
    Private WithEvents button1 As Button
End Class
