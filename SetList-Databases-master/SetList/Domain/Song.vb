Public Class Song
    Public ReadOnly Property sonDAO As SongDAO
    Public Property idSong As Integer
    Public Property songName As String
    Public Property songLength As Integer
    Public Property songAlbum As Integer
    Public Property songOrder As Integer
    Public Sub New()
        Me.sonDAO = New SongDAO
    End Sub
    Public Sub New(idSon As Integer)
        Me.sonDAO = New SongDAO
        Me.idSong = idSon
    End Sub
    Public Sub New(idSon As Integer, sonName As String, sonLength As Integer, sonAlbum As Integer, sonOrder As Integer)
        Me.sonDAO = New SongDAO
        idSong = idSon
        songName = sonName
        songLength = sonLength
        songAlbum = sonAlbum
        songOrder = sonOrder
    End Sub
    Public Function GetIdSong() As Integer
        Return idSong
    End Function

    Public Function GetSongName() As String
        Return songName
    End Function
    Public Function GetSongLength() As Integer
        Return songLength
    End Function

    Public Function GetSongAlbum() As Integer
        Return songAlbum
    End Function
    Public Function GetSongOrder() As Integer
        Return songOrder
    End Function

    Public Function SetIdSong(idSon As Integer) As Integer
        idSong = idSon
    End Function

    Public Function SetSongName(sonName As String) As String
        songName = sonName
    End Function
    Public Function SetSongLength(sonLength As Integer) As Integer
        songLength = sonLength
    End Function

    Public Function SetSongAlbum(sonAlbum As Integer) As Integer
        songAlbum = sonAlbum
    End Function
    Public Function SetSongOrder(sonOrder As Integer) As Integer
        songOrder = sonOrder
    End Function


    Public Function ReadAllSongs() As Object
        Return Me.sonDAO.ReadAll()
    End Function

    Public Function ReadAllAlbumSongs() As Object
        Return Me.sonDAO.ReadAllAlbumSongs(Me)
    End Function

    Public Sub ReadSong()
        Me.sonDAO.Read(Me)
    End Sub

    Public Sub ReadSongByName()
        Me.sonDAO.ReadByName(Me)
    End Sub

    Public Function InsertSong() As Integer
        Return Me.sonDAO.Insert(Me)
    End Function

    Public Function UpdateSong() As Integer
        Return Me.sonDAO.Update(Me)
    End Function

    Public Function DeleteSong() As Integer
        Return Me.sonDAO.Delete(Me)
    End Function

    Public Function Query4() As Object
        Return Me.sonDAO.Query4(Me)
    End Function
End Class