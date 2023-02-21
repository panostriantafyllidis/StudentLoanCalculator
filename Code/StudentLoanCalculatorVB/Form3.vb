Public Class Form3
    '===============================================
    'Clicking the exit button will close the App
    '===============================================

    Private Sub Quitbtn_Click(sender As Object, e As EventArgs) Handles Quitbtn.Click

        Dim Response As DialogResult
        Response = MessageBox.Show("Would you like to exit ?", "",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Response = DialogResult.Yes Then

            Application.Exit()

        End If

    End Sub

    '================================================================================================
    'Clicking the "Reset" button will close form 3 , show form 3 and let the user re-do the process
    '================================================================================================

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Form2.txtboxSalary.Clear()
        Form2.txtboxLoanAmount.Clear()
        Form2.txtboxMaxTerms.Clear()
        txtboxLoanConfirm.Clear()
        txtboxAnnualRepayment.Clear()
        txtboxMonthlyRepayment.Clear()
        txtboxMonths.Clear()
        txtboxYears.Clear()
        txtboxTotalinterestPayed.Clear()
        txtboxTotalPayment.Clear()
        lstBoxInfo.Items.Clear()
        Me.Hide()
        Form2.Show()
    End Sub

    '===============================================================================================================================
    'The use of "Back" button is to give freedome to the user to view both the inputs and the outputs after a successful calculation
    '===============================================================================================================================
    Private Sub txtBoxBack_Click(sender As Object, e As EventArgs) Handles txtBoxBack.Click
        Me.Hide()
        Form2.Show()
    End Sub


End Class