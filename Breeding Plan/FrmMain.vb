Public Class FrmMain
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MessageBox.Show(ActionTypeString(GetActionType(False, True, False, False)))
        Call DataDefine.CreateDataDefine()
        Call Procedure.CreateProcedure()
        Call Doing.CreateDoing()
        'MessageBox.Show(DtsDefine.Tables.Item("Round").Rows.Count)
        'MessageBox.Show(DtsDefine.Tables.Item("Revolution").Select("Code='T'")(0).Item("Breeds"))
        'DtsDefine.Tables("Action").WriteXml(My.Application.Info.DirectoryPath & "\Action.xml")
        'DtsDefine.Tables("Days").WriteXml(My.Application.Info.DirectoryPath & "\Days.xml")
        'DtsDefine.Tables("Round").WriteXml(My.Application.Info.DirectoryPath & "\Round.xml")
        'DtsDefine.Tables("Revolution").WriteXml(My.Application.Info.DirectoryPath & "\Revolution.xml")



        For Each fi In New IO.DirectoryInfo(My.Application.Info.DirectoryPath & "\XMLs").GetFiles
            fi.Delete()
        Next
        Dim tempTable As DataTable
        For Each tempTable In DtsDefine.Tables
            tempTable.WriteXml(My.Application.Info.DirectoryPath & "\XMLs\Define-" & tempTable.TableName & ".xml")
        Next
        For Each tempTable In DtsProcedure.Tables
            tempTable.WriteXml(My.Application.Info.DirectoryPath & "\XMLs\Procedure-" & tempTable.TableName & ".xml")
        Next
        For Each tempTable In DtsDoing.Tables
            tempTable.WriteXml(My.Application.Info.DirectoryPath & "\XMLs\Doing-" & tempTable.TableName & ".xml")
        Next
        'MessageBox.Show(DtsDoing.Tables.Count)
        'Dim i As Integer
        'For i = 1 To 5 Step 1
        '    MessageBox.Show(PeriodToTime(i))
        'Next
        'MessageBox.Show(ActionTypeString(GetActionType(False, True, False, False)))
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        End
    End Sub
End Class