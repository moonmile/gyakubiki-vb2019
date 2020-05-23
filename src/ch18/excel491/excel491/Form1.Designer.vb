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
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'textBox1
        '
        Me.textBox1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.textBox1.Location = New System.Drawing.Point(24, 73)
        Me.textBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(431, 31)
        Me.textBox1.TabIndex = 7
        '
        'checkBox1
        '
        Me.checkBox1.AutoSize = True
        Me.checkBox1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.checkBox1.Location = New System.Drawing.Point(24, 139)
        Me.checkBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(84, 28)
        Me.checkBox1.TabIndex = 6
        Me.checkBox1.Text = "完了"
        Me.checkBox1.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.label1.Location = New System.Drawing.Point(24, 23)
        Me.label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(67, 24)
        Me.label1.TabIndex = 5
        Me.label1.Text = "label1"
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("MS UI Gothic", 18.0!)
        Me.button1.Location = New System.Drawing.Point(24, 209)
        Me.button1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(432, 96)
        Me.button1.TabIndex = 4
        Me.button1.Text = "実行"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 331)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.checkBox1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents textBox1 As TextBox
    Private WithEvents checkBox1 As CheckBox
    Private WithEvents label1 As Label
    Private WithEvents button1 As Button
End Class
