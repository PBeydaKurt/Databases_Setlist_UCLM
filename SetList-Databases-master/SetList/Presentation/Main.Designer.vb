<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btn_Statistics = New System.Windows.Forms.Button()
        Me.btn_openCountries = New System.Windows.Forms.Button()
        Me.btn_openArtists = New System.Windows.Forms.Button()
        Me.btn_openVenues = New System.Windows.Forms.Button()
        Me.btn_openSongs = New System.Windows.Forms.Button()
        Me.btn_openAlbums = New System.Windows.Forms.Button()
        Me.btn_openConcerts = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(412, 18)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(348, 77)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'btn_Statistics
        '
        Me.btn_Statistics.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Statistics.Image = Global.SetList.My.Resources.Resources.grafico
        Me.btn_Statistics.Location = New System.Drawing.Point(412, 510)
        Me.btn_Statistics.Name = "btn_Statistics"
        Me.btn_Statistics.Size = New System.Drawing.Size(235, 71)
        Me.btn_Statistics.TabIndex = 36
        Me.btn_Statistics.Text = "Statistics" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn_Statistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Statistics.UseVisualStyleBackColor = True
        '
        'btn_openCountries
        '
        Me.btn_openCountries.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_openCountries.Image = Global.SetList.My.Resources.Resources.countries
        Me.btn_openCountries.Location = New System.Drawing.Point(70, 183)
        Me.btn_openCountries.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_openCountries.Name = "btn_openCountries"
        Me.btn_openCountries.Size = New System.Drawing.Size(235, 71)
        Me.btn_openCountries.TabIndex = 37
        Me.btn_openCountries.Text = "Countries"
        Me.btn_openCountries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_openCountries.UseVisualStyleBackColor = True
        '
        'btn_openArtists
        '
        Me.btn_openArtists.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_openArtists.Image = Global.SetList.My.Resources.Resources.cantante
        Me.btn_openArtists.Location = New System.Drawing.Point(412, 183)
        Me.btn_openArtists.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_openArtists.Name = "btn_openArtists"
        Me.btn_openArtists.Size = New System.Drawing.Size(235, 71)
        Me.btn_openArtists.TabIndex = 38
        Me.btn_openArtists.Text = "Artist"
        Me.btn_openArtists.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_openArtists.UseVisualStyleBackColor = True
        '
        'btn_openVenues
        '
        Me.btn_openVenues.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_openVenues.Image = Global.SetList.My.Resources.Resources.puntero_del_mapa
        Me.btn_openVenues.Location = New System.Drawing.Point(752, 183)
        Me.btn_openVenues.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_openVenues.Name = "btn_openVenues"
        Me.btn_openVenues.Size = New System.Drawing.Size(235, 71)
        Me.btn_openVenues.TabIndex = 39
        Me.btn_openVenues.Text = "Venues"
        Me.btn_openVenues.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_openVenues.UseVisualStyleBackColor = True
        '
        'btn_openSongs
        '
        Me.btn_openSongs.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_openSongs.Image = Global.SetList.My.Resources.Resources.music
        Me.btn_openSongs.Location = New System.Drawing.Point(412, 339)
        Me.btn_openSongs.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_openSongs.Name = "btn_openSongs"
        Me.btn_openSongs.Size = New System.Drawing.Size(235, 71)
        Me.btn_openSongs.TabIndex = 40
        Me.btn_openSongs.Text = "Songs"
        Me.btn_openSongs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_openSongs.UseVisualStyleBackColor = True
        '
        'btn_openAlbums
        '
        Me.btn_openAlbums.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_openAlbums.Image = Global.SetList.My.Resources.Resources.album
        Me.btn_openAlbums.Location = New System.Drawing.Point(70, 339)
        Me.btn_openAlbums.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_openAlbums.Name = "btn_openAlbums"
        Me.btn_openAlbums.Size = New System.Drawing.Size(235, 71)
        Me.btn_openAlbums.TabIndex = 41
        Me.btn_openAlbums.Text = "Albums"
        Me.btn_openAlbums.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_openAlbums.UseVisualStyleBackColor = True
        '
        'btn_openConcerts
        '
        Me.btn_openConcerts.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_openConcerts.Image = Global.SetList.My.Resources.Resources.concierto
        Me.btn_openConcerts.Location = New System.Drawing.Point(752, 339)
        Me.btn_openConcerts.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_openConcerts.Name = "btn_openConcerts"
        Me.btn_openConcerts.Size = New System.Drawing.Size(235, 71)
        Me.btn_openConcerts.TabIndex = 42
        Me.btn_openConcerts.Text = "Concerts"
        Me.btn_openConcerts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_openConcerts.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1076, 618)
        Me.Controls.Add(Me.btn_openConcerts)
        Me.Controls.Add(Me.btn_openAlbums)
        Me.Controls.Add(Me.btn_openSongs)
        Me.Controls.Add(Me.btn_openVenues)
        Me.Controls.Add(Me.btn_openArtists)
        Me.Controls.Add(Me.btn_openCountries)
        Me.Controls.Add(Me.btn_Statistics)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1092, 657)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1092, 657)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setlist"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_Statistics As Button
    Friend WithEvents btn_openCountries As Button
    Friend WithEvents btn_openArtists As Button
    Friend WithEvents btn_openVenues As Button
    Friend WithEvents btn_openSongs As Button
    Friend WithEvents btn_openAlbums As Button
    Friend WithEvents btn_openConcerts As Button
End Class
