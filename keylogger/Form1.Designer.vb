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
        Me.components = New System.ComponentModel.Container()
        Me.TmrEmail = New System.Windows.Forms.Timer(Me.components)
        Me.textlogs = New System.Windows.Forms.TextBox()
        Me.TmrKeys = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'TmrEmail
        '
        Me.TmrEmail.Enabled = True
        Me.TmrEmail.Interval = 60000
        '
        'textlogs
        '
        Me.textlogs.Location = New System.Drawing.Point(401, 95)
        Me.textlogs.Name = "textlogs"
        Me.textlogs.Size = New System.Drawing.Size(100, 31)
        Me.textlogs.TabIndex = 0
        '
        'TmrKeys
        '
        Me.TmrKeys.Enabled = True
        Me.TmrKeys.Interval = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 0)
        Me.Controls.Add(Me.textlogs)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TmrEmail As Timer
    Friend WithEvents textlogs As TextBox
    Friend WithEvents TmrKeys As Timer
End Class
