Public Class frmSimple

    Dim GrossPay, SocialSecurity, Medicare, FederalIncome, Netpay As Decimal


    Private Sub cmdPayroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPayroll.Click

        If txtHours.Text = "" Then
            MsgBox("Enter the number of hours worked.")
            Exit Sub
        End If

        If Val(txtHours.Text) > 40 Then
            GrossPay = Round(txtHours.Text - 40) * Round(txtPayRate.Text / 2 + txtPayRate.Text) + Round(40 * txtPayRate.Text)
        Else
            GrossPay = txtHours.Text * txtPayRate.Text
        End If

        SocialSecurity = SocialSecurityTax(GrossPay)
        Medicare = MedicareTax(GrossPay)
        FederalIncome = FederalIncomeTax(GrossPay, txtExemptions.Text, cmbStatus.Text)
        Netpay = GrossPay - SocialSecurity - Medicare - FederalIncome

        pbSimple.Refresh()
    End Sub

    Private Sub pbSimple_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pbSimple.Paint
        With e.Graphics

            .CompositingQuality = Drawing2D.CompositingQuality.HighQuality
            .InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            .SmoothingMode = Drawing2D.SmoothingMode.HighQuality

            .DrawRectangle(sPen, 10, 60, 175, 50)
            .DrawRectangle(sPen, 10, 110, 175, 50)
            .DrawRectangle(sPen, 10, 160, 175, 50)
            .DrawRectangle(sPen, 10, 210, 175, 50)
            .DrawRectangle(sPen, 10, 260, 175, 50)

            .DrawRectangle(sPen, 185, 10, 175, 50)
            .DrawRectangle(sPen, 185, 60, 175, 50)
            .DrawRectangle(sPen, 185, 110, 175, 50)
            .DrawRectangle(sPen, 185, 160, 175, 50)
            .DrawRectangle(sPen, 185, 210, 175, 50)
            .DrawRectangle(sPen, 185, 260, 175, 50)

            .DrawString("CURRENT", sFont, sBrush, 207, 20)
            .DrawString("GROSS", cFont, sBrush, 17, 67)
            .DrawString("EARNINGS", cFont, sBrush, 17, 83)

            .DrawString("SOCIAL", cFont, sBrush, 17, 116)
            .DrawString("SECURITY", cFont, sBrush, 17, 132)

            .DrawString("MEDICARE", cFont, sBrush, 17, 167)
            .DrawString("WITHHOLDINGS", cFont, sBrush, 17, 183)

            .DrawString("FEDERAL", cFont, sBrush, 17, 216)
            .DrawString("INCOME TAX", cFont, sBrush, 17, 232)

            .DrawString("NET PAY", sFont, sBrush, 17, 270)

            txtFormat.Alignment = StringAlignment.Far

            currentCell.Location = New Point(185, 70)
            .DrawString(GrossPay.ToString("0.00"), sFont, sBrush, currentCell, txtFormat)

            currentCell.Location = New Point(185, 120)
            .DrawString(SocialSecurity.ToString("0.00"), sFont, sBrush, currentCell, txtFormat)

            currentCell.Location = New Point(185, 170)
            .DrawString(Medicare.ToString("0.00"), sFont, sBrush, currentCell, txtFormat)

            currentCell.Location = New Point(185, 220)
            .DrawString(FederalIncome.ToString("0.00"), sFont, sBrush, currentCell, txtFormat)

            currentCell.Location = New Point(185, 270)
            .DrawString(Netpay.ToString("0.00"), sFont, sBrush, currentCell, txtFormat)

        End With
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class