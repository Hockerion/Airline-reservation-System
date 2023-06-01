Imports IBM.Data.DB2
Public Class Register
    Private ConnVar As Common.DbConnection
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ConnVar = New DB2Connection("server=localhost;database=airline;" + "uid=db2admin;password=db2admin;")
            ConnVar.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)


        End Try

    End Sub

    Private Sub Signin_Click(sender As Object, e As EventArgs) Handles Signin.Click
        Dim Cmd As DB2Command

        Try
            Cmd = New DB2Command("insert into login values('" & Me.EMPID.Text & "','" & Me.USERNAME.Text & "', '" & Me.PASSWORD.Text & "'
                                )", ConnVar)
            Cmd.ExecuteNonQuery()
            MsgBox("Successfully Registered!")

            Me.EMPID.Clear()
            Me.USERNAME.Clear()
            Me.PASSWORD.Clear()


        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim back = New Login
        back.Show()
        Me.Hide()

    End Sub
End Class