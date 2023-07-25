Public Class CountryDAO
    Public ReadOnly Property Countries As Collection

    Public Sub New()
        Me.Countries = New Collection
    End Sub

    Public Function ReadAll() As Object
        Dim country As Country
        Dim col, aux As Collection
        col = DBBroker.GetBroker().Read("SELECT * FROM Country ORDER BY idCountry")
        For Each aux In col
            country = New Country(aux(1).ToString, aux(2).ToString)
            Me.Countries.Add(country)
        Next
        Return Countries
    End Function

    Public Sub Read(ByRef country As Country)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Country WHERE idCountry='" & country.GetIdCountry & "';")
        For Each aux In col
            country.SetCountryName(aux(2).ToString)
        Next
    End Sub

    Public Sub ReadCountryByName(ByRef country As Country)
        Dim col As Collection : Dim aux As Collection
        col = DBBroker.GetBroker.Read("SELECT * FROM Country WHERE CountryName='" & country.countryName & "';")
        For Each aux In col
            country.SetIdCountry(aux(1).ToString)
            country.SetCountryName(aux(2).ToString)
        Next
    End Sub

    Public Function Insert(ByVal country As Country) As Integer
        Return DBBroker.GetBroker.Change("INSERT INTO Country (idCountry,countryName) VALUES ('" & country.GetIdCountry() & "','" & country.GetCountryName() & "');")
    End Function

    Public Function Update(ByVal country As Country) As Integer
        Return DBBroker.GetBroker.Change("UPDATE Country SET idCountry='" & country.countryName.Substring(0, 3) & "' ,countryName='" & country.countryName & "'WHERE idCountry='" & country.GetIdCountry() & "';")
    End Function

    Public Function Delete(ByVal country As Country) As Integer
        Return DBBroker.GetBroker.Change("DELETE FROM Country WHERE idCountry='" & country.idCountry & "';")
    End Function

    Public Function Query6(ByRef startDate As Date, ByRef endDate As Date) As Object
        Dim nameCountry As String
        Dim countriesPerformed As New Collection : Dim aux As Collection
        Dim col As Collection = DBBroker.GetBroker().Read("SELECT c.CountryName, COUNT(con.idConcert) AS total_conciertos FROM venues v, concerts con, country c 
                                                           WHERE c.idCountry = v.VenueCountry AND con.Venue = v.idVenue and con.ConcertDate BETWEEN '" & startDate.ToString("yyyy/MM/dd") & "' AND '" & endDate.ToString("yyyy/MM/dd") & "' 
                                                           GROUP BY c.CountryName ORDER BY total_conciertos DESC;")

        For Each aux In col
            nameCountry = aux(1).ToString
            countriesPerformed.Add(nameCountry)
        Next
        Return countriesPerformed
    End Function

End Class
