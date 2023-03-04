Option Explicit On
Public Class Medio
    Dim score As Integer = 0
    Dim arrImagenes As ArrayList
    Dim MiGrafica As Bitmap
    Dim randObj As New System.Random()
    Dim arrList As New ArrayList()
    Dim compara As Boolean
    Dim NombreImagen1 As String
    Dim PictureImagen1 As PictureBox
    Dim segundo As Integer = 0

    Dim mistake As Integer = 0
    Dim chuck_norris As Integer = 0


    Private Sub Facil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ControlBox = False
        LlenarImagenes()
    End Sub
    Private Sub FacilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacilToolStripMenuItem.Click
        Facil.Show()
        Close()
    End Sub

    Private Sub MedioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MedioToolStripMenuItem.Click
        Main.Show()
        Close()
    End Sub

    Private Sub DificilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DificilToolStripMenuItem.Click
        Dificil.Show()
        Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub LlenarImagenes()

        ColocarImagen(PictureBox1)

        ColocarImagen(PictureBox2)

        ColocarImagen(PictureBox3)

        ColocarImagen(PictureBox4)

        ColocarImagen(PictureBox5)

        ColocarImagen(PictureBox6)

        ColocarImagen(PictureBox7)

        ColocarImagen(PictureBox8)

        ColocarImagen(PictureBox9)

        ColocarImagen(PictureBox10)

        ColocarImagen(PictureBox11)

        ColocarImagen(PictureBox12)

        ColocarImagen(PictureBox13)

        ColocarImagen(PictureBox14)


        PictureBox1.BackColor = Color.Black
        PictureBox2.BackColor = Color.Black
        PictureBox3.BackColor = Color.Black
        PictureBox4.BackColor = Color.Black
        PictureBox5.BackColor = Color.Black
        PictureBox6.BackColor = Color.Black
        PictureBox7.BackColor = Color.Black
        PictureBox8.BackColor = Color.Black
        PictureBox9.BackColor = Color.Black
        PictureBox10.BackColor = Color.Black
        PictureBox11.BackColor = Color.Black
        PictureBox12.BackColor = Color.Black
        PictureBox13.BackColor = Color.Black
        PictureBox14.BackColor = Color.Black

    End Sub
    Private Sub ColocarImagen(ByVal CajaImagen As PictureBox)
        Dim i As String
        i = randObj.Next(1, 8).ToString()
        If (YaExistePareja(i) = False) Then
            'CajaImagen.Image = My.Resources.ResourceManager.GetObject(i)
            CajaImagen.Tag = i
            arrList.Add(i)
        Else
            ColocarImagen(CajaImagen)
        End If
    End Sub

    Public Function YaExistePareja(ByVal nomGrafica As String) As Boolean
        Dim Existe As Boolean
        Dim conteo As Integer
        conteo = 0
        For Each objNomGrafica As String In arrList
            If (objNomGrafica = nomGrafica) Then
                Existe = True
                conteo = conteo + 1
            Else
                Existe = False
            End If
        Next

        If (conteo > 1) Then
            Existe = True
        Else
            Existe = False
        End If

        Return Existe
    End Function

    Private Sub CompararImagenes(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click, PictureBox7.Click, PictureBox6.Click, PictureBox5.Click, PictureBox4.Click, PictureBox3.Click, PictureBox2.Click, PictureBox1.Click, PictureBox9.Click, PictureBox14.Click, PictureBox13.Click, PictureBox12.Click, PictureBox11.Click, PictureBox10.Click
        Dim obimagen As PictureBox = sender
        obimagen.Image = My.Resources.ResourceManager.GetObject(obimagen.Tag)
        Label1.Text = score
        Label1.Refresh()
        Label2.Text = mistake
        Label2.Refresh()
        Label3.Text = chuck_norris
        Label3.Refresh()
        Timer1.Enabled = True
        Timer1.Interval = 2000
        If (compara = True) Then
            If obimagen.Name <> PictureImagen1.Name Then
                Label1.Refresh()
                If (NombreImagen1 = obimagen.Tag) Then
                    score = score + 100
                    obimagen.Visible = False
                    PictureImagen1.Visible = False
                    compara = False
                    chuck_norris = chuck_norris + 1
                Else
                    compara = False
                    obimagen.Image = My.Resources.ResourceManager.GetObject(obimagen.Tag)
                    MsgBox("Intenta de nuevo")
                    PictureImagen1.Image = My.Resources.ResourceManager.GetObject(PictureImagen1.Tag)
                    PictureImagen1.Refresh()
                    Timer1.Enabled = True
                    Timer1.Interval = 3000
                    score = score - 20
                    mistake = mistake + 1
                    obimagen.Image = My.Resources.ResourceManager.GetObject("99")
                    PictureImagen1.Image = My.Resources.ResourceManager.GetObject("99")
                End If
            End If
        Else
            NombreImagen1 = obimagen.Tag
            PictureImagen1 = obimagen
            compara = True
        End If

    End Sub

    Private Sub Timer1_Timer()
        segundo = segundo + 1
        Label2.Text = segundo & "seg"
    End Sub

    Private Sub InstruccionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InstruccionesToolStripMenuItem.Click
        MsgBox("Se deben de encontrar las parejas en los diferentes niveles en el menor tiempo posible.")
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Acerca.show()
    End Sub



End Class