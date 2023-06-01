Imports IBM.Data.DB2
Public Class Seat
    Private ConnVar As Common.DbConnection
    Private Sub Seat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim StrLoad As String
        Dim CmdLoad As DB2Command
        Dim RdrLoad As DB2DataReader
        Dim row As String()
        Try

            ConnVar = New DB2Connection("server=localhost;database=airline;" + "uid=db2admin;password=db2admin;")
            ConnVar.Open()
            With Me.DGVSEAT
                .ColumnCount = 3
                .Columns(0).Name = "Seat ID"
                .Columns(1).Name = "Class"
                .Columns(2).Name = "Status"
                .Columns(0).Width = 350
                .Columns(1).Width = 350
                .Columns(2).Width = 350

            End With

            Me.DGVSEAT.ColumnCount = 3

            StrLoad = "select * from seat"
            CmdLoad = New DB2Command(StrLoad, ConnVar)
            RdrLoad = CmdLoad.ExecuteReader
            While RdrLoad.Read
                row = New String() {RdrLoad.GetString(0), RdrLoad.GetString(1), RdrLoad.GetString(2)}
                Me.DGVSEAT.Rows.Add(row)
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
            Me.DGVSEAT.Rows.Clear()

            StrLoad = "select * from seat"
            CmdLoad = New DB2Command(StrLoad, ConnVar)
            RdrLoad = CmdLoad.ExecuteReader
            While RdrLoad.Read
                row = New String() {RdrLoad.GetString(0), RdrLoad.GetString(1), RdrLoad.GetString(2)}
                Me.DGVSEAT.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub SEARCHSEAT_TextChanged(sender As Object, e As EventArgs) Handles SEARCHSEAT.TextChanged
        Dim StrSearch As String
        Dim StrValue As String
        Dim CmdSearch As DB2Command
        Dim RdrSearch As DB2DataReader
        Dim row As String()
        Try
            StrValue = Me.SEARCHSEAT.Text + "%"
            StrSearch = "Select * from seat where class like '" & StrValue & "'"
            CmdSearch = New DB2Command(StrSearch, ConnVar)
            RdrSearch = CmdSearch.ExecuteReader

            Me.DGVSEAT.Rows.Clear()

            While RdrSearch.Read
                row = New String() {RdrSearch.GetString(0), RdrSearch.GetString(1), RdrSearch.GetString(2)}
                Me.DGVSEAT.Rows.Add(row)

            End While

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub DGVSEAT_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVSEAT.MouseUp
        Try
            With Me.DGVSEAT
                Me.SEATID.Text = .CurrentRow.Cells(0).Value
                Me.CLASSS.Text = .CurrentRow.Cells(1).Value
                Me.STATUS.Text = .CurrentRow.Cells(2).Value

            End With
            Me.SEATID.Enabled = False


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub ADDSEAT_Click(sender As Object, e As EventArgs) Handles ADDSEAT.Click
        Dim Cmd As DB2Command
        Try
            Cmd = New DB2Command("insert into seat values('" & Me.SEATID.Text & "','" & Me.CLASSS.Text & "', '" & Me.STATUS.Text & "'
                            )", ConnVar)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("The record was successfully added.", "", MessageBoxButtons.OK)
            Me.SEATID.Clear()
            Me.CLASSS.Clear()
            Me.STATUS.Clear()



        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub SAVESEAT_Click(sender As Object, e As EventArgs) Handles SAVESEAT.Click
        Dim StrUpdateSeat As String
        Dim CmdUpdateSeat As DB2Command

        Dim USEATID As String
        Dim UCLASSS As String
        Dim USTATUS As String



        Try
            USEATID = Me.SEATID.Text
            UCLASSS = Me.CLASSS.Text
            USTATUS = Me.STATUS.Text



            StrUpdateSeat = "update seat set seatID = '" & USEATID & "', CLASS = '" & UCLASSS & "', STATUS = '" & USTATUS & "'"

            CmdUpdateSeat = New DB2Command(StrUpdateSeat, ConnVar)
            CmdUpdateSeat.ExecuteNonQuery()
            MessageBox.Show("The record was successfully updated.", "", MessageBoxButtons.OK)
            Me.SEATID.Clear()
            Me.CLASSS.Clear()
            Me.STATUS.Clear()

            Me.SEATID.Focus()
            Call RefreshDataGridView()
            Me.SEATID.Enabled = True


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DELETESEAT_Click(sender As Object, e As EventArgs) Handles DELETESEAT.Click
        Dim StrDelete As String
        Dim CmdDelete As DB2Command

        Try
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to DELETE this record?", "Confirmation", MessageBoxButtons.YesNo)


            If result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then

                StrDelete = "delete from seat where seatid = '" & Me.SEATID.Text & "'"
                CmdDelete = New DB2Command(StrDelete, ConnVar)
                CmdDelete.ExecuteNonQuery()

                Me.SEATID.Clear()
                Me.CLASSS.Clear()
                Me.STATUS.Clear()

                Me.SEATID.Focus()
                Call RefreshDataGridView()


                MessageBox.Show("The record was successfully deleted.", "", MessageBoxButtons.OK)
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub



    Private Sub SEATBACK_Click_1(sender As Object, e As EventArgs) Handles SEATBACK.Click
        Dim back = New MAIN
        back.Show()

        Me.Hide()

    End Sub
End Class