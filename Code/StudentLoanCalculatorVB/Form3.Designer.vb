<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.txtboxMonths = New System.Windows.Forms.RichTextBox()
        Me.txtboxYears = New System.Windows.Forms.RichTextBox()
        Me.txtboxTotalPayment = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtboxLoanConfirm = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblRepaymentData = New System.Windows.Forms.Label()
        Me.lstBoxInfo = New System.Windows.Forms.ListBox()
        Me.txtboxAnnualRepayment = New System.Windows.Forms.TextBox()
        Me.txtboxMonthlyRepayment = New System.Windows.Forms.TextBox()
        Me.lblAnnualRepayment = New System.Windows.Forms.Label()
        Me.lblMonthlyRepayment = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtboxTotalinterestPayed = New System.Windows.Forms.RichTextBox()
        Me.Quitbtn = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.txtBoxBack = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblRefund = New System.Windows.Forms.Label()
        Me.lblRefundPrice = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtboxMonths
        '
        Me.txtboxMonths.Enabled = False
        Me.txtboxMonths.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxMonths.Location = New System.Drawing.Point(63, 175)
        Me.txtboxMonths.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtboxMonths.Name = "txtboxMonths"
        Me.txtboxMonths.Size = New System.Drawing.Size(90, 33)
        Me.txtboxMonths.TabIndex = 0
        Me.txtboxMonths.Text = ""
        '
        'txtboxYears
        '
        Me.txtboxYears.Enabled = False
        Me.txtboxYears.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxYears.Location = New System.Drawing.Point(63, 109)
        Me.txtboxYears.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtboxYears.Name = "txtboxYears"
        Me.txtboxYears.Size = New System.Drawing.Size(90, 31)
        Me.txtboxYears.TabIndex = 1
        Me.txtboxYears.Text = ""
        '
        'txtboxTotalPayment
        '
        Me.txtboxTotalPayment.Enabled = False
        Me.txtboxTotalPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxTotalPayment.Location = New System.Drawing.Point(705, 421)
        Me.txtboxTotalPayment.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtboxTotalPayment.Name = "txtboxTotalPayment"
        Me.txtboxTotalPayment.Size = New System.Drawing.Size(168, 42)
        Me.txtboxTotalPayment.TabIndex = 2
        Me.txtboxTotalPayment.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(14, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Your loan of    £"
        '
        'txtboxLoanConfirm
        '
        Me.txtboxLoanConfirm.Enabled = False
        Me.txtboxLoanConfirm.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxLoanConfirm.Location = New System.Drawing.Point(157, 29)
        Me.txtboxLoanConfirm.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtboxLoanConfirm.Name = "txtboxLoanConfirm"
        Me.txtboxLoanConfirm.Size = New System.Drawing.Size(107, 28)
        Me.txtboxLoanConfirm.TabIndex = 4
        Me.txtboxLoanConfirm.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(156, 185)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Months"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(156, 116)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Years"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(423, 441)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(282, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "The Total Amount payed is :   £"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(281, 36)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 21)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Will be repayed in ..."
        '
        'lblRepaymentData
        '
        Me.lblRepaymentData.AutoSize = True
        Me.lblRepaymentData.BackColor = System.Drawing.Color.Transparent
        Me.lblRepaymentData.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRepaymentData.ForeColor = System.Drawing.Color.Black
        Me.lblRepaymentData.Location = New System.Drawing.Point(567, 81)
        Me.lblRepaymentData.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRepaymentData.Name = "lblRepaymentData"
        Me.lblRepaymentData.Size = New System.Drawing.Size(241, 21)
        Me.lblRepaymentData.TabIndex = 10
        Me.lblRepaymentData.Text = "Detailed repayment data :"
        '
        'lstBoxInfo
        '
        Me.lstBoxInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBoxInfo.FormattingEnabled = True
        Me.lstBoxInfo.ItemHeight = 17
        Me.lstBoxInfo.Location = New System.Drawing.Point(543, 106)
        Me.lstBoxInfo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstBoxInfo.Name = "lstBoxInfo"
        Me.lstBoxInfo.Size = New System.Drawing.Size(337, 242)
        Me.lstBoxInfo.TabIndex = 11
        '
        'txtboxAnnualRepayment
        '
        Me.txtboxAnnualRepayment.Enabled = False
        Me.txtboxAnnualRepayment.Location = New System.Drawing.Point(59, 270)
        Me.txtboxAnnualRepayment.Name = "txtboxAnnualRepayment"
        Me.txtboxAnnualRepayment.Size = New System.Drawing.Size(113, 20)
        Me.txtboxAnnualRepayment.TabIndex = 12
        '
        'txtboxMonthlyRepayment
        '
        Me.txtboxMonthlyRepayment.Enabled = False
        Me.txtboxMonthlyRepayment.Location = New System.Drawing.Point(59, 324)
        Me.txtboxMonthlyRepayment.Name = "txtboxMonthlyRepayment"
        Me.txtboxMonthlyRepayment.Size = New System.Drawing.Size(113, 20)
        Me.txtboxMonthlyRepayment.TabIndex = 13
        '
        'lblAnnualRepayment
        '
        Me.lblAnnualRepayment.AutoSize = True
        Me.lblAnnualRepayment.BackColor = System.Drawing.Color.Transparent
        Me.lblAnnualRepayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnnualRepayment.ForeColor = System.Drawing.Color.Black
        Me.lblAnnualRepayment.Location = New System.Drawing.Point(56, 249)
        Me.lblAnnualRepayment.Name = "lblAnnualRepayment"
        Me.lblAnnualRepayment.Size = New System.Drawing.Size(149, 17)
        Me.lblAnnualRepayment.TabIndex = 14
        Me.lblAnnualRepayment.Text = "Annual Repayment "
        '
        'lblMonthlyRepayment
        '
        Me.lblMonthlyRepayment.AutoSize = True
        Me.lblMonthlyRepayment.BackColor = System.Drawing.Color.Transparent
        Me.lblMonthlyRepayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthlyRepayment.ForeColor = System.Drawing.Color.Black
        Me.lblMonthlyRepayment.Location = New System.Drawing.Point(56, 306)
        Me.lblMonthlyRepayment.Name = "lblMonthlyRepayment"
        Me.lblMonthlyRepayment.Size = New System.Drawing.Size(155, 17)
        Me.lblMonthlyRepayment.TabIndex = 15
        Me.lblMonthlyRepayment.Text = "Monthly Repayment "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(431, 501)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(276, 21)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "With Total Interest payed :    £" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtboxTotalinterestPayed
        '
        Me.txtboxTotalinterestPayed.Enabled = False
        Me.txtboxTotalinterestPayed.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxTotalinterestPayed.Location = New System.Drawing.Point(705, 480)
        Me.txtboxTotalinterestPayed.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtboxTotalinterestPayed.Name = "txtboxTotalinterestPayed"
        Me.txtboxTotalinterestPayed.Size = New System.Drawing.Size(168, 42)
        Me.txtboxTotalinterestPayed.TabIndex = 17
        Me.txtboxTotalinterestPayed.Text = ""
        '
        'Quitbtn
        '
        Me.Quitbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Quitbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quitbtn.Location = New System.Drawing.Point(98, 479)
        Me.Quitbtn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Quitbtn.Name = "Quitbtn"
        Me.Quitbtn.Size = New System.Drawing.Size(122, 49)
        Me.Quitbtn.TabIndex = 20
        Me.Quitbtn.Text = "Quit"
        Me.Quitbtn.UseVisualStyleBackColor = False
        '
        'ResetButton
        '
        Me.ResetButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ResetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetButton.ForeColor = System.Drawing.Color.Black
        Me.ResetButton.Location = New System.Drawing.Point(185, 405)
        Me.ResetButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(68, 49)
        Me.ResetButton.TabIndex = 21
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'txtBoxBack
        '
        Me.txtBoxBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtBoxBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxBack.ForeColor = System.Drawing.Color.Black
        Me.txtBoxBack.Location = New System.Drawing.Point(74, 405)
        Me.txtBoxBack.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBoxBack.Name = "txtBoxBack"
        Me.txtBoxBack.Size = New System.Drawing.Size(68, 49)
        Me.txtBoxBack.TabIndex = 22
        Me.txtBoxBack.Text = "Back"
        Me.txtBoxBack.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(94, 146)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Or"
        '
        'lblRefund
        '
        Me.lblRefund.AutoSize = True
        Me.lblRefund.BackColor = System.Drawing.Color.Transparent
        Me.lblRefund.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefund.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblRefund.Location = New System.Drawing.Point(423, 374)
        Me.lblRefund.Name = "lblRefund"
        Me.lblRefund.Size = New System.Drawing.Size(0, 19)
        Me.lblRefund.TabIndex = 24
        '
        'lblRefundPrice
        '
        Me.lblRefundPrice.AutoSize = True
        Me.lblRefundPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblRefundPrice.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefundPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblRefundPrice.Location = New System.Drawing.Point(588, 374)
        Me.lblRefundPrice.Name = "lblRefundPrice"
        Me.lblRefundPrice.Size = New System.Drawing.Size(0, 19)
        Me.lblRefundPrice.TabIndex = 25
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(931, 570)
        Me.Controls.Add(Me.lblRefundPrice)
        Me.Controls.Add(Me.lblRefund)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBoxBack)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.Quitbtn)
        Me.Controls.Add(Me.txtboxTotalinterestPayed)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblMonthlyRepayment)
        Me.Controls.Add(Me.lblAnnualRepayment)
        Me.Controls.Add(Me.txtboxMonthlyRepayment)
        Me.Controls.Add(Me.txtboxAnnualRepayment)
        Me.Controls.Add(Me.lstBoxInfo)
        Me.Controls.Add(Me.lblRepaymentData)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtboxLoanConfirm)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtboxTotalPayment)
        Me.Controls.Add(Me.txtboxYears)
        Me.Controls.Add(Me.txtboxMonths)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form3"
        Me.Text = "Results"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtboxMonths As RichTextBox
    Friend WithEvents txtboxYears As RichTextBox
    Friend WithEvents txtboxTotalPayment As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtboxLoanConfirm As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblRepaymentData As Label
    Friend WithEvents lstBoxInfo As ListBox
    Friend WithEvents txtboxAnnualRepayment As TextBox
    Friend WithEvents txtboxMonthlyRepayment As TextBox
    Friend WithEvents lblAnnualRepayment As Label
    Friend WithEvents lblMonthlyRepayment As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtboxTotalinterestPayed As RichTextBox
    Friend WithEvents Quitbtn As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents txtBoxBack As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblRefund As Label
    Friend WithEvents lblRefundPrice As Label
End Class
