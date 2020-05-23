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
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(266, 30)
        Me.textBox2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(142, 25)
        Me.textBox2.TabIndex = 18
        Me.textBox2.Text = "20"
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(59, 30)
        Me.textBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(142, 25)
        Me.textBox1.TabIndex = 17
        Me.textBox1.Text = "10"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(234, 34)
        Me.label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(21, 18)
        Me.label3.TabIndex = 16
        Me.label3.Text = "b:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(28, 34)
        Me.label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(21, 18)
        Me.label2.TabIndex = 15
        Me.label2.Text = "a:"
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(26, 282)
        Me.button2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(433, 80)
        Me.button2.TabIndex = 14
        Me.button2.Text = "ラムダ式で実行"
        Me.button2.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(91, 139)
        Me.label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(52, 18)
        Me.label1.TabIndex = 13
        Me.label1.Text = "label1"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(36, 90)
        Me.label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(126, 18)
        Me.label4.TabIndex = 12
        Me.label4.Text = "ラムダ式の結果："
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(26, 193)
        Me.button1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(433, 80)
        Me.button1.TabIndex = 11
        Me.button1.Text = "メソッド内の関数で実行"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 390)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents textBox2 As TextBox
    Private WithEvents textBox1 As TextBox
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents button2 As Button
    Private WithEvents label1 As Label
    Private WithEvents label4 As Label
    Private WithEvents button1 As Button
End Class
