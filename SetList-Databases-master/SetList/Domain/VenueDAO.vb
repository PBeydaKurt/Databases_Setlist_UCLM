Public Class VenueDAO
    Public ReadOnly Property Venues As Collection

    Public Sub New()
        Me.Venues = New Collection
    End Sub

    Public Function ReadAll() As Object
        Dim v As Venue
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM Venues ORDER BY idVenue")
        For Each aux In col
            v = New Venue(Convert.ToInt32(aux(1).ToString), aux(2).ToString, aux(3).ToString, aux(4).ToString)
            Me.Venues.Add(v)
        Next
        Return Venues
    End Function

    Public Sub Read(ByRef v As Venue)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Venues WHERE idVenue='" & v.GetidVenue() & "';")
        For Each aux In col
            v.SetVenueName(aux(2).ToString)
            v.SetVenueCountry(aux(3).ToString)
            v.SetVenueType(aux(4).ToString)
        Next
    End Sub

    Public Sub ReadByName(ByRef v As Venue)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Venues WHERE VenueName='" & v.GetVenueName() & "';")
        For Each aux In col
            v.idVenue = Convert.ToInt32(aux(1).ToString)
            v.SetVenueCountry(aux(3).ToString)
            v.SetVenueType(aux(4).ToString)
        Next
    End Sub

    Public Function ReadAllCountryVenues(ByRef country As Country) As Object
        Dim ve As Venue
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM Venues WHERE VenueCountry='" & country.idCountry & "';")
        For Each aux In col
            ve = New Venue(Convert.ToInt32(aux(1).ToString), aux(2).ToString, aux(3).ToString, aux(4).ToString)
            Me.Venues.Add(ve)
        Next
        Return Venues
    End Function

    Public Function Insert(ByVal v As Venue) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO venues (VenueName, VenueCountry, VenueType) VALUES ('" & v.GetVenueName() & "', (SELECT idCountry FROM Country WHERE idCountry='" & v.GetVenueCountry() & "'), '" & v.GetVenueType() & "');")
    End Function

    Public Function Update(ByVal v As Venue) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Venues SET venueName='" & v.GetVenueName() & "' , venueCountry='" & v.GetVenueCountry() & "' ,venueType='" & v.GetVenueType() & "'WHERE idVenue=" & v.GetidVenue & ";")
    End Function
    Public Function Delete(ByVal v As Venue) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Venues WHERE idVenue='" & v.idVenue & "';")
    End Function
End Class
