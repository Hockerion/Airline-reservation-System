Imports IBM.Data.DB2
Public Class Rebook_Flight
    Private ConnVar As Common.DbConnection

    Private Sub Rebook_Flight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim StrLoad As String
        Dim CmdLoad As DB2Command
        Dim RdrLoad As DB2DataReader
        Dim row As String()
        Try

            ConnVar = New DB2Connection("server=localhost;database=airline;" + "uid=db2admin;password=db2admin;")
            ConnVar.Open()
            With Me.DGVRESERVATION
                .ColumnCount = 5
                .Columns(0).Name = "Reservation ID"
                .Columns(1).Name = "Reservation Date"
                .Columns(2).Name = "Pnrno"
                .Columns(3).Name = "Flight ID"
                .Columns(4).Name = "Seat ID"
                .Columns(0).Width = 210
                .Columns(1).Width = 210
                .Columns(2).Width = 210
                .Columns(3).Width = 210
                .Columns(4).Width = 210



            End With
            Me.DGVRESERVATION.ColumnCount = 5

            StrLoad = "select * from reservation"
            CmdLoad = New DB2Command(StrLoad, ConnVar)
            RdrLoad = CmdLoad.ExecuteReader
            While RdrLoad.Read
                row = New String() {RdrLoad.GetString(0), RdrLoad.GetString(1), RdrLoad.GetString(2), RdrLoad.GetString(3), RdrLoad.GetString(4)}
                Me.DGVRESERVATION.Rows.Add(row)
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
            Me.DGVRESERVATION.Rows.Clear()

            StrLoad = "select * from reservation"
            CmdLoad = New DB2Command(StrLoad, ConnVar)
            RdrLoad = CmdLoad.ExecuteReader
            While RdrLoad.Read
                row = New String() {RdrLoad.GetString(0), RdrLoad.GetString(1), RdrLoad.GetString(2), RdrLoad.GetString(3), RdrLoad.GetString(4)}
                Me.DGVRESERVATION.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DGVRESERVATION_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVRESERVATION.MouseUp
        Try
            With Me.DGVRESERVATION

                Me.SEARCHPNRNO.Text = .CurrentRow.Cells(2).Value
                Me.FLIGHTID.Text = .CurrentRow.Cells(3).Value
                Me.SEATID.Text = .CurrentRow.Cells(4).Value


            End With



        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private Sub Panel2CAR_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub RESBACK_Click(sender As Object, e As EventArgs) Handles RESBACK.Click
        Dim back = MAIN
        back.Show()
        Me.Hide()

        Dim StrUpdateSeat As String
        Dim Cmd As DB2Command

        Dim USTATUS As String = "Reserved"

        StrUpdateSeat = "update seat set STATUS = '" & USTATUS & "' where seatid = '" & Me.SEATID.Text & "'"

        Cmd = New DB2Command(StrUpdateSeat, ConnVar)
        Cmd.ExecuteNonQuery()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles VIEWFLIGHTS.Click
        Dim flights = New BOOK
        flights.Show()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles VIEWSEATS.Click
        Dim seats = New Choose_Seat
        seats.Show()

        Dim StrUpdateSeat As String
        Dim Cmd As DB2Command

        Dim OSTATUS As String = "Available"


        ' VVV UPDATING OLD SEAT STATUS VVV


        StrUpdateSeat = "update seat set STATUS = '" & OSTATUS & "' where seatid = '" & Me.SEATID.Text & "'"

        Cmd = New DB2Command(StrUpdateSeat, ConnVar)
        Cmd.ExecuteNonQuery()









    End Sub

    Private Sub SEARCHRESERVATION_TextChanged(sender As Object, e As EventArgs) Handles SEARCHPNRNO.TextChanged
        Dim StrSearch As String
        Dim StrValue As String
        Dim CmdSearch As DB2Command
        Dim RdrSearch As DB2DataReader
        Dim row As String()
        Try
            StrValue = Me.SEARCHPNRNO.Text + "%"
            StrSearch = "Select * from reservation where pnrno like '" & StrValue & "'"
            CmdSearch = New DB2Command(StrSearch, ConnVar)
            RdrSearch = CmdSearch.ExecuteReader

            Me.DGVRESERVATION.Rows.Clear()

            While RdrSearch.Read
                row = New String() {RdrSearch.GetString(0), RdrSearch.GetString(1), RdrSearch.GetString(2), RdrSearch.GetString(3), RdrSearch.GetString(4)}
                Me.DGVRESERVATION.Rows.Add(row)

            End While

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub REBOOKFLI_Click(sender As Object, e As EventArgs) Handles REBOOKFLI.Click
        Dim StrUpdateReservation As String
        Dim CmdUpdateReservation As DB2Command
        Dim StrUpdateSeat As String
        Dim Cmd As DB2Command


        Dim UFLIGHTID As String
        Dim USEATID As String


        Dim URESDATE As Date = Today


        Dim USTATUS As String = "Reserved"


        Try

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to proceed?", "Confirmation", MessageBoxButtons.YesNo)


            If result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then

                UFLIGHTID = Me.FLIGHTID.Text
                USEATID = Me.SEATID.Text



                StrUpdateReservation = "update reservation set RESDATE = '" & URESDATE & "', FLIGHTID = '" & UFLIGHTID & "' , SEATID = '" & USEATID & "'"
                CmdUpdateReservation = New DB2Command(StrUpdateReservation, ConnVar)
                CmdUpdateReservation.ExecuteNonQuery()


                'VVV UPDATING SEAT STATUS VVV

                StrUpdateSeat = "update seat set STATUS = '" & USTATUS & "' where seatid = '" & Me.SEATID.Text & "'"

                Cmd = New DB2Command(StrUpdateSeat, ConnVar)
                Cmd.ExecuteNonQuery()




                Me.FLIGHTID.Clear()
                Me.SEATID.Clear()
                Me.SEARCHPNRNO.Clear()


                MessageBox.Show("The flight was successfully rebooked.", "", MessageBoxButtons.OK)
            End If


        Catch ex As Exception

        End Try

    End Sub


End Class