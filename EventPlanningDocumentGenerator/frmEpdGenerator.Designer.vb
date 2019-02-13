<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEpdGenerator
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.txtProgramName = New System.Windows.Forms.TextBox()
        Me.dgdEvents = New System.Windows.Forms.DataGridView()
        Me.colObject = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEventTrigger = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEventProcessing = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblObjectName = New System.Windows.Forms.Label()
        Me.txtObject = New System.Windows.Forms.TextBox()
        Me.lblDeveloper = New System.Windows.Forms.Label()
        Me.txtDeveloper = New System.Windows.Forms.TextBox()
        Me.lblProgramName = New System.Windows.Forms.Label()
        Me.btnImport = New System.Windows.Forms.Button()
        CType(Me.dgdEvents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGenerate
        '
        Me.btnGenerate.Enabled = False
        Me.btnGenerate.Location = New System.Drawing.Point(387, 35)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(95, 23)
        Me.btnGenerate.TabIndex = 0
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'txtProgramName
        '
        Me.txtProgramName.Location = New System.Drawing.Point(98, 11)
        Me.txtProgramName.Name = "txtProgramName"
        Me.txtProgramName.Size = New System.Drawing.Size(150, 20)
        Me.txtProgramName.TabIndex = 1
        '
        'dgdEvents
        '
        Me.dgdEvents.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgdEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdEvents.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colObject, Me.colEventTrigger, Me.colEventProcessing})
        Me.dgdEvents.Location = New System.Drawing.Point(0, 68)
        Me.dgdEvents.Name = "dgdEvents"
        Me.dgdEvents.Size = New System.Drawing.Size(497, 382)
        Me.dgdEvents.TabIndex = 4
        '
        'colObject
        '
        Me.colObject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colObject.HeaderText = "Object"
        Me.colObject.Name = "colObject"
        '
        'colEventTrigger
        '
        Me.colEventTrigger.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colEventTrigger.HeaderText = "Event Trigger"
        Me.colEventTrigger.Name = "colEventTrigger"
        '
        'colEventProcessing
        '
        Me.colEventProcessing.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colEventProcessing.DefaultCellStyle = DataGridViewCellStyle3
        Me.colEventProcessing.FillWeight = 200.0!
        Me.colEventProcessing.HeaderText = "Event Processing"
        Me.colEventProcessing.Name = "colEventProcessing"
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.btnImport)
        Me.pnlHeader.Controls.Add(Me.lblObjectName)
        Me.pnlHeader.Controls.Add(Me.txtObject)
        Me.pnlHeader.Controls.Add(Me.lblDeveloper)
        Me.pnlHeader.Controls.Add(Me.txtDeveloper)
        Me.pnlHeader.Controls.Add(Me.lblProgramName)
        Me.pnlHeader.Controls.Add(Me.btnGenerate)
        Me.pnlHeader.Controls.Add(Me.txtProgramName)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(497, 67)
        Me.pnlHeader.TabIndex = 5
        '
        'lblObjectName
        '
        Me.lblObjectName.AutoSize = True
        Me.lblObjectName.Location = New System.Drawing.Point(254, 14)
        Me.lblObjectName.Name = "lblObjectName"
        Me.lblObjectName.Size = New System.Drawing.Size(72, 13)
        Me.lblObjectName.TabIndex = 8
        Me.lblObjectName.Text = "Object Name:"
        Me.lblObjectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtObject
        '
        Me.txtObject.Location = New System.Drawing.Point(332, 11)
        Me.txtObject.Name = "txtObject"
        Me.txtObject.Size = New System.Drawing.Size(150, 20)
        Me.txtObject.TabIndex = 7
        '
        'lblDeveloper
        '
        Me.lblDeveloper.AutoSize = True
        Me.lblDeveloper.Location = New System.Drawing.Point(33, 40)
        Me.lblDeveloper.Name = "lblDeveloper"
        Me.lblDeveloper.Size = New System.Drawing.Size(59, 13)
        Me.lblDeveloper.TabIndex = 6
        Me.lblDeveloper.Text = "Developer:"
        Me.lblDeveloper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDeveloper
        '
        Me.txtDeveloper.Location = New System.Drawing.Point(98, 37)
        Me.txtDeveloper.Name = "txtDeveloper"
        Me.txtDeveloper.Size = New System.Drawing.Size(150, 20)
        Me.txtDeveloper.TabIndex = 5
        '
        'lblProgramName
        '
        Me.lblProgramName.AutoSize = True
        Me.lblProgramName.Location = New System.Drawing.Point(12, 14)
        Me.lblProgramName.Name = "lblProgramName"
        Me.lblProgramName.Size = New System.Drawing.Size(80, 13)
        Me.lblProgramName.TabIndex = 4
        Me.lblProgramName.Text = "Program Name:"
        Me.lblProgramName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(286, 35)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(95, 23)
        Me.btnImport.TabIndex = 9
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'frmEpdGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 450)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.dgdEvents)
        Me.Name = "frmEpdGenerator"
        Me.Text = "Event Planning Document Generator"
        CType(Me.dgdEvents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGenerate As Button
    Friend WithEvents txtProgramName As TextBox
    Friend WithEvents dgdEvents As DataGridView
    Friend WithEvents colObject As DataGridViewTextBoxColumn
    Friend WithEvents colEventTrigger As DataGridViewTextBoxColumn
    Friend WithEvents colEventProcessing As DataGridViewTextBoxColumn
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblObjectName As Label
    Friend WithEvents txtObject As TextBox
    Friend WithEvents lblDeveloper As Label
    Friend WithEvents txtDeveloper As TextBox
    Friend WithEvents lblProgramName As Label
    Friend WithEvents btnImport As Button
End Class
