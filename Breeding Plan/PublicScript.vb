Module PublicScript
    Public Sub AddColumnToTable(ByVal inpType As String, ByVal inpName As String, ByRef oupTable As DataTable)
        Dim tempColumn As New DataColumn
        tempColumn.DataType = Type.GetType(inpType)
        tempColumn.ColumnName = inpName
        tempColumn.Caption = inpName
        tempColumn.AllowDBNull = False
        oupTable.Columns.Add(tempColumn)
        tempColumn.Dispose()
    End Sub
    Public Function PeriodToTime(Period As Byte) As String
        Return PeriodToBeginTime(Period) & "-" & PeriodToEndTime(Period)
    End Function
    Private Function PeriodToBeginTime(Period As Byte) As String
        Return Math.Floor(Period / 2).ToString.PadLeft(2, "0") & ((Period Mod 2) * 30).ToString.PadLeft(2, "0")
    End Function
    Private Function PeriodToEndTime(Period As Byte) As String
        Return Math.Floor((Period + 1) / 2).ToString.PadLeft(2, "0") & (((Period + 1) Mod 2) * 30).ToString.PadLeft(2, "0")
    End Function
    Public Function GetActionTypeByCode(ActionCode As String) As Byte
        With FrmMain.DtsDefine.Tables("Action").Select("Code='" & ActionCode & "'")(0)
            Return GetActionType(.Item("Breeding"), .Item("Eating"), .Item("Sleeping"), .Item("Resting"))
        End With
    End Function
End Module
