Imports System
Imports System.IO
Imports System.Xml
Imports System.Text
Imports System.Configuration
Imports System.Collections.Generic


Public Class Form1


    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim arTIme As New ArrayList
        arTIme = GetList()

        For i = 0 To arTIme.Count - 1
            RadDropDownList1.Items.Add(arTIme(i).ToString)
        Next
    End Sub

    Function GetList()
        Dim arrTime As New ArrayList
        Dim arTimeSpl(10) As String
        Dim dtTime, dtStpTime As Date
        Dim strTimme As String = ""
        strTimme = "6:00 AM"
        Dim icnt As Integer = 0
        dtTime = Convert.ToDateTime(strTimme)
        dtStpTime = Convert.ToDateTime("11:45 PM")
        arrTime.Add(dtTime.ToString("HH:mm"))
        Do While (dtTime <= dtStpTime)
            dtTime = dtTime.AddMinutes(15)
            arrTime.Add(dtTime.ToString("HH:mm"))
        Loop

        Return arrTime

    End Function

   
End Class
