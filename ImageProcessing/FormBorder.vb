Public Class FormBorder
    Public namaFile As String
    Dim bmp As Bitmap = DirectCast(Form1.PictureBox1.Image, Bitmap)
    Dim warna As String
    Dim borderPixel As String = String.Empty

    Sub refresh()
        Form1.PictureBox1.BorderStyle = BorderStyle.None
        Dim r, g, b As Integer
        Dim originalImage = New Bitmap(namaFile)

        For bar As Integer = 0 To Form1.PictureBox1.Image.Height - 1
            For kol As Integer = 0 To Form1.PictureBox1.Image.Width - 1
                r = bmp.GetPixel(kol, bar).R
                g = bmp.GetPixel(kol, bar).G
                b = bmp.GetPixel(kol, bar).B
                bmp.SetPixel(kol, bar, Color.FromArgb(r, g, b))
            Next
        Next
        bmp = originalImage
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If warna = String.Empty Or borderPixel = String.Empty Then
            MsgBox("masukkan property terlebih dahulu..")
        Else
            refresh()
            Dim gr As Graphics = Graphics.FromImage(bmp)
            If warna.Equals("Merah") Then
                gr.DrawRectangle(New Pen(Color.Red, borderPixel), 0, 0, bmp.Width, bmp.Height)
                gr.Dispose()
            ElseIf warna.Equals("Hijau") Then
                gr.DrawRectangle(New Pen(Color.Green, borderPixel), 0, 0, bmp.Width, bmp.Height)
                gr.Dispose()
            ElseIf warna.Equals("Biru") Then
                gr.DrawRectangle(New Pen(Color.Blue, borderPixel), 0, 0, bmp.Width, bmp.Height)
                gr.Dispose()
            End If
            Form1.PictureBox1.Image = bmp
            Me.Close()
        End If

    End Sub

    Private Sub cmbWarnaBorder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbWarnaBorder.SelectedIndexChanged
        warna = cmbWarnaBorder.SelectedItem.ToString
    End Sub

    Private Sub cmbKetebalanBorder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKetebalanBorder.SelectedIndexChanged
        Dim input As String = cmbKetebalanBorder.SelectedItem.ToString
        Dim numbers() As Char = input.ToCharArray()
        For Each ch As Char In numbers
            If Char.IsDigit(ch) Then
                borderPixel += ch.ToString()
            End If
        Next
    End Sub
End Class