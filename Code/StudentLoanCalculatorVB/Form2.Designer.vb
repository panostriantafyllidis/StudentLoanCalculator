<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.txtboxSalary = New System.Windows.Forms.TextBox()
        Me.txtboxLoanAmount = New System.Windows.Forms.TextBox()
        Me.txtboxInterestRate = New System.Windows.Forms.TextBox()
        Me.txtboxThreshold = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtboxMaxTerms = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtboxRepaymentPrcent = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Calculatebtn = New System.Windows.Forms.Button()
        Me.Quitbtn = New System.Windows.Forms.Button()
        Me.lblCalculationConfirm = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtboxSalary
        '
        Me.txtboxSalary.BackColor = System.Drawing.Color.White
        Me.txtboxSalary.ForeColor = System.Drawing.Color.Black
        Me.txtboxSalary.Location = New System.Drawing.Point(20, 99)
        Me.txtboxSalary.Name = "txtboxSalary"
        Me.txtboxSalary.Size = New System.Drawing.Size(141, 31)
        Me.txtboxSalary.TabIndex = 0
        Me.txtboxSalary.Text = "80000"
        '
        'txtboxLoanAmount
        '
        Me.txtboxLoanAmount.BackColor = System.Drawing.Color.White
        Me.txtboxLoanAmount.Location = New System.Drawing.Point(20, 198)
        Me.txtboxLoanAmount.Name = "txtboxLoanAmount"
        Me.txtboxLoanAmount.Size = New System.Drawing.Size(141, 31)
        Me.txtboxLoanAmount.TabIndex = 1
        Me.txtboxLoanAmount.Text = "35000"
        '
        'txtboxInterestRate
        '
        Me.txtboxInterestRate.BackColor = System.Drawing.Color.White
        Me.txtboxInterestRate.Location = New System.Drawing.Point(39, 76)
        Me.txtboxInterestRate.Name = "txtboxInterestRate"
        Me.txtboxInterestRate.Size = New System.Drawing.Size(116, 31)
        Me.txtboxInterestRate.TabIndex = 2
        Me.txtboxInterestRate.Text = " 6.3"
        '
        'txtboxThreshold
        '
        Me.txtboxThreshold.BackColor = System.Drawing.Color.White
        Me.txtboxThreshold.Location = New System.Drawing.Point(37, 156)
        Me.txtboxThreshold.Name = "txtboxThreshold"
        Me.txtboxThreshold.Size = New System.Drawing.Size(118, 31)
        Me.txtboxThreshold.TabIndex = 3
        Me.txtboxThreshold.Text = "  25000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Forte", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(282, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(551, 51)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Student Loan Calculator "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtboxSalary)
        Me.GroupBox1.Controls.Add(Me.txtboxLoanAmount)
        Me.GroupBox1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(38, 344)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(274, 266)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Information"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(234, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Student Loan Amount (£)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Annual Salary (£)"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtboxMaxTerms)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtboxRepaymentPrcent)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtboxInterestRate)
        Me.GroupBox2.Controls.Add(Me.txtboxThreshold)
        Me.GroupBox2.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(737, 209)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(320, 401)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Loan Data"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 367)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(287, 22)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "(Standard:30 yrs[360  Months])"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 308)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(231, 22)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Maximum Terms (Years)"
        '
        'txtboxMaxTerms
        '
        Me.txtboxMaxTerms.BackColor = System.Drawing.Color.White
        Me.txtboxMaxTerms.Location = New System.Drawing.Point(37, 333)
        Me.txtboxMaxTerms.Name = "txtboxMaxTerms"
        Me.txtboxMaxTerms.Size = New System.Drawing.Size(117, 31)
        Me.txtboxMaxTerms.TabIndex = 8
        Me.txtboxMaxTerms.Text = "30"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(259, 22)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Repayment Percentage (%)"
        '
        'txtboxRepaymentPrcent
        '
        Me.txtboxRepaymentPrcent.BackColor = System.Drawing.Color.White
        Me.txtboxRepaymentPrcent.Location = New System.Drawing.Point(38, 249)
        Me.txtboxRepaymentPrcent.Name = "txtboxRepaymentPrcent"
        Me.txtboxRepaymentPrcent.Size = New System.Drawing.Size(117, 31)
        Me.txtboxRepaymentPrcent.TabIndex = 6
        Me.txtboxRepaymentPrcent.Text = "  9"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(231, 22)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Annual Interest Rate (%)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(236, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Repayment Threshold (£)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(34, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(539, 120)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = resources.GetString("Label8.Text")
        '
        'Calculatebtn
        '
        Me.Calculatebtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Calculatebtn.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calculatebtn.ForeColor = System.Drawing.Color.Black
        Me.Calculatebtn.Location = New System.Drawing.Point(454, 450)
        Me.Calculatebtn.Name = "Calculatebtn"
        Me.Calculatebtn.Size = New System.Drawing.Size(190, 45)
        Me.Calculatebtn.TabIndex = 8
        Me.Calculatebtn.Text = "Calculate"
        Me.Calculatebtn.UseVisualStyleBackColor = False
        '
        'Quitbtn
        '
        Me.Quitbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Quitbtn.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quitbtn.Location = New System.Drawing.Point(454, 566)
        Me.Quitbtn.Name = "Quitbtn"
        Me.Quitbtn.Size = New System.Drawing.Size(190, 44)
        Me.Quitbtn.TabIndex = 9
        Me.Quitbtn.Text = "Quit"
        Me.Quitbtn.UseVisualStyleBackColor = False
        '
        'lblCalculationConfirm
        '
        Me.lblCalculationConfirm.AutoSize = True
        Me.lblCalculationConfirm.BackColor = System.Drawing.Color.Transparent
        Me.lblCalculationConfirm.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalculationConfirm.Location = New System.Drawing.Point(528, 167)
        Me.lblCalculationConfirm.Name = "lblCalculationConfirm"
        Me.lblCalculationConfirm.Size = New System.Drawing.Size(0, 22)
        Me.lblCalculationConfirm.TabIndex = 10
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(998, 616)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(59, 48)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "=>"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1097, 673)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.lblCalculationConfirm)
        Me.Controls.Add(Me.Quitbtn)
        Me.Controls.Add(Me.Calculatebtn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Loan calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtboxSalary As TextBox
    Friend WithEvents txtboxLoanAmount As TextBox
    Friend WithEvents txtboxInterestRate As TextBox
    Friend WithEvents txtboxThreshold As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtboxRepaymentPrcent As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtboxMaxTerms As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Calculatebtn As Button
    Friend WithEvents Quitbtn As Button
    Friend WithEvents lblCalculationConfirm As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
