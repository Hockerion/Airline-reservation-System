<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TICKET
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Search = New System.Windows.Forms.Label()
        Me.DGVTICKET = New System.Windows.Forms.DataGridView()
        Me.DELETETICKET = New System.Windows.Forms.Button()
        Me.SAVETICKET = New System.Windows.Forms.Button()
        Me.ADDTICKET = New System.Windows.Forms.Button()
        Me.SEARCHTICKET = New System.Windows.Forms.TextBox()
        Me.Panel2CAR = New System.Windows.Forms.Panel()
        Me.SEATID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FLIGHTID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PNRNO = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TICKETID = New System.Windows.Forms.TextBox()
        Me.LabelFNCAR = New System.Windows.Forms.Label()
        Me.AIRCRAFTNo = New System.Windows.Forms.Label()
        Me.DATEISSUED = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TICKBACK = New System.Windows.Forms.Button()
        CType(Me.DGVTICKET, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2CAR.SuspendLayout()
        Me.SuspendLayout()
        '
        'Search
        '
        Me.Search.AutoSize = True
        Me.Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(29, 364)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(132, 20)
        Me.Search.TabIndex = 74
        Me.Search.Text = "Search PNRNO:"
        '
        'DGVTICKET
        '
        Me.DGVTICKET.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVTICKET.Location = New System.Drawing.Point(13, 405)
        Me.DGVTICKET.Name = "DGVTICKET"
        Me.DGVTICKET.RowTemplate.Height = 24
        Me.DGVTICKET.Size = New System.Drawing.Size(1443, 355)
        Me.DGVTICKET.TabIndex = 73
        '
        'DELETETICKET
        '
        Me.DELETETICKET.Location = New System.Drawing.Point(1326, 358)
        Me.DELETETICKET.Margin = New System.Windows.Forms.Padding(4)
        Me.DELETETICKET.Name = "DELETETICKET"
        Me.DELETETICKET.Size = New System.Drawing.Size(100, 28)
        Me.DELETETICKET.TabIndex = 76
        Me.DELETETICKET.Text = "DELETE"
        Me.DELETETICKET.UseVisualStyleBackColor = True
        '
        'SAVETICKET
        '
        Me.SAVETICKET.Location = New System.Drawing.Point(1049, 358)
        Me.SAVETICKET.Margin = New System.Windows.Forms.Padding(4)
        Me.SAVETICKET.Name = "SAVETICKET"
        Me.SAVETICKET.Size = New System.Drawing.Size(100, 28)
        Me.SAVETICKET.TabIndex = 75
        Me.SAVETICKET.Text = "SAVE"
        Me.SAVETICKET.UseVisualStyleBackColor = True
        '
        'ADDTICKET
        '
        Me.ADDTICKET.Location = New System.Drawing.Point(941, 358)
        Me.ADDTICKET.Margin = New System.Windows.Forms.Padding(4)
        Me.ADDTICKET.Name = "ADDTICKET"
        Me.ADDTICKET.Size = New System.Drawing.Size(100, 28)
        Me.ADDTICKET.TabIndex = 71
        Me.ADDTICKET.Text = "ADD"
        Me.ADDTICKET.UseVisualStyleBackColor = True
        '
        'SEARCHTICKET
        '
        Me.SEARCHTICKET.Location = New System.Drawing.Point(210, 364)
        Me.SEARCHTICKET.Margin = New System.Windows.Forms.Padding(4)
        Me.SEARCHTICKET.Name = "SEARCHTICKET"
        Me.SEARCHTICKET.Size = New System.Drawing.Size(485, 22)
        Me.SEARCHTICKET.TabIndex = 77
        '
        'Panel2CAR
        '
        Me.Panel2CAR.Controls.Add(Me.SEATID)
        Me.Panel2CAR.Controls.Add(Me.Label4)
        Me.Panel2CAR.Controls.Add(Me.FLIGHTID)
        Me.Panel2CAR.Controls.Add(Me.Label3)
        Me.Panel2CAR.Controls.Add(Me.PNRNO)
        Me.Panel2CAR.Controls.Add(Me.Label1)
        Me.Panel2CAR.Controls.Add(Me.TICKETID)
        Me.Panel2CAR.Controls.Add(Me.LabelFNCAR)
        Me.Panel2CAR.Controls.Add(Me.AIRCRAFTNo)
        Me.Panel2CAR.Controls.Add(Me.DATEISSUED)
        Me.Panel2CAR.Location = New System.Drawing.Point(13, 48)
        Me.Panel2CAR.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2CAR.Name = "Panel2CAR"
        Me.Panel2CAR.Size = New System.Drawing.Size(1443, 291)
        Me.Panel2CAR.TabIndex = 72
        '
        'SEATID
        '
        Me.SEATID.Location = New System.Drawing.Point(928, 168)
        Me.SEATID.Margin = New System.Windows.Forms.Padding(4)
        Me.SEATID.Name = "SEATID"
        Me.SEATID.Size = New System.Drawing.Size(485, 22)
        Me.SEATID.TabIndex = 40
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(747, 168)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 32)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Seat ID:"
        '
        'FLIGHTID
        '
        Me.FLIGHTID.Location = New System.Drawing.Point(928, 114)
        Me.FLIGHTID.Margin = New System.Windows.Forms.Padding(4)
        Me.FLIGHTID.Name = "FLIGHTID"
        Me.FLIGHTID.Size = New System.Drawing.Size(485, 22)
        Me.FLIGHTID.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(747, 114)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 32)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Flight ID:"
        '
        'PNRNO
        '
        Me.PNRNO.Location = New System.Drawing.Point(197, 220)
        Me.PNRNO.Margin = New System.Windows.Forms.Padding(4)
        Me.PNRNO.Name = "PNRNO"
        Me.PNRNO.Size = New System.Drawing.Size(485, 22)
        Me.PNRNO.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 220)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 32)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "PNR Number:"
        '
        'TICKETID
        '
        Me.TICKETID.Location = New System.Drawing.Point(197, 114)
        Me.TICKETID.Margin = New System.Windows.Forms.Padding(4)
        Me.TICKETID.Name = "TICKETID"
        Me.TICKETID.Size = New System.Drawing.Size(485, 22)
        Me.TICKETID.TabIndex = 34
        '
        'LabelFNCAR
        '
        Me.LabelFNCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFNCAR.Location = New System.Drawing.Point(15, 168)
        Me.LabelFNCAR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelFNCAR.Name = "LabelFNCAR"
        Me.LabelFNCAR.Size = New System.Drawing.Size(148, 32)
        Me.LabelFNCAR.TabIndex = 25
        Me.LabelFNCAR.Text = "Date Issued:"
        '
        'AIRCRAFTNo
        '
        Me.AIRCRAFTNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AIRCRAFTNo.Location = New System.Drawing.Point(15, 114)
        Me.AIRCRAFTNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AIRCRAFTNo.Name = "AIRCRAFTNo"
        Me.AIRCRAFTNo.Size = New System.Drawing.Size(148, 32)
        Me.AIRCRAFTNo.TabIndex = 24
        Me.AIRCRAFTNo.Text = "Ticket ID:"
        '
        'DATEISSUED
        '
        Me.DATEISSUED.Location = New System.Drawing.Point(197, 168)
        Me.DATEISSUED.Margin = New System.Windows.Forms.Padding(4)
        Me.DATEISSUED.Name = "DATEISSUED"
        Me.DATEISSUED.Size = New System.Drawing.Size(485, 22)
        Me.DATEISSUED.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 36)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "TICKET"
        '
        'TICKBACK
        '
        Me.TICKBACK.Location = New System.Drawing.Point(1218, 358)
        Me.TICKBACK.Margin = New System.Windows.Forms.Padding(4)
        Me.TICKBACK.Name = "TICKBACK"
        Me.TICKBACK.Size = New System.Drawing.Size(100, 28)
        Me.TICKBACK.TabIndex = 78
        Me.TICKBACK.Text = "BACK"
        Me.TICKBACK.UseVisualStyleBackColor = True
        '
        'TICKET
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1469, 768)
        Me.Controls.Add(Me.TICKBACK)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.DGVTICKET)
        Me.Controls.Add(Me.DELETETICKET)
        Me.Controls.Add(Me.SAVETICKET)
        Me.Controls.Add(Me.ADDTICKET)
        Me.Controls.Add(Me.SEARCHTICKET)
        Me.Controls.Add(Me.Panel2CAR)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TICKET"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TICKET"
        CType(Me.DGVTICKET, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2CAR.ResumeLayout(False)
        Me.Panel2CAR.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Search As Label
    Friend WithEvents DGVTICKET As DataGridView
    Private WithEvents DELETETICKET As Button
    Private WithEvents SAVETICKET As Button
    Private WithEvents ADDTICKET As Button
    Private WithEvents SEARCHTICKET As TextBox
    Private WithEvents Panel2CAR As Panel
    Private WithEvents PNRNO As TextBox
    Friend WithEvents Label1 As Label
    Private WithEvents TICKETID As TextBox
    Friend WithEvents LabelFNCAR As Label
    Friend WithEvents AIRCRAFTNo As Label
    Private WithEvents DATEISSUED As TextBox
    Friend WithEvents Label2 As Label
    Private WithEvents TICKBACK As Button
    Private WithEvents SEATID As TextBox
    Friend WithEvents Label4 As Label
    Private WithEvents FLIGHTID As TextBox
    Friend WithEvents Label3 As Label
End Class
