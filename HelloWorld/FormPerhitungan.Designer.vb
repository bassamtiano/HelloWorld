<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPerhitungan
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
        Me.TxtNilai1 = New System.Windows.Forms.TextBox()
        Me.TxtNilai2 = New System.Windows.Forms.TextBox()
        Me.LblSimbolTambah = New System.Windows.Forms.Label()
        Me.BtnHitung = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtNilai1
        '
        Me.TxtNilai1.Location = New System.Drawing.Point(45, 44)
        Me.TxtNilai1.Name = "TxtNilai1"
        Me.TxtNilai1.Size = New System.Drawing.Size(100, 20)
        Me.TxtNilai1.TabIndex = 0
        '
        'TxtNilai2
        '
        Me.TxtNilai2.Location = New System.Drawing.Point(181, 44)
        Me.TxtNilai2.Name = "TxtNilai2"
        Me.TxtNilai2.Size = New System.Drawing.Size(100, 20)
        Me.TxtNilai2.TabIndex = 1
        '
        'LblSimbolTambah
        '
        Me.LblSimbolTambah.AutoSize = True
        Me.LblSimbolTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSimbolTambah.Location = New System.Drawing.Point(151, 44)
        Me.LblSimbolTambah.Name = "LblSimbolTambah"
        Me.LblSimbolTambah.Size = New System.Drawing.Size(24, 25)
        Me.LblSimbolTambah.TabIndex = 2
        Me.LblSimbolTambah.Text = "+"
        '
        'BtnHitung
        '
        Me.BtnHitung.Location = New System.Drawing.Point(125, 72)
        Me.BtnHitung.Name = "BtnHitung"
        Me.BtnHitung.Size = New System.Drawing.Size(75, 23)
        Me.BtnHitung.TabIndex = 3
        Me.BtnHitung.Text = "Button1"
        Me.BtnHitung.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 125)
        Me.Controls.Add(Me.BtnHitung)
        Me.Controls.Add(Me.LblSimbolTambah)
        Me.Controls.Add(Me.TxtNilai2)
        Me.Controls.Add(Me.TxtNilai1)
        Me.Name = "Form1"
        Me.Text = "Hello TI-B"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNilai1 As TextBox
    Friend WithEvents TxtNilai2 As TextBox
    Friend WithEvents LblSimbolTambah As Label
    Friend WithEvents BtnHitung As Button
End Class
