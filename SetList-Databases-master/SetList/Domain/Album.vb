Public Class Album
    Public ReadOnly Property albDAO As AlbumDAO
    Public Property idAlbum As Integer
    Public Property albumName As String
    Public Property albumYear As Integer
    Public Property albumArtist As Integer
    Public Sub New()
        Me.albDAO = New AlbumDAO
    End Sub
    Public Sub New(idAlb As Integer)
        Me.albDAO = New AlbumDAO
        Me.idAlbum = idAlb
    End Sub
    Public Sub New(idAlb As Integer, albName As String, albYear As Integer, albArtist As Integer)
        Me.albDAO = New AlbumDAO
        idAlbum = idAlb
        albumName = albName
        albumYear = albYear
        albumArtist = albArtist
    End Sub
    Public Function GetIdAlbum() As Integer
        Return idAlbum
    End Function

    Public Function GetAlbumName() As String
        Return albumName
    End Function
    Public Function GetAlbumYear() As Integer
        Return albumYear
    End Function

    Public Function GetAlbumArtist() As Integer
        Return albumArtist
    End Function

    Public Function SetIdAlbum(idAlb As Integer) As Integer
        idAlbum = idAlb
    End Function

    Public Function SetAlbumName(albName As String) As String
        albumName = albName
    End Function
    Public Function SetAlbumYear(albYear As Integer) As Integer
        albumYear = albYear
    End Function

    Public Function SetAlbumArtist(albArtist As Integer) As Integer
        albumArtist = albArtist
    End Function

    Public Function ReadAllAlbums() As Object
        Return Me.albDAO.ReadAll()
    End Function

    Public Function ReadAllAlbumsArtist() As Object
        Return Me.albDAO.ReadAllArtistAlbums(Me)
    End Function

    Public Sub ReadAlbum()
        Me.albDAO.Read(Me)
    End Sub

    Public Sub ReadAlbumByName()
        Me.albDAO.ReadByName(Me)
    End Sub

    Public Function InsertAlbum() As Integer
        Return Me.albDAO.Insert(Me)
    End Function

    Public Function UpdateAlbum() As Integer
        Return Me.albDAO.Update(Me)
    End Function
    Public Function DeleteAlbum() As Integer
        Return Me.albDAO.Delete(Me)
    End Function
End Class