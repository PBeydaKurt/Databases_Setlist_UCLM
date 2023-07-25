Public Class ArtistForm

    Private artist As Artist
    Private previousArtist As Artist
    Private country As Country
    Private artistCountry As Country
    Public albumArtist As Integer

    Public Function LoadInfo() As Boolean
        Dim aAux As Artist
        Dim couAux As Country

        Me.artist = New Artist
        Me.country = New Country
        Try
            Me.artist.ReadAllArtists()
            Me.country.ReadAllCountries()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End Try

        For Each aAux In Me.artist.artistsDAO.Artists
            Me.lst_artists.Items.Add(aAux.artistName)
        Next
        For Each couAux In Me.country.counDAO.Countries
            Me.lst_Countries.Items.Add(couAux.countryName)
        Next

        btn_insertArtist.Enabled = True
        Return True
    End Function

    Private Sub lst_artists_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_artists.SelectedIndexChanged
        btn_deleteArtist.Enabled = True
        btn_updateArtist.Enabled = True

        If lst_artists.SelectedItem IsNot Nothing Then
            Try
                Me.artist = New Artist
                artist.artistName = lst_artists.SelectedItem.ToString
                artist.ReadArtistByName()
                albumArtist = artist.IdArtist
                txt_artistName.Text = artist.artistName
                Me.artistCountry = New Country
                artistCountry.idCountry = artist.artistCountry
                artistCountry.ReadCountry()
                Me.previousArtist = New Artist
                previousArtist.artistName = txt_artistName.Text
                previousArtist.ReadArtistByName()

                For Each pais As String In lst_Countries.Items
                    If pais.Contains(artistCountry.countryName) Then
                        lst_Countries.SelectedItem = pais
                        Exit For
                    End If
                Next

            Catch ex As Exception
                lst_artists.SelectedIndex = -1
            End Try
        End If
    End Sub

    Private Sub btn_insertArtist_Click(sender As Object, e As EventArgs) Handles btn_insertArtist.Click
        Dim artistNew As Artist
        If txt_artistName.Text <> String.Empty And lst_Countries.SelectedIndex <> -1 Then
            artistNew = New Artist
            artistNew.artistName = txt_artistName.Text
            artistNew.artistCountry = lst_Countries.SelectedItem.ToString.Substring(0, 3)

            Try
                If artistNew.InsertArtist() <> 1 Then
                    MessageBox.Show("INSERT <> 1", "CUSTOM ERROR", MessageBoxButtons.OK)
                Else
                    lst_artists.Items.Add(artistNew.GetName)
                    txt_artistName.Clear()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try

        Else
            MessageBox.Show("Id and Name were empty, please fill those spaces", "Custom Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btn_updateArtist_Click(sender As Object, e As EventArgs) Handles btn_updateArtist.Click
        Me.artist = New Artist
        Dim UpdateArtist = New Artist
        Dim aAux As Artist

        If MessageBox.Show("Are you sure? Do you want to update this country?", "Custom Error", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If

        Try
            UpdateArtist.artistName = txt_artistName.Text
            UpdateArtist.artistCountry = lst_Countries.SelectedItem.ToString.Substring(0, 3)
            UpdateArtist.IdArtist = previousArtist.GetIdArtist()

            If txt_artistName.Text <> String.Empty And lst_Countries.SelectedIndex <> -1 Then
                Try
                    If UpdateArtist.UpdateArtist() <> 1 Then
                        MessageBox.Show("UPDATE <> 1", "Custom Error", MessageBoxButtons.OK)
                    Else
                        lst_artists.Items.Clear()
                        artist.ReadAllArtists()
                        For Each aAux In Me.artist.artistsDAO.Artists
                            Me.lst_artists.Items.Add(aAux.artistName)
                        Next
                        MsgBox("Artist Update Succesfully")
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

    Private Sub btn_deleteArtist_Click(sender As Object, e As EventArgs) Handles btn_deleteArtist.Click

        If MessageBox.Show("Are you sure? Do you want to delete permanetly this artist?", "Custom Error", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If

        If txt_artistName.Text <> String.Empty And lst_Countries.SelectedIndex <> -1 Then
            Me.artist = New Artist
            Me.country = New Country
            artist.artistName = lst_artists.SelectedItem.ToString
            artist.ReadArtistByName()
            country.idCountry = artist.artistCountry
            country.ReadCountry()

            If artist.artistName <> txt_artistName.Text.Trim() Or country.countryName <> lst_Countries.SelectedItem.ToString Then
                MessageBox.Show("This is not the same artist that you have selected in the artist list, please check the data", "Custom Error", MessageBoxButtons.OK)
                Exit Sub
            End If
            Try
                If artist.DeleteArtist() <> 1 Then
                    MessageBox.Show("INSERT <> 1", "Custom Error", MessageBoxButtons.OK)
                Else
                    Me.lst_artists.Items.Remove(artist.artistName)
                    txt_artistName.Clear()
                    MessageBox.Show("Artist Deleted")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try

        Else
            MessageBox.Show("Unable to delete information, all needed fields must be filled", "Custom Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btn_clean_Click(sender As Object, e As EventArgs) Handles btn_clean.Click
        txt_artistName.Clear()
        lst_artists.ClearSelected()
        lst_Countries.ClearSelected()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim Form1 As New Main
        Form1.Show()
        Me.Hide()
    End Sub
End Class