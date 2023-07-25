Public Class StatisticsForm
    Private artist As Artist
    Private song As Song
    Private previousArtist As Artist
    Private country As Country
    Private concert As Concert
    Private album As Album
    Private artistCountry As Country
    Public albumArtist As Integer

    Public Function LoadInfo() As Boolean
        Dim aAux As Artist


        Me.artist = New Artist
        Me.country = New Country
        Try
            Me.artist.ReadAllArtists()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End Try

        For Each aAux In Me.artist.artistsDAO.Artists
            Me.lst_artists.Items.Add(aAux.artistName)
            Me.lst_artistsAlbum.Items.Add(aAux.artistName)
        Next

        Return True
    End Function

    Private Sub btn_searchSql1_Click(sender As Object, e As EventArgs) Handles btn_searchSql1.Click
        Dim list As New Collection

        Me.artist = New Artist

        lst_moreSinged.Items.Clear()

        If lst_artists.SelectedItem IsNot Nothing Then
            artist.artistName = lst_artists.SelectedItem.ToString
            artist.ReadArtistByName()

            list = CType(artist.Query1(), Collection)

            For Each songName In list
                lst_moreSinged.Items.Add(songName)
            Next

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Query4.Click
        Dim list As New Collection
        Dim sonAux As New Song
        Me.song = New Song
        Me.album = New Album

        lst_songs.Items.Clear()

        list = CType(song.Query4(), Collection)

        For Each songName In list
            sonAux.songName = songName.ToString
            sonAux.ReadSongByName()
            album.idAlbum = sonAux.songAlbum
            album.ReadAlbum()

            lst_songs.Items.Add("Name: " & sonAux.songName & " Length: " & sonAux.songLength & " Album: " & album.albumName & " Song Order: " & sonAux.songOrder)
        Next

    End Sub

    Private Sub btn_searchSql2_Click(sender As Object, e As EventArgs) Handles btn_searchSql2.Click
        Dim list As New Collection
        Dim albAux As New Album
        Me.artist = New Artist

        lst_albums.Items.Clear()

        If lst_artistsAlbum.SelectedItem IsNot Nothing Then
            artist.artistName = lst_artistsAlbum.SelectedItem.ToString
            artist.ReadArtistByName()

            list = CType(artist.Query2(), Collection)

            For Each albName In list
                lst_albums.Items.Add(albName)
            Next

        End If

    End Sub

    Private Sub btn_Query3_Click(sender As Object, e As EventArgs) Handles btn_Query3.Click
        Dim list As New Collection

        Me.artist = New Artist
        lst_Query3.Items.Clear()

        list = CType(artist.Query3(), Collection)

        For Each artistName In list
            lst_Query3.Items.Add(artistName)
        Next

    End Sub

    Private Sub btn_Query5_Click(sender As Object, e As EventArgs) Handles btn_Query5.Click
        Dim list As New Collection
        Dim startDate As Date : Dim endDate As Date
        Me.artist = New Artist

        lst_artistDates.Items.Clear()

        If txt_StartDate.Value.ToString <> String.Empty And txt_endDate.Value.ToString <> String.Empty Then
            startDate = txt_StartDate.Value.Date
            endDate = txt_endDate.Value.Date

            Try
                If startDate < endDate Then
                    list = CType(artist.Query5(startDate, endDate), Collection)
                    For Each artistName In list
                        lst_artistDates.Items.Add(artistName)
                    Next
                Else
                    Throw New Exception("Invalid date range")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Date error", MessageBoxButtons.OK)
            End Try



        End If
    End Sub

    Private Sub btn_Query6_Click(sender As Object, e As EventArgs) Handles btn_Query6.Click
        Dim list As New Collection
        Dim startDate As Date : Dim endDate As Date
        Me.country = New Country

        lst_countries.Items.Clear()

        If txt_startDateQ6.Value.ToString <> String.Empty And txt_endDateQ6.Value.ToString <> String.Empty Then
            startDate = txt_startDateQ6.Value.Date
            endDate = txt_endDateQ6.Value.Date
            Try
                If startDate < endDate Then
                    list = CType(country.Query6(startDate, endDate), Collection)
                    For Each countryName In list
                        lst_countries.Items.Add(countryName)
                    Next
                Else
                    Throw New Exception("Invalid date range")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Date error", MessageBoxButtons.OK)
            End Try


        End If
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim Form1 As New Main
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class