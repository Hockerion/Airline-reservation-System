<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EMPLOYEE
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
        Me.DGVEMPLOYEE = New System.Windows.Forms.DataGridView()
        Me.SAVEEMPLOYEE = New System.Windows.Forms.Button()
        Me.ADDEMPLOYEE = New System.Windows.Forms.Button()
        Me.SEARCHEMPLOYEE = New System.Windows.Forms.TextBox()
        Me.Panel2CAR = New System.Windows.Forms.Panel()
        Me.EMPTEL = New System.Windows.Forms.TextBox()
        Me.EMPADDRESS = New System.Windows.Forms.TextBox()
        Me.EMPID = New System.Windows.Forms.TextBox()
        Me.EMPEMAIL = New System.Windows.Forms.TextBox()
        Me.EMPMNAME = New System.Windows.Forms.TextBox()
        Me.EMPLNAME = New System.Windows.Forms.TextBox()
        Me.LabelTNCAR = New System.Windows.Forms.Label()
        Me.LabelACAR = New System.Windows.Forms.Label()
        Me.LabelECAR = New System.Windows.Forms.Label()
        Me.LabelLNCAR = New System.Windows.Forms.Label()
        Me.LabelMNCAR = New System.Windows.Forms.Label()
        Me.LabelFNCAR = New System.Windows.Forms.Label()
        Me.LabelPNRNCAR = New System.Windows.Forms.Label()
        Me.EMPFNAME = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DELETEMPLOYEE = New System.Windows.Forms.Button()
        Me.EMPBACK = New System.Windows.Forms.Button()
        CType(Me.DGVEMPLOYEE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2CAR.SuspendLayout()
        Me.SuspendLayout()
        '
        'Search
        '
        Me.Search.AutoSize = True
        Me.Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(28, 364)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(128, 20)
        Me.Search.TabIndex = 58
        Me.Search.Text = "Search Emp ID:"
        '
        'DGVEMPLOYEE
        '
        Me.DGVEMPLOYEE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVEMPLOYEE.Location = New System.Drawing.Point(13, 405)
        Me.DGVEMPLOYEE.Name = "DGVEMPLOYEE"
        Me.DGVEMPLOYEE.RowTemplate.Height = 24
        Me.DGVEMPLOYEE.Size = New System.Drawing.Size(1443, 355)
        Me.DGVEMPLOYEE.TabIndex = 57
        '
        'SAVEEMPLOYEE
        '
        Me.SAVEEMPLOYEE.Location = New System.Drawing.Point(1049, 358)
        Me.SAVEEMPLOYEE.Margin = New System.Windows.Forms.Padding(4)
        Me.SAVEEMPLOYEE.Name = "SAVEEMPLOYEE"
        Me.SAVEEMPLOYEE.Size = New System.Drawing.Size(100, 28)
        Me.SAVEEMPLOYEE.TabIndex = 59
        Me.SAVEEMPLOYEE.Text = "SAVE"
        Me.SAVEEMPLOYEE.UseVisualStyleBackColor = True
        '
        'ADDEMPLOYEE
        '
        Me.ADDEMPLOYEE.Location = New System.Drawing.Point(941, 358)
        Me.ADDEMPLOYEE.Margin = New System.Windows.Forms.Padding(4)
        Me.ADDEMPLOYEE.Name = "ADDEMPLOYEE"
        Me.ADDEMPLOYEE.Size = New System.Drawing.Size(100, 28)
        Me.ADDEMPLOYEE.TabIndex = 55
        Me.ADDEMPLOYEE.Text = "ADD"
        Me.ADDEMPLOYEE.UseVisualStyleBackColor = True
        '
        'SEARCHEMPLOYEE
        '
        Me.SEARCHEMPLOYEE.Location = New System.Drawing.Point(210, 364)
        Me.SEARCHEMPLOYEE.Margin = New System.Windows.Forms.Padding(4)
        Me.SEARCHEMPLOYEE.Name = "SEARCHEMPLOYEE"
        Me.SEARCHEMPLOYEE.Size = New System.Drawing.Size(485, 22)
        Me.SEARCHEMPLOYEE.TabIndex = 60
        '
        'Panel2CAR
        '
        Me.Panel2CAR.Controls.Add(Me.EMPTEL)
        Me.Panel2CAR.Controls.Add(Me.EMPADDRESS)
        Me.Panel2CAR.Controls.Add(Me.EMPID)
        Me.Panel2CAR.Controls.Add(Me.EMPEMAIL)
        Me.Panel2CAR.Controls.Add(Me.EMPMNAME)
        Me.Panel2CAR.Controls.Add(Me.EMPLNAME)
        Me.Panel2CAR.Controls.Add(Me.LabelTNCAR)
        Me.Panel2CAR.Controls.Add(Me.LabelACAR)
        Me.Panel2CAR.Controls.Add(Me.LabelECAR)
        Me.Panel2CAR.Controls.Add(Me.LabelLNCAR)
        Me.Panel2CAR.Controls.Add(Me.LabelMNCAR)
        Me.Panel2CAR.Controls.Add(Me.LabelFNCAR)
        Me.Panel2CAR.Controls.Add(Me.LabelPNRNCAR)
        Me.Panel2CAR.Controls.Add(Me.EMPFNAME)
        Me.Panel2CAR.Location = New System.Drawing.Point(13, 48)
        Me.Panel2CAR.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2CAR.Name = "Panel2CAR"
        Me.Panel2CAR.Size = New System.Drawing.Size(1443, 291)
        Me.Panel2CAR.TabIndex = 56
        '
        'EMPTEL
        '
        Me.EMPTEL.Location = New System.Drawing.Point(928, 146)
        Me.EMPTEL.Margin = New System.Windows.Forms.Padding(4)
        Me.EMPTEL.Name = "EMPTEL"
        Me.EMPTEL.Size = New System.Drawing.Size(485, 22)
        Me.EMPTEL.TabIndex = 36
        '
        'EMPADDRESS
        '
        Me.EMPADDRESS.Location = New System.Drawing.Point(928, 114)
        Me.EMPADDRESS.Margin = New System.Windows.Forms.Padding(4)
        Me.EMPADDRESS.Name = "EMPADDRESS"
        Me.EMPADDRESS.Size = New System.Drawing.Size(485, 22)
        Me.EMPADDRESS.TabIndex = 35
        '
        'EMPID
        '
        Me.EMPID.Location = New System.Drawing.Point(197, 81)
        Me.EMPID.Margin = New System.Windows.Forms.Padding(4)
        Me.EMPID.Name = "EMPID"
        Me.EMPID.Size = New System.Drawing.Size(485, 22)
        Me.EMPID.TabIndex = 34
        '
        'EMPEMAIL
        '
        Me.EMPEMAIL.Location = New System.Drawing.Point(928, 81)
        Me.EMPEMAIL.Margin = New System.Windows.Forms.Padding(4)
        Me.EMPEMAIL.Name = "EMPEMAIL"
        Me.EMPEMAIL.Size = New System.Drawing.Size(485, 22)
        Me.EMPEMAIL.TabIndex = 33
        '
        'EMPMNAME
        '
        Me.EMPMNAME.Location = New System.Drawing.Point(197, 145)
        Me.EMPMNAME.Margin = New System.Windows.Forms.Padding(4)
        Me.EMPMNAME.Name = "EMPMNAME"
        Me.EMPMNAME.Size = New System.Drawing.Size(485, 22)
        Me.EMPMNAME.TabIndex = 32
        '
        'EMPLNAME
        '
        Me.EMPLNAME.Location = New System.Drawing.Point(197, 177)
        Me.EMPLNAME.Margin = New System.Windows.Forms.Padding(4)
        Me.EMPLNAME.Name = "EMPLNAME"
        Me.EMPLNAME.Size = New System.Drawing.Size(485, 22)
        Me.EMPLNAME.TabIndex = 31
        '
        'LabelTNCAR
        '
        Me.LabelTNCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTNCAR.Location = New System.Drawing.Point(736, 146)
        Me.LabelTNCAR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTNCAR.Name = "LabelTNCAR"
        Me.LabelTNCAR.Size = New System.Drawing.Size(184, 32)
        Me.LabelTNCAR.TabIndex = 30
        Me.LabelTNCAR.Text = "Telephone Number:"
        '
        'LabelACAR
        '
        Me.LabelACAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelACAR.Location = New System.Drawing.Point(736, 114)
        Me.LabelACAR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelACAR.Name = "LabelACAR"
        Me.LabelACAR.Size = New System.Drawing.Size(96, 32)
        Me.LabelACAR.TabIndex = 29
        Me.LabelACAR.Text = "Address:"
        '
        'LabelECAR
        '
        Me.LabelECAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelECAR.Location = New System.Drawing.Point(736, 81)
        Me.LabelECAR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelECAR.Name = "LabelECAR"
        Me.LabelECAR.Size = New System.Drawing.Size(96, 32)
        Me.LabelECAR.TabIndex = 28
        Me.LabelECAR.Text = "Email:"
        '
        'LabelLNCAR
        '
        Me.LabelLNCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLNCAR.Location = New System.Drawing.Point(15, 178)
        Me.LabelLNCAR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelLNCAR.Name = "LabelLNCAR"
        Me.LabelLNCAR.Size = New System.Drawing.Size(136, 32)
        Me.LabelLNCAR.TabIndex = 27
        Me.LabelLNCAR.Text = "Last Name:"
        '
        'LabelMNCAR
        '
        Me.LabelMNCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMNCAR.Location = New System.Drawing.Point(16, 146)
        Me.LabelMNCAR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelMNCAR.Name = "LabelMNCAR"
        Me.LabelMNCAR.Size = New System.Drawing.Size(148, 32)
        Me.LabelMNCAR.TabIndex = 26
        Me.LabelMNCAR.Text = "Middle Name:"
        '
        'LabelFNCAR
        '
        Me.LabelFNCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFNCAR.Location = New System.Drawing.Point(16, 114)
        Me.LabelFNCAR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelFNCAR.Name = "LabelFNCAR"
        Me.LabelFNCAR.Size = New System.Drawing.Size(148, 32)
        Me.LabelFNCAR.TabIndex = 25
        Me.LabelFNCAR.Text = "First Name:"
        '
        'LabelPNRNCAR
        '
        Me.LabelPNRNCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPNRNCAR.Location = New System.Drawing.Point(15, 82)
        Me.LabelPNRNCAR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPNRNCAR.Name = "LabelPNRNCAR"
        Me.LabelPNRNCAR.Size = New System.Drawing.Size(148, 32)
        Me.LabelPNRNCAR.TabIndex = 24
        Me.LabelPNRNCAR.Text = "Emp ID:"
        '
        'EMPFNAME
        '
        Me.EMPFNAME.Location = New System.Drawing.Point(197, 114)
        Me.EMPFNAME.Margin = New System.Windows.Forms.Padding(4)
        Me.EMPFNAME.Name = "EMPFNAME"
        Me.EMPFNAME.Size = New System.Drawing.Size(485, 22)
        Me.EMPFNAME.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 36)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "EMPLOYEE"
        '
        'DELETEMPLOYEE
        '
        Me.DELETEMPLOYEE.Location = New System.Drawing.Point(1326, 358)
        Me.DELETEMPLOYEE.Margin = New System.Windows.Forms.Padding(4)
        Me.DELETEMPLOYEE.Name = "DELETEMPLOYEE"
        Me.DELETEMPLOYEE.Size = New System.Drawing.Size(100, 28)
        Me.DELETEMPLOYEE.TabIndex = 61
        Me.DELETEMPLOYEE.Text = "DELETE"
        Me.DELETEMPLOYEE.UseVisualStyleBackColor = True
        '
        'EMPBACK
        '
        Me.EMPBACK.Location = New System.Drawing.Point(1218, 358)
        Me.EMPBACK.Margin = New System.Windows.Forms.Padding(4)
        Me.EMPBACK.Name = "EMPBACK"
        Me.EMPBACK.Size = New System.Drawing.Size(100, 28)
        Me.EMPBACK.TabIndex = 62
        Me.EMPBACK.Text = "BACK"
        Me.EMPBACK.UseVisualStyleBackColor = True
        '
        'EMPLOYEE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1469, 768)
        Me.Controls.Add(Me.EMPBACK)
        Me.Controls.Add(Me.DELETEMPLOYEE)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.DGVEMPLOYEE)
        Me.Controls.Add(Me.SAVEEMPLOYEE)
        Me.Controls.Add(Me.ADDEMPLOYEE)
        Me.Controls.Add(Me.SEARCHEMPLOYEE)
        Me.Controls.Add(Me.Panel2CAR)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EMPLOYEE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EMPLOYEE"
        CType(Me.DGVEMPLOYEE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2CAR.ResumeLayout(False)
        Me.Panel2CAR.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Search As Label
    Friend WithEvents DGVEMPLOYEE As DataGridView
    Private WithEvents SAVEEMPLOYEE As Button
    Private WithEvents ADDEMPLOYEE As Button
    Private WithEvents SEARCHEMPLOYEE As TextBox
    Private WithEvents Panel2CAR As Panel
    Private WithEvents EMPTEL As TextBox
    Private WithEvents EMPADDRESS As TextBox
    Private WithEvents EMPID As TextBox
    Private WithEvents EMPEMAIL As TextBox
    Private WithEvents EMPMNAME As TextBox
    Private WithEvents EMPLNAME As TextBox
    Friend WithEvents LabelTNCAR As Label
    Friend WithEvents LabelACAR As Label
    Friend WithEvents LabelECAR As Label
    Friend WithEvents LabelLNCAR As Label
    Friend WithEvents LabelMNCAR As Label
    Friend WithEvents LabelFNCAR As Label
    Friend WithEvents LabelPNRNCAR As Label
    Private WithEvents EMPFNAME As TextBox
    Friend WithEvents Label2 As Label
    Private WithEvents DELETEMPLOYEE As Button
    Private WithEvents EMPBACK As Button
End Class
