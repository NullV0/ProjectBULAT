Public Class Form1
    Public at1hiz, at2hiz, bitis As Integer
    Public cevap As String
    Dim var As String
    Dim intPic As Integer
    Dim rand As New Random

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Timer1.Start()
        Timer2.Start()
        Dim intPic As Integer
        intPic = Int((15 * Rnd()) + 1)
        PictureBox3.Image = ımageList1.Images(intPic)
        If intPic = 1 Then
            cevap = "sitokinez"
        End If
        If intPic = 2 Then
            cevap = "anafaz"
        End If
        If intPic = 3 Then
            cevap = "anafaz"
        End If
        If intPic = 4 Then
            cevap = "interfaz"
        End If
        If intPic = 5 Then
            cevap = "interfaz"
        End If
        If intPic = 6 Then
            cevap = "metafaz"
        End If
        If intPic = 7 Then
            cevap = "metafaz"
        End If
        If intPic = 8 Then
            cevap = "profaz"
        End If
        If intPic = 9 Then
            cevap = "profaz"
        End If
        If intPic = 10 Then
            cevap = "telofaz"
        End If
        If intPic = 11 Then
            cevap = "telofaz"

        End If



    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        var = TextBox1.Text
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim intPic As Integer
        Dim rand As New Random

        var = TextBox1.Text

        If var = cevap Then
            PictureBox2.Left = PictureBox2.Left + at2hiz + 50
            intPic = Int((14 * Rnd()) + 1)
            PictureBox3.Image = ımageList1.Images(intPic)

        End If
        If intPic = 1 Then
            cevap = "sitokinez"
        ElseIf intPic = 2 Then
            cevap = "anafaz"

        ElseIf intPic = 3 Then
            cevap = "anafaz"

        ElseIf intPic = 4 Then
            cevap = "interfaz"

        ElseIf intPic = 5 Then
            cevap = "interfaz"

        ElseIf intPic = 6 Then
            cevap = "metafaz"

        ElseIf intPic = 7 Then
            cevap = "metafaz"

        ElseIf intPic = 8 Then
            cevap = "profaz"

        ElseIf intPic = 9 Then
            cevap = "profaz"

        ElseIf intPic = 10 Then
            cevap = "telofaz"

        ElseIf intPic = 11 Then
            cevap = "telofaz"

        ElseIf intPic = 12 Then
            cevap = "anafaz"

        ElseIf intPic = 13 Then
            cevap = "metafaz"

        ElseIf intPic = 14 Then
            cevap = "telofaz"
        End If






    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'FevziBOT
        Randomize()
        at1hiz = Math.Ceiling(Rnd() * 10)
        PictureBox1.Left = PictureBox1.Left + at1hiz
        'Player
        Randomize()
        at2hiz = 4
        PictureBox2.Left = PictureBox2.Left + at2hiz
        If PictureBox1.Left > Label1.Left Then
            Timer1.Stop()
            MsgBox("FevziBOT kazandı!")
            PictureBox2.Left = 0
            PictureBox1.Left = 0
        End If

        If PictureBox2.Left > Label1.Left Then
            Timer1.Stop()
            MsgBox("Sen Kazandın!")
            PictureBox2.Left = 0
            PictureBox1.Left = 0
        End If


    End Sub
End Class
