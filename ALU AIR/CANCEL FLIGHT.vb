Imports IBM.Data.DB2
Public Class Cancel_Flight
    Private ConnVar As Common.DbConnection
    Private Sub Cancel_Flight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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





    Private Sub Back_Click(sender As Object, e As EventArgs)
        Dim back = MAIN
        back.Show()
        Me.Hide()

    End Sub

    Private Sub SAVERESERVATION_Click(sender As Object, e As EventArgs) Handles CANCELFLI.Click
        Dim StrDelete As String
        Dim CmdDelete As DB2Command
        Dim Cmd As DB2Command
        Dim StrUpdateSeat As String

        Dim USTATUS As String = "Available"

        Try
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to CANCEL this flight?", "Confirmation", MessageBoxButtons.YesNo)


            If result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then

                StrDelete = "delete from reservation where pnrno = '" & Me.SEARCHPNRNO.Text & "'"
                CmdDelete = New DB2Command(StrDelete, ConnVar)
                CmdDelete.ExecuteNonQuery()


                Call RefreshDataGridView()

                'vvv UPDATING SEAT STATUS TO AVAILABLE vvv

                StrUpdateSeat = "update seat set STATUS = '" & USTATUS & "' where seatid = '" & Me.SEATID.Text & "'"

                Cmd = New DB2Command(StrUpdateSeat, ConnVar)
                Cmd.ExecuteNonQuery()

                'vvv DELETING CUSTOMER RECORD VVV

                StrDelete = "delete from customer where pnrno = '" & Me.SEARCHPNRNO.Text & "'"
                CmdDelete = New DB2Command(StrDelete, ConnVar)
                CmdDelete.ExecuteNonQuery()


                Me.SEARCHPNRNO.Clear()
                Me.FLIGHTID.Clear()
                Me.SEATID.Clear()


                MessageBox.Show("The flight was successfully canceled.", "", MessageBoxButtons.OK)
            End If



        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub RESBACK_Click(sender As Object, e As EventArgs) Handles RESBACK.Click
        Dim back = New MAIN
        back.Show()
        Me.Hide()

    End Sub

    Private Sub SEARCHPNRNO_TextChanged_1(sender As Object, e As EventArgs) Handles SEARCHPNRNO.TextChanged
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

    Private Sub DGVRESERVATION_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVRESERVATION.CellContentClick

    End Sub
End Class