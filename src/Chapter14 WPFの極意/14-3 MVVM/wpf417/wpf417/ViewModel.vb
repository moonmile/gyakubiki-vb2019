Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices


Public Class ViewModel
    Inherits ObservableObject
    Private _Message As String
    Public Property Message As String
        Get
            Return _Message
        End Get
        Set(value As String)
            SetProperty(_Message, value, NameOf(Message))
        End Set
    End Property

    Private _Items As New ObservableCollection(Of Person)
    Public Property Items As ObservableCollection(Of Person)
        Get
            Return _Items
        End Get
        Set(value As ObservableCollection(Of Person))
            SetProperty(_Items, value, NameOf(Items))
        End Set
    End Property

    Private _Item As Person
    Public Property Item As Person
        Get
            Return _Item
        End Get
        Set(value As Person)
            SetProperty(_Item, value, NameOf(Item))
        End Set
    End Property
End Class


Public Class Person
    Public Property ID As Integer
    Public Property Name As String
    Public Property Age As Integer
    Public Property Address As String
End Class



Public Class ObservableObject
    Implements INotifyPropertyChanged

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Protected Function SetProperty(Of T)(
        ByRef backingStore As T,
        value As T,
        <CallerMemberName> Optional propertyName As String = "",
        Optional onChange As Action = Nothing)

        If EqualityComparer(Of T).Default.Equals(backingStore, value) Then
            Return False
        End If
        backingStore = value
        onChange?.Invoke()
        OnPropertyChanged(propertyName)
        Return True
    End Function

    Protected Sub OnPropertyChanged(
        <CallerMemberName> Optional propertyName As String = "")
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub

    ' 値クラスを内部に持つViewModelを作る場合
    Protected Function SetProperty(Of T)(
        backingStore As Object,
        backingStorePropertyName As String,
        value As T,
        <CallerMemberName> Optional propertyName As String = "",
        Optional onChanged As Action = Nothing)

        Dim pi = backingStore.GetType().GetProperty(backingStorePropertyName)
        If pi Is Nothing Then Return False
        If pi.PropertyType <> value.GetType() Then Return False
        pi.SetMethod.Invoke(backingStore, New Object() {value})
        onChanged?.Invoke()
        OnPropertyChanged(propertyName)
        Return True
    End Function

    ' 値クラスを内部に持つViewModelを作る場合
    ' プロパティ名が内部のModelクラスのものと同一の場合
    Protected Function SetProperty(Of T)(
        backingStore As Object,
        value As T,
        <CallerMemberName> Optional propertyName As String = "",
        Optional onChanged As Action = Nothing)
        Return SetProperty(Of T)(backingStore, propertyName, value, propertyName, onChanged)
    End Function
End Class