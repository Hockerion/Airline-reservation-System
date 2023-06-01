Imports IBM.Data.DB2
Public Class Book_Flight
    Private ConnVar As Common.DbConnection
    Private Sub Book_Flight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ConnVar = New DB2Connection("server=localhost;database=airline;" + "uid=db2admin;password=db2admin;")
            ConnVar.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim flights = New BOOK
        flights.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim seats = New Choose_Seat
        seats.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BOOK.Click
        Dim Cmd As DB2Command
        Dim StrUpdateSeat As String

        Dim StrSearch As String
        Dim CmdSearch As DB2Command
        Dim RdrSearch As DB2DataReader




        Dim newid As Integer


        Dim dte As Date = Today
        

        Try

            Dim USTATUS As String = "Reserved"

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to proceed?", "Confirmation", MessageBoxButtons.YesNo)


            If result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then

                'RESERVATION ID GENERATOR

                StrSearch = "Select * from reservation ORDER BY resid DESC"


                CmdSearch = New DB2Command(StrSearch, ConnVar)
                RdrSearch = CmdSearch.ExecuteReader(CommandBehavior.CloseConnection)


                If RdrSearch.Read() = True Then

                    newid = Val(RdrSearch(0)) + 1
                    newid = newid.ToString("000")


                Else



                    newid = 101



                End If




                'CUSTOMER TABLE
                Cmd = New DB2Command("insert into customer values('" & Me.PNRNO.Text & "','" & Me.CUSLNAME.Text & "', '" & Me.CUSMNAME.Text & "', '" & Me.CUSFNAME.Text & "', 
                            '" & Me.CUSDOB.Text & "', '" & Me.CUSEMAIL.Text & "', '" & Me.CUSTEL.Text & "', '" & Me.CUSADDRESS.Text & "', '" & Me.PASSPORTNO.Text & "'
                            )", ConnVar)
                Cmd.ExecuteNonQuery()


                'RESERVATION TABLE
                Cmd = New DB2Command("insert into reservation values('" & newid & "','" & dte & "', '" & Me.PNRNO.Text & "', '" & Me.FLIGHTID.Text & "', '" & Me.SEATID.Text & "'
                            )", ConnVar)
                Cmd.ExecuteNonQuery()

                'UPDATING SEAT STATUS
                StrUpdateSeat = "update seat set STATUS = '" & USTATUS & "' where seatid = '" & Me.SEATID.Text & "'"



                Cmd = New DB2Command(StrUpdateSeat, ConnVar)
                Cmd.ExecuteNonQuery()

                Me.PNRNO.Clear()
                Me.CUSLNAME.Clear()
                Me.CUSMNAME.Clear()
                Me.CUSFNAME.Clear()
                Me.CUSDOB.Clear()
                Me.CUSEMAIL.Clear()
                Me.CUSTEL.Clear()
                Me.CUSADDRESS.Clear()
                Me.PASSPORTNO.Clear()
                Me.FLIGHTID.Clear()
                Me.SEATID.Clear()

                MessageBox.Show("The flight was successfully booked.", "", MessageBoxButtons.OK)

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)




        End Try




    End Sub

    Private Sub BACK_Click(sender As Object, e As EventArgs) Handles BACK.Click
        Dim back = New MAIN
        back.Show()
        Me.Hide()

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles PNRNO.TextChanged

    End Sub

    Private Sub PNRNOGEN_Click(sender As Object, e As EventArgs) Handles PNRNOGEN.Click
        'PNRNO GENERATOR

        Dim StrSearch As String
        Dim CmdSearch As DB2Command
        Dim RdrSearch As DB2DataReader



        Dim newid As Integer


        Try
            StrSearch = "Select * from customer ORDER BY pnrno DESC"


            CmdSearch = New DB2Command(StrSearch, ConnVar)
            RdrSearch = CmdSearch.ExecuteReader(CommandBehavior.CloseConnection)


            If RdrSearch.Read() = True Then

                newid = Val(RdrSearch(0)) + 1
                Me.PNRNO.Text = newid.ToString("0000000")


            Else



                PNRNO.Text = "1460001"



            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally






        End Try
    End Sub
End Class