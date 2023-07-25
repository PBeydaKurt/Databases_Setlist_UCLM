<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SongsForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SongsForm))
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_clean = New System.Windows.Forms.Button()
        Me.lst_albums = New System.Windows.Forms.ListBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_songOrder = New System.Windows.Forms.TextBox()
        Me.lst_songs = New System.Windows.Forms.ListBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_songLength = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_songName = New System.Windows.Forms.TextBox()
        Me.btn_deleteSong = New System.Windows.Forms.Button()
        Me.btn_updateSong = New System.Windows.Forms.Button()
        Me.btn_insertSong = New System.Windows.Forms.Button()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Silver
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.btn_back)
        Me.Panel6.Controls.Add(Me.btn_clean)
        Me.Panel6.Controls.Add(Me.lst_albums)
        Me.Panel6.Controls.Add(Me.Label22)
        Me.Panel6.Controls.Add(Me.txt_songOrder)
        Me.Panel6.Controls.Add(Me.lst_songs)
        Me.Panel6.Controls.Add(Me.Label23)
        Me.Panel6.Controls.Add(Me.txt_songLength)
        Me.Panel6.Controls.Add(Me.Label21)
        Me.Panel6.Controls.Add(Me.Label20)
        Me.Panel6.Controls.Add(Me.txt_songName)
        Me.Panel6.Controls.Add(Me.btn_deleteSong)
        Me.Panel6.Controls.Add(Me.btn_updateSong)
        Me.Panel6.Controls.Add(Me.btn_insertSong)
        Me.Panel6.Location = New System.Drawing.Point(131, 91)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1185, 608)
        Me.Panel6.TabIndex = 35
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Image = Global.SetList.My.Resources.Resources.volver__1_
        Me.btn_back.Location = New System.Drawing.Point(43, 519)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(181, 68)
        Me.btn_back.TabIndex = 54
        Me.btn_back.Text = "BACK"
        Me.btn_back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_clean
        '
        Me.btn_clean.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clean.Image = Global.SetList.My.Resources.Resources.escoba__2_
        Me.btn_clean.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_clean.Location = New System.Drawing.Point(967, 519)
        Me.btn_clean.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_clean.Name = "btn_clean"
        Me.btn_clean.Size = New System.Drawing.Size(181, 68)
        Me.btn_clean.TabIndex = 53
        Me.btn_clean.Text = "CLEAN"
        Me.btn_clean.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_clean.UseVisualStyleBackColor = True
        '
        'lst_albums
        '
        Me.lst_albums.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_albums.FormattingEnabled = True
        Me.lst_albums.ItemHeight = 25
        Me.lst_albums.Location = New System.Drawing.Point(748, 68)
        Me.lst_albums.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_albums.Name = "lst_albums"
        Me.lst_albums.Size = New System.Drawing.Size(399, 329)
        Me.lst_albums.TabIndex = 40
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label22.Location = New System.Drawing.Point(741, 20)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(100, 32)
        Me.Label22.TabIndex = 38
        Me.Label22.Text = "Album" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txt_songOrder
        '
        Me.txt_songOrder.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_songOrder.Location = New System.Drawing.Point(345, 348)
        Me.txt_songOrder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_songOrder.MaxLength = 2
        Me.txt_songOrder.Name = "txt_songOrder"
        Me.txt_songOrder.Size = New System.Drawing.Size(361, 39)
        Me.txt_songOrder.TabIndex = 30
        '
        'lst_songs
        '
        Me.lst_songs.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_songs.FormattingEnabled = True
        Me.lst_songs.ItemHeight = 25
        Me.lst_songs.Location = New System.Drawing.Point(43, 71)
        Me.lst_songs.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_songs.Name = "lst_songs"
        Me.lst_songs.Size = New System.Drawing.Size(277, 429)
        Me.lst_songs.TabIndex = 29
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label23.Location = New System.Drawing.Point(341, 302)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(93, 32)
        Me.Label23.TabIndex = 39
        Me.Label23.Text = "Order"
        '
        'txt_songLength
        '
        Me.txt_songLength.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_songLength.Location = New System.Drawing.Point(347, 210)
        Me.txt_songLength.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_songLength.MaxLength = 4
        Me.txt_songLength.Name = "txt_songLength"
        Me.txt_songLength.Size = New System.Drawing.Size(361, 39)
        Me.txt_songLength.TabIndex = 35
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label21.Location = New System.Drawing.Point(340, 164)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(108, 32)
        Me.Label21.TabIndex = 37
        Me.Label21.Text = "Length"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label20.Location = New System.Drawing.Point(340, 39)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(93, 32)
        Me.Label20.TabIndex = 36
        Me.Label20.Text = "Name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txt_songName
        '
        Me.txt_songName.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_songName.Location = New System.Drawing.Point(345, 73)
        Me.txt_songName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_songName.Name = "txt_songName"
        Me.txt_songName.Size = New System.Drawing.Size(361, 39)
        Me.txt_songName.TabIndex = 34
        '
        'btn_deleteSong
        '
        Me.btn_deleteSong.Enabled = False
        Me.btn_deleteSong.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deleteSong.Image = CType(resources.GetObject("btn_deleteSong.Image"), System.Drawing.Image)
        Me.btn_deleteSong.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_deleteSong.Location = New System.Drawing.Point(748, 519)
        Me.btn_deleteSong.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_deleteSong.Name = "btn_deleteSong"
        Me.btn_deleteSong.Size = New System.Drawing.Size(181, 68)
        Me.btn_deleteSong.TabIndex = 30
        Me.btn_deleteSong.Text = "DELETE"
        Me.btn_deleteSong.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_deleteSong.UseVisualStyleBackColor = True
        '
        'btn_updateSong
        '
        Me.btn_updateSong.Enabled = False
        Me.btn_updateSong.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_updateSong.Image = CType(resources.GetObject("btn_updateSong.Image"), System.Drawing.Image)
        Me.btn_updateSong.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_updateSong.Location = New System.Drawing.Point(967, 425)
        Me.btn_updateSong.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_updateSong.Name = "btn_updateSong"
        Me.btn_updateSong.Size = New System.Drawing.Size(181, 68)
        Me.btn_updateSong.TabIndex = 30
        Me.btn_updateSong.Text = "UPDATE"
        Me.btn_updateSong.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_updateSong.UseVisualStyleBackColor = True
        '
        'btn_insertSong
        '
        Me.btn_insertSong.Enabled = False
        Me.btn_insertSong.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insertSong.Image = Global.SetList.My.Resources.Resources.plus__1_
        Me.btn_insertSong.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_insertSong.Location = New System.Drawing.Point(748, 425)
        Me.btn_insertSong.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_insertSong.Name = "btn_insertSong"
        Me.btn_insertSong.Size = New System.Drawing.Size(181, 68)
        Me.btn_insertSong.TabIndex = 33
        Me.btn_insertSong.Text = "ADD"
        Me.btn_insertSong.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_insertSong.UseVisualStyleBackColor = True
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = Global.SetList.My.Resources.Resources.music1
        Me.PictureBox7.Location = New System.Drawing.Point(601, 9)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(106, 78)
        Me.PictureBox7.TabIndex = 28
        Me.PictureBox7.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Verdana", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(704, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(237, 73)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Songs"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(42, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 32)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Songs"
        '
        'SongsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SetList.My.Resources.Resources.Five_Simple_Editing_Tips_That_Will_Make_Your_Photos_Stand_Out
        Me.ClientSize = New System.Drawing.Size(1432, 753)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.PictureBox7)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "SongsForm"
        Me.Text = "Songs"
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel6 As Panel
    Friend WithEvents txt_songOrder As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txt_songLength As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txt_songName As TextBox
    Friend WithEvents btn_deleteSong As Button
    Friend WithEvents btn_updateSong As Button
    Friend WithEvents btn_insertSong As Button
    Friend WithEvents lst_songs As ListBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents lst_albums As ListBox
    Friend WithEvents btn_clean As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents Label1 As Label
End Class
