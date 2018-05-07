Public Class FrmMain
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Doing.CreateDoing()
        Call DataDefine.CreateDataDefine()
        Call Procedure.CreateProcedure()

        Call ClearExportFolder(True, True, My.Application.Info.DirectoryPath)
        Call ExportDataByTable(False, True, My.Application.Info.DirectoryPath)
        Call ExportData(False, True, My.Application.Info.DirectoryPath)
        'MessageBox.Show(AbbrToFull("U"))
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        End
    End Sub

    Private Sub BtnAction_Click(sender As Object, e As EventArgs) Handles BtnAction.Click
        Me.Hide()
        FrmAction.Show()
    End Sub
End Class