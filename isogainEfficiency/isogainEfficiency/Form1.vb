Imports Thorlabs.PM100D_32.Interop
Imports Thorlabs.TL4000

Public Class Form1
    Dim lasSeed, lasPump As TL4000
    Dim pm980 As New PM100D("USB0::0x1313::0x8072::P2008967::0::INSTR", True, True)
    Dim pm1550 As New PM100D("USB0::0x1313::0x8072::P2007348::0::INSTR", True, True)
    Dim seedOn As Boolean = False 'is the laser on or off ?
	Dim pumpOn As Boolean = False
    Dim SCur, PCur As Double
    Dim calB1, calIntercept As Double
    Dim listPumpPower As New List(Of Double)(New Double() {100, 200, 300, 400, 500, 600})
    Dim listPumpCurrent As New List(Of Double)
    Dim testCount, testIndex, testSwitch As Int16
    Dim pwr1550Test, pwr980Test As Double
    Dim pwr980, pwr1550 As Decimal
    Dim list980Power, list1550Power As New List(Of Double)

    'Dim lisOut, lisSeed, lisPump As New List(Of Double)






    Private Sub btnEngSOn_Click(sender As Object, e As EventArgs) Handles btnEngSOn.Click
		If seedOn = False Then
			'MsgBox("Ensure that lid is closed")
		End If

		seedOn = Not (seedOn)
        If seedOn = True Then
            btnEngSOn.Text = "Switch seed OFF"
            txtEngSPow.Text = "test"
            lasSeed.switchLdOutput(True)
        ElseIf seedOn = False Then
            btnEngSOn.Text = "Switch seed ON"
            lasSeed.switchLdOutput(False)
        End If
    End Sub
    Private Sub btnEngPOn_Click(sender As Object, e As EventArgs) Handles btnEngPOn.Click
        If pumpOn = False Then
            MsgBox("Ensure that lid is closed")
        End If

        pumpOn = Not (pumpOn)
        If pumpOn = True Then
            btnEngPOn.Text = "Switch pump OFF"
            lasPump.switchLdOutput(True)
        ElseIf pumpOn = False Then
            btnEngPOn.Text = "Switch pump ON"
            lasPump.switchLdOutput(False)
        End If
    End Sub

    Private Sub tmrMain_Tick(sender As Object, e As EventArgs) Handles tmrMain.Tick
        pm1550.measPower(pwr1550)
        pm980.measPower(pwr980)
        pwr1550 = Decimal.Round(pwr1550 * 1000, 1)
        pwr980 = Decimal.Round(pwr980 * 1000, 1)

        txtTestPPower.Text = pwr980
        txtTestSPower.Text = pwr1550
    End Sub

    Private Sub btnEngSSet_Click(sender As Object, e As EventArgs) Handles btnEngSSet.Click
        Dim seedCur As Double
        seedCur = txtEngSCur.Text / 1000
        lasSeed.setLdCurrSetpoint(seedCur)
    End Sub

    Private Sub btnStopTest_Click(sender As Object, e As EventArgs) Handles btnStopTest.Click
        tmrTest.Stop()
        testIndex = 0
        lasPump.setLdCurrSetpoint(0.01)
        lasPump.switchLdOutput(0)
        lasSeed.switchLdOutput(0)
        For Each entry In list1550Power
            cmb1.Items.Add(entry)
        Next
        For Each entry In list980Power
            cmb2.Items.Add(entry)
        Next

    End Sub

    Private Sub btnStartTest_Click(sender As Object, e As EventArgs) Handles btnStartTest.Click
        tmrTest.Start()
    End Sub



    Private Sub btnEngPSet_Click(sender As Object, e As EventArgs) Handles btnEngPSet.Click
        Dim pumpCur As Double
        pumpCur = txtEngPCur.Text / 1000
        lasPump.setLdCurrSetpoint(pumpCur)
    End Sub

    Private Sub tmrTest_Tick(sender As Object, e As EventArgs) Handles tmrTest.Tick
        If testSwitch = 0 Then
            testIndex = 0
            lasPump.setLdCurrSetpoint(listPumpCurrent(0))
            lasSeed.switchLdOutput(1)
            lasPump.switchLdOutput(1)

        End If
        testSwitch = 1
        If testCount = 10 Then
            list980Power.Add(pwr980)
            list1550Power.Add(pwr1550)
            testIndex += 1
            Dim pumpCurrent As Double = listPumpCurrent(testIndex)
            lasPump.setLdCurrSetpoint(pumpCurrent)
            testCount = 0

        End If
        If testIndex = 6 Then
            lasPump.setLdCurrSetpoint(0.01)
            lasPump.switchLdOutput(0)
            lasSeed.switchLdOutput(0)
            tmrTest.Stop()
            testSwitch = 0
        End If
        testCount += 1


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
        tmrMain.Start()
        lasSeed = New TL4000("USB::4883::32847::M00280750::INSTR", True, False)
        lasPump = New TL4000("USB0::0x1313::0x804F::M00280970::0::INSTR", True, False)
        lasSeed.getLdCurrSetpoint(0, SCur)
        lasPump.getLdCurrSetpoint(0, PCur)
        txtEngSCur.Text = SCur * 1000
        txtEngPCur.Text = PCur * 1000
        lasPump.setLdCurrLimit(1.1)
        pm980.setWavelength(980)
        pm1550.setWavelength(1550)
        calB1 = 0.699
        calIntercept = -41.047
        For Each num In listPumpPower
            listPumpCurrent.Add((num - calIntercept) / (1000 * calB1))
        Next
        For Each num In listPumpCurrent
            cmbTest.Items.Add(num)
        Next
        testSwitch = 0


    End Sub
    Private Sub Form1_close(sender As Object, e As EventArgs) Handles MyBase.Closed
        lasSeed.switchLdOutput(0)
        lasPump.switchLdOutput(0)
    End Sub
End Class
