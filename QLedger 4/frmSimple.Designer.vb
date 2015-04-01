<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSimple
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSimple))
        Me.lblPayrate = New System.Windows.Forms.Label
        Me.lblHours = New System.Windows.Forms.Label
        Me.txtPayRate = New System.Windows.Forms.TextBox
        Me.txtHours = New System.Windows.Forms.TextBox
        Me.cmbStatus = New System.Windows.Forms.ComboBox
        Me.lblExemptions = New System.Windows.Forms.Label
        Me.txtExemptions = New System.Windows.Forms.TextBox
        Me.lblStatus = New System.Windows.Forms.Label
        Me.pbSimple = New System.Windows.Forms.PictureBox
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdPayroll = New System.Windows.Forms.Button
        CType(Me.pbSimple, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPayrate
        '
        Me.lblPayrate.AutoSize = True
        Me.lblPayrate.BackColor = System.Drawing.Color.White
        Me.lblPayrate.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayrate.Location = New System.Drawing.Point(48, 25)
        Me.lblPayrate.Name = "lblPayrate"
        Me.lblPayrate.Size = New System.Drawing.Size(98, 21)
        Me.lblPayrate.TabIndex = 65
        Me.lblPayrate.Text = "Payrate:"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.BackColor = System.Drawing.Color.White
        Me.lblHours.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHours.Location = New System.Drawing.Point(70, 57)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(76, 21)
        Me.lblHours.TabIndex = 64
        Me.lblHours.Text = "Hours:"
        '
        'txtPayRate
        '
        Me.txtPayRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPayRate.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPayRate.Location = New System.Drawing.Point(166, 23)
        Me.txtPayRate.Name = "txtPayRate"
        Me.txtPayRate.Size = New System.Drawing.Size(100, 29)
        Me.txtPayRate.TabIndex = 63
        Me.txtPayRate.Text = "7.00"
        '
        'txtHours
        '
        Me.txtHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHours.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHours.Location = New System.Drawing.Point(166, 55)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(100, 29)
        Me.txtHours.TabIndex = 62
        Me.txtHours.Text = "40"
        '
        'cmbStatus
        '
        Me.cmbStatus.BackColor = System.Drawing.Color.White
        Me.cmbStatus.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"SINGLE", "MARRIED"})
        Me.cmbStatus.Location = New System.Drawing.Point(166, 86)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(100, 29)
        Me.cmbStatus.TabIndex = 66
        Me.cmbStatus.Text = "SINGLE"
        '
        'lblExemptions
        '
        Me.lblExemptions.AutoSize = True
        Me.lblExemptions.BackColor = System.Drawing.Color.White
        Me.lblExemptions.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExemptions.Location = New System.Drawing.Point(15, 121)
        Me.lblExemptions.Name = "lblExemptions"
        Me.lblExemptions.Size = New System.Drawing.Size(131, 21)
        Me.lblExemptions.TabIndex = 68
        Me.lblExemptions.Text = "Exemptions:"
        '
        'txtExemptions
        '
        Me.txtExemptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExemptions.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExemptions.Location = New System.Drawing.Point(166, 119)
        Me.txtExemptions.Name = "txtExemptions"
        Me.txtExemptions.Size = New System.Drawing.Size(100, 29)
        Me.txtExemptions.TabIndex = 67
        Me.txtExemptions.Text = "1"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.White
        Me.lblStatus.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(59, 89)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(87, 21)
        Me.lblStatus.TabIndex = 69
        Me.lblStatus.Text = "Status:"
        '
        'pbSimple
        '
        Me.pbSimple.Location = New System.Drawing.Point(12, 179)
        Me.pbSimple.Name = "pbSimple"
        Me.pbSimple.Size = New System.Drawing.Size(376, 320)
        Me.pbSimple.TabIndex = 72
        Me.pbSimple.TabStop = False
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.White
        Me.cmdExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ForeColor = System.Drawing.Color.Black
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(343, 77)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(45, 45)
        Me.cmdExit.TabIndex = 71
        Me.cmdExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'cmdPayroll
        '
        Me.cmdPayroll.BackColor = System.Drawing.Color.White
        Me.cmdPayroll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdPayroll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdPayroll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdPayroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPayroll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPayroll.Image = CType(resources.GetObject("cmdPayroll.Image"), System.Drawing.Image)
        Me.cmdPayroll.Location = New System.Drawing.Point(343, 25)
        Me.cmdPayroll.Name = "cmdPayroll"
        Me.cmdPayroll.Size = New System.Drawing.Size(45, 45)
        Me.cmdPayroll.TabIndex = 70
        Me.cmdPayroll.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdPayroll.UseVisualStyleBackColor = False
        '
        'frmSimple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(404, 513)
        Me.ControlBox = False
        Me.Controls.Add(Me.pbSimple)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdPayroll)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblExemptions)
        Me.Controls.Add(Me.txtExemptions)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.lblPayrate)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.txtPayRate)
        Me.Controls.Add(Me.txtHours)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmSimple"
        Me.Text = "QLedger Simple Calculator"
        CType(Me.pbSimple, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPayrate As System.Windows.Forms.Label
    Friend WithEvents lblHours As System.Windows.Forms.Label
    Friend WithEvents txtPayRate As System.Windows.Forms.TextBox
    Friend WithEvents txtHours As System.Windows.Forms.TextBox
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblExemptions As System.Windows.Forms.Label
    Friend WithEvents txtExemptions As System.Windows.Forms.TextBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents cmdPayroll As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents pbSimple As System.Windows.Forms.PictureBox
End Class
