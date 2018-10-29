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
		Me.btnEngSSet = New System.Windows.Forms.Button()
		Me.btnEngPSet = New System.Windows.Forms.Button()
		Me.txtEngSPow = New System.Windows.Forms.TextBox()
		Me.txtEngPPow = New System.Windows.Forms.TextBox()
		Me.txtEngSCur = New System.Windows.Forms.TextBox()
		Me.txtEngPCur = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
		'txtEngSPow
		'
		Me.txtEngSPow.Location = New System.Drawing.Point(584, 24)
		Me.txtEngSPow.Name = "txtEngSPow"
		Me.txtEngSPow.Size = New System.Drawing.Size(100, 22)
		Me.txtEngSPow.TabIndex = 2
		'
		'txtEngPPow
		'
		Me.txtEngPPow.Location = New System.Drawing.Point(584, 82)
		Me.txtEngPPow.Name = "txtEngPPow"
		Me.txtEngPPow.Size = New System.Drawing.Size(100, 22)
		Me.txtEngPPow.TabIndex = 3
		'
		'txtEngSCur
		'
		Me.txtEngSCur.Location = New System.Drawing.Point(6, 23)
		Me.txtEngSCur.Name = "txtEngSCur"
		Me.txtEngSCur.Size = New System.Drawing.Size(100, 22)
		Me.txtEngSCur.TabIndex = 4
		'
		'txtEngPCur
		'
		Me.txtEngPCur.Location = New System.Drawing.Point(6, 51)
		Me.txtEngPCur.Name = "txtEngPCur"
		Me.txtEngPCur.Size = New System.Drawing.Size(100, 22)
		Me.txtEngPCur.TabIndex = 5
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(487, 26)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(91, 16)
		Me.Label1.TabIndex = 6
		Me.Label1.Text = "Seed power"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(487, 82)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(93, 16)
		Me.Label2.TabIndex = 7
		Me.Label2.Text = "Pump power"
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
End Class
