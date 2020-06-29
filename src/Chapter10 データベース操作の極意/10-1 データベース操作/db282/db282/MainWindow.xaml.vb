Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports db282.db282

Class MainWindow
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        AddHandler Me.Loaded,
            Sub()
                _vm = New MainViewModel()
                Me.DataContext = _vm
            End Sub
    End Sub
    Private _vm As MainViewModel
    Private _ent As New sampledbEntities()

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        _vm.Items = New ObservableCollection(Of Person)(_ent.Person.ToList())
    End Sub

    Private Sub clickAdd(sender As Object, e As RoutedEventArgs)
        Dim pa As New Person() With {
            .Name = _vm.Name,
            .Age = _vm.Age,
            .Address = _vm.Address
        }
        _ent.Person.Add(pa)
        _ent.SaveChanges()
    End Sub

    Private Sub clickUpdate(sender As Object, e As RoutedEventArgs)
        _vm.Item.Name = _vm.Name
        _vm.Item.Age = _vm.Age
        _vm.Item.Address = _vm.Address
        _ent.SaveChanges()
    End Sub

    Private Sub clickDelete(sender As Object, e As RoutedEventArgs)
        If _vm.Item Is Nothing Then
            Return
        End If
        Dim it = _ent.Person.FirstOrDefault(
            New Func(Of Person, Boolean)(
            Function(t)
                Return t.ID = _vm.Item.ID
            End Function))

        _ent.Person.Remove(it)
        _ent.SaveChanges()
    End Sub

End Class

Public Class MainViewModel
    Inherits ObservableObject
    Private _Item As Person
    Private _Items As ObservableCollection(Of Person)

    Public Property Item As Person
        Get
            Return _Item
        End Get
        Set(value As Person)
            If Not _Item Is value Then
                _Item = value
                OnPropertyChanged(NameOf(Item))
                If Not _Item Is Nothing Then
                    Me.Name = _Item.Name
                    Me.Age = _Item.Age
                    Me.Address = _Item.Address
                End If
            End If
        End Set
    End Property
    Public Property Items As ObservableCollection(Of Person)
        Get
            Return _Items
        End Get
        Set(value As ObservableCollection(Of Person))
            Me.Item = Nothing
            SetProperty(_Items, value, NameOf(Items))
        End Set
    End Property

    Private _Name As String
    Private _Age As Integer
    Private _Address As String
    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            SetProperty(_Name, value, NameOf(Name))
        End Set
    End Property
    Public Property Age As Integer
        Get
            Return _Age
        End Get
        Set(value As Integer)
            SetProperty(_Age, value, NameOf(Age))
        End Set
    End Property
    Public Property Address As String
        Get
            Return _Address
        End Get
        Set(value As String)
            SetProperty(_Address, value, NameOf(Address))
        End Set
    End Property
End Class


Public Class ObservableObject
    Implements INotifyPropertyChanged
    Protected Function SetProperty(Of T)(
            ByRef backingStore As T,
            value As T,
            <CallerMemberName> propertyName As String,
            Optional onChanged As Action = Nothing) As Boolean
        If EqualityComparer(Of T).Default.Equals(backingStore, value) Then
            Return False
        End If
        backingStore = value
        onChanged?.Invoke()
        OnPropertyChanged(propertyName)
        Return True
    End Function
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Protected Sub OnPropertyChanged(<CallerMemberName> Optional propertyName As String = "")
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
End Class

