Public Class SongDAO
    Public ReadOnly Property Songs As Collection

    Public Sub New()
        Me.Songs = New Collection
    End Sub

    Public Function ReadAll() As Object
        Dim so As Song
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM Songs ORDER BY idSong")
        For Each aux In col
            so = New Song(Convert.ToInt32(aux(1).ToString))
            so.SetSongName(aux(2).ToString)
            so.songLength = Convert.ToInt32(aux(3).ToString)
            so.songAlbum = Convert.ToInt32(aux(4).ToString)
            so.songOrder = Convert.ToInt32(aux(5).ToString)
            Me.Songs.Add(so)
        Next
        Return Songs
    End Function

    Public Function ReadAllAlbumSongs(ByRef song As Song) As Object
        Dim so As Song
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM Songs WHERE Album='" & song.songAlbum & "';")
        For Each aux In col
            so = New Song(Convert.ToInt32(aux(1).ToString))
            so.SetSongName(aux(2).ToString)
            so.songLength = Convert.ToInt32(aux(3).ToString)
            so.songAlbum = Convert.ToInt32(aux(4).ToString)
            so.songOrder = Convert.ToInt32(aux(5).ToString)
            Me.Songs.Add(so)
        Next
        Return Songs
    End Function

    Public Sub Read(ByRef so As Song)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Songs WHERE idSong=" & so.GetIdSong() & ";")
        For Each aux In col
            so.SetSongName(aux(2).ToString)
            so.songLength = Convert.ToInt32(aux(3).ToString)
            so.songAlbum = Convert.ToInt32(aux(4).ToString)
            so.songOrder = Convert.ToInt32(aux(5).ToString)
        Next
    End Sub

    Public Sub ReadByName(ByRef so As Song)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Songs WHERE SongName='" & so.GetSongName() & "';")
        For Each aux In col
            so.idSong = Convert.ToInt32(aux(1).ToString)
            so.SetSongName(aux(2).ToString)
            so.songLength = Convert.ToInt32(aux(3).ToString)
            so.songAlbum = Convert.ToInt32(aux(4).ToString)
            so.songOrder = Convert.ToInt32(aux(5).ToString)
        Next
    End Sub

    Public Function Insert(ByVal so As Song) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Songs (SongName, SongLength, Album, SongOrder) VALUES ('" & so.GetSongName() & "' ," & so.GetSongLength() & "," & so.GetSongAlbum() & "," & so.GetSongOrder() & ");")
    End Function

    Public Function Update(ByVal so As Song) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Songs SET SongName='" & so.GetSongName() & "', SongLength=" & so.GetSongLength() & ", Album=" & so.GetSongAlbum() & ", SongOrder=" & so.GetSongOrder() & " " & "WHERE idSong=" & so.GetIdSong() & ";")

    End Function

    Public Function Delete(ByVal so As Song) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Songs WHERE idSong='" & so.idSong & "';")
    End Function

    Public Function Query4(song As Song) As Object
        Dim nameSong As String
        Dim songOnConcert As New Collection : Dim aux As Collection
        Dim col As Collection = DBBroker.GetBroker().Read("SELECT s.songName , COUNT(st.Song) as max_repro FROM songs s, setlists st WHERE(st.Song = s.idSong) GROUP BY s.SongName ORDER BY max_repro DESC;")

        For Each aux In col
            nameSong = aux(1).ToString
            songOnConcert.Add(nameSong)
        Next
        Return songOnConcert
    End Function

End Class