Public Class ConcertsForm

    Private artist As Artist
    Private Venue As Venue
    Private concert As Concert
    Private previousConcert As Concert
    Private song As Song
    Private album As Album


    Public Function LoadInfo() As Boolean
        Dim coAux As Concert
        Dim aAux As Artist
        Dim vAux As Venue

        Me.artist = New Artist
        Me.Venue = New Venue
        Me.concert = New Concert

        Try
            Me.artist.ReadAllArtists()
            Me.Venue.ReadAllVenues()
            Me.concert.ReadAllConcert()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End Try

        For Each aAux In Me.artist.artistsDAO.Artists
            Me.lst_artists.Items.Add(aAux.artistName)
        Next
        For Each vAux In Me.Venue.vDao.Venues
            Me.lst_venues.Items.Add(vAux.venueName)
        Next
        For Each coAux In Me.concert.cDao.Concerts
            Me.artist = New Artist
            Me.Venue = New Venue
            artist.IdArtist = coAux.ArtistName
            artist.ReadArtist()
            Venue.idVenue = coAux.VenueName
            Venue.ReadVenue()
            Me.lst_concerts.Items.Add(coAux.idConcert & "-" & artist.artistName & "-" & Venue.venueName)
        Next

        btn_insertConcert.Enabled = True
        Return True
    End Function

    Private Sub lst_concerts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_concerts.SelectedIndexChanged
        Dim data As String : Dim separatedData() As String

        btn_updateConcert.Enabled = True
        btn_deleteConcert.Enabled = True
        lst_concertSetlist.Items.Clear()

        If lst_concerts.SelectedItem IsNot Nothing Then
            Me.concert = New Concert
            Me.artist = New Artist
            Me.Venue = New Venue
            Me.song = New Song

            data = lst_concerts.SelectedItem.ToString()
            separatedData = data.Split("-"c)
            concert.idConcert = Convert.ToInt32(separatedData(0))
            artist.artistName = separatedData(1)
            artist.ReadArtistByName()
            Venue.venueName = separatedData(2)
            Venue.ReadVenueByName()
            concert.ArtistName = artist.IdArtist
            concert.VenueName = Venue.idVenue
            concert.ReadConcert()
            txt_dateConcert.Value = concert.GetDate()



            For Each artista As String In lst_artists.Items
                If artista.Contains(artist.artistName) Then
                    lst_artists.SelectedItem = artista
                    Exit For
                End If
            Next

            For Each concertVenue As String In lst_venues.Items
                If concertVenue.Contains(Venue.venueName) Then
                    lst_venues.SelectedItem = concertVenue
                    Exit For
                End If
            Next

            concert.ReadSetlist()
            For Each setlistSong As Integer In concert.SetList
                song.idSong = setlistSong
                song.ReadSong()
                lst_concertSetlist.Items.Add(song.songName)
            Next


            Me.previousConcert = New Concert
            data = lst_concerts.SelectedItem.ToString()
            separatedData = data.Split("-"c)
            previousConcert.idConcert = Convert.ToInt32(separatedData(0))
            artist.artistName = separatedData(1)
            artist.ReadArtistByName()
            Venue.venueName = separatedData(2)
            Venue.ReadVenueByName()
            previousConcert.ArtistName = artist.IdArtist
            previousConcert.VenueName = Venue.idVenue
            previousConcert.ReadConcert()

        End If
    End Sub

    Private Sub lst_songs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_songs.SelectedIndexChanged
        btn_addSong.Enabled = True
        btn_removeSong.Enabled = False
    End Sub

    Private Sub lst_concertSetlist_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_concertSetlist.SelectedIndexChanged
        btn_removeSong.Enabled = True
    End Sub

    Private Sub lst_artists_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_artists.SelectedIndexChanged
        Dim albAux As Album
        Dim sonAux As Song

        Me.artist = New Artist
        Me.album = New Album
        Me.song = New Song
        If lst_artists.SelectedIndex <> -1 Then
            btn_addSong.Enabled = False
            lst_concertSetlist.Items.Clear()
            lst_songs.Items.Clear()
            artist.artistName = lst_artists.SelectedItem.ToString
            artist.ReadArtistByName()

            Try
                album.albumArtist = artist.IdArtist
                album.ReadAllAlbumsArtist()

                For Each albAux In Me.album.albDAO.Albums
                    song.songAlbum = albAux.idAlbum
                    song.ReadAllAlbumSongs()
                    For Each sonAux In Me.song.sonDAO.Songs
                        song.songName = sonAux.songName
                        Me.lst_songs.Items.Add(song.songName)
                    Next
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            EliminateDuplicateSongs(Me.lst_songs)
        End If

    End Sub

    Public Sub EliminateDuplicateSongs(ByRef listbox As ListBox)
        Dim items As New List(Of String)
        For Each item As String In listbox.Items
            items.Add(item)
        Next

        For i As Integer = items.Count - 1 To 0 Step -1
            If listbox.Items.IndexOf(items(i)) <> i Then
                listbox.Items.RemoveAt(i)
            End If
        Next
    End Sub

    Private Sub btn_insertConcert_Click(sender As Object, e As EventArgs) Handles btn_insertConcert.Click
        Dim concertNew As Concert
        Me.artist = New Artist
        Me.Venue = New Venue
        Me.song = New Song

        If lst_artists.SelectedIndex <> -1 And lst_venues.SelectedIndex <> -1 And txt_dateConcert.Value.ToString <> String.Empty And lst_concertSetlist.Items.Count > 0 Then
            concertNew = New Concert
            artist.artistName = lst_artists.SelectedItem.ToString
            artist.ReadArtistByName()
            concertNew.ArtistName = artist.IdArtist
            Venue.venueName = lst_venues.SelectedItem.ToString
            Venue.ReadVenueByName()
            concertNew.VenueName = Venue.idVenue
            concertNew.concertDate = txt_dateConcert.Value.Date

            For Each cancion As String In lst_concertSetlist.Items
                song.songName = cancion
                song.ReadSongByName()
                concertNew.SetList.Add(song.idSong)
            Next

            Try
                If concertNew.InsertConcert() <> 1 Then
                    MessageBox.Show("INSERT <> -1", "CUSTOM ERROR", MessageBoxButtons.OK)
                Else
                    concertNew.ReadConcertbyArtistAndVenue()
                    concertNew.InsertConcertSetlist()
                    lst_concerts.Items.Add(concertNew.idConcert & "-" & artist.artistName & "-" & Venue.venueName)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        Else
            MessageBox.Show("Artist, Venue or Setlist is not selected or fulfilled, please fill those spaces", "Custom Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btn_updateConcert_Click(sender As Object, e As EventArgs) Handles btn_updateConcert.Click
        Me.concert = New Concert
        Dim UpdateConcert As New Concert : Dim coAux As Concert
        Me.artist = New Artist
        Me.Venue = New Venue
        Me.song = New Song

        If MessageBox.Show("Are you sure? Do you want to update this concert?", "Custom Error", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If

        Try
            UpdateConcert = New Concert
            UpdateConcert.concertDate = txt_dateConcert.Value.Date
            artist.artistName = lst_artists.SelectedItem.ToString
            artist.ReadArtistByName()
            UpdateConcert.ArtistName = artist.IdArtist
            Venue.venueName = lst_venues.SelectedItem.ToString
            Venue.ReadVenueByName()
            UpdateConcert.VenueName = Venue.idVenue
            UpdateConcert.idConcert = previousConcert.idConcert

            If lst_artists.SelectedIndex <> -1 And lst_venues.SelectedIndex <> -1 And txt_dateConcert.Value.ToString <> String.Empty And lst_concertSetlist.Items.Count > 0 Then
                Try
                    If UpdateConcert.UpdateConcert() <> 1 Then
                        MessageBox.Show("UPDATE <> -1", "CUSTOM ERROR", MessageBoxButtons.OK)
                    Else
                        lst_concerts.Items.Clear()
                        concert.ReadAllConcert()
                        For Each coAux In Me.concert.cDao.Concerts
                            Me.artist = New Artist
                            Me.Venue = New Venue
                            artist.IdArtist = coAux.ArtistName
                            artist.ReadArtist()
                            Venue.idVenue = coAux.VenueName
                            Venue.ReadVenue()
                            Me.lst_concerts.Items.Add(coAux.idConcert & "-" & artist.artistName & "-" & Venue.venueName)
                        Next

                        UpdateConcert.DeleteConcertSetlist()
                        For Each cancion As String In lst_concertSetlist.Items
                            song.songName = cancion
                            song.ReadSongByName()
                            UpdateConcert.SetList.Add(song.idSong)
                        Next
                        UpdateConcert.InsertConcertSetlist()
                        UpdateConcert.ReadSetlist()
                        lst_concertSetlist.Items.Clear()

                        For Each setlistSong As Integer In UpdateConcert.SetList
                            song.idSong = setlistSong
                            song.ReadSong()
                            lst_concertSetlist.Items.Add(song.songName)
                        Next
                        EliminateDuplicateSongs(Me.lst_concertSetlist)
                        MsgBox("Album Update Succesfully")
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try

            Else
                MessageBox.Show("Unable to update information, all needed fields must be filled", "Custom Error", MessageBoxButtons.OK)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_deleteConcert_Click(sender As Object, e As EventArgs) Handles btn_deleteConcert.Click
        Dim data As String : Dim separatedData() As String
        Dim setlistInBox As New Collection
        Dim correctSetlist As New Boolean

        Me.concert = New Concert
        Me.artist = New Artist
        Me.Venue = New Venue
        Me.song = New Song

        If MessageBox.Show("Are you sure? Do you want to delete permanetly this concert?", "Custom Error", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If

        If lst_artists.SelectedIndex <> -1 And lst_venues.SelectedIndex <> -1 And txt_dateConcert.Value.ToString <> String.Empty And lst_concertSetlist.Items.Count > 0 Then
            data = lst_concerts.SelectedItem.ToString()
            separatedData = data.Split("-"c)
            concert.idConcert = Convert.ToInt32(separatedData(0))
            artist.artistName = separatedData(1)
            artist.ReadArtistByName()
            Venue.venueName = separatedData(2)
            Venue.ReadVenueByName()
            concert.ArtistName = artist.IdArtist
            concert.VenueName = Venue.idVenue
            concert.ReadConcert()
            txt_dateConcert.Value = concert.GetDate()
            concert.ReadSetlist()

            For Each cancion As String In lst_concertSetlist.Items
                song.songName = cancion
                song.ReadSongByName()
                setlistInBox.Add(song.idSong)
            Next

            If artist.artistName <> lst_artists.SelectedItem.ToString Or Venue.venueName <> lst_venues.SelectedItem.ToString Or concert.GetDate <> txt_dateConcert.Value Or Not concert.SetList.Cast(Of Integer)().SequenceEqual(setlistInBox.Cast(Of Integer)()) Then
                MessageBox.Show("This is not the same concert you have selected in the setlist list, please check the data", "Custom Error", MessageBoxButtons.OK)
                Exit Sub
            End If

            concert.DeleteConcertSetlist()
            lst_concertSetlist.Items.Clear()

            If artist.artistName <> lst_artists.SelectedItem.ToString And Venue.venueName <> lst_venues.SelectedItem.ToString Then
                MessageBox.Show("This is not the same concert", "Custom Error", MessageBoxButtons.OK)
                Exit Sub
            End If
            Try
                If concert.DeleteConcert() <> 1 Then
                    MessageBox.Show("INSERT <> -1", "Custom Error", MessageBoxButtons.OK)
                Else
                    Me.lst_concerts.Items.Remove(concert.idConcert & "-" & artist.artistName & "-" & Venue.venueName)
                    MessageBox.Show("Album Deleted")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try

        Else
            MessageBox.Show("Unable to delete information, all needed fields must be filled", "Custom Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btn_addSong_Click(sender As Object, e As EventArgs) Handles btn_addSong.Click

        If Not lst_concertSetlist.Items.Contains(lst_songs.SelectedItem.ToString) Then
            lst_concertSetlist.Items.Add(lst_songs.SelectedItem.ToString)
        Else
            MsgBox("This song is already on the list")
        End If

    End Sub

    Private Sub btn_removeSong_Click(sender As Object, e As EventArgs) Handles btn_removeSong.Click
        lst_concertSetlist.Items.Remove(lst_concertSetlist.SelectedItem.ToString)
    End Sub

    Private Sub btn_orderBy_Click(sender As Object, e As EventArgs) Handles btn_orderBy.Click
        Dim OrderByForm As New OrderByForm() 'Crea una nueva instancia del formulario 2
        Dim infoCargada As Boolean = False

        infoCargada = OrderByForm.LoadInfo()

        If infoCargada Then
            OrderByForm.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim Form1 As New Main
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btn_clean_Click(sender As Object, e As EventArgs) Handles btn_clean.Click

        lst_concerts.ClearSelected()
        lst_songs.Items.Clear()
        lst_artists.ClearSelected()

        lst_venues.ClearSelected()
    End Sub
End Class