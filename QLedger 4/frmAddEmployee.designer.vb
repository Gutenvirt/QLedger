<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEmployee))
        Me.txtExemptions = New System.Windows.Forms.TextBox
        Me.txtPayRate = New System.Windows.Forms.TextBox
        Me.txtSSN = New System.Windows.Forms.TextBox
        Me.txtZipCode = New System.Windows.Forms.TextBox
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.txtStreetAddress = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.lstMaritalStatus = New System.Windows.Forms.ComboBox
        Me.txtOldSSN = New System.Windows.Forms.TextBox
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdAddWorker = New System.Windows.Forms.Button
        Me.pbEmployee = New System.Windows.Forms.PictureBox
        CType(Me.pbEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtExemptions
        '
        Me.txtExemptions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtExemptions.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExemptions.Location = New System.Drawing.Point(195, 220)
        Me.txtExemptions.Name = "txtExemptions"
        Me.txtExemptions.Size = New System.Drawing.Size(100, 33)
        Me.txtExemptions.TabIndex = 15
        Me.txtExemptions.Text = "0"
        '
        'txtPayRate
        '
        Me.txtPayRate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPayRate.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayRate.Location = New System.Drawing.Point(195, 270)
        Me.txtPayRate.Name = "txtPayRate"
        Me.txtPayRate.Size = New System.Drawing.Size(100, 33)
        Me.txtPayRate.TabIndex = 16
        Me.txtPayRate.Text = "7.00"
        '
        'txtSSN
        '
        Me.txtSSN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSSN.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSSN.Location = New System.Drawing.Point(195, 170)
        Me.txtSSN.MaxLength = 11
        Me.txtSSN.Name = "txtSSN"
        Me.txtSSN.Size = New System.Drawing.Size(153, 33)
        Me.txtSSN.TabIndex = 14
        '
        'txtZipCode
        '
        Me.txtZipCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtZipCode.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZipCode.Location = New System.Drawing.Point(478, 119)
        Me.txtZipCode.MaxLength = 5
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(100, 33)
        Me.txtZipCode.TabIndex = 13
        '
        'txtCity
        '
        Me.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCity.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(195, 120)
        Me.txtCity.MaxLength = 14
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(262, 33)
        Me.txtCity.TabIndex = 12
        '
        'txtStreetAddress
        '
        Me.txtStreetAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStreetAddress.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStreetAddress.Location = New System.Drawing.Point(195, 70)
        Me.txtStreetAddress.MaxLength = 22
        Me.txtStreetAddress.Name = "txtStreetAddress"
        Me.txtStreetAddress.Size = New System.Drawing.Size(383, 33)
        Me.txtStreetAddress.TabIndex = 11
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(195, 20)
        Me.txtName.MaxLength = 22
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(383, 33)
        Me.txtName.TabIndex = 10
        '
        'lstMaritalStatus
        '
        Me.lstMaritalStatus.AutoCompleteCustomSource.AddRange(New String() {"SINGLE", "MARRIED"})
        Me.lstMaritalStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.lstMaritalStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.lstMaritalStatus.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lstMaritalStatus.Font = New System.Drawing.Font("Courier New", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMaritalStatus.FormattingEnabled = True
        Me.lstMaritalStatus.Items.AddRange(New Object() {"SINGLE", "MARRIED"})
        Me.lstMaritalStatus.Location = New System.Drawing.Point(195, 317)
        Me.lstMaritalStatus.Name = "lstMaritalStatus"
        Me.lstMaritalStatus.Size = New System.Drawing.Size(153, 40)
        Me.lstMaritalStatus.TabIndex = 17
        Me.lstMaritalStatus.Text = "SINGLE"
        '
        'txtOldSSN
        '
        Me.txtOldSSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldSSN.Location = New System.Drawing.Point(367, 172)
        Me.txtOldSSN.Name = "txtOldSSN"
        Me.txtOldSSN.Size = New System.Drawing.Size(100, 31)
        Me.txtOldSSN.TabIndex = 30
        Me.txtOldSSN.Visible = False
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.Color.White
        Me.cmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Image = CType(resources.GetObject("cmdCancel.Image"), System.Drawing.Image)
        Me.cmdCancel.Location = New System.Drawing.Point(539, 313)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(45, 45)
        Me.cmdCancel.TabIndex = 19
        Me.cmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdAddWorker
        '
        Me.cmdAddWorker.BackColor = System.Drawing.Color.White
        Me.cmdAddWorker.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdAddWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAddWorker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddWorker.Image = CType(resources.GetObject("cmdAddWorker.Image"), System.Drawing.Image)
        Me.cmdAddWorker.Location = New System.Drawing.Point(539, 258)
        Me.cmdAddWorker.Name = "cmdAddWorker"
        Me.cmdAddWorker.Size = New System.Drawing.Size(45, 45)
        Me.cmdAddWorker.TabIndex = 18
        Me.cmdAddWorker.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdAddWorker.UseVisualStyleBackColor = False
        '
        'pbEmployee
        '
        Me.pbEmployee.BackColor = System.Drawing.Color.White
        Me.pbEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbEmployee.Location = New System.Drawing.Point(0, 0)
        Me.pbEmployee.Name = "pbEmployee"
        Me.pbEmployee.Size = New System.Drawing.Size(606, 376)
        Me.pbEmployee.TabIndex = 31
        Me.pbEmployee.TabStop = False
        '
        'frmAddEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 370)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtOldSSN)
        Me.Controls.Add(Me.lstMaritalStatus)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdAddWorker)
        Me.Controls.Add(Me.txtExemptions)
        Me.Controls.Add(Me.txtPayRate)
        Me.Controls.Add(Me.txtSSN)
        Me.Controls.Add(Me.txtZipCode)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtStreetAddress)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.pbEmployee)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmAddEmployee"
        Me.Text = "EMPLOYEE INFORMATION"
        CType(Me.pbEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdAddWorker As System.Windows.Forms.Button
    Friend WithEvents txtExemptions As System.Windows.Forms.TextBox
    Friend WithEvents txtPayRate As System.Windows.Forms.TextBox
    Friend WithEvents txtSSN As System.Windows.Forms.TextBox
    Friend WithEvents txtZipCode As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtStreetAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lstMaritalStatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtOldSSN As System.Windows.Forms.TextBox
    Friend WithEvents pbEmployee As System.Windows.Forms.PictureBox
End Class
