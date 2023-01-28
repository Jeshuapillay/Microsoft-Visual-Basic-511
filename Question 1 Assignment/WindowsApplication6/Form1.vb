Public Class Form1
    Dim dblStart As Integer = 0
    Dim dblInteger As Integer = 0
    Dim dblHeight As Integer = 0
    Dim dblWidth As Integer = 0
    Dim dblCoverage As Integer = 0
    'Jeshua Leonard Pillay, Student Number:154332'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For dblStart As Integer = 10 To 35
            With ComboBox1.Items
                .Add(dblStart)
            End With
            With ComboBox2.Items
                .Add(dblStart)
            End With
            With ComboBox3.Items
                .Add(dblStart)
            End With
        Next dblStart
        For dblStart As Double = 40 To 50 Step 0.5
            With ComboBox4.Items
                .Add(dblStart)
            End With
        Next dblStart
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        txtSingle.Clear()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        txtSingle.Clear()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        txtSingle.Clear()
    End Sub
    'Jeshua Leonard Pillay, Student Number:154332'
    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        txtSingle.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dblLength As Integer = ComboBox1.SelectedItem
        Dim dblWidth As Integer = ComboBox2.SelectedItem
        Dim dblHeight As Integer = ComboBox3.SelectedItem
        Dim dblCoverage As Integer = ComboBox4.SelectedItem

        txtSingle.Text = calcRolls(dblLength, dblWidth, dblHeight, dblCoverage)
    End Sub

    Private Function calcRolls(dblLen As Integer, dblWid As Integer, dblHei As Integer, dblCov As Double)
        ' formula of TSA = (l * h * 2 + w * h * 2 ) / cov (1 = length, w = width, h = height cov = roll coverage )
        Dim dblTSA As Integer = Math.Ceiling((dblLen * dblHei * 2 + dblWid * dblHei * 2) / dblCov)

        Return dblTSA
    End Function
End Class
