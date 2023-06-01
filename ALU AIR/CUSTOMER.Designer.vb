<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CUSTOMER
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Search = New System.Windows.Forms.Label()
        Me.DGVCUSTOMER = New System.Windows.Forms.DataGridView()
        Me.PASSPORTNO = New System.Windows.Forms.TextBox()
        Me.CUSDOB = New System.Windows.Forms.TextBox()
        Me.LabelPNCAR = New System.Windows.Forms.Label()
        Me.LabelDoBCAR = New System.Windows.Forms.Label()
        Me.CUSTEL = New System.Windows.Forms.TextBox()
        Me.CUSADDRESS = New System.Windows.Forms.TextBox()
        Me.PNRNO = New System.Windows.Forms.TextBox()
        Me.CUSEMAIL = New System.Windows.Forms.TextBox()
        Me.CUSMNAME = New System.Windows.Forms.TextBox()
        Me.CUSLNAME = New System.Windows.Forms.TextBox()
        Me.LabelTNCAR = New System.Windows.Forms.Label()
        Me.DELETECUS = New System.Windows.Forms.Button()
        Me.SAVECUS = New System.Windows.Forms.Button()
        Me.ADDCUS = New System.Windows.Forms.Button()
        Me.LabelACAR = New System.Windows.Forms.Label()
        Me.LabelECAR = New System.Windows.Forms.Label()
        Me.LabelLNCAR = New System.Windows.Forms.Label()
        Me.LabelFNCAR = New System.Windows.Forms.Label()
        Me.LabelPNRNCAR = New System.Windows.Forms.Label()
        Me.CUSFNAME = New System.Windows.Forms.TextBox()
        Me.SEARCHCUS = New System.Windows.Forms.TextBox()
        Me.Panel2CAR = New System.Windows.Forms.Panel()
        Me.LabelMNCAR = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CUSBACK = New System.Windows.Forms.Button()
        CType(Me.DGVCUSTOMER, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2CAR.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, -83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 36)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "CUSTOMER "
        '
        'Search
        '
        Me.Search.AutoSize = True
        Me.Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(28, 366)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(132, 20)
        Me.Search.TabIndex = 50
        Me.Search.Text = "Search PNRNO:"
        '
        'DGVCUSTOMER
        '
        Me.DGVCUSTOMER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCUSTOMER.Location = New System.Drawing.Point(13, 405)
        Me.DGVCUSTOMER.Name = "DGVCUSTOMER"
        Me.DGVCUSTOMER.RowTemplate.Height = 24
        Me.DGVCUSTOMER.Size = New System.Drawing.Size(1443, 355)
        Me.DGVCUSTOMER.TabIndex = 49
        '
        'PASSPORTNO
        '
        Me.PASSPORTNO.Location = New System.Drawing.Point(928, 247)
        Me.PASSPORTNO.Margin = New System.Windows.Forms.Padding(4)
        Me.PASSPORTNO.Name = "PASSPORTNO"
        Me.PASSPORTNO.Size = New System.Drawing.Size(485, 22)
        Me.PASSPORTNO.TabIndex = 40
        '
        'CUSDOB
        '
        Me.CUSDOB.Location = New System.Drawing.Point(197, 247)
        Me.CUSDOB.Margin = New System.Windows.Forms.Padding(4)
        Me.CUSDOB.Name = "CUSDOB"
        Me.CUSDOB.Size = New System.Drawing.Size(485, 22)
        Me.CUSDOB.TabIndex = 39
        '
        'LabelPNCAR
        '
        Me.LabelPNCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPNCAR.Location = New System.Drawing.Point(736, 247)
        Me.LabelPNCAR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPNCAR.Name = "LabelPNCAR"
        Me.LabelPNCAR.Size = New System.Drawing.Size(184, 32)
        Me.LabelPNCAR.TabIndex = 38
        Me.LabelPNCAR.Text = "Passport Number:"
        '
        'LabelDoBCAR
        '
        Me.LabelDoBCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDoBCAR.Location = New System.Drawing.Point(15, 247)
        Me.LabelDoBCAR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelDoBCAR.Name = "LabelDoBCAR"
        Me.LabelDoBCAR.Size = New System.Drawing.Size(135, 32)
        Me.LabelDoBCAR.TabIndex = 37
        Me.LabelDoBCAR.Text = "Date of Birth:"
        '
        'CUSTEL
        '
        Me.CUSTEL.Location = New System.Drawing.Point(928, 146)
        Me.CUSTEL.Margin = New System.Windows.Forms.Padding(4)
        Me.CUSTEL.Name = "CUSTEL"
        Me.CUSTEL.Size = New System.Drawing.Size(485, 22)
        Me.CUSTEL.TabIndex = 36
        '
        'CUSADDRESS
        '
        Me.CUSADDRESS.Location = New System.Drawing.Point(928, 114)
        Me.CUSADDRESS.Margin = New System.Windows.Forms.Padding(4)
        Me.CUSADDRESS.Name = "CUSADDRESS"
        Me.CUSADDRESS.Size = New System.Drawing.Size(485, 22)
        Me.CUSADDRESS.TabIndex = 35
        '
        'PNRNO
        '
        Me.PNRNO.Location = New System.Drawing.Point(197, 81)
        Me.PNRNO.Margin = New System.Windows.Forms.Padding(4)
        Me.PNRNO.Name = "PNRNO"
        Me.PNRNO.Size = New System.Drawing.Size(485, 22)
        Me.PNRNO.TabIndex = 34
        '
        'CUSEMAIL
        '
        Me.CUSEMAIL.Location = New System.Drawing.Point(928, 81)
        Me.CUSEMAIL.Margin = New System.Windows.Forms.Padding(4)
        Me.CUSEMAIL.Name = "CUSEMAIL"
        Me.CUSEMAIL.Size = New System.Drawing.Size(485, 22)
        Me.CUSEMAIL.TabIndex = 33
        '
        'CUSMNAME
        '
        Me.CUSMNAME.Location = New System.Drawing.Point(197, 145)
        Me.CUSMNAME.Margin = New System.Windows.Forms.Padding(4)
        Me.CUSMNAME.Name = "CUSMNAME"
        Me.CUSMNAME.Size = New System.Drawing.Size(485, 22)
        Me.CUSMNAME.TabIndex = 32
        '
        'CUSLNAME
        '
        Me.CUSLNAME.Location = New System.Drawing.Point(197, 177)
        Me.CUSLNAME.Margin = New System.Windows.Forms.Padding(4)
        Me.CUSLNAME.Name = "CUSLNAME"
        Me.CUSLNAME.Size = New System.Drawing.Size(485, 22)
        Me.CUSLNAME.TabIndex = 31
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
        'DELETECUS
        '
        Me.DELETECUS.Location = New System.Drawing.Point(1326, 358)
        Me.DELETECUS.Margin = New System.Windows.Forms.Padding(4)
        Me.DELETECUS.Name = "DELETECUS"
        Me.DELETECUS.Size = New System.Drawing.Size(100, 28)
        Me.DELETECUS.TabIndex = 52
        Me.DELETECUS.Text = "DELETE"
        Me.DELETECUS.UseVisualStyleBackColor = True
        '
        'SAVECUS
        '
        Me.SAVECUS.Location = New System.Drawing.Point(1049, 358)
        Me.SAVECUS.Margin = New System.Windows.Forms.Padding(4)
        Me.SAVECUS.Name = "SAVECUS"
        Me.SAVECUS.Size = New System.Drawing.Size(100, 28)
        Me.SAVECUS.TabIndex = 51
        Me.SAVECUS.Text = "SAVE"
        Me.SAVECUS.UseVisualStyleBackColor = True
        '
        'ADDCUS
        '
        Me.ADDCUS.Location = New System.Drawing.Point(941, 358)
        Me.ADDCUS.Margin = New System.Windows.Forms.Padding(4)
        Me.ADDCUS.Name = "ADDCUS"
        Me.ADDCUS.Size = New System.Drawing.Size(100, 28)
        Me.ADDCUS.TabIndex = 47
        Me.ADDCUS.Text = "ADD"
        Me.ADDCUS.UseVisualStyleBackColor = True
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
        Me.LabelPNRNCAR.Text = "PNR Number:"
        '
        'CUSFNAME
        '
        Me.CUSFNAME.Location = New System.Drawing.Point(197, 114)
        Me.CUSFNAME.Margin = New System.Windows.Forms.Padding(4)
        Me.CUSFNAME.Name = "CUSFNAME"
        Me.CUSFNAME.Size = New System.Drawing.Size(485, 22)
        Me.CUSFNAME.TabIndex = 0
        '
        'SEARCHCUS
        '
        Me.SEARCHCUS.Location = New System.Drawing.Point(210, 364)
        Me.SEARCHCUS.Margin = New System.Windows.Forms.Padding(4)
        Me.SEARCHCUS.Name = "SEARCHCUS"
        Me.SEARCHCUS.Size = New System.Drawing.Size(485, 22)
        Me.SEARCHCUS.TabIndex = 53
        '
        'Panel2CAR
        '
        Me.Panel2CAR.Controls.Add(Me.PASSPORTNO)
        Me.Panel2CAR.Controls.Add(Me.CUSDOB)
        Me.Panel2CAR.Controls.Add(Me.LabelPNCAR)
        Me.Panel2CAR.Controls.Add(Me.LabelDoBCAR)
        Me.Panel2CAR.Controls.Add(Me.CUSTEL)
        Me.Panel2CAR.Controls.Add(Me.CUSADDRESS)
        Me.Panel2CAR.Controls.Add(Me.PNRNO)
        Me.Panel2CAR.Controls.Add(Me.CUSEMAIL)
        Me.Panel2CAR.Controls.Add(Me.CUSMNAME)
        Me.Panel2CAR.Controls.Add(Me.CUSLNAME)
        Me.Panel2CAR.Controls.Add(Me.LabelTNCAR)
        Me.Panel2CAR.Controls.Add(Me.LabelACAR)
        Me.Panel2CAR.Controls.Add(Me.LabelECAR)
        Me.Panel2CAR.Controls.Add(Me.LabelLNCAR)
        Me.Panel2CAR.Controls.Add(Me.LabelMNCAR)
        Me.Panel2CAR.Controls.Add(Me.LabelFNCAR)
        Me.Panel2CAR.Controls.Add(Me.LabelPNRNCAR)
        Me.Panel2CAR.Controls.Add(Me.CUSFNAME)
        Me.Panel2CAR.Location = New System.Drawing.Point(13, 48)
        Me.Panel2CAR.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2CAR.Name = "Panel2CAR"
        Me.Panel2CAR.Size = New System.Drawing.Size(1443, 291)
        Me.Panel2CAR.TabIndex = 48
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 36)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "CUSTOMER "
        '
        'CUSBACK
        '
        Me.CUSBACK.Location = New System.Drawing.Point(1218, 358)
        Me.CUSBACK.Margin = New System.Windows.Forms.Padding(4)
        Me.CUSBACK.Name = "CUSBACK"
        Me.CUSBACK.Size = New System.Drawing.Size(100, 28)
        Me.CUSBACK.TabIndex = 64
        Me.CUSBACK.Text = "BACK"
        Me.CUSBACK.UseVisualStyleBackColor = True
        '
        'CUSTOMER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1469, 768)
        Me.Controls.Add(Me.CUSBACK)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.DGVCUSTOMER)
        Me.Controls.Add(Me.DELETECUS)
        Me.Controls.Add(Me.SAVECUS)
        Me.Controls.Add(Me.ADDCUS)
        Me.Controls.Add(Me.SEARCHCUS)
        Me.Controls.Add(Me.Panel2CAR)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CUSTOMER"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.DGVCUSTOMER, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2CAR.ResumeLayout(False)
        Me.Panel2CAR.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Search As Label
    Friend WithEvents DGVCUSTOMER As DataGridView
    Private WithEvents PASSPORTNO As TextBox
    Private WithEvents CUSDOB As TextBox
    Friend WithEvents LabelPNCAR As Label
    Friend WithEvents LabelDoBCAR As Label
    Private WithEvents CUSTEL As TextBox
    Private WithEvents CUSADDRESS As TextBox
    Private WithEvents PNRNO As TextBox
    Private WithEvents CUSEMAIL As TextBox
    Private WithEvents CUSMNAME As TextBox
    Private WithEvents CUSLNAME As TextBox
    Friend WithEvents LabelTNCAR As Label
    Private WithEvents DELETECUS As Button
    Private WithEvents SAVECUS As Button
    Private WithEvents ADDCUS As Button
    Friend WithEvents LabelACAR As Label
    Friend WithEvents LabelECAR As Label
    Friend WithEvents LabelLNCAR As Label
    Friend WithEvents LabelFNCAR As Label
    Friend WithEvents LabelPNRNCAR As Label
    Private WithEvents CUSFNAME As TextBox
    Private WithEvents SEARCHCUS As TextBox
    Private WithEvents Panel2CAR As Panel
    Friend WithEvents LabelMNCAR As Label
    Friend WithEvents Label2 As Label
    Private WithEvents CUSBACK As Button
End Class
