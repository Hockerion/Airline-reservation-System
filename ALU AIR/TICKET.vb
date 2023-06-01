Imports IBM.Data.DB2
Public Class TICKET
    Private ConnVar As Common.DbConnection
    Private Sub TICKET_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim StrLoad As String
        Dim CmdLoad As DB2Command
        Dim RdrLoad As DB2DataReader
        Dim row As String()
        Try

            ConnVar = New DB2Connection("server=localhost;database=airline;" + "uid=db2admin;password=db2admin;")
            ConnVar.Open()
            With Me.DGVTICKET
                .ColumnCount = 5
                .Columns(0).Name = "Ticket ID"
                .Columns(1).Name = "Date Issued"
                .Columns(2).Name = "Pnrno"
                .Columns(3).Name = "Flight ID"
                .Columns(4).Name = "Seat ID"
                .Columns(0).Width = 210
                .Columns(1).Width = 210
                .Columns(2).Width = 210
                .Columns(3).Width = 210
                .Columns(4).Width = 210




            End With
            Me.DGVTICKET.ColumnCount = 5

            StrLoad = "select * from ticket"
            CmdLoad = New DB2Command(StrLoad, ConnVar)
            RdrLoad = CmdLoad.ExecuteReader
            While RdrLoad.Read
                row = New String() {RdrLoad.GetString(0), RdrLoad.GetString(1), RdrLoad.GetString(2), RdrLoad.GetString(3), RdrLoad.GetString(4)}
                Me.DGVTICKET.Rows.Add(row)
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
            Me.DGVTICKET.Rows.Clear()

            StrLoad = "select * from ticket"
            CmdLoad = New DB2Command(StrLoad, ConnVar)
            RdrLoad = CmdLoad.ExecuteReader
            While RdrLoad.Read
                row = New String() {RdrLoad.GetString(0), RdrLoad.GetString(1), RdrLoad.GetString(2), RdrLoad.GetString(3), RdrLoad.GetString(4)}
                Me.DGVTICKET.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ADDTICKET_Click(sender As Object, e As EventArgs) Handles ADDTICKET.Click
        Dim Cmd As DB2Command
        Try
            Cmd = New DB2Command("insert into ticket values('" & Me.TICKETID.Text & "','" & Me.DATEISSUED.Text & "', '" & Me.PNRNO.Text & "','" & Me.FLIGHTID.Text & "','" & Me.SEATID.Text & "'
                            )", ConnVar)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("The record was successfully added.", "", MessageBoxButtons.OK)

            Me.TICKETID.Clear()
            Me.DATEISSUED.Clear()
            Me.PNRNO.Clear()
            Me.FLIGHTID.Clear()
            Me.SEATID.Clear()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub SEARCHTICKET_TextChanged(sender As Object, e As EventArgs) Handles SEARCHTICKET.TextChanged
        Dim StrSearch As String
        Dim StrValue As String
        Dim CmdSearch As DB2Command
        Dim RdrSearch As DB2DataReader
        Dim row As String()
        Try
            StrValue = Me.SEARCHTICKET.Text + "%"
            StrSearch = "Select * from ticket  where pnrno like '" & StrValue & "'"
            CmdSearch = New DB2Command(StrSearch, ConnVar)
            RdrSearch = CmdSearch.ExecuteReader

            Me.DGVTICKET.Rows.Clear()

            While RdrSearch.Read
                row = New String() {RdrSearch.GetString(0), RdrSearch.GetString(1), RdrSearch.GetString(2), RdrSearch.GetString(3), RdrSearch.GetString(4)}
                Me.DGVTICKET.Rows.Add(row)

            End While

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub DGVTICKET_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVTICKET.MouseUp
        Try
            With Me.DGVTICKET
                Me.TICKETID.Text = .CurrentRow.Cells(0).Value
                Me.DATEISSUED.Text = .CurrentRow.Cells(1).Value
                Me.PNRNO.Text = .CurrentRow.Cells(2).Value
                Me.FLIGHTID.Text = .CurrentRow.Cells(3).Value
                Me.SEATID.Text = .CurrentRow.Cells(4).Value










            End With
            Me.TICKETID.Enabled = False


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub SAVETICKET_Click(sender As Object, e As EventArgs) Handles SAVETICKET.Click
        Dim StrUpdateTicket As String
        Dim CmdUpdateTicket As DB2Command

        Dim UTICKETID As String
        Dim UDATEISSUED As String
        Dim UPNRNO As String
        Dim UFLIGHTID As String
        Dim USEATID As String




        Try
            UTICKETID = Me.TICKETID.Text
            UDATEISSUED = Me.DATEISSUED.Text
            UPNRNO = Me.PNRNO.Text
            UFLIGHTID = Me.FLIGHTID.Text
            USEATID = Me.SEATID.Text


            StrUpdateTicket = "update ticket set TICKETID = '" & UTICKETID & "', DATEISSUED = '" & UDATEISSUED & "', PNRNO = '" & UPNRNO & "', FLIGHTID = '" & UFLIGHTID & "', SEATID = '" & USEATID & "'"
            CmdUpdateTicket = New DB2Command(StrUpdateTicket, ConnVar)
            CmdUpdateTicket.ExecuteNonQuery()
            MessageBox.Show("The record was successfully updated.", "", MessageBoxButtons.OK)
            Me.TICKETID.Clear()
            Me.DATEISSUED.Clear()
            Me.PNRNO.Clear()
            Me.FLIGHTID.Clear()
            Me.SEATID.Clear()





            Me.TICKETID.Focus()
            Call RefreshDataGridView()
            Me.TICKETID.Enabled = True


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DELETETICKET_Click(sender As Object, e As EventArgs) Handles DELETETICKET.Click
        Dim StrDelete As String
        Dim CmdDelete As DB2Command

        Try
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to DELETE this record?", "Confirmation", MessageBoxButtons.YesNo)


            If result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                StrDelete = "delete from ticket where ticketid = '" & Me.TICKETID.Text & "'"
                CmdDelete = New DB2Command(StrDelete, ConnVar)
                CmdDelete.ExecuteNonQuery()

                Me.TICKETID.Clear()
                Me.DATEISSUED.Clear()
                Me.PNRNO.Clear()
                Me.FLIGHTID.Clear()
                Me.SEATID.Clear()





                Me.TICKETID.Focus()
                Call RefreshDataGridView()

                MessageBox.Show("The record was successfully deleted.", "", MessageBoxButtons.OK)
            End If



        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub DGVAIRCRAFT_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVTICKET.CellContentClick

    End Sub

    Private Sub TICKBACK_Click(sender As Object, e As EventArgs) Handles TICKBACK.Click
        Dim back = New MAIN
        back.Show()
        Me.Hide()

    End Sub
End Class