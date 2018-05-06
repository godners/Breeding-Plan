Friend Module Procedure
    Public Sub CreateProcedure()
        For Each tempRow In FrmMain.DtsDefine.Tables("Days").Rows
            Call CreateDayProcedure(tempRow("Code"))
        Next
        For Each tempRow In FrmMain.DtsDefine.Tables("Round").Rows
            Call CreateRoundProcedureByDay(tempRow("Code"))
            Call CreateRoundProcedure(tempRow("Code"))
        Next
        For Each tempRow In FrmMain.DtsDefine.Tables("Revolution").Rows
            Call CreateRevolutionProcedure(tempRow("Code"))
        Next
    End Sub
    Private Sub CreateDayProcedure(DayCode As String)
        Dim tempTable As DataTable = New DataTable()
        AddColumnToTable("System.UInt16", "Period", tempTable)
        AddColumnToTable("System.String", "Time", tempTable)
        AddColumnToTable("System.Char", "ActionCode", tempTable)
        AddColumnToTable("System.Byte", "ActionType", tempTable)
        Dim StrProcedure As String = FrmMain.DtsDefine.Tables("Days").Select("Code='" & DayCode & "'")(0).Item("Procedure")
        Dim Period As UInt16 = 0
        Dim i, j As UInt16
        Dim a As String
        For i = 0 To StrProcedure.Length - 1
            a = StrProcedure.Substring(i, 1)
            For j = 1 To FrmMain.DtsDefine.Tables("Action").Select("Code='" & a & "'")(0).Item("Still") / 30
                AddRowToDayProcedure(Period, a, tempTable)
                Period += 1
            Next
        Next
        tempTable.TableName = FrmMain.DtsDefine.Tables("Days").Select("Code='" & DayCode & "'")(0).Item("Description")
        FrmMain.DtsProcedure.Tables.Add(tempTable)
        tempTable.Dispose()
    End Sub
    Private Sub CreateRoundProcedureByDay(RoundCode As String)
        Dim tempTable As DataTable = New DataTable()
        AddColumnToTable("System.UInt16", "Period", tempTable)
        AddColumnToTable("System.Char", "DaysCode", temptable)
        AddColumnToTable("System.UInt16", "Breeds", temptable)
        Dim StrProcedure As String = FrmMain.DtsDefine.Tables("Round").Select("Code='" & RoundCode & "'")(0).Item("Procedure")
        Dim i As UInt16
        For i = 0 To StrProcedure.Length - 1
            AddRowToRoundProcedureByDay(i, StrProcedure.Substring(i, 1), tempTable)
        Next
        tempTable.TableName = FrmMain.DtsDefine.Tables("Round").Select("Code='" & RoundCode & "'")(0).Item("Description") & "ByDay"
        FrmMain.DtsProcedure.Tables.Add(temptable)
        temptable.Dispose()
    End Sub
    Private Sub CreateRoundProcedure(RoundCode As String)
        Dim tempTable As DataTable = New DataTable
        AddColumnToTable("System.UInt16", "Period", tempTable)
        AddColumnToTable("System.UInt16", "TimePeriod", tempTable)
        AddColumnToTable("System.UInt16", "DaysPeriod", tempTable)
        AddColumnToTable("System.String", "Time", tempTable)
        AddColumnToTable("System.Char", "DaysCode", tempTable)
        AddColumnToTable("System.Char", "ActionCode", tempTable)
        AddColumnToTable("System.Byte", "ActionType", tempTable)
        Dim StrProcedure As String = FrmMain.DtsDefine.Tables("Round").Select("Code='" & RoundCode & "'")(0).Item("Procedure")
        Dim Period As UInt16 = 0
        Dim i, j, k As UInt16
        Dim d, a, StrSubProcedure As String
        For i = 0 To StrProcedure.Length - 1
            d = StrProcedure.Substring(i, 1)
            StrSubProcedure = FrmMain.DtsDefine.Tables("Days").Select("Code='" & d & "'")(0).Item("Procedure")
            For j = 0 To StrSubProcedure.Length - 1
                a = StrSubProcedure.Substring(j, 1)
                For k = 1 To FrmMain.DtsDefine.Tables("Action").Select("Code='" & a & "'")(0).Item("Still") / 30
                    AddRowToRoundProcedure(Period, d, a, tempTable)
                    Period += 1
                Next
            Next
        Next
        tempTable.TableName = FrmMain.DtsDefine.Tables("Round").Select("Code='" & RoundCode & "'")(0).Item("Description")
        FrmMain.DtsProcedure.Tables.Add(tempTable)
        tempTable.Dispose()
    End Sub
    Private Sub CreateRevolutionProcedure(RevolutionCode As String)
        Dim tempTable As DataTable = New DataTable
        AddColumnToTable("System.UInt16", "Period", tempTable)
        AddColumnToTable("System.UInt16", "TimePeriod", tempTable)
        AddColumnToTable("System.UInt16", "DaysPeriod", tempTable)
        AddColumnToTable("System.UInt16", "DaysPeriodOnRound", tempTable)
        AddColumnToTable("System.UInt16", "RoundPeriod", tempTable)
        AddColumnToTable("System.String", "Time", tempTable)
        AddColumnToTable("System.Char", "RoundCode", tempTable)
        AddColumnToTable("System.Char", "DaysCode", tempTable)
        AddColumnToTable("System.Char", "ActionCode", tempTable)
        AddColumnToTable("System.Byte", "ActionType", tempTable)
        Dim StrRoundProcedure As String = FrmMain.DtsDefine.Tables("Revolution").Select("Code='" & RevolutionCode & "'")(0).Item("Procedure")
        Dim Period As UInt16 = 0
        Dim i, j, k, l, PeriodOnRound As UInt16
        Dim r, d, a, StrDaysProcedure, StrActionProcedure As String
        For i = 0 To StrRoundProcedure.Length - 1
            r = StrRoundProcedure.Substring(i, 1)
            StrDaysProcedure = FrmMain.DtsDefine.Tables("Round").Select("Code='" & r & "'")(0).Item("Procedure")
            PeriodOnRound = 0
            For j = 0 To StrDaysProcedure.Length - 1
                d = StrDaysProcedure.Substring(j, 1)
                StrActionProcedure = FrmMain.DtsDefine.Tables("Days").Select("Code='" & d & "'")(0).Item("Procedure")
                For k = 0 To StrActionProcedure.Length - 1
                    a = StrActionProcedure.Substring(k, 1)
                    For l = 1 To FrmMain.DtsDefine.Tables("Action").Select("Code='" & a & "'")(0).Item("Still") / 30
                        AddRowToRevolutionPercedure(Period, PeriodOnRound, i, r, d, a, tempTable)
                        Period += 1
                    Next
                Next
                PeriodOnRound += 1
            Next
        Next
        tempTable.TableName = FrmMain.DtsDefine.Tables("Revolution").Select("Code='" & RevolutionCode & "'")(0).Item("Description")
        FrmMain.DtsProcedure.Tables.Add(tempTable)
        tempTable.Dispose()
    End Sub

    Private Sub AddRowToRevolutionPercedure(inpP As UInt16, inpDR As UInt16, inpRp As UInt16,
                inpR As String, inpD As String, inpA As String, ByRef oupTable As DataTable)
        Dim tempRow As DataRow = oupTable.NewRow
        tempRow("Period") = inpP
        tempRow("TimePeriod") = inpP Mod 48
        tempRow("DaysPeriod") = Math.Floor(inpP / 48)
        tempRow("DaysPeriodOnRound") = inpDR
        tempRow("RoundPeriod") = inpRp
        tempRow("Time") = PeriodToTime(inpP Mod 48)
        tempRow("RoundCode") = inpR
        tempRow("DaysCode") = inpD
        tempRow("ActionCode") = inpA
        tempRow("ActionType") = GetActionTypeByCode(inpA)
        oupTable.Rows.Add(tempRow)
    End Sub
    Private Sub AddRowToRoundProcedure(inpP As UInt16, inpD As String, inpA As String, ByRef oupTable As DataTable)
        Dim tempRow As DataRow = oupTable.NewRow
        tempRow("Period") = inpP
        tempRow("TimePeriod") = inpP Mod 48
        tempRow("DaysPeriod") = Math.Floor(inpP / 48)
        tempRow("Time") = PeriodToTime(inpP Mod 48)
        tempRow("DaysCode") = inpD.ToCharArray()(0)
        tempRow("ActionCode") = inpA.ToCharArray()(0)
        tempRow("ActionType") = GetActionTypeByCode(inpA)
        oupTable.Rows.Add(tempRow)
    End Sub
    Private Sub AddRowToRoundProcedureByDay(inpP As UInt16, inpD As String, ByRef oupTable As DataTable)
        Dim tempRow As DataRow = oupTable.NewRow()
        tempRow("Period") = inpP
        tempRow("DaysCode") = inpD.ToCharArray()(0)
        tempRow("Breeds") = FrmMain.DtsDefine.Tables("Days").Select("Code='" & inpD & "'")(0).Item("Breeds")
        oupTable.Rows.Add(tempRow)
    End Sub
    Private Sub AddRowToDayProcedure(inpP As UInt16, inpA As String, ByRef oupTable As DataTable)
        Dim tempRow As DataRow = oupTable.NewRow()
        tempRow("Period") = inpP
        tempRow("Time") = PeriodToTime(inpP)
        tempRow("ActionCode") = inpA.ToCharArray()(0)
        tempRow("ActionType") = GetActionTypeByCode(inpA)
        oupTable.Rows.Add(tempRow)
    End Sub
End Module
