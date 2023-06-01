Imports IBM.Data.DB2
Public Class RESERVATION
    Private ConnVar As Common.DbConnection
    Private Sub RESERVATION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub ADDRESERVATION_Click(sender As Object, e As EventArgs) Handles ADDRESERVATION.Click
        Dim Cmd As DB2Command
        Try
            Cmd = New DB2Command("insert into reservation values('" & Me.RESID.Text & "','" & Me.RESDATE.Text & "', '" & Me.PNRNO.Text & "', '" & Me.FLIGHTID.Text & "', '" & Me.SEATID.Text & "'
                            )", ConnVar)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("The record was successfully added.", "", MessageBoxButtons.OK)

            Me.RESID.Clear()
            Me.RESDATE.Clear()
            Me.PNRNO.Clear()
            Me.FLIGHTID.Clear()
            Me.SEATID.Clear()








        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub SEARCHRESERVATION_TextChanged(sender As Object, e As EventArgs) Handles SEARCHRESERVATION.TextChanged
        Dim StrSearch As String
        Dim StrValue As String
        Dim CmdSearch As DB2Command
        Dim RdrSearch As DB2DataReader
        Dim row As String()
        Try
            StrValue = Me.SEARCHRESERVATION.Text + "%"
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

    Private Sub DGVRESERVATION_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVRESERVATION.MouseUp
        Try
            With Me.DGVRESERVATION
                Me.RESID.Text = .CurrentRow.Cells(0).Value
                Me.RESDATE.Text = .CurrentRow.Cells(1).Value
                Me.PNRNO.Text = .CurrentRow.Cells(2).Value
                Me.FLIGHTID.Text = .CurrentRow.Cells(3).Value
                Me.SEATID.Text = .CurrentRow.Cells(4).Value








            End With
            Me.RESID.Enabled = False


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub SAVERESERVATION_Click(sender As Object, e As EventArgs) Handles SAVERESERVATION.Click
        Dim StrUpdateReservation As String
        Dim CmdUpdateReservation As DB2Command

        Dim URESID As String
        Dim URESDATE As String
        Dim UPNRNO As String
        Dim UFLIGHTID As String
        Dim USEATID As String



        Try
            URESID = Me.RESID.Text
            URESDATE = Me.RESDATE.Text
            UPNRNO = Me.PNRNO.Text
            UFLIGHTID = Me.FLIGHTID.Text
            USEATID = Me.SEATID.Text




            StrUpdateReservation = "update reservation set RESID = '" & URESID & "', RESDATE = '" & URESDATE & "', PNRNO = '" & UPNRNO & "', FLIGHTID = '" & UFLIGHTID & "' , SEATID = '" & USEATID & "'"
            CmdUpdateReservation = New DB2Command(StrUpdateReservation, ConnVar)
            CmdUpdateReservation.ExecuteNonQuery()
            MessageBox.Show("The record was successfully updated.", "", MessageBoxButtons.OK)
            Me.RESID.Clear()
            Me.RESDATE.Clear()
            Me.PNRNO.Clear()
            Me.FLIGHTID.Clear()
            Me.SEATID.Clear()



            Me.RESID.Focus()
            Call RefreshDataGridView()
            Me.RESVID.Enabled = True


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DELETERESERVATION_Click(sender As Object, e As EventArgs) Handles DELETERESERVATION.Click
        Dim StrDelete As String
        Dim CmdDelete As DB2Command

        Try
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to DELETE this record?", "Confirmation", MessageBoxButtons.YesNo)


            If result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                StrDelete = "delete from reservation where resid = '" & Me.RESID.Text & "'"
                CmdDelete = New DB2Command(StrDelete, ConnVar)
                CmdDelete.ExecuteNonQuery()

                Me.RESID.Clear()
                Me.RESDATE.Clear()
                Me.PNRNO.Clear()
                Me.FLIGHTID.Clear()
                Me.SEATID.Clear()


                Me.RESID.Focus()
                Call RefreshDataGridView()

                MessageBox.Show("The record was successfully deleted.", "", MessageBoxButtons.OK)
            End If



        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub DGVAIRCRAFT_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVRESERVATION.CellContentClick

    End Sub

    Private Sub RESBACK_Click(sender As Object, e As EventArgs) Handles RESBACK.Click
        Dim back = New MAIN
        back.Show()

        Me.Hide()

    End Sub
End Class