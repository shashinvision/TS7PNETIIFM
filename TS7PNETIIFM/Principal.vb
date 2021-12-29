Public Class Principal
    Private Sub AccesoConectadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccesoConectadoToolStripMenuItem.Click
        Dim accesoConectadoForm As New AccesoConectadoFR
        accesoConectadoForm.MdiParent = Me
        accesoConectadoForm.Show()

    End Sub

    Private Sub AccesoDesconectadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccesoDesconectadoToolStripMenuItem.Click

        Dim accesoDesconectadoForm As New AccesoDesconectadoFR
        accesoDesconectadoForm.MdiParent = Me
        accesoDesconectadoForm.Show()

    End Sub
End Class
