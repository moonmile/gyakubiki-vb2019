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
        Me.label6 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(36, 164)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(35, 12)
        Me.label5.TabIndex = 13
        Me.label5.Text = "label5"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(12, 136)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(69, 12)
        Me.label6.TabIndex = 12
        Me.label6.Text = "改行を含める"
        Me.label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(36, 106)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(35, 12)
        Me.label4.TabIndex = 11
        Me.label4.Text = "label4"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(36, 47)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(35, 12)
        Me.label3.TabIndex = 10
        Me.label3.Text = "label3"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(12, 78)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(100, 12)
        Me.label2.TabIndex = 9
        Me.label2.Text = "ダブルクォートを挿入"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 19)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(74, 12)
        Me.label1.TabIndex = 8
        Me.label1.Text = "円記号を挿入"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(12, 233)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(259, 53)
        Me.button1.TabIndex = 7
        Me.button1.Text = "文字列をそのまま利用する"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 312)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label5 As Label
    Private WithEvents label6 As Label
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents button1 As Button
End Class
