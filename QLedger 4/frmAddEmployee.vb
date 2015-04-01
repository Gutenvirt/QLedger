Public Class frmAddEmployee


    Private Sub cmdAddWorker_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddWorker.Click
        txtSSN.Text = txtSSN.Text.Replace("-", "")
        txtCity.Text = txtCity.Text.Replace(" ", "_")

        If lstMaritalStatus.Text = "" Then
            lstMaritalStatus.Text = "SINGLE"
        End If

        If txtSSN.Text.Length <> 9 Then
            Randomize()
            txtSSN.Text = "NOSSN" & Int(Rnd() * 10) & Int(Rnd() * 10) & Int(Rnd() * 10) & Int(Rnd() * 10)
        End If

        If txtName.Text.IndexOf(" ") = -1 Then
            MsgBox("Please go back and enter a last name")
            Exit Sub
        End If

        Dim employeeData As String

        employeeData = txtName.Text & "," & txtStreetAddress.Text & "," & txtCity.Text & " FL " & txtZipCode.Text & "," & txtSSN.Text.Replace("-", "") & "," & txtPayRate.Text & "," & lstMaritalStatus.Text & "," & txtExemptions.Text & ",##CHECKS##"
        WriteEmployeeData(employeeData.Split(","))

        employeeData = ""
        Me.Close()

    End Sub

    Public Sub WriteEmployeeData(ByVal employeeString() As String)
        freefile = FileSystem.FreeFile
        Try
            FileSystem.Kill(path & "employees\" & txtOldSSN.Text.Replace("-", "") & ".wrk")
        Catch e As Exception

        End Try

        FileSystem.FileOpen(freefile, path & "employees\" & txtSSN.Text.Replace("-", "") & ".wrk", OpenMode.Output, OpenAccess.Write)

        For Each sVar As String In employeeString
            FileSystem.PrintLine(freefile, sVar.ToUpper)
        Next

        For sA As Integer = 9 To CurrentEmployee.Count
            FileSystem.PrintLine(freefile, CurrentEmployee(sA).ToString)
        Next
        FileSystem.FileClose()
        frmMain.FindEmployees()

    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub txtSSN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSSN.TextChanged
        If txtSSN.Text.EndsWith(" ") = True Then
            txtSSN.Select(txtSSN.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub pbEmployee_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pbEmployee.Paint
        With e.Graphics
            'column 1
            .DrawRectangle(sPen, 10, 10, 175, 50)
            .DrawRectangle(sPen, 10, 60, 175, 100)
            '.DrawRectangle(sPen, 10, 110, 175, 50)

            .DrawRectangle(sPen, 460, 110, 125, 50)

            .DrawRectangle(sPen, 10, 160, 175, 50)
            .DrawRectangle(sPen, 10, 210, 175, 50)
            .DrawRectangle(sPen, 10, 260, 175, 50)
            .DrawRectangle(sPen, 10, 310, 175, 50)

            'column 2
            .DrawRectangle(sPen, 185, 10, 400, 50)
            .DrawRectangle(sPen, 185, 60, 400, 50)
            .DrawRectangle(sPen, 185, 110, 400, 50)

            .DrawRectangle(sPen, 185, 160, 200, 50)
            .DrawRectangle(sPen, 185, 210, 200, 50)
            .DrawRectangle(sPen, 185, 260, 200, 50)
            .DrawRectangle(sPen, 185, 310, 200, 50)

            'text
            .DrawString("NAME   :", sFont, sBrush, 20, 20)
            .DrawString("FLORIDA", sFont, sBrush, 20, 80)
            .DrawString("ADDRESS:", sFont, sBrush, 20, 110)

            .DrawString("SSN    :", sFont, sBrush, 20, 170)
            .DrawString("CLAIMS :", sFont, sBrush, 20, 220)
            .DrawString("PAYRATE:", sFont, sBrush, 20, 270)
            .DrawString("STATUS :", sFont, sBrush, 20, 320)

        End With
    End Sub

    Private Sub frmAddEmployee_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtCity.Font = sFont
        txtExemptions.Font = sFont
        txtName.Font = sFont
        txtPayRate.Font = sFont
        txtSSN.Font = sFont
        txtStreetAddress.Font = sFont
        txtZipCode.Font = sFont

        If My.Computer.FileSystem.DirectoryExists(path & "employees\") = False Then
            My.Computer.FileSystem.CreateDirectory(path & "employees\")
        End If

    End Sub

    Private Sub txtName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtName.TextChanged
        If txtName.Text.IndexOf(",") > 0 Then
            MsgBox("Please re-enter the name (FIRST LAST)")
        End If
    End Sub
End Class