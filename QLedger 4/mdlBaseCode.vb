Module mdlBaseCode
    Public freefile As Byte

    Public path As String = Application.StartupPath & "\"

    Public CurrentEmployee As New Collection

    Public GlobalPay, GlobalFederalIncomeTax, GlobalFICA As Decimal

    Public Function Round(ByVal decNum As Decimal) As Decimal
        Return Decimal.Round(decNum, 2)
    End Function

    Public Function MedicareTax(ByVal GrossPay As Decimal) As Decimal
        Return Round(GrossPay * 0.0145)
    End Function

    Public Function SocialSecurityTax(ByVal GrossPay As Decimal) As Decimal
        Return Round(GrossPay * 0.062)
    End Function

    Public Function FederalIncomeTax(ByVal GrossPay As Decimal, ByVal Allowances As Integer, ByVal Status As String) As Decimal
        Dim decWithholding As Decimal

        GrossPay = GrossPay - (70.19 * Allowances)

        If Status = "SINGLE" Then
            If GrossPay <= 116 Then Return 0
            If GrossPay > 116 And GrossPay <= 200 Then decWithholding = (GrossPay - 51) * 0.1
            If GrossPay > 200 And GrossPay <= 681 Then decWithholding = (GrossPay - 200) * 0.15 + 14.9
            If GrossPay > 693 And GrossPay <= 1621 Then decWithholding = (GrossPay - 681) * 0.25 + 87.05
            If GrossPay > 1302 And GrossPay <= 3338 Then decWithholding = (GrossPay - 1621) * 0.28 + 322.05
            If GrossPay > 3338 And GrossPay <= 7212 Then decWithholding = (GrossPay - 3338) * 0.33 + 802.81
            If GrossPay > 7212 Then decWithholding = (GrossPay - 7212) * 0.35 + 2081.23
        Else
            If GrossPay <= 154 Then Return 0
            If GrossPay > 154 And GrossPay <= 461 Then decWithholding = (GrossPay - 154) * 0.1
            If GrossPay > 461 And GrossPay <= 1455 Then decWithholding = (GrossPay - 461) * 0.15 + 30.7
            If GrossPay > 1455 And GrossPay <= 2785 Then decWithholding = (GrossPay - 1455) * 0.25 + 179.8
            If GrossPay > 2785 And GrossPay <= 4165 Then decWithholding = (GrossPay - 2785) * 0.28 + 512.3
            If GrossPay > 4165 And GrossPay <= 7321 Then decWithholding = (GrossPay - 4165) * 0.33 + 898.7
            If GrossPay > 7321 Then decWithholding = (GrossPay - 7321) * 0.35 + 1940.18
        End If

        Return Round(decWithholding)

    End Function

    Enum ce
        Name = 1
        StreetAddress = 2
        CityStateZip = 3
        SocialSecuityNumber = 4
        Payrate = 5
        MaritalStatus = 6
        Exemptions = 7
        CheckHeading = 8
    End Enum

    Enum month
        January = 1
        February = 2
        March = 3
        April = 4
        May = 5
        June = 6
        July = 7
        August = 8
        September = 9
        October = 10
        November = 11
        December = 12
    End Enum
End Module
