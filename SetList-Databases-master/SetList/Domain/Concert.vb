Public Class Concert
    Public Property idConcert As Integer
    Public Property concertDate As Date
    Public Property ArtistName As Integer
    Public Property VenueName As Integer
    Public Property SetList As New Collection()

    Public ReadOnly Property cDao As ConcertDAO

    Public Sub New()
        Me.cDao = New ConcertDAO
    End Sub
    Public Sub New(id As Integer)
        Me.cDao = New ConcertDAO
        Me.idConcert = id
    End Sub
    Public Sub New(id As Integer, artist As Integer, venue As Integer, conDate As Date)
        Me.cDao = New ConcertDAO
        idConcert = id
        Me.ArtistName = artist
        Me.VenueName = venue
        concertDate = conDate
    End Sub

    Public Function GetArtist() As Integer
        Return ArtistName
    End Function

    Public Function GetConcert() As Integer
        Return idConcert
    End Function

    Public Function GetDate() As Date
        Return concertDate
    End Function

    Public Function GetVenue() As Integer
        Return VenueName
    End Function

    Public Function SetIdConcert(id As Integer) As Integer
        idConcert = id
    End Function

    Public Function SetDate(conDate As Date) As Date
        concertDate = conDate
    End Function

    Public Function SetArtist(artist As Integer) As Integer
        Me.ArtistName = artist
    End Function

    Public Function SetVenue(venue As Integer) As Integer
        Me.VenueName = venue
    End Function

    Public Function ReadAllConcert() As Object
        Return Me.cDao.ReadAll()
    End Function

    Public Sub ReadSetlist()
        Me.cDao.ReadSetlist(Me)
    End Sub

    Public Sub ReadConcert()
        Me.cDao.Read(Me)
    End Sub

    Public Sub ReadConcertbyArtistAndVenue()
        Me.cDao.ReadByArtistAndVenue(Me)
    End Sub

    Public Sub ReadConcertbyArtistAndVenueAndDate()
        Me.cDao.ReadByArtistAndVenueAndDate(Me)
    End Sub

    Public Function ReadAllArtistsConcerts() As Object
        Return Me.cDao.ReadAllArtistConcerts(Me)
    End Function

    Public Function ReadAllVenueConcerts() As Object
        Return Me.cDao.ReadAllVenueConcerts(Me)
    End Function

    Public Function InsertConcert() As Integer
        Return Me.cDao.Insert(Me)
    End Function

    Public Function InsertConcertSetlist() As Integer
        Return Me.cDao.InsertSetlist(Me)
    End Function

    Public Function DeleteConcert() As Integer
        Return Me.cDao.Delete(Me)
    End Function

    Public Function DeleteConcertSetlist() As Integer
        Return Me.cDao.DeteleSetlist(Me)
    End Function

    Public Function UpdateConcert() As Integer
        Return Me.cDao.Update(Me)
    End Function

End Class
