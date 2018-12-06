<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtsalary = New System.Windows.Forms.TextBox()
        Me.btncalculate = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.lbltotaltax = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lblsalary = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(147, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรเเกรมคำนวนค่าภาษี"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 40)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "เงินเดือนพนักงาน"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 40)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "เงินเดือนพนักงานต่อ/ปี"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(187, 40)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "ภาษีที่ต้องชำระ"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 298)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(187, 40)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "ขายได้สุทธิ"
        '
        'txtsalary
        '
        Me.txtsalary.Location = New System.Drawing.Point(254, 114)
        Me.txtsalary.Name = "txtsalary"
        Me.txtsalary.Size = New System.Drawing.Size(148, 20)
        Me.txtsalary.TabIndex = 2
        '
        'btncalculate
        '
        Me.btncalculate.BackColor = System.Drawing.Color.LightGreen
        Me.btncalculate.Location = New System.Drawing.Point(114, 373)
        Me.btncalculate.Name = "btncalculate"
        Me.btncalculate.Size = New System.Drawing.Size(87, 37)
        Me.btncalculate.TabIndex = 3
        Me.btncalculate.Text = "คำนวน"
        Me.btncalculate.UseVisualStyleBackColor = False
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Salmon
        Me.btnclose.Location = New System.Drawing.Point(254, 373)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(88, 37)
        Me.btnclose.TabIndex = 3
        Me.btnclose.Text = "ปิด"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'lbltotaltax
        '
        Me.lbltotaltax.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lbltotaltax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltotaltax.Location = New System.Drawing.Point(251, 246)
        Me.lbltotaltax.Name = "lbltotaltax"
        Me.lbltotaltax.Size = New System.Drawing.Size(151, 23)
        Me.lbltotaltax.TabIndex = 4
        '
        'lbltotal
        '
        Me.lbltotal.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lbltotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltotal.Location = New System.Drawing.Point(251, 303)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(151, 23)
        Me.lbltotal.TabIndex = 4
        '
        'lblsalary
        '
        Me.lblsalary.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblsalary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblsalary.Location = New System.Drawing.Point(251, 178)
        Me.lblsalary.Name = "lblsalary"
        Me.lblsalary.Size = New System.Drawing.Size(151, 23)
        Me.lblsalary.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(535, 448)
        Me.Controls.Add(Me.lblsalary)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.lbltotaltax)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btncalculate)
        Me.Controls.Add(Me.txtsalary)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtsalary As TextBox
    Friend WithEvents btncalculate As Button
    Friend WithEvents btnclose As Button
    Friend WithEvents lbltotaltax As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents lblsalary As Label
End Class
