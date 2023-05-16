Public Class FormWatermark
    Public namaFile As String

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim kata As String = txtKata.Text
        Dim wtrmark As String
        Dim font As New Font("Verdana", 16, FontStyle.Bold)
        Dim brush As New SolidBrush(Color.FromArgb(64, 192, 255, 255))
        brush.Color = Color.FromArgb(255, 0, 0, 0)
        Form1.PictureBox1.CreateGraphics.DrawString(kata, font, brush, 150, 190)
    End Sub
End Class