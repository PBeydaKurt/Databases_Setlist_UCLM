Public Class AlbumForm

    Private artist As Artist
    Private album As Album
    Private previousAlbum As Album

    Private albumArtist As Integer

    Public Function LoadInfo() As Boolean
        Dim albAux As Album
        Dim aAux As Artist

        Me.artist = New Artist
        Me.album = New Album
        Try
            Me.album.ReadAllAlbums()
            Me.artist.ReadAllArtists()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End Try

        For Each albAux In Me.album.albDAO.Albums
            Me.lst_albums.Items.Add(albAux.albumName)
        Next
        For Each aAux In Me.artist.artistsDAO.Artists
            Me.lst_artists.Items.Add(aAux.artistName)
        Next

        btn_insertAlbum.Enabled = True
        Return True
    End Function

    Private Sub lst_albums_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_albums.SelectedIndexChanged
        btn_deleteAlbum.Enabled = True
        btn_updateAlbum.Enabled = True

        If lst_albums.SelectedItem IsNot Nothing Then
            Try
                Me.album = New Album
                album.albumName = lst_albums.SelectedItem.ToString
                album.ReadAlbumByName()
                txt_albumName.Text = album.albumName
                txt_albumYear.Text = album.albumYear.ToString()
                Me.artist = New Artist
                artist.IdArtist = album.albumArtist
                artist.ReadArtist()

                For Each artista As String In lst_artists.Items
                    If artista.Contains(artist.artistName) Then
                        lst_artists.SelectedItem = artista
                        Exit For
                    End If
                Next

                Me.previousAlbum = New Album
                previousAlbum.albumName = txt_albumName.Text
                previousAlbum.ReadAlbumByName()

            Catch ex As Exception
                lst_albums.SelectedIndex = -1
            End Try
        End If
    End Sub

    Private Sub btn_insertAlbum_Click(sender As Object, e As EventArgs) Handles btn_insertAlbum.Click
        Dim albumNew As Album
        If txt_albumName.Text <> String.Empty And txt_albumYear.Text <> String.Empty And lst_artists.SelectedIndex <> -1 Then
            albumNew = New Album
            albumNew.albumName = txt_albumName.Text
            albumNew.albumYear = Convert.ToInt32(txt_albumYear.Text)
            Me.artist = New Artist
            artist.artistName = lst_artists.SelectedItem.ToString
            artist.ReadArtistByName()
            albumNew.albumArtist = artist.GetIdArtist()

            Try
                If albumNew.InsertAlbum() <> 1 Then
                    MessageBox.Show("INSERT <> 1", "CUSTOM ERROR", MessageBoxButtons.OK)
                Else
                    If albumNew.GetAlbumName <> album.GetAlbumName Then
                        lst_albums.Items.Add(albumNew.GetAlbumName)
                        txt_albumName.Clear()
                        txt_albumYear.Clear()
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try

        Else
            MessageBox.Show("Name, year or artist are empty please fill those spaces", "Custom Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btn_updateAlbum_Click(sender As Object, e As EventArgs) Handles btn_updateAlbum.Click
        Me.album = New Album
        Dim UpdateAlbum = New Album
        Dim albAux As Album

        If MessageBox.Show("Are you sure? Do you want to update this album?", "Custom Error", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If

        Try
            UpdateAlbum.albumName = txt_albumName.Text
            UpdateAlbum.albumYear = Convert.ToInt32(txt_albumYear.Text)
            Me.artist = New Artist
            artist.artistName = lst_artists.SelectedItem.ToString
            artist.ReadArtistByName()
            UpdateAlbum.albumArtist = artist.IdArtist
            UpdateAlbum.idAlbum = previousAlbum.GetIdAlbum()


            If txt_albumName.Text <> String.Empty And txt_albumYear.Text <> String.Empty And lst_artists.SelectedIndex <> -1 Then
                Try
                    If UpdateAlbum.UpdateAlbum() <> 1 Then
                        MessageBox.Show("UPDATE <> 1", "CUSTOM ERROR", MessageBoxButtons.OK)
                    Else
                        lst_albums.Items.Clear()
                        album.ReadAllAlbums()
                        For Each albAux In Me.album.albDAO.Albums
                            Me.lst_albums.Items.Add(albAux.albumName)
                        Next
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

    Private Sub btn_deleteAlbum_Click(sender As Object, e As EventArgs) Handles btn_deleteAlbum.Click

        Me.artist = New Artist
        Me.album = New Album
        If MessageBox.Show("Are you sure? Do you want to delete permanetly this album?", "Custom Error", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If

        If txt_albumName.Text <> String.Empty And txt_albumYear.Text <> String.Empty And lst_artists.SelectedIndex <> -1 Then

            album.albumName = lst_albums.SelectedItem.ToString
            album.ReadAlbumByName()
            artist.artistName = lst_artists.SelectedItem.ToString
            artist.ReadArtistByName()

            If album.albumName <> txt_albumName.Text.Trim() Or artist.IdArtist <> album.albumArtist Or album.albumYear <> Convert.ToInt32(txt_albumYear.Text) Then
                MessageBox.Show("This is not the same album that you have selected in the album list, please check the data", "Custom Error", MessageBoxButtons.OK)
                Exit Sub
            End If
            Try
                If album.DeleteAlbum() <> 1 Then
                    MessageBox.Show("INSERT <> 1", "Custom Error", MessageBoxButtons.OK)
                Else
                    Me.lst_albums.Items.Remove(album.albumName)
                    txt_albumName.Clear()
                    txt_albumYear.Clear()
                    MsgBox("Album Deleted")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try

        Else
            MessageBox.Show("Unable to delete information, all needed fields must be filled", "Custom Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btn_clean_Click(sender As Object, e As EventArgs) Handles btn_clean.Click
        txt_albumName.Clear()
        txt_albumYear.Clear()
        lst_albums.ClearSelected()
        lst_artists.ClearSelected()

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim Form1 As New Main
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub txt_albumYear_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txt_albumYear.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class