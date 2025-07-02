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
        Me.txtInput = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtInputBox = New System.Windows.Forms.TextBox()
        Me.txtList = New System.Windows.Forms.TextBox()
        Me.btnPrintShopList = New System.Windows.Forms.Button()
        Me.btnAddShopList = New System.Windows.Forms.Button()
        Me.btnClearShopList = New System.Windows.Forms.Button()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.AutoSize = True
        Me.txtInput.Location = New System.Drawing.Point(48, 51)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(211, 20)
        Me.txtInput.TabIndex = 0
        Me.txtInput.Text = "Type item to be added to list:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Shopping list:"
        '
        'txtInputBox
        '
        Me.txtInputBox.Location = New System.Drawing.Point(286, 45)
        Me.txtInputBox.Name = "txtInputBox"
        Me.txtInputBox.Size = New System.Drawing.Size(195, 26)
        Me.txtInputBox.TabIndex = 2
        '
        'txtList
        '
        Me.txtList.Location = New System.Drawing.Point(286, 115)
        Me.txtList.Multiline = True
        Me.txtList.Name = "txtList"
        Me.txtList.ReadOnly = True
        Me.txtList.Size = New System.Drawing.Size(188, 191)
        Me.txtList.TabIndex = 3
        '
        'btnPrintShopList
        '
        Me.btnPrintShopList.Location = New System.Drawing.Point(74, 332)
        Me.btnPrintShopList.Name = "btnPrintShopList"
        Me.btnPrintShopList.Size = New System.Drawing.Size(119, 78)
        Me.btnPrintShopList.TabIndex = 4
        Me.btnPrintShopList.Text = "Print Shopping List"
        Me.btnPrintShopList.UseVisualStyleBackColor = True
        '
        'btnAddShopList
        '
        Me.btnAddShopList.Location = New System.Drawing.Point(244, 332)
        Me.btnAddShopList.Name = "btnAddShopList"
        Me.btnAddShopList.Size = New System.Drawing.Size(115, 78)
        Me.btnAddShopList.TabIndex = 5
        Me.btnAddShopList.Text = "Add to Shopping List"
        Me.btnAddShopList.UseVisualStyleBackColor = True
        '
        'btnClearShopList
        '
        Me.btnClearShopList.Location = New System.Drawing.Point(403, 330)
        Me.btnClearShopList.Name = "btnClearShopList"
        Me.btnClearShopList.Size = New System.Drawing.Size(107, 77)
        Me.btnClearShopList.TabIndex = 6
        Me.btnClearShopList.Text = "Clear Shopping List"
        Me.btnClearShopList.UseVisualStyleBackColor = True
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(567, 326)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(105, 90)
        Me.btnDone.TabIndex = 7
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(699, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "---------------------------------------------------------------------------------" &
    "---------------------------------------------------------"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnClearShopList)
        Me.Controls.Add(Me.btnAddShopList)
        Me.Controls.Add(Me.btnPrintShopList)
        Me.Controls.Add(Me.txtList)
        Me.Controls.Add(Me.txtInputBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtInput)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInput As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtInputBox As TextBox
    Friend WithEvents txtList As TextBox
    Friend WithEvents btnPrintShopList As Button
    Friend WithEvents btnAddShopList As Button
    Friend WithEvents btnClearShopList As Button
    Friend WithEvents btnDone As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Label1 As Label
End Class
