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
        Me.progressBar1 = New System.Windows.Forms.ProgressBar()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'progressBar1
        '
        Me.progressBar1.Location = New System.Drawing.Point(14, 92)
        Me.progressBar1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.progressBar1.Name = "progressBar1"
        Me.progressBar1.Size = New System.Drawing.Size(433, 34)
        Me.progressBar1.TabIndex = 7
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.label2.Location = New System.Drawing.Point(14, 162)
        Me.label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(92, 33)
        Me.label2.TabIndex = 6
        Me.label2.Text = "label2"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("MS UI Gothic", 16.0!)
        Me.label1.Location = New System.Drawing.Point(14, 26)
        Me.label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(92, 33)
        Me.label1.TabIndex = 5
        Me.label1.Text = "label1"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(14, 232)
        Me.button1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(433, 80)
        Me.button1.TabIndex = 4
        Me.button1.Text = "非同期メソッドを呼び出す"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 340)
        Me.Controls.Add(Me.progressBar1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents progressBar1 As ProgressBar
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents button1 As Button
End Class
