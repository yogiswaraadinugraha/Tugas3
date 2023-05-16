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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropertiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistogramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreyscaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerahkanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GelapkanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahKontrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KurangiKontrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TampilkanHistogramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EffectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TajamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KaburkanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Putar90DerajarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlipHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlipHorizontalManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlipVertikalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdgeDetectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EffectTugas3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WatermarkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InversiWarnaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RonaMerahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RonaHijauToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RonaBiruToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RonaSpesialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HistogramToolStripMenuItem, Me.EffectsToolStripMenuItem, Me.EffectTugas3ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BukaToolStripMenuItem, Me.SimpanToolStripMenuItem, Me.PropertiToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'BukaToolStripMenuItem
        '
        Me.BukaToolStripMenuItem.Name = "BukaToolStripMenuItem"
        Me.BukaToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.BukaToolStripMenuItem.Text = "Buka"
        '
        'SimpanToolStripMenuItem
        '
        Me.SimpanToolStripMenuItem.Name = "SimpanToolStripMenuItem"
        Me.SimpanToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SimpanToolStripMenuItem.Text = "Simpan"
        '
        'PropertiToolStripMenuItem
        '
        Me.PropertiToolStripMenuItem.Name = "PropertiToolStripMenuItem"
        Me.PropertiToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.PropertiToolStripMenuItem.Text = "Properti"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'HistogramToolStripMenuItem
        '
        Me.HistogramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GreyscaleToolStripMenuItem, Me.CerahkanToolStripMenuItem, Me.GelapkanToolStripMenuItem, Me.TambahKontrasToolStripMenuItem, Me.KurangiKontrasToolStripMenuItem, Me.ResetToolStripMenuItem, Me.TampilkanHistogramToolStripMenuItem})
        Me.HistogramToolStripMenuItem.Name = "HistogramToolStripMenuItem"
        Me.HistogramToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.HistogramToolStripMenuItem.Text = "Histogram"
        '
        'GreyscaleToolStripMenuItem
        '
        Me.GreyscaleToolStripMenuItem.Name = "GreyscaleToolStripMenuItem"
        Me.GreyscaleToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.GreyscaleToolStripMenuItem.Text = "Greyscale"
        '
        'CerahkanToolStripMenuItem
        '
        Me.CerahkanToolStripMenuItem.Name = "CerahkanToolStripMenuItem"
        Me.CerahkanToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.CerahkanToolStripMenuItem.Text = "Cerahkan"
        '
        'GelapkanToolStripMenuItem
        '
        Me.GelapkanToolStripMenuItem.Name = "GelapkanToolStripMenuItem"
        Me.GelapkanToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.GelapkanToolStripMenuItem.Text = "Gelapkan"
        '
        'TambahKontrasToolStripMenuItem
        '
        Me.TambahKontrasToolStripMenuItem.Name = "TambahKontrasToolStripMenuItem"
        Me.TambahKontrasToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.TambahKontrasToolStripMenuItem.Text = "Tambah Kontras"
        '
        'KurangiKontrasToolStripMenuItem
        '
        Me.KurangiKontrasToolStripMenuItem.Name = "KurangiKontrasToolStripMenuItem"
        Me.KurangiKontrasToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.KurangiKontrasToolStripMenuItem.Text = "Kurangi Kontras"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'TampilkanHistogramToolStripMenuItem
        '
        Me.TampilkanHistogramToolStripMenuItem.Name = "TampilkanHistogramToolStripMenuItem"
        Me.TampilkanHistogramToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.TampilkanHistogramToolStripMenuItem.Text = "Tampilkan Histogram"
        '
        'EffectsToolStripMenuItem
        '
        Me.EffectsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TajamToolStripMenuItem, Me.KaburkanToolStripMenuItem, Me.Putar90DerajarToolStripMenuItem, Me.FlipHorizontalToolStripMenuItem, Me.FlipHorizontalManualToolStripMenuItem, Me.FlipVertikalToolStripMenuItem, Me.EdgeDetectionToolStripMenuItem})
        Me.EffectsToolStripMenuItem.Name = "EffectsToolStripMenuItem"
        Me.EffectsToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.EffectsToolStripMenuItem.Text = "Effects"
        '
        'TajamToolStripMenuItem
        '
        Me.TajamToolStripMenuItem.Name = "TajamToolStripMenuItem"
        Me.TajamToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.TajamToolStripMenuItem.Text = "Tajam"
        '
        'KaburkanToolStripMenuItem
        '
        Me.KaburkanToolStripMenuItem.Name = "KaburkanToolStripMenuItem"
        Me.KaburkanToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.KaburkanToolStripMenuItem.Text = "Kaburkan"
        '
        'Putar90DerajarToolStripMenuItem
        '
        Me.Putar90DerajarToolStripMenuItem.Name = "Putar90DerajarToolStripMenuItem"
        Me.Putar90DerajarToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.Putar90DerajarToolStripMenuItem.Text = "Putar 90 Derajat"
        '
        'FlipHorizontalToolStripMenuItem
        '
        Me.FlipHorizontalToolStripMenuItem.Name = "FlipHorizontalToolStripMenuItem"
        Me.FlipHorizontalToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.FlipHorizontalToolStripMenuItem.Text = "Flip Horizontal"
        '
        'FlipHorizontalManualToolStripMenuItem
        '
        Me.FlipHorizontalManualToolStripMenuItem.Name = "FlipHorizontalManualToolStripMenuItem"
        Me.FlipHorizontalManualToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.FlipHorizontalManualToolStripMenuItem.Text = "Flip Horizontal Manual"
        '
        'FlipVertikalToolStripMenuItem
        '
        Me.FlipVertikalToolStripMenuItem.Name = "FlipVertikalToolStripMenuItem"
        Me.FlipVertikalToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.FlipVertikalToolStripMenuItem.Text = "Flip Vertikal"
        '
        'EdgeDetectionToolStripMenuItem
        '
        Me.EdgeDetectionToolStripMenuItem.Name = "EdgeDetectionToolStripMenuItem"
        Me.EdgeDetectionToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.EdgeDetectionToolStripMenuItem.Text = "Edge Detection"
        '
        'EffectTugas3ToolStripMenuItem
        '
        Me.EffectTugas3ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorderToolStripMenuItem, Me.WatermarkToolStripMenuItem, Me.InversiWarnaToolStripMenuItem, Me.RonaMerahToolStripMenuItem, Me.RonaHijauToolStripMenuItem, Me.RonaBiruToolStripMenuItem, Me.RonaSpesialToolStripMenuItem})
        Me.EffectTugas3ToolStripMenuItem.Name = "EffectTugas3ToolStripMenuItem"
        Me.EffectTugas3ToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.EffectTugas3ToolStripMenuItem.Text = "Effect Tugas 3"
        '
        'BorderToolStripMenuItem
        '
        Me.BorderToolStripMenuItem.Name = "BorderToolStripMenuItem"
        Me.BorderToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BorderToolStripMenuItem.Text = "Border"
        '
        'WatermarkToolStripMenuItem
        '
        Me.WatermarkToolStripMenuItem.Name = "WatermarkToolStripMenuItem"
        Me.WatermarkToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.WatermarkToolStripMenuItem.Text = "Watermark"
        '
        'InversiWarnaToolStripMenuItem
        '
        Me.InversiWarnaToolStripMenuItem.Name = "InversiWarnaToolStripMenuItem"
        Me.InversiWarnaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.InversiWarnaToolStripMenuItem.Text = "Inversi Warna"
        '
        'RonaMerahToolStripMenuItem
        '
        Me.RonaMerahToolStripMenuItem.Name = "RonaMerahToolStripMenuItem"
        Me.RonaMerahToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RonaMerahToolStripMenuItem.Text = "Rona Merah"
        '
        'RonaHijauToolStripMenuItem
        '
        Me.RonaHijauToolStripMenuItem.Name = "RonaHijauToolStripMenuItem"
        Me.RonaHijauToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RonaHijauToolStripMenuItem.Text = "Rona Hijau"
        '
        'RonaBiruToolStripMenuItem
        '
        Me.RonaBiruToolStripMenuItem.Name = "RonaBiruToolStripMenuItem"
        Me.RonaBiruToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RonaBiruToolStripMenuItem.Text = "Rona Biru"
        '
        'RonaSpesialToolStripMenuItem
        '
        Me.RonaSpesialToolStripMenuItem.Name = "RonaSpesialToolStripMenuItem"
        Me.RonaSpesialToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RonaSpesialToolStripMenuItem.Text = "Rona Spesial"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(800, 426)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pengolahan Citra "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents SaveFileDialog2 As SaveFileDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistogramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EffectsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PropertiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GreyscaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerahkanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GelapkanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahKontrasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KurangiKontrasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TampilkanHistogramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TajamToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KaburkanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Putar90DerajarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlipHorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlipVertikalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EdgeDetectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlipHorizontalManualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EffectTugas3ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WatermarkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InversiWarnaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RonaMerahToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RonaHijauToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RonaBiruToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RonaSpesialToolStripMenuItem As ToolStripMenuItem
End Class
