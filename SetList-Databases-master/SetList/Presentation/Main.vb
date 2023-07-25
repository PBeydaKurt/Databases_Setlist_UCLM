Imports System.Windows
Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports SetList.CountryForm
Imports SetList.ArtistForm
Imports SetList.VenueForm
Imports SetList.SongsForm
Imports SetList.AlbumForm
Imports SetList.ConcertsForm
Imports SetList.StatisticsForm

Public Class Main

    Private Sub btn_openCountries_Click(sender As Object, e As EventArgs) Handles btn_openCountries.Click
        Dim countryForm As New CountryForm
        Dim infoCargada As Boolean = False

        infoCargada = countryForm.LoadInfo()

        If infoCargada Then
            countryForm.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub btn_openArtists_Click(sender As Object, e As EventArgs) Handles btn_openArtists.Click
        Dim artistForm As New ArtistForm
        Dim infoCargada As Boolean = False

        infoCargada = artistForm.LoadInfo()

        If infoCargada Then
            artistForm.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub btn_openVenues_Click(sender As Object, e As EventArgs) Handles btn_openVenues.Click
        Dim venueForm As New VenueForm
        Dim infoCargada As Boolean = False

        infoCargada = venueForm.LoadInfo()

        If infoCargada Then
            venueForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btn_openAlbums_Click(sender As Object, e As EventArgs) Handles btn_openAlbums.Click
        Dim albumForm As New AlbumForm
        Dim infoCargada As Boolean = False

        infoCargada = albumForm.LoadInfo()

        If infoCargada Then
            albumForm.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub btn_openSongs_Click(sender As Object, e As EventArgs) Handles btn_openSongs.Click
        Dim songsForm As New SongsForm
        Dim infoCargada As Boolean = False

        infoCargada = songsForm.LoadInfo()

        If infoCargada Then
            songsForm.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub btn_openConcerts_Click(sender As Object, e As EventArgs) Handles btn_openConcerts.Click
        Dim concertsForm As New ConcertsForm
        Dim infoCargada As Boolean = False

        infoCargada = concertsForm.LoadInfo()

        If infoCargada Then
            concertsForm.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub btn_Statistics_Click(sender As Object, e As EventArgs) Handles btn_Statistics.Click
        Dim statisticsForm As New StatisticsForm
        Dim infoCargada As Boolean = False

        infoCargada = statisticsForm.LoadInfo()

        If infoCargada Then
            statisticsForm.Show()
            Me.Hide()
        End If
    End Sub
End Class
