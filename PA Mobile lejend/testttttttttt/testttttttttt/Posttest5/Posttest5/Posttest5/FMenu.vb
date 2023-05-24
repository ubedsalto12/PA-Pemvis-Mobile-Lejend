Imports MySql.Data.MySqlClient

Public Class FMenu

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        End
    End Sub
    Private Sub PesanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PesanToolStripMenuItem.Click
        PemesananDiamond.Show()
    End Sub
    Private Sub DataDiamondToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataDiamondToolStripMenuItem.Click
        DataDiamond.Show()
    End Sub
    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Login.Show()

    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        SLabel5.Text = TimeOfDay
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Call Terkunci()
    End Sub
    Sub Terkunci()
        LoginToolStripMenuItem.Enabled = True
        PemesananDiamondToolStripMenuItem.Enabled = False
        LogoutToolStripMenuItem.Enabled = False
        MasterDataToolStripMenuItem.Enabled = False

        PengaturanToolStripMenuItem.Enabled = True
        KeluarToolStripMenuItem.Enabled = True
        SLabel1.Text = ""
        SLabel2.Text = ""
        SLabel3.Text = ""
    End Sub
    Private Sub FMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Terkunci()
    End Sub
    Private Sub DataPemesananDiamondToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPemesananDiamondToolStripMenuItem.Click
        DataPemesanan.Show()
    End Sub

    Private Sub LaporanDataDiamondToolStripMenuItem_Click(sender As Object, e As EventArgs)
        LaporanDataPemesanan.Show()
    End Sub


End Class