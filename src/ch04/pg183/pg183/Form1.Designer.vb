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
        Me.label5 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label20 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(29, 217)
        Me.label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(192, 18)
        Me.label5.TabIndex = 18
        Me.label5.Text = "文字列を数だけ繰り返し："
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(84, 268)
        Me.label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(52, 18)
        Me.label3.TabIndex = 17
        Me.label3.Text = "label3"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(84, 170)
        Me.label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(52, 18)
        Me.label2.TabIndex = 16
        Me.label2.Text = "label2"
        '
        'label20
        '
        Me.label20.AutoSize = True
        Me.label20.Location = New System.Drawing.Point(29, 121)
        Me.label20.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(162, 18)
        Me.label20.TabIndex = 15
        Me.label20.Text = "２つの文字列を結合："
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(84, 73)
        Me.label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(52, 18)
        Me.label1.TabIndex = 14
        Me.label1.Text = "label1"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(29, 24)
        Me.label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(144, 18)
        Me.label4.TabIndex = 13
        Me.label4.Text = "２つの数値を加算："
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(29, 331)
        Me.button1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(433, 80)
        Me.button1.TabIndex = 12
        Me.button1.Text = "関数のオーバーロード"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 450)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label20)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label5 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label20 As Label
    Private WithEvents label1 As Label
    Private WithEvents label4 As Label
    Private WithEvents button1 As Button
End Class
