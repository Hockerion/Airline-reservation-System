Imports IBM.Data.DB2
Public Class MAIN
    Private ConnVar As Common.DbConnection
    Private Sub MAIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try
            ConnVar = New DB2Connection("server=localhost;database=airline;" + "uid=db2admin;password=db2admin;")
            ConnVar.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub
    Private Sub EMPLOYEE_Click(sender As Object, e As EventArgs) Handles EMPLOYEE.Click


        Dim emp = New EMPLOYEE
        emp.Show()

        Me.Hide()



    End Sub

    Private Sub FLIGHT_Click(sender As Object, e As EventArgs) Handles FLIGHT.Click
        Dim fli = New FLIGHT
        fli.Show()

        Me.Hide()

    End Sub

    Private Sub AIRCRAFT_Click(sender As Object, e As EventArgs) Handles AIRCRAFT.Click
        Dim air = New AIRCRAFT
        air.Show()

        Me.Hide()

    End Sub

    Private Sub CUSTOMER_Click(sender As Object, e As EventArgs) Handles CUSTOMER.Click
        Dim cus = New CUSTOMER
        cus.Show()

        Me.Hide()

    End Sub

    Private Sub RESERVATION_Click(sender As Object, e As EventArgs) Handles RESERVATION.Click
        Dim res = New RESERVATION
        res.Show()

        Me.Hide()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub TICKET_Click(sender As Object, e As EventArgs) Handles TICKET.Click
        Dim tic = New TICKET
        tic.Show()

        Me.Hide()


    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim book = New Book_Flight

        book.Show()
        Me.Hide()



    End Sub

    Private Sub SEAT_Click(sender As Object, e As EventArgs) Handles SEAT.Click
        Dim seat = New Seat
        seat.Show()
        Me.Hide()

    End Sub

    Private Sub CANCELFLI_Click(sender As Object, e As EventArgs) Handles CANCELFLI.Click
        Dim cancelfli = Cancel_Flight
        cancelfli.Show()
        Me.Hide()

    End Sub

    Private Sub REBOOKFLI_Click(sender As Object, e As EventArgs) Handles REBOOKFLI.Click
        Dim rebook = New Rebook_Flight
        rebook.Show()
        Me.Hide()

    End Sub

    Private Sub LOGOUT_Click(sender As Object, e As EventArgs) Handles LOGOUT.Click
        Me.Close()


    End Sub
End Class