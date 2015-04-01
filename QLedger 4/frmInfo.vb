Public Class frmInfo

    Private Sub pbInfo_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pbInfo.Paint
        With e.Graphics

            .DrawString("2007-2009 C. D. Stefancik", iFont, sBrush, 10, 10)
            .DrawLine(Pens.Black, 10, 35, pbInfo.Width - 10, 35)
            .DrawString("Tax year         : 2009", cFont, sBrush, 10, 40)
            .DrawString("Pay period       : WEEKLY", cFont, sBrush, 10, 60)
            .DrawString("SS Wage Base     : $106,800", cFont, sBrush, 10, 90)
            .DrawString("Med Wage Base    : UNLIMITED", cFont, sBrush, 10, 110)
            .DrawLine(Pens.Black, 10, 140, pbInfo.Width - 10, 140)
            .DrawString("Total Employees  : " & frmMain.lsbEmployees.Items.Count, cFont, sBrush, 10, 150)
            .DrawString("Total Gross Pay  : $" & GlobalPay, cFont, sBrush, 10, 170)
            .DrawString("Total FICA Tax   : $" & GlobalFICA, cFont, sBrush, 10, 190)
            .DrawString("Total Income Tax : $" & GlobalFederalIncomeTax, cFont, sBrush, 10, 210)
        End With
    End Sub

    Private Sub pbLogo_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pbLogo.Paint
        With e.Graphics

            .CompositingQuality = Drawing2D.CompositingQuality.HighQuality
            .InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            .SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            .DrawImage(My.Resources.LOGO, 0, 0, 237, 241)
        End With
    End Sub
End Class