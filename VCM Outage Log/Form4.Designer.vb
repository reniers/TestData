<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Location = New System.Drawing.Point(411, 302)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 35)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Compile Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(83, 66)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker2.CustomFormat = "2011/08/30"
        Me.DateTimePicker2.Location = New System.Drawing.Point(384, 66)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Start Date"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(318, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "End Date"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.VCML.My.Resources.Resources.global_logo
        Me.PictureBox1.Location = New System.Drawing.Point(15, 314)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(215, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(535, 302)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 35)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ALL Outages", "(ATL) pop3.lantic.net", "(ATL) www.lantic.net", "(ATL) webmail.lantic.net", "(ATL) webmail.lantic.net", "(ATL) HQ Power", "(ATL) LDAP Problems", "(ATL) SMTP: mail.lantic.net", "(ATL) netralink.lantic.net", "(ATL) xsinet.lantic.net", "(ATL) Hosted Websites", "(ATL) MJVN", "(ATL) Dial Authentication Problems", "(ATL) pop3.lantic.net", "(AIA) pop3.absamail.co.za", "(AIA) aiamail.lantic.net", "(AIA) EVW", "(AIA) LDAP Problems", "(AIA) Dial Authentication Problem", "(AIA) smtp.absamail.co.za", "(VDP) Fishbone Issues", "(VDP) Diginet - International eg GIB", "(VDP) Diginet General", "(VDP) mx.datapro.co.za", "(VDP) Database Problems eg Trax Lpass", "(VDP) Vox Website", "(VDP) DP JHB / HQ Phone Outage", "(VDP) DP CTN Phone Outage", "(VDP) DP DBN Phone Outage", "(VDP) DP DBN Power", "(VDP) DP CTN Power", "(VDP) DP JHB Power", "(VDP) DP Website", "(VDP) VPN Outages", "(VDP) BDSL", "(VDP) DP SMTP Auth", "(VDP) DP ETRN", "(VDP) Lector", "(VDP) Brightmail / Ironport", "(VDP) Dial Authentication", "(VTSC) Trax Outage", "(VTSC) Fax number", "(VTSC) Static ADSL", "(VTSC) Wireless Outages", "(VTSC) Phone system", "(VTSC) Call Operator Panel", "(VTSC) Logic SMS / Server", "(VTSC) Power", "(VTSC) Exchange", "(VTSC) File Server", "(VTSC) Scarab", "(VTSC) Switches", "(VTSC) Monitoring e.g Nagios", "(VTSC) Databases / CB System", "(AMVIA) Incoming Fax problems", "(AMVIA) Outgoing Fax problems", "(AMVIA) Website", "(Voice) CDR Rating Outage", "(Voice) Powwow", "(Voice) Metronet Outages", "(Voice) Verso Outages", "(Voice) Quintum Outages", "(Voice) Database outages", "(Voice) Telepreneur Outages", "(Voice) Quality issues", "(Voice) MOS Check problems", "(Voice) Maintenance", "(STORM) Databases e.g. Atlas", "(STORM) jhb.stormnet.co.za", "(STORM) dbn.stormnet.co.za", "(STORM) ctn.stormnet.co.za", "(STORM) DNS", "(STORM) Databases e.g. Atlas", "(STORM) ctn.stormnet.co.za", "Metro Connect", "Iburst outages", "Cell c", "Vodacom 3G Outages", "Telkom ADSL outages", "Neotel Outages", "Broadlink Wireless", "Comsol Wireless", "IS ADSL outages", "IS Dialup outages", "SAIX Dial up outages", "Hosted exchange", "Eskom Power Outage", "IS Bandwith", "Telkom Uniweb", "MWEB SIP Registrations", "VSAT"})
        Me.ComboBox1.Location = New System.Drawing.Point(231, 158)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(202, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(135, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Type of Outage"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 355)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.Text = "VCM Outage Report"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Public WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
