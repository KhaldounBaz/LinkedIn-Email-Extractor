<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.CmbCountries = New System.Windows.Forms.ComboBox()
        Me.TxtJob = New System.Windows.Forms.TextBox()
        Me.TxtKeywords = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewSearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExportListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchPreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.l1 = New System.Windows.Forms.Label()
        Me.l2 = New System.Windows.Forms.Label()
        Me.l3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmbCountries
        '
        Me.CmbCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCountries.FormattingEnabled = True
        Me.CmbCountries.Location = New System.Drawing.Point(9, 46)
        Me.CmbCountries.Name = "CmbCountries"
        Me.CmbCountries.Size = New System.Drawing.Size(180, 21)
        Me.CmbCountries.TabIndex = 0
        '
        'TxtJob
        '
        Me.TxtJob.AutoCompleteCustomSource.AddRange(New String() {"IT Manager ", "IT Manager or IT Director"})
        Me.TxtJob.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TxtJob.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtJob.Location = New System.Drawing.Point(196, 47)
        Me.TxtJob.Name = "TxtJob"
        Me.TxtJob.Size = New System.Drawing.Size(180, 20)
        Me.TxtJob.TabIndex = 1
        '
        'TxtKeywords
        '
        Me.TxtKeywords.Location = New System.Drawing.Point(9, 89)
        Me.TxtKeywords.Name = "TxtKeywords"
        Me.TxtKeywords.Size = New System.Drawing.Size(180, 20)
        Me.TxtKeywords.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(196, 89)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(180, 20)
        Me.TextBox3.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Country "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(193, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Job title"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(193, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Keywords to exclude"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Location or keywords to include"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(3, 115)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(373, 43)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Launch search"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(6, 163)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(370, 298)
        Me.ListView1.TabIndex = 14
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Email"
        Me.ColumnHeader2.Width = 355
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(3, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(92, 7)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 23)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(181, 7)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(83, 23)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Export"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(380, 24)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "File"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewSearchToolStripMenuItem, Me.ToolStripMenuItem1, Me.ExportListToolStripMenuItem, Me.ToolStripMenuItem2, Me.ClearListToolStripMenuItem, Me.ToolStripMenuItem3, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewSearchToolStripMenuItem
        '
        Me.NewSearchToolStripMenuItem.Name = "NewSearchToolStripMenuItem"
        Me.NewSearchToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.NewSearchToolStripMenuItem.Text = "New Search"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(133, 6)
        '
        'ExportListToolStripMenuItem
        '
        Me.ExportListToolStripMenuItem.Name = "ExportListToolStripMenuItem"
        Me.ExportListToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ExportListToolStripMenuItem.Text = "Export List"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(133, 6)
        '
        'ClearListToolStripMenuItem
        '
        Me.ClearListToolStripMenuItem.Name = "ClearListToolStripMenuItem"
        Me.ClearListToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ClearListToolStripMenuItem.Text = "Clear List"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(133, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchPreferencesToolStripMenuItem})
        Me.ToolsToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'SearchPreferencesToolStripMenuItem
        '
        Me.SearchPreferencesToolStripMenuItem.Name = "SearchPreferencesToolStripMenuItem"
        Me.SearchPreferencesToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.SearchPreferencesToolStripMenuItem.Text = "Search Preferences"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewHelpToolStripMenuItem, Me.ToolStripMenuItem4, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        Me.HelpToolStripMenuItem.Visible = False
        '
        'ViewHelpToolStripMenuItem
        '
        Me.ViewHelpToolStripMenuItem.Name = "ViewHelpToolStripMenuItem"
        Me.ViewHelpToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ViewHelpToolStripMenuItem.Text = "View Help"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(177, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 504)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(380, 24)
        Me.StatusStrip1.TabIndex = 19
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(91, 19)
        Me.ToolStripStatusLabel1.Text = "Emails Found:0"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(94, 19)
        Me.ToolStripStatusLabel2.Text = "Lines scanned:0"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 467)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(380, 37)
        Me.Panel1.TabIndex = 20
        '
        'l1
        '
        Me.l1.AutoSize = True
        Me.l1.BackColor = System.Drawing.Color.White
        Me.l1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l1.ForeColor = System.Drawing.Color.Gray
        Me.l1.Location = New System.Drawing.Point(197, 50)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(83, 13)
        Me.l1.TabIndex = 21
        Me.l1.Text = "e.g. IT Manager"
        '
        'l2
        '
        Me.l2.AutoSize = True
        Me.l2.BackColor = System.Drawing.Color.White
        Me.l2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l2.ForeColor = System.Drawing.Color.Gray
        Me.l2.Location = New System.Drawing.Point(13, 92)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(83, 13)
        Me.l2.TabIndex = 22
        Me.l2.Text = "e.g. Real Estate"
        '
        'l3
        '
        Me.l3.AutoSize = True
        Me.l3.BackColor = System.Drawing.Color.White
        Me.l3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l3.ForeColor = System.Drawing.Color.Gray
        Me.l3.Location = New System.Drawing.Point(197, 92)
        Me.l3.Name = "l3"
        Me.l3.Size = New System.Drawing.Size(51, 13)
        Me.l3.TabIndex = 23
        Me.l3.Text = "e.g.  cars"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 528)
        Me.Controls.Add(Me.l3)
        Me.Controls.Add(Me.l2)
        Me.Controls.Add(Me.l1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TxtKeywords)
        Me.Controls.Add(Me.TxtJob)
        Me.Controls.Add(Me.CmbCountries)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LinkedIn Express Extractor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbCountries As ComboBox
    Friend WithEvents TxtJob As TextBox
    Friend WithEvents TxtKeywords As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents NewSearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ExportListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents ClearListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchPreferencesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewHelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents l1 As Label
    Friend WithEvents l2 As Label
    Friend WithEvents l3 As Label
    Friend WithEvents Timer1 As Timer
End Class
