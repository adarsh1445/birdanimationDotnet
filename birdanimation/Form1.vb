Public Class Form1
    Dim bird As Integer = 1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case bird
            Case 1
                Pic.Image = My.Resources.i1
                bird += 1
            Case 2
                Pic.Image = My.Resources.i2
                bird += 1
            Case 3
                Pic.Image = My.Resources.i3
                bird += 1
            Case 4
                Pic.Image = My.Resources.i4
                bird = 1
        End Select

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Pic.Click

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Select Case bird
            Case 1
                Pic1.Image = My.Resources.i2
                bird += 1
            Case 2
                Pic1.Image = My.Resources.i3
                bird += 1
            Case 3
                Pic1.Image = My.Resources.i4
                bird += 1
            Case 4
                Pic1.Image = My.Resources.i1
                bird = 1
        End Select
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles Pic1.Click

    End Sub
End Class
