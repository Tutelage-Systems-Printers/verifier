Public Class frmMain

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnScan.Click
        device_ip_address = txtIPAddress.Text
        snmp_password = txtSnmpPassword.Text
        snmp_timeout = txtSnmpTimeout.Text

        ResetDevice()
        Scan()

        tsLabel.Text = "The scan took: " & (printer.debug_time_start - printer.debug_time_stop).Milliseconds & " milliseconds."

        If (printer.information_was_scanned) Then
            txtManufacture.Text = printer.general_manufacture
            txtModel.Text = printer.general_model
            txtSerialNumber.Text = printer.general_serial
            chkIsColor.Checked = printer.general_color
            txtTotalPageCount.Text = printer.counter_total
            txtMonoCount.Text = printer.counter_mono_total
            txtColorCount.Text = printer.counter_color_total

            pbBlackToner.Value = printer.supplies_black.Percentage
            lblBlackTonerPercent.Text = printer.supplies_black.Percentage & "%"
            txtBlackTonerPart.Text = printer.supplies_black.Part

            pbCyanToner.Value = printer.supplies_cyan.Percentage
            lblCyanTonerPercent.Text = printer.supplies_cyan.Percentage & "%"
            txtCyanTonerPart.Text = printer.supplies_cyan.Part

            pbYellowToner.Value = printer.supplies_yellow.Percentage
            lblYellowTonerPercent.Text = printer.supplies_yellow.Percentage & "%"
            txtYellowTonerPart.Text = printer.supplies_yellow.Part

            pbMagentaToner.Value = printer.supplies_yellow.Percentage
            lblMagentaTonerPercent.Text = printer.supplies_yellow.Percentage & "%"
            txtMagentaTonerPart.Text = printer.supplies_magenta.Part

            txtDisplay.Text = printer.general_display
        Else
            MessageBox.Show("The IP Address could not be reached", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Sub ResetDevice()
        txtManufacture.Text = ""
        txtModel.Text = ""
        txtSerialNumber.Text = ""
        chkIsColor.Checked = False
        txtTotalPageCount.Text = ""
        txtMonoCount.Text = ""
        txtColorCount.Text = ""
        pbBlackToner.Value = 0
        txtBlackTonerPart.Text = ""
        lblBlackTonerPercent.Text = "0%"
        pbCyanToner.Value = 0
        txtCyanTonerPart.Text = ""
        lblCyanTonerPercent.Text = "0%"
        pbYellowToner.Value = 0
        txtYellowTonerPart.Text = ""
        lblYellowTonerPercent.Text = "0%"
        pbMagentaToner.Value = 0
        txtMagentaTonerPart.Text = ""
        lblMagentaTonerPercent.Text = "0%"
        txtDisplay.Text = ""
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        ResetDevice()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim s_message As String = Application.ProductName & vbNewLine & vbNewLine & "Version: " & Application.ProductVersion & vbNewLine & vbNewLine & Application.CompanyName

        MessageBox.Show(s_message, "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
