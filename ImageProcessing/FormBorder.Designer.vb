<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBorder
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
        Me.cmbWarnaBorder = New System.Windows.Forms.ComboBox()
        Me.cmbKetebalanBorder = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Warna Border : "
        '
        'cmbWarnaBorder
        '
        Me.cmbWarnaBorder.FormattingEnabled = True
        Me.cmbWarnaBorder.Items.AddRange(New Object() {"Merah", "Hijau", "Biru"})
        Me.cmbWarnaBorder.Location = New System.Drawing.Point(185, 44)
        Me.cmbWarnaBorder.Name = "cmbWarnaBorder"
        Me.cmbWarnaBorder.Size = New System.Drawing.Size(121, 21)
        Me.cmbWarnaBorder.TabIndex = 1
        '
        'cmbKetebalanBorder
        '
        Me.cmbKetebalanBorder.FormattingEnabled = True
        Me.cmbKetebalanBorder.Items.AddRange(New Object() {"2px", "4px", "6px", "8px", "10px"})
        Me.cmbKetebalanBorder.Location = New System.Drawing.Point(185, 93)
        Me.cmbKetebalanBorder.Name = "cmbKetebalanBorder"
        Me.cmbKetebalanBorder.Size = New System.Drawing.Size(121, 21)
        Me.cmbKetebalanBorder.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ketebalan Border : "
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(73, 180)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(75, 23)
        Me.btnBatal.TabIndex = 4
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(231, 180)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 5
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'FormBorder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 321)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnBatal)
        Me.Controls.Add(Me.cmbKetebalanBorder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbWarnaBorder)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormBorder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormBorder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbWarnaBorder As ComboBox
    Friend WithEvents cmbKetebalanBorder As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnSimpan As Button
End Class
