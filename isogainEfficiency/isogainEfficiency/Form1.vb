Imports Thorlabs.PM100D_32.Interop
Imports Thorlabs.TL4000

Public Class Form1
    Dim lasSeed, lasPump As TL4000
    Dim pmSeed, pmOut As PM100D
    Dim lisOut, lisSeed, lisPump As New List(Of Double)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lasSeed = New TL4000("")
        lasPump = New TL4000("")
        pmSeed = New PM100D("")
        pmOut = New PM100D("")


    End Sub
End Class
