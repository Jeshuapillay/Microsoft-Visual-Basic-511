Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim asset_cost, salvage_value As Double
        Dim useful_life As Integer

        asset_cost = TextBox1.Text
        salvage_value = TextBox2.Text
        useful_life = ComboBox1.SelectedItem

        ListBox1.Items.Add("Year" & vbTab & "Depreciation")
        ListBox2.Items.Add("Year" & vbTab & "Depreciation")

        For years As Integer = 1 To 5
            ListBox1.Items.Add(years & vbTab & Financial.DDB(asset_cost, salvage_value, useful_life, years).ToString("C2"))
            ListBox2.Items.Add(years & vbTab & Financial.SYD(asset_cost, salvage_value, useful_life, years).ToString("C2"))
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For goku As Integer = 3 To 20
            ComboBox1.Items.Add(goku)
        Next
    End Sub
End Class
