<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnAction = New System.Windows.Forms.Button()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.BtnDays = New System.Windows.Forms.Button()
        Me.BtnRound = New System.Windows.Forms.Button()
        Me.BtnRevolution = New System.Windows.Forms.Button()
        Me.PtbLogo = New System.Windows.Forms.PictureBox()
        Me.DtsDefine = New System.Data.DataSet()
        Me.DtsProcedure = New System.Data.DataSet()
        Me.DtsDoing = New System.Data.DataSet()
        Me.BtnExport = New System.Windows.Forms.Button()
        CType(Me.PtbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsDefine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsProcedure, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsDoing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnExit
        '
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Location = New System.Drawing.Point(141, 145)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(120, 36)
        Me.BtnExit.TabIndex = 0
        Me.BtnExit.Text = "E&xit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnAction
        '
        Me.BtnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAction.Location = New System.Drawing.Point(13, 57)
        Me.BtnAction.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAction.Name = "BtnAction"
        Me.BtnAction.Size = New System.Drawing.Size(120, 36)
        Me.BtnAction.TabIndex = 1
        Me.BtnAction.Text = "&Action"
        Me.BtnAction.UseVisualStyleBackColor = True
        '
        'LblTitle
        '
        Me.LblTitle.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(57, 13)
        Me.LblTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(204, 36)
        Me.LblTitle.TabIndex = 2
        Me.LblTitle.Text = "Breeding Plan"
        Me.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnDays
        '
        Me.BtnDays.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDays.Location = New System.Drawing.Point(141, 57)
        Me.BtnDays.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDays.Name = "BtnDays"
        Me.BtnDays.Size = New System.Drawing.Size(120, 36)
        Me.BtnDays.TabIndex = 3
        Me.BtnDays.Text = "&Days"
        Me.BtnDays.UseVisualStyleBackColor = True
        '
        'BtnRound
        '
        Me.BtnRound.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRound.Location = New System.Drawing.Point(13, 101)
        Me.BtnRound.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRound.Name = "BtnRound"
        Me.BtnRound.Size = New System.Drawing.Size(120, 36)
        Me.BtnRound.TabIndex = 4
        Me.BtnRound.Text = "&Round"
        Me.BtnRound.UseVisualStyleBackColor = True
        '
        'BtnRevolution
        '
        Me.BtnRevolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRevolution.Location = New System.Drawing.Point(141, 101)
        Me.BtnRevolution.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnRevolution.Name = "BtnRevolution"
        Me.BtnRevolution.Size = New System.Drawing.Size(120, 36)
        Me.BtnRevolution.TabIndex = 4
        Me.BtnRevolution.Text = "Re&volution"
        Me.BtnRevolution.UseVisualStyleBackColor = True
        '
        'PtbLogo
        '
        Me.PtbLogo.BackgroundImage = Global.Breeding_Plan.My.Resources.Resources.Logo_PNG
        Me.PtbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PtbLogo.Location = New System.Drawing.Point(13, 13)
        Me.PtbLogo.Margin = New System.Windows.Forms.Padding(4)
        Me.PtbLogo.Name = "PtbLogo"
        Me.PtbLogo.Size = New System.Drawing.Size(36, 36)
        Me.PtbLogo.TabIndex = 5
        Me.PtbLogo.TabStop = False
        '
        'DtsDefine
        '
        Me.DtsDefine.DataSetName = "DataDefine"
        '
        'DtsProcedure
        '
        Me.DtsProcedure.DataSetName = "Procedure"
        '
        'DtsDoing
        '
        Me.DtsDoing.DataSetName = "DtsDoing"
        '
        'BtnExport
        '
        Me.BtnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExport.Location = New System.Drawing.Point(13, 145)
        Me.BtnExport.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnExport.Name = "BtnExport"
        Me.BtnExport.Size = New System.Drawing.Size(120, 36)
        Me.BtnExport.TabIndex = 7
        Me.BtnExport.Text = "&Export"
        Me.BtnExport.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(274, 194)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnExport)
        Me.Controls.Add(Me.PtbLogo)
        Me.Controls.Add(Me.BtnRevolution)
        Me.Controls.Add(Me.BtnRound)
        Me.Controls.Add(Me.BtnDays)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.BtnAction)
        Me.Controls.Add(Me.BtnExit)
        Me.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Name = "FrmMain"
        Me.Text = "Breeding Plan"
        CType(Me.PtbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsDefine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsProcedure, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsDoing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    'Friend WithEvents Button1 As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnAction As Button
    Friend WithEvents LblTitle As Label
    Friend WithEvents BtnDays As Button
    Friend WithEvents BtnRound As Button
    Friend WithEvents BtnRevolution As Button
    Friend WithEvents PtbLogo As PictureBox
    Friend WithEvents DtsProcedure As DataSet
    Friend WithEvents DtsDefine As DataSet
    Friend WithEvents DtsDoing As DataSet
    Friend WithEvents BtnExport As Button
End Class
