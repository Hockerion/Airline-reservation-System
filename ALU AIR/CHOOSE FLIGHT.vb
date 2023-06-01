Imports IBM.Data.DB2
Public Class BOOK
    Private ConnVar As Common.DbConnection
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim seat = New Choose_Seat
        seat.Show()
        Me.Hide()

    End Sub

    Private Sub BOOK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim StrLoad As String
        Dim CmdLoad As DB2Command
        Dim RdrLoad As DB2DataReader
        Dim row As String()



        Try

            ConnVar = New DB2Connection("server=localhost;database=airline;" + "uid=db2admin;password=db2admin;")
            ConnVar.Open()
            With Me.DGVFLIGHT
                .ColumnCount = 13
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
            Me.DGVFLIGHT.ColumnCount = 13

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


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Me.Close()

    End Sub
End Class