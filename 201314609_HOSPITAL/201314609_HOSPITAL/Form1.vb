Public Class Form1
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoPago.SelectedIndexChanged

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("Desea Salir", vbQuestion + vbYesNo, "PRECAUCION") = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub CalcularToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem1.Click


    End Sub
End Class

