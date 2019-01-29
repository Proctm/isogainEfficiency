<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
		Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
		Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.btnEngPOn = New System.Windows.Forms.Button()
		Me.btnEngSOn = New System.Windows.Forms.Button()
		Me.txtEngPCur = New System.Windows.Forms.TextBox()
		Me.txtEngSCur = New System.Windows.Forms.TextBox()
		Me.btnEngPSet = New System.Windows.Forms.Button()
		Me.btnEngSSet = New System.Windows.Forms.Button()
		Me.tmrMain = New System.Windows.Forms.Timer(Me.components)
		Me.btnStartTest = New System.Windows.Forms.Button()
		Me.tmrTest = New System.Windows.Forms.Timer(Me.components)
		Me.txtTestPPower = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.btnStopTest = New System.Windows.Forms.Button()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtTestSPower = New System.Windows.Forms.TextBox()
		Me.crtResults = New System.Windows.Forms.DataVisualization.Charting.Chart()
		Me.btnOpenExcel = New System.Windows.Forms.Button()
		Me.GroupBox1.SuspendLayout()
		CType(Me.crtResults, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.Label3)
		Me.GroupBox1.Controls.Add(Me.btnEngPOn)
		Me.GroupBox1.Controls.Add(Me.btnEngSOn)
		Me.GroupBox1.Controls.Add(Me.txtEngPCur)
		Me.GroupBox1.Controls.Add(Me.txtEngSCur)
		Me.GroupBox1.Controls.Add(Me.btnEngPSet)
		Me.GroupBox1.Controls.Add(Me.btnEngSSet)
		Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox1.ForeColor = System.Drawing.Color.Red
		Me.GroupBox1.Location = New System.Drawing.Point(12, 471)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(690, 110)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Engineering control"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.Black
		Me.Label1.Location = New System.Drawing.Point(68, 54)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(25, 15)
		Me.Label1.TabIndex = 10
		Me.Label1.Text = "mA"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.Black
		Me.Label3.Location = New System.Drawing.Point(68, 26)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(25, 15)
		Me.Label3.TabIndex = 1
		Me.Label3.Text = "mA"
		'
		'btnEngPOn
		'
		Me.btnEngPOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnEngPOn.Location = New System.Drawing.Point(267, 51)
		Me.btnEngPOn.Name = "btnEngPOn"
		Me.btnEngPOn.Size = New System.Drawing.Size(128, 23)
		Me.btnEngPOn.TabIndex = 9
		Me.btnEngPOn.Text = "Switch pump ON"
		Me.btnEngPOn.UseVisualStyleBackColor = True
		'
		'btnEngSOn
		'
		Me.btnEngSOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnEngSOn.Location = New System.Drawing.Point(267, 22)
		Me.btnEngSOn.Name = "btnEngSOn"
		Me.btnEngSOn.Size = New System.Drawing.Size(128, 23)
		Me.btnEngSOn.TabIndex = 8
		Me.btnEngSOn.Text = "Switch seed ON"
		Me.btnEngSOn.UseVisualStyleBackColor = True
		'
		'txtEngPCur
		'
		Me.txtEngPCur.Location = New System.Drawing.Point(6, 51)
		Me.txtEngPCur.Name = "txtEngPCur"
		Me.txtEngPCur.Size = New System.Drawing.Size(56, 22)
		Me.txtEngPCur.TabIndex = 5
		'
		'txtEngSCur
		'
		Me.txtEngSCur.Location = New System.Drawing.Point(6, 23)
		Me.txtEngSCur.Name = "txtEngSCur"
		Me.txtEngSCur.Size = New System.Drawing.Size(56, 22)
		Me.txtEngSCur.TabIndex = 4
		'
		'btnEngPSet
		'
		Me.btnEngPSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnEngPSet.Location = New System.Drawing.Point(112, 50)
		Me.btnEngPSet.Name = "btnEngPSet"
		Me.btnEngPSet.Size = New System.Drawing.Size(118, 23)
		Me.btnEngPSet.TabIndex = 1
		Me.btnEngPSet.Text = "Set pump current"
		Me.btnEngPSet.UseVisualStyleBackColor = True
		'
		'btnEngSSet
		'
		Me.btnEngSSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnEngSSet.Location = New System.Drawing.Point(112, 23)
		Me.btnEngSSet.Name = "btnEngSSet"
		Me.btnEngSSet.Size = New System.Drawing.Size(118, 23)
		Me.btnEngSSet.TabIndex = 0
		Me.btnEngSSet.Text = "Set seed current"
		Me.btnEngSSet.UseVisualStyleBackColor = True
		'
		'tmrMain
		'
		Me.tmrMain.Interval = 250
		'
		'btnStartTest
		'
		Me.btnStartTest.Location = New System.Drawing.Point(12, 12)
		Me.btnStartTest.Name = "btnStartTest"
		Me.btnStartTest.Size = New System.Drawing.Size(142, 23)
		Me.btnStartTest.TabIndex = 2
		Me.btnStartTest.Text = "Start Efficiency Test"
		Me.btnStartTest.UseVisualStyleBackColor = True
		'
		'tmrTest
		'
		Me.tmrTest.Interval = 1000
		'
		'txtTestPPower
		'
		Me.txtTestPPower.Location = New System.Drawing.Point(407, 9)
		Me.txtTestPPower.Name = "txtTestPPower"
		Me.txtTestPPower.Size = New System.Drawing.Size(100, 20)
		Me.txtTestPPower.TabIndex = 3
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(316, 12)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(85, 13)
		Me.Label4.TabIndex = 4
		Me.Label4.Text = "980 power [mW]"
		'
		'btnStopTest
		'
		Me.btnStopTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnStopTest.ForeColor = System.Drawing.Color.Red
		Me.btnStopTest.Location = New System.Drawing.Point(12, 54)
		Me.btnStopTest.Name = "btnStopTest"
		Me.btnStopTest.Size = New System.Drawing.Size(142, 23)
		Me.btnStopTest.TabIndex = 5
		Me.btnStopTest.Text = "Stop Test"
		Me.btnStopTest.UseVisualStyleBackColor = True
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(310, 64)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(91, 13)
		Me.Label5.TabIndex = 7
		Me.Label5.Text = "1550 power [mW]"
		'
		'txtTestSPower
		'
		Me.txtTestSPower.Location = New System.Drawing.Point(407, 64)
		Me.txtTestSPower.Name = "txtTestSPower"
		Me.txtTestSPower.Size = New System.Drawing.Size(100, 20)
		Me.txtTestSPower.TabIndex = 6
		'
		'crtResults
		'
		ChartArea1.Name = "ChartArea1"
		Me.crtResults.ChartAreas.Add(ChartArea1)
		Legend1.Name = "Legend1"
		Me.crtResults.Legends.Add(Legend1)
		Me.crtResults.Location = New System.Drawing.Point(18, 109)
		Me.crtResults.Name = "crtResults"
		Series1.ChartArea = "ChartArea1"
		Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
		Series1.Legend = "Legend1"
		Series1.Name = "Efficiency"
		Me.crtResults.Series.Add(Series1)
		Me.crtResults.Size = New System.Drawing.Size(678, 202)
		Me.crtResults.TabIndex = 8
		Me.crtResults.Text = "Chart1"
		'
		'btnOpenExcel
		'
		Me.btnOpenExcel.Location = New System.Drawing.Point(224, 328)
		Me.btnOpenExcel.Name = "btnOpenExcel"
		Me.btnOpenExcel.Size = New System.Drawing.Size(213, 23)
		Me.btnOpenExcel.TabIndex = 9
		Me.btnOpenExcel.Text = "Open Excel for data analysis"
		Me.btnOpenExcel.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(714, 593)
		Me.Controls.Add(Me.btnOpenExcel)
		Me.Controls.Add(Me.crtResults)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.txtTestSPower)
		Me.Controls.Add(Me.btnStopTest)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.txtTestPPower)
		Me.Controls.Add(Me.btnStartTest)
		Me.Controls.Add(Me.GroupBox1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "Form1"
		Me.Text = "Isogain efficiency"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		CType(Me.crtResults, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents txtEngPCur As TextBox
	Friend WithEvents txtEngSCur As TextBox
	Friend WithEvents btnEngPSet As Button
	Friend WithEvents btnEngSSet As Button
	Friend WithEvents btnEngPOn As Button
	Friend WithEvents btnEngSOn As Button
	Friend WithEvents tmrMain As Timer
	Friend WithEvents Label3 As Label
	Friend WithEvents btnStartTest As Button
	Friend WithEvents tmrTest As Timer
	Friend WithEvents txtTestPPower As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents btnStopTest As Button
	Friend WithEvents Label5 As Label
	Friend WithEvents txtTestSPower As TextBox
	Friend WithEvents crtResults As DataVisualization.Charting.Chart
	Friend WithEvents Label1 As Label
	Friend WithEvents btnOpenExcel As Button
End Class
