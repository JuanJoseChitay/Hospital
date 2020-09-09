Public Class Calcular

    Public mivector(5) As String
    'Public mymatriz(3, 3) As String





    Sub SeleccionHabitacion()


        Select Case Form1.cmbHabitacion.SelectedItem

            Case "Privado"
                'INTERES = SALDO * 0.02
            Case "SemiPrivado"
                'INTERES = SALDO * 0.05
            Case "No Privado"
                'INTERES = SALDO * 0.07
        End Select
    End Sub

    Sub SeleccionPagos()


        Select Case Form1.cmbTipoPago.SelectedItem

            Case "Efectivo"
                'INTERES = SALDO * 0.02
            Case "Cheque"
                'INTERES = SALDO * 0.05
            Case "Targeta De Credito"
                'INTERES = SALDO * 0.07
            Case "Targeta De Debito"
        End Select
    End Sub





End Class
