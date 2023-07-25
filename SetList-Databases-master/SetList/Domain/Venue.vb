Public Class Venue
    Public Property idVenue As Integer
    Public Property venueName As String
    Public Property venueCountry As String
    Public Property venueType As String
    Public vDao As VenueDAO

    Public Sub New()
        Me.vDao = New VenueDAO
    End Sub

    Public Sub New(id As Integer, vName As String, vCountry As String, vType As String)
        Me.vDao = New VenueDAO
        idVenue = id
        venueName = vName
        venueCountry = vCountry
        venueType = vType
    End Sub

    Public Function GetidVenue() As Integer
        Return idVenue
    End Function

    Public Function GetVenueName() As String
        Return venueName
    End Function

    Public Function GetVenueCountry() As String
        Return venueCountry
    End Function

    Public Function GetVenueType() As String
        Return venueType
    End Function

    Public Function SetidVenue(id As Integer) As Integer
        idVenue = id
    End Function

    Public Function SetVenueName(vName As String) As String
        venueName = vName
    End Function

    Public Function SetVenueCountry(vCountry As String) As String
        venueCountry = vCountry
    End Function

    Public Function SetVenueType(vType As String) As String
        venueType = vType
    End Function

    Public Function ReadAllVenues() As Object
        Return Me.vDao.ReadAll()
    End Function

    Public Function ReadAllVenuesCountry(country As Country) As Object
        Return Me.vDao.ReadAllCountryVenues(country)
    End Function

    Public Sub ReadVenue()
        Me.vDao.Read(Me)
    End Sub

    Public Sub ReadVenueByName()
        Me.vDao.ReadByName(Me)
    End Sub

    Public Function InsertVenue() As Integer
        Return Me.vDao.Insert(Me)
    End Function

    Public Function DeleteVenue() As Integer
        Return Me.vDao.Delete(Me)
    End Function

    Public Function UpdateVenue() As Integer
        Return Me.vDao.Update(Me)
    End Function

End Class
