Public Class AlbumDAO
    Public ReadOnly Property Albums As Collection

    Public Sub New()
        Me.Albums = New Collection
    End Sub

    Public Function ReadAll() As Object
        Dim ar As Album
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM Albums ORDER BY idAlbum")
        For Each aux In col
            ar = New Album(Convert.ToInt32(aux(1).ToString))
            ar.SetAlbumName(aux(2).ToString)
            ar.albumYear = Convert.ToInt32(aux(3).ToString)
            ar.albumArtist = Convert.ToInt32(aux(1).ToString)
            Me.Albums.Add(ar)
        Next
        Return Albums
    End Function

    Public Function ReadAllArtistAlbums(ByRef album As Album) As Object
        Dim ar As Album
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM albums WHERE Artist=" & album.albumArtist & ";")
        For Each aux In col
            ar = New Album(Convert.ToInt32(aux(1).ToString))
            ar.SetAlbumName(aux(2).ToString)
            ar.albumYear = Convert.ToInt32(aux(3).ToString)
            ar.albumArtist = Convert.ToInt32(aux(1).ToString)
            Me.Albums.Add(ar)
        Next
        Return Albums
    End Function

    Public Sub Read(ByRef ar As Album)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Albums WHERE idAlbum=" & ar.GetIdAlbum() & ";")
        For Each aux In col
            ar.SetAlbumName(aux(2).ToString)
            ar.albumYear = Convert.ToInt32(aux(3).ToString)
            ar.albumArtist = Convert.ToInt32(aux(4).ToString)
        Next
    End Sub

    Public Sub ReadByName(ByRef ar As Album)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Albums WHERE AlbumName='" & ar.GetAlbumName() & "';")
        For Each aux In col
            ar.idAlbum = Convert.ToInt32(aux(1).ToString)
            ar.SetAlbumName(aux(2).ToString)
            ar.albumYear = Convert.ToInt32(aux(3).ToString)
            ar.albumArtist = Convert.ToInt32(aux(4).ToString)
        Next
    End Sub

    Public Function Insert(ByVal ar As Album) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Albums (AlbumName, YearAlbum, Artist) VALUES ('" & ar.GetAlbumName() & "' ," & ar.GetAlbumYear() & "," & ar.GetAlbumArtist() & ");")
    End Function

    Public Function Update(ByVal ar As Album) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Albums SET AlbumName='" & ar.GetAlbumName() & "', YearAlbum=" & ar.GetAlbumYear() & ", Artist=" & ar.GetAlbumArtist & " " & "WHERE idAlbum=" & ar.GetIdAlbum() & ";")

    End Function

    Public Function Delete(ByVal ar As Album) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Albums WHERE idAlbum='" & ar.idAlbum & "';")
    End Function

End Class
