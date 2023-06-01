Imports IBM.Data.DB2
Public Class CUSTOMER
    Private ConnVar As Common.DbConnection

    Private Sub DELETE_Click(sender As Object, e As EventArgs) Handles DELETECUS.Click
        Dim StrDelete As String
        Dim CmdDelete As DB2Command

        Try
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to DELETE this record?", "Confirmation", MessageBoxButtons.YesNo)


            If result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                StrDelete = "delete from customer where pnrno = '" & Me.PNRNO.Text & "'"
                CmdDelete = New DB2Command(StrDelete, ConnVar)
                CmdDelete.ExecuteNonQuery()


                Me.PNRNO.Clear()
                Me.CUSLNAME.Clear()
                Me.CUSMNAME.Clear()
                Me.CUSFNAME.Clear()
                Me.CUSDOB.Clear()
                Me.CUSEMAIL.Clear()
                Me.CUSTEL.Clear()
                Me.CUSADDRESS.Clear()
                Me.PASSPORTNO.Clear()
                Me.PNRNO.Focus()
                Call RefreshDataGridView()

                MessageBox.Show("The record was successfully deleted.", "", MessageBoxButtons.OK)
            End If



        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub CUSTOMER_SIMP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim StrLoad As String
        Dim CmdLoad As DB2Command
        Dim RdrLoad As DB2DataReader
        Dim row As String()
        Try
            ConnVar = New DB2Connection("server=localhost;database=airline;" + "uid=db2admin;password=db2admin;")
            ConnVar.Open()
            With Me.DGVCUSTOMER
                .ColumnCount = 9
                .Columns(0).Name = "PnrNo"
                .Columns(1).Name = "Last Name"
                .Columns(2).Name = "Middle Name"
                .Columns(3).Name = "First Name"
                .Columns(4).Name = "Date of Birth"
                .Columns(5).Name = "Email"
                .Columns(6).Name = "Tel"
                .Columns(7).Name = "Address"
                .Columns(8).Name = "Passport No."
                .Columns(0).Width = 130
                .Columns(1).Width = 130
                .Columns(2).Width = 130
                .Columns(3).Width = 130
                .Columns(4).Width = 130
                .Columns(5).Width = 130
                .Columns(6).Width = 130
                .Columns(7).Width = 130
                .Columns(8).Width = 130
            End With
            Me.DGVCUSTOMER.ColumnCount = 9

            StrLoad = "select * from customer"
            CmdLoad = New DB2Command(StrLoad, ConnVar)
            RdrLoad = CmdLoad.ExecuteReader
            While RdrLoad.Read
                row = New String() {RdrLoad.GetString(0), RdrLoad.GetString(1), RdrLoad.GetString(2), RdrLoad.GetString(3), RdrLoad.GetString(4),
                    RdrLoad.GetString(5), RdrLoad.GetString(6), RdrLoad.GetString(7), RdrLoad.GetString(8)}
                Me.DGVCUSTOMER.Rows.Add(row)
            End While


            Call RefreshDataGridView()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try




    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCUSTOMER.CellContentClick

    End Sub

    Private Sub ADDCUS_Click(sender As Object, e As EventArgs) Handles ADDCUS.Click
        Dim Cmd As DB2Command
        Try
            Cmd = New DB2Command("insert into customer values('" & Me.PNRNO.Text & "','" & Me.CUSLNAME.Text & "', '" & Me.CUSMNAME.Text & "', '" & Me.CUSFNAME.Text & "', 
                            '" & Me.CUSDOB.Text & "', '" & Me.CUSEMAIL.Text & "', '" & Me.CUSTEL.Text & "', '" & Me.CUSADDRESS.Text & "', '" & Me.PASSPORTNO.Text & "'
                            )", ConnVar)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("The record was successfully added.", "", MessageBoxButtons.OK)
            Me.PNRNO.Clear()
            Me.CUSLNAME.Clear()
            Me.CUSMNAME.Clear()
            Me.CUSFNAME.Clear()
            Me.CUSDOB.Clear()
            Me.CUSEMAIL.Clear()
            Me.CUSTEL.Clear()
            Me.CUSADDRESS.Clear()
            Me.PASSPORTNO.Clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub SEARCHCUS_TextChanged(sender As Object, e As EventArgs) Handles SEARCHCUS.TextChanged
        Dim StrSearch As String
        Dim StrValue As String
        Dim CmdSearch As DB2Command
        Dim RdrSearch As DB2DataReader
        Dim row As String()
        Try
            StrValue = Me.SEARCHCUS.Text + "%"
            StrSearch = "Select * from customer where pnrno like '" & StrValue & "'"
            CmdSearch = New DB2Command(StrSearch, ConnVar)
            RdrSearch = CmdSearch.ExecuteReader

            Me.DGVCUSTOMER.Rows.Clear()

            While RdrSearch.Read
                row = New String() {RdrSearch.GetString(0), RdrSearch.GetString(1), RdrSearch.GetString(2), RdrSearch.GetString(3), RdrSearch.GetString(4),
                    RdrSearch.GetString(5), RdrSearch.GetString(6), RdrSearch.GetString(7), RdrSearch.GetString(8)}
                Me.DGVCUSTOMER.Rows.Add(row)

            End While

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try


    End Sub

    Private Sub SAVECUS_Click(sender As Object, e As EventArgs) Handles SAVECUS.Click
        Dim StrUpdateCustomer As String
        Dim CmdUpdateCustomer As DB2Command
        Dim UPNRNO As String
        Dim UCUSLNAME As String
        Dim UCUSMNAME As String
        Dim UCUSFNAME As String
        Dim UCUSDOB As String
        Dim UCUSEMAIL As String
        Dim UCUSTEL As String
        Dim UCUSADDRESS As String
        Dim UPASSPORTNO As String

        Try
            UPNRNO = Me.PNRNO.Text
            UCUSLNAME = Me.CUSLNAME.Text
            UCUSMNAME = Me.CUSMNAME.Text
            UCUSFNAME = Me.CUSFNAME.Text
            UCUSDOB = Me.CUSDOB.Text
            UCUSEMAIL = Me.CUSEMAIL.Text
            UCUSTEL = Me.CUSTEL.Text
            UCUSADDRESS = Me.CUSADDRESS.Text
            UPASSPORTNO = Me.PASSPORTNO.Text
            StrUpdateCustomer = "update customer set PNRNO = '" & UPNRNO & "', CUSLNAME = '" & UCUSLNAME & "', CUSMNAME = '" & UCUSMNAME & "'," _
                                 & "CUSFNAME = '" & UCUSFNAME & "', CUSDOB = '" & UCUSDOB & "', CUSEMAIL = '" & UCUSEMAIL & "', CUSTEL = '" & UCUSTEL & "'," _
                                 & "CUSADDRESS = '" & UCUSADDRESS & "', PASSPORTNO = '" & UPASSPORTNO & "' where PNRNO = '" & UPNRNO & "'"
            CmdUpdateCustomer = New DB2Command(StrUpdateCustomer, ConnVar)
            CmdUpdateCustomer.ExecuteNonQuery()
            MessageBox.Show("The record was successfully updated.", "", MessageBoxButtons.OK)
            Me.PNRNO.Clear()
            Me.CUSLNAME.Clear()
            Me.CUSMNAME.Clear()
            Me.CUSFNAME.Clear()
            Me.CUSDOB.Clear()
            Me.CUSEMAIL.Clear()
            Me.CUSTEL.Clear()
            Me.CUSADDRESS.Clear()
            Me.PASSPORTNO.Clear()
            Me.PNRNO.Focus()
            Call RefreshDataGridView()
            Me.PNRNO.Enabled = True


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
            Me.DGVCUSTOMER.Rows.Clear()

            StrLoad = "select * from customer"
            CmdLoad = New DB2Command(StrLoad, ConnVar)
            RdrLoad = CmdLoad.ExecuteReader
            While RdrLoad.Read
                row = New String() {RdrLoad.GetString(0), RdrLoad.GetString(1), RdrLoad.GetString(2), RdrLoad.GetString(3), RdrLoad.GetString(4),
                    RdrLoad.GetString(5), RdrLoad.GetString(6), RdrLoad.GetString(7), RdrLoad.GetString(8)}
                Me.DGVCUSTOMER.Rows.Add(row)
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DGVCustomer_MouseUp(sender As Object, e As MouseEventArgs) Handles DGVCUSTOMER.MouseUp
        Try
            With Me.DGVCUSTOMER
                Me.PNRNO.Text = .CurrentRow.Cells(0).Value
                Me.CUSLNAME.Text = .CurrentRow.Cells(1).Value
                Me.CUSMNAME.Text = .CurrentRow.Cells(2).Value
                Me.CUSFNAME.Text = .CurrentRow.Cells(3).Value
                Me.CUSDOB.Text = .CurrentRow.Cells(4).Value
                Me.CUSEMAIL.Text = .CurrentRow.Cells(5).Value
                Me.CUSTEL.Text = .CurrentRow.Cells(6).Value
                Me.CUSADDRESS.Text = .CurrentRow.Cells(7).Value
                Me.PASSPORTNO.Text = .CurrentRow.Cells(8).Value



            End With
            Me.PNRNO.Enabled = False


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub AIRBACK_Click(sender As Object, e As EventArgs) Handles CUSBACK.Click
        Dim back = New MAIN
        back.Show()

        Me.Hide()


    End Sub
End Class
