<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits MetroFramework.Forms.MetroForm

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.Text_Ram = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.Tile_Calc = New MetroFramework.Controls.MetroTile()
        Me.Text_Slots = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.Text_Upload = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.Text_Cores = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.Text_CPU = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.Radio_Source = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Radio_HLDS = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.Text_RecCPU = New MetroFramework.Controls.MetroLabel()
        Me.Text_RecRam = New MetroFramework.Controls.MetroLabel()
        Me.Text_RecCon = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.Text_Output = New MetroFramework.Controls.MetroTextBox()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Location = New System.Drawing.Point(16, 52)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 1
        Me.MetroTabControl1.Size = New System.Drawing.Size(469, 236)
        Me.MetroTabControl1.TabIndex = 1
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel14)
        Me.MetroTabPage1.Controls.Add(Me.Text_Ram)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel9)
        Me.MetroTabPage1.Controls.Add(Me.Tile_Calc)
        Me.MetroTabPage1.Controls.Add(Me.Text_Slots)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel7)
        Me.MetroTabPage1.Controls.Add(Me.Text_Upload)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel6)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel5)
        Me.MetroTabPage1.Controls.Add(Me.Text_Cores)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel4)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel3)
        Me.MetroTabPage1.Controls.Add(Me.Text_CPU)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel2)
        Me.MetroTabPage1.Controls.Add(Me.Radio_Source)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel1)
        Me.MetroTabPage1.Controls.Add(Me.Radio_HLDS)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 35)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(461, 197)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Input"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        '
        'Text_Ram
        '
        Me.Text_Ram.Location = New System.Drawing.Point(121, 156)
        Me.Text_Ram.Name = "Text_Ram"
        Me.Text_Ram.Size = New System.Drawing.Size(153, 23)
        Me.Text_Ram.TabIndex = 25
        Me.Text_Ram.Text = "1500"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(120, 134)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(76, 19)
        Me.MetroLabel9.TabIndex = 24
        Me.MetroLabel9.Text = "RAM in MB"
        '
        'Tile_Calc
        '
        Me.Tile_Calc.Location = New System.Drawing.Point(1, 88)
        Me.Tile_Calc.Name = "Tile_Calc"
        Me.Tile_Calc.Size = New System.Drawing.Size(102, 42)
        Me.Tile_Calc.TabIndex = 23
        Me.Tile_Calc.Text = "Calculate"
        '
        'Text_Slots
        '
        Me.Text_Slots.Location = New System.Drawing.Point(294, 108)
        Me.Text_Slots.Name = "Text_Slots"
        Me.Text_Slots.Size = New System.Drawing.Size(151, 23)
        Me.Text_Slots.TabIndex = 22
        Me.Text_Slots.Text = "24"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(294, 86)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(131, 19)
        Me.MetroLabel7.TabIndex = 21
        Me.MetroLabel7.Text = "Slots you want to run"
        '
        'Text_Upload
        '
        Me.Text_Upload.Location = New System.Drawing.Point(294, 60)
        Me.Text_Upload.Name = "Text_Upload"
        Me.Text_Upload.Size = New System.Drawing.Size(151, 23)
        Me.Text_Upload.TabIndex = 20
        Me.Text_Upload.Text = "10"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(294, 38)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(145, 19)
        Me.MetroLabel6.TabIndex = 19
        Me.MetroLabel6.Text = "Upload Rate (in MBit/s)"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(294, 9)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(123, 19)
        Me.MetroLabel5.TabIndex = 18
        Me.MetroLabel5.Text = "Internet Connection"
        '
        'Text_Cores
        '
        Me.Text_Cores.Location = New System.Drawing.Point(121, 108)
        Me.Text_Cores.Name = "Text_Cores"
        Me.Text_Cores.Size = New System.Drawing.Size(153, 23)
        Me.Text_Cores.TabIndex = 17
        Me.Text_Cores.Text = "3"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(120, 86)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel4.TabIndex = 16
        Me.MetroLabel4.Text = "Core(s)"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(120, 38)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel3.TabIndex = 15
        Me.MetroLabel3.Text = "MHz CPU"
        '
        'Text_CPU
        '
        Me.Text_CPU.Location = New System.Drawing.Point(121, 60)
        Me.Text_CPU.Name = "Text_CPU"
        Me.Text_CPU.Size = New System.Drawing.Size(153, 23)
        Me.Text_CPU.TabIndex = 14
        Me.Text_CPU.Text = "3400"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(120, 9)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel2.TabIndex = 13
        Me.MetroLabel2.Text = "Hardware"
        '
        'Radio_Source
        '
        Me.Radio_Source.AutoSize = True
        Me.Radio_Source.Enabled = False
        Me.Radio_Source.Location = New System.Drawing.Point(0, 61)
        Me.Radio_Source.Name = "Radio_Source"
        Me.Radio_Source.Size = New System.Drawing.Size(105, 15)
        Me.Radio_Source.TabIndex = 12
        Me.Radio_Source.TabStop = True
        Me.Radio_Source.Text = "Source (SRCDS)"
        Me.Radio_Source.UseVisualStyleBackColor = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(0, 9)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(48, 19)
        Me.MetroLabel1.TabIndex = 11
        Me.MetroLabel1.Text = "Engine"
        '
        'Radio_HLDS
        '
        Me.Radio_HLDS.AutoSize = True
        Me.Radio_HLDS.Location = New System.Drawing.Point(0, 40)
        Me.Radio_HLDS.Name = "Radio_HLDS"
        Me.Radio_HLDS.Size = New System.Drawing.Size(104, 15)
        Me.Radio_HLDS.TabIndex = 10
        Me.Radio_HLDS.Text = "GoldSrc (HLDS)"
        Me.Radio_HLDS.UseVisualStyleBackColor = True
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.MetroLink1)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel13)
        Me.MetroTabPage2.Controls.Add(Me.Text_RecCPU)
        Me.MetroTabPage2.Controls.Add(Me.Text_RecRam)
        Me.MetroTabPage2.Controls.Add(Me.Text_RecCon)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel12)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel11)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel10)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel8)
        Me.MetroTabPage2.Controls.Add(Me.Text_Output)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 35)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(461, 197)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Output"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        '
        'Text_RecCPU
        '
        Me.Text_RecCPU.AutoSize = True
        Me.Text_RecCPU.Location = New System.Drawing.Point(298, 175)
        Me.Text_RecCPU.Name = "Text_RecCPU"
        Me.Text_RecCPU.Size = New System.Drawing.Size(15, 19)
        Me.Text_RecCPU.TabIndex = 10
        Me.Text_RecCPU.Text = "-"
        '
        'Text_RecRam
        '
        Me.Text_RecRam.AutoSize = True
        Me.Text_RecRam.Location = New System.Drawing.Point(298, 156)
        Me.Text_RecRam.Name = "Text_RecRam"
        Me.Text_RecRam.Size = New System.Drawing.Size(15, 19)
        Me.Text_RecRam.TabIndex = 9
        Me.Text_RecRam.Text = "-"
        '
        'Text_RecCon
        '
        Me.Text_RecCon.AutoSize = True
        Me.Text_RecCon.Location = New System.Drawing.Point(298, 137)
        Me.Text_RecCon.Name = "Text_RecCon"
        Me.Text_RecCon.Size = New System.Drawing.Size(15, 19)
        Me.Text_RecCon.TabIndex = 8
        Me.Text_RecCon.Text = "-"
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(0, 175)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(221, 19)
        Me.MetroLabel12.TabIndex = 7
        Me.MetroLabel12.Text = "Recommended Slots based on CPU:"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(0, 156)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(224, 19)
        Me.MetroLabel11.TabIndex = 6
        Me.MetroLabel11.Text = "Recommended Slots based on RAM:"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(0, 137)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(261, 19)
        Me.MetroLabel10.TabIndex = 5
        Me.MetroLabel10.Text = "Recommended Slots based on Connection:"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(245, 3)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(204, 76)
        Me.MetroLabel8.TabIndex = 3
        Me.MetroLabel8.Text = "Paste this into your server.cfg." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For further questions contact me " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "via mail: co" & _
    "ntact@xi4.me" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Text_Output
        '
        Me.Text_Output.Location = New System.Drawing.Point(0, 3)
        Me.Text_Output.Multiline = True
        Me.Text_Output.Name = "Text_Output"
        Me.Text_Output.Size = New System.Drawing.Size(239, 131)
        Me.Text_Output.TabIndex = 2
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(245, 71)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(186, 38)
        Me.MetroLabel13.TabIndex = 11
        Me.MetroLabel13.Text = "For recommended Slots, take " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "always the lowest."
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.Location = New System.Drawing.Point(293, 149)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(165, 38)
        Me.MetroLabel14.TabIndex = 26
        Me.MetroLabel14.Text = "The Tool uses 95% of your " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Input to calculate."
        '
        'MetroLink1
        '
        Me.MetroLink1.Location = New System.Drawing.Point(245, 112)
        Me.MetroLink1.Name = "MetroLink1"
        Me.MetroLink1.Size = New System.Drawing.Size(216, 23)
        Me.MetroLink1.TabIndex = 12
        Me.MetroLink1.Text = "Visit my homepage! :)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 294)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Resizable = False
        Me.Text = "Form1"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Text_Upload As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Text_Cores As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Text_CPU As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Radio_Source As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Radio_HLDS As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
    Friend WithEvents Text_Slots As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Tile_Calc As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Text_Output As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Text_Ram As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Text_RecCPU As MetroFramework.Controls.MetroLabel
    Friend WithEvents Text_RecRam As MetroFramework.Controls.MetroLabel
    Friend WithEvents Text_RecCon As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink

End Class
