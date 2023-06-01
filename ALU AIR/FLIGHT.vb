Imports IBM.Data.DB2
Public Class FLIGHT
    Private ConnVar As Common.DbConnection
    Private Sub FLIGHT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim StrLoad As String
        Dim CmdLoad As DB2Command
        Dim RdrLoad As DB2DataReader
        Dim row As String()



        Try

            ConnVar = New DB2Connection("server=localhost;database=airline;" + "uid=db2admin;password=db2admin;")
            ConnVar.Open()
            With Me.DGVFLIGHT
                .ColumnCount = 12
                .Columns(0).Name = "Flight ID"
                .Columns(1).Name = "Origin"
                .Columns(2).Name = "Destination"
                .Columns(3).Name = "Flight Type"
                .Columns(4).Name = "Route"
                .Columns(5).Name = "Departure Data"
                .Columns(6).Name = "Departure Time"
                .Columns(7).Name = "Arrival Date"
                .Columns(8).Name = "Arrival Time"
                .Columns(9).Name = "Duration (Hour/s)"
                .Columns(10).Name = "Fare"
                .Columns(11).Name = "Aircraft ID"
            End With
            Me.DGVFLIGHT.ColumnCount = 12

            StrLoad = "select * from flight"
            CmdLoad = New DB2Command(StrLoad, ConnVar)
            RdrLoad = CmdLoad.ExecuteReader
            While RdrLoad.Read
                row = New String() {RdrLoad.GetString(0), RdrLoad.GetString(1), RdrLoad.GetString(2), RdrLoad.GetString(3), RdrLoad.GetString(4),
                    RdrLoad.GetString(5), RdrLoad.GetString(6), RdrLoad.GetString(7), RdrLoad.GetString(8), RdrLoad.GetString(9), RdrLoad.GetString(10),
                    RdrLoad.GetString(11)}
                Me.DGVFLIGHT.Rows.Add(row)
            End While


            Call RefreshDataGridView()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    Private Sub RefreshDataGridView()
        Dim StrLoad As String
        Dim CmdLoad As DB2Command
        Dim RdrLoad As DB2DataReader
        Dim row As String()
        Try
            Me.DGVFLIGHT.Rows.Clear()

            StrLoad = "select * from flight"
            CmdLoad = New DB2Command(StrLoad, ConnVar)
            RdrLoad = CmdLoad.ExecuteReader
            While RdrLoad.Read
                row = New String() {RdrLoad.GetString(0), RdrLoad.GetString(1), RdrLoad.GetString(2), RdrLoad.GetString(3), RdrLoad.GetString(4),
                    RdrLoad.GetString(5), RdrLoad.GetString(6), RdrLoad.GetString(7), RdrLoad.GetString(8), RdrLoad.GetString(9), RdrLoad.GetString(10),
                    RdrLoad.GetString(11)}
                Me.DGVFLIGHT.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub SEARCHFLI_TextChanged(sender As Object, e As EventArgs) Handles SEARCHFLI.TextChanged
        Dim StrSearch As String
        Dim StrValue As String
        Dim CmdSearch As DB2Command
        Dim RdrSearch As DB2DataReader
        Dim row As String()
        Try
            StrValue = Me.SEARCHFLI.Text + "%"
            StrSearch = "Select * from flight where destination like '" & StrValue & "'"
            CmdSearch = New DB2Command(StrSearch, ConnVar)
            RdrSearch = CmdSearch.ExecuteReader

            Me.DGVFLIGHT.Rows.Clear()

            While RdrSearch.Read
                row = New String() {RdrSearch.GetString(0), RdrSearch.GetString(1), RdrSearch.GetString(2), RdrSearch.GetString(3), RdrSearch.GetString(4),
                    RdrSearch.GetString(5), RdrSearch.GetString(6), RdrSearch.GetString(7), RdrSearch.GetString(8), RdrSearch.GetString(9), RdrSearch.GetString(10),
                    RdrSearch.GetString(11)}
                Me.DGVFLIGHT.Rows.Add(row)

            End While

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub DGVFLIGHT_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVFLIGHT.MouseUp
        Try
            With Me.DGVFLIGHT
                Me.FLIGHTID.Text = .CurrentRow.Cells(0).Value
                Me.ORIGIN.Text = .CurrentRow.Cells(1).Value
                Me.DESTINATION.Text = .CurrentRow.Cells(2).Value
                Me.FLIGHTTYPE.Text = .CurrentRow.Cells(3).Value
                Me.ROUTE.Text = .CurrentRow.Cells(4).Value
                Me.DEPDATE.Text = .CurrentRow.Cells(5).Value
                Me.DEPPTIME.Text = .CurrentRow.Cells(6).Value
                Me.ARRDATE.Text = .CurrentRow.Cells(7).Value
                Me.ARRRTIME.Text = .CurrentRow.Cells(8).Value
                Me.DURATION.Text = .CurrentRow.Cells(9).Value
                Me.FARE.Text = .CurrentRow.Cells(10).Value
                Me.AIRCRAFTID.Text = .CurrentRow.Cells(11).Value







            End With
            Me.FLIGHTID.Enabled = False


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub ADDFLI_Click(sender As Object, e As EventArgs) Handles ADDFLI.Click
        Dim Cmd As DB2Command

        Dim atime = DateTime.Parse(Me.ARRRTIME.Text)
        Dim dtime = DateTime.Parse(Me.DEPPTIME.Text)

        Dim result = atime - dtime

        Dim differenceInHours = result.Hours

        If differenceInHours < 0 Then
            Me.DURATION.Text = differenceInHours * -1
        Else
            Me.DURATION.Text = differenceInHours

        End If



        Try
            Cmd = New DB2Command("insert into flight values('" & Me.FLIGHTID.Text & "','" & Me.ORIGIN.Text & "', '" & Me.DESTINATION.Text & "', '" & Me.FLIGHTTYPE.Text & "', 
                            '" & Me.ROUTE.Text & "', '" & Me.DEPDATE.Value & "', '" & Me.DEPPTIME.Text & "', '" & Me.ARRDATE.Value & "', '" & Me.ARRRTIME.Text & "', '" & Me.DURATION.Text & "',
                            '" & Me.FARE.Text & "', '" & Me.AIRCRAFTID.Text & "'
                            )", ConnVar)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("The record was successfully added.", "", MessageBoxButtons.OK)
            Me.FLIGHTID.Clear()
            Me.ORIGIN.Clear()
            Me.DESTINATION.Clear()
            Me.FLIGHTTYPE.Clear()
            Me.ROUTE.Clear()
            'Me.DEPDATE.Clear()
            Me.DEPPTIME.Clear()
            'Me.ARRDATE.Clear()
            Me.ARRRTIME.Clear()
            Me.DURATION.Clear()
            Me.FARE.Clear()
            Me.AIRCRAFTID.Clear()




        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub SAVEFLI_Click(sender As Object, e As EventArgs) Handles SAVEFLI.Click
        Dim StrUpdateFlight As String
        Dim CmdUpdateFlight As DB2Command

        Dim atime = DateTime.Parse(Me.ARRRTIME.Text)
        Dim dtime = DateTime.Parse(Me.DEPPTIME.Text)

        Dim result = atime - dtime

        Dim differenceInHours = result.Hours

        If differenceInHours < 0 Then
            Me.DURATION.Text = differenceInHours * -1
        Else
            Me.DURATION.Text = differenceInHours

        End If






        Dim UFLIGHTID As String
        Dim UORIGIN As String
        Dim UDESTINATION As String
        Dim UFLIGHTTYPE As String
        Dim UROUTE As String
        Dim UDEPDATE As String
        Dim UDEPTIME As String
        Dim UARRDATE As String
        Dim UARRTIME As String
        Dim UDURATION As String
        Dim UFARE As String
        Dim UAIRCRAFTID As String


        Try
            UFLIGHTID = Me.FLIGHTID.Text
            UORIGIN = Me.ORIGIN.Text
            UDESTINATION = Me.DESTINATION.Text
            UFLIGHTTYPE = Me.FLIGHTTYPE.Text
            UROUTE = Me.ROUTE.Text
            UDEPDATE = Me.DEPDATE.Value
            UDEPTIME = Me.DEPPTIME.Text
            UARRDATE = Me.ARRDATE.Value
            UARRTIME = Me.ARRRTIME.Text
            UDURATION = Me.DURATION.Text
            UFARE = Me.FARE.Text
            UAIRCRAFTID = Me.AIRCRAFTID.Text


            StrUpdateFlight = "update flight set FLIGHTID = '" & UFLIGHTID & "', ORIGIN = '" & UORIGIN & "', DESTINATION = '" & UDESTINATION & "'," _
                              & "FLIGHTTYPE = '" & UFLIGHTTYPE & "', ROUTE = '" & UROUTE & "', DEPDATE = '" & UDEPDATE & "', DEPTIME = '" & UDEPTIME & "'," _
                              & " ARRDATE = '" & UARRDATE & "', ARRTIME = '" & UARRTIME & "', DURATION = '" & UDURATION & "', FARE = '" & UFARE & "'," _
                              & " AIRCRAFTID = '" & UAIRCRAFTID & "' where FLIGHTID = '" & UFLIGHTID & "'"

            CmdUpdateFlight = New DB2Command(StrUpdateFlight, ConnVar)
            CmdUpdateFlight.ExecuteNonQuery()
            MessageBox.Show("The record was successfully updated.", "", MessageBoxButtons.OK)
            Me.FLIGHTID.Clear()
            Me.ORIGIN.Clear()
            Me.DESTINATION.Clear()
            Me.FLIGHTTYPE.Clear()
            Me.ROUTE.Clear()
            'Me.DEPDATE.Clear()
            Me.DEPPTIME.Clear()
            'Me.ARRDATE.Clear()
            Me.ARRRTIME.Clear()
            Me.DURATION.Clear()
            Me.FARE.Clear()

            Me.AIRCRAFTID.Clear()
            Me.FLIGHTID.Focus()
            Call RefreshDataGridView()
            Me.FLIGHTID.Enabled = True


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DELETEFLI_Click(sender As Object, e As EventArgs) Handles DELETEFLI.Click
        Dim StrDelete As String
        Dim CmdDelete As DB2Command

        Try
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to DELETE this record?", "Confirmation", MessageBoxButtons.YesNo)


            If result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then

                StrDelete = "delete from flight where flightid = '" & Me.FLIGHTID.Text & "'"
                CmdDelete = New DB2Command(StrDelete, ConnVar)
                CmdDelete.ExecuteNonQuery()

                Me.FLIGHTID.Clear()
                Me.ORIGIN.Clear()
                Me.DESTINATION.Clear()
                Me.FLIGHTTYPE.Clear()
                Me.ROUTE.Clear()
                'Me.DEPDATE.Clear()
                'Me.DEPPTIME.Clear()
                'Me.ARRDATE.Clear()
                'Me.ARRRTIME.Clear()
                Me.DURATION.Clear()
                Me.FARE.Clear()

                Me.AIRCRAFTID.Clear()
                Me.FLIGHTID.Focus()
                Call RefreshDataGridView()


                MessageBox.Show("The record was successfully deleted.", "", MessageBoxButtons.OK)
            End If



        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub DGVFLIGHT_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVFLIGHT.CellContentClick

    End Sub

    Private Sub FLIBACK_Click(sender As Object, e As EventArgs) Handles FLIBACK.Click
        Dim back = New MAIN
        back.Show()

        Me.Hide()

    End Sub

    Private Sub DURATION_TextChanged(sender As Object, e As EventArgs) Handles DURATION.TextChanged

































    End Sub

    Private Sub ARRTIME_ValueChanged(sender As Object, e As EventArgs)

    End Sub
End Class