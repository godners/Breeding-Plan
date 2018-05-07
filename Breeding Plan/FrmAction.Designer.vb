<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAction
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAction))
        Me.PtbGraph = New System.Windows.Forms.PictureBox()
        Me.PtbLogo = New System.Windows.Forms.PictureBox()
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.BtnBreeding = New System.Windows.Forms.Button()
        Me.BtnEating = New System.Windows.Forms.Button()
        Me.BtnSleeping = New System.Windows.Forms.Button()
        Me.BtnResting = New System.Windows.Forms.Button()
        Me.BtnReturn = New System.Windows.Forms.Button()
        CType(Me.PtbGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PtbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PtbGraph
        '
        Me.PtbGraph.Image = Global.Breeding_Plan.My.Resources.Resources.Action_Breeding
        Me.PtbGraph.Location = New System.Drawing.Point(13, 101)
        Me.PtbGraph.Margin = New System.Windows.Forms.Padding(4)
        Me.PtbGraph.Name = "PtbGraph"
        Me.PtbGraph.Size = New System.Drawing.Size(675, 284)
        Me.PtbGraph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PtbGraph.TabIndex = 9
        Me.PtbGraph.TabStop = False
        '
        'PtbLogo
        '
        Me.PtbLogo.BackgroundImage = Global.Breeding_Plan.My.Resources.Resources.Logo_PNG
        Me.PtbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PtbLogo.Location = New System.Drawing.Point(13, 13)
        Me.PtbLogo.Margin = New System.Windows.Forms.Padding(4)
        Me.PtbLogo.Name = "PtbLogo"
        Me.PtbLogo.Size = New System.Drawing.Size(36, 36)
        Me.PtbLogo.TabIndex = 10
        Me.PtbLogo.TabStop = False
        '
        'LblTitle
        '
        Me.LblTitle.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(57, 13)
        Me.LblTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(320, 36)
        Me.LblTitle.TabIndex = 11
        Me.LblTitle.Text = "Breeding Plan - Action"
        Me.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnBreeding
        '
        Me.BtnBreeding.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnBreeding.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBreeding.ForeColor = System.Drawing.Color.Black
        Me.BtnBreeding.Location = New System.Drawing.Point(13, 57)
        Me.BtnBreeding.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBreeding.Name = "BtnBreeding"
        Me.BtnBreeding.Size = New System.Drawing.Size(136, 36)
        Me.BtnBreeding.TabIndex = 12
        Me.BtnBreeding.Text = "&Breeding"
        Me.BtnBreeding.UseVisualStyleBackColor = False
        '
        'BtnEating
        '
        Me.BtnEating.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEating.Location = New System.Drawing.Point(157, 57)
        Me.BtnEating.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEating.Name = "BtnEating"
        Me.BtnEating.Size = New System.Drawing.Size(136, 36)
        Me.BtnEating.TabIndex = 13
        Me.BtnEating.Text = "&Eating"
        Me.BtnEating.UseVisualStyleBackColor = True
        '
        'BtnSleeping
        '
        Me.BtnSleeping.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSleeping.Location = New System.Drawing.Point(301, 57)
        Me.BtnSleeping.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSleeping.Name = "BtnSleeping"
        Me.BtnSleeping.Size = New System.Drawing.Size(136, 36)
        Me.BtnSleeping.TabIndex = 14
        Me.BtnSleeping.Text = "&Sleeping"
        Me.BtnSleeping.UseVisualStyleBackColor = True
        '
        'BtnResting
        '
        Me.BtnResting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnResting.Location = New System.Drawing.Point(445, 57)
        Me.BtnResting.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnResting.Name = "BtnResting"
        Me.BtnResting.Size = New System.Drawing.Size(136, 36)
        Me.BtnResting.TabIndex = 15
        Me.BtnResting.Text = "&Resting"
        Me.BtnResting.UseVisualStyleBackColor = True
        '
        'BtnReturn
        '
        Me.BtnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReturn.Location = New System.Drawing.Point(589, 57)
        Me.BtnReturn.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnReturn.Name = "BtnReturn"
        Me.BtnReturn.Size = New System.Drawing.Size(99, 36)
        Me.BtnReturn.TabIndex = 16
        Me.BtnReturn.Text = "Re&turn"
        Me.BtnReturn.UseVisualStyleBackColor = True
        '
        'FrmAction
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(701, 398)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnReturn)
        Me.Controls.Add(Me.BtnResting)
        Me.Controls.Add(Me.BtnSleeping)
        Me.Controls.Add(Me.BtnEating)
        Me.Controls.Add(Me.BtnBreeding)
        Me.Controls.Add(Me.LblTitle)
        Me.Controls.Add(Me.PtbLogo)
        Me.Controls.Add(Me.PtbGraph)
        Me.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.Name = "FrmAction"
        Me.Text = "Breeding Plan - Action"
        CType(Me.PtbGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PtbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PtbGraph As PictureBox
    Friend WithEvents PtbLogo As PictureBox
    Friend WithEvents LblTitle As Label
    Friend WithEvents BtnBreeding As Button
    Friend WithEvents BtnEating As Button
    Friend WithEvents BtnSleeping As Button
    Friend WithEvents BtnResting As Button
    Friend WithEvents BtnReturn As Button
End Class
