Friend Module DataDefine
    Public Sub CreateDataDefine()
        Call CreateActionTable()
        Call CreateDaysTable()
        Call CreateRoundTable()
        Call CreateRevolutionTable()
        Call CreateAbbreviationTable()
    End Sub
    Public Enum ActionType As Byte
        None = 0
        Breeding = 1
        Eating = 2
        Sleeping = 3
        Resting = 4
    End Enum
    Public Function ActionTypeString(inp As Byte) As String
        Select Case inp
            Case ActionType.Breeding : Return "Breeding"
            Case ActionType.Eating : Return "Eating"
            Case ActionType.Sleeping : Return "Sleeping"
            Case ActionType.Resting : Return "Resting"
            Case Else : Return "None"
        End Select
    End Function
    Public Function GetActionType(Breeding As Boolean, Eating As Boolean, Sleeping As Boolean, Resting As Boolean) As Byte
        Dim i As Byte = 0
        If Breeding Then i += 2
        If Eating Then i += 4
        If Sleeping Then i += 8
        If Resting Then i += 16
        Select Case i
            Case 2 : Return ActionType.Breeding
            Case 4 : Return ActionType.Eating
            Case 8 : Return ActionType.Sleeping
            Case 16 : Return ActionType.Resting
            Case Else : Return ActionType.None
        End Select
    End Function

    Private Sub CreateActionTable()
        Dim tempTable As DataTable = New DataTable()
        AddColumnToTable("System.Char", "Code", tempTable)
        AddColumnToTable("System.String", "Description", tempTable)
        AddColumnToTable("System.UInt16", "Still", tempTable)
        AddColumnToTable("System.Boolean", "Breeding", tempTable)
        AddColumnToTable("System.Boolean", "Eating", tempTable)
        AddColumnToTable("System.Boolean", "Sleeping", tempTable)
        AddColumnToTable("System.Boolean", "Resting", tempTable)
        AddRowToAction("U", "Usual", 90, ActionType.Breeding, tempTable)
        AddRowToAction("E", "Exciting", 180, ActionType.Breeding, tempTable)
        AddRowToAction("B", "Breakfast", 60, ActionType.Eating, tempTable)
        AddRowToAction("L", "Lunch", 60, ActionType.Eating, tempTable)
        AddRowToAction("D", "Dinner", 60, ActionType.Eating, tempTable)
        AddRowToAction("S", "Sleep", 360, ActionType.Sleeping, tempTable)
        AddRowToAction("A", "Asleep", 630, ActionType.Sleeping, tempTable)
        AddRowToAction("R", "Rest", 120, ActionType.Resting, tempTable)
        AddRowToAction("G", "Regain", 150, ActionType.Resting, tempTable)
        AddRowToAction("V", "Recover", 240, ActionType.Resting, tempTable)
        tempTable.TableName = "Action"
        FrmMain.DtsDefine.Tables.Add(tempTable)
        tempTable.Dispose()
    End Sub
    Private Sub CreateDaysTable()
        Dim tempTable As DataTable = New DataTable()
        AddColumnToTable("System.Char", "Code", tempTable)
        AddColumnToTable("System.String", "Description", tempTable)
        AddColumnToTable("System.UInt16", "Steps", tempTable)
        AddColumnToTable("System.String", "Procedure", tempTable)
        AddColumnToTable("System.UInt16", "Breeds", tempTable)
        AddColumnToTable("System.UInt16", "BreedStill", tempTable)
        AddColumnToTable("System.UInt16", "SleepStill", tempTable)
        AddColumnToTable("System.UInt16", "RestStill", tempTable)
        AddRowToDays("C", "Ceremony", "BULUEUUDEUSU", tempTable)
        AddRowToDays("J", "Job", "BRLGUDEESE", tempTable)
        AddRowToDays("P", "Poor", "BRLVDEAU", tempTable)
        tempTable.TableName = "Days"
        FrmMain.DtsDefine.Tables.Add(tempTable)
        tempTable.Dispose()
    End Sub
    Private Sub CreateRoundTable()
        Dim tempTable As DataTable = New DataTable
        AddColumnToTable("System.Char", "Code", tempTable)
        AddColumnToTable("System.String", "Description", tempTable)
        AddColumnToTable("System.UInt16", "Days", tempTable)
        AddColumnToTable("System.String", "Procedure", tempTable)
        AddColumnToTable("System.UInt16", "Breeds", tempTable)
        AddRowToRound("W", "Worship", "CCCJCCCCCCCPPPCJCCCP", tempTable)
        AddRowToRound("Q", "Ease", "JPCCCJCPCCPP", tempTable)
        AddRowToRound("K", "Leisure", "PJPJJJCPPPJCJPPJPJ", tempTable)
        tempTable.TableName = "Round"
        FrmMain.DtsDefine.Tables.Add(tempTable)
        tempTable.Dispose()
    End Sub
    Private Sub CreateRevolutionTable()
        Dim tempTable As DataTable = New DataTable
        AddColumnToTable("System.Char", "Code", tempTable)
        AddColumnToTable("System.String", "Description", tempTable)
        AddColumnToTable("System.UInt16", "Rounds", tempTable)
        AddColumnToTable("System.String", "Procedure", tempTable)
        AddColumnToTable("System.UInt16", "Days", tempTable)
        AddColumnToTable("System.UInt16", "Breeds", tempTable)
        AddRowToRevolution("T", "Total", "KQQKWQWKWQQKWWKQQKWWWQW", tempTable)
        tempTable.TableName = "Revolution"
        FrmMain.DtsDefine.Tables.Add(tempTable)
        tempTable.Dispose()
    End Sub
    Private Sub CreateAbbreviationTable()
        Dim tempTable As DataTable = New DataTable
        AddColumnToTable("System.Char", "Code", tempTable)
        AddColumnToTable("System.String", "Description", tempTable)
        AddColumnToTable("System.String", "Range", tempTable)
        AddRowToAbbreviation("U", "Usual", "Action", tempTable)
        AddRowToAbbreviation("E", "Exciting", "Action", tempTable)
        AddRowToAbbreviation("B", "Breakfast", "Action", tempTable)
        AddRowToAbbreviation("L", "Lunch", "Action", tempTable)
        AddRowToAbbreviation("D", "Dinner", "Action", tempTable)
        AddRowToAbbreviation("S", "Sleep", "Action", tempTable)
        AddRowToAbbreviation("A", "Asleep", "Action", tempTable)
        AddRowToAbbreviation("R", "Rest", "Action", tempTable)
        AddRowToAbbreviation("G", "Regain", "Action", tempTable)
        AddRowToAbbreviation("V", "Recover", "Action", tempTable)
        AddRowToAbbreviation("C", "Ceremony", "Days", tempTable)
        AddRowToAbbreviation("J", "Job", "Days", tempTable)
        AddRowToAbbreviation("P", "Poor", "Days", tempTable)
        AddRowToAbbreviation("W", "Worship", "Round", tempTable)
        AddRowToAbbreviation("Q", "Ease", "Round", tempTable)
        AddRowToAbbreviation("K", "Leisure", "Round", tempTable)
        AddRowToAbbreviation("T", "Total", "Revolution", tempTable)
        tempTable.TableName = "Abbreviation"
        FrmMain.DtsDefine.Tables.Add(tempTable)
        tempTable.Dispose()
    End Sub

    Private Sub AddRowToAbbreviation(inpC As String, inpD As String, inpR As String, ByRef oupTable As DataTable)
        Dim tempRow As DataRow = oupTable.NewRow()
        tempRow("Code") = inpC.ToArray()(0)
        tempRow("Description") = inpD
        tempRow("Range") = inpR
        oupTable.Rows.Add(tempRow)
    End Sub
    Private Sub AddRowToRevolution(inpC As String, inpD As String, inpP As String, ByRef oupTable As DataTable)
        Dim tempRow As DataRow = oupTable.NewRow()
        tempRow("Code") = inpC.ToCharArray()(0)
        tempRow("Description") = inpD
        tempRow("Rounds") = inpP.Length
        tempRow("Procedure") = inpP
        tempRow("Days") = 0
        tempRow("Breeds") = 0
        For i = 0 To inpP.Length - 1
            tempRow("Days") += FrmMain.DtsDefine.Tables("Round").Select("Code='" & inpP.Substring(i, 1) & "'")(0).Item("Days")
            tempRow("Breeds") += FrmMain.DtsDefine.Tables("Round").Select("Code='" & inpP.Substring(i, 1) & "'")(0).Item("Breeds")
        Next
        oupTable.Rows.Add(tempRow)
    End Sub
    Private Sub AddRowToRound(inpC As String, inpD As String, inpP As String, ByRef oupTable As DataTable)
        Dim tempRow As DataRow = oupTable.NewRow()
        tempRow("Code") = inpC.ToCharArray()(0)
        tempRow("Description") = inpD
        tempRow("Days") = inpP.Length
        tempRow("Procedure") = inpP
        tempRow("Breeds") = 0
        For i = 0 To inpP.Length - 1
            tempRow("Breeds") += FrmMain.DtsDefine.Tables("Days").Select("Code='" & inpP.Substring(i, 1) & "'")(0).Item("Breeds")
        Next
        oupTable.Rows.Add(tempRow)
    End Sub
    Private Sub AddRowToDays(inpC As String, inpD As String, inpP As String, ByRef oupTable As DataTable)
        Dim tempRow As DataRow = oupTable.NewRow()
        tempRow("Code") = inpC.ToCharArray()(0)
        tempRow("Description") = inpD
        tempRow("Steps") = inpP.Length
        tempRow("Procedure") = inpP
        tempRow("Breeds") = 0
        tempRow("BreedStill") = 0
        tempRow("SleepStill") = 0
        tempRow("RestStill") = 0
        Dim i As Byte
        For i = 0 To inpP.Length - 1
            With FrmMain.DtsDefine.Tables("Action").Select("Code='" & inpP.Substring(i, 1) & "'")(0)
                If .Item("Breeding") Then
                    tempRow("Breeds") += 1
                    tempRow("BreedStill") += .Item("Still")
                End If
                If .Item("Sleeping") Then
                    tempRow("SleepStill") += .Item("Still")
                End If
                If .Item("Resting") Then
                    tempRow("RestStill") += .Item("Still")
                End If
            End With
        Next i
        oupTable.Rows.Add(tempRow)
    End Sub
    Private Sub AddRowToAction(inpC As String, inpD As String, inpS As UInt16, inpIng As ActionType, ByRef oupTable As DataTable)
        Dim tempRow As DataRow = oupTable.NewRow()
        tempRow("Code") = inpC.ToCharArray()(0)
        tempRow("Description") = inpD
        tempRow("Still") = inpS
        tempRow("Breeding") = False
        tempRow("Eating") = False
        tempRow("Sleeping") = False
        tempRow("Resting") = False
        Select Case inpIng
            Case ActionType.Breeding : tempRow("Breeding") = True
            Case ActionType.Eating : tempRow("Eating") = True
            Case ActionType.Sleeping : tempRow("Sleeping") = True
            Case ActionType.Resting : tempRow("Resting") = True
            Case Else
        End Select
        oupTable.Rows.Add(tempRow)
    End Sub

End Module
