Public Class frmPayBill

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        BillDocument.Print()
    End Sub

    Private Sub BillDocument_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles BillDocument.PrintPage
        Dim NL As Integer = 18

        Dim c1x As Integer = 40
        Dim c2x As Integer = 415
        Dim c3x As Integer = 537
        Dim c4x As Integer = 655

        Dim r1y As Integer = 424
        Dim r2y As Integer = 480
        Dim r3y As Integer = 566

        With e.Graphics

            .DrawImage(My.Resources.CHECKFIELDS, 25, 385, 760, 291)
            .DrawString(DateString.ToString, iFont, iBrush, 262, r1y)
            .DrawString(txtOrderOf.Text.ToUpper, iFont, iBrush, c1x, r2y)
            .DrawString(txtAmount.Text, iFont, iBrush, c4x, r2y)

            .DrawString(txtAmount.Text, iFont, iBrush, c3x, 645)

            'Check
            .DrawString(DateString.ToString, iText, iBrush, 680, 67)
            .DrawString(txtOrderOf.Text.ToUpper, iText, iBrush, 90, 117)
            .DrawString(txtAmount.Text, iText, iBrush, 690, 117)
            .DrawString(txtMemo.Text.ToUpper, iText, iBrush, 61, 254)

            Dim pString As String = DecimalToText.ConvertDecimalToText(txtAmount.Text).Replace("'s Dollars", " ")

            While pString.Length < 70
                pString &= "*"
            End While

            .DrawString(pString, iText, iBrush, 23, 150)

        End With

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class