Module DecimalToText

    Public Function ConvertDecimalToText(ByVal decAmount As Decimal) As String

        Dim strAmount As String = ""
        Dim decValue As Decimal = decAmount
        Dim amount() As Char
        amount = decValue.ToString.ToCharArray()

        Dim places As Integer
        places = amount.Length - 3
        If amount(0) = "0" Then
            places = places - 1
        End If

        Select Case places
            Case 0
                'change only
                strAmount = "Zero " & GetChange(amount)
            Case 1
                'dollar
                strAmount = GetDollars(amount(0)) & GetChange(amount)
            Case 2
                'tens of dollars
                Dim strTemp As String = amount(0) & amount(1)
                strAmount = GetTensOfDollars(strTemp) & GetChange(amount)
            Case 3
                'hundreds of dollars
                Dim strTemp As String = amount(1) & amount(2)
                strAmount = GetHundredsOfDollars(amount(0)) & GetTensOfDollars(strTemp) & GetChange(amount)
            Case 4
                'thousands of dollars
                Dim strTemp10s As String = amount(2) & amount(3)
                strAmount = GetThousandsOfDollars(amount(0)) & GetHundredsOfDollars(amount(1)) & GetTensOfDollars(strTemp10s) & GetChange(amount)
            Case 5
                'tens of thousands of dollars
                Dim strTemp1000s As String = amount(0) & amount(1)
                Dim strTemp10s As String = amount(3) & amount(4)
                strAmount = GetTenThousandsOfDollars(strTemp1000s) & GetHundredsOfDollars(amount(2)) & GetTensOfDollars(strTemp10s) & GetChange(amount)
            Case 6
                'hundreds of thousands of dollars
                Dim strTemp1000s As String = amount(1) & amount(2)
                Dim strTemp10s As String = amount(4) & amount(5)
                If amount(1) = "0" And amount(2) = "0" Then
                    strAmount = Get100ThousandsOfDollars(amount(0), True) & GetTenThousandsOfDollars(strTemp1000s) & GetHundredsOfDollars(amount(3)) & GetTensOfDollars(strTemp10s) & GetChange(amount)
                Else
                    strAmount = Get100ThousandsOfDollars(amount(0), false) & GetTenThousandsOfDollars(strTemp1000s) & GetHundredsOfDollars(amount(3)) & GetTensOfDollars(strTemp10s) & GetChange(amount)
                End If
            Case 7
                'one million dollars
                Dim strTempMillions As String = amount(0)
                Dim strTemp1000s As String = amount(2) & amount(3)
                Dim strTemp10s As String = amount(5) & amount(6)
                If amount(2) = "0" And amount(3) = "0" Then
                    strAmount = GetMillionsOfDollars(strTempMillions) & Get100ThousandsOfDollars(amount(1), True) & GetTenThousandsOfDollars(strTemp1000s) & GetHundredsOfDollars(amount(4)) & GetTensOfDollars(strTemp10s) & GetChange(amount)
                Else
                    strAmount = GetMillionsOfDollars(strTempMillions) & Get100ThousandsOfDollars(amount(1), False) & GetTenThousandsOfDollars(strTemp1000s) & GetHundredsOfDollars(amount(4)) & GetTensOfDollars(strTemp10s) & GetChange(amount)
                End If
            Case 8
                strAmount = "Passed maximum amount"
            Case Else
                strAmount = "Unknown number submitted"
        End Select

        Return strAmount

    End Function



    Private Function GetChange(ByVal chn() As Char)

        Dim amount() As Char = chn
        Dim strAmount As String = ""
        Dim indexVal As Integer = amount.Length - 1

        Select Case amount(indexVal - 1)
            Case "1"
                Select Case amount(indexVal)
                    Case "1"
                        strAmount = strAmount & "and 11/100's Dollars"
                    Case "2"
                        strAmount = strAmount & "and 12/100's Dollars"
                    Case "3"
                        strAmount = strAmount & "and 13/100's Dollars"
                    Case "4"
                        strAmount = strAmount & "and 14/100's Dollars"
                    Case "5"
                        strAmount = strAmount & "and 15/100's Dollars"
                    Case "6"
                        strAmount = strAmount & "and 16/100's Dollars"
                    Case "7"
                        strAmount = strAmount & "and 17/100's Dollars"
                    Case "8"
                        strAmount = strAmount & "and 18/100's Dollars"
                    Case "9"
                        strAmount = strAmount & "and 19/100's Dollars"
                    Case "0"
                        strAmount = strAmount & "and 10/100's Dollars"
                End Select
            Case "2"
                Select Case amount(indexVal)
                    Case "1"
                        strAmount = strAmount & "and 21/100's Dollars"
                    Case "2"
                        strAmount = strAmount & "and 22/100's Dollars"
                    Case "3"
                        strAmount = strAmount & "and 23/100's Dollars"
                    Case "4"
                        strAmount = strAmount & "and 24/100's Dollars"
                    Case "5"
                        strAmount = strAmount & "and 25/100's Dollars"
                    Case "6"
                        strAmount = strAmount & "and 26/100's Dollars"
                    Case "7"
                        strAmount = strAmount & "and 27/100's Dollars"
                    Case "8"
                        strAmount = strAmount & "and 28/100's Dollars"
                    Case "9"
                        strAmount = strAmount & "and 29/100's Dollars"
                    Case "0"
                        strAmount = strAmount & "and 20/100's Dollars"
                End Select
            Case "3"
                Select Case amount(indexVal)
                    Case "1"
                        strAmount = strAmount & "and 31/100's Dollars"
                    Case "2"
                        strAmount = strAmount & "and 32/100's Dollars"
                    Case "3"
                        strAmount = strAmount & "and 33/100's Dollars"
                    Case "4"
                        strAmount = strAmount & "and 34/100's Dollars"
                    Case "5"
                        strAmount = strAmount & "and 35/100's Dollars"
                    Case "6"
                        strAmount = strAmount & "and 36/100's Dollars"
                    Case "7"
                        strAmount = strAmount & "and 37/100's Dollars"
                    Case "8"
                        strAmount = strAmount & "and 38/100's Dollars"
                    Case "9"
                        strAmount = strAmount & "and 39/100's Dollars"
                    Case "0"
                        strAmount = strAmount & "and 30/100's Dollars"
                End Select
            Case "4"
                Select Case amount(indexVal)
                    Case "1"
                        strAmount = strAmount & "and 41/100's Dollars"
                    Case "2"
                        strAmount = strAmount & "and 42/100's Dollars"
                    Case "3"
                        strAmount = strAmount & "and 43/100's Dollars"
                    Case "4"
                        strAmount = strAmount & "and 44/100's Dollars"
                    Case "5"
                        strAmount = strAmount & "and 45/100's Dollars"
                    Case "6"
                        strAmount = strAmount & "and 46/100's Dollars"
                    Case "7"
                        strAmount = strAmount & "and 47/100's Dollars"
                    Case "8"
                        strAmount = strAmount & "and 48/100's Dollars"
                    Case "9"
                        strAmount = strAmount & "and 49/100's Dollars"
                    Case "0"
                        strAmount = strAmount & "and 40/100's Dollars"
                End Select
            Case "5"
                Select Case amount(indexVal)
                    Case "1"
                        strAmount = strAmount & "and 51/100's Dollars"
                    Case "2"
                        strAmount = strAmount & "and 52/100's Dollars"
                    Case "3"
                        strAmount = strAmount & "and 53/100's Dollars"
                    Case "4"
                        strAmount = strAmount & "and 54/100's Dollars"
                    Case "5"
                        strAmount = strAmount & "and 55/100's Dollars"
                    Case "6"
                        strAmount = strAmount & "and 56/100's Dollars"
                    Case "7"
                        strAmount = strAmount & "and 57/100's Dollars"
                    Case "8"
                        strAmount = strAmount & "and 58/100's Dollars"
                    Case "9"
                        strAmount = strAmount & "and 59/100's Dollars"
                    Case "0"
                        strAmount = strAmount & "and 50/100's Dollars"
                End Select
            Case "6"
                Select Case amount(indexVal)
                    Case "1"
                        strAmount = strAmount & "and 61/100's Dollars"
                    Case "2"
                        strAmount = strAmount & "and 62/100's Dollars"
                    Case "3"
                        strAmount = strAmount & "and 63/100's Dollars"
                    Case "4"
                        strAmount = strAmount & "and 64/100's Dollars"
                    Case "5"
                        strAmount = strAmount & "and 65/100's Dollars"
                    Case "6"
                        strAmount = strAmount & "and 66/100's Dollars"
                    Case "7"
                        strAmount = strAmount & "and 67/100's Dollars"
                    Case "8"
                        strAmount = strAmount & "and 68/100's Dollars"
                    Case "9"
                        strAmount = strAmount & "and 69/100's Dollars"
                    Case "0"
                        strAmount = strAmount & "and 60/100's Dollars"
                End Select
            Case "7"
                Select Case amount(indexVal)
                    Case "1"
                        strAmount = strAmount & "and 71/100's Dollars"
                    Case "2"
                        strAmount = strAmount & "and 72/100's Dollars"
                    Case "3"
                        strAmount = strAmount & "and 73/100's Dollars"
                    Case "4"
                        strAmount = strAmount & "and 74/100's Dollars"
                    Case "5"
                        strAmount = strAmount & "and 75/100's Dollars"
                    Case "6"
                        strAmount = strAmount & "and 76/100's Dollars"
                    Case "7"
                        strAmount = strAmount & "and 77/100's Dollars"
                    Case "8"
                        strAmount = strAmount & "and 78/100's Dollars"
                    Case "9"
                        strAmount = strAmount & "and 79/100's Dollars"
                    Case "0"
                        strAmount = strAmount & "and 70/100's Dollars"
                End Select
            Case "8"
                Select Case amount(indexVal)
                    Case "1"
                        strAmount = strAmount & "and 81/100's Dollars"
                    Case "2"
                        strAmount = strAmount & "and 82/100's Dollars"
                    Case "3"
                        strAmount = strAmount & "and 83/100's Dollars"
                    Case "4"
                        strAmount = strAmount & "and 84/100's Dollars"
                    Case "5"
                        strAmount = strAmount & "and 85/100's Dollars"
                    Case "6"
                        strAmount = strAmount & "and 86/100's Dollars"
                    Case "7"
                        strAmount = strAmount & "and 87/100's Dollars"
                    Case "8"
                        strAmount = strAmount & "and 88/100's Dollars"
                    Case "9"
                        strAmount = strAmount & "and 89/100's Dollars"
                    Case "0"
                        strAmount = strAmount & "and 80/100's Dollars"
                End Select
            Case "9"
                Select Case amount(indexVal)
                    Case "1"
                        strAmount = strAmount & "and 91/100's Dollars"
                    Case "2"
                        strAmount = strAmount & "and 92/100's Dollars"
                    Case "3"
                        strAmount = strAmount & "and 93/100's Dollars"
                    Case "4"
                        strAmount = strAmount & "and 94/100's Dollars"
                    Case "5"
                        strAmount = strAmount & "and 95/100's Dollars"
                    Case "6"
                        strAmount = strAmount & "and 96/100's Dollars"
                    Case "7"
                        strAmount = strAmount & "and 97/100's Dollars"
                    Case "8"
                        strAmount = strAmount & "and 98/100's Dollars"
                    Case "9"
                        strAmount = strAmount & "and 99/100's Dollars"
                    Case "0"
                        strAmount = strAmount & "and 90/100's Dollars"
                End Select
            Case "0"
                Select Case amount(indexVal)
                    Case "1"
                        strAmount = strAmount & "and 1/100's Dollars"
                    Case "2"
                        strAmount = strAmount & "and 2/100's Dollars"
                    Case "3"
                        strAmount = strAmount & "and 3/100's Dollars"
                    Case "4"
                        strAmount = strAmount & "and 4/100's Dollars"
                    Case "5"
                        strAmount = strAmount & "and 5/100's Dollars"
                    Case "6"
                        strAmount = strAmount & "and 6/100's Dollars"
                    Case "7"
                        strAmount = strAmount & "and 7/100's Dollars"
                    Case "8"
                        strAmount = strAmount & "and 8/100's Dollars"
                    Case "9"
                        strAmount = strAmount & "and 9/100's Dollars"
                    Case "0"
                        strAmount = strAmount & "and 0/100's Dollars"
                End Select
        End Select

        Return strAmount

    End Function



    Private Function GetDollars(ByVal cd As Char)

        Dim strDollars As String = ""

        Select Case cd
            Case "1"
                strDollars = "One "
            Case "2"
                strDollars = "Two "
            Case "3"
                strDollars = "Three "
            Case "4"
                strDollars = "Four "
            Case "5"
                strDollars = "Five "
            Case "6"
                strDollars = "Six "
            Case "7"
                strDollars = "Seven "
            Case "8"
                strDollars = "Eight "
            Case "9"
                strDollars = "Nine "
            Case "0"
                strDollars = "Zero "
        End Select


        Return strDollars

    End Function



    Private Function GetTensOfDollars(ByVal cd As String)

        Dim strDollars As String = ""

        Select Case cd
            Case "00"
                strDollars = ""
            Case "01"
                strDollars = "One "
            Case "02"
                strDollars = "Two "
            Case "03"
                strDollars = "Three "
            Case "04"
                strDollars = "Four "
            Case "05"
                strDollars = "Five "
            Case "06"
                strDollars = "Six "
            Case "07"
                strDollars = "Seven "
            Case "08"
                strDollars = "Eight "
            Case "09"
                strDollars = "Nine "
            Case "10"
                strDollars = "Ten "
            Case "11"
                strDollars = "Eleven "
            Case "12"
                strDollars = "Twelve "
            Case "13"
                strDollars = "Thirteen "
            Case "14"
                strDollars = "Fourteen "
            Case "15"
                strDollars = "Fifteen "
            Case "16"
                strDollars = "Sixteen "
            Case "17"
                strDollars = "Seventeen "
            Case "18"
                strDollars = "Eighteen "
            Case "19"
                strDollars = "Nineteen "
            Case "20"
                strDollars = "Twenty "
            Case "21"
                strDollars = "Twenty-One "
            Case "22"
                strDollars = "Twenty-Two "
            Case "23"
                strDollars = "Twenty-Three "
            Case "24"
                strDollars = "Twenty-Four "
            Case "25"
                strDollars = "Twenty-Five "
            Case "26"
                strDollars = "Twenty-Six "
            Case "27"
                strDollars = "Twenty-Seven "
            Case "28"
                strDollars = "Twenty-Eight "
            Case "29"
                strDollars = "Twenty-Nine "
            Case "30"
                strDollars = "Thirty "
            Case "31"
                strDollars = "Thirty-One "
            Case "32"
                strDollars = "Thirty-Two "
            Case "33"
                strDollars = "Thirty-Three "
            Case "34"
                strDollars = "Thirty-Four "
            Case "35"
                strDollars = "Thirty-Five "
            Case "36"
                strDollars = "Thirty-Six "
            Case "37"
                strDollars = "Thirty-Seven "
            Case "38"
                strDollars = "Thirty-Eight "
            Case "39"
                strDollars = "Thirty-Nine "
            Case "40"
                strDollars = "Fourty "
            Case "41"
                strDollars = "Fourty-One "
            Case "42"
                strDollars = "Fourty-Two "
            Case "43"
                strDollars = "Fourty-Three "
            Case "44"
                strDollars = "Fourty-Four "
            Case "45"
                strDollars = "Fourty-Five "
            Case "46"
                strDollars = "Fourty-Six "
            Case "47"
                strDollars = "Fourty-Seven "
            Case "48"
                strDollars = "Fourty-Eight "
            Case "49"
                strDollars = "Fourty-Nine "
            Case "50"
                strDollars = "Fifty "
            Case "51"
                strDollars = "Fifty-One "
            Case "52"
                strDollars = "Fifty-Two "
            Case "53"
                strDollars = "Fifty-Three "
            Case "54"
                strDollars = "Fifty-Four "
            Case "55"
                strDollars = "Fifty-Five "
            Case "56"
                strDollars = "Fifty-Six "
            Case "57"
                strDollars = "Fifty-Seven "
            Case "58"
                strDollars = "Fifty-Eight "
            Case "59"
                strDollars = "Fifty-Nine "
            Case "60"
                strDollars = "Sixty "
            Case "61"
                strDollars = "Sixty-One "
            Case "62"
                strDollars = "Sixty-Two "
            Case "63"
                strDollars = "Sixty-Three "
            Case "64"
                strDollars = "Sixty-Four "
            Case "65"
                strDollars = "Sixty-Five "
            Case "66"
                strDollars = "Sixty-Six "
            Case "67"
                strDollars = "Sixty-Seven "
            Case "68"
                strDollars = "Sixty-Eight "
            Case "69"
                strDollars = "Sixty-Nine "
            Case "70"
                strDollars = "Seventy "
            Case "71"
                strDollars = "Seventy-One "
            Case "72"
                strDollars = "Seventy-Two "
            Case "73"
                strDollars = "Seventy-Three "
            Case "74"
                strDollars = "Seventy-Four "
            Case "75"
                strDollars = "Seventy-Five "
            Case "76"
                strDollars = "Seventy-Six "
            Case "77"
                strDollars = "Seventy-Seven "
            Case "78"
                strDollars = "Seventy-Eight "
            Case "79"
                strDollars = "Seventy-Nine "
            Case "80"
                strDollars = "Eighty "
            Case "81"
                strDollars = "Eighty-One "
            Case "82"
                strDollars = "Eighty-Two "
            Case "83"
                strDollars = "Eighty-Three "
            Case "84"
                strDollars = "Eighty-Four "
            Case "85"
                strDollars = "Eighty-Five "
            Case "86"
                strDollars = "Eighty-Six "
            Case "87"
                strDollars = "Eighty-Seven "
            Case "88"
                strDollars = "Eighty-Eight "
            Case "89"
                strDollars = "Eighty-Nine "
            Case "90"
                strDollars = "Ninety "
            Case "91"
                strDollars = "Ninety-One "
            Case "92"
                strDollars = "Ninety-Two "
            Case "93"
                strDollars = "Ninety-Three "
            Case "94"
                strDollars = "Ninety-Four "
            Case "95"
                strDollars = "Ninety-Five "
            Case "96"
                strDollars = "Ninety-Six "
            Case "97"
                strDollars = "Ninety-Seven "
            Case "98"
                strDollars = "Ninety-Eight "
            Case "99"
                strDollars = "Ninety-Nine "
        End Select


        Return strDollars

    End Function



    Private Function GetHundredsOfDollars(ByVal cd As Char)

        Dim strDollars As String = ""

        Select Case cd
            Case "1"
                strDollars = "One Hundred "
            Case "2"
                strDollars = "Two Hundred "
            Case "3"
                strDollars = "Three Hundred "
            Case "4"
                strDollars = "Four Hundred "
            Case "5"
                strDollars = "Five Hundred "
            Case "6"
                strDollars = "Six Hundred "
            Case "7"
                strDollars = "Seven Hundred "
            Case "8"
                strDollars = "Eight Hundred "
            Case "9"
                strDollars = "Nine Hundred "
            Case "0"
                strDollars = " "
        End Select


        Return strDollars

    End Function



    Private Function GetThousandsOfDollars(ByVal cd As Char)

        Dim strDollars As String = ""

        Select Case cd
            Case "1"
                strDollars = "One Thousand "
            Case "2"
                strDollars = "Two Thousand "
            Case "3"
                strDollars = "Three Thousand "
            Case "4"
                strDollars = "Four Thousand "
            Case "5"
                strDollars = "Five Thousand "
            Case "6"
                strDollars = "Six Thousand "
            Case "7"
                strDollars = "Seven Thousand "
            Case "8"
                strDollars = "Eight Thousand "
            Case "9"
                strDollars = "Nine Thousand "
            Case "0"
                strDollars = "Zero Thousand "
        End Select


        Return strDollars

    End Function




    Private Function GetTenThousandsOfDollars(ByVal cd As String)

        Dim strDollars As String = ""

        Select Case cd
            Case "00"
                strDollars = ""
            Case "01"
                strDollars = "One Thousand "
            Case "02"
                strDollars = "Two Thousand "
            Case "03"
                strDollars = "Three Thousand "
            Case "04"
                strDollars = "Four Thousand "
            Case "05"
                strDollars = "Five Thousand "
            Case "06"
                strDollars = "Six Thousand "
            Case "07"
                strDollars = "Seven Thousand "
            Case "08"
                strDollars = "Eight Thousand "
            Case "09"
                strDollars = "Nine Thousand "
            Case "10"
                strDollars = "Ten Thousand "
            Case "11"
                strDollars = "Eleven Thousand "
            Case "12"
                strDollars = "Twelve Thousand "
            Case "13"
                strDollars = "Thirteen Thousand "
            Case "14"
                strDollars = "Fourteen Thousand "
            Case "15"
                strDollars = "Fifteen Thousand "
            Case "16"
                strDollars = "Sixteen Thousand "
            Case "17"
                strDollars = "Seventeen Thousand "
            Case "18"
                strDollars = "Eighteen Thousand "
            Case "19"
                strDollars = "Nineteen Thousand "
            Case "20"
                strDollars = "Twenty Thousand "
            Case "21"
                strDollars = "Twenty-One Thousand "
            Case "22"
                strDollars = "Twenty-Two Thousand "
            Case "23"
                strDollars = "Twenty-Three Thousand "
            Case "24"
                strDollars = "Twenty-Four Thousand "
            Case "25"
                strDollars = "Twenty-Five Thousand "
            Case "26"
                strDollars = "Twenty-Six Thousand "
            Case "27"
                strDollars = "Twenty-Seven Thousand "
            Case "28"
                strDollars = "Twenty-Eight Thousand "
            Case "29"
                strDollars = "Twenty-Nine Thousand "
            Case "30"
                strDollars = "Thirty Thousand "
            Case "31"
                strDollars = "Thirty-One Thousand "
            Case "32"
                strDollars = "Thirty-Two Thousand "
            Case "33"
                strDollars = "Thirty-Three Thousand "
            Case "34"
                strDollars = "Thirty-Four Thousand "
            Case "35"
                strDollars = "Thirty-Five Thousand "
            Case "36"
                strDollars = "Thirty-Six Thousand "
            Case "37"
                strDollars = "Thirty-Seven Thousand "
            Case "38"
                strDollars = "Thirty-Eight Thousand "
            Case "39"
                strDollars = "Thirty-Nine Thousand "
            Case "40"
                strDollars = "Fourty Thousand "
            Case "41"
                strDollars = "Fourty-One Thousand "
            Case "42"
                strDollars = "Fourty-Two Thousand "
            Case "43"
                strDollars = "Fourty-Three Thousand "
            Case "44"
                strDollars = "Fourty-Four Thousand "
            Case "45"
                strDollars = "Fourty-Five Thousand "
            Case "46"
                strDollars = "Fourty-Six Thousand "
            Case "47"
                strDollars = "Fourty-Seven Thousand "
            Case "48"
                strDollars = "Fourty-Eight Thousand "
            Case "49"
                strDollars = "Fourty-Nine Thousand "
            Case "50"
                strDollars = "Fifty Thousand "
            Case "51"
                strDollars = "Fifty-One Thousand "
            Case "52"
                strDollars = "Fifty-Two Thousand "
            Case "53"
                strDollars = "Fifty-Three Thousand "
            Case "54"
                strDollars = "Fifty-Four Thousand "
            Case "55"
                strDollars = "Fifty-Five Thousand "
            Case "56"
                strDollars = "Fifty-Six Thousand "
            Case "57"
                strDollars = "Fifty-Seven Thousand "
            Case "58"
                strDollars = "Fifty-Eight Thousand "
            Case "59"
                strDollars = "Fifty-Nine Thousand "
            Case "60"
                strDollars = "Sixty Thousand "
            Case "61"
                strDollars = "Sixty-One Thousand "
            Case "62"
                strDollars = "Sixty-Two Thousand "
            Case "63"
                strDollars = "Sixty-Three Thousand "
            Case "64"
                strDollars = "Sixty-Four Thousand "
            Case "65"
                strDollars = "Sixty-Five Thousand "
            Case "66"
                strDollars = "Sixty-Six Thousand "
            Case "67"
                strDollars = "Sixty-Seven Thousand "
            Case "68"
                strDollars = "Sixty-Eight Thousand "
            Case "69"
                strDollars = "Sixty-Nine Thousand "
            Case "70"
                strDollars = "Seventy Thousand "
            Case "71"
                strDollars = "Seventy-One Thousand "
            Case "72"
                strDollars = "Seventy-Two Thousand "
            Case "73"
                strDollars = "Seventy-Three Thousand "
            Case "74"
                strDollars = "Seventy-Four Thousand "
            Case "75"
                strDollars = "Seventy-Five Thousand "
            Case "76"
                strDollars = "Seventy-Six Thousand "
            Case "77"
                strDollars = "Seventy-Seven Thousand "
            Case "78"
                strDollars = "Seventy-Eight Thousand "
            Case "79"
                strDollars = "Seventy-Nine Thousand "
            Case "80"
                strDollars = "Eighty Thousand "
            Case "81"
                strDollars = "Eighty-One Thousand "
            Case "82"
                strDollars = "Eighty-Two Thousand "
            Case "83"
                strDollars = "Eighty-Three Thousand "
            Case "84"
                strDollars = "Eighty-Four Thousand "
            Case "85"
                strDollars = "Eighty-Five Thousand "
            Case "86"
                strDollars = "Eighty-Six Thousand "
            Case "87"
                strDollars = "Eighty-Seven Thousand "
            Case "88"
                strDollars = "Eighty-Eight Thousand "
            Case "89"
                strDollars = "Eighty-Nine Thousand "
            Case "90"
                strDollars = "Ninety Thousand "
            Case "91"
                strDollars = "Ninety-One Thousand "
            Case "92"
                strDollars = "Ninety-Two Thousand "
            Case "93"
                strDollars = "Ninety-Three Thousand "
            Case "94"
                strDollars = "Ninety-Four Thousand "
            Case "95"
                strDollars = "Ninety-Five Thousand "
            Case "96"
                strDollars = "Ninety-Six Thousand "
            Case "97"
                strDollars = "Ninety-Seven Thousand "
            Case "98"
                strDollars = "Ninety-Eight Thousand "
            Case "99"
                strDollars = "Ninety-Nine Thousand "
        End Select

        Return strDollars

    End Function


    Private Function Get100ThousandsOfDollars(ByVal cd As Char, ByVal evenMoney As Boolean)

        Dim strDollars As String = ""

        Select Case cd
            Case "1"
                If evenMoney = True Then
                    strDollars = "One Hundred Thousand "
                Else
                    strDollars = "One Hundred "
                End If
            Case "2"
                If evenMoney = True Then
                    strDollars = strDollars = "Two Hundred Thousand "
                Else
                    strDollars = "Two Hundred "
                End If
            Case "3"
                If evenMoney = True Then
                    strDollars = "Three Hundred Thousand "
                Else
                    strDollars = "Three Hundred "
                End If
            Case "4"
                If evenMoney = True Then
                    strDollars = "Four Hundred Thousand "
                Else
                    strDollars = "Four Hundred "
                End If
            Case "5"
                If evenMoney = True Then
                    strDollars = "Five Hundred Thousand "
                Else
                    strDollars = "Five Hundred "
                End If
            Case "6"
                If evenMoney = True Then
                    strDollars = "Six Hundred Thousand "
                Else
                    strDollars = "Six Hundred "
                End If
            Case "7"
                If evenMoney = True Then
                    strDollars = "Seven Hundred Thousand "
                Else
                    strDollars = "Seven Hundred "
                End If
            Case "8"
                If evenMoney = True Then
                    strDollars = "Eight Hundred Thousand "
                Else
                    strDollars = "Eight Hundred "
                End If
            Case "9"
                If evenMoney = True Then
                    strDollars = "Nine Hundred Thousand "
                Else
                    strDollars = "Nine Hundred "
                End If
            Case "0"
                strDollars = ""
        End Select


        Return strDollars

    End Function



    Private Function GetMillionsOfDollars(ByVal cd As String)

        Dim strDollars As String = ""

        Select Case cd
            Case "0"
                strDollars = ""
            Case "1"
                strDollars = "One Million "
            Case "2"
                strDollars = "Two Million "
            Case "3"
                strDollars = "Three Million "
            Case "4"
                strDollars = "Four Million "
            Case "5"
                strDollars = "Five Million "
            Case "6"
                strDollars = "Six Million "
            Case "7"
                strDollars = "Seven Million "
            Case "8"
                strDollars = "Eight Million "
            Case "9"
                strDollars = "Nine Million "
        End Select

        Return strDollars

    End Function



End Module
