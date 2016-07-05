<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.btnJP = New System.Windows.Forms.Button()
        Me.btnNT = New System.Windows.Forms.Button()
        Me.lblTIcket = New System.Windows.Forms.LinkLabel()
        Me.lblSafety = New System.Windows.Forms.LinkLabel()
        Me.lblContact = New System.Windows.Forms.LinkLabel()
        Me.lblEmergency = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'btnJP
        '
        Me.btnJP.BackgroundImage = CType(resources.GetObject("btnJP.BackgroundImage"), System.Drawing.Image)
        Me.btnJP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnJP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJP.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnJP.Location = New System.Drawing.Point(76, 423)
        Me.btnJP.Name = "btnJP"
        Me.btnJP.Size = New System.Drawing.Size(193, 89)
        Me.btnJP.TabIndex = 0
        Me.btnJP.Text = "Journey Planner"
        Me.btnJP.UseVisualStyleBackColor = True
        '
        'btnNT
        '
        Me.btnNT.BackColor = System.Drawing.Color.Cornsilk
        Me.btnNT.BackgroundImage = CType(resources.GetObject("btnNT.BackgroundImage"), System.Drawing.Image)
        Me.btnNT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNT.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNT.Location = New System.Drawing.Point(649, 423)
        Me.btnNT.Name = "btnNT"
        Me.btnNT.Size = New System.Drawing.Size(193, 89)
        Me.btnNT.TabIndex = 1
        Me.btnNT.Text = "Next Train"
        Me.btnNT.UseVisualStyleBackColor = False
        '
        'lblTIcket
        '
        Me.lblTIcket.AutoSize = True
        Me.lblTIcket.Location = New System.Drawing.Point(54, 34)
        Me.lblTIcket.Name = "lblTIcket"
        Me.lblTIcket.Size = New System.Drawing.Size(59, 20)
        Me.lblTIcket.TabIndex = 2
        Me.lblTIcket.TabStop = True
        Me.lblTIcket.Text = "Tickets"
        '
        'lblSafety
        '
        Me.lblSafety.AutoSize = True
        Me.lblSafety.Location = New System.Drawing.Point(219, 34)
        Me.lblSafety.Name = "lblSafety"
        Me.lblSafety.Size = New System.Drawing.Size(55, 20)
        Me.lblSafety.TabIndex = 3
        Me.lblSafety.TabStop = True
        Me.lblSafety.Text = "Safety"
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Location = New System.Drawing.Point(782, 34)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(65, 20)
        Me.lblContact.TabIndex = 5
        Me.lblContact.TabStop = True
        Me.lblContact.Text = "Contact"
        '
        'lblEmergency
        '
        Me.lblEmergency.AutoSize = True
        Me.lblEmergency.Location = New System.Drawing.Point(617, 34)
        Me.lblEmergency.Name = "lblEmergency"
        Me.lblEmergency.Size = New System.Drawing.Size(89, 20)
        Me.lblEmergency.TabIndex = 4
        Me.lblEmergency.TabStop = True
        Me.lblEmergency.Text = "Emergency"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(943, 556)
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.lblEmergency)
        Me.Controls.Add(Me.lblSafety)
        Me.Controls.Add(Me.lblTIcket)
        Me.Controls.Add(Me.btnNT)
        Me.Controls.Add(Me.btnJP)
        Me.Name = "frmMenu"
        Me.Text = "frmMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnJP As Button
    Friend WithEvents btnNT As Button
    Friend WithEvents lblTIcket As LinkLabel
    Friend WithEvents lblSafety As LinkLabel
    Friend WithEvents lblContact As LinkLabel
    Friend WithEvents lblEmergency As LinkLabel
End Class
