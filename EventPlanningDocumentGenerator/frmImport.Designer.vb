<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImport
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
        Me.txtSolutionPath = New System.Windows.Forms.TextBox()
        Me.grpSolution = New System.Windows.Forms.GroupBox()
        Me.btnLoadSolution = New System.Windows.Forms.Button()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboClass = New System.Windows.Forms.ComboBox()
        Me.cboProject = New System.Windows.Forms.ComboBox()
        Me.dlgOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.grpSolution.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSolutionPath
        '
        Me.txtSolutionPath.Location = New System.Drawing.Point(6, 19)
        Me.txtSolutionPath.Name = "txtSolutionPath"
        Me.txtSolutionPath.ReadOnly = True
        Me.txtSolutionPath.Size = New System.Drawing.Size(247, 20)
        Me.txtSolutionPath.TabIndex = 0
        '
        'grpSolution
        '
        Me.grpSolution.Controls.Add(Me.btnLoadSolution)
        Me.grpSolution.Controls.Add(Me.txtSolutionPath)
        Me.grpSolution.Location = New System.Drawing.Point(12, 12)
        Me.grpSolution.Name = "grpSolution"
        Me.grpSolution.Size = New System.Drawing.Size(340, 51)
        Me.grpSolution.TabIndex = 1
        Me.grpSolution.TabStop = False
        Me.grpSolution.Text = "Solution"
        '
        'btnLoadSolution
        '
        Me.btnLoadSolution.Location = New System.Drawing.Point(259, 17)
        Me.btnLoadSolution.Name = "btnLoadSolution"
        Me.btnLoadSolution.Size = New System.Drawing.Size(75, 23)
        Me.btnLoadSolution.TabIndex = 1
        Me.btnLoadSolution.Text = "Load"
        Me.btnLoadSolution.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Enabled = False
        Me.btnImport.Location = New System.Drawing.Point(277, 186)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(75, 23)
        Me.btnImport.TabIndex = 3
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboProject)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(340, 51)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Project"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboClass)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(340, 51)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Class"
        '
        'cboClass
        '
        Me.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClass.Enabled = False
        Me.cboClass.FormattingEnabled = True
        Me.cboClass.Location = New System.Drawing.Point(6, 19)
        Me.cboClass.Name = "cboClass"
        Me.cboClass.Size = New System.Drawing.Size(328, 21)
        Me.cboClass.TabIndex = 6
        '
        'cboProject
        '
        Me.cboProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProject.Enabled = False
        Me.cboProject.FormattingEnabled = True
        Me.cboProject.Location = New System.Drawing.Point(6, 19)
        Me.cboProject.Name = "cboProject"
        Me.cboProject.Size = New System.Drawing.Size(328, 21)
        Me.cboProject.TabIndex = 7
        '
        'dlgOpenFile
        '
        Me.dlgOpenFile.Filter = "Visual Studio files|*.sln"
        '
        'frmImport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 221)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.grpSolution)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmImport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Import from Solution"
        Me.grpSolution.ResumeLayout(False)
        Me.grpSolution.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtSolutionPath As TextBox
    Friend WithEvents grpSolution As GroupBox
    Friend WithEvents btnLoadSolution As Button
    Friend WithEvents btnImport As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboProject As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cboClass As ComboBox
    Friend WithEvents dlgOpenFile As OpenFileDialog
End Class
