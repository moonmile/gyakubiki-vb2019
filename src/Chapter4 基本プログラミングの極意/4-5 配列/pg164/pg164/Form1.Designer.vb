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
        Me.label3 = New System.Windows.Forms.Label()
        Me.listBox3 = New System.Windows.Forms.ListBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.listBox2 = New System.Windows.Forms.ListBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.listBox1 = New System.Windows.Forms.ListBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(369, 22)
        Me.label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(110, 18)
        Me.label3.TabIndex = 13
        Me.label3.Text = "降順でソート："
        '
        'listBox3
        '
        Me.listBox3.FormattingEnabled = True
        Me.listBox3.ItemHeight = 18
        Me.listBox3.Location = New System.Drawing.Point(371, 50)
        Me.listBox3.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.listBox3.Name = "listBox3"
        Me.listBox3.Size = New System.Drawing.Size(164, 148)
        Me.listBox3.TabIndex = 12
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(193, 22)
        Me.label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(110, 18)
        Me.label2.TabIndex = 11
        Me.label2.Text = "昇順でソート："
        '
        'listBox2
        '
        Me.listBox2.FormattingEnabled = True
        Me.listBox2.ItemHeight = 18
        Me.listBox2.Location = New System.Drawing.Point(194, 50)
        Me.listBox2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.listBox2.Name = "listBox2"
        Me.listBox2.Size = New System.Drawing.Size(164, 148)
        Me.listBox2.TabIndex = 10
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(16, 22)
        Me.label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(77, 18)
        Me.label1.TabIndex = 9
        Me.label1.Text = "ソート前："
        '
        'listBox1
        '
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.ItemHeight = 18
        Me.listBox1.Location = New System.Drawing.Point(18, 50)
        Me.listBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(164, 148)
        Me.listBox1.TabIndex = 8
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(19, 208)
        Me.button1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(518, 80)
        Me.button1.TabIndex = 7
        Me.button1.Text = "配列の要素を並び替える"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 310)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.listBox3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.listBox2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.listBox1)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label3 As Label
    Private WithEvents listBox3 As ListBox
    Private WithEvents label2 As Label
    Private WithEvents listBox2 As ListBox
    Private WithEvents label1 As Label
    Private WithEvents listBox1 As ListBox
    Private WithEvents button1 As Button
End Class
