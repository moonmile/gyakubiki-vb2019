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
        Me.label7 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Button()
        Me.label40 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(20, 195)
        Me.label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(107, 18)
        Me.label7.TabIndex = 19
        Me.label7.Text = "Telプロパティ："
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(218, 195)
        Me.label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(52, 18)
        Me.label4.TabIndex = 18
        Me.label4.Text = "label8"
        Me.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(23, 345)
        Me.button2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(433, 80)
        Me.button2.TabIndex = 17
        Me.button2.Text = "継承した SubSampleClass"
        Me.button2.UseVisualStyleBackColor = True
        '
        'label40
        '
        Me.label40.AutoSize = True
        Me.label40.Location = New System.Drawing.Point(20, 140)
        Me.label40.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label40.Name = "label40"
        Me.label40.Size = New System.Drawing.Size(143, 18)
        Me.label40.TabIndex = 16
        Me.label40.Text = "Addressプロパティ："
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(20, 82)
        Me.label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(111, 18)
        Me.label5.TabIndex = 15
        Me.label5.Text = "Ageプロパティ："
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(20, 27)
        Me.label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(126, 18)
        Me.label6.TabIndex = 14
        Me.label6.Text = "Nameプロパティ："
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(218, 140)
        Me.label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(52, 18)
        Me.label3.TabIndex = 13
        Me.label3.Text = "label3"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(218, 82)
        Me.label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(52, 18)
        Me.label2.TabIndex = 12
        Me.label2.Text = "label2"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(218, 27)
        Me.label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(52, 18)
        Me.label1.TabIndex = 11
        Me.label1.Text = "label1"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(23, 256)
        Me.button1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(433, 80)
        Me.button1.TabIndex = 10
        Me.button1.Text = "基本の SampleClass "
        Me.button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 450)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.label40)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label7 As Label
    Private WithEvents label4 As Label
    Private WithEvents button2 As Button
    Private WithEvents label40 As Label
    Private WithEvents label5 As Label
    Private WithEvents label6 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents button1 As Button
End Class
