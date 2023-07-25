<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConcertsForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConcertsForm))
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_clean = New System.Windows.Forms.Button()
        Me.btn_removeSong = New System.Windows.Forms.Button()
        Me.btn_addSong = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lst_songs = New System.Windows.Forms.ListBox()
        Me.lst_venues = New System.Windows.Forms.ListBox()
        Me.lst_artists = New System.Windows.Forms.ListBox()
        Me.lst_concertSetlist = New System.Windows.Forms.ListBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_deleteConcert = New System.Windows.Forms.Button()
        Me.btn_updateConcert = New System.Windows.Forms.Button()
        Me.btn_insertConcert = New System.Windows.Forms.Button()
        Me.txt_dateConcert = New System.Windows.Forms.DateTimePicker()
        Me.lst_concerts = New System.Windows.Forms.ListBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btn_orderBy = New System.Windows.Forms.Button()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Silver
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.btn_back)
        Me.Panel5.Controls.Add(Me.btn_clean)
        Me.Panel5.Controls.Add(Me.btn_removeSong)
        Me.Panel5.Controls.Add(Me.btn_addSong)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.lst_songs)
        Me.Panel5.Controls.Add(Me.lst_venues)
        Me.Panel5.Controls.Add(Me.lst_artists)
        Me.Panel5.Controls.Add(Me.lst_concertSetlist)
        Me.Panel5.Controls.Add(Me.Label19)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.btn_deleteConcert)
        Me.Panel5.Controls.Add(Me.btn_updateConcert)
        Me.Panel5.Controls.Add(Me.btn_insertConcert)
        Me.Panel5.Controls.Add(Me.txt_dateConcert)
        Me.Panel5.Controls.Add(Me.lst_concerts)
        Me.Panel5.Location = New System.Drawing.Point(131, 91)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1185, 608)
        Me.Panel5.TabIndex = 32
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Image = Global.SetList.My.Resources.Resources.volver__1_
        Me.btn_back.Location = New System.Drawing.Point(21, 517)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(181, 68)
        Me.btn_back.TabIndex = 34
        Me.btn_back.Text = "BACK"
        Me.btn_back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_clean
        '
        Me.btn_clean.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clean.Image = Global.SetList.My.Resources.Resources.escoba__2_
        Me.btn_clean.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_clean.Location = New System.Drawing.Point(990, 517)
        Me.btn_clean.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_clean.Name = "btn_clean"
        Me.btn_clean.Size = New System.Drawing.Size(181, 68)
        Me.btn_clean.TabIndex = 51
        Me.btn_clean.Text = "CLEAN"
        Me.btn_clean.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_clean.UseVisualStyleBackColor = True
        '
        'btn_removeSong
        '
        Me.btn_removeSong.Enabled = False
        Me.btn_removeSong.Image = Global.SetList.My.Resources.Resources.flecha_izquierda
        Me.btn_removeSong.Location = New System.Drawing.Point(906, 251)
        Me.btn_removeSong.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_removeSong.Name = "btn_removeSong"
        Me.btn_removeSong.Size = New System.Drawing.Size(47, 43)
        Me.btn_removeSong.TabIndex = 50
        Me.btn_removeSong.UseVisualStyleBackColor = True
        '
        'btn_addSong
        '
        Me.btn_addSong.Enabled = False
        Me.btn_addSong.Image = Global.SetList.My.Resources.Resources.flecha_correcta
        Me.btn_addSong.Location = New System.Drawing.Point(905, 144)
        Me.btn_addSong.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_addSong.Name = "btn_addSong"
        Me.btn_addSong.Size = New System.Drawing.Size(47, 43)
        Me.btn_addSong.TabIndex = 49
        Me.btn_addSong.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(694, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 32)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Songs"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(959, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 32)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Setlist"
        '
        'lst_songs
        '
        Me.lst_songs.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_songs.FormattingEnabled = True
        Me.lst_songs.ItemHeight = 22
        Me.lst_songs.Location = New System.Drawing.Point(690, 55)
        Me.lst_songs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_songs.Name = "lst_songs"
        Me.lst_songs.Size = New System.Drawing.Size(208, 356)
        Me.lst_songs.TabIndex = 46
        '
        'lst_venues
        '
        Me.lst_venues.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_venues.FormattingEnabled = True
        Me.lst_venues.ItemHeight = 22
        Me.lst_venues.Location = New System.Drawing.Point(330, 361)
        Me.lst_venues.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_venues.Name = "lst_venues"
        Me.lst_venues.Size = New System.Drawing.Size(351, 224)
        Me.lst_venues.TabIndex = 45
        '
        'lst_artists
        '
        Me.lst_artists.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_artists.FormattingEnabled = True
        Me.lst_artists.ItemHeight = 22
        Me.lst_artists.Location = New System.Drawing.Point(330, 127)
        Me.lst_artists.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_artists.Name = "lst_artists"
        Me.lst_artists.Size = New System.Drawing.Size(351, 202)
        Me.lst_artists.TabIndex = 44
        '
        'lst_concertSetlist
        '
        Me.lst_concertSetlist.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_concertSetlist.FormattingEnabled = True
        Me.lst_concertSetlist.ItemHeight = 22
        Me.lst_concertSetlist.Location = New System.Drawing.Point(958, 55)
        Me.lst_concertSetlist.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_concertSetlist.Name = "lst_concertSetlist"
        Me.lst_concertSetlist.Size = New System.Drawing.Size(213, 356)
        Me.lst_concertSetlist.TabIndex = 36
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label19.Location = New System.Drawing.Point(15, 22)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(203, 32)
        Me.Label19.TabIndex = 35
        Me.Label19.Text = "Artist - Venue"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label18.Location = New System.Drawing.Point(325, 26)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 32)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Date"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label16.Location = New System.Drawing.Point(325, 331)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 32)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "Venue"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(325, 97)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 32)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Artist"
        '
        'btn_deleteConcert
        '
        Me.btn_deleteConcert.Enabled = False
        Me.btn_deleteConcert.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deleteConcert.Image = CType(resources.GetObject("btn_deleteConcert.Image"), System.Drawing.Image)
        Me.btn_deleteConcert.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_deleteConcert.Location = New System.Drawing.Point(717, 517)
        Me.btn_deleteConcert.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_deleteConcert.Name = "btn_deleteConcert"
        Me.btn_deleteConcert.Size = New System.Drawing.Size(181, 68)
        Me.btn_deleteConcert.TabIndex = 30
        Me.btn_deleteConcert.Text = "DELETE"
        Me.btn_deleteConcert.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_deleteConcert.UseVisualStyleBackColor = True
        '
        'btn_updateConcert
        '
        Me.btn_updateConcert.Enabled = False
        Me.btn_updateConcert.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_updateConcert.Image = CType(resources.GetObject("btn_updateConcert.Image"), System.Drawing.Image)
        Me.btn_updateConcert.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_updateConcert.Location = New System.Drawing.Point(990, 425)
        Me.btn_updateConcert.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_updateConcert.Name = "btn_updateConcert"
        Me.btn_updateConcert.Size = New System.Drawing.Size(181, 68)
        Me.btn_updateConcert.TabIndex = 30
        Me.btn_updateConcert.Text = "UPDATE"
        Me.btn_updateConcert.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_updateConcert.UseVisualStyleBackColor = True
        '
        'btn_insertConcert
        '
        Me.btn_insertConcert.Enabled = False
        Me.btn_insertConcert.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insertConcert.Image = Global.SetList.My.Resources.Resources.plus__1_
        Me.btn_insertConcert.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_insertConcert.Location = New System.Drawing.Point(717, 425)
        Me.btn_insertConcert.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_insertConcert.Name = "btn_insertConcert"
        Me.btn_insertConcert.Size = New System.Drawing.Size(181, 68)
        Me.btn_insertConcert.TabIndex = 33
        Me.btn_insertConcert.Text = "ADD"
        Me.btn_insertConcert.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_insertConcert.UseVisualStyleBackColor = True
        '
        'txt_dateConcert
        '
        Me.txt_dateConcert.CalendarFont = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dateConcert.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dateConcert.Location = New System.Drawing.Point(330, 57)
        Me.txt_dateConcert.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_dateConcert.Name = "txt_dateConcert"
        Me.txt_dateConcert.Size = New System.Drawing.Size(351, 29)
        Me.txt_dateConcert.TabIndex = 32
        '
        'lst_concerts
        '
        Me.lst_concerts.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_concerts.FormattingEnabled = True
        Me.lst_concerts.ItemHeight = 22
        Me.lst_concerts.Location = New System.Drawing.Point(21, 59)
        Me.lst_concerts.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_concerts.Name = "lst_concerts"
        Me.lst_concerts.Size = New System.Drawing.Size(298, 444)
        Me.lst_concerts.TabIndex = 29
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = Global.SetList.My.Resources.Resources.spotlight
        Me.PictureBox6.Location = New System.Drawing.Point(505, 4)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(92, 80)
        Me.PictureBox6.TabIndex = 28
        Me.PictureBox6.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Verdana", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label17.Location = New System.Drawing.Point(584, 11)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(327, 73)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Concerts"
        '
        'btn_orderBy
        '
        Me.btn_orderBy.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_orderBy.Image = Global.SetList.My.Resources.Resources.sort_by_alphabet
        Me.btn_orderBy.Location = New System.Drawing.Point(1135, 14)
        Me.btn_orderBy.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_orderBy.Name = "btn_orderBy"
        Me.btn_orderBy.Size = New System.Drawing.Size(181, 68)
        Me.btn_orderBy.TabIndex = 33
        Me.btn_orderBy.Text = "Order by"
        Me.btn_orderBy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_orderBy.UseVisualStyleBackColor = True
        '
        'ConcertsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SetList.My.Resources.Resources.Five_Simple_Editing_Tips_That_Will_Make_Your_Photos_Stand_Out
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1432, 753)
        Me.Controls.Add(Me.btn_orderBy)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.PictureBox6)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ConcertsForm"
        Me.Text = "Concerts"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel5 As Panel
    Friend WithEvents lst_concertSetlist As ListBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btn_deleteConcert As Button
    Friend WithEvents btn_updateConcert As Button
    Friend WithEvents btn_insertConcert As Button
    Friend WithEvents txt_dateConcert As DateTimePicker
    Friend WithEvents lst_concerts As ListBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents lst_artists As ListBox
    Friend WithEvents lst_venues As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lst_songs As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_removeSong As Button
    Friend WithEvents btn_addSong As Button
    Friend WithEvents btn_clean As Button
    Friend WithEvents btn_orderBy As Button
    Friend WithEvents btn_back As Button
End Class
