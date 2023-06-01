<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RESERVATION
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Search = New System.Windows.Forms.Label()
        Me.DGVRESERVATION = New System.Windows.Forms.DataGridView()
        Me.DELETERESERVATION = New System.Windows.Forms.Button()
        Me.SAVERESERVATION = New System.Windows.Forms.Button()
        Me.ADDRESERVATION = New System.Windows.Forms.Button()
        Me.SEARCHRESERVATION = New System.Windows.Forms.TextBox()
        Me.Panel2CAR = New System.Windows.Forms.Panel()
        Me.SEATID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FLIGHTID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PNRNO = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RESID = New System.Windows.Forms.TextBox()
        Me.LabelFNCAR = New System.Windows.Forms.Label()
        Me.RESVID = New System.Windows.Forms.Label()
        Me.RESDATE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RESBACK = New System.Windows.Forms.Button()
        CType(Me.DGVRESERVATION, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2CAR.SuspendLayout()
        Me.SuspendLayout()
        '
        'Search
        '
        Me.Search.AutoSize = True
        Me.Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(28, 364)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(132, 20)
        Me.Search.TabIndex = 66
        Me.Search.Text = "Search PNRNO:"
        '
        'DGVRESERVATION
        '
        Me.DGVRESERVATION.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRESERVATION.Location = New System.Drawing.Point(13, 405)
        Me.DGVRESERVATION.Name = "DGVRESERVATION"
        Me.DGVRESERVATION.RowTemplate.Height = 24
        Me.DGVRESERVATION.Size = New System.Drawing.Size(1443, 355)
        Me.DGVRESERVATION.TabIndex = 65
        '
        'DELETERESERVATION
        '
        Me.DELETERESERVATION.Location = New System.Drawing.Point(1326, 358)
        Me.DELETERESERVATION.Margin = New System.Windows.Forms.Padding(4)
        Me.DELETERESERVATION.Name = "DELETERESERVATION"
        Me.DELETERESERVATION.Size = New System.Drawing.Size(100, 28)
        Me.DELETERESERVATION.TabIndex = 68
        Me.DELETERESERVATION.Text = "DELETE"
        Me.DELETERESERVATION.UseVisualStyleBackColor = True
        '
        'SAVERESERVATION
        '
        Me.SAVERESERVATION.Location = New System.Drawing.Point(1049, 358)
        Me.SAVERESERVATION.Margin = New System.Windows.Forms.Padding(4)
        Me.SAVERESERVATION.Name = "SAVERESERVATION"
        Me.SAVERESERVATION.Size = New System.Drawing.Size(100, 28)
        Me.SAVERESERVATION.TabIndex = 67
        Me.SAVERESERVATION.Text = "SAVE"
        Me.SAVERESERVATION.UseVisualStyleBackColor = True
        '
        'ADDRESERVATION
        '
        Me.ADDRESERVATION.Location = New System.Drawing.Point(941, 358)
        Me.ADDRESERVATION.Margin = New System.Windows.Forms.Padding(4)
        Me.ADDRESERVATION.Name = "ADDRESERVATION"
        Me.ADDRESERVATION.Size = New System.Drawing.Size(100, 28)
        Me.ADDRESERVATION.TabIndex = 63
        Me.ADDRESERVATION.Text = "ADD"
        Me.ADDRESERVATION.UseVisualStyleBackColor = True
        '
        'SEARCHRESERVATION
        '
        Me.SEARCHRESERVATION.Location = New System.Drawing.Point(210, 364)
        Me.SEARCHRESERVATION.Margin = New System.Windows.Forms.Padding(4)
        Me.SEARCHRESERVATION.Name = "SEARCHRESERVATION"
        Me.SEARCHRESERVATION.Size = New System.Drawing.Size(485, 22)
        Me.SEARCHRESERVATION.TabIndex = 69
        '
        'Panel2CAR
        '
        Me.Panel2CAR.Controls.Add(Me.SEATID)
        Me.Panel2CAR.Controls.Add(Me.Label4)
        Me.Panel2CAR.Controls.Add(Me.FLIGHTID)
        Me.Panel2CAR.Controls.Add(Me.Label3)
        Me.Panel2CAR.Controls.Add(Me.PNRNO)
        Me.Panel2CAR.Controls.Add(Me.Label1)
        Me.Panel2CAR.Controls.Add(Me.RESID)
        Me.Panel2CAR.Controls.Add(Me.LabelFNCAR)
        Me.Panel2CAR.Controls.Add(Me.RESVID)
        Me.Panel2CAR.Controls.Add(Me.RESDATE)
        Me.Panel2CAR.Location = New System.Drawing.Point(13, 48)
        Me.Panel2CAR.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2CAR.Name = "Panel2CAR"
        Me.Panel2CAR.Size = New System.Drawing.Size(1443, 291)
        Me.Panel2CAR.TabIndex = 64
        '
        'SEATID
        '
        Me.SEATID.Location = New System.Drawing.Point(932, 168)
        Me.SEATID.Margin = New System.Windows.Forms.Padding(4)
        Me.SEATID.Name = "SEATID"
        Me.SEATID.Size = New System.Drawing.Size(485, 22)
        Me.SEATID.TabIndex = 40
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(756, 168)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 32)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Seat ID:"
        '
        'FLIGHTID
        '
        Me.FLIGHTID.Location = New System.Drawing.Point(932, 114)
        Me.FLIGHTID.Margin = New System.Windows.Forms.Padding(4)
        Me.FLIGHTID.Name = "FLIGHTID"
        Me.FLIGHTID.Size = New System.Drawing.Size(485, 22)
        Me.FLIGHTID.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(756, 114)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 32)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Flight ID:"
        '
        'PNRNO
        '
        Me.PNRNO.Location = New System.Drawing.Point(197, 224)
        Me.PNRNO.Margin = New System.Windows.Forms.Padding(4)
        Me.PNRNO.Name = "PNRNO"
        Me.PNRNO.Size = New System.Drawing.Size(485, 22)
        Me.PNRNO.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 224)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 32)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Pnrno:"
        '
        'RESID
        '
        Me.RESID.Location = New System.Drawing.Point(197, 114)
        Me.RESID.Margin = New System.Windows.Forms.Padding(4)
        Me.RESID.Name = "RESID"
        Me.RESID.Size = New System.Drawing.Size(485, 22)
        Me.RESID.TabIndex = 34
        '
        'LabelFNCAR
        '
        Me.LabelFNCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFNCAR.Location = New System.Drawing.Point(15, 168)
        Me.LabelFNCAR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelFNCAR.Name = "LabelFNCAR"
        Me.LabelFNCAR.Size = New System.Drawing.Size(163, 32)
        Me.LabelFNCAR.TabIndex = 25
        Me.LabelFNCAR.Text = "Reservation Date:"
        '
        'RESVID
        '
        Me.RESVID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RESVID.Location = New System.Drawing.Point(15, 114)
        Me.RESVID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RESVID.Name = "RESVID"
        Me.RESVID.Size = New System.Drawing.Size(148, 32)
        Me.RESVID.TabIndex = 24
        Me.RESVID.Text = "Reservation ID:"
        '
        'RESDATE
        '
        Me.RESDATE.Location = New System.Drawing.Point(197, 168)
        Me.RESDATE.Margin = New System.Windows.Forms.Padding(4)
        Me.RESDATE.Name = "RESDATE"
        Me.RESDATE.Size = New System.Drawing.Size(485, 22)
        Me.RESDATE.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(231, 36)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "RESERVATION"
        '
        'RESBACK
        '
        Me.RESBACK.Location = New System.Drawing.Point(1218, 358)
        Me.RESBACK.Margin = New System.Windows.Forms.Padding(4)
        Me.RESBACK.Name = "RESBACK"
        Me.RESBACK.Size = New System.Drawing.Size(100, 28)
        Me.RESBACK.TabIndex = 70
        Me.RESBACK.Text = "BACK"
        Me.RESBACK.UseVisualStyleBackColor = True
        '
        'RESERVATION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1469, 768)
        Me.Controls.Add(Me.RESBACK)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.DGVRESERVATION)
        Me.Controls.Add(Me.DELETERESERVATION)
        Me.Controls.Add(Me.SAVERESERVATION)
        Me.Controls.Add(Me.ADDRESERVATION)
        Me.Controls.Add(Me.SEARCHRESERVATION)
        Me.Controls.Add(Me.Panel2CAR)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RESERVATION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RESERVATION"
        CType(Me.DGVRESERVATION, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2CAR.ResumeLayout(False)
        Me.Panel2CAR.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Search As Label
    Friend WithEvents DGVRESERVATION As DataGridView
    Private WithEvents DELETERESERVATION As Button
    Private WithEvents SAVERESERVATION As Button
    Private WithEvents ADDRESERVATION As Button
    Private WithEvents SEARCHRESERVATION As TextBox
    Private WithEvents Panel2CAR As Panel
    Private WithEvents RESID As TextBox
    Friend WithEvents LabelFNCAR As Label
    Friend WithEvents RESVID As Label
    Private WithEvents RESDATE As TextBox
    Friend WithEvents Label2 As Label
    Private WithEvents FLIGHTID As TextBox
    Friend WithEvents Label3 As Label
    Private WithEvents PNRNO As TextBox
    Friend WithEvents Label1 As Label
    Private WithEvents RESBACK As Button
    Private WithEvents SEATID As TextBox
    Friend WithEvents Label4 As Label
End Class
