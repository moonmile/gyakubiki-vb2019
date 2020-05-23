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
        Me.listBox2 = New System.Windows.Forms.ListBox()
        Me.listBox1 = New System.Windows.Forms.ListBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listBox2
        '
        Me.listBox2.FormattingEnabled = True
        Me.listBox2.ItemHeight = 18
        Me.listBox2.Location = New System.Drawing.Point(260, 64)
        Me.listBox2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.listBox2.Name = "listBox2"
        Me.listBox2.Size = New System.Drawing.Size(197, 112)
        Me.listBox2.TabIndex = 13
        '
        'listBox1
        '
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.ItemHeight = 18
        Me.listBox1.Location = New System.Drawing.Point(27, 64)
        Me.listBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(197, 112)
        Me.listBox1.TabIndex = 12
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(257, 26)
        Me.label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(71, 18)
        Me.label1.TabIndex = 11
        Me.label1.Text = "変換先："
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(27, 285)
        Me.button2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(433, 80)
        Me.button2.TabIndex = 10
        Me.button2.Text = "コレクションの受け渡し"
        Me.button2.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(27, 26)
        Me.label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(71, 18)
        Me.label4.TabIndex = 9
        Me.label4.Text = "変換元："
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(27, 196)
        Me.button1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(433, 80)
        Me.button1.TabIndex = 8
        Me.button1.Text = "配列の受け渡し"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 389)
        Me.Controls.Add(Me.listBox2)
        Me.Controls.Add(Me.listBox1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents listBox2 As ListBox
    Private WithEvents listBox1 As ListBox
    Private WithEvents label1 As Label
    Private WithEvents button2 As Button
    Private WithEvents label4 As Label
    Private WithEvents button1 As Button
End Class
