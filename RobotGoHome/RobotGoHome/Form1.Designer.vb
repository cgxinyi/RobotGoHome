<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_robot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_robot))
        Me.pic_robot = New System.Windows.Forms.PictureBox()
        Me.txt_userInput = New System.Windows.Forms.TextBox()
        Me.btn_userInput = New System.Windows.Forms.Button()
        Me.panel_robo = New System.Windows.Forms.Panel()
        Me.label_info = New System.Windows.Forms.Label()
        Me.pic_home = New System.Windows.Forms.PictureBox()
        CType(Me.pic_robot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_robo.SuspendLayout()
        CType(Me.pic_home, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pic_robot
        '
        Me.pic_robot.Image = CType(resources.GetObject("pic_robot.Image"), System.Drawing.Image)
        Me.pic_robot.Location = New System.Drawing.Point(3, 109)
        Me.pic_robot.Name = "pic_robot"
        Me.pic_robot.Size = New System.Drawing.Size(100, 100)
        Me.pic_robot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_robot.TabIndex = 0
        Me.pic_robot.TabStop = False
        '
        'txt_userInput
        '
        Me.txt_userInput.Location = New System.Drawing.Point(20, 930)
        Me.txt_userInput.Multiline = True
        Me.txt_userInput.Name = "txt_userInput"
        Me.txt_userInput.Size = New System.Drawing.Size(1010, 60)
        Me.txt_userInput.TabIndex = 1
        '
        'btn_userInput
        '
        Me.btn_userInput.Location = New System.Drawing.Point(1050, 930)
        Me.btn_userInput.Name = "btn_userInput"
        Me.btn_userInput.Size = New System.Drawing.Size(200, 60)
        Me.btn_userInput.TabIndex = 2
        Me.btn_userInput.Text = "Enter"
        Me.btn_userInput.UseVisualStyleBackColor = True
        '
        'panel_robo
        '
        Me.panel_robo.BackColor = System.Drawing.SystemColors.MenuBar
        Me.panel_robo.Controls.Add(Me.label_info)
        Me.panel_robo.Controls.Add(Me.pic_home)
        Me.panel_robo.Controls.Add(Me.pic_robot)
        Me.panel_robo.Controls.Add(Me.btn_userInput)
        Me.panel_robo.Controls.Add(Me.txt_userInput)
        Me.panel_robo.Location = New System.Drawing.Point(12, 12)
        Me.panel_robo.Name = "panel_robo"
        Me.panel_robo.Size = New System.Drawing.Size(1500, 1000)
        Me.panel_robo.TabIndex = 3
        '
        'label_info
        '
        Me.label_info.AutoSize = True
        Me.label_info.Location = New System.Drawing.Point(1050, 50)
        Me.label_info.Name = "label_info"
        Me.label_info.Size = New System.Drawing.Size(102, 32)
        Me.label_info.TabIndex = 5
        Me.label_info.Text = "Label1"
        '
        'pic_home
        '
        Me.pic_home.Image = CType(resources.GetObject("pic_home.Image"), System.Drawing.Image)
        Me.pic_home.Location = New System.Drawing.Point(3, 3)
        Me.pic_home.Name = "pic_home"
        Me.pic_home.Size = New System.Drawing.Size(100, 100)
        Me.pic_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_home.TabIndex = 3
        Me.pic_home.TabStop = False
        '
        'form_robot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1530, 1058)
        Me.Controls.Add(Me.panel_robo)
        Me.Name = "form_robot"
        Me.Text = "RobotGOHome"
        CType(Me.pic_robot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_robo.ResumeLayout(False)
        Me.panel_robo.PerformLayout()
        CType(Me.pic_home, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pic_robot As PictureBox
    Friend WithEvents txt_userInput As TextBox
    Friend WithEvents btn_userInput As Button
    Friend WithEvents panel_robo As Panel
    Friend WithEvents pic_home As PictureBox
    Friend WithEvents label_info As Label
End Class
