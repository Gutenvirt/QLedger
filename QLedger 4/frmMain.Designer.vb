<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lsbEmployees = New System.Windows.Forms.ListBox
        Me.lsvChecks = New System.Windows.Forms.ListView
        Me.clmDate = New System.Windows.Forms.ColumnHeader
        Me.clmGross = New System.Windows.Forms.ColumnHeader
        Me.clmFedIncome = New System.Windows.Forms.ColumnHeader
        Me.clmSocialSecurity = New System.Windows.Forms.ColumnHeader
        Me.clmMedicare = New System.Windows.Forms.ColumnHeader
        Me.clmNet = New System.Windows.Forms.ColumnHeader
        Me.txtHours = New System.Windows.Forms.TextBox
        Me.txtPayRate = New System.Windows.Forms.TextBox
        Me.CheckDocument = New System.Drawing.Printing.PrintDocument
        Me.HistoryDocument = New System.Drawing.Printing.PrintDocument
        Me.txtDeductionAmount = New System.Windows.Forms.TextBox
        Me.txtDeduction = New System.Windows.Forms.TextBox
        Me.msMain = New System.Windows.Forms.MenuStrip
        Me.tsFile = New System.Windows.Forms.ToolStripMenuItem
        Me.BackupEmployeeDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.tsExit = New System.Windows.Forms.ToolStripMenuItem
        Me.tsEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.tsAddEmployee = New System.Windows.Forms.ToolStripMenuItem
        Me.tsDeleteEmployee = New System.Windows.Forms.ToolStripMenuItem
        Me.tsChangeEmployeeData = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsDeleteCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.tsView = New System.Windows.Forms.ToolStripMenuItem
        Me.ShowPaymentHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tsSortFirstName = New System.Windows.Forms.ToolStripMenuItem
        Me.tsSortLastName = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.ApplyFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.cmbMonth = New System.Windows.Forms.ToolStripComboBox
        Me.SetYearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tsSet2008 = New System.Windows.Forms.ToolStripMenuItem
        Me.tsSet2009 = New System.Windows.Forms.ToolStripMenuItem
        Me.tsSet2010 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.tsShowCalculator = New System.Windows.Forms.ToolStripMenuItem
        Me.tsCalender = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.tsShowCheckWriter = New System.Windows.Forms.ToolStripMenuItem
        Me.PayrollToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.tsRunSingle = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.tsPrintCheck = New System.Windows.Forms.ToolStripMenuItem
        Me.tsPrintHistory = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator
        Me.tsAddMemo = New System.Windows.Forms.ToolStripMenuItem
        Me.tsInformation = New System.Windows.Forms.ToolStripMenuItem
        Me.lsvTotals = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.PrintDialog = New System.Windows.Forms.PrintDialog
        Me.cmdPrintHistory = New System.Windows.Forms.Button
        Me.pbInformation = New System.Windows.Forms.PictureBox
        Me.cmdPrintCheck = New System.Windows.Forms.Button
        Me.cmdPayroll = New System.Windows.Forms.Button
        Me.pbCurrent = New System.Windows.Forms.PictureBox
        Me.msMain.SuspendLayout()
        CType(Me.pbInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCurrent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lsbEmployees
        '
        Me.lsbEmployees.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsbEmployees.FormattingEnabled = True
        Me.lsbEmployees.ItemHeight = 21
        Me.lsbEmployees.Location = New System.Drawing.Point(12, 40)
        Me.lsbEmployees.Name = "lsbEmployees"
        Me.lsbEmployees.Size = New System.Drawing.Size(213, 697)
        Me.lsbEmployees.Sorted = True
        Me.lsbEmployees.TabIndex = 0
        '
        'lsvChecks
        '
        Me.lsvChecks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lsvChecks.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmDate, Me.clmGross, Me.clmFedIncome, Me.clmSocialSecurity, Me.clmMedicare, Me.clmNet})
        Me.lsvChecks.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvChecks.GridLines = True
        Me.lsvChecks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lsvChecks.LabelWrap = False
        Me.lsvChecks.Location = New System.Drawing.Point(231, 488)
        Me.lsvChecks.MultiSelect = False
        Me.lsvChecks.Name = "lsvChecks"
        Me.lsvChecks.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lsvChecks.Size = New System.Drawing.Size(754, 225)
        Me.lsvChecks.TabIndex = 2
        Me.lsvChecks.UseCompatibleStateImageBehavior = False
        Me.lsvChecks.View = System.Windows.Forms.View.Details
        '
        'clmDate
        '
        Me.clmDate.Text = "DATE"
        Me.clmDate.Width = 125
        '
        'clmGross
        '
        Me.clmGross.Text = "GROSS PAY"
        Me.clmGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.clmGross.Width = 125
        '
        'clmFedIncome
        '
        Me.clmFedIncome.Text = "FED INCOME"
        Me.clmFedIncome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.clmFedIncome.Width = 125
        '
        'clmSocialSecurity
        '
        Me.clmSocialSecurity.Text = "SOC SEC"
        Me.clmSocialSecurity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.clmSocialSecurity.Width = 125
        '
        'clmMedicare
        '
        Me.clmMedicare.Text = "MEDICARE"
        Me.clmMedicare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.clmMedicare.Width = 126
        '
        'clmNet
        '
        Me.clmNet.Text = "NET PAY"
        Me.clmNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.clmNet.Width = 127
        '
        'txtHours
        '
        Me.txtHours.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHours.Font = New System.Drawing.Font("Courier New", 21.75!)
        Me.txtHours.Location = New System.Drawing.Point(825, 232)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtHours.Size = New System.Drawing.Size(112, 33)
        Me.txtHours.TabIndex = 55
        Me.txtHours.Text = "0.00"
        Me.txtHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPayRate
        '
        Me.txtPayRate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPayRate.Font = New System.Drawing.Font("Courier New", 21.75!)
        Me.txtPayRate.Location = New System.Drawing.Point(647, 232)
        Me.txtPayRate.Name = "txtPayRate"
        Me.txtPayRate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPayRate.Size = New System.Drawing.Size(115, 33)
        Me.txtPayRate.TabIndex = 56
        Me.txtPayRate.Text = "0.00"
        Me.txtPayRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CheckDocument
        '
        '
        'HistoryDocument
        '
        '
        'txtDeductionAmount
        '
        Me.txtDeductionAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDeductionAmount.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeductionAmount.Location = New System.Drawing.Point(813, 373)
        Me.txtDeductionAmount.Name = "txtDeductionAmount"
        Me.txtDeductionAmount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDeductionAmount.Size = New System.Drawing.Size(124, 33)
        Me.txtDeductionAmount.TabIndex = 77
        Me.txtDeductionAmount.Text = "0.00"
        Me.txtDeductionAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDeduction
        '
        Me.txtDeduction.AutoCompleteCustomSource.AddRange(New String() {"Uniform", "Advance", "Other", "Equipment", "Supplies", "Gas", "Damages", "Personal", "Special", "Cash Adv"})
        Me.txtDeduction.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtDeduction.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtDeduction.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDeduction.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeduction.Location = New System.Drawing.Point(632, 373)
        Me.txtDeduction.Name = "txtDeduction"
        Me.txtDeduction.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDeduction.Size = New System.Drawing.Size(164, 33)
        Me.txtDeduction.TabIndex = 76
        Me.txtDeduction.Text = "DEDUCTION"
        '
        'msMain
        '
        Me.msMain.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsFile, Me.tsEdit, Me.tsView, Me.PayrollToolStripMenuItem, Me.tsInformation})
        Me.msMain.Location = New System.Drawing.Point(0, 0)
        Me.msMain.Name = "msMain"
        Me.msMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.msMain.Size = New System.Drawing.Size(997, 29)
        Me.msMain.TabIndex = 93
        '
        'tsFile
        '
        Me.tsFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackupEmployeeDataToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem6, Me.ToolStripSeparator6, Me.tsExit})
        Me.tsFile.Name = "tsFile"
        Me.tsFile.Size = New System.Drawing.Size(46, 25)
        Me.tsFile.Text = "File"
        '
        'BackupEmployeeDataToolStripMenuItem
        '
        Me.BackupEmployeeDataToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackupEmployeeDataToolStripMenuItem.Image = CType(resources.GetObject("BackupEmployeeDataToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BackupEmployeeDataToolStripMenuItem.Name = "BackupEmployeeDataToolStripMenuItem"
        Me.BackupEmployeeDataToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.BackupEmployeeDataToolStripMenuItem.Text = "Create Backup"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(186, 6)
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Enabled = False
        Me.ToolStripMenuItem6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem6.Image = CType(resources.GetObject("ToolStripMenuItem6.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(189, 26)
        Me.ToolStripMenuItem6.Text = "Print Setup"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(186, 6)
        '
        'tsExit
        '
        Me.tsExit.Image = CType(resources.GetObject("tsExit.Image"), System.Drawing.Image)
        Me.tsExit.Name = "tsExit"
        Me.tsExit.Size = New System.Drawing.Size(189, 26)
        Me.tsExit.Text = "Exit"
        '
        'tsEdit
        '
        Me.tsEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsAddEmployee, Me.tsDeleteEmployee, Me.tsChangeEmployeeData, Me.ToolStripMenuItem2, Me.tsDeleteCheck})
        Me.tsEdit.Name = "tsEdit"
        Me.tsEdit.Size = New System.Drawing.Size(48, 25)
        Me.tsEdit.Text = "Edit"
        '
        'tsAddEmployee
        '
        Me.tsAddEmployee.Image = CType(resources.GetObject("tsAddEmployee.Image"), System.Drawing.Image)
        Me.tsAddEmployee.Name = "tsAddEmployee"
        Me.tsAddEmployee.Size = New System.Drawing.Size(301, 26)
        Me.tsAddEmployee.Text = "Add New Empmloyee"
        '
        'tsDeleteEmployee
        '
        Me.tsDeleteEmployee.Image = CType(resources.GetObject("tsDeleteEmployee.Image"), System.Drawing.Image)
        Me.tsDeleteEmployee.Name = "tsDeleteEmployee"
        Me.tsDeleteEmployee.Size = New System.Drawing.Size(301, 26)
        Me.tsDeleteEmployee.Text = "Delete Employee"
        '
        'tsChangeEmployeeData
        '
        Me.tsChangeEmployeeData.Image = CType(resources.GetObject("tsChangeEmployeeData.Image"), System.Drawing.Image)
        Me.tsChangeEmployeeData.Name = "tsChangeEmployeeData"
        Me.tsChangeEmployeeData.Size = New System.Drawing.Size(301, 26)
        Me.tsChangeEmployeeData.Text = "Change Employee Information"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(298, 6)
        '
        'tsDeleteCheck
        '
        Me.tsDeleteCheck.Enabled = False
        Me.tsDeleteCheck.Image = CType(resources.GetObject("tsDeleteCheck.Image"), System.Drawing.Image)
        Me.tsDeleteCheck.Name = "tsDeleteCheck"
        Me.tsDeleteCheck.Size = New System.Drawing.Size(301, 26)
        Me.tsDeleteCheck.Text = "Delete Check"
        '
        'tsView
        '
        Me.tsView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowPaymentHistoryToolStripMenuItem, Me.ToolStripSeparator8, Me.ApplyFilterToolStripMenuItem, Me.SetYearToolStripMenuItem, Me.ToolStripMenuItem3, Me.tsShowCalculator, Me.tsCalender, Me.ToolStripMenuItem4, Me.tsShowCheckWriter})
        Me.tsView.Name = "tsView"
        Me.tsView.Size = New System.Drawing.Size(56, 25)
        Me.tsView.Text = "View"
        '
        'ShowPaymentHistoryToolStripMenuItem
        '
        Me.ShowPaymentHistoryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSortFirstName, Me.tsSortLastName})
        Me.ShowPaymentHistoryToolStripMenuItem.Name = "ShowPaymentHistoryToolStripMenuItem"
        Me.ShowPaymentHistoryToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.ShowPaymentHistoryToolStripMenuItem.Text = "Sort Names"
        '
        'tsSortFirstName
        '
        Me.tsSortFirstName.Name = "tsSortFirstName"
        Me.tsSortFirstName.Size = New System.Drawing.Size(166, 26)
        Me.tsSortFirstName.Text = "First Name"
        '
        'tsSortLastName
        '
        Me.tsSortLastName.Checked = True
        Me.tsSortLastName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tsSortLastName.Name = "tsSortLastName"
        Me.tsSortLastName.Size = New System.Drawing.Size(166, 26)
        Me.tsSortLastName.Text = "Last Name"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(177, 6)
        '
        'ApplyFilterToolStripMenuItem
        '
        Me.ApplyFilterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmbMonth})
        Me.ApplyFilterToolStripMenuItem.Name = "ApplyFilterToolStripMenuItem"
        Me.ApplyFilterToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.ApplyFilterToolStripMenuItem.Text = "Apply Filter"
        '
        'cmbMonth
        '
        Me.cmbMonth.Items.AddRange(New Object() {"ALL YEAR", "----------------", "JANUARY", "FEBRUARY", "MARCH", "APRIL", "MAY", "JUNE", "JULY", "AUGUST", "SEPTEMBER", "OCTOBER", "NOVEMBER", "DECEMBER", "----------------", "1ST QUARTER", "2ND QUARTER", "3RD QUARTER", "4TH QUARTER"})
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(152, 21)
        Me.cmbMonth.Text = "Show All"
        '
        'SetYearToolStripMenuItem
        '
        Me.SetYearToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsSet2008, Me.tsSet2009, Me.tsSet2010})
        Me.SetYearToolStripMenuItem.Name = "SetYearToolStripMenuItem"
        Me.SetYearToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.SetYearToolStripMenuItem.Text = "Set Year"
        '
        'tsSet2008
        '
        Me.tsSet2008.Name = "tsSet2008"
        Me.tsSet2008.Size = New System.Drawing.Size(152, 26)
        Me.tsSet2008.Text = "2008"
        '
        'tsSet2009
        '
        Me.tsSet2009.Name = "tsSet2009"
        Me.tsSet2009.Size = New System.Drawing.Size(152, 26)
        Me.tsSet2009.Text = "2009"
        '
        'tsSet2010
        '
        Me.tsSet2010.Checked = True
        Me.tsSet2010.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tsSet2010.Name = "tsSet2010"
        Me.tsSet2010.Size = New System.Drawing.Size(152, 26)
        Me.tsSet2010.Text = "2010"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(177, 6)
        '
        'tsShowCalculator
        '
        Me.tsShowCalculator.Image = CType(resources.GetObject("tsShowCalculator.Image"), System.Drawing.Image)
        Me.tsShowCalculator.Name = "tsShowCalculator"
        Me.tsShowCalculator.Size = New System.Drawing.Size(180, 26)
        Me.tsShowCalculator.Text = "Calculator"
        '
        'tsCalender
        '
        Me.tsCalender.Image = CType(resources.GetObject("tsCalender.Image"), System.Drawing.Image)
        Me.tsCalender.Name = "tsCalender"
        Me.tsCalender.Size = New System.Drawing.Size(180, 26)
        Me.tsCalender.Text = "Calender"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(177, 6)
        '
        'tsShowCheckWriter
        '
        Me.tsShowCheckWriter.Image = CType(resources.GetObject("tsShowCheckWriter.Image"), System.Drawing.Image)
        Me.tsShowCheckWriter.Name = "tsShowCheckWriter"
        Me.tsShowCheckWriter.Size = New System.Drawing.Size(180, 26)
        Me.tsShowCheckWriter.Text = "Check Writer"
        '
        'PayrollToolStripMenuItem
        '
        Me.PayrollToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsRunSingle, Me.ToolStripMenuItem7, Me.ToolStripSeparator7, Me.tsPrintCheck, Me.tsPrintHistory, Me.ToolStripMenuItem5, Me.tsAddMemo})
        Me.PayrollToolStripMenuItem.Name = "PayrollToolStripMenuItem"
        Me.PayrollToolStripMenuItem.Size = New System.Drawing.Size(70, 25)
        Me.PayrollToolStripMenuItem.Text = "Payroll"
        '
        'tsRunSingle
        '
        Me.tsRunSingle.Image = CType(resources.GetObject("tsRunSingle.Image"), System.Drawing.Image)
        Me.tsRunSingle.Name = "tsRunSingle"
        Me.tsRunSingle.Size = New System.Drawing.Size(213, 26)
        Me.tsRunSingle.Text = "Run Single"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Enabled = False
        Me.ToolStripMenuItem7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem7.Image = CType(resources.GetObject("ToolStripMenuItem7.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(213, 26)
        Me.ToolStripMenuItem7.Text = "Run Multiple"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(210, 6)
        '
        'tsPrintCheck
        '
        Me.tsPrintCheck.Image = CType(resources.GetObject("tsPrintCheck.Image"), System.Drawing.Image)
        Me.tsPrintCheck.Name = "tsPrintCheck"
        Me.tsPrintCheck.Size = New System.Drawing.Size(213, 26)
        Me.tsPrintCheck.Text = "Print Paycheck"
        '
        'tsPrintHistory
        '
        Me.tsPrintHistory.Image = CType(resources.GetObject("tsPrintHistory.Image"), System.Drawing.Image)
        Me.tsPrintHistory.Name = "tsPrintHistory"
        Me.tsPrintHistory.Size = New System.Drawing.Size(213, 26)
        Me.tsPrintHistory.Text = "Print History"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(210, 6)
        '
        'tsAddMemo
        '
        Me.tsAddMemo.Image = CType(resources.GetObject("tsAddMemo.Image"), System.Drawing.Image)
        Me.tsAddMemo.Name = "tsAddMemo"
        Me.tsAddMemo.Size = New System.Drawing.Size(213, 26)
        Me.tsAddMemo.Text = "Add Check Memo"
        '
        'tsInformation
        '
        Me.tsInformation.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsInformation.Image = CType(resources.GetObject("tsInformation.Image"), System.Drawing.Image)
        Me.tsInformation.Name = "tsInformation"
        Me.tsInformation.Size = New System.Drawing.Size(28, 25)
        '
        'lsvTotals
        '
        Me.lsvTotals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lsvTotals.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lsvTotals.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvTotals.GridLines = True
        Me.lsvTotals.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lsvTotals.LabelWrap = False
        Me.lsvTotals.Location = New System.Drawing.Point(231, 712)
        Me.lsvTotals.MultiSelect = False
        Me.lsvTotals.Name = "lsvTotals"
        Me.lsvTotals.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lsvTotals.Size = New System.Drawing.Size(754, 25)
        Me.lsvTotals.TabIndex = 96
        Me.lsvTotals.UseCompatibleStateImageBehavior = False
        Me.lsvTotals.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "DATE"
        Me.ColumnHeader1.Width = 125
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "GROSS PAY"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 125
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "FED INCOME"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader3.Width = 125
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "SOC SEC"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader4.Width = 125
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "MEDICARE"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 126
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "NET PAY"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader6.Width = 127
        '
        'PrintDialog
        '
        Me.PrintDialog.Document = Me.CheckDocument
        Me.PrintDialog.UseEXDialog = True
        '
        'cmdPrintHistory
        '
        Me.cmdPrintHistory.BackColor = System.Drawing.Color.White
        Me.cmdPrintHistory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdPrintHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdPrintHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdPrintHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPrintHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrintHistory.Image = CType(resources.GetObject("cmdPrintHistory.Image"), System.Drawing.Image)
        Me.cmdPrintHistory.Location = New System.Drawing.Point(929, 430)
        Me.cmdPrintHistory.Name = "cmdPrintHistory"
        Me.cmdPrintHistory.Size = New System.Drawing.Size(45, 45)
        Me.cmdPrintHistory.TabIndex = 94
        Me.cmdPrintHistory.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdPrintHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdPrintHistory.UseVisualStyleBackColor = False
        '
        'pbInformation
        '
        Me.pbInformation.BackColor = System.Drawing.Color.White
        Me.pbInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbInformation.Location = New System.Drawing.Point(231, 40)
        Me.pbInformation.Name = "pbInformation"
        Me.pbInformation.Size = New System.Drawing.Size(754, 123)
        Me.pbInformation.TabIndex = 3
        Me.pbInformation.TabStop = False
        '
        'cmdPrintCheck
        '
        Me.cmdPrintCheck.BackColor = System.Drawing.Color.White
        Me.cmdPrintCheck.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdPrintCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdPrintCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdPrintCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPrintCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrintCheck.Image = CType(resources.GetObject("cmdPrintCheck.Image"), System.Drawing.Image)
        Me.cmdPrintCheck.Location = New System.Drawing.Point(878, 430)
        Me.cmdPrintCheck.Name = "cmdPrintCheck"
        Me.cmdPrintCheck.Size = New System.Drawing.Size(45, 45)
        Me.cmdPrintCheck.TabIndex = 59
        Me.cmdPrintCheck.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdPrintCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdPrintCheck.UseVisualStyleBackColor = False
        '
        'cmdPayroll
        '
        Me.cmdPayroll.BackColor = System.Drawing.Color.White
        Me.cmdPayroll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdPayroll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdPayroll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdPayroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPayroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPayroll.Image = CType(resources.GetObject("cmdPayroll.Image"), System.Drawing.Image)
        Me.cmdPayroll.Location = New System.Drawing.Point(827, 430)
        Me.cmdPayroll.Name = "cmdPayroll"
        Me.cmdPayroll.Size = New System.Drawing.Size(45, 45)
        Me.cmdPayroll.TabIndex = 57
        Me.cmdPayroll.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdPayroll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdPayroll.UseVisualStyleBackColor = False
        '
        'pbCurrent
        '
        Me.pbCurrent.BackColor = System.Drawing.Color.White
        Me.pbCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbCurrent.Location = New System.Drawing.Point(231, 162)
        Me.pbCurrent.Name = "pbCurrent"
        Me.pbCurrent.Size = New System.Drawing.Size(754, 323)
        Me.pbCurrent.TabIndex = 63
        Me.pbCurrent.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 751)
        Me.Controls.Add(Me.lsvTotals)
        Me.Controls.Add(Me.cmdPrintHistory)
        Me.Controls.Add(Me.msMain)
        Me.Controls.Add(Me.pbInformation)
        Me.Controls.Add(Me.lsbEmployees)
        Me.Controls.Add(Me.lsvChecks)
        Me.Controls.Add(Me.txtDeductionAmount)
        Me.Controls.Add(Me.txtDeduction)
        Me.Controls.Add(Me.txtPayRate)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.cmdPrintCheck)
        Me.Controls.Add(Me.cmdPayroll)
        Me.Controls.Add(Me.pbCurrent)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(25, 25)
        Me.MainMenuStrip = Me.msMain
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "QLedger"
        Me.msMain.ResumeLayout(False)
        Me.msMain.PerformLayout()
        CType(Me.pbInformation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCurrent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lsbEmployees As System.Windows.Forms.ListBox
    Friend WithEvents lsvChecks As System.Windows.Forms.ListView
    Friend WithEvents clmDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmGross As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmFedIncome As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmSocialSecurity As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmMedicare As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmNet As System.Windows.Forms.ColumnHeader
    Friend WithEvents pbInformation As System.Windows.Forms.PictureBox
    Friend WithEvents txtHours As System.Windows.Forms.TextBox
    Friend WithEvents txtPayRate As System.Windows.Forms.TextBox
    Friend WithEvents cmdPayroll As System.Windows.Forms.Button
    Friend WithEvents cmdPrintCheck As System.Windows.Forms.Button
    Friend WithEvents pbCurrent As System.Windows.Forms.PictureBox
    Friend WithEvents CheckDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents HistoryDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents txtDeductionAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtDeduction As System.Windows.Forms.TextBox
    Friend WithEvents msMain As System.Windows.Forms.MenuStrip
    Friend WithEvents tsFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackupEmployeeDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsChangeEmployeeData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsDeleteEmployee As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsAddEmployee As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsDeleteCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowPaymentHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApplyFilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsShowCalculator As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsCalender As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsShowCheckWriter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PayrollToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsRunSingle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsPrintCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsPrintHistory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsSortFirstName As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsSortLastName As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbMonth As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsAddMemo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdPrintHistory As System.Windows.Forms.Button
    Friend WithEvents lsvTotals As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents PrintDialog As System.Windows.Forms.PrintDialog
    Friend WithEvents tsInformation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetYearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsSet2008 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsSet2009 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsSet2010 As System.Windows.Forms.ToolStripMenuItem

End Class
