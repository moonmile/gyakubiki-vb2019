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
        Me.label2 = New System.Windows.Forms.Label()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(82, 114)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(35, 12)
        Me.label2.TabIndex = 10
        Me.label2.Text = "label2"
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(84, 47)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(100, 19)
        Me.textBox1.TabIndex = 9
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(23, 23)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(139, 12)
        Me.label4.TabIndex = 8
        Me.label4.Text = "0 から 100 までの値を指定："
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(82, 80)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(35, 12)
        Me.label1.TabIndex = 7
        Me.label1.Text = "label1"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(12, 143)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(259, 53)
        Me.button1.TabIndex = 6
        Me.button1.Text = "三項演算子を使う"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 213)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label2 As Label
    Private WithEvents textBox1 As TextBox
    Private WithEvents label4 As Label
    Private WithEvents label1 As Label
    Private WithEvents button1 As Button
End Class
