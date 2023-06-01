<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Choose_Seat
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
        Me.SEARCHCLASS = New System.Windows.Forms.TextBox()
        Me.Search = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DGVSEAT = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGVSEAT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SEARCHCLASS
        '
        Me.SEARCHCLASS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SEARCHCLASS.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SEARCHCLASS.Location = New System.Drawing.Point(258, 88)
        Me.SEARCHCLASS.Margin = New System.Windows.Forms.Padding(4)
        Me.SEARCHCLASS.Name = "SEARCHCLASS"
        Me.SEARCHCLASS.Size = New System.Drawing.Size(485, 28)
        Me.SEARCHCLASS.TabIndex = 68
        '
        'Search
        '
        Me.Search.AutoSize = True
        Me.Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(12, 88)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(130, 25)
        Me.Search.TabIndex = 67
        Me.Search.Text = "Search Class"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1339, 766)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 42)
        Me.Button1.TabIndex = 66
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DGVSEAT
        '
        Me.DGVSEAT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSEAT.Location = New System.Drawing.Point(12, 137)
        Me.DGVSEAT.Name = "DGVSEAT"
        Me.DGVSEAT.RowTemplate.Height = 24
        Me.DGVSEAT.Size = New System.Drawing.Size(1454, 605)
        Me.DGVSEAT.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 38)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Seats"
        '
        'Choose_Seat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1478, 818)
        Me.Controls.Add(Me.SEARCHCLASS)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DGVSEAT)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Choose_Seat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choose_Seat"
        CType(Me.DGVSEAT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents SEARCHCLASS As TextBox
    Friend WithEvents Search As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DGVSEAT As DataGridView
    Friend WithEvents Label1 As Label
End Class
