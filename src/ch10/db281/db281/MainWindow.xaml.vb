Imports System.Data.Common
Imports System.Data.Entity
Imports db281.db281

Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        ' 接続文字列
        Dim cnstr = "data source=.;initial catalog=sampledb;integrated security=True"
        ' EntityConnectionの作成
        Dim esb = New System.Data.Entity.Core.EntityClient.EntityConnectionStringBuilder()
        esb.Provider = "System.Data.SqlClient"
        esb.ProviderConnectionString = cnstr
        esb.Metadata = "res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl"
        Dim cn As New System.Data.Entity.Core.EntityClient.EntityConnection(esb.ToString())
        ' EntityConnectionのインスタンスを渡す
        Dim ent As New sampledbEntities(cn)
        dg.ItemsSource = ent.Person.ToList()
    End Sub
End Class

Namespace db281
    Partial Public Class sampledbEntities
        Inherits DbContext
        Public Sub New(existingConnection As DbConnection)
            MyBase.New(existingConnection, True)
        End Sub
    End Class
End Namespace

