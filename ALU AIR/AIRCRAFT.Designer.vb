<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AIRCRAFT
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
        Me.DGVAIRCRAFT = New System.Windows.Forms.DataGridView()
        Me.DELETEAIRCRAFT = New System.Windows.Forms.Button()
        Me.SAVEAIRCRAFT = New System.Windows.Forms.Button()
        Me.ADDAIRCRAFT = New System.Windows.Forms.Button()
        Me.SEARCHAIRCRAFT = New System.Windows.Forms.TextBox()
        Me.Panel2CAR = New System.Windows.Forms.Panel()
        Me.AIRCRAFTID = New System.Windows.Forms.TextBox()
        Me.LabelFNCAR = New System.Windows.Forms.Label()
        Me.AIRCRAFTNo = New System.Windows.Forms.Label()
        Me.CAPACITY = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AIRBACK = New System.Windows.Forms.Button()
        CType(Me.DGVAIRCRAFT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2CAR.SuspendLayout()
        Me.SuspendLayout()
        '
        'Search
        '
        Me.Search.AutoSize = True
        Me.Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(29, 364)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(89, 20)
        Me.Search.TabIndex = 58
        Me.Search.Text = "Search ID:"
        '
        'DGVAIRCRAFT
        '
        Me.DGVAIRCRAFT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAIRCRAFT.Location = New System.Drawing.Point(13, 405)
        Me.DGVAIRCRAFT.Name = "DGVAIRCRAFT"
        Me.DGVAIRCRAFT.RowTemplate.Height = 24
        Me.DGVAIRCRAFT.Size = New System.Drawing.Size(1443, 355)
        Me.DGVAIRCRAFT.TabIndex = 57
        '
        'DELETEAIRCRAFT
        '
        Me.DELETEAIRCRAFT.Location = New System.Drawing.Point(1326, 358)
        Me.DELETEAIRCRAFT.Margin = New System.Windows.Forms.Padding(4)
        Me.DELETEAIRCRAFT.Name = "DELETEAIRCRAFT"
        Me.DELETEAIRCRAFT.Size = New System.Drawing.Size(100, 28)
        Me.DELETEAIRCRAFT.TabIndex = 60
        Me.DELETEAIRCRAFT.Text = "DELETE"
        Me.DELETEAIRCRAFT.UseVisualStyleBackColor = True
        '
        'SAVEAIRCRAFT
        '
        Me.SAVEAIRCRAFT.Location = New System.Drawing.Point(1049, 358)
        Me.SAVEAIRCRAFT.Margin = New System.Windows.Forms.Padding(4)
        Me.SAVEAIRCRAFT.Name = "SAVEAIRCRAFT"
        Me.SAVEAIRCRAFT.Size = New System.Drawing.Size(100, 28)
        Me.SAVEAIRCRAFT.TabIndex = 59
        Me.SAVEAIRCRAFT.Text = "SAVE"
        Me.SAVEAIRCRAFT.UseVisualStyleBackColor = True
        '
        'ADDAIRCRAFT
        '
        Me.ADDAIRCRAFT.Location = New System.Drawing.Point(941, 358)
        Me.ADDAIRCRAFT.Margin = New System.Windows.Forms.Padding(4)
        Me.ADDAIRCRAFT.Name = "ADDAIRCRAFT"
        Me.ADDAIRCRAFT.Size = New System.Drawing.Size(100, 28)
        Me.ADDAIRCRAFT.TabIndex = 55
        Me.ADDAIRCRAFT.Text = "ADD"
        Me.ADDAIRCRAFT.UseVisualStyleBackColor = True
        '
        'SEARCHAIRCRAFT
        '
        Me.SEARCHAIRCRAFT.Location = New System.Drawing.Point(210, 364)
        Me.SEARCHAIRCRAFT.Margin = New System.Windows.Forms.Padding(4)
        Me.SEARCHAIRCRAFT.Name = "SEARCHAIRCRAFT"
        Me.SEARCHAIRCRAFT.Size = New System.Drawing.Size(485, 22)
        Me.SEARCHAIRCRAFT.TabIndex = 61
        '
        'Panel2CAR
        '
        Me.Panel2CAR.Controls.Add(Me.AIRCRAFTID)
        Me.Panel2CAR.Controls.Add(Me.LabelFNCAR)
        Me.Panel2CAR.Controls.Add(Me.AIRCRAFTNo)
        Me.Panel2CAR.Controls.Add(Me.CAPACITY)
        Me.Panel2CAR.Location = New System.Drawing.Point(13, 48)
        Me.Panel2CAR.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2CAR.Name = "Panel2CAR"
        Me.Panel2CAR.Size = New System.Drawing.Size(1443, 291)
        Me.Panel2CAR.TabIndex = 56
        '
        'AIRCRAFTID
        '
        Me.AIRCRAFTID.Location = New System.Drawing.Point(197, 114)
        Me.AIRCRAFTID.Margin = New System.Windows.Forms.Padding(4)
        Me.AIRCRAFTID.Name = "AIRCRAFTID"
        Me.AIRCRAFTID.Size = New System.Drawing.Size(485, 22)
        Me.AIRCRAFTID.TabIndex = 34
        '
        'LabelFNCAR
        '
        Me.LabelFNCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFNCAR.Location = New System.Drawing.Point(15, 168)
        Me.LabelFNCAR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelFNCAR.Name = "LabelFNCAR"
        Me.LabelFNCAR.Size = New System.Drawing.Size(148, 32)
        Me.LabelFNCAR.TabIndex = 25
        Me.LabelFNCAR.Text = "Capacity:"
        '
        'AIRCRAFTNo
        '
        Me.AIRCRAFTNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AIRCRAFTNo.Location = New System.Drawing.Point(15, 114)
        Me.AIRCRAFTNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AIRCRAFTNo.Name = "AIRCRAFTNo"
        Me.AIRCRAFTNo.Size = New System.Drawing.Size(148, 32)
        Me.AIRCRAFTNo.TabIndex = 24
        Me.AIRCRAFTNo.Text = "Aircraft ID:"
        '
        'CAPACITY
        '
        Me.CAPACITY.Location = New System.Drawing.Point(197, 168)
        Me.CAPACITY.Margin = New System.Windows.Forms.Padding(4)
        Me.CAPACITY.Name = "CAPACITY"
        Me.CAPACITY.Size = New System.Drawing.Size(485, 22)
        Me.CAPACITY.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 36)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "AIRCRAFT"
        '
        'AIRBACK
        '
        Me.AIRBACK.Location = New System.Drawing.Point(1218, 358)
        Me.AIRBACK.Margin = New System.Windows.Forms.Padding(4)
        Me.AIRBACK.Name = "AIRBACK"
        Me.AIRBACK.Size = New System.Drawing.Size(100, 28)
        Me.AIRBACK.TabIndex = 63
        Me.AIRBACK.Text = "BACK"
        Me.AIRBACK.UseVisualStyleBackColor = True
        '
        'AIRCRAFT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1469, 768)
        Me.Controls.Add(Me.AIRBACK)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.DGVAIRCRAFT)
        Me.Controls.Add(Me.DELETEAIRCRAFT)
        Me.Controls.Add(Me.SAVEAIRCRAFT)
        Me.Controls.Add(Me.ADDAIRCRAFT)
        Me.Controls.Add(Me.SEARCHAIRCRAFT)
        Me.Controls.Add(Me.Panel2CAR)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AIRCRAFT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AIRCRAFT"
        CType(Me.DGVAIRCRAFT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2CAR.ResumeLayout(False)
        Me.Panel2CAR.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Search As Label
    Friend WithEvents DGVAIRCRAFT As DataGridView
    Private WithEvents DELETEAIRCRAFT As Button
    Private WithEvents SAVEAIRCRAFT As Button
    Private WithEvents ADDAIRCRAFT As Button
    Private WithEvents SEARCHAIRCRAFT As TextBox
    Private WithEvents Panel2CAR As Panel
    Private WithEvents AIRCRAFTID As TextBox
    Friend WithEvents LabelFNCAR As Label
    Friend WithEvents AIRCRAFTNo As Label
    Private WithEvents CAPACITY As TextBox
    Friend WithEvents Label2 As Label
    Private WithEvents AIRBACK As Button
End Class
