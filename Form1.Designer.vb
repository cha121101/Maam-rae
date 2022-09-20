<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblempno = New System.Windows.Forms.Label()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.lbllastname = New System.Windows.Forms.Label()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.lblfirstname = New System.Windows.Forms.Label()
        Me.txtmiddle = New System.Windows.Forms.TextBox()
        Me.lblmi = New System.Windows.Forms.Label()
        Me.lbladdress = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.lblgender = New System.Windows.Forms.Label()
        Me.lblcontact = New System.Windows.Forms.Label()
        Me.lblposition = New System.Windows.Forms.Label()
        Me.cmbposition = New System.Windows.Forms.ComboBox()
        Me.cmbgender = New System.Windows.Forms.ComboBox()
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnaddnewemp = New System.Windows.Forms.Button()
        Me.btnupdateemp = New System.Windows.Forms.Button()
        Me.btndeleteemp = New System.Windows.Forms.Button()
        Me.txtempno = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblempno
        '
        Me.lblempno.AutoSize = True
        Me.lblempno.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblempno.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblempno.Location = New System.Drawing.Point(46, 59)
        Me.lblempno.Name = "lblempno"
        Me.lblempno.Size = New System.Drawing.Size(80, 16)
        Me.lblempno.TabIndex = 1
        Me.lblempno.Text = "Employee No:"
        '
        'txtlastname
        '
        Me.txtlastname.Location = New System.Drawing.Point(46, 122)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(107, 20)
        Me.txtlastname.TabIndex = 2
        '
        'lbllastname
        '
        Me.lbllastname.AutoSize = True
        Me.lbllastname.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lbllastname.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllastname.Location = New System.Drawing.Point(46, 106)
        Me.lbllastname.Name = "lbllastname"
        Me.lbllastname.Size = New System.Drawing.Size(62, 16)
        Me.lbllastname.TabIndex = 3
        Me.lbllastname.Text = "Last Name"
        '
        'txtfirstname
        '
        Me.txtfirstname.Location = New System.Drawing.Point(159, 122)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(118, 20)
        Me.txtfirstname.TabIndex = 4
        '
        'lblfirstname
        '
        Me.lblfirstname.AutoSize = True
        Me.lblfirstname.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblfirstname.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfirstname.Location = New System.Drawing.Point(156, 106)
        Me.lblfirstname.Name = "lblfirstname"
        Me.lblfirstname.Size = New System.Drawing.Size(63, 16)
        Me.lblfirstname.TabIndex = 5
        Me.lblfirstname.Text = "First Name"
        '
        'txtmiddle
        '
        Me.txtmiddle.Location = New System.Drawing.Point(286, 122)
        Me.txtmiddle.Name = "txtmiddle"
        Me.txtmiddle.Size = New System.Drawing.Size(112, 20)
        Me.txtmiddle.TabIndex = 6
        '
        'lblmi
        '
        Me.lblmi.AutoSize = True
        Me.lblmi.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblmi.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmi.Location = New System.Drawing.Point(286, 106)
        Me.lblmi.Name = "lblmi"
        Me.lblmi.Size = New System.Drawing.Size(27, 16)
        Me.lblmi.TabIndex = 7
        Me.lblmi.Text = "M.I."
        '
        'lbladdress
        '
        Me.lbladdress.AutoSize = True
        Me.lbladdress.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lbladdress.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladdress.Location = New System.Drawing.Point(46, 163)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(49, 16)
        Me.lbladdress.TabIndex = 8
        Me.lbladdress.Text = "Address"
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(46, 182)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(352, 20)
        Me.txtaddress.TabIndex = 9
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblgender.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgender.Location = New System.Drawing.Point(43, 224)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(45, 16)
        Me.lblgender.TabIndex = 10
        Me.lblgender.Text = "Gender"
        '
        'lblcontact
        '
        Me.lblcontact.AutoSize = True
        Me.lblcontact.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblcontact.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcontact.Location = New System.Drawing.Point(159, 224)
        Me.lblcontact.Name = "lblcontact"
        Me.lblcontact.Size = New System.Drawing.Size(70, 16)
        Me.lblcontact.TabIndex = 11
        Me.lblcontact.Text = "Contact No."
        '
        'lblposition
        '
        Me.lblposition.AutoSize = True
        Me.lblposition.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblposition.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblposition.Location = New System.Drawing.Point(283, 224)
        Me.lblposition.Name = "lblposition"
        Me.lblposition.Size = New System.Drawing.Size(50, 16)
        Me.lblposition.TabIndex = 12
        Me.lblposition.Text = "Position"
        '
        'cmbposition
        '
        Me.cmbposition.FormattingEnabled = True
        Me.cmbposition.Items.AddRange(New Object() {"CEO", "Manager", "Secretary"})
        Me.cmbposition.Location = New System.Drawing.Point(283, 241)
        Me.cmbposition.Name = "cmbposition"
        Me.cmbposition.Size = New System.Drawing.Size(115, 21)
        Me.cmbposition.TabIndex = 13
        '
        'cmbgender
        '
        Me.cmbgender.FormattingEnabled = True
        Me.cmbgender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbgender.Location = New System.Drawing.Point(46, 241)
        Me.cmbgender.Name = "cmbgender"
        Me.cmbgender.Size = New System.Drawing.Size(107, 21)
        Me.cmbgender.TabIndex = 14
        '
        'txtcontact
        '
        Me.txtcontact.Location = New System.Drawing.Point(159, 241)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(118, 20)
        Me.txtcontact.TabIndex = 15
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(46, 285)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(352, 125)
        Me.ListView1.TabIndex = 16
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'btnaddnewemp
        '
        Me.btnaddnewemp.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddnewemp.Location = New System.Drawing.Point(49, 453)
        Me.btnaddnewemp.Name = "btnaddnewemp"
        Me.btnaddnewemp.Size = New System.Drawing.Size(75, 23)
        Me.btnaddnewemp.TabIndex = 17
        Me.btnaddnewemp.Text = "ADD NEW"
        Me.btnaddnewemp.UseVisualStyleBackColor = True
        '
        'btnupdateemp
        '
        Me.btnupdateemp.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdateemp.Location = New System.Drawing.Point(131, 453)
        Me.btnupdateemp.Name = "btnupdateemp"
        Me.btnupdateemp.Size = New System.Drawing.Size(75, 23)
        Me.btnupdateemp.TabIndex = 18
        Me.btnupdateemp.Text = "UPDATE"
        Me.btnupdateemp.UseVisualStyleBackColor = True
        '
        'btndeleteemp
        '
        Me.btndeleteemp.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeleteemp.Location = New System.Drawing.Point(212, 453)
        Me.btndeleteemp.Name = "btndeleteemp"
        Me.btndeleteemp.Size = New System.Drawing.Size(75, 23)
        Me.btndeleteemp.TabIndex = 19
        Me.btndeleteemp.Text = "DELETE"
        Me.btndeleteemp.UseVisualStyleBackColor = True
        '
        'txtempno
        '
        Me.txtempno.Location = New System.Drawing.Point(131, 55)
        Me.txtempno.Name = "txtempno"
        Me.txtempno.Size = New System.Drawing.Size(32, 20)
        Me.txtempno.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ClientSize = New System.Drawing.Size(439, 533)
        Me.Controls.Add(Me.btndeleteemp)
        Me.Controls.Add(Me.btnupdateemp)
        Me.Controls.Add(Me.btnaddnewemp)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.txtcontact)
        Me.Controls.Add(Me.cmbgender)
        Me.Controls.Add(Me.cmbposition)
        Me.Controls.Add(Me.lblposition)
        Me.Controls.Add(Me.lblcontact)
        Me.Controls.Add(Me.lblgender)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.lbladdress)
        Me.Controls.Add(Me.lblmi)
        Me.Controls.Add(Me.txtmiddle)
        Me.Controls.Add(Me.lblfirstname)
        Me.Controls.Add(Me.txtfirstname)
        Me.Controls.Add(Me.lbllastname)
        Me.Controls.Add(Me.txtlastname)
        Me.Controls.Add(Me.lblempno)
        Me.Controls.Add(Me.txtempno)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblempno As Label
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents lbllastname As Label
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents lblfirstname As Label
    Friend WithEvents txtmiddle As TextBox
    Friend WithEvents lblmi As Label
    Friend WithEvents lbladdress As Label
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents lblgender As Label
    Friend WithEvents lblcontact As Label
    Friend WithEvents lblposition As Label
    Friend WithEvents cmbposition As ComboBox
    Friend WithEvents cmbgender As ComboBox
    Friend WithEvents txtcontact As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents btnaddnewemp As Button
    Friend WithEvents btnupdateemp As Button
    Friend WithEvents btndeleteemp As Button
    Friend WithEvents txtempno As TextBox
End Class
