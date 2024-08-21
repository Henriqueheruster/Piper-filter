<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TxtcaminhoArquivo = New System.Windows.Forms.TextBox()
        Me.lblNomeArquivoNovo = New System.Windows.Forms.Label()
        Me.txtnomeArquivoNovo = New System.Windows.Forms.TextBox()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtConteudo = New System.Windows.Forms.TextBox()
        Me.txtConteudoNovo = New System.Windows.Forms.TextBox()
        Me.btnlimpar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 45)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Buscar Arquivo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TxtcaminhoArquivo
        '
        Me.TxtcaminhoArquivo.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TxtcaminhoArquivo.Enabled = False
        Me.TxtcaminhoArquivo.Location = New System.Drawing.Point(130, 23)
        Me.TxtcaminhoArquivo.Name = "TxtcaminhoArquivo"
        Me.TxtcaminhoArquivo.ReadOnly = True
        Me.TxtcaminhoArquivo.Size = New System.Drawing.Size(379, 20)
        Me.TxtcaminhoArquivo.TabIndex = 2
        '
        'lblNomeArquivoNovo
        '
        Me.lblNomeArquivoNovo.AutoSize = True
        Me.lblNomeArquivoNovo.Location = New System.Drawing.Point(320, 82)
        Me.lblNomeArquivoNovo.Name = "lblNomeArquivoNovo"
        Me.lblNomeArquivoNovo.Size = New System.Drawing.Size(65, 13)
        Me.lblNomeArquivoNovo.TabIndex = 3
        Me.lblNomeArquivoNovo.Text = "Nome novo:"
        '
        'txtnomeArquivoNovo
        '
        Me.txtnomeArquivoNovo.Location = New System.Drawing.Point(391, 79)
        Me.txtnomeArquivoNovo.Name = "txtnomeArquivoNovo"
        Me.txtnomeArquivoNovo.Size = New System.Drawing.Size(118, 20)
        Me.txtnomeArquivoNovo.TabIndex = 4
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(428, 328)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(103, 36)
        Me.btnSair.TabIndex = 5
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(237, 180)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 36)
        Me.btnModificar.TabIndex = 6
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'txtConteudo
        '
        Me.txtConteudo.Location = New System.Drawing.Point(12, 113)
        Me.txtConteudo.Multiline = True
        Me.txtConteudo.Name = "txtConteudo"
        Me.txtConteudo.ReadOnly = True
        Me.txtConteudo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtConteudo.Size = New System.Drawing.Size(213, 191)
        Me.txtConteudo.TabIndex = 7
        '
        'txtConteudoNovo
        '
        Me.txtConteudoNovo.Location = New System.Drawing.Point(323, 113)
        Me.txtConteudoNovo.Multiline = True
        Me.txtConteudoNovo.Name = "txtConteudoNovo"
        Me.txtConteudoNovo.ReadOnly = True
        Me.txtConteudoNovo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtConteudoNovo.Size = New System.Drawing.Size(213, 191)
        Me.txtConteudoNovo.TabIndex = 8
        '
        'btnlimpar
        '
        Me.btnlimpar.Enabled = False
        Me.btnlimpar.Location = New System.Drawing.Point(323, 328)
        Me.btnlimpar.Name = "btnlimpar"
        Me.btnlimpar.Size = New System.Drawing.Size(99, 34)
        Me.btnlimpar.TabIndex = 9
        Me.btnlimpar.Text = "Limpar"
        Me.btnlimpar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 374)
        Me.Controls.Add(Me.btnlimpar)
        Me.Controls.Add(Me.txtConteudoNovo)
        Me.Controls.Add(Me.txtConteudo)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.txtnomeArquivoNovo)
        Me.Controls.Add(Me.lblNomeArquivoNovo)
        Me.Controls.Add(Me.TxtcaminhoArquivo)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pippe Filter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents TxtcaminhoArquivo As TextBox
    Friend WithEvents lblNomeArquivoNovo As Label
    Friend WithEvents txtnomeArquivoNovo As TextBox
    Friend WithEvents btnSair As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txtConteudo As TextBox
    Friend WithEvents txtConteudoNovo As TextBox
    Friend WithEvents btnlimpar As Button
End Class
