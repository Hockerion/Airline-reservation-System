Imports IBM.Data.DB2
Public Class EMPLOYEE
    Private ConnVar As Common.DbConnection
    Private Sub EMPLOYEE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim StrLoad As String
        Dim CmdLoad As DB2Command
        Dim RdrLoad As DB2DataReader
        Dim row As String()
        Try

            ConnVar = New DB2Connection("server=localhost;database=airline;" + "uid=db2admin;password=db2admin;")
            ConnVar.Open()
            With Me.DGVEMPLOYEE
                .ColumnCount = 7
                .Columns(0).Name = "Employee ID"
                .Columns(1).Name = "Last Name"
                .Columns(2).Name = "Middle Name"
                .Columns(3).Name = "First Name"
                .Columns(4).Name = "Email"
                .Columns(5).Name = "Address"
                .Columns(6).Name = "Tel"
                .Columns(0).Width = 150
                .Columns(1).Width = 150
                .Columns(2).Width = 150
                .Columns(3).Width = 150
                .Columns(4).Width = 150
                .Columns(5).Width = 150
                .Columns(6).Width = 150



            End With
            Me.DGVEMPLOYEE.ColumnCount = 7

            StrLoad = "select * from employee"
            CmdLoad = New DB2Command(StrLoad, ConnVar)
            RdrLoad = CmdLoad.ExecuteReader
            While RdrLoad.Read
                row = New String() {RdrLoad.GetString(0), RdrLoad.GetString(1), RdrLoad.GetString(2), RdrLoad.GetString(3),
                    RdrLoad.GetString(4), RdrLoad.GetString(5), RdrLoad.GetString(6)}
                Me.DGVEMPLOYEE.Rows.Add(row)
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
            Me.DGVEMPLOYEE.Rows.Clear()

            StrLoad = "select * from employee"
            CmdLoad = New DB2Command(StrLoad, ConnVar)
            RdrLoad = CmdLoad.ExecuteReader
            While RdrLoad.Read
                row = New String() {RdrLoad.GetString(0), RdrLoad.GetString(1), RdrLoad.GetString(2), RdrLoad.GetString(3),
                    RdrLoad.GetString(4), RdrLoad.GetString(5), RdrLoad.GetString(6)}
                Me.DGVEMPLOYEE.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ADDEMPLOYEE_Click(sender As Object, e As EventArgs) Handles ADDEMPLOYEE.Click
        Dim Cmd As DB2Command
        Try
            Cmd = New DB2Command("insert into employee values('" & Me.EMPID.Text & "','" & Me.EMPLNAME.Text & "', '" & Me.EMPMNAME.Text & "', '" & Me.EMPFNAME.Text & "', 
                            '" & Me.EMPEMAIL.Text & "', '" & Me.EMPADDRESS.Text & "', '" & Me.EMPTEL.Text & "'

                            )", ConnVar)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("The record was successfully added.", "", MessageBoxButtons.OK)

            Me.EMPID.Clear()
            Me.EMPLNAME.Clear()
            Me.EMPMNAME.Clear()
            Me.EMPFNAME.Clear()
            Me.EMPEMAIL.Clear()
            Me.EMPADDRESS.Clear()
            Me.EMPTEL.Clear()







        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub SEARCHEMPLOYEE_TextChanged(sender As Object, e As EventArgs) Handles SEARCHEMPLOYEE.TextChanged
        Dim StrSearch As String
        Dim StrValue As String
        Dim CmdSearch As DB2Command
        Dim RdrSearch As DB2DataReader
        Dim row As String()
        Try
            StrValue = Me.SEARCHEMPLOYEE.Text + "%"
            StrSearch = "Select * from employee where empid Like '" & StrValue & "'"
            CmdSearch = New DB2Command(StrSearch, ConnVar)
            RdrSearch = CmdSearch.ExecuteReader

            Me.DGVEMPLOYEE.Rows.Clear()

            While RdrSearch.Read
                row = New String() {RdrSearch.GetString(0), RdrSearch.GetString(1)}
                Me.DGVEMPLOYEE.Rows.Add(row)

            End While

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub DGVEMPLOYEE_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVEMPLOYEE.MouseUp
        Try
            With Me.DGVEMPLOYEE
                Me.EMPID.Text = .CurrentRow.Cells(0).Value
                Me.EMPLNAME.Text = .CurrentRow.Cells(1).Value
                Me.EMPMNAME.Text = .CurrentRow.Cells(2).Value
                Me.EMPFNAME.Text = .CurrentRow.Cells(3).Value
                Me.EMPEMAIL.Text = .CurrentRow.Cells(4).Value
                Me.EMPADDRESS.Text = .CurrentRow.Cells(5).Value
                Me.EMPTEL.Text = .CurrentRow.Cells(6).Value








            End With
            Me.EMPID.Enabled = False


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub SAVEEMPLOYEE_Click(sender As Object, e As EventArgs) Handles SAVEEMPLOYEE.Click
        Dim StrUpdateEmployee As String
        Dim CmdUpdateEmployee As DB2Command

        Dim UEMPID As String
        Dim UEMPLNAME As String
        Dim UEMPMNAME As String
        Dim UEMPFNAME As String

        Dim UEMPEMAIL As String
        Dim UEMPADDRESS As String
        Dim UEMPTEL As String


        Try
            UEMPID = Me.EMPID.Text
            UEMPLNAME = Me.EMPLNAME.Text
            UEMPMNAME = Me.EMPMNAME.Text
            UEMPFNAME = Me.EMPFNAME.Text
            UEMPEMAIL = Me.EMPEMAIL.Text
            UEMPADDRESS = Me.EMPADDRESS.Text
            UEMPTEL = Me.EMPTEL.Text







            StrUpdateEmployee = "update employee set EMPID = '" & UEMPID & "', EMPLNAME = '" & UEMPLNAME & "', EMPMNAME = '" & UEMPMNAME & "', EMPFNAME = '" & UEMPFNAME & "'," _
                                 & "EMPEMAIL = '" & UEMPEMAIL & "', EMPADDRESS = '" & UEMPADDRESS & "', EMPTEL = '" & UEMPTEL & "' where EMPID = '" & UEMPID & "'"

            CmdUpdateEmployee = New DB2Command(StrUpdateEmployee, ConnVar)
            CmdUpdateEmployee.ExecuteNonQuery()
            MessageBox.Show("The record was successfully updated.", "", MessageBoxButtons.OK)
            Me.EMPID.Clear()
            Me.EMPLNAME.Clear()
            Me.EMPMNAME.Clear()
            Me.EMPFNAME.Clear()
            Me.EMPEMAIL.Clear()
            Me.EMPADDRESS.Clear()
            Me.EMPTEL.Clear()

            Me.EMPID.Focus()
            Call RefreshDataGridView()
            Me.EMPID.Enabled = True


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DELETEEMPLOYEE_Click(sender As Object, e As EventArgs) Handles DELETEMPLOYEE.Click
        Dim StrDelete As String
        Dim CmdDelete As DB2Command

        Try
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to DELETE this record?", "Confirmation", MessageBoxButtons.YesNo)


            If result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then

                StrDelete = "delete from employee where empid = '" & Me.EMPID.Text & "'"
                CmdDelete = New DB2Command(StrDelete, ConnVar)
                CmdDelete.ExecuteNonQuery()

                Me.EMPID.Clear()
                Me.EMPLNAME.Clear()
                Me.EMPMNAME.Clear()
                Me.EMPFNAME.Clear()
                Me.EMPEMAIL.Clear()
                Me.EMPADDRESS.Clear()
                Me.EMPTEL.Clear()

                Me.EMPID.Focus()
                Call RefreshDataGridView()

                MessageBox.Show("The record was successfully deleted.", "", MessageBoxButtons.OK)
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub DGVAIRCRAFT_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVEMPLOYEE.CellContentClick

    End Sub

    Private Sub EMPBACK_Click(sender As Object, e As EventArgs) Handles EMPBACK.Click
        Dim m = MAIN
        m.Show()
        Me.Hide()
    End Sub
End Class