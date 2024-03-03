Public Class btnHandle
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'list.Items.Clear()
        For Each ctrl In Controls.OfType(Of TextBox)
            ctrl.Clear()
        Next
        ' set mouse cursor
        'txt.Focus()
    End Sub
End Class
