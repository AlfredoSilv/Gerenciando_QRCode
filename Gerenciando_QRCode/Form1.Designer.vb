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
        Me.picImagem = New System.Windows.Forms.PictureBox()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnLer = New System.Windows.Forms.Button()
        Me.btnCarregar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnGerar = New System.Windows.Forms.Button()
        Me.txtQRCode = New System.Windows.Forms.TextBox()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.prnQRCode = New System.Drawing.Printing.PrintDocument()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.picImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picImagem
        '
        Me.picImagem.Location = New System.Drawing.Point(18, 55)
        Me.picImagem.Name = "picImagem"
        Me.picImagem.Size = New System.Drawing.Size(327, 348)
        Me.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picImagem.TabIndex = 0
        Me.picImagem.TabStop = False
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(351, 57)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(150, 40)
        Me.btnSair.TabIndex = 3
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnLer
        '
        Me.btnLer.Location = New System.Drawing.Point(351, 108)
        Me.btnLer.Name = "btnLer"
        Me.btnLer.Size = New System.Drawing.Size(150, 40)
        Me.btnLer.TabIndex = 4
        Me.btnLer.Text = "Ler QRCode"
        Me.btnLer.UseVisualStyleBackColor = True
        '
        'btnCarregar
        '
        Me.btnCarregar.Location = New System.Drawing.Point(351, 159)
        Me.btnCarregar.Name = "btnCarregar"
        Me.btnCarregar.Size = New System.Drawing.Size(150, 40)
        Me.btnCarregar.TabIndex = 5
        Me.btnCarregar.Text = "Carregar QRCode"
        Me.btnCarregar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(351, 210)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(150, 40)
        Me.btnSalvar.TabIndex = 6
        Me.btnSalvar.Text = "Salvar QRCode"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnGerar
        '
        Me.btnGerar.Location = New System.Drawing.Point(351, 261)
        Me.btnGerar.Name = "btnGerar"
        Me.btnGerar.Size = New System.Drawing.Size(150, 40)
        Me.btnGerar.TabIndex = 7
        Me.btnGerar.Text = "Gerar QRCode"
        Me.btnGerar.UseVisualStyleBackColor = True
        '
        'txtQRCode
        '
        Me.txtQRCode.Location = New System.Drawing.Point(507, 55)
        Me.txtQRCode.Multiline = True
        Me.txtQRCode.Name = "txtQRCode"
        Me.txtQRCode.Size = New System.Drawing.Size(327, 348)
        Me.txtQRCode.TabIndex = 8
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(351, 363)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(150, 40)
        Me.btnLimpar.TabIndex = 9
        Me.btnLimpar.Text = "Limpar Texto"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(351, 312)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(150, 40)
        Me.btnImprimir.TabIndex = 10
        Me.btnImprimir.Text = "Imprime QRCode"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'prnQRCode
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "QRCode:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(504, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Texto do QRCode:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 418)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.txtQRCode)
        Me.Controls.Add(Me.btnGerar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnCarregar)
        Me.Controls.Add(Me.btnLer)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.picImagem)
        Me.Name = "Form1"
        Me.Text = "QRCode Manager"
        CType(Me.picImagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picImagem As PictureBox
    Friend WithEvents btnSair As Button
    Friend WithEvents btnLer As Button
    Friend WithEvents btnCarregar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnGerar As Button
    Friend WithEvents txtQRCode As TextBox
    Friend WithEvents btnLimpar As Button
    Friend WithEvents btnImprimir As Button
    Friend WithEvents prnQRCode As Printing.PrintDocument
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
