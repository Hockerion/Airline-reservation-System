Imports IBM.Data.DB2
Public Class Login
    Private ConnVar As Common.DbConnection
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ConnVar = New DB2Connection("server=localhost;database=airline;" + "uid=db2admin;password=db2admin;")
            ConnVar.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)


        End Try

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Username.TextChanged




    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Signin_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Signin_Click_1(sender As Object, e As EventArgs) Handles Signin.Click
        Dim username As String = Console.ReadLine
        Dim password As String = Console.ReadLine


        If Me.Username.Text = "username" And Me.Password.Text = "password" Then

            Dim dashb = New MAIN
            dashb.Show()
            Me.Hide()

        End If

        Dim StrSearch As String

        Dim StrValue As String
        Dim StrValue2 As String

        Dim CmdSearch As DB2Command
        Dim RdrSearch As DB2DataReader

        Try
            StrValue = Me.Password.Text + "%"
            StrValue2 = Me.Username.Text + "%"

            StrSearch = "Select * from login where password like '" & StrValue & "' and username like '" & StrValue2 & "'"

            CmdSearch = New DB2Command(StrSearch, ConnVar)
            RdrSearch = CmdSearch.ExecuteReader




            If (RdrSearch.Read()) Then
                Dim dashb = New MAIN
                dashb.Show()
                Me.Hide()

            Else
                MsgBox("Incorrect Username/Password!")


            End If





        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try



    End Sub



    Private Sub Register_Click(sender As Object, e As EventArgs) Handles Register.Click
        Dim register = New Register
        register.Show()
        Me.Hide()



    End Sub

    Private Sub Password_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged

    End Sub
End Class