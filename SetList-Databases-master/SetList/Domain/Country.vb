Public Class Country
    Public ReadOnly Property counDAO As CountryDAO
    Public Property idCountry As String
    Public Property countryName As String

    Public Sub New()
        Me.counDAO = New CountryDAO
    End Sub

    Public Sub New(idCou As String, couName As String)
        Me.counDAO = New CountryDAO
        idCountry = idCou
        countryName = couName
    End Sub

    Public Function GetIdCountry() As String
        Return idCountry
    End Function

    Public Function GetCountryName() As String
        Return countryName
    End Function

    Public Function SetIdCountry(idCou As String) As String
        idCountry = idCou
    End Function

    Public Function SetCountryName(couName As String) As String
        countryName = couName
    End Function

    Public Function ReadAllCountries() As Object
        Return Me.counDAO.ReadAll()
    End Function

    Public Sub ReadCountry()
        Me.counDAO.Read(Me)
    End Sub

    Public Sub ReadCountryByName()
        Me.counDAO.ReadCountryByName(Me)
    End Sub

    Public Function InsertCountry() As Integer
        Return Me.counDAO.Insert(Me)
    End Function

    Public Function UpdateCountry() As Integer
        Return Me.counDAO.Update(Me)
    End Function
    Public Function DeleteCountry() As Integer
        Return Me.counDAO.Delete(Me)
    End Function

    Public Function Query6(startDate As Date, endDate As Date) As Object
        Return Me.counDAO.Query6(startDate, endDate)
    End Function

End Class
