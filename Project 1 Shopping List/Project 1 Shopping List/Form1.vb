Public Class Form1

    Private Sub Button1_click(sneder As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtList.TextChanged


    End Sub

    Private Sub btnAddShopList_Click(sender As Object, e As EventArgs) Handles btnAddShopList.Click
        'txtList.Text = txtList.Test & txtInputBox.Text & ControlChars.CrLf
        txtList.Text = txtList.Text & txtInputBox.Text & Environment.NewLine
        txtInputBox.Clear()
        txtInputBox.Focus()
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Me.Close()
    End Sub

    Private Sub btnPrintShopList_Click(sender As Object, e As EventArgs) Handles btnPrintShopList.Click
        PrintDocument1.Print()
    End Sub

    Private Sub btnClearShopList_Click(sender As Object, e As EventArgs) Handles btnClearShopList.Click
        txtInputBox.Clear()
        txtList.Clear()
        txtInputBox.Focus()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Shopping List", New Font("arial", 12, FontStyle.Regular, GraphicsUnit.Pixel),
                              Brushes.Black, 25, 25)
        e.Graphics.DrawString("_____________", New Font("arial", 12, FontStyle.Regular, GraphicsUnit.Pixel),
                             Brushes.Black, 25, 25)
        e.Graphics.DrawString(txtList.Text, New Font("arial", 12, FontStyle.Regular, GraphicsUnit.Pixel),
                             Brushes.Black, 25, 25)

    End Sub

    Private Sub txtInputBox_TextChanged(sender As Object, e As EventArgs) Handles txtInputBox.TextChanged

    End Sub
End Class
