Public Class Form1
    Private Sub btnRojo_Click(sender As Object, e As EventArgs) Handles btnRojo.Click
        txtcolores.BackColor = Color.Red
    End Sub

    Private Sub BtnAmarillo_Click(sender As Object, e As EventArgs) Handles BtnAmarillo.Click
        txtcolores.BackColor = Color.Yellow
    End Sub

    Private Sub btnNegro_Click(sender As Object, e As EventArgs) Handles btnNegro.Click
        txtcolores.BackColor = Color.Black
    End Sub

    Private Sub btnAzul_Click(sender As Object, e As EventArgs) Handles btnAzul.Click
        txtcolores.BackColor = Color.Blue
    End Sub
End Class
