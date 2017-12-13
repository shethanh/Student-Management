<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.txtcurrentuser = New System.Windows.Forms.ToolStripTextBox()
        Me.btnstudentlist = New System.Windows.Forms.Button()
        Me.btnrigister = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncourse = New System.Windows.Forms.Button()
        Me.btnsubject = New System.Windows.Forms.Button()
        Me.btnclassmanagement = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripTextBox1, Me.txtcurrentuser})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 548)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1123, 32)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 29)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 32)
        Me.ToolStripTextBox1.Text = "User:"
        '
        'txtcurrentuser
        '
        Me.txtcurrentuser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtcurrentuser.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcurrentuser.Name = "txtcurrentuser"
        Me.txtcurrentuser.Size = New System.Drawing.Size(100, 32)
        '
        'btnstudentlist
        '
        Me.btnstudentlist.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnstudentlist.Font = New System.Drawing.Font("Khmer OS Fasthand", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstudentlist.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnstudentlist.Location = New System.Drawing.Point(587, 122)
        Me.btnstudentlist.Name = "btnstudentlist"
        Me.btnstudentlist.Size = New System.Drawing.Size(322, 98)
        Me.btnstudentlist.TabIndex = 6
        Me.btnstudentlist.Text = "បញ្ជីឈ្មោះសិស្ស"
        Me.btnstudentlist.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnstudentlist.UseVisualStyleBackColor = False
        '
        'btnrigister
        '
        Me.btnrigister.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnrigister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnrigister.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btnrigister.Font = New System.Drawing.Font("Khmer OS Fasthand", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrigister.ForeColor = System.Drawing.Color.Black
        Me.btnrigister.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnrigister.Location = New System.Drawing.Point(50, 122)
        Me.btnrigister.Name = "btnrigister"
        Me.btnrigister.Size = New System.Drawing.Size(298, 108)
        Me.btnrigister.TabIndex = 5
        Me.btnrigister.Text = "ចុះឈ្មោះសិស្សថ្មី"
        Me.btnrigister.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnrigister.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-15, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1138, 81)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Welcome"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btncourse
        '
        Me.btncourse.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btncourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btncourse.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btncourse.Font = New System.Drawing.Font("Khmer OS Fasthand", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncourse.ForeColor = System.Drawing.Color.Black
        Me.btncourse.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncourse.Location = New System.Drawing.Point(50, 268)
        Me.btncourse.Name = "btncourse"
        Me.btncourse.Size = New System.Drawing.Size(298, 108)
        Me.btncourse.TabIndex = 8
        Me.btncourse.Text = "ជំនាញ"
        Me.btncourse.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btncourse.UseVisualStyleBackColor = False
        '
        'btnsubject
        '
        Me.btnsubject.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnsubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnsubject.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btnsubject.Font = New System.Drawing.Font("Khmer OS Fasthand", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsubject.ForeColor = System.Drawing.Color.Black
        Me.btnsubject.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnsubject.Location = New System.Drawing.Point(587, 268)
        Me.btnsubject.Name = "btnsubject"
        Me.btnsubject.Size = New System.Drawing.Size(322, 108)
        Me.btnsubject.TabIndex = 9
        Me.btnsubject.Text = "មុខវិជ្ជា"
        Me.btnsubject.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnsubject.UseVisualStyleBackColor = False
        '
        'btnclassmanagement
        '
        Me.btnclassmanagement.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnclassmanagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnclassmanagement.Cursor = System.Windows.Forms.Cursors.Cross
        Me.btnclassmanagement.Font = New System.Drawing.Font("Khmer OS Fasthand", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclassmanagement.ForeColor = System.Drawing.Color.Black
        Me.btnclassmanagement.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnclassmanagement.Location = New System.Drawing.Point(329, 411)
        Me.btnclassmanagement.Name = "btnclassmanagement"
        Me.btnclassmanagement.Size = New System.Drawing.Size(298, 108)
        Me.btnclassmanagement.TabIndex = 10
        Me.btnclassmanagement.Text = "គ្រប់គ្រងថ្នាក់"
        Me.btnclassmanagement.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnclassmanagement.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1123, 580)
        Me.Controls.Add(Me.btnclassmanagement)
        Me.Controls.Add(Me.btnsubject)
        Me.Controls.Add(Me.btncourse)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnstudentlist)
        Me.Controls.Add(Me.btnrigister)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMain"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents txtcurrentuser As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnstudentlist As System.Windows.Forms.Button
    Friend WithEvents btnrigister As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btncourse As System.Windows.Forms.Button
    Friend WithEvents btnsubject As System.Windows.Forms.Button
    Friend WithEvents btnclassmanagement As System.Windows.Forms.Button
End Class
