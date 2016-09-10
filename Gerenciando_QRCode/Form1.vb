Imports MessagingToolkit.QRCode.Codec
Imports MessagingToolkit.QRCode.Codec.Data
Public Class Form1
    Private Sub tamanhoNormaldoForm()
        Me.Width = 900
        Me.Height = 650
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub
    Private Sub btnGerar_Click(sender As Object, e As EventArgs) Handles btnGerar.Click
        If Not String.IsNullOrWhiteSpace(txtQRCode.Text) Then
            Try
                tamanhoNormaldoForm()
                Dim QRCodeText As String = txtQRCode.Text
                Dim qrencod As New QRCodeEncoder()
                Dim qrcode As Bitmap = qrencod.Encode(QRCodeText)
                picImagem.Image = TryCast(qrcode, Image)
            Catch ex As Exception
                MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Informe uma texto para gerar o QRCode", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If Not IsNothing(picImagem.Image) Then
            Try
                tamanhoNormaldoForm()
                Dim sfd As New SaveFileDialog()
                sfd.InitialDirectory = "D:\QrCode\"
                sfd.Filter = "JPEG | *.png| JPEG| *.jpg | BMP| *.bmp"
                If sfd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    picImagem.Image.Save(sfd.FileName)
                End If
            Catch ex As Exception
                MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Não existem imagem QRCode", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnCarregar_Click(sender As Object, e As EventArgs) Handles btnCarregar.Click
        Try
            tamanhoNormaldoForm()
            Dim ofd As New OpenFileDialog()
            ofd.InitialDirectory = "D:\QrCode\"
            If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                picImagem.ImageLocation = ofd.FileName
            End If
        Catch ex As Exception
            MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLer_Click(sender As Object, e As EventArgs) Handles btnLer.Click
        If Not IsNothing(picImagem.Image) Then
            Try
                txtQRCode.Text = Nothing
                tamanhoNormaldoForm()
                Dim decoder As New QRCodeDecoder()
                txtQRCode.Text = decoder.Decode(New QRCodeBitmapImage(TryCast(picImagem.Image, Bitmap)))
            Catch ex As Exception
                MessageBox.Show("Erro : " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Selecione a imagem QRCode para decodificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        If txtQRCode.Text = Nothing Then
            Exit Sub
        Else
            txtQRCode.Text = Nothing
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        ' redimensiona a figura para ajustar o tamanho
        picImagem.Width = picImagem.Image.Width + 2
        picImagem.Height = picImagem.Image.Height + 2
        ' imprime a imagem
        prnQRCode.Print()
    End Sub

    Private Sub prnQRCode_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles prnQRCode.PrintPage
        Dim Rect As New Rectangle(80, 80, picImagem.Width, picImagem.Height)
        e.Graphics.DrawImage(picImagem.Image, Rect)
    End Sub
End Class
