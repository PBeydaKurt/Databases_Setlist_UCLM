<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VenueForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VenueForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_clean = New System.Windows.Forms.Button()
        Me.lst_Countries = New System.Windows.Forms.ListBox()
        Me.cmb_venuesType = New System.Windows.Forms.ComboBox()
        Me.btn_updateVenue = New System.Windows.Forms.Button()
        Me.btn_deleteVenue = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lst_venues = New System.Windows.Forms.ListBox()
        Me.txt_venueName = New System.Windows.Forms.TextBox()
        Me.btn_insertVenue = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_back)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btn_clean)
        Me.Panel1.Controls.Add(Me.lst_Countries)
        Me.Panel1.Controls.Add(Me.cmb_venuesType)
        Me.Panel1.Controls.Add(Me.btn_updateVenue)
        Me.Panel1.Controls.Add(Me.btn_deleteVenue)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lst_venues)
        Me.Panel1.Controls.Add(Me.txt_venueName)
        Me.Panel1.Controls.Add(Me.btn_insertVenue)
        Me.Panel1.Location = New System.Drawing.Point(131, 91)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1185, 608)
        Me.Panel1.TabIndex = 27
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Image = Global.SetList.My.Resources.Resources.volver__1_
        Me.btn_back.Location = New System.Drawing.Point(33, 496)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(181, 68)
        Me.btn_back.TabIndex = 56
        Me.btn_back.Text = "BACK"
        Me.btn_back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(34, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 34)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Venues"
        '
        'btn_clean
        '
        Me.btn_clean.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clean.Image = Global.SetList.My.Resources.Resources.escoba__2_
        Me.btn_clean.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_clean.Location = New System.Drawing.Point(966, 496)
        Me.btn_clean.Name = "btn_clean"
        Me.btn_clean.Size = New System.Drawing.Size(181, 68)
        Me.btn_clean.TabIndex = 54
        Me.btn_clean.Text = "CLEAN"
        Me.btn_clean.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_clean.UseVisualStyleBackColor = True
        '
        'lst_Countries
        '
        Me.lst_Countries.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_Countries.FormattingEnabled = True
        Me.lst_Countries.ItemHeight = 25
        Me.lst_Countries.Location = New System.Drawing.Point(827, 71)
        Me.lst_Countries.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_Countries.Name = "lst_Countries"
        Me.lst_Countries.Size = New System.Drawing.Size(320, 304)
        Me.lst_Countries.TabIndex = 30
        '
        'cmb_venuesType
        '
        Me.cmb_venuesType.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_venuesType.FormattingEnabled = True
        Me.cmb_venuesType.Items.AddRange(New Object() {"HALL", "PAVILION", "STADIUM", "FESTIVAL"})
        Me.cmb_venuesType.Location = New System.Drawing.Point(467, 227)
        Me.cmb_venuesType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmb_venuesType.Name = "cmb_venuesType"
        Me.cmb_venuesType.Size = New System.Drawing.Size(337, 40)
        Me.cmb_venuesType.TabIndex = 29
        '
        'btn_updateVenue
        '
        Me.btn_updateVenue.Enabled = False
        Me.btn_updateVenue.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_updateVenue.Image = CType(resources.GetObject("btn_updateVenue.Image"), System.Drawing.Image)
        Me.btn_updateVenue.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_updateVenue.Location = New System.Drawing.Point(966, 400)
        Me.btn_updateVenue.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_updateVenue.Name = "btn_updateVenue"
        Me.btn_updateVenue.Size = New System.Drawing.Size(181, 68)
        Me.btn_updateVenue.TabIndex = 28
        Me.btn_updateVenue.Text = "UPDATE"
        Me.btn_updateVenue.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_updateVenue.UseVisualStyleBackColor = True
        '
        'btn_deleteVenue
        '
        Me.btn_deleteVenue.Enabled = False
        Me.btn_deleteVenue.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deleteVenue.Image = CType(resources.GetObject("btn_deleteVenue.Image"), System.Drawing.Image)
        Me.btn_deleteVenue.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_deleteVenue.Location = New System.Drawing.Point(736, 496)
        Me.btn_deleteVenue.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_deleteVenue.Name = "btn_deleteVenue"
        Me.btn_deleteVenue.Size = New System.Drawing.Size(181, 68)
        Me.btn_deleteVenue.TabIndex = 26
        Me.btn_deleteVenue.Text = "DELETE"
        Me.btn_deleteVenue.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_deleteVenue.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(461, 191)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 34)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Type"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(821, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 34)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Country"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(461, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 34)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Name"
        '
        'lst_venues
        '
        Me.lst_venues.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lst_venues.FormattingEnabled = True
        Me.lst_venues.ItemHeight = 25
        Me.lst_venues.Location = New System.Drawing.Point(33, 71)
        Me.lst_venues.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_venues.Name = "lst_venues"
        Me.lst_venues.Size = New System.Drawing.Size(422, 404)
        Me.lst_venues.TabIndex = 20
        '
        'txt_venueName
        '
        Me.txt_venueName.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_venueName.Location = New System.Drawing.Point(467, 98)
        Me.txt_venueName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_venueName.Name = "txt_venueName"
        Me.txt_venueName.Size = New System.Drawing.Size(337, 40)
        Me.txt_venueName.TabIndex = 21
        '
        'btn_insertVenue
        '
        Me.btn_insertVenue.Enabled = False
        Me.btn_insertVenue.Font = New System.Drawing.Font("Verdana", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insertVenue.Image = CType(resources.GetObject("btn_insertVenue.Image"), System.Drawing.Image)
        Me.btn_insertVenue.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_insertVenue.Location = New System.Drawing.Point(736, 400)
        Me.btn_insertVenue.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_insertVenue.Name = "btn_insertVenue"
        Me.btn_insertVenue.Size = New System.Drawing.Size(181, 68)
        Me.btn_insertVenue.TabIndex = 24
        Me.btn_insertVenue.Text = "ADD"
        Me.btn_insertVenue.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_insertVenue.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.SetList.My.Resources.Resources.map__1_
        Me.PictureBox4.Location = New System.Drawing.Point(617, 14)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(95, 73)
        Me.PictureBox4.TabIndex = 28
        Me.PictureBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(711, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 73)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Venues"
        '
        'VenueForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SetList.My.Resources.Resources.Five_Simple_Editing_Tips_That_Will_Make_Your_Photos_Stand_Out
        Me.ClientSize = New System.Drawing.Size(1432, 753)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VenueForm"
        Me.Text = "Venue"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents cmb_venuesType As ComboBox
    Friend WithEvents btn_updateVenue As Button
    Friend WithEvents btn_deleteVenue As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lst_venues As ListBox
    Friend WithEvents txt_venueName As TextBox
    Friend WithEvents btn_insertVenue As Button
    Friend WithEvents lst_Countries As ListBox
    Friend WithEvents btn_clean As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_back As Button
End Class
