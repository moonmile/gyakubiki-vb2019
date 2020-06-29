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
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.textBox6 = New System.Windows.Forms.TextBox()
        Me.textBox5 = New System.Windows.Forms.TextBox()
        Me.textBox4 = New System.Windows.Forms.TextBox()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(16, 177)
        Me.label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(57, 18)
        Me.label4.TabIndex = 21
        Me.label4.Text = "Pages:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(16, 140)
        Me.label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(51, 18)
        Me.label3.TabIndex = 20
        Me.label3.Text = "Price:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(16, 103)
        Me.label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(46, 18)
        Me.label2.TabIndex = 19
        Me.label2.Text = "Title:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(16, 65)
        Me.label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(28, 18)
        Me.label1.TabIndex = 18
        Me.label1.Text = "ID:"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(14, 211)
        Me.button1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(432, 57)
        Me.button1.TabIndex = 17
        Me.button1.Text = "送信"
        Me.button1.UseVisualStyleBackColor = True
        '
        'textBox6
        '
        Me.textBox6.Location = New System.Drawing.Point(14, 277)
        Me.textBox6.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox6.Multiline = True
        Me.textBox6.Name = "textBox6"
        Me.textBox6.Size = New System.Drawing.Size(431, 100)
        Me.textBox6.TabIndex = 16
        '
        'textBox5
        '
        Me.textBox5.Location = New System.Drawing.Point(144, 173)
        Me.textBox5.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox5.Name = "textBox5"
        Me.textBox5.Size = New System.Drawing.Size(301, 25)
        Me.textBox5.TabIndex = 15
        Me.textBox5.Text = "100"
        '
        'textBox4
        '
        Me.textBox4.Location = New System.Drawing.Point(144, 135)
        Me.textBox4.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New System.Drawing.Size(301, 25)
        Me.textBox4.TabIndex = 14
        Me.textBox4.Text = "2000"
        '
        'textBox3
        '
        Me.textBox3.Location = New System.Drawing.Point(144, 98)
        Me.textBox3.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(301, 25)
        Me.textBox3.TabIndex = 13
        Me.textBox3.Text = "新刊本"
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(144, 61)
        Me.textBox2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(301, 25)
        Me.textBox2.TabIndex = 12
        Me.textBox2.Text = "100"
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(14, 23)
        Me.textBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(431, 25)
        Me.textBox1.TabIndex = 11
        Me.textBox1.Text = "http://localhost:5000/api/Books/"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 395)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.textBox6)
        Me.Controls.Add(Me.textBox5)
        Me.Controls.Add(Me.textBox4)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.textBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents button1 As Button
    Private WithEvents textBox6 As TextBox
    Private WithEvents textBox5 As TextBox
    Private WithEvents textBox4 As TextBox
    Private WithEvents textBox3 As TextBox
    Private WithEvents textBox2 As TextBox
    Private WithEvents textBox1 As TextBox
End Class
