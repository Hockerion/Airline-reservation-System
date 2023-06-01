<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BOOK
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGVFLIGHT = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Search = New System.Windows.Forms.Label()
        Me.SEARCHFLI = New System.Windows.Forms.TextBox()
        CType(Me.DGVFLIGHT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Flights"
        '
        'DGVFLIGHT
        '
        Me.DGVFLIGHT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVFLIGHT.Location = New System.Drawing.Point(12, 135)
        Me.DGVFLIGHT.Name = "DGVFLIGHT"
        Me.DGVFLIGHT.RowTemplate.Height = 24
        Me.DGVFLIGHT.Size = New System.Drawing.Size(1454, 605)
        Me.DGVFLIGHT.TabIndex = 58
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1339, 764)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 42)
        Me.Button1.TabIndex = 61
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Search
        '
        Me.Search.AutoSize = True
        Me.Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(12, 86)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(183, 25)
        Me.Search.TabIndex = 62
        Me.Search.Text = "Search Destination:"
        '
        'SEARCHFLI
        '
        Me.SEARCHFLI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SEARCHFLI.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SEARCHFLI.Location = New System.Drawing.Point(258, 86)
        Me.SEARCHFLI.Margin = New System.Windows.Forms.Padding(4)
        Me.SEARCHFLI.Name = "SEARCHFLI"
        Me.SEARCHFLI.Size = New System.Drawing.Size(485, 28)
        Me.SEARCHFLI.TabIndex = 63
        '
        'BOOK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1478, 818)
        Me.Controls.Add(Me.SEARCHFLI)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DGVFLIGHT)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BOOK"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choose Flight"
        CType(Me.DGVFLIGHT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DGVFLIGHT As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Search As Label
    Private WithEvents SEARCHFLI As TextBox
End Class
