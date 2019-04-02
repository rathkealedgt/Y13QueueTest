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
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSecond = New System.Windows.Forms.TextBox()
        Me.btnOffer = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnPoll = New System.Windows.Forms.Button()
        Me.btnElement = New System.Windows.Forms.Button()
        Me.btnPeek = New System.Windows.Forms.Button()
        Me.btnEmpty = New System.Windows.Forms.Button()
        Me.btnCount = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblQueue1Out = New System.Windows.Forms.Label()
        Me.lblQueue2Out = New System.Windows.Forms.Label()
        Me.lblCountFirst = New System.Windows.Forms.Label()
        Me.lblCountSecond = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(12, 35)
        Me.txtFirst.MaxLength = 1
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(49, 20)
        Me.txtFirst.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Queue 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(305, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Queue 2"
        '
        'txtSecond
        '
        Me.txtSecond.Location = New System.Drawing.Point(304, 35)
        Me.txtSecond.MaxLength = 1
        Me.txtSecond.Name = "txtSecond"
        Me.txtSecond.Size = New System.Drawing.Size(49, 20)
        Me.txtSecond.TabIndex = 2
        '
        'btnOffer
        '
        Me.btnOffer.Location = New System.Drawing.Point(12, 61)
        Me.btnOffer.Name = "btnOffer"
        Me.btnOffer.Size = New System.Drawing.Size(49, 39)
        Me.btnOffer.TabIndex = 4
        Me.btnOffer.Text = "Offer"
        Me.btnOffer.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(304, 61)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(49, 39)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(304, 106)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(49, 39)
        Me.btnRemove.TabIndex = 7
        Me.btnRemove.Text = "Rem"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnPoll
        '
        Me.btnPoll.Location = New System.Drawing.Point(12, 106)
        Me.btnPoll.Name = "btnPoll"
        Me.btnPoll.Size = New System.Drawing.Size(49, 39)
        Me.btnPoll.TabIndex = 6
        Me.btnPoll.Text = "Poll"
        Me.btnPoll.UseVisualStyleBackColor = True
        '
        'btnElement
        '
        Me.btnElement.Location = New System.Drawing.Point(304, 151)
        Me.btnElement.Name = "btnElement"
        Me.btnElement.Size = New System.Drawing.Size(49, 39)
        Me.btnElement.TabIndex = 9
        Me.btnElement.Text = "Elem"
        Me.btnElement.UseVisualStyleBackColor = True
        '
        'btnPeek
        '
        Me.btnPeek.Location = New System.Drawing.Point(12, 151)
        Me.btnPeek.Name = "btnPeek"
        Me.btnPeek.Size = New System.Drawing.Size(49, 39)
        Me.btnPeek.TabIndex = 8
        Me.btnPeek.Text = "Peek"
        Me.btnPeek.UseVisualStyleBackColor = True
        '
        'btnEmpty
        '
        Me.btnEmpty.Location = New System.Drawing.Point(304, 196)
        Me.btnEmpty.Name = "btnEmpty"
        Me.btnEmpty.Size = New System.Drawing.Size(49, 39)
        Me.btnEmpty.TabIndex = 11
        Me.btnEmpty.Text = "Empty"
        Me.btnEmpty.UseVisualStyleBackColor = True
        '
        'btnCount
        '
        Me.btnCount.Location = New System.Drawing.Point(12, 196)
        Me.btnCount.Name = "btnCount"
        Me.btnCount.Size = New System.Drawing.Size(49, 39)
        Me.btnCount.TabIndex = 10
        Me.btnCount.Text = "Count"
        Me.btnCount.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 268)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Queue 1:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 353)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Queue 2:"
        '
        'lblQueue1Out
        '
        Me.lblQueue1Out.AutoSize = True
        Me.lblQueue1Out.Location = New System.Drawing.Point(13, 290)
        Me.lblQueue1Out.Name = "lblQueue1Out"
        Me.lblQueue1Out.Size = New System.Drawing.Size(0, 13)
        Me.lblQueue1Out.TabIndex = 14
        '
        'lblQueue2Out
        '
        Me.lblQueue2Out.AutoSize = True
        Me.lblQueue2Out.Location = New System.Drawing.Point(13, 375)
        Me.lblQueue2Out.Name = "lblQueue2Out"
        Me.lblQueue2Out.Size = New System.Drawing.Size(0, 13)
        Me.lblQueue2Out.TabIndex = 15
        '
        'lblCountFirst
        '
        Me.lblCountFirst.AutoSize = True
        Me.lblCountFirst.Location = New System.Drawing.Point(12, 419)
        Me.lblCountFirst.Name = "lblCountFirst"
        Me.lblCountFirst.Size = New System.Drawing.Size(47, 13)
        Me.lblCountFirst.TabIndex = 16
        Me.lblCountFirst.Text = "Count: 0"
        '
        'lblCountSecond
        '
        Me.lblCountSecond.AutoSize = True
        Me.lblCountSecond.Location = New System.Drawing.Point(301, 419)
        Me.lblCountSecond.Name = "lblCountSecond"
        Me.lblCountSecond.Size = New System.Drawing.Size(47, 13)
        Me.lblCountSecond.TabIndex = 17
        Me.lblCountSecond.Text = "Count: 0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 463)
        Me.Controls.Add(Me.lblCountSecond)
        Me.Controls.Add(Me.lblCountFirst)
        Me.Controls.Add(Me.lblQueue2Out)
        Me.Controls.Add(Me.lblQueue1Out)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnEmpty)
        Me.Controls.Add(Me.btnCount)
        Me.Controls.Add(Me.btnElement)
        Me.Controls.Add(Me.btnPeek)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnPoll)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnOffer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSecond)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFirst)
        Me.Name = "Form1"
        Me.Text = "Queue Tester"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirst As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSecond As TextBox
    Friend WithEvents btnOffer As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnPoll As Button
    Friend WithEvents btnElement As Button
    Friend WithEvents btnPeek As Button
    Friend WithEvents btnEmpty As Button
    Friend WithEvents btnCount As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblQueue1Out As Label
    Friend WithEvents lblQueue2Out As Label
    Friend WithEvents lblCountFirst As Label
    Friend WithEvents lblCountSecond As Label
End Class
