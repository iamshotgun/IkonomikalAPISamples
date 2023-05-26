Public Class switchOptions

    Private Sub AddAPIBtn_Click(sender As Object, e As EventArgs) Handles AddAPIBtn.Click
        Dim dmyFrm As New saveNewData
        dmyFrm.ShowDialog(Me)
        dmyFrm.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dmyFrm As New addToDeleteFromDataStorage
        dmyFrm.ShowDialog(Me)
        dmyFrm.Dispose()
    End Sub
End Class