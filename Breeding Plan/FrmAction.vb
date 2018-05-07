Public Class FrmAction
    Private Sub BtnReturn_Click(sender As Object, e As EventArgs) Handles BtnReturn.Click
        FrmMain.Show()
        Me.Close()
    End Sub

    Private Sub BtnBreeding_Click(sender As Object, e As EventArgs) Handles BtnBreeding.Click
        Call ResetButtonColor()
        BtnBreeding.BackColor = My.Settings.Yellow
        BtnBreeding.ForeColor = My.Settings.Black
        PtbGraph.Image = My.Resources.Action_Breeding
    End Sub


    Private Sub ResetButtonColor()
        BtnBreeding.BackColor = My.Settings.Black
        BtnEating.BackColor = My.Settings.Black
        BtnSleeping.BackColor = My.Settings.Black
        BtnResting.BackColor = My.Settings.Black
        BtnBreeding.ForeColor = My.Settings.Yellow
        BtnEating.ForeColor = My.Settings.Yellow
        BtnSleeping.ForeColor = My.Settings.Yellow
        BtnResting.ForeColor = My.Settings.Yellow
    End Sub

    Private Sub BtnEating_Click(sender As Object, e As EventArgs) Handles BtnEating.Click
        Call ResetButtonColor()
        BtnEating.BackColor = My.Settings.Yellow
        BtnEating.ForeColor = My.Settings.Black
        PtbGraph.Image = My.Resources.Action_Eating
    End Sub

    Private Sub BtnSleeping_Click(sender As Object, e As EventArgs) Handles BtnSleeping.Click
        Call ResetButtonColor()
        BtnSleeping.BackColor = My.Settings.Yellow
        BtnSleeping.ForeColor = My.Settings.Black
        PtbGraph.Image = My.Resources.Action_Sleeping
    End Sub

    Private Sub BtnResting_Click(sender As Object, e As EventArgs) Handles BtnResting.Click
        Call ResetButtonColor()
        BtnResting.BackColor = My.Settings.Yellow
        BtnResting.ForeColor = My.Settings.Black
        PtbGraph.Image = My.Resources.Action_Resting
    End Sub
End Class