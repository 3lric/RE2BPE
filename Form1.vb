Public Class Form1

    Public Sub Combo1_Click(sender As Object, e As EventArgs) Handles Combo1.Click, Combo1.SelectedIndexChanged


        StartLoc_Button.Enabled = False
        StartInv_Button.Enabled = False
        HP_Button.Enabled = False
        DMG_Button.Enabled = False
        Foot_Button.Enabled = False
        BGM_Button.Enabled = False
        Convert_Button.Enabled = False
        SCD_Button.Enabled = False
        XAS_Button.Enabled = False

        If Combo1.Text = ("Windows") Then
            Combo2.Enabled = True
            Combo2.Items.Clear()
            Combo2.Text = ("Select Version...")
            Combo2.Items.Add("Platinum 1.00 (UK)")
            Combo2.Items.Add("Sourcenext 1.0")
            Combo2.Items.Add("Sourcenext 1.1")

        ElseIf Combo1.Text = ("Playstation") Then
            Combo2.Enabled = True
            Combo2.Items.Clear()
            Combo2.Text = ("Select Version...")
            Combo2.Items.Add("SLUS_004.21")
            Combo2.Items.Add("SLUS_005.92")
            Combo2.Items.Add("SLUS_007.48")
            Combo2.Items.Add("SLUS_007.56")
            Combo2.Items.Add("SLES_009.72")
            Combo2.Items.Add("SLES_009.73")
            Combo2.Items.Add("SLES_009.74")
            Combo2.Items.Add("SLES_009.75")
            Combo2.Items.Add("SLES_009.76")
            Combo2.Items.Add("SLES_109.72")
            Combo2.Items.Add("SLES_109.73")
            Combo2.Items.Add("SLES_109.74")
            Combo2.Items.Add("SLES_109.75")
            Combo2.Items.Add("SLES_109.76")
            Combo2.Items.Add("SLPS_012.22")
            Combo2.Items.Add("SLPS_012.23")
            Combo2.Items.Add("SLPS_015.10")
            Combo2.Items.Add("SLPS_015.11")

        ElseIf Combo1.Text = ("Dreamcast") Then
            Combo2.Enabled = True
            Combo2.Items.Clear()
            Combo2.Text = ("Select Version...")
            Combo2.Items.Add("T-1205N (USA)")
            Combo2.Items.Add("T-7004D-61 (PAL)")
            Combo2.Items.Add("T-1214M (JAP)")

        ElseIf Combo1.Text = ("Gamecube") Then
            Combo2.Enabled = True
            Combo2.Items.Clear()
            Combo2.Text = ("Select Version...")
            Combo2.Items.Add("DOL-GHAE-USA")
            Combo2.Items.Add("DOL-GHAJ-JPN")
            Combo2.Items.Add("DOL-GHAP-FRA")
            Combo2.Items.Add("DOL-GHAP-UKV")
            Combo2.Items.Add("DOL-GHAP-EUR")
        End If

    End Sub
    Public Sub Combo2_Click(sender As Object, e As EventArgs) Handles Combo2.Click, Combo2.SelectedIndexChanged

        StartLoc_Button.Enabled = False
        StartInv_Button.Enabled = False
        HP_Button.Enabled = False
        DMG_Button.Enabled = False
        Foot_Button.Enabled = False
        BGM_Button.Enabled = False
        Convert_Button.Enabled = False
        SCD_Button.Enabled = False
        XAS_Button.Enabled = False

        If Combo2.Text = ("SLUS_004.21") Then
            Combo3.Enabled = True
            Combo3.Items.Clear()
            Combo3.Text = ("Select Character...")
            Combo3.Items.Add("Leon")
            Combo3.Items.Add("4th Survivor")

        ElseIf Combo2.Text = ("SLUS_005.92") Then
            Combo3.Enabled = True
            Combo3.Items.Clear()
            Combo3.Text = ("Select Character...")
            Combo3.Items.Add("Claire")
            Combo3.Items.Add("4th Survivor")

        ElseIf Combo2.Text = ("SLUS_007.48") Then
            Combo3.Enabled = True
            Combo3.Items.Clear()
            Combo3.Text = ("Select Character...")
            Combo3.Items.Add("Leon")
            Combo3.Items.Add("4th Survivor")
            Combo3.Items.Add("Extreme Battle")

        ElseIf Combo2.Text = ("SLUS_007.56") Then
            Combo3.Enabled = True
            Combo3.Items.Clear()
            Combo3.Text = ("Select Character...")
            Combo3.Items.Add("Claire")
            Combo3.Items.Add("4th Survivor")
            Combo3.Items.Add("Extreme Battle")

        ElseIf Combo2.Text = ("SLUS_007.56") Then
            Combo3.Enabled = True
            Combo3.Items.Clear()
            Combo3.Text = ("Select Character...")
            Combo3.Items.Add("Claire")
            Combo3.Items.Add("4th Survivor")
            Combo3.Items.Add("Extreme Battle")

        ElseIf Combo2.Text = ("SLES_009.72") Then
            Combo3.Enabled = True
            Combo3.Items.Clear()
            Combo3.Text = ("Select Character...")
            Combo3.Items.Add("Leon")
            Combo3.Items.Add("4th Survivor")

        ElseIf Combo2.Text = ("SLES_009.73") Then
            Combo3.Enabled = True
            Combo3.Items.Clear()
            Combo3.Text = ("Select Character...")
            Combo3.Items.Add("Leon")
            Combo3.Items.Add("4th Survivor")

        ElseIf Combo2.Text = ("SLES_009.74") Then
            Combo3.Enabled = True
            Combo3.Items.Clear()
            Combo3.Text = ("Select Character...")
            Combo3.Items.Add("Leon")
            Combo3.Items.Add("4th Survivor")

        ElseIf Combo2.Text = ("SLES_009.75") Then
            Combo3.Enabled = True
            Combo3.Items.Clear()
            Combo3.Text = ("Select Character...")
            Combo3.Items.Add("Leon")
            Combo3.Items.Add("4th Survivor")

        ElseIf Combo2.Text = ("SLES_009.76") Then
            Combo3.Enabled = True
            Combo3.Items.Clear()
            Combo3.Text = ("Select Character...")
            Combo3.Items.Add("Leon")
            Combo3.Items.Add("4th Survivor")

        ElseIf Combo2.Text = ("SLES_109.72") Then
            Combo3.Enabled = True
            Combo3.Items.Clear()
            Combo3.Text = ("Select Character...")
            Combo3.Items.Add("Claire")
            Combo3.Items.Add("4th Survivor")

        ElseIf Combo2.Text = ("SLES_109.73") Then
            Combo3.Enabled = True
            Combo3.Items.Clear()
            Combo3.Text = ("Select Character...")
            Combo3.Items.Add("Claire")
            Combo3.Items.Add("4th Survivor")

        ElseIf Combo2.Text = ("SLES_109.74") Then
            Combo3.Enabled = True
            Combo3.Items.Clear()
            Combo3.Text = ("Select Character...")
            Combo3.Items.Add("Claire")
            Combo3.Items.Add("4th Survivor")

        ElseIf Combo2.Text = ("SLES_109.75") Then
            Combo3.Enabled = True
            Combo3.Items.Clear()
            Combo3.Text = ("Select Character...")
            Combo3.Items.Add("Claire")
            Combo3.Items.Add("4th Survivor")

        ElseIf Combo2.Text = ("SLES_109.76") Then
            Combo3.Enabled = True
            Combo3.Items.Clear()
            Combo3.Text = ("Select Character...")
            Combo3.Items.Add("Claire")
            Combo3.Items.Add("4th Survivor")

        ElseIf Combo2.Text = ("SLPS_012.22") Then
            Combo3.Enabled = True
            Combo3.Items.Clear()
            Combo3.Text = ("Select Character...")
            Combo3.Items.Add("Leon")
            Combo3.Items.Add("4th Survivor")

        ElseIf Combo2.Text = ("SLPS_012.23") Then
            Combo3.Enabled = True
            Combo3.Items.Clear()
            Combo3.Text = ("Select Character...")
            Combo3.Items.Add("Claire")
            Combo3.Items.Add("4th Survivor")

        ElseIf Combo2.Text = ("SLPS_015.10") Then
            Combo3.Enabled = True
            Combo3.Items.Clear()
            Combo3.Text = ("Select Character...")
            Combo3.Items.Add("Leon")
            Combo3.Items.Add("4th Survivor")
            Combo3.Items.Add("Extreme Battle")

        ElseIf Combo2.Text = ("SLPS_015.11") Then
            Combo3.Enabled = True
            Combo3.Items.Clear()
            Combo3.Text = ("Select Character...")
            Combo3.Items.Add("Claire")
            Combo3.Items.Add("4th Survivor")
            Combo3.Items.Add("Extreme Battle")

        ElseIf Combo2.Text = ("Platinum 1.00 (UK)") Then
            Combo3.Enabled = True
            Combo3.Items.Clear()
            Combo3.Text = ("Select Character...")
            Combo3.Items.Add("Leon")
            Combo3.Items.Add("Claire")
            Combo3.Items.Add("4th Survivor")
            Combo3.Items.Add("Extreme Battle")

        ElseIf Combo2.Text = ("Sourcenext 1.0") Then
            Combo3.Enabled = True
            Combo3.Items.Clear()
            Combo3.Text = ("Select Character...")
            Combo3.Items.Add("Leon")
            Combo3.Items.Add("Claire")
            Combo3.Items.Add("4th Survivor")
            Combo3.Items.Add("Extreme Battle")

        ElseIf Combo2.Text = ("Sourcenext 1.1") Then
            Combo3.Enabled = True
            Combo3.Items.Clear()
            Combo3.Text = ("Select Character...")
            Combo3.Items.Add("Leon")
            Combo3.Items.Add("Claire")
            Combo3.Items.Add("4th Survivor")
            Combo3.Items.Add("Extreme Battle")

        ElseIf Combo2.Text = ("T-1205N (USA)") Then
            Combo3.Enabled = True
            Combo3.Items.Clear()
            Combo3.Text = ("Select Character...")
            Combo3.Items.Add("Leon")
            Combo3.Items.Add("Claire")
            Combo3.Items.Add("4th Survivor")
            Combo3.Items.Add("Extreme Battle")

        ElseIf Combo2.Text = ("T-7004D-61 (PAL)") Then
            Combo3.Enabled = True
            Combo3.Items.Clear()
            Combo3.Text = ("Select Character...")
            Combo3.Items.Add("Leon")
            Combo3.Items.Add("Claire")
            Combo3.Items.Add("4th Survivor")
            Combo3.Items.Add("Extreme Battle")

        ElseIf Combo2.Text = ("T-1214M (JAP)") Then
            Combo3.Enabled = True
            Combo3.Items.Clear()
            Combo3.Text = ("Select Character...")
            Combo3.Items.Add("Leon")
            Combo3.Items.Add("Claire")
            Combo3.Items.Add("4th Survivor")
            Combo3.Items.Add("Extreme Battle")

        ElseIf Combo2.Text = ("DOL-GHAE-USA") Then
            Combo3.Enabled = True
            Combo3.Items.Clear()
            Combo3.Text = ("Select Character...")
            Combo3.Items.Add("Leon")
            Combo3.Items.Add("Claire")
            Combo3.Items.Add("4th Survivor")
            Combo3.Items.Add("Extreme Battle")

        ElseIf Combo2.Text = ("DOL-GHAJ-JPN") Then
            Combo3.Enabled = True
            Combo3.Items.Clear()
            Combo3.Text = ("Select Character...")
            Combo3.Items.Add("Leon")
            Combo3.Items.Add("Claire")
            Combo3.Items.Add("4th Survivor")
            Combo3.Items.Add("Extreme Battle")

        ElseIf Combo2.Text = ("DOL-GHAP-FRA") Then
            Combo3.Enabled = True
            Combo3.Items.Clear()
            Combo3.Text = ("Select Character...")
            Combo3.Items.Add("Leon")
            Combo3.Items.Add("Claire")
            Combo3.Items.Add("4th Survivor")
            Combo3.Items.Add("Extreme Battle")

        ElseIf Combo2.Text = ("DOL-GHAP-UKV") Then
            Combo3.Enabled = True
            Combo3.Items.Clear()
            Combo3.Text = ("Select Character...")
            Combo3.Items.Add("Leon")
            Combo3.Items.Add("Claire")
            Combo3.Items.Add("4th Survivor")
            Combo3.Items.Add("Extreme Battle")

        ElseIf Combo2.Text = ("DOL-GHAP-EUR") Then
            Combo3.Enabled = True
            Combo3.Items.Clear()
            Combo3.Text = ("Select Character...")
            Combo3.Items.Add("Leon")
            Combo3.Items.Add("Claire")
            Combo3.Items.Add("4th Survivor")
            Combo3.Items.Add("Extreme Battle")

        End If
    End Sub
    Public Sub Combo3_Click(sender As Object, e As EventArgs) Handles Combo3.Click, Combo3.SelectedIndexChanged
        If Combo1.Text = "Windows" And Combo2.Text = "Platinum 1.00 (UK)" And Combo3.Text = "Claire" Then
            StartLoc_Button.Enabled = True
            StartInv_Button.Enabled = False
            HP_Button.Enabled = False
            DMG_Button.Enabled = False
            Foot_Button.Enabled = False
            BGM_Button.Enabled = False
            Convert_Button.Enabled = False
            SCD_Button.Enabled = False
            XAS_Button.Enabled = False
        End If
    End Sub

    Public Sub Form_Load() Handles MyBase.Load

        Combo1.Items.Add("Windows")
        Combo1.Items.Add("Playstation")
        Combo1.Items.Add("Dreamcast")
        Combo1.Items.Add("Gamecube")

        Combo2.Enabled = Combo1.Text = "Windows"
        Combo2.Enabled = Combo1.Text = "Playstation"
        Combo2.Enabled = Combo1.Text = "Dreamcast"
        Combo2.Enabled = Combo1.Text = "Gamecube"

        Combo3.Enabled = Combo2.Text = "SLUS_004.21"
        Combo3.Enabled = Combo2.Text = "SLUS_005.92"
        Combo3.Enabled = Combo2.Text = "SLUS_007.48"
        Combo3.Enabled = Combo2.Text = "SLUS_007.56"

        Combo3.Enabled = Combo2.Text = "SLES_009.72"
        Combo3.Enabled = Combo2.Text = "SLES_009.73"
        Combo3.Enabled = Combo2.Text = "SLES_009.74"
        Combo3.Enabled = Combo2.Text = "SLES_009.75"
        Combo3.Enabled = Combo2.Text = "SLES_009.76"

        Combo3.Enabled = Combo2.Text = "SLES_109.72"
        Combo3.Enabled = Combo2.Text = "SLES_109.73"
        Combo3.Enabled = Combo2.Text = "SLES_109.74"
        Combo3.Enabled = Combo2.Text = "SLES_109.75"
        Combo3.Enabled = Combo2.Text = "SLES_109.76"

        Combo3.Enabled = Combo2.Text = "SLPS_012.22"
        Combo3.Enabled = Combo2.Text = "SLPS_012.23"
        Combo3.Enabled = Combo2.Text = "SLPS_015.10"
        Combo3.Enabled = Combo2.Text = "SLPS_015.11"

        Combo3.Enabled = Combo2.Text = "Platinum 1.00 (UK)"
        Combo3.Enabled = Combo2.Text = "Sourcenext 1.0"
        Combo3.Enabled = Combo2.Text = "Sourcenext 1.1"
        Combo3.Enabled = Combo2.Text = "T-1205N (USA)"
        Combo3.Enabled = Combo2.Text = "T-7004D-61 (PAL)"
        Combo3.Enabled = Combo2.Text = "T-1214M (JAP)"
        Combo3.Enabled = Combo2.Text = "DOL-GHAE-USA"
        Combo3.Enabled = Combo2.Text = "DOL-GHAJ-JPN"
        Combo3.Enabled = Combo2.Text = "DOL-GHAP-FRA"
        Combo3.Enabled = Combo2.Text = "DOL-GHAP-UKV"
        Combo3.Enabled = Combo2.Text = "DOL-GHAP-EUR"

        StartLoc_Button.Enabled = False
        StartInv_Button.Enabled = False
        HP_Button.Enabled = False
        DMG_Button.Enabled = False
        Foot_Button.Enabled = False
        BGM_Button.Enabled = False
        Convert_Button.Enabled = False
        SCD_Button.Enabled = False
        XAS_Button.Enabled = False

    End Sub


    Public Sub StartLoc_Button_Click(sender As Object, e As EventArgs) Handles StartLoc_Button.Click
        Dim Form2 As New Form2
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class
