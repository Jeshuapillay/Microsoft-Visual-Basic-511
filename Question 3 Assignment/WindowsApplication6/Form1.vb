Public Class Form1

    Dim Columns As Integer = 3
    Dim Rows As Integer = 5
    Dim dblArraySales(Rows, Columns) As Integer
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dblArraySales(0, 1) = 120000
        dblArraySales(1, 1) = 190000
        dblArraySales(2, 1) = 175000
        dblArraySales(3, 1) = 188000
        dblArraySales(4, 1) = 125000
        dblArraySales(5, 1) = 163000

        dblArraySales(0, 2) = 90000
        dblArraySales(1, 2) = 85000
        dblArraySales(2, 2) = 80000
        dblArraySales(3, 2) = 83000
        dblArraySales(4, 2) = 87000
        dblArraySales(5, 2) = 80000

        dblArraySales(0, 3) = 65000
        dblArraySales(1, 3) = 64000
        dblArraySales(2, 3) = 71000
        dblArraySales(3, 3) = 67000
        dblArraySales(4, 3) = 65000
        dblArraySales(5, 3) = 64000
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim KwaZuluNatal As Integer = 0
        Dim Gauteng As Integer = 0
        Dim WesternCape As Integer = 0
        Dim Sum As Integer = 0

        RichTextBox1.Clear()

        RichTextBox1.SelectionTabs = {50, 200, 300, 450}

        RichTextBox1.AppendText("Month:" & vbTab & "Kwa-Zulu-Natal Sales:" & vbTab & "Gauteng Sales:" & vbTab & "Western Cape Sales:" & vbNewLine)
        RichTextBox1.AppendText(vbNewLine)

        For Month As Integer = 0 To Rows
            RichTextBox1.AppendText(Month + 1 & vbTab)

            For Region As Integer = 1 To Columns
                RichTextBox1.AppendText(dblArraySales(Month, Region).ToString("C0") & vbTab)

                If Region = 1 Then
                    KwaZuluNatal += dblArraySales(Month, Region)
                ElseIf Region = 2
                    Gauteng += dblArraySales(Month, Region)
                Else
                    WesternCape += dblArraySales(Month, Region)
                End If
            Next Region

            RichTextBox1.AppendText(vbNewLine)
        Next Month

        Sum = KwaZuluNatal + Gauteng + WesternCape

        RichTextBox1.AppendText(vbNewLine & "The total amount that ITI Hub made in all 3 regions is:" & Sum.ToString("C0") & vbNewLine)

        RichTextBox1.AppendText("KwaZuluNatal has contributed" & Math.Round(((KwaZuluNatal / Sum) * 100), 0) & "%" & "to the total." & vbNewLine)
        RichTextBox1.AppendText("Gauteng has contributed" & Math.Round((Gauteng / Sum) * 100, 0) & "%" & "to the total." & vbNewLine)
        RichTextBox1.AppendText("WesternCape has contributed" & Math.Round((Gauteng / Sum) * 100, 0) & "%" & "to the total." & vbNewLine)

    End Sub
End Class
