﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.textBox4 = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.label3.Location = New System.Drawing.Point(31, 293)
        Me.label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(60, 24)
        Me.label3.TabIndex = 17
        Me.label3.Text = "Age："
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.label4.Location = New System.Drawing.Point(31, 249)
        Me.label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(78, 24)
        Me.label4.TabIndex = 16
        Me.label4.Text = "Name："
        '
        'textBox3
        '
        Me.textBox3.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.textBox3.Location = New System.Drawing.Point(131, 245)
        Me.textBox3.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(331, 31)
        Me.textBox3.TabIndex = 15
        '
        'textBox4
        '
        Me.textBox4.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.textBox4.Location = New System.Drawing.Point(131, 293)
        Me.textBox4.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New System.Drawing.Size(331, 31)
        Me.textBox4.TabIndex = 14
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.label2.Location = New System.Drawing.Point(31, 75)
        Me.label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(60, 24)
        Me.label2.TabIndex = 13
        Me.label2.Text = "Age："
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.label1.Location = New System.Drawing.Point(31, 31)
        Me.label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(78, 24)
        Me.label1.TabIndex = 12
        Me.label1.Text = "Name："
        '
        'textBox2
        '
        Me.textBox2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.textBox2.Location = New System.Drawing.Point(131, 71)
        Me.textBox2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(331, 31)
        Me.textBox2.TabIndex = 11
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("MS UI Gothic", 18.0!)
        Me.button1.Location = New System.Drawing.Point(31, 127)
        Me.button1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(433, 90)
        Me.button1.TabIndex = 10
        Me.button1.Text = "実行"
        Me.button1.UseVisualStyleBackColor = True
        '
        'textBox1
        '
        Me.textBox1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!)
        Me.textBox1.Location = New System.Drawing.Point(131, 27)
        Me.textBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(331, 31)
        Me.textBox1.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 351)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.textBox4)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.textBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label3 As Label
    Private WithEvents label4 As Label
    Private WithEvents textBox3 As TextBox
    Private WithEvents textBox4 As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents textBox2 As TextBox
    Private WithEvents button1 As Button
    Private WithEvents textBox1 As TextBox
End Class
