Public Class frmMain

    Dim GrossPay, SocialSecurity, Medicare, FederalIncome, Netpay As Decimal
    Dim g, f, m, s, n As Decimal
    Dim CheckMonth As String = ""
    Dim strSort As String = "LAST NAME"
    Dim strMemo As String = ""
    Dim strYear As String = "2010"

    Public Sub FindEmployees()

        GlobalPay = 0
        lsbEmployees.Items.Clear()

        If My.Computer.FileSystem.DirectoryExists(path & "employees\") = True Then

            For Each foundfile As String In My.Computer.FileSystem.GetFiles(path & "employees\", FileIO.SearchOption.SearchTopLevelOnly, "*.wrk")
                ReadEmployeeData(foundfile.Substring(foundfile.Length - 13, 9))
                If strSort = "LAST NAME" Then
                    lsbEmployees.Items.Add(CurrentEmployee(ce.Name).ToString.Substring(CurrentEmployee(ce.Name).ToString.IndexOf(" ") + 1) & ", " & CurrentEmployee(ce.Name).ToString.Substring(0, CurrentEmployee(ce.Name).ToString.IndexOf(" ")) & "              :" & foundfile.Substring(foundfile.Length - 13, 9))
                Else
                    lsbEmployees.Items.Add(CurrentEmployee(ce.Name).ToString & "              :" & foundfile.Substring(foundfile.Length - 13, 9))
                End If

                lsvChecks.Items.Clear()
                CurrentEmployee.Clear()

                GlobalPay += g
                GlobalFederalIncomeTax += f
                GlobalFICA += (s + m)

            Next
        Else
            MsgBox("The employee payroll data could not be found." & vbNewLine & "If this the first time running QLedger please add an employee now.", MsgBoxStyle.Information)
            cmdPrintCheck.Enabled = False
            tsPrintCheck.Enabled = False
        End If
        If lsbEmployees.Items.Count > 0 Then lsbEmployees.SetSelected(0, True)

    End Sub

    Public Sub ReadEmployeeData(ByVal employeeID As String)

        CurrentEmployee.Clear()
        lsvChecks.Items.Clear()

        If My.Computer.FileSystem.DirectoryExists(path & "employees\") = False Then Exit Sub

        freefile = FileSystem.FreeFile

        FileSystem.FileOpen(freefile, path & "employees\" & employeeID & ".wrk", OpenMode.Input, OpenAccess.Read)

        While Not EOF(freefile)

            CurrentEmployee.Add(LineInput(freefile))

        End While

        FileSystem.FileClose(freefile)

        txtPayRate.Text = CurrentEmployee(ce.Payrate)
        ParseChecks()

    End Sub

    Public Sub WriteEmployeeData()
        freefile = FileSystem.FreeFile
        Try
            FileSystem.Kill(path & "employees\" & CurrentEmployee(ce.SocialSecuityNumber).Replace("-", "") & ".wrk")
        Catch e As Exception

        End Try

        FileSystem.FileOpen(freefile, path & "employees\" & CurrentEmployee(ce.SocialSecuityNumber).Replace("-", "") & ".wrk", OpenMode.Output, OpenAccess.Write)

        For Each sVar As String In CurrentEmployee
            FileSystem.PrintLine(freefile, sVar.ToUpper)
        Next

        FileSystem.FileClose()
        UpdateUI()

    End Sub

    Public Sub ParseChecks()
        Dim aVar As Integer = 0
        Dim strCheck As String()

        g = 0
        f = 0
        s = 0
        m = 0
        n = 0

        For aVar = ce.CheckHeading + 1 To CurrentEmployee.Count
            strCheck = CurrentEmployee(aVar).ToString.Split(",")
            If strCheck(0).EndsWith(strYear) Then
                If Val(CheckMonth) > 12 Then
                    Select Case CheckMonth
                        Case "13"
                            If strCheck(0).StartsWith("01") Or strCheck(0).StartsWith("02") Or strCheck(0).StartsWith("03") Then
                                With lsvChecks.Items.Add(strCheck(0))
                                    .SubItems.Add(strCheck(1))
                                    .SubItems.Add(strCheck(2))
                                    .SubItems.Add(strCheck(3))
                                    .SubItems.Add(strCheck(4))
                                    .SubItems.Add(strCheck(5))
                                End With
                            End If
                        Case "14"
                            If strCheck(0).StartsWith("04") Or strCheck(0).StartsWith("05") Or strCheck(0).StartsWith("06") Then
                                With lsvChecks.Items.Add(strCheck(0))
                                    .SubItems.Add(strCheck(1))
                                    .SubItems.Add(strCheck(2))
                                    .SubItems.Add(strCheck(3))
                                    .SubItems.Add(strCheck(4))
                                    .SubItems.Add(strCheck(5))
                                End With
                            End If
                        Case "15"
                            If strCheck(0).StartsWith("07") Or strCheck(0).StartsWith("08") Or strCheck(0).StartsWith("09") Then
                                With lsvChecks.Items.Add(strCheck(0))
                                    .SubItems.Add(strCheck(1))
                                    .SubItems.Add(strCheck(2))
                                    .SubItems.Add(strCheck(3))
                                    .SubItems.Add(strCheck(4))
                                    .SubItems.Add(strCheck(5))
                                End With
                            End If
                        Case "16"
                            If strCheck(0).StartsWith("10") Or strCheck(0).StartsWith("11") Or strCheck(0).StartsWith("12") Then
                                With lsvChecks.Items.Add(strCheck(0))
                                    .SubItems.Add(strCheck(1))
                                    .SubItems.Add(strCheck(2))
                                    .SubItems.Add(strCheck(3))
                                    .SubItems.Add(strCheck(4))
                                    .SubItems.Add(strCheck(5))
                                End With
                            End If
                    End Select
                Else
                    If strCheck(0).StartsWith(CheckMonth) Then
                        With lsvChecks.Items.Add(strCheck(0))
                            .SubItems.Add(strCheck(1))
                            .SubItems.Add(strCheck(2))
                            .SubItems.Add(strCheck(3))
                            .SubItems.Add(strCheck(4))
                            .SubItems.Add(strCheck(5))
                        End With
                    End If
                End If
            End If
        Next

        For aVar = 0 To lsvChecks.Items.Count - 1
            g += lsvChecks.Items(aVar).SubItems(1).Text
            f += lsvChecks.Items(aVar).SubItems(2).Text
            s += lsvChecks.Items(aVar).SubItems(3).Text
            m += lsvChecks.Items(aVar).SubItems(4).Text
            n += lsvChecks.Items(aVar).SubItems(5).Text
        Next

    End Sub

    Public Sub UpdateUI()

        pbCurrent.Refresh()
        pbInformation.Refresh()
        pbTotalsRefresh()
        Me.Text = "QLedger - " & strYear

    End Sub

    Private Sub lsbEmployees_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsbEmployees.SelectedIndexChanged

        txtDeduction.Text = "DEDUCTION"
        txtDeductionAmount.Text = "0.00"
        strMemo = ""

        GrossPay = 0
        SocialSecurity = 0
        Medicare = 0
        FederalIncome = 0
        Netpay = 0

        g = 0
        f = 0
        s = 0
        m = 0
        n = 0

        ReadEmployeeData(lsbEmployees.SelectedItem.ToString.Substring(lsbEmployees.SelectedItem.ToString.LastIndexOf(":") + 1, 9))

        UpdateUI()

    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        FindEmployees()

        lsvChecks.Font = cFont
        lsvTotals.Font = cFont
        lsbEmployees.Font = cFont
        txtHours.Font = sFont
        txtPayRate.Font = sFont
        cmbMonth.Font = cFont

        txtDeduction.Font = sFont
        txtDeductionAmount.Font = sFont

        txtFormat.Alignment = StringAlignment.Far

        cmbMonth.Text = "ALL YEAR"
        strYear = "2010"

        If CInt(System.DateTime.Today.Year) > 2010 Then
            MsgBox("This version of QLedger is outdated." & vbNewLine & "All payroll reporting functions are disabled.", MsgBoxStyle.Critical, "Outdated...")
        End If

    End Sub

    Private Sub cmdPayroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPayroll.Click
        If strYear <> CInt(System.DateTime.Today.Year).ToString Then
            MsgBox("You are now in a previous tax year." & vbNewLine & "All payroll reporting functions are disabled.", MsgBoxStyle.Critical)
        End If
        If txtHours.Text = "" Then
            MsgBox("Enter the number of hours worked.", MsgBoxStyle.Information)
            Exit Sub
        End If

        If Val(txtHours.Text) > 40 Then
            GrossPay = Round(txtHours.Text - 40) * Round(txtPayRate.Text / 2 + txtPayRate.Text) + Round(40 * txtPayRate.Text)
        Else
            GrossPay = txtHours.Text * txtPayRate.Text
        End If

        If g < 106800 Then
            SocialSecurity = SocialSecurityTax(GrossPay)
        Else
            SocialSecurity = 0
        End If

        Medicare = MedicareTax(GrossPay)
        FederalIncome = FederalIncomeTax(GrossPay, CInt(CurrentEmployee(ce.Exemptions)), CurrentEmployee(ce.MaritalStatus))

        Netpay = GrossPay - SocialSecurity - Medicare - FederalIncome - CDec(txtDeductionAmount.Text)

        UpdateUI()

    End Sub

    Private Sub CheckDocument_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles CheckDocument.PrintPage

        Dim NL As Integer = 18

        Dim c1x As Integer = 40
        Dim c2x As Integer = 415
        Dim c3x As Integer = 537
        Dim c4x As Integer = 655

        Dim r1y As Integer = 424
        Dim r2y As Integer = 480
        Dim r3y As Integer = 566


        With e.Graphics
            .CompositingQuality = Drawing2D.CompositingQuality.HighQuality
            .InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            .SmoothingMode = Drawing2D.SmoothingMode.HighQuality

            .DrawImage(My.Resources.CHECKFIELDS, 25, 385, 760, 291)

            .DrawString(CurrentEmployee(ce.Name), iFont, iBrush, c1x, r1y)
            .DrawString(DateString.ToString, iFont, iBrush, 262, r1y)
            .DrawString("Exemptions: " & CurrentEmployee(ce.Exemptions), iFont, iBrush, c2x, r1y)
            .DrawString("Status: " & CurrentEmployee(ce.MaritalStatus), iFont, iBrush, 580, r1y)

            .DrawString("Regular Pay $" & txtPayRate.Text, iFont, iBrush, c1x, r2y)

            If txtHours.Text > 40 Then
                .DrawString("40.00", iFont, iBrush, c2x, r2y)

                .DrawString("Overtime Pay $" & Round(txtPayRate.Text / 2 + txtPayRate.Text).ToString("0.00"), iFont, iBrush, c1x, r2y + NL)
                .DrawString(Round(txtHours.Text - 40).ToString("0.00"), iFont, iBrush, c2x, r2y + NL)
            Else
                .DrawString(txtHours.Text, iFont, iBrush, c2x, r2y)
            End If

            .DrawString(GrossPay.ToString("0.00"), iFont, iBrush, c3x, r2y)

            .DrawString(g.ToString("0.00"), iFont, iBrush, c4x, r2y)

            'Withholdings
            .DrawString("Federal Income Tax", iFont, iBrush, c1x, r3y)
            .DrawString(FederalIncome.ToString("0.00"), iFont, iBrush, c3x, r3y)
            .DrawString(f.ToString("0.00"), iFont, iBrush, c4x, r3y)

            .DrawString("Social Security", iFont, iBrush, c1x, r3y + NL)
            .DrawString(SocialSecurity.ToString("0.00"), iFont, iBrush, c3x, r3y + NL)
            .DrawString(s.ToString("0.00"), iFont, iBrush, c4x, r3y + NL)

            .DrawString("Medicare", iFont, iBrush, c1x, r3y + 2 * NL)
            .DrawString(Medicare.ToString("0.00"), iFont, iBrush, c3x, r3y + 2 * NL)
            .DrawString(m.ToString("0.00"), iFont, iBrush, c4x, r3y + 2 * NL)

            If Val(txtDeductionAmount.Text) > 0 Then

                .DrawString(txtDeduction.Text, iFont, iBrush, c1x, r3y + 3 * NL)
                .DrawString(txtDeductionAmount.Text, iFont, iBrush, c3x, r3y + 3 * NL)

            End If
            .DrawString(Netpay.ToString("0.00"), iFont, iBrush, c3x, 645)

            'Check
            .DrawString(DateString.ToString, iText, iBrush, 680, 67)
            .DrawString(CurrentEmployee(ce.Name).ToUpper, iText, iBrush, 90, 117)
            .DrawString(Netpay.ToString("0.00"), iText, iBrush, 690, 117)
            .DrawString(strMemo.ToUpper, iText, iBrush, 61, 254)

            Dim pString As String = DecimalToText.ConvertDecimalToText(Netpay.ToString("0.00")).Replace("'s Dollars", " ")

            While pString.Length < 70
                pString &= "*"
            End While

            .DrawString(pString, iText, iBrush, 23, 150)

        End With

        c1x = 40
        c2x = 415
        c3x = 537
        c4x = 655

        r1y = 424 + 345
        r2y = 480 + 345
        r3y = 566 + 345


        With e.Graphics

            .DrawImage(My.Resources.CHECKFIELDS, 25, 730, 760, 291)

            .DrawString(CurrentEmployee(ce.Name), iFont, iBrush, c1x, r1y)
            .DrawString(DateString.ToString, iFont, iBrush, 262, r1y)
            .DrawString("Exemptions: " & CurrentEmployee(ce.Exemptions), iFont, iBrush, c2x, r1y)
            .DrawString("Status: " & CurrentEmployee(ce.MaritalStatus), iFont, iBrush, 580, r1y)

            .DrawString("Regular Pay $" & txtPayRate.Text, iFont, iBrush, c1x, r2y)

            If txtHours.Text > 40 Then
                .DrawString("40.00", iFont, iBrush, c2x, r2y)

                .DrawString("Overtime Pay $" & Round(txtPayRate.Text / 2 + txtPayRate.Text).ToString("0.00"), iFont, iBrush, c1x, r2y + NL)
                .DrawString(Round(txtHours.Text - 40).ToString("0.00"), iFont, iBrush, c2x, r2y + NL)
            Else
                .DrawString(txtHours.Text, iFont, iBrush, c2x, r2y)
            End If

            .DrawString(GrossPay.ToString("0.00"), iFont, iBrush, c3x, r2y)

            .DrawString(g.ToString("0.00"), iFont, iBrush, c4x, r2y)

            'Withholdings
            .DrawString("Federal Income Tax", iFont, iBrush, c1x, r3y)
            .DrawString(FederalIncome.ToString("0.00"), iFont, iBrush, c3x, r3y)
            .DrawString(f.ToString("0.00"), iFont, iBrush, c4x, r3y)

            .DrawString("Social Security", iFont, iBrush, c1x, r3y + NL)
            .DrawString(SocialSecurity.ToString("0.00"), iFont, iBrush, c3x, r3y + NL)
            .DrawString(s.ToString("0.00"), iFont, iBrush, c4x, r3y + NL)

            .DrawString("Medicare", iFont, iBrush, c1x, r3y + 2 * NL)
            .DrawString(Medicare.ToString("0.00"), iFont, iBrush, c3x, r3y + 2 * NL)
            .DrawString(m.ToString("0.00"), iFont, iBrush, c4x, r3y + 2 * NL)

            If Val(txtDeductionAmount.Text) > 0 Then

                .DrawString(txtDeduction.Text, iFont, iBrush, c1x, r3y + 3 * NL)
                .DrawString(txtDeductionAmount.Text, iFont, iBrush, c3x, r3y + 3 * NL)

            End If
            .DrawString(Netpay.ToString("0.00"), iFont, iBrush, c3x, 645 + 345)

        End With

    End Sub

    Private Sub cmdPrintCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintCheck.Click
        PrintDialog.Document = CheckDocument
        CheckDocument.DocumentName = "Paycheck for " & CurrentEmployee(ce.Name)
        If txtHours.Text <> "" And PrintDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            CurrentEmployee.Add(DateString.ToString & "," & GrossPay.ToString("0.00") & "," & FederalIncome.ToString("0.00") & "," & SocialSecurity.ToString("0.00") & "," & Medicare.ToString("0.00") & "," & Netpay.ToString("0.00"))

            WriteEmployeeData()
            ReadEmployeeData(CurrentEmployee(ce.SocialSecuityNumber))

            Application.DoEvents()

            UpdateUI()

            If GrossPay > 0 Then CheckDocument.Print()
        Else
            MsgBox("Enter the number of hours worked.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub pbInformation_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pbInformation.Paint

        If CurrentEmployee.Count < 1 Then Exit Sub

        Dim sHeight As Integer = pbInformation.Height
        Dim sWidth As Integer = pbInformation.Width

        With e.Graphics
            .CompositingQuality = Drawing2D.CompositingQuality.HighQuality
            .InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            .SmoothingMode = Drawing2D.SmoothingMode.HighQuality

            .Clear(Color.White)

            .DrawLine(sPen, CInt(sWidth / 7 * 4), 0, CInt(sWidth / 7 * 4), sHeight)
            .DrawLine(sPen, 0, 45, sWidth, 45)

            .DrawString(CurrentEmployee(ce.Name), sFont, sBrush, 5, 7)

            If CurrentEmployee(ce.StreetAddress) <> "" Then
                .DrawString(CurrentEmployee(ce.StreetAddress), sFont, sBrush, 5, 53)
                .DrawString(CurrentEmployee(ce.CityStateZip).ToString.Replace("_", " "), sFont, sBrush, 5, 79)
            Else
                .DrawString("ADDRESS NOT ON FILE", sFont, oBrush, 5, 67)
            End If

            .DrawString("SSN   :", sFont, sBrush, 435, 7)
            .DrawString("STATUS:", sFont, sBrush, 435, 54)
            .DrawString("CLAIMS:", sFont, sBrush, 435, 80)

            If CurrentEmployee(ce.SocialSecuityNumber).ToString.StartsWith("NOSSN") Then
                .DrawString(CurrentEmployee(ce.SocialSecuityNumber), sFont, oBrush, 568, 7)
            Else
                .DrawString(CurrentEmployee(ce.SocialSecuityNumber), sFont, sBrush, 568, 7)
            End If

            .DrawString(CurrentEmployee(ce.MaritalStatus), sFont, sBrush, 568, 54)

            If CurrentEmployee(ce.Exemptions) > 10 Then
                .DrawString(CurrentEmployee(ce.Exemptions), sFont, oBrush, 568, 80)
            Else
                .DrawString(CurrentEmployee(ce.Exemptions), sFont, sBrush, 568, 80)
            End If


        End With
    End Sub

    Private Sub pbCurrent_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pbCurrent.Paint
        If CurrentEmployee.Count < 1 Then Exit Sub

        With e.Graphics

            .CompositingQuality = Drawing2D.CompositingQuality.HighQuality
            .InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            .SmoothingMode = Drawing2D.SmoothingMode.HighQuality

            .DrawRectangle(sPen, 10, 60, 175, 50)
            .DrawRectangle(sPen, 10, 110, 175, 50)
            .DrawRectangle(sPen, 10, 160, 175, 50)
            .DrawRectangle(sPen, 10, 210, 175, 50)
            .DrawRectangle(sPen, 10, 260, 175, 50)

            'payrate & hours box information
            .DrawString("RATE", sFont, sBrush, 437, 20)
            .DrawString("HOURS", sFont, sBrush, 605, 20)

            .DrawRectangle(sPen, 390, 10, 175, 50)
            .DrawRectangle(sPen, 390, 60, 175, 50)

            .DrawRectangle(sPen, 565, 10, 175, 50)
            .DrawRectangle(sPen, 565, 60, 175, 50)

            'normal drawing
            .DrawRectangle(sPen, 185, 10, 175, 50)
            .DrawRectangle(sPen, 185, 60, 175, 50)
            .DrawRectangle(sPen, 185, 110, 175, 50)
            .DrawRectangle(sPen, 185, 160, 175, 50)
            .DrawRectangle(sPen, 185, 210, 175, 50)
            .DrawRectangle(sPen, 185, 260, 175, 50)

            'deduction
            .DrawLine(sPen, 365, 260, 390, 200)
            .DrawLine(sPen, 365, 260, 390, 250)

            .DrawLine(New Pen(Color.Black, 2), 10, 260, 365, 260)

            .DrawRectangle(sPen, 390, 200, 175, 50)
            .DrawRectangle(sPen, 565, 200, 175, 50)

            'payroll
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

    Private Sub pbTotalsRefresh()
        If CurrentEmployee.Count < 1 Then Exit Sub

        With lsvTotals
            .Columns(0).Text = "TOTALS:"
            .Columns(1).Text = g.ToString("0.00")
            .Columns(2).Text = f.ToString("0.00")
            .Columns(3).Text = s.ToString("0.00")
            .Columns(4).Text = m.ToString("0.00")
            .Columns(5).Text = n.ToString("0.00")

        End With

        If lsvChecks.Items.Count > 8 Then
            lsvChecks.Columns(5).Width = 111
        Else
            lsvChecks.Columns(5).Width = 127
        End If

    End Sub

    Private Sub HistoryDocument_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles HistoryDocument.PrintPage
        Dim x As Integer

        With e.Graphics
            .DrawString(CurrentEmployee(ce.SocialSecuityNumber), iFont, iBrush, 30, 25)
            .DrawString(cmbMonth.Text, iFont, iBrush, 30, 45)
            .DrawString(CurrentEmployee(ce.Name) & " PAYROLL ROSTER", iFont, Brushes.Black, 400, 25)
            .DrawString("AS OF " & DateString.ToString, iFont, Brushes.Black, 850, 25)
            .DrawString("DATE", iFont, iBrush, 30, 100)
            .DrawString("GROSS WAGES", iFont, iBrush, 212, 100)
            .DrawString("FEDERAL INCOME", iFont, iBrush, 404, 100)
            .DrawString("SOCIAL SECURITY", iFont, iBrush, 596, 100)
            .DrawString("MEDICARE", iFont, iBrush, 788, 100)
            .DrawString("NET PAY", iFont, iBrush, 950, 100)
            .DrawLine(Pens.Black, 30, 121, 1030, 121)


            For x = 0 To lsvChecks.Items.Count - 1
                .DrawString(lsvChecks.Items(x).SubItems(0).Text, iFont, iBrush, 30, 125 + x * 20)
                .DrawString(lsvChecks.Items(x).SubItems(1).Text, iFont, iBrush, 212, 125 + x * 20)
                .DrawString(lsvChecks.Items(x).SubItems(2).Text, iFont, iBrush, 404, 125 + x * 20)
                .DrawString(lsvChecks.Items(x).SubItems(3).Text, iFont, iBrush, 596, 125 + x * 20)
                .DrawString(lsvChecks.Items(x).SubItems(4).Text, iFont, iBrush, 788, 125 + x * 20)
                .DrawString(lsvChecks.Items(x).SubItems(5).Text, iFont, iBrush, 950, 125 + x * 20)
            Next

            x += 1

            .DrawLine(Pens.Black, 30, 115 + x * 20, 1030, 115 + x * 20)
            .DrawLine(Pens.Black, 30, 118 + x * 20, 1030, 118 + x * 20)

            .DrawString("TOTALS:", iFont, iBrush, 30, 125 + x * 20)
            .DrawString(g.ToString("0.00"), iFont, iBrush, 212, 125 + x * 20)
            .DrawString(f.ToString("0.00"), iFont, iBrush, 404, 125 + x * 20)
            .DrawString(s.ToString("0.00"), iFont, iBrush, 596, 125 + x * 20)
            .DrawString(m.ToString("0.00"), iFont, iBrush, 788, 125 + x * 20)
            .DrawString(n.ToString("0.00"), iFont, iBrush, 950, 125 + x * 20)

        End With
    End Sub

    Private Sub HistoryDocument_QueryPageSettings(ByVal sender As Object, ByVal e As System.Drawing.Printing.QueryPageSettingsEventArgs) Handles HistoryDocument.QueryPageSettings
        e.PageSettings.Landscape = True
    End Sub

    Private Sub cbCustom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        UpdateUI()
    End Sub

    Private Sub tsExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsExit.Click
        End
    End Sub

    Private Sub tsChangeEmployeeData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsChangeEmployeeData.Click
        If CurrentEmployee.Count = 0 Then Exit Sub

        Dim sStr() As String = CurrentEmployee(ce.CityStateZip).ToString.Split(" ")

        With frmAddEmployee
            .Show()
            .txtName.Text = CurrentEmployee(ce.Name)
            .txtCity.Text = sStr(0).Replace("_", " ")
            .txtExemptions.Text = CurrentEmployee(ce.Exemptions)
            .txtPayRate.Text = CurrentEmployee(ce.Payrate)
            .txtSSN.Text = CurrentEmployee(ce.SocialSecuityNumber)
            .txtOldSSN.Text = .txtSSN.Text
            .txtStreetAddress.Text = CurrentEmployee(ce.StreetAddress)
            .txtZipCode.Text = sStr(2)
            .lstMaritalStatus.Text = CurrentEmployee(ce.MaritalStatus)

        End With
        ReadEmployeeData(lsbEmployees.SelectedItem.ToString.Substring(lsbEmployees.SelectedItem.ToString.LastIndexOf(":") + 1, 9))
    End Sub

    Private Sub tsDeleteEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDeleteEmployee.Click
        If MsgBox("Are you sure you want to delete " & CurrentEmployee(ce.Name) & "'s record?", MsgBoxStyle.YesNo, "Delete Record...") = MsgBoxResult.No Then Exit Sub
        Try
            FileSystem.Kill(path & "employees\" & CurrentEmployee(ce.SocialSecuityNumber).Replace("-", "") & ".wrk")
            FindEmployees()
        Catch err As Exception
            MsgBox("An error occured", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub tsAddEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsAddEmployee.Click
        CurrentEmployee.Clear()
        frmAddEmployee.Show()
    End Sub

    Private Sub tsDeleteCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsDeleteCheck.Click
        If lsvChecks.Items.Count < 1 Then Exit Sub

        If CheckMonth <> "" Then
            MsgBox("You can only delete a check in ALL YEAR mode.")
            Exit Sub
        End If

        Dim aVar As Integer = 0

        For Each lvItem As ListViewItem In lsvChecks.Items
            If lsvChecks.Items(aVar).Selected = True Then Exit For
            aVar += 1
        Next

        If aVar = lsvChecks.Items.Count Then Exit Sub

        If MsgBox("Are you sure you want to delete this check?" & vbNewLine & vbNewLine & lsvChecks.Items(aVar).SubItems(0).Text & " : $" & lsvChecks.Items(aVar).SubItems(5).Text, MsgBoxStyle.YesNo, "Removing Check...") = MsgBoxResult.No Then Exit Sub

        Try
            CurrentEmployee.Remove(aVar + ce.CheckHeading + 1)
        Catch b As Exception
            CurrentEmployee.Remove(ce.CheckHeading + 1)
        End Try

        WriteEmployeeData()
        ReadEmployeeData(CurrentEmployee(ce.SocialSecuityNumber))

        UpdateUI()
    End Sub

    Private Sub tsShowCheckWriter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsShowCheckWriter.Click
        frmPayBill.Show()
    End Sub

    Private Sub tsShowCalculator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsShowCalculator.Click
        frmSimple.Show()
    End Sub

    Private Sub tsSortFirstName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSortFirstName.Click
        strSort = "FIRST NAME"
        tsSortFirstName.Checked = True
        tsSortLastName.Checked = False

        FindEmployees()
    End Sub

    Private Sub tsSortLastName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSortLastName.Click
        strSort = "LAST NAME"
        tsSortFirstName.Checked = False
        tsSortLastName.Checked = True

        FindEmployees()
    End Sub

    Private Sub cmbMonth_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMonth.SelectedIndexChanged
        Select Case cmbMonth.Text
            Case "ALL YEAR"
                CheckMonth = ""
            Case "JANUARY"
                CheckMonth = "01"
            Case "FEBRUARY"
                CheckMonth = "02"
            Case "MARCH"
                CheckMonth = "03"
            Case "APRIL"
                CheckMonth = "04"
            Case "MAY"
                CheckMonth = "05"
            Case "JUNE"
                CheckMonth = "06"
            Case "JULY"
                CheckMonth = "07"
            Case "AUGUST"
                CheckMonth = "08"
            Case "SEPTEMBER"
                CheckMonth = "09"
            Case "OCTOBER"
                CheckMonth = "10"
            Case "NOVEMBER"
                CheckMonth = "11"
            Case "DECEMBER"
                CheckMonth = "12"
            Case "1ST QUARTER"
                CheckMonth = "13"
            Case "2ND QUARTER"
                CheckMonth = "14"
            Case "3RD QUARTER"
                CheckMonth = "15"
            Case "4TH QUARTER"
                CheckMonth = "16"
            Case "----------------"
                CheckMonth = ""
                cmbMonth.Text = "ALL YEAR"

        End Select
        If CurrentEmployee.Count > 0 Then ReadEmployeeData(CurrentEmployee(ce.SocialSecuityNumber))
        UpdateUI()
    End Sub

    Private Sub txtHours_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHours.TextChanged
        If Val(txtHours.Text) > 40 Then
            pbCurrent.Refresh()
        End If
    End Sub

    Private Sub tsAddMemo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsAddMemo.Click
        strMemo = InputBox("Enter the check memo you would like to add", "Enter memo...")
    End Sub

    Private Sub cmdPrintHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintHistory.Click
        tsPrintHistory.PerformClick()
    End Sub

    Private Sub tsPrintHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsPrintHistory.Click
        PrintDialog.Document = HistoryDocument
        HistoryDocument.DocumentName = "Payment history for " & CurrentEmployee(ce.Name)
        If PrintDialog.ShowDialog = Windows.Forms.DialogResult.OK Then HistoryDocument.Print()
    End Sub

    Private Sub tsCalender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsCalender.Click
        frmCalender.Show()
    End Sub

    Private Sub tsPrintCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsPrintCheck.Click
        cmdPrintCheck.PerformClick()
    End Sub

    Private Sub tsRunSingle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsRunSingle.Click
        cmdPayroll.PerformClick()
    End Sub

    Private Sub tsInformation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsInformation.Click
        frmInfo.Show()
    End Sub

    Private Sub tsSet2009_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSet2009.Click
        strYear = "2009"
        tsSet2010.Checked = False
        tsSet2009.Checked = True
        tsSet2008.Checked = False
        cmdPrintCheck.Enabled = False
        tsPrintCheck.Enabled = False
        MsgBox("You are now in a previous tax year." & vbNewLine & "All payroll reporting functions are disabled.", MsgBoxStyle.Exclamation)
        ReadEmployeeData(CurrentEmployee(ce.SocialSecuityNumber))
        UpdateUI()
    End Sub

    Private Sub tsSet2008_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSet2008.Click
        strYear = "2008"
        tsSet2008.Checked = True
        tsSet2009.Checked = False
        tsSet2010.Checked = False
        cmdPrintCheck.Enabled = False
        tsPrintCheck.Enabled = False
        MsgBox("You are now in a previous tax year." & vbNewLine & "All payroll reporting functions are disabled.", MsgBoxStyle.Exclamation)
        ReadEmployeeData(CurrentEmployee(ce.SocialSecuityNumber))
        UpdateUI()
    End Sub

    Private Sub BackupEmployeeDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupEmployeeDataToolStripMenuItem.Click
        If My.Computer.FileSystem.DirectoryExists(path & "\" & DateString.ToString) = True Then
            MsgBox("Backup already exists for today.", MsgBoxStyle.Information)
            Exit Sub
        End If

        My.Computer.FileSystem.CreateDirectory(path & "\" & DateString.ToString)
        My.Computer.FileSystem.CopyDirectory(path & "employees\", path & "\" & DateString.ToString)
    End Sub

    Private Sub tsSet2010_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsSet2010.Click
        strYear = "2010"
        tsSet2010.Checked = True
        tsSet2009.Checked = False
        tsSet2008.Checked = False
        cmdPrintCheck.Enabled = True
        tsPrintCheck.Enabled = True
        ReadEmployeeData(CurrentEmployee(ce.SocialSecuityNumber))
        UpdateUI()
    End Sub
End Class
