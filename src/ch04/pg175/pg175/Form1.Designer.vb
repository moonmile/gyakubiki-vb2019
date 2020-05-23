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
        Me.label2 = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.listBox1 = New System.Windows.Forms.ListBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listBox2
        '
        Me.listBox2.FormattingEnabled = True
        Me.listBox2.ItemHeight = 18
        Me.listBox2.Location = New System.Drawing.Point(386, 60)
        Me.listBox2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.listBox2.Name = "listBox2"
        Me.listBox2.Size = New System.Drawing.Size(86, 148)
        Me.listBox2.TabIndex = 12
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(383, 24)
        Me.label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(47, 18)
        Me.label2.TabIndex = 10
        Me.label2.Text = "キー："
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(25, 24)
        Me.label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(76, 18)
        Me.label10.TabIndex = 11
        Me.label10.Text = "キーと値："
        '
        'listBox1
        '
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.ItemHeight = 18
        Me.listBox1.Location = New System.Drawing.Point(23, 60)
        Me.listBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(351, 148)
        Me.listBox1.TabIndex = 9
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(23, 236)
        Me.button1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(452, 80)
        Me.button1.TabIndex = 8
        Me.button1.Text = "キーの一覧を取得"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 346)
        Me.Controls.Add(Me.listBox2)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label10)
        Me.Controls.Add(Me.listBox1)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents listBox2 As ListBox
    Private WithEvents label2 As Label
    Private WithEvents label10 As Label
    Private WithEvents listBox1 As ListBox
    Private WithEvents button1 As Button
End Class
