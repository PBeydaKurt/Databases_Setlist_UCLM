Public Class ArtistDAO
    Public ReadOnly Property Artists As Collection

    Public Sub New()
        Me.Artists = New Collection
    End Sub

    Public Function ReadAll() As Object
        Dim ar As Artist
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM Artists ORDER BY IdArtist")
        For Each aux In col
            ar = New Artist(Convert.ToInt32(aux(1).ToString))
            ar.SetName(aux(2).ToString)
            ar.SetCountry(aux(3).ToString)
            Me.Artists.Add(ar)
        Next
        Return Artists
    End Function

    Public Sub Read(ByRef ar As Artist)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Artists WHERE idArtist='" & ar.GetIdArtist() & "';")
        For Each aux In col
            ar.SetName(aux(2).ToString)
            ar.SetCountry(aux(3).ToString)
        Next
    End Sub

    Public Sub ReadByName(ByRef ar As Artist)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Artists WHERE ArtistName='" & ar.GetName() & "';")
        For Each aux In col
            ar.IdArtist = Convert.ToInt32(aux(1).ToString)
            ar.SetName(aux(2).ToString)
            ar.SetCountry(aux(3).ToString)
        Next
    End Sub

    Public Function Insert(ByVal ar As Artist) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Artists (artistName, artistCountry) VALUES ('" & ar.GetName() & "' ,(SELECT idCountry FROM country WHERE idCountry='" & ar.GetCountry() & "'));")
    End Function

    Public Function Update(ByVal ar As Artist) As Integer
        Return DBBroker.GetBroker.Change("UPDATE artists SET ArtistName='" & ar.GetName() & "' ,ArtistCountry='" & ar.GetCountry() & "' WHERE idArtist=" & ar.GetIdArtist() & ";")

    End Function

    Public Function Delete(ByVal ar As Artist) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Artists WHERE idArtist=" & ar.IdArtist & ";")
    End Function

    Public Function Query1(artist As Artist) As Object
        Dim nameSong As String
        Dim songOnConcert As New Collection : Dim aux As Collection
        Dim col As Collection = DBBroker.GetBroker().Read("SELECT DISTINCT s.SongName , COUNT(st.Song) as mas_sonada FROM concerts c, setlists st, songs s 
                                                            WHERE(c.Artist = " & artist.IdArtist & " AND c.idConcert = st.Concert AND s.idSong = st.Song) GROUP BY s.SongName ORDER BY mas_sonada DESC;")

        For Each aux In col
            nameSong = aux(1).ToString
            songOnConcert.Add(nameSong)
        Next
        Return songOnConcert
    End Function

    Public Function Query2(artist As Artist) As Object
        Dim nameAlbum As String
        Dim albumsOnConcert As New Collection : Dim aux As Collection
        Dim col As Collection = DBBroker.GetBroker().Read("SELECT DISTINCT al.AlbumName , COUNT(st.Song) AS total FROM albums al, songs s, setlists st, concerts c 
                                                           WHERE(al.Artist = " & artist.IdArtist & " AND al.idAlbum = s.Album AND s.idSong = st.Song AND st.Concert = c.idConcert) GROUP BY al.AlbumName ORDER BY total DESC;")

        For Each aux In col
            nameAlbum = aux(1).ToString
            albumsOnConcert.Add(nameAlbum)
        Next
        Return albumsOnConcert
    End Function

    Public Function Query3() As Object
        Dim nameArtist As String
        Dim albumsOnConcert As New Collection : Dim aux As Collection
        Dim col As Collection = DBBroker.GetBroker().Read("SELECT DISTINCT ar.ArtistName 
                                                           FROM artists ar, albums al, songs_of_album_per_concert sc, songs_per_album_view sa
                                                           WHERE ar.idArtist = al.Artist AND al.idAlbum = sc.album AND al.idAlbum = sa.idAlbum AND sc.total_concert = sa.total_album;")

        For Each aux In col
            nameArtist = aux(1).ToString
            albumsOnConcert.Add(nameArtist)
        Next
        Return albumsOnConcert
    End Function

    Public Function Query5(ByRef startDate As Date, ByRef endDate As Date) As Object
        Dim nameArtist As String
        Dim artistMorePerformances As New Collection : Dim aux As Collection
        Dim col As Collection = DBBroker.GetBroker().Read("SELECT a.ArtistName, COUNT(DISTINCT c.idConcert) AS total_conciertos FROM artists a, concerts c 
                                                               WHERE(a.idArtist = c.Artist AND c.ConcertDate BETWEEN '" & startDate.ToString("yyyy/MM/dd") & "' AND '" & endDate.ToString("yyyy/MM/dd") & "') 
                                                               GROUP BY a.ArtistName ORDER BY total_conciertos DESC;")
        For Each aux In col
            nameArtist = aux(1).ToString
            artistMorePerformances.Add(nameArtist)
        Next
        Return artistMorePerformances
    End Function

End Class