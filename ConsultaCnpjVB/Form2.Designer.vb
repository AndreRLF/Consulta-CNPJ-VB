<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRequest
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCnpj = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNomeEmpresa = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNomeFantasia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtInicioAtv = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTelefone = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtSocios = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(93, 30)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(211, 37)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Empresa Testes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CNPJ"
        '
        'txtCnpj
        '
        Me.txtCnpj.Location = New System.Drawing.Point(15, 113)
        Me.txtCnpj.Name = "txtCnpj"
        Me.txtCnpj.Size = New System.Drawing.Size(349, 20)
        Me.txtCnpj.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome da Empresa"
        '
        'txtNomeEmpresa
        '
        Me.txtNomeEmpresa.Location = New System.Drawing.Point(15, 172)
        Me.txtNomeEmpresa.Name = "txtNomeEmpresa"
        Me.txtNomeEmpresa.Size = New System.Drawing.Size(349, 20)
        Me.txtNomeEmpresa.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nome Fantasia"
        '
        'txtNomeFantasia
        '
        Me.txtNomeFantasia.Location = New System.Drawing.Point(15, 233)
        Me.txtNomeFantasia.Name = "txtNomeFantasia"
        Me.txtNomeFantasia.Size = New System.Drawing.Size(349, 20)
        Me.txtNomeFantasia.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Início das Atividades"
        '
        'txtInicioAtv
        '
        Me.txtInicioAtv.Location = New System.Drawing.Point(15, 297)
        Me.txtInicioAtv.Name = "txtInicioAtv"
        Me.txtInicioAtv.Size = New System.Drawing.Size(349, 20)
        Me.txtInicioAtv.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 343)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Endereço"
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(15, 359)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(349, 20)
        Me.txtEndereco.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 404)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Telefone"
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(15, 420)
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(349, 20)
        Me.txtTelefone.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 465)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(15, 481)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(349, 20)
        Me.txtEmail.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ConsultaCnpjVB.My.Resources.Resources.receita_federeal_logo
        Me.PictureBox1.Location = New System.Drawing.Point(15, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'txtSocios
        '
        Me.txtSocios.AutoSize = True
        Me.txtSocios.Location = New System.Drawing.Point(12, 522)
        Me.txtSocios.Name = "txtSocios"
        Me.txtSocios.Size = New System.Drawing.Size(39, 13)
        Me.txtSocios.TabIndex = 1
        Me.txtSocios.Text = "Sócios"
        Me.txtSocios.Visible = False
        '
        'frmRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(394, 541)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtSocios)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTelefone)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtInicioAtv)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNomeFantasia)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNomeEmpresa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCnpj)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRequest"
        Me.Text = "CNPJ"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCnpj As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNomeEmpresa As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNomeFantasia As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtInicioAtv As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTelefone As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtSocios As Label
End Class
