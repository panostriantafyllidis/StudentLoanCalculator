Public Class Form1

    '==========================================================================================
    '#  Close the splash screen and open the new form once the progress bar timer expires ' 
    '==========================================================================================

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2)

        'The bar is being filled by two vallues at a time. When it reaches 80 the cover page hides and form 2 is shown
        If ProgressBar1.Value = 80 Then
            Form2.Show()
            Me.Hide()
        End If

    End Sub


End Class
