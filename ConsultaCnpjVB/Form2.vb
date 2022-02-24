Public Class frmRequest

    Private Sub CenterLbl(ByVal texto As String)
        Me.lblTitulo.Text = texto
        Dim frmCenter As Integer = Me.Size.Width / 2
        Dim xLocation As Integer = frmCenter - Me.lblTitulo.Size.Width / 2
        Me.lblTitulo.Location = New Point(xLocation, 30)
    End Sub

    Public Sub New(ByVal CNPJ As String)
        InitializeComponent()

        'Definições do Documento
        Dim str_ulr As String = "http://cnpj.info/" + CNPJ
        Dim html As String = DownloadWebPageStrings.Run(str_ulr)
        html = Replace(html, vbCrLf, "")

        'Expressões Regulares
        Dim regExPage As String = "<h1>Encontrado.*?<\/h1>"
        Dim regExEmpresa As String = "<td>Nome da empresa<\/td><td><a.*?>(.*?)<\/a><\/td>"
        Dim regExFantasia As String = "<td>Fantasia nome<\/td><td><a.*?>(.*?)<\/a><\/td>"
        Dim regExInicioAtv As String = "<td>Inicio atividade data<\/td><td>(.*?)<\/td>"
        Dim regExEndereco As String = "<h3>Endereço<\/h3>(.*?)<h3>"
        Dim regExTel As String = "<li>Telefone\(s\): <a.*?>(.*?)<\/a>"
        Dim regExEmail As String = "<li>Correio eletrônico: <a.*?>(.*?)<\/a>"
        Dim regExSocios As String = "<h3>Sócios<\/h3><table><tbody><tr>.*?<\/tr>(?:<tr><td>.*?<\/td><td>(.*?)<\/td><td>.*?<\/td><td>(.*?)<\/td><\/tr>)+.*?<\/table"



        'RegexTools
        Dim regexTools As RegexTools = New RegexTools()
        Dim hasMatch As Boolean = regexTools.findPage(regExPage, html)

        If hasMatch Then
            CenterLbl("CNPJ Encontrado")

            Me.txtCnpj.Text = CNPJ
            Me.txtNomeEmpresa.Text = regexTools.getField(regExEmpresa, html)
            Me.txtNomeFantasia.Text = regexTools.getField(regExFantasia, html)
            Me.txtInicioAtv.Text = regexTools.getField(regExInicioAtv, html)
            Me.txtEndereco.Text = regexTools.getEndereco(regExEndereco, html)
            Me.txtTelefone.Text = regexTools.getField(regExTel, html)
            Me.txtEmail.Text = regexTools.getField(regExEmail, html)

            Dim socios As List(Of String) = regexTools.getSocios(html)
            If socios.Count > 0 Then
                txtSocios.Visible = True

                Dim countS As Integer = 0
                For Each socio As String In socios
                    Dim Ly As Integer = 538 + (26 * countS)
                    countS += 1

                    Dim txb As TextBox = New TextBox()
                    txb.Location = New Point(15, Ly)
                    txb.Size = txtCnpj.Size
                    txb.Name = "txtSocio" + countS.ToString()
                    txb.Text = socio

                    Me.Controls.Add(txb)

                    If countS = socios.Count Then
                        Dim pnlMargin As Panel = New Panel()
                        pnlMargin.Location = New Point(15, Ly)
                        pnlMargin.Size = New Size(0, 50)
                        Me.Controls.Add(pnlMargin)
                    End If
                Next



            End If

            Me.txtCnpj.Select()
        Else
            CenterLbl("CNPJ Não Encontrado")
            MessageBox.Show("Sem Correspondência para o CNPJ informado", "CNPJ Não Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

End Class