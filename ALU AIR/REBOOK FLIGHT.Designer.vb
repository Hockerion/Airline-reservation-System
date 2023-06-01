<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rebook_Flight
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
        Me.RESBACK = New System.Windows.Forms.Button()
        Me.Search = New System.Windows.Forms.Label()
        Me.DGVRESERVATION = New System.Windows.Forms.DataGridView()
        Me.REBOOKFLI = New System.Windows.Forms.Button()
        Me.SEARCHPNRNO = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.VIEWSEATS = New System.Windows.Forms.Button()
        Me.VIEWFLIGHTS = New System.Windows.Forms.Button()
        Me.SEATID = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.FLIGHTID = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.DGVRESERVATION, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'RESBACK
        '
        Me.RESBACK.Location = New System.Drawing.Point(1326, 358)
        Me.RESBACK.Margin = New System.Windows.Forms.Padding(4)
        Me.RESBACK.Name = "RESBACK"
        Me.RESBACK.Size = New System.Drawing.Size(100, 28)
        Me.RESBACK.TabIndex = 79
        Me.RESBACK.Text = "BACK"
        Me.RESBACK.UseVisualStyleBackColor = True
        '
        'Search
        '
        Me.Search.AutoSize = True
        Me.Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(29, 366)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(132, 20)
        Me.Search.TabIndex = 75
        Me.Search.Text = "Search PNRNO:"
        '
        'DGVRESERVATION
        '
        Me.DGVRESERVATION.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRESERVATION.Location = New System.Drawing.Point(13, 405)
        Me.DGVRESERVATION.Name = "DGVRESERVATION"
        Me.DGVRESERVATION.RowTemplate.Height = 24
        Me.DGVRESERVATION.Size = New System.Drawing.Size(1443, 355)
        Me.DGVRESERVATION.TabIndex = 74
        '
        'REBOOKFLI
        '
        Me.REBOOKFLI.Location = New System.Drawing.Point(1218, 358)
        Me.REBOOKFLI.Margin = New System.Windows.Forms.Padding(4)
        Me.REBOOKFLI.Name = "REBOOKFLI"
        Me.REBOOKFLI.Size = New System.Drawing.Size(100, 28)
        Me.REBOOKFLI.TabIndex = 76
        Me.REBOOKFLI.Text = "Rebook"
        Me.REBOOKFLI.UseVisualStyleBackColor = True
        '
        'SEARCHPNRNO
        '
        Me.SEARCHPNRNO.Location = New System.Drawing.Point(215, 366)
        Me.SEARCHPNRNO.Margin = New System.Windows.Forms.Padding(4)
        Me.SEARCHPNRNO.Name = "SEARCHPNRNO"
        Me.SEARCHPNRNO.Size = New System.Drawing.Size(485, 22)
        Me.SEARCHPNRNO.TabIndex = 78
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 36)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Rebook Flight"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.VIEWSEATS)
        Me.GroupBox3.Controls.Add(Me.VIEWFLIGHTS)
        Me.GroupBox3.Controls.Add(Me.SEATID)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.FLIGHTID)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 47)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1444, 279)
        Me.GroupBox3.TabIndex = 80
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Flight "
        '
        'VIEWSEATS
        '
        Me.VIEWSEATS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VIEWSEATS.Location = New System.Drawing.Point(204, 212)
        Me.VIEWSEATS.Name = "VIEWSEATS"
        Me.VIEWSEATS.Size = New System.Drawing.Size(118, 42)
        Me.VIEWSEATS.TabIndex = 46
        Me.VIEWSEATS.Text = "View Seats"
        Me.VIEWSEATS.UseVisualStyleBackColor = True
        '
        'VIEWFLIGHTS
        '
        Me.VIEWFLIGHTS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VIEWFLIGHTS.Location = New System.Drawing.Point(203, 87)
        Me.VIEWFLIGHTS.Name = "VIEWFLIGHTS"
        Me.VIEWFLIGHTS.Size = New System.Drawing.Size(119, 42)
        Me.VIEWFLIGHTS.TabIndex = 45
        Me.VIEWFLIGHTS.Text = "View Flights"
        Me.VIEWFLIGHTS.UseVisualStyleBackColor = True
        '
        'SEATID
        '
        Me.SEATID.Location = New System.Drawing.Point(204, 183)
        Me.SEATID.Margin = New System.Windows.Forms.Padding(4)
        Me.SEATID.Name = "SEATID"
        Me.SEATID.Size = New System.Drawing.Size(485, 22)
        Me.SEATID.TabIndex = 44
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(22, 183)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(148, 32)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Seat ID:"
        '
        'FLIGHTID
        '
        Me.FLIGHTID.Location = New System.Drawing.Point(203, 58)
        Me.FLIGHTID.Margin = New System.Windows.Forms.Padding(4)
        Me.FLIGHTID.Name = "FLIGHTID"
        Me.FLIGHTID.Size = New System.Drawing.Size(485, 22)
        Me.FLIGHTID.TabIndex = 42
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(22, 58)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(148, 32)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Flight ID:"
        '
        'Rebook_Flight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1469, 768)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.RESBACK)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.DGVRESERVATION)
        Me.Controls.Add(Me.REBOOKFLI)
        Me.Controls.Add(Me.SEARCHPNRNO)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Rebook_Flight"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rebook_Flight"
        CType(Me.DGVRESERVATION, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents RESBACK As Button
    Friend WithEvents Search As Label
    Friend WithEvents DGVRESERVATION As DataGridView
    Private WithEvents REBOOKFLI As Button
    Private WithEvents SEARCHPNRNO As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents VIEWSEATS As Button
    Friend WithEvents VIEWFLIGHTS As Button
    Private WithEvents SEATID As TextBox
    Friend WithEvents Label11 As Label
    Private WithEvents FLIGHTID As TextBox
    Friend WithEvents Label12 As Label
End Class
