Imports System.Reflection

Public Class Form1
    Inherits MetroFramework.Forms.MetroForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim versionNumber As Version
        versionNumber = Assembly.GetExecutingAssembly().GetName().Version
        Me.Text = "XiRates " + versionNumber.ToString()

        MetroToolTip1.SetToolTip(MetroLabel3, "Amount of MHz of your CPU. 3,4 GHz = 3400 MHz")
        MetroToolTip1.SetToolTip(MetroLabel4, "The amount of Cores in your CPU.")
        MetroToolTip1.SetToolTip(MetroLabel6, "Your Upload Speed in MBit/s. 10 MBit/s = 1 MB / s")
        MetroToolTip1.SetToolTip(MetroLabel14, "Example: You type 1000 MHz => Tool calculates with 950 MHz")

        Radio_HLDS.Select()
        MetroTabControl1.SelectedTab = MetroTabPage1

    End Sub

    Private Sub Tile_Calc_Click(sender As Object, e As EventArgs) Handles Tile_Calc.Click
        MetroTabControl1.SelectedTab = MetroTabPage2

        Dim iMaxrate As Double = CInt(((Text_Upload.Text * 0.95 * 125) * 125) / Text_Slots.Text)
        If iMaxrate > 100000 Then
            iMaxrate = 100000
        End If
        Text_Output.Text = "sv_minrate 0" + vbNewLine +
                           "sv_maxrate " + iMaxrate.ToString + vbNewLine +
                           "sv_minupdaterate 4" + vbNewLine +
                           "sv_maxupdaterate " + CInt(iMaxrate / 300).ToString

        Text_RecCon.Text = CInt((Text_Upload.Text * 0.95 * 125) / 41).ToString()
        Text_RecRam.Text = CInt(Text_Ram.Text * 0.95 / 40).ToString()
        If Text_Cores.Text > 1 Then
            Text_RecCPU.Text = CInt((Text_CPU.Text * 0.95 / 87) * ((Text_Cores.Text - 1) * 3.36)).ToString()
        Else
            Text_RecCPU.Text = CInt(Text_CPU.Text * 0.95 / 87).ToString()
        End If
    End Sub

    Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles MetroLink1.Click
        Process.Start("http://www.xi4.me")
    End Sub
End Class
