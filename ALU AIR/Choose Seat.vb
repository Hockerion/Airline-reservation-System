Imports IBM.Data.DB2
Public Class Choose_Seat
    Private ConnVar As Common.DbConnection
    Private Sub Choose_Seat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub SEARCHSEAT_TextChanged(sender As Object, e As EventArgs) Handles SEARCHCLASS.TextChanged
        Dim StrSearch As String
        Dim StrValue As String
        Dim CmdSearch As DB2Command
        Dim RdrSearch As DB2DataReader
        Dim row As String()
        Try
            StrValue = Me.SEARCHCLASS.Text + "%"
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
    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim book = New BOOK
        book.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub


End Class