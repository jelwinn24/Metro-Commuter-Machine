<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJPCurrent
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
        Me.lblCurrentStation = New System.Windows.Forms.Label()
        Me.cmbCurrent = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblCurrentStation
        '
        Me.lblCurrentStation.Font = New System.Drawing.Font("Segoe UI Black", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentStation.Location = New System.Drawing.Point(106, 30)
        Me.lblCurrentStation.Name = "lblCurrentStation"
        Me.lblCurrentStation.Size = New System.Drawing.Size(720, 67)
        Me.lblCurrentStation.TabIndex = 0
        Me.lblCurrentStation.Text = "Choose your Current Station"
        '
        'cmbCurrent
        '
        Me.cmbCurrent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbCurrent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCurrent.FormattingEnabled = True
        Me.cmbCurrent.Location = New System.Drawing.Point(66, 119)
        Me.cmbCurrent.Name = "cmbCurrent"
        Me.cmbCurrent.Size = New System.Drawing.Size(774, 28)
        Me.cmbCurrent.TabIndex = 1
        '
        'frmJPCurrent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 565)
        Me.Controls.Add(Me.cmbCurrent)
        Me.Controls.Add(Me.lblCurrentStation)
        Me.Name = "frmJPCurrent"
        Me.Text = "Journey Planner"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblCurrentStation As Label
    Friend WithEvents cmbCurrent As ComboBox
End Class
