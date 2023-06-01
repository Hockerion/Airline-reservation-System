Imports IBM.Data.DB2
Public Class AIRCRAFT
    Private ConnVar As Common.DbConnection
    Private Sub AIRCRAFT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim StrLoad As String
        Dim CmdLoad As DB2Command
        Dim RdrLoad As DB2DataReader
        Dim row As String()
        Try



            ConnVar = New DB2Connection("server=localhost;database=airline;" + "uid=db2admin;password=db2admin;")
            ConnVar.Open()
            With Me.DGVAIRCRAFT
                .ColumnCount = 2
                .Columns(0).Name = "Aircraft ID"
                .Columns(1).Name = "Capacity"
                .Columns(0).Width = 520
                .Columns(1).Width = 520

            End With
            Me.DGVAIRCRAFT.ColumnCount = 2

            StrLoad = "select * from aircraft"
            CmdLoad = New DB2Command(StrLoad, ConnVar)
            RdrLoad = CmdLoad.ExecuteReader
            While RdrLoad.Read
                row = New String() {RdrLoad.GetString(0), RdrLoad.GetString(1)}
                Me.DGVAIRCRAFT.Rows.Add(row)
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
            Me.DGVAIRCRAFT.Rows.Clear()

            StrLoad = "select * from aircraft"
            CmdLoad = New DB2Command(StrLoad, ConnVar)
            RdrLoad = CmdLoad.ExecuteReader
            While RdrLoad.Read
                row = New String() {RdrLoad.GetString(0), RdrLoad.GetString(1)}
                Me.DGVAIRCRAFT.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ADDAIRCRAFT_Click(sender As Object, e As EventArgs) Handles ADDAIRCRAFT.Click
        Dim Cmd As DB2Command
        Try
            Cmd = New DB2Command("insert into aircraft values('" & Me.AIRCRAFTID.Text & "','" & Me.CAPACITY.Text & "'
                            )", ConnVar)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("The record was successfully added.", "", MessageBoxButtons.OK)

            Me.AIRCRAFTID.Clear()
            Me.CAPACITY.Clear()





        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub SEARCHAIRCRAFT_TextChanged(sender As Object, e As EventArgs) Handles SEARCHAIRCRAFT.TextChanged
        Dim StrSearch As String
        Dim StrValue As String
        Dim CmdSearch As DB2Command
        Dim RdrSearch As DB2DataReader
        Dim row As String()
        Try
            StrValue = Me.SEARCHAIRCRAFT.Text + "%"
            StrSearch = "Select * from aircraft where aircraftid like '" & StrValue & "'"
            CmdSearch = New DB2Command(StrSearch, ConnVar)
            RdrSearch = CmdSearch.ExecuteReader

            Me.DGVAIRCRAFT.Rows.Clear()

            While RdrSearch.Read
                row = New String() {RdrSearch.GetString(0), RdrSearch.GetString(1)}
                Me.DGVAIRCRAFT.Rows.Add(row)

            End While

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub DGVAIRCRAFT_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVAIRCRAFT.MouseUp
        Try
            With Me.DGVAIRCRAFT
                Me.AIRCRAFTID.Text = .CurrentRow.Cells(0).Value
                Me.CAPACITY.Text = .CurrentRow.Cells(1).Value








            End With
            Me.AIRCRAFTID.Enabled = False


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub SAVEAIRCRAFT_Click(sender As Object, e As EventArgs) Handles SAVEAIRCRAFT.Click
        Dim StrUpdateAircraft As String
        Dim CmdUpdateAircraft As DB2Command

        Dim UAIRCRAFTID As String
        Dim UCAPACITY As Integer



        Try
            UAIRCRAFTID = Me.AIRCRAFTID.Text
            UCAPACITY = Me.CAPACITY.Text



            StrUpdateAircraft = "update aircraft set AIRCRAFTID = '" & UAIRCRAFTID & "', CAPACITY = '" & UCAPACITY & "'"
            CmdUpdateAircraft = New DB2Command(StrUpdateAircraft, ConnVar)
            CmdUpdateAircraft.ExecuteNonQuery()
            MessageBox.Show("The record was successfully updated.", "", MessageBoxButtons.OK)
            Me.AIRCRAFTID.Clear()
            Me.CAPACITY.Clear()

            Me.AIRCRAFTID.Focus()
            Call RefreshDataGridView()
            Me.AIRCRAFTNo.Enabled = True


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DELETEAIRCRAFT_Click(sender As Object, e As EventArgs) Handles DELETEAIRCRAFT.Click
        Dim StrDelete As String
        Dim CmdDelete As DB2Command

        Try
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to DELETE this record?", "Confirmation", MessageBoxButtons.YesNo)


            If result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                StrDelete = "delete from aircraft where aircraftid = '" & Me.AIRCRAFTID.Text & "'"
                CmdDelete = New DB2Command(StrDelete, ConnVar)
                CmdDelete.ExecuteNonQuery()

                MessageBox.Show("The record was successfully deleted.", "", MessageBoxButtons.OK)
            End If



            Me.AIRCRAFTID.Clear()
            Me.CAPACITY.Clear()

            Me.AIRCRAFTID.Focus()
            Call RefreshDataGridView()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub DGVAIRCRAFT_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVAIRCRAFT.CellContentClick

    End Sub

    Private Sub AIRBACK_Click(sender As Object, e As EventArgs) Handles AIRBACK.Click
        Dim back = New MAIN

        back.Show()

        Me.Hide()

    End Sub

    Private Sub CAPACITY_TextChanged(sender As Object, e As EventArgs) Handles CAPACITY.TextChanged

    End Sub

    Private Sub Panel2CAR_Paint(sender As Object, e As PaintEventArgs) Handles Panel2CAR.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)






    End Sub
End Class