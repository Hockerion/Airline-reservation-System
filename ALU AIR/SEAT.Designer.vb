<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Seat
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
        Me.SEATBACK = New System.Windows.Forms.Button()
        Me.Search = New System.Windows.Forms.Label()
        Me.DGVSEAT = New System.Windows.Forms.DataGridView()
        Me.DELETESEAT = New System.Windows.Forms.Button()
        Me.SAVESEAT = New System.Windows.Forms.Button()
        Me.ADDSEAT = New System.Windows.Forms.Button()
        Me.SEARCHSEAT = New System.Windows.Forms.TextBox()
        Me.Panel2CAR = New System.Windows.Forms.Panel()
        Me.STATUS = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SEATID = New System.Windows.Forms.TextBox()
        Me.LabelFNCAR = New System.Windows.Forms.Label()
        Me.AIRCRAFTNo = New System.Windows.Forms.Label()
        Me.CLASSS = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DGVSEAT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2CAR.SuspendLayout()
        Me.SuspendLayout()
        '
        'SEATBACK
        '
        Me.SEATBACK.Location = New System.Drawing.Point(1218, 358)
        Me.SEATBACK.Margin = New System.Windows.Forms.Padding(4)
        Me.SEATBACK.Name = "SEATBACK"
        Me.SEATBACK.Size = New System.Drawing.Size(100, 28)
        Me.SEATBACK.TabIndex = 79
        Me.SEATBACK.Text = "BACK"
        Me.SEATBACK.UseVisualStyleBackColor = True
        '
        'Search
        '
        Me.Search.AutoSize = True
        Me.Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(28, 364)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(115, 20)
        Me.Search.TabIndex = 75
        Me.Search.Text = "Search Class:"
        '
        'DGVSEAT
        '
        Me.DGVSEAT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSEAT.Location = New System.Drawing.Point(13, 405)
        Me.DGVSEAT.Name = "DGVSEAT"
        Me.DGVSEAT.RowTemplate.Height = 24
        Me.DGVSEAT.Size = New System.Drawing.Size(1443, 355)
        Me.DGVSEAT.TabIndex = 74
        '
        'DELETESEAT
        '
        Me.DELETESEAT.Location = New System.Drawing.Point(1326, 358)
        Me.DELETESEAT.Margin = New System.Windows.Forms.Padding(4)
        Me.DELETESEAT.Name = "DELETESEAT"
        Me.DELETESEAT.Size = New System.Drawing.Size(100, 28)
        Me.DELETESEAT.TabIndex = 77
        Me.DELETESEAT.Text = "DELETE"
        Me.DELETESEAT.UseVisualStyleBackColor = True
        '
        'SAVESEAT
        '
        Me.SAVESEAT.Location = New System.Drawing.Point(1049, 358)
        Me.SAVESEAT.Margin = New System.Windows.Forms.Padding(4)
        Me.SAVESEAT.Name = "SAVESEAT"
        Me.SAVESEAT.Size = New System.Drawing.Size(100, 28)
        Me.SAVESEAT.TabIndex = 76
        Me.SAVESEAT.Text = "SAVE"
        Me.SAVESEAT.UseVisualStyleBackColor = True
        '
        'ADDSEAT
        '
        Me.ADDSEAT.Location = New System.Drawing.Point(941, 358)
        Me.ADDSEAT.Margin = New System.Windows.Forms.Padding(4)
        Me.ADDSEAT.Name = "ADDSEAT"
        Me.ADDSEAT.Size = New System.Drawing.Size(100, 28)
        Me.ADDSEAT.TabIndex = 72
        Me.ADDSEAT.Text = "ADD"
        Me.ADDSEAT.UseVisualStyleBackColor = True
        '
        'SEARCHSEAT
        '
        Me.SEARCHSEAT.Location = New System.Drawing.Point(210, 364)
        Me.SEARCHSEAT.Margin = New System.Windows.Forms.Padding(4)
        Me.SEARCHSEAT.Name = "SEARCHSEAT"
        Me.SEARCHSEAT.Size = New System.Drawing.Size(485, 22)
        Me.SEARCHSEAT.TabIndex = 78
        '
        'Panel2CAR
        '
        Me.Panel2CAR.Controls.Add(Me.STATUS)
        Me.Panel2CAR.Controls.Add(Me.Label1)
        Me.Panel2CAR.Controls.Add(Me.SEATID)
        Me.Panel2CAR.Controls.Add(Me.LabelFNCAR)
        Me.Panel2CAR.Controls.Add(Me.AIRCRAFTNo)
        Me.Panel2CAR.Controls.Add(Me.CLASSS)
        Me.Panel2CAR.Location = New System.Drawing.Point(13, 48)
        Me.Panel2CAR.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2CAR.Name = "Panel2CAR"
        Me.Panel2CAR.Size = New System.Drawing.Size(1443, 291)
        Me.Panel2CAR.TabIndex = 73
        '
        'STATUS
        '
        Me.STATUS.Location = New System.Drawing.Point(928, 114)
        Me.STATUS.Margin = New System.Windows.Forms.Padding(4)
        Me.STATUS.Name = "STATUS"
        Me.STATUS.Size = New System.Drawing.Size(485, 22)
        Me.STATUS.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(752, 114)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 32)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Status:"
        '
        'SEATID
        '
        Me.SEATID.Location = New System.Drawing.Point(197, 114)
        Me.SEATID.Margin = New System.Windows.Forms.Padding(4)
        Me.SEATID.Name = "SEATID"
        Me.SEATID.Size = New System.Drawing.Size(485, 22)
        Me.SEATID.TabIndex = 34
        '
        'LabelFNCAR
        '
        Me.LabelFNCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFNCAR.Location = New System.Drawing.Point(15, 168)
        Me.LabelFNCAR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelFNCAR.Name = "LabelFNCAR"
        Me.LabelFNCAR.Size = New System.Drawing.Size(148, 32)
        Me.LabelFNCAR.TabIndex = 25
        Me.LabelFNCAR.Text = "Class:"
        '
        'AIRCRAFTNo
        '
        Me.AIRCRAFTNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AIRCRAFTNo.Location = New System.Drawing.Point(15, 114)
        Me.AIRCRAFTNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AIRCRAFTNo.Name = "AIRCRAFTNo"
        Me.AIRCRAFTNo.Size = New System.Drawing.Size(148, 32)
        Me.AIRCRAFTNo.TabIndex = 24
        Me.AIRCRAFTNo.Text = "Seat ID:"
        '
        'CLASSS
        '
        Me.CLASSS.Location = New System.Drawing.Point(197, 168)
        Me.CLASSS.Margin = New System.Windows.Forms.Padding(4)
        Me.CLASSS.Name = "CLASSS"
        Me.CLASSS.Size = New System.Drawing.Size(485, 22)
        Me.CLASSS.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 36)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Seat"
        '
        'Seat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1469, 768)
        Me.Controls.Add(Me.SEATBACK)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.DGVSEAT)
        Me.Controls.Add(Me.DELETESEAT)
        Me.Controls.Add(Me.SAVESEAT)
        Me.Controls.Add(Me.ADDSEAT)
        Me.Controls.Add(Me.SEARCHSEAT)
        Me.Controls.Add(Me.Panel2CAR)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Seat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seat"
        CType(Me.DGVSEAT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2CAR.ResumeLayout(False)
        Me.Panel2CAR.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents SEATBACK As Button
    Friend WithEvents Search As Label
    Friend WithEvents DGVSEAT As DataGridView
    Private WithEvents DELETESEAT As Button
    Private WithEvents SAVESEAT As Button
    Private WithEvents ADDSEAT As Button
    Private WithEvents SEARCHSEAT As TextBox
    Private WithEvents Panel2CAR As Panel
    Private WithEvents STATUS As TextBox
    Friend WithEvents Label1 As Label
    Private WithEvents SEATID As TextBox
    Friend WithEvents LabelFNCAR As Label
    Friend WithEvents AIRCRAFTNo As Label
    Private WithEvents CLASSS As TextBox
    Friend WithEvents Label2 As Label
End Class
