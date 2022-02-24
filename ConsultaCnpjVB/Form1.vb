Public Class frmFindCnpj
    Private Sub Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cbxEstado.SelectedIndex = 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form2 As frmRequest = New frmRequest(Me.mtbCNPJ.Text)
        form2.Show()
        Me.Hide()
    End Sub

End Class
