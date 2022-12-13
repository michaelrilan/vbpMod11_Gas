<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.input_usd = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.results = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Input USD to convert into CAD liter/s:"
        '
        'input_usd
        '
        Me.input_usd.Location = New System.Drawing.Point(222, 34)
        Me.input_usd.Name = "input_usd"
        Me.input_usd.Size = New System.Drawing.Size(100, 20)
        Me.input_usd.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(97, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Convert"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'results
        '
        Me.results.AutoSize = True
        Me.results.Location = New System.Drawing.Point(40, 144)
        Me.results.Name = "results"
        Me.results.Size = New System.Drawing.Size(10, 13)
        Me.results.TabIndex = 3
        Me.results.Text = ":"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 288)
        Me.Controls.Add(Me.results)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.input_usd)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "vbpMod11_Gas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents input_usd As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents results As Label
End Class
