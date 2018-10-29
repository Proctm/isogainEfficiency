'Imports Thorlabs.PM100D_32.Interop
'Imports Thorlabs.TL4000

Public Class Form1
	'Dim lasSeed, lasPump As TL4000
	'Dim pmSeed, pmOut As PM100D
	Dim seedOn As Boolean = False 'is the laser on or off ?
	Dim pumpOn As Boolean = False
	Dim SCur, PCur As Double



	Private Sub btnEngSOn_Click(sender As Object, e As EventArgs) Handles btnEngSOn.Click
		If seedOn = False Then
			'MsgBox("Ensure that lid is closed")
		End If

		seedOn = Not (seedOn)
		If seedOn = True Then
			btnEngSOn.Text = "Switch seed OFF"
		ElseIf seedOn = False Then
			btnEngSOn.Text = "Switch seed ON"
		End If
	End Sub
	Private Sub btnEngPOn_Click(sender As Object, e As EventArgs) Handles btnEngPOn.Click
		If pumpOn = False Then
			MsgBox("Ensure that lid is closed")
		End If

		pumpOn = Not (pumpOn)
		If pumpOn = True Then
			btnEngPOn.Text = "Switch pump OFF"
		ElseIf pumpOn = False Then
			btnEngPOn.Text = "Switch pump ON"
		End If
	End Sub

	Dim lisOut, lisSeed, lisPump As New List(Of Double)

	Private Sub txtEngSCur_TextChanged(sender As Object, e As EventArgs) Handles txtEngSCur.TextChanged
		'SCur = txtEngSCur.Text
	End Sub
	Private Sub txtEngSCur_keyPress(sender As Object, e As KeyPressEventArgs) Handles txtEngSCur.KeyPress

		If Char.IsControl(e.KeyChar) And Char.IsDigit(e.KeyChar) And e.KeyChar = "." Then
			e.Handled = True
		Else
			e.Handled = False
		End If

		'// only allow one decimal point
		'If ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
		'	{
		'	e.Handled = True;
		'  }
	End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'PCur = txtEngPCur.Text
	End Sub
End Class
