<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.btnEngPOn = New System.Windows.Forms.Button()
		Me.btnEngSOn = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtEngPCur = New System.Windows.Forms.TextBox()
		Me.txtEngSCur = New System.Windows.Forms.TextBox()
		Me.txtEngPPow = New System.Windows.Forms.TextBox()
		Me.txtEngSPow = New System.Windows.Forms.TextBox()
		Me.btnEngPSet = New System.Windows.Forms.Button()
		Me.btnEngSSet = New System.Windows.Forms.Button()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GroupBox1.Controls.Add(Me.btnEngPOn)
		Me.GroupBox1.Controls.Add(Me.btnEngSOn)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Controls.Add(Me.txtEngPCur)
		Me.GroupBox1.Controls.Add(Me.txtEngSCur)
		Me.GroupBox1.Controls.Add(Me.txtEngPPow)
		Me.GroupBox1.Controls.Add(Me.txtEngSPow)
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
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(504, 82)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(76, 13)
		Me.Label2.TabIndex = 7
		Me.Label2.Text = "Pump power"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(504, 24)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(74, 13)
		Me.Label1.TabIndex = 6
		Me.Label1.Text = "Seed power"
		'
		'txtEngPCur
		'
		Me.txtEngPCur.Location = New System.Drawing.Point(6, 51)
		Me.txtEngPCur.Name = "txtEngPCur"
		Me.txtEngPCur.Size = New System.Drawing.Size(100, 22)
		Me.txtEngPCur.TabIndex = 5
		'
		'txtEngSCur
		'
		Me.txtEngSCur.Location = New System.Drawing.Point(6, 23)
		Me.txtEngSCur.Name = "txtEngSCur"
		Me.txtEngSCur.Size = New System.Drawing.Size(100, 22)
		Me.txtEngSCur.TabIndex = 4
		'
		'txtEngPPow
		'
		Me.txtEngPPow.Location = New System.Drawing.Point(584, 82)
		Me.txtEngPPow.Name = "txtEngPPow"
		Me.txtEngPPow.Size = New System.Drawing.Size(100, 22)
		Me.txtEngPPow.TabIndex = 3
		'
		'txtEngSPow
		'
		Me.txtEngSPow.Location = New System.Drawing.Point(584, 24)
		Me.txtEngSPow.Name = "txtEngSPow"
		Me.txtEngSPow.Size = New System.Drawing.Size(100, 22)
		Me.txtEngSPow.TabIndex = 2
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
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(714, 593)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents txtEngPCur As TextBox
	Friend WithEvents txtEngSCur As TextBox
	Friend WithEvents txtEngPPow As TextBox
	Friend WithEvents txtEngSPow As TextBox
	Friend WithEvents btnEngPSet As Button
	Friend WithEvents btnEngSSet As Button
	Friend WithEvents btnEngPOn As Button
	Friend WithEvents btnEngSOn As Button
End Class
