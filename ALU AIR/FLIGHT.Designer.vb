<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FLIGHT
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
        Me.DGVFLIGHT = New System.Windows.Forms.DataGridView()
        Me.SAVEFLI = New System.Windows.Forms.Button()
        Me.ADDFLI = New System.Windows.Forms.Button()
        Me.SEARCHFLI = New System.Windows.Forms.TextBox()
        Me.Panel2CAR = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ARRRTIME = New System.Windows.Forms.TextBox()
        Me.DEPPTIME = New System.Windows.Forms.TextBox()
        Me.ARRDATE = New System.Windows.Forms.DateTimePicker()
        Me.DEPDATE = New System.Windows.Forms.DateTimePicker()
        Me.AIRCRAFTID = New System.Windows.Forms.TextBox()
        Me.AIRCRAFTNO = New System.Windows.Forms.Label()
        Me.FARE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DURATION = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelPNCAR = New System.Windows.Forms.Label()
        Me.LabelDoBCAR = New System.Windows.Forms.Label()
        Me.FLIGHTID = New System.Windows.Forms.TextBox()
        Me.ROUTE = New System.Windows.Forms.TextBox()
        Me.DESTINATION = New System.Windows.Forms.TextBox()
        Me.FLIGHTTYPE = New System.Windows.Forms.TextBox()
        Me.LabelTNCAR = New System.Windows.Forms.Label()
        Me.LabelACAR = New System.Windows.Forms.Label()
        Me.LabelECAR = New System.Windows.Forms.Label()
        Me.LabelLNCAR = New System.Windows.Forms.Label()
        Me.LabelMNCAR = New System.Windows.Forms.Label()
        Me.LabelFNCAR = New System.Windows.Forms.Label()
        Me.LabelPNRNCAR = New System.Windows.Forms.Label()
        Me.ORIGIN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DELETEFLI = New System.Windows.Forms.Button()
        Me.FLIBACK = New System.Windows.Forms.Button()
        CType(Me.DGVFLIGHT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2CAR.SuspendLayout()
        Me.SuspendLayout()
        '
        'Search
        '
        Me.Search.AutoSize = True
        Me.Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(29, 364)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(157, 20)
        Me.Search.TabIndex = 58
        Me.Search.Text = "Search Destination:"
        '
        'DGVFLIGHT
        '
        Me.DGVFLIGHT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVFLIGHT.Location = New System.Drawing.Point(13, 405)
        Me.DGVFLIGHT.Name = "DGVFLIGHT"
        Me.DGVFLIGHT.RowTemplate.Height = 24
        Me.DGVFLIGHT.Size = New System.Drawing.Size(1443, 355)
        Me.DGVFLIGHT.TabIndex = 57
        '
        'SAVEFLI
        '
        Me.SAVEFLI.Location = New System.Drawing.Point(1049, 358)
        Me.SAVEFLI.Margin = New System.Windows.Forms.Padding(4)
        Me.SAVEFLI.Name = "SAVEFLI"
        Me.SAVEFLI.Size = New System.Drawing.Size(100, 28)
        Me.SAVEFLI.TabIndex = 59
        Me.SAVEFLI.Text = "SAVE"
        Me.SAVEFLI.UseVisualStyleBackColor = True
        '
        'ADDFLI
        '
        Me.ADDFLI.Location = New System.Drawing.Point(941, 358)
        Me.ADDFLI.Margin = New System.Windows.Forms.Padding(4)
        Me.ADDFLI.Name = "ADDFLI"
        Me.ADDFLI.Size = New System.Drawing.Size(100, 28)
        Me.ADDFLI.TabIndex = 55
        Me.ADDFLI.Text = "ADD"
        Me.ADDFLI.UseVisualStyleBackColor = True
        '
        'SEARCHFLI
        '
        Me.SEARCHFLI.Location = New System.Drawing.Point(210, 364)
        Me.SEARCHFLI.Margin = New System.Windows.Forms.Padding(4)
        Me.SEARCHFLI.Name = "SEARCHFLI"
        Me.SEARCHFLI.Size = New System.Drawing.Size(485, 22)
        Me.SEARCHFLI.TabIndex = 60
        '
        'Panel2CAR
        '
        Me.Panel2CAR.Controls.Add(Me.Label5)
        Me.Panel2CAR.Controls.Add(Me.ARRRTIME)
        Me.Panel2CAR.Controls.Add(Me.DEPPTIME)
        Me.Panel2CAR.Controls.Add(Me.ARRDATE)
        Me.Panel2CAR.Controls.Add(Me.DEPDATE)
        Me.Panel2CAR.Controls.Add(Me.AIRCRAFTID)
        Me.Panel2CAR.Controls.Add(Me.AIRCRAFTNO)
        Me.Panel2CAR.Controls.Add(Me.FARE)
        Me.Panel2CAR.Controls.Add(Me.Label3)
        Me.Panel2CAR.Controls.Add(Me.DURATION)
        Me.Panel2CAR.Controls.Add(Me.Label1)
        Me.Panel2CAR.Controls.Add(Me.LabelPNCAR)
        Me.Panel2CAR.Controls.Add(Me.LabelDoBCAR)
        Me.Panel2CAR.Controls.Add(Me.FLIGHTID)
        Me.Panel2CAR.Controls.Add(Me.ROUTE)
        Me.Panel2CAR.Controls.Add(Me.DESTINATION)
        Me.Panel2CAR.Controls.Add(Me.FLIGHTTYPE)
        Me.Panel2CAR.Controls.Add(Me.LabelTNCAR)
        Me.Panel2CAR.Controls.Add(Me.LabelACAR)
        Me.Panel2CAR.Controls.Add(Me.LabelECAR)
        Me.Panel2CAR.Controls.Add(Me.LabelLNCAR)
        Me.Panel2CAR.Controls.Add(Me.LabelMNCAR)
        Me.Panel2CAR.Controls.Add(Me.LabelFNCAR)
        Me.Panel2CAR.Controls.Add(Me.LabelPNRNCAR)
        Me.Panel2CAR.Controls.Add(Me.ORIGIN)
        Me.Panel2CAR.Location = New System.Drawing.Point(13, 48)
        Me.Panel2CAR.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2CAR.Name = "Panel2CAR"
        Me.Panel2CAR.Size = New System.Drawing.Size(1443, 291)
        Me.Panel2CAR.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1035, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 17)
        Me.Label5.TabIndex = 68
        Me.Label5.Text = "h"
        '
        'ARRRTIME
        '
        Me.ARRRTIME.Location = New System.Drawing.Point(928, 171)
        Me.ARRRTIME.Margin = New System.Windows.Forms.Padding(4)
        Me.ARRRTIME.Name = "ARRRTIME"
        Me.ARRRTIME.Size = New System.Drawing.Size(485, 22)
        Me.ARRRTIME.TabIndex = 67
        Me.ARRRTIME.Text = "00:00:00"
        '
        'DEPPTIME
        '
        Me.DEPPTIME.Location = New System.Drawing.Point(928, 141)
        Me.DEPPTIME.Margin = New System.Windows.Forms.Padding(4)
        Me.DEPPTIME.Name = "DEPPTIME"
        Me.DEPPTIME.Size = New System.Drawing.Size(485, 22)
        Me.DEPPTIME.TabIndex = 66
        Me.DEPPTIME.Text = "00:00:00"
        '
        'ARRDATE
        '
        Me.ARRDATE.Location = New System.Drawing.Point(928, 112)
        Me.ARRDATE.Name = "ARRDATE"
        Me.ARRDATE.Size = New System.Drawing.Size(485, 22)
        Me.ARRDATE.TabIndex = 65
        '
        'DEPDATE
        '
        Me.DEPDATE.Location = New System.Drawing.Point(928, 79)
        Me.DEPDATE.Name = "DEPDATE"
        Me.DEPDATE.Size = New System.Drawing.Size(485, 22)
        Me.DEPDATE.TabIndex = 64
        '
        'AIRCRAFTID
        '
        Me.AIRCRAFTID.Location = New System.Drawing.Point(928, 237)
        Me.AIRCRAFTID.Margin = New System.Windows.Forms.Padding(4)
        Me.AIRCRAFTID.Name = "AIRCRAFTID"
        Me.AIRCRAFTID.Size = New System.Drawing.Size(485, 22)
        Me.AIRCRAFTID.TabIndex = 63
        '
        'AIRCRAFTNO
        '
        Me.AIRCRAFTNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AIRCRAFTNO.Location = New System.Drawing.Point(732, 237)
        Me.AIRCRAFTNO.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AIRCRAFTNO.Name = "AIRCRAFTNO"
        Me.AIRCRAFTNO.Size = New System.Drawing.Size(151, 32)
        Me.AIRCRAFTNO.TabIndex = 62
        Me.AIRCRAFTNO.Text = "Aircraft ID:"
        '
        'FARE
        '
        Me.FARE.Location = New System.Drawing.Point(197, 237)
        Me.FARE.Margin = New System.Windows.Forms.Padding(4)
        Me.FARE.Name = "FARE"
        Me.FARE.Size = New System.Drawing.Size(485, 22)
        Me.FARE.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 237)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 32)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Fare:"
        '
        'DURATION
        '
        Me.DURATION.Enabled = False
        Me.DURATION.Location = New System.Drawing.Point(928, 201)
        Me.DURATION.Margin = New System.Windows.Forms.Padding(4)
        Me.DURATION.Name = "DURATION"
        Me.DURATION.Size = New System.Drawing.Size(100, 22)
        Me.DURATION.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(732, 207)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 32)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Duration:"
        '
        'LabelPNCAR
        '
        Me.LabelPNCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPNCAR.Location = New System.Drawing.Point(732, 145)
        Me.LabelPNCAR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPNCAR.Name = "LabelPNCAR"
        Me.LabelPNCAR.Size = New System.Drawing.Size(184, 32)
        Me.LabelPNCAR.TabIndex = 38
        Me.LabelPNCAR.Text = "Departure Time:"
        '
        'LabelDoBCAR
        '
        Me.LabelDoBCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDoBCAR.Location = New System.Drawing.Point(732, 178)
        Me.LabelDoBCAR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelDoBCAR.Name = "LabelDoBCAR"
        Me.LabelDoBCAR.Size = New System.Drawing.Size(135, 32)
        Me.LabelDoBCAR.TabIndex = 37
        Me.LabelDoBCAR.Text = "Arrival Time:"
        '
        'FLIGHTID
        '
        Me.FLIGHTID.Location = New System.Drawing.Point(197, 81)
        Me.FLIGHTID.Margin = New System.Windows.Forms.Padding(4)
        Me.FLIGHTID.Name = "FLIGHTID"
        Me.FLIGHTID.Size = New System.Drawing.Size(485, 22)
        Me.FLIGHTID.TabIndex = 34
        '
        'ROUTE
        '
        Me.ROUTE.Location = New System.Drawing.Point(197, 207)
        Me.ROUTE.Margin = New System.Windows.Forms.Padding(4)
        Me.ROUTE.Name = "ROUTE"
        Me.ROUTE.Size = New System.Drawing.Size(485, 22)
        Me.ROUTE.TabIndex = 33
        '
        'DESTINATION
        '
        Me.DESTINATION.Location = New System.Drawing.Point(197, 145)
        Me.DESTINATION.Margin = New System.Windows.Forms.Padding(4)
        Me.DESTINATION.Name = "DESTINATION"
        Me.DESTINATION.Size = New System.Drawing.Size(485, 22)
        Me.DESTINATION.TabIndex = 32
        '
        'FLIGHTTYPE
        '
        Me.FLIGHTTYPE.Location = New System.Drawing.Point(197, 177)
        Me.FLIGHTTYPE.Margin = New System.Windows.Forms.Padding(4)
        Me.FLIGHTTYPE.Name = "FLIGHTTYPE"
        Me.FLIGHTTYPE.Size = New System.Drawing.Size(485, 22)
        Me.FLIGHTTYPE.TabIndex = 31
        '
        'LabelTNCAR
        '
        Me.LabelTNCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTNCAR.Location = New System.Drawing.Point(732, 113)
        Me.LabelTNCAR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTNCAR.Name = "LabelTNCAR"
        Me.LabelTNCAR.Size = New System.Drawing.Size(184, 32)
        Me.LabelTNCAR.TabIndex = 30
        Me.LabelTNCAR.Text = "Arrival Date:"
        '
        'LabelACAR
        '
        Me.LabelACAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelACAR.Location = New System.Drawing.Point(732, 81)
        Me.LabelACAR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelACAR.Name = "LabelACAR"
        Me.LabelACAR.Size = New System.Drawing.Size(188, 32)
        Me.LabelACAR.TabIndex = 29
        Me.LabelACAR.Text = "Departure Date:"
        '
        'LabelECAR
        '
        Me.LabelECAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelECAR.Location = New System.Drawing.Point(15, 206)
        Me.LabelECAR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelECAR.Name = "LabelECAR"
        Me.LabelECAR.Size = New System.Drawing.Size(96, 32)
        Me.LabelECAR.TabIndex = 28
        Me.LabelECAR.Text = "Route:"
        '
        'LabelLNCAR
        '
        Me.LabelLNCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLNCAR.Location = New System.Drawing.Point(15, 178)
        Me.LabelLNCAR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelLNCAR.Name = "LabelLNCAR"
        Me.LabelLNCAR.Size = New System.Drawing.Size(136, 32)
        Me.LabelLNCAR.TabIndex = 27
        Me.LabelLNCAR.Text = "Flight Type:"
        '
        'LabelMNCAR
        '
        Me.LabelMNCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMNCAR.Location = New System.Drawing.Point(15, 141)
        Me.LabelMNCAR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelMNCAR.Name = "LabelMNCAR"
        Me.LabelMNCAR.Size = New System.Drawing.Size(148, 32)
        Me.LabelMNCAR.TabIndex = 26
        Me.LabelMNCAR.Text = "Destination:"
        '
        'LabelFNCAR
        '
        Me.LabelFNCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFNCAR.Location = New System.Drawing.Point(15, 114)
        Me.LabelFNCAR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelFNCAR.Name = "LabelFNCAR"
        Me.LabelFNCAR.Size = New System.Drawing.Size(148, 32)
        Me.LabelFNCAR.TabIndex = 25
        Me.LabelFNCAR.Text = "Origin:"
        '
        'LabelPNRNCAR
        '
        Me.LabelPNRNCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPNRNCAR.Location = New System.Drawing.Point(16, 81)
        Me.LabelPNRNCAR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPNRNCAR.Name = "LabelPNRNCAR"
        Me.LabelPNRNCAR.Size = New System.Drawing.Size(148, 32)
        Me.LabelPNRNCAR.TabIndex = 24
        Me.LabelPNRNCAR.Text = "Flight ID:"
        '
        'ORIGIN
        '
        Me.ORIGIN.Location = New System.Drawing.Point(197, 114)
        Me.ORIGIN.Margin = New System.Windows.Forms.Padding(4)
        Me.ORIGIN.Name = "ORIGIN"
        Me.ORIGIN.Size = New System.Drawing.Size(485, 22)
        Me.ORIGIN.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 36)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "FLIGHT"
        '
        'DELETEFLI
        '
        Me.DELETEFLI.Location = New System.Drawing.Point(1326, 358)
        Me.DELETEFLI.Margin = New System.Windows.Forms.Padding(4)
        Me.DELETEFLI.Name = "DELETEFLI"
        Me.DELETEFLI.Size = New System.Drawing.Size(100, 28)
        Me.DELETEFLI.TabIndex = 61
        Me.DELETEFLI.Text = "DELETE"
        Me.DELETEFLI.UseVisualStyleBackColor = True
        '
        'FLIBACK
        '
        Me.FLIBACK.Location = New System.Drawing.Point(1218, 358)
        Me.FLIBACK.Margin = New System.Windows.Forms.Padding(4)
        Me.FLIBACK.Name = "FLIBACK"
        Me.FLIBACK.Size = New System.Drawing.Size(100, 28)
        Me.FLIBACK.TabIndex = 63
        Me.FLIBACK.Text = "BACK"
        Me.FLIBACK.UseVisualStyleBackColor = True
        '
        'FLIGHT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1469, 768)
        Me.Controls.Add(Me.FLIBACK)
        Me.Controls.Add(Me.DELETEFLI)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.DGVFLIGHT)
        Me.Controls.Add(Me.SAVEFLI)
        Me.Controls.Add(Me.ADDFLI)
        Me.Controls.Add(Me.SEARCHFLI)
        Me.Controls.Add(Me.Panel2CAR)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FLIGHT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FLIGHT"
        CType(Me.DGVFLIGHT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2CAR.ResumeLayout(False)
        Me.Panel2CAR.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Search As Label
    Friend WithEvents DGVFLIGHT As DataGridView
    Private WithEvents SAVEFLI As Button
    Private WithEvents ADDFLI As Button
    Private WithEvents SEARCHFLI As TextBox
    Private WithEvents Panel2CAR As Panel
    Friend WithEvents LabelPNCAR As Label
    Friend WithEvents LabelDoBCAR As Label
    Private WithEvents FLIGHTID As TextBox
    Private WithEvents ROUTE As TextBox
    Private WithEvents DESTINATION As TextBox
    Private WithEvents FLIGHTTYPE As TextBox
    Friend WithEvents LabelTNCAR As Label
    Friend WithEvents LabelACAR As Label
    Friend WithEvents LabelECAR As Label
    Friend WithEvents LabelLNCAR As Label
    Friend WithEvents LabelMNCAR As Label
    Friend WithEvents LabelFNCAR As Label
    Friend WithEvents LabelPNRNCAR As Label
    Private WithEvents ORIGIN As TextBox
    Friend WithEvents Label2 As Label
    Private WithEvents FARE As TextBox
    Friend WithEvents Label3 As Label
    Private WithEvents DURATION As TextBox
    Friend WithEvents Label1 As Label
    Private WithEvents DELETEFLI As Button
    Private WithEvents AIRCRAFTID As TextBox
    Friend WithEvents AIRCRAFTNO As Label
    Private WithEvents FLIBACK As Button
    Friend WithEvents DEPDATE As DateTimePicker
    Friend WithEvents ARRDATE As DateTimePicker
    Friend WithEvents ARRTIME As DateTimePicker
    Friend WithEvents DEPTIME As DateTimePicker
    Private WithEvents ARRRTIME As TextBox
    Private WithEvents DEPPTIME As TextBox
    Friend WithEvents Label5 As Label
End Class
