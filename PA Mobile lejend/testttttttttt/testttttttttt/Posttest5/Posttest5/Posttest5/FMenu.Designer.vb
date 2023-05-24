<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FMenu
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PemesananDiamondToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataDiamondToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPemesananDiamondToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengaturanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.SLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PemesananDiamondToolStripMenuItem, Me.MasterDataToolStripMenuItem, Me.PengaturanToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(600, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PemesananDiamondToolStripMenuItem
        '
        Me.PemesananDiamondToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PesanToolStripMenuItem})
        Me.PemesananDiamondToolStripMenuItem.Name = "PemesananDiamondToolStripMenuItem"
        Me.PemesananDiamondToolStripMenuItem.Size = New System.Drawing.Size(132, 20)
        Me.PemesananDiamondToolStripMenuItem.Text = "Pemesanan Diamond"
        '
        'PesanToolStripMenuItem
        '
        Me.PesanToolStripMenuItem.Name = "PesanToolStripMenuItem"
        Me.PesanToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PesanToolStripMenuItem.Text = "Pesan"
        '
        'MasterDataToolStripMenuItem
        '
        Me.MasterDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataDiamondToolStripMenuItem, Me.DataPemesananDiamondToolStripMenuItem})
        Me.MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        Me.MasterDataToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.MasterDataToolStripMenuItem.Text = "Master Data"
        '
        'DataDiamondToolStripMenuItem
        '
        Me.DataDiamondToolStripMenuItem.Name = "DataDiamondToolStripMenuItem"
        Me.DataDiamondToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.DataDiamondToolStripMenuItem.Text = "Data Diamond"
        '
        'DataPemesananDiamondToolStripMenuItem
        '
        Me.DataPemesananDiamondToolStripMenuItem.Name = "DataPemesananDiamondToolStripMenuItem"
        Me.DataPemesananDiamondToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.DataPemesananDiamondToolStripMenuItem.Text = "Data Pemesanan Diamond"
        '
        'PengaturanToolStripMenuItem
        '
        Me.PengaturanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.PengaturanToolStripMenuItem.Name = "PengaturanToolStripMenuItem"
        Me.PengaturanToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.PengaturanToolStripMenuItem.Text = "Pengaturan"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SLabel1, Me.SLabel2, Me.SLabel3, Me.SLabel4, Me.SLabel5})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 344)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(600, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'SLabel1
        '
        Me.SLabel1.Name = "SLabel1"
        Me.SLabel1.Size = New System.Drawing.Size(119, 17)
        Me.SLabel1.Text = "ToolStripStatusLabel1"
        '
        'SLabel2
        '
        Me.SLabel2.Name = "SLabel2"
        Me.SLabel2.Size = New System.Drawing.Size(119, 17)
        Me.SLabel2.Text = "ToolStripStatusLabel2"
        '
        'SLabel3
        '
        Me.SLabel3.Name = "SLabel3"
        Me.SLabel3.Size = New System.Drawing.Size(119, 17)
        Me.SLabel3.Text = "ToolStripStatusLabel3"
        '
        'SLabel4
        '
        Me.SLabel4.Name = "SLabel4"
        Me.SLabel4.Size = New System.Drawing.Size(34, 17)
        Me.SLabel4.Text = "Jam :"
        '
        'SLabel5
        '
        Me.SLabel5.Name = "SLabel5"
        Me.SLabel5.Size = New System.Drawing.Size(0, 17)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(82, 155)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(443, 49)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Diamond Mobile Legend"
        '
        'FMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Posttest5.My.Resources.Resources.back2
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FMenu"
        Me.Text = "FMenu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MasterDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengaturanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents SLabel1 As ToolStripStatusLabel
    Friend WithEvents SLabel2 As ToolStripStatusLabel
    Friend WithEvents SLabel3 As ToolStripStatusLabel
    Friend WithEvents DataDiamondToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PemesananDiamondToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PesanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SLabel4 As ToolStripStatusLabel
    Friend WithEvents SLabel5 As ToolStripStatusLabel
    Friend WithEvents DataPemesananDiamondToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
End Class
