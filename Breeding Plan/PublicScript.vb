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

        Return ((Math.Floor(Period / 6) + 9) Mod 24).ToString.PadLeft(2, "0") &
            ((Period Mod 6) * 10).ToString.PadLeft(2, "0")

        'Return PeriodToBeginTime(Period) & "-" & PeriodToEndTime(Period)
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
    Public Sub ExportDataByTable(IncludeSchema As Boolean, AloneSchema As Boolean, oupPath As String)
        'Dim fi As IO.FileInfo
        Dim dt As DataTable
        Dim m As XmlWriteMode = If(IncludeSchema, XmlWriteMode.WriteSchema, XmlWriteMode.IgnoreSchema)
        If Not IO.Directory.Exists(oupPath) Then Exit Sub
        If Not IO.Directory.Exists(oupPath & "\XMLs") Then IO.Directory.CreateDirectory(oupPath & "\XMLs")
        'For Each fi In New IO.DirectoryInfo(oupPath & "\XMLs").GetFiles
        '    fi.Delete()
        'Next
        For Each dt In FrmMain.DtsDefine.Tables
            dt.WriteXml(oupPath & "\XMLs\Define-" & dt.TableName & ".xml", m)
        Next
        For Each dt In FrmMain.DtsProcedure.Tables
            dt.WriteXml(oupPath & "\XMLs\Procedure-" & dt.TableName & ".xml", m)
        Next
        For Each dt In FrmMain.DtsDoing.Tables
            dt.WriteXml(oupPath & "\XMLs\Doing-" & dt.TableName & ".xml", m)
        Next
        If AloneSchema Then
            If Not IO.Directory.Exists(oupPath & "\XMLSchemas") Then IO.Directory.CreateDirectory(oupPath & "\XMLSchemas")
            'For Each fi In New IO.DirectoryInfo(oupPath & "\XMLSchemas").GetFiles
            '    fi.Delete()
            'Next
            For Each dt In FrmMain.DtsDefine.Tables
                dt.WriteXmlSchema(oupPath & "\XMLSchemas\Define-" & dt.TableName & ".xml")
            Next
            For Each dt In FrmMain.DtsProcedure.Tables
                dt.WriteXmlSchema(oupPath & "\XMLSchemas\Procedure-" & dt.TableName & ".xml")
            Next
            For Each dt In FrmMain.DtsDoing.Tables
                dt.WriteXmlSchema(oupPath & "\XMLSchemas\Doing-" & dt.TableName & ".xml")
            Next
        End If
    End Sub
    Public Sub ExportData(IncludeSchema As Boolean, AloneSchema As Boolean, oupPath As String)
        Dim m As XmlWriteMode = If(IncludeSchema, XmlWriteMode.WriteSchema, XmlWriteMode.IgnoreSchema)
        If Not IO.Directory.Exists(oupPath) Then Exit Sub
        If Not IO.Directory.Exists(oupPath & "\XMLs") Then IO.Directory.CreateDirectory(oupPath & "\XMLs")
        FrmMain.DtsDefine.WriteXml(oupPath & "\XMLs\Define.xml", m)
        FrmMain.DtsProcedure.WriteXml(oupPath & "\XMLs\Procedure.xml", m)
        FrmMain.DtsDoing.WriteXml(oupPath & "\XMLs\Doing.xml", m)
        If AloneSchema Then
            If Not IO.Directory.Exists(oupPath & "\XMLSchemas") Then IO.Directory.CreateDirectory(oupPath & "\XMLSchemas")
            FrmMain.DtsDefine.WriteXmlSchema(oupPath & "\XMLSchemas\Define.xml")
            FrmMain.DtsProcedure.WriteXmlSchema(oupPath & "\XMLSchemas\Procedure.xml")
            FrmMain.DtsDoing.WriteXmlSchema(oupPath & "\XMLSchemas\Doing.xml")
        End If
    End Sub
    Public Sub ClearExportFolder(DataFolder As Boolean, SchemaFolder As Boolean, oupPath As String)
        If DataFolder And IO.Directory.Exists(oupPath & "\XMLs") Then IO.Directory.Delete(oupPath & "\XMLs", True)
        If DataFolder And IO.Directory.Exists(oupPath & "\XMLschemas") Then IO.Directory.Delete(oupPath & "\XMLSchemas", True)
    End Sub
    Public Function AbbrToFull(inpC As String) As String
        Return FrmMain.DtsDefine.Tables("Abbreviation").Select("Code='" & inpC & "'")(0).Item("Description")
    End Function
End Module
