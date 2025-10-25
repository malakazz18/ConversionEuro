

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim montanteur As Decimal
        Dim montantdin As Decimal
        Const taux As Decimal = 3.5
        If Decimal.TryParse(Txt1.Text, montanteur) Then
            montantdin = montanteur * taux
            res.Text = montantdin.ToString("F2")
        Else
            MessageBox.Show("Veuillez entrer un montant valide en euros.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Txt1.Clear()
        res.Text = " "
    End Sub
End Class
