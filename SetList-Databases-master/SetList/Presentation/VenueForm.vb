Public Class VenueForm

    Private Venue As Venue
    Private previousVenue As Venue
    Private country As Country
    Private venueCountry As Country

    Public idVenue As Integer

    Public Function LoadInfo() As Boolean
        Dim vAux As Venue
        Dim couAux As Country

        Me.Venue = New Venue
        Me.country = New Country
        Try
            Me.Venue.ReadAllVenues()
            Me.country.ReadAllCountries()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End Try

        For Each vAux In Me.Venue.vDao.Venues
            Me.lst_venues.Items.Add(vAux.venueName)
        Next
        For Each couAux In Me.country.counDAO.Countries
            Me.lst_Countries.Items.Add(couAux.countryName)
        Next

        btn_insertVenue.Enabled = True
        Return True
    End Function

    Private Sub lst_venues_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_venues.SelectedIndexChanged
        btn_deleteVenue.Enabled = True
        btn_updateVenue.Enabled = True

        If lst_venues.SelectedItem IsNot Nothing Then
            Try
                Me.Venue = New Venue
                Venue.venueName = lst_venues.SelectedItem.ToString
                Venue.ReadVenueByName()
                idVenue = Venue.idVenue
                txt_venueName.Text = Venue.venueName
                Me.venueCountry = New Country
                venueCountry.idCountry = Venue.venueCountry
                venueCountry.ReadCountry()

                For Each pais As String In lst_Countries.Items
                    If pais.Contains(venueCountry.countryName) Then
                        lst_Countries.SelectedItem = pais
                        Exit For
                    End If
                Next

                cmb_venuesType.Text = Venue.GetVenueType()
                Me.previousVenue = New Venue
                previousVenue.venueName = txt_venueName.Text
                previousVenue.ReadVenueByName()

            Catch ex As Exception
                lst_venues.SelectedIndex = -1
            End Try
        End If
    End Sub


    Private Sub btn_venueInsertar_Click(sender As Object, e As EventArgs) Handles btn_insertVenue.Click
        Dim venueNew As Venue
        If txt_venueName.Text <> String.Empty And cmb_venuesType.SelectedItem IsNot Nothing And lst_Countries.SelectedIndex <> -1 Then
            venueNew = New Venue
            venueNew.venueName = txt_venueName.Text
            venueNew.venueCountry = lst_Countries.SelectedItem.ToString.Substring(0, 3)
            venueNew.venueType = cmb_venuesType.SelectedItem.ToString

            Try
                If venueNew.InsertVenue() <> 1 Then
                    MessageBox.Show("INSERT <> 1", "CUSTOM ERROR", MessageBoxButtons.OK)
                Else
                    lst_venues.Items.Add(venueNew.GetVenueName)
                    txt_venueName.Clear()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try

        Else
            MessageBox.Show("Name, country or type are empty please fill those spaces", "Custom Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btn_updateVenue_Click(sender As Object, e As EventArgs) Handles btn_updateVenue.Click
        Me.Venue = New Venue
        Dim UpdateVenue = New Venue : Dim countryNameNew As String : Dim vAux As Venue

        If MessageBox.Show("Are you sure? Do you want to update this venue?", "Custom Error", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If

        If txt_venueName.Text <> String.Empty And cmb_venuesType.SelectedItem IsNot Nothing And lst_Countries.SelectedIndex <> -1 Then
            Try
                UpdateVenue.venueName = txt_venueName.Text
                UpdateVenue.venueCountry = lst_Countries.SelectedItem.ToString.Substring(0, 3)
                UpdateVenue.venueType = cmb_venuesType.SelectedItem.ToString
                UpdateVenue.idVenue = previousVenue.GetidVenue()

                If txt_venueName.Text <> String.Empty Then
                    Try
                        If UpdateVenue.UpdateVenue() <> 1 Then

                        Else
                            lst_venues.Items.Clear()
                            Venue.ReadAllVenues()
                            For Each vAux In Me.Venue.vDao.Venues
                                Me.lst_venues.Items.Add(vAux.venueName)
                            Next
                            MsgBox("Venue Update Succesfully")
                        End If

                    Catch ex As Exception
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End Try

                Else
                    MessageBox.Show("Unable to update information, all needed fields must be filled", "Custom Error", MessageBoxButtons.OK)
                End If
            Catch ex As Exception

            End Try
        Else
            MessageBox.Show("Name, country or type are empty please fill those spaces", "Custom Error", MessageBoxButtons.OK)
        End If



    End Sub

    Private Sub btn_deleteVenue_Click(sender As Object, e As EventArgs) Handles btn_deleteVenue.Click
        Me.Venue = New Venue
        Me.country = New Country

        If MessageBox.Show("Are you sure? Do you want to delete permanetly this country?", "Custom Error", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If

        If txt_venueName.Text <> String.Empty And cmb_venuesType.SelectedItem IsNot Nothing And lst_Countries.SelectedIndex <> -1 Then

            Venue.venueName = lst_venues.SelectedItem.ToString
            Venue.ReadVenueByName()
            country.idCountry = Venue.venueCountry
            country.ReadCountry()

            If Venue.venueName <> txt_venueName.Text.Trim() Or country.countryName <> lst_Countries.SelectedItem.ToString Or Not Venue.venueType.Equals(cmb_venuesType.SelectedItem.ToString, StringComparison.OrdinalIgnoreCase) Then
                MessageBox.Show("This is not the same venue you have selected, please check the data", "Custom Error", MessageBoxButtons.OK)
                Exit Sub
            End If
            Try
                If Venue.DeleteVenue() <> 1 Then
                    MessageBox.Show("DELETE <> 1", "Custom Error", MessageBoxButtons.OK)
                Else
                    Me.lst_venues.Items.Remove(Venue.venueName)
                    txt_venueName.Clear()
                    MsgBox("Venue Deleted")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try

        Else
            MessageBox.Show("Unable to delete information, all needed fields must be filled", "Custom Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btn_clean_Click(sender As Object, e As EventArgs) Handles btn_clean.Click
        txt_venueName.Clear()
        lst_Countries.ClearSelected()
        lst_venues.ClearSelected()
        cmb_venuesType.SelectedItem = Nothing
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Dim Form1 As New Main
        Form1.Show()
        Me.Hide()
    End Sub
End Class