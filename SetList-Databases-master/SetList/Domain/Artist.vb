Public Class Artist
    Public Property IdArtist As Integer
    Public Property artistName As String
    Public Property artistCountry As String
    Public ReadOnly Property artistsDAO As ArtistDAO

    Public Sub New()
        Me.artistsDAO = New ArtistDAO
    End Sub
    Public Sub New(id As Integer)
        Me.artistsDAO = New ArtistDAO
        Me.IdArtist = id
    End Sub
    Public Sub New(id As Integer, name As String, country As String)
        Me.artistsDAO = New ArtistDAO
        Me.IdArtist = id
        Me.artistName = name
        Me.artistCountry = country
    End Sub

    Public Sub ReadArtist()
        Me.artistsDAO.Read(Me)
    End Sub

    Public Sub ReadArtistByName()
        Me.artistsDAO.ReadByName(Me)
    End Sub

    Public Function GetIdArtist() As Integer
        Return IdArtist
    End Function

    Public Function GetCountry() As String
        Return artistCountry
    End Function
    Public Function GetName() As String
        Return artistName
    End Function

    Public Function SetIdArtist(idArtsit As Integer) As Integer
        IdArtist = idArtsit
        Return idArtsit
    End Function
    Public Function SetName(name As String) As String
        artistName = name
    End Function

    Public Function SetCountry(country As String) As String
        Me.artistCountry = country
    End Function

    Public Sub ReadAllArtists()
        Me.artistsDAO.ReadAll()
    End Sub
    Public Sub ReadAll()
        Me.artistsDAO.Read(Me)
    End Sub
    Public Function InsertArtist() As Integer
        Return Me.artistsDAO.Insert(Me)
    End Function

    Public Function UpdateArtist() As Integer
        Return Me.artistsDAO.Update(Me)
    End Function

    Public Function DeleteArtist() As Integer
        Return Me.artistsDAO.Delete(Me)
    End Function

    Public Function Query1() As Object
        Return Me.artistsDAO.Query1(Me)
    End Function

    Public Function Query2() As Object
        Return Me.artistsDAO.Query2(Me)
    End Function

    Public Function Query3() As Object
        Return Me.artistsDAO.Query3()
    End Function

    Public Function Query5(startDate As Date, endDate As Date) As Object
        Return Me.artistsDAO.Query5(startDate, endDate)
    End Function

End Class
