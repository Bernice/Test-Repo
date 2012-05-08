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
        Me.RadDropDownList1 = New Telerik.WinControls.UI.RadDropDownList()
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadDropDownList1
        '
        Me.RadDropDownList1.DropDownAnimationEnabled = True
        Me.RadDropDownList1.Location = New System.Drawing.Point(54, 31)
        Me.RadDropDownList1.Name = "RadDropDownList1"
        Me.RadDropDownList1.ShowImageInEditorArea = True
        Me.RadDropDownList1.Size = New System.Drawing.Size(152, 20)
        Me.RadDropDownList1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(322, 206)
        Me.Controls.Add(Me.RadDropDownList1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.RadDropDownList1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadDropDownList1 As Telerik.WinControls.UI.RadDropDownList

End Class
