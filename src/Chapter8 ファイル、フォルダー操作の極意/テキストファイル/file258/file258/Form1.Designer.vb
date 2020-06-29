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
        Me.checkBox4 = New System.Windows.Forms.CheckBox()
        Me.checkBox3 = New System.Windows.Forms.CheckBox()
        Me.checkBox2 = New System.Windows.Forms.CheckBox()
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'checkBox4
        '
        Me.checkBox4.AutoSize = True
        Me.checkBox4.Location = New System.Drawing.Point(238, 138)
        Me.checkBox4.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.checkBox4.Name = "checkBox4"
        Me.checkBox4.Size = New System.Drawing.Size(143, 22)
        Me.checkBox4.TabIndex = 18
        Me.checkBox4.Text = "システムファイル"
        Me.checkBox4.UseVisualStyleBackColor = True
        '
        'checkBox3
        '
        Me.checkBox3.AutoSize = True
        Me.checkBox3.Location = New System.Drawing.Point(36, 138)
        Me.checkBox3.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.checkBox3.Name = "checkBox3"
        Me.checkBox3.Size = New System.Drawing.Size(121, 22)
        Me.checkBox3.TabIndex = 17
        Me.checkBox3.Text = "圧縮ファイル"
        Me.checkBox3.UseVisualStyleBackColor = True
        '
        'checkBox2
        '
        Me.checkBox2.AutoSize = True
        Me.checkBox2.Location = New System.Drawing.Point(238, 83)
        Me.checkBox2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(116, 22)
        Me.checkBox2.TabIndex = 16
        Me.checkBox2.Text = "隠しファイル"
        Me.checkBox2.UseVisualStyleBackColor = True
        '
        'checkBox1
        '
        Me.checkBox1.AutoSize = True
        Me.checkBox1.Location = New System.Drawing.Point(36, 83)
        Me.checkBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(133, 22)
        Me.checkBox1.TabIndex = 15
        Me.checkBox1.Text = "読み取り専用"
        Me.checkBox1.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(36, 205)
        Me.button1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(433, 80)
        Me.button1.TabIndex = 14
        Me.button1.Text = "ファイルの属性を取得する"
        Me.button1.UseVisualStyleBackColor = True
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(36, 23)
        Me.textBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(431, 25)
        Me.textBox1.TabIndex = 13
        Me.textBox1.Text = "c:\VB2019\sample.txt"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 309)
        Me.Controls.Add(Me.checkBox4)
        Me.Controls.Add(Me.checkBox3)
        Me.Controls.Add(Me.checkBox2)
        Me.Controls.Add(Me.checkBox1)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.textBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents checkBox4 As CheckBox
    Private WithEvents checkBox3 As CheckBox
    Private WithEvents checkBox2 As CheckBox
    Private WithEvents checkBox1 As CheckBox
    Private WithEvents button1 As Button
    Private WithEvents textBox1 As TextBox
End Class
