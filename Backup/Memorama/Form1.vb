Public Class Main

    Private Sub FacilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacilToolStripMenuItem.Click
        Facil.Show()
        Me.Hide()
    End Sub

    Private Sub MedioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MedioToolStripMenuItem.Click
        Medio.Show()
        Me.Hide()
    End Sub

    Private Sub DificilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DificilToolStripMenuItem.Click
        Dificil.Show()
        Me.Hide()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBox = False
    End Sub
    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Acerca.show()
    End Sub
    Private Sub InstruccionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstruccionesToolStripMenuItem.Click
        MsgBox("Se deben de encontrar las parejas en los diferentes niveles en el menor tiempo posible.")
    End Sub
End Class
