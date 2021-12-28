Public Class Principal
    Private Sub AccesoConectadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccesoConectadoToolStripMenuItem.Click
        Dim accesoConectado As New AccesoConectadoFR
        accesoConectado.MdiParent = Me
        accesoConectado.Show()

    End Sub

    Private Sub AccesoDesconectadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccesoDesconectadoToolStripMenuItem.Click
        Dim accesoDesconectado As New AccesoDesconectadoFR
        accesoDesconectado.MdiParent = Me
        accesoDesconectado.Show()

    End Sub
End Class
