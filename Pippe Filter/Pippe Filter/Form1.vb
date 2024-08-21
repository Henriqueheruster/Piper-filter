Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text

Public Class Form1

    Private caminho As String = String.Empty
    Private arquivo As String = String.Empty

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtcaminhoArquivo.Enabled = False
    End Sub

    Private Sub Limpar()
        TxtcaminhoArquivo.Text = Nothing
        txtnomeArquivoNovo.Text = Nothing
        txtnomeArquivoNovo.ReadOnly = False
        txtConteudo.Text = Nothing
        txtConteudoNovo.Text = Nothing
        caminho = Nothing
        arquivo = Nothing
        btnlimpar.Enabled = False
        btnModificar.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Filtro1()
    End Sub

    Private Sub Filtro1()
        Me.OpenFileDialog1.Filter = "Txt (*.txt)|*.txt|" & "All files (*.*)|*.*"
        Me.OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName <> "" Then
            caminho = OpenFileDialog1.FileName
            arquivo = System.IO.File.ReadAllText(caminho)
            txtConteudo.Text = arquivo
        Else
            Exit Sub
        End If
        TxtcaminhoArquivo.Text = caminho
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If txtnomeArquivoNovo.Text <> Nothing AndAlso TxtcaminhoArquivo.Text <> Nothing Then
            Filtro2(arquivo)
        Else
            MessageBox.Show("Existem campos vazio!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Filtro2(arquivo As String)
        Dim ConteudoSemEspaço As String
        ConteudoSemEspaço = arquivo.Replace(" ", "").Replace(".", "").Replace(",", "")
        Filtro3(ConteudoSemEspaço)
    End Sub

    Private Sub Filtro3(ConteudoSemEspaço As String)
        Dim ConteudoMaisculo As String
        ConteudoMaisculo = ConteudoSemEspaço.ToUpper()
        Fitro4(ConteudoMaisculo)
    End Sub

    Private Sub Fitro4(ConteudoMaisculo)
        Try
            Dim NovoNome As String
            Dim caminhonovo As String
            Dim diretorio As String = System.IO.Path.GetDirectoryName(caminho)
            NovoNome = txtnomeArquivoNovo.Text
            caminhonovo = System.IO.Path.Combine(diretorio, NovoNome & ".txt")
            System.IO.File.WriteAllText(caminhonovo, ConteudoMaisculo)
            System.IO.File.Delete(caminho)
            txtConteudoNovo.Text = ConteudoMaisculo
            txtnomeArquivoNovo.ReadOnly = True
        Catch ex As Exception
            MessageBox.Show($"Erro ao processar o arquivo TXT: {ex.Message}")
            Exit Sub
        End Try
        MessageBox.Show("arquivo modificado!")
        btnModificar.Enabled = False
        btnlimpar.Enabled = True
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnlimpar_Click(sender As Object, e As EventArgs) Handles btnlimpar.Click
        Limpar()
    End Sub

End Class
