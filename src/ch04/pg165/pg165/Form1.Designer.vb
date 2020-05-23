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
        Me.button2 = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label20 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(253, 210)
        Me.button2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(200, 80)
        Me.button2.TabIndex = 12
        Me.button2.Text = "部分的にクリアする"
        Me.button2.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(40, 162)
        Me.label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(52, 18)
        Me.label2.TabIndex = 11
        Me.label2.Text = "label2"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(40, 68)
        Me.label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(52, 18)
        Me.label1.TabIndex = 10
        Me.label1.Text = "label1"
        '
        'label20
        '
        Me.label20.AutoSize = True
        Me.label20.Location = New System.Drawing.Point(20, 116)
        Me.label20.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label20.Name = "label20"
        Me.label20.Size = New System.Drawing.Size(72, 18)
        Me.label20.TabIndex = 9
        Me.label20.Text = "クリア後："
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(20, 24)
        Me.label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(72, 18)
        Me.label10.TabIndex = 8
        Me.label10.Text = "クリア前："
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(23, 210)
        Me.button1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(200, 80)
        Me.button1.TabIndex = 7
        Me.button1.Text = "すべてクリアする"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 315)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.label20)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents button2 As Button
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents label20 As Label
    Private WithEvents label10 As Label
    Private WithEvents button1 As Button
End Class
