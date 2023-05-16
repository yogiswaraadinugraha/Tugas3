Public Class Form1
    Dim namaFile As String
    Private Sub BukaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaToolStripMenuItem.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "Bitmap files (*.bmp)|*.bmp|JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png"
        openFileDialog1.FilterIndex = 2
        'kembali ke folder utama
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(openFileDialog1.FileName)
            namaFile = openFileDialog1.FileName

            HistogramToolStripMenuItem.Enabled = True
            SimpanToolStripMenuItem.Enabled = True
            PropertiToolStripMenuItem.Enabled = True
            EffectsToolStripMenuItem.Enabled = True
            EffectTugas3ToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub SimpanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanToolStripMenuItem.Click
        If PictureBox1.Image Is Nothing Then
            MsgBox("Buka file foto terlebih dahulu..")
        Else
            Dim saveFileDialog1 As New SaveFileDialog()
            Dim MyPicture As Image
            MyPicture = PictureBox1.Image
            saveFileDialog1.Filter = "Bitmap files (*.bmp)|*.bmp|JPG files (*.jpg)|*.jpg|PNG Files (*.png)|*.png"
            saveFileDialog1.FilterIndex = 2
            saveFileDialog1.RestoreDirectory = True
            If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                If saveFileDialog1.FilterIndex = 1 Then
                    'apapun yang ada di dalam picturebox akan disimpan dalam format bmp
                    MyPicture.Save(saveFileDialog1.FileName,
                   System.Drawing.Imaging.ImageFormat.Bmp)
                End If
                If saveFileDialog1.FilterIndex = 2 Then
                    'apapun yang ada di dalam picturebox akan disimpan dalam format jpg
                    MyPicture.Save(saveFileDialog1.FileName,
                   System.Drawing.Imaging.ImageFormat.Jpeg)
                End If
                If saveFileDialog1.FilterIndex = 3 Then
                    'apapun yang ada di dalam picturebox akan disimpan dalam format png
                    MyPicture.Save(saveFileDialog1.FileName,
                    System.Drawing.Imaging.ImageFormat.Png)
                End If
            End If
        End If
    End Sub

    Private Sub PropertiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropertiToolStripMenuItem.Click
        If PictureBox1.Image Is Nothing Then
            MsgBox("Buka file foto terlebih dahulu..")
        Else
            MessageBox.Show("Nama File: " + namaFile + vbCr + "Lebar: " + PictureBox1.Image.Width.ToString + vbCr + "Tinggi: " + PictureBox1.Image.Height.ToString)
        End If
    End Sub
    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub GreyscaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyscaleToolStripMenuItem.Click
        If PictureBox1.Image Is Nothing Then
            MsgBox("Buka file foto terlebih dahulu..")
        Else
            Dim r, g, b, gray As Integer
            Dim bmp = New Bitmap(PictureBox1.Image)

            For bar As Integer = 0 To PictureBox1.Image.Height - 1
                For kol As Integer = 0 To PictureBox1.Image.Width - 1
                    r = bmp.GetPixel(kol, bar).R
                    g = bmp.GetPixel(kol, bar).G
                    b = bmp.GetPixel(kol, bar).B
                    'nilai tidak boleh pecahan, jadi gunakan round
                    gray = Math.Round(0.2126 * r + 0.7152 * g + 0.0722 * b)
                    bmp.SetPixel(kol, bar, Color.FromArgb(gray, gray, gray))
                Next
            Next
            PictureBox1.Image = bmp
        End If
    End Sub

    Private Sub CerahkanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerahkanToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)

        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R + 10
                g = bmp.GetPixel(kol, bar).G + 10
                b = bmp.GetPixel(kol, bar).B + 10
                'kalo udh smpe 255 maka ketika diturunkan tidak bisa sesuai dengan warna aslinya
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        MsgBox("R: " + r.ToString + " ,G: " + g.ToString + " ,B: " + b.ToString)
        PictureBox1.Image = bmp
    End Sub

    Private Sub GelapkanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GelapkanToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)

        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R - 10
                g = bmp.GetPixel(kol, bar).G - 10
                b = bmp.GetPixel(kol, bar).B - 10
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        MsgBox("R: " + r.ToString + " ,G: " + g.ToString + " ,B: " + b.ToString)
        PictureBox1.Image = bmp
    End Sub

    'contrast, yang hitam makin hitam, yang terang makin terang
    Private Sub TambahKontrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahKontrasToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B
                'kenapa di kali 1.1 tidak 2, karna supaya dikit demi dikit
                r = Math.Round(128 + (1.1 * (r - 128)))
                g = Math.Round(128 + (1.1 * (g - 128)))
                b = Math.Round(128 + (1.1 * (b - 128)))
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub KurangiKontrasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KurangiKontrasToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B
                r = Math.Round(128 + (0.90909 * (r - 128)))
                g = Math.Round(128 + (0.90909 * (g - 128)))
                b = Math.Round(128 + (0.90909 * (b - 128)))
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(namaFile)

        For bar As Integer = 0 To PictureBox1.Image.Height - 1
            For kol As Integer = 0 To PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub TampilkanHistogramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TampilkanHistogramToolStripMenuItem.Click
        Form2.ShowDialog()
    End Sub

    Private Sub TajamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TajamToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        Dim kernel As Integer() = {-1, -1, -1, -1, 8, -1, -1, -1, -1}

        For bar As Integer = 1 To PictureBox1.Image.Height - 2
            For kol As Integer = 1 To PictureBox1.Image.Width - 2
                r = 0
                g = 0
                b = 0
                For i As Integer = 0 To 8
                    r = r + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).R)
                    g = g + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).G)
                    b = b + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).B)
                Next
                r = Math.Floor(r / 3)
                g = Math.Floor(g / 3)
                b = Math.Floor(b / 3)
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
    End Sub

    Private Sub KaburkanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KaburkanToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        Dim kernel As Integer() = {1, 1, 1, 1, 1, 1, 1, 1, 1}

        For bar As Integer = 1 To PictureBox1.Image.Height - 2
            For kol As Integer = 1 To PictureBox1.Image.Width - 2
                r = 0
                g = 0
                b = 0
                For i As Integer = 0 To 8
                    r = r + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).R)
                    g = g + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).G)
                    b = b + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).B)
                Next
                r = Math.Floor(r / 9)
                g = Math.Floor(g / 9)
                b = Math.Floor(b / 9)
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub Putar90DerajarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Putar90DerajarToolStripMenuItem.Click
        Dim bmp = New Bitmap(PictureBox1.Image)
        bmp.RotateFlip(RotateFlipType.Rotate90FlipNone)
        PictureBox1.Image = bmp
    End Sub

    Private Sub FlipHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlipHorizontalToolStripMenuItem.Click
        Dim bmp = New Bitmap(PictureBox1.Image)
        bmp.RotateFlip(RotateFlipType.RotateNoneFlipX)
        PictureBox1.Image = bmp
    End Sub

    Private Sub FlipVertikalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlipVertikalToolStripMenuItem.Click
        Dim bmp = New Bitmap(PictureBox1.Image)
        bmp.RotateFlip(RotateFlipType.RotateNoneFlipY)
        PictureBox1.Image = bmp
    End Sub

    Private Sub FlipHorizontalManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlipHorizontalManualToolStripMenuItem.Click
        Dim original As Bitmap = New Bitmap(PictureBox1.Image)
        Dim mirrorImage As Bitmap = New Bitmap(original.Width, original.Height)
        For y As Integer = 0 To original.Height - 1
            Dim ix As Integer = 0, rx As Integer = original.Width - 1
            While ix < original.Width
                Dim color As Color = original.GetPixel(ix, y)
                mirrorImage.SetPixel(rx, y, color)
                ix += 1
                rx -= 1
            End While
        Next
        PictureBox1.Image = mirrorImage
    End Sub

    Private Sub EdgeDetectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EdgeDetectionToolStripMenuItem.Click
        Dim r, g, b As Integer
        Dim bmp = New Bitmap(PictureBox1.Image)
        Dim kernel As Integer() = {-1, -1, -1, -1, 8, -1, -1, -1, -1}

        For bar As Integer = 1 To PictureBox1.Image.Height - 2
            For kol As Integer = 1 To PictureBox1.Image.Width - 2
                r = 0
                g = 0
                b = 0
                For i As Integer = 0 To 8
                    r = r + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).R)
                    g = g + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).G)
                    b = b + (kernel(i) * bmp.GetPixel(kol - 1 + (i Mod 3), bar - 1 + (i \ 3)).B)
                Next
                r = Math.Floor(r / 3)
                g = Math.Floor(g / 3)
                b = Math.Floor(b / 3)
                If r < 0 Then r = 0
                If g < 0 Then g = 0
                If b < 0 Then b = 0
                If r > 255 Then r = 255
                If g > 255 Then g = 255
                If b > 255 Then b = 255
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        PictureBox1.Image = bmp
    End Sub

    Private Sub BorderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorderToolStripMenuItem.Click
        Dim showFormBoder As New FormBorder
        showFormBoder.namaFile = namaFile
        showFormBoder.Show()
    End Sub

    Private Sub WatermarkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WatermarkToolStripMenuItem.Click
        Dim showFormWatermark As New FormWatermark
        showFormWatermark.namaFile = namaFile
        showFormWatermark.Show()
    End Sub

    Private Sub RonaMerahToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RonaMerahToolStripMenuItem.Click
        If PictureBox1.Image Is Nothing Then
            MsgBox("Buka file foto terlebih dahulu..")
        Else
            Dim r, g, b As Integer
            Dim bmp As Bitmap = New Bitmap(PictureBox1.Image)

            For bar As Integer = 0 To PictureBox1.Image.Height - 1
                For kol As Integer = 0 To PictureBox1.Image.Width - 1
                    Dim oldPixelColor As Color = bmp.GetPixel(kol, bar)
                    Dim newPixelColor As Color = Color.FromArgb(oldPixelColor.R, 0, 0)
                    bmp.SetPixel(kol, bar, newPixelColor)
                Next
            Next
            PictureBox1.Image = bmp
        End If
    End Sub

    Private Sub RonaHijauToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RonaHijauToolStripMenuItem.Click
        If PictureBox1.Image Is Nothing Then
            MsgBox("Buka file foto terlebih dahulu..")
        Else
            Dim r, g, b As Integer
            Dim bmp As Bitmap = New Bitmap(PictureBox1.Image)

            For bar As Integer = 0 To PictureBox1.Image.Height - 1
                For kol As Integer = 0 To PictureBox1.Image.Width - 1
                    Dim oldPixelColor As Color = bmp.GetPixel(kol, bar)
                    Dim newPixelColor As Color = Color.FromArgb(0, oldPixelColor.G, 0)
                    bmp.SetPixel(kol, bar, newPixelColor)
                Next
            Next
            PictureBox1.Image = bmp
        End If
    End Sub

    Private Sub RonaBiruToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RonaBiruToolStripMenuItem.Click
        If PictureBox1.Image Is Nothing Then
            MsgBox("Buka file foto terlebih dahulu..")
        Else
            Dim r, g, b As Integer
            Dim bmp As Bitmap = New Bitmap(PictureBox1.Image)

            For bar As Integer = 0 To PictureBox1.Image.Height - 1
                For kol As Integer = 0 To PictureBox1.Image.Width - 1
                    Dim oldPixelColor As Color = bmp.GetPixel(kol, bar)
                    Dim newPixelColor As Color = Color.FromArgb(0, 0, oldPixelColor.B)
                    bmp.SetPixel(kol, bar, newPixelColor)
                Next
            Next
            PictureBox1.Image = bmp
        End If
    End Sub

    Private Sub InversiWarnaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InversiWarnaToolStripMenuItem.Click
        Dim bm As New Bitmap(PictureBox1.Image)
        Dim X As Integer
        Dim Y As Integer
        Dim r As Integer
        Dim g As Integer
        Dim b As Integer

        For X = 0 To bm.Width - 1
            For Y = 0 To bm.Height - 1
                r = 255 - bm.GetPixel(X, Y).R
                g = 255 - bm.GetPixel(X, Y).G
                b = 255 - bm.GetPixel(X, Y).B
                bm.SetPixel(X, Y, Color.FromArgb(r, g, b))
            Next Y
        Next X

        PictureBox1.Image = bm
    End Sub

    Private Sub RonaSpesialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RonaSpesialToolStripMenuItem.Click
        If PictureBox1.Image Is Nothing Then
            MsgBox("Buka file foto terlebih dahulu..")
        Else
            Dim r, g, b As Integer
            Dim bmp As Bitmap = New Bitmap(PictureBox1.Image)

            For bar As Integer = 0 To PictureBox1.Image.Height - 1
                For kol As Integer = 0 To PictureBox1.Image.Width - 1
                    Dim oldPixelColor As Color = bmp.GetPixel(kol, bar)
                    Dim newPixelColor As Color = Color.FromArgb(255, 215, oldPixelColor.B)
                    bmp.SetPixel(kol, bar, newPixelColor)
                Next
            Next
            PictureBox1.Image = bmp
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HistogramToolStripMenuItem.Enabled = False
        SimpanToolStripMenuItem.Enabled = False
        PropertiToolStripMenuItem.Enabled = False
        EffectsToolStripMenuItem.Enabled = False
        EffectTugas3ToolStripMenuItem.Enabled = False
    End Sub
End Class
