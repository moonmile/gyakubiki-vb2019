﻿'------------------------------------------------------------------------------
' <auto-generated>
'     このコードはテンプレートから生成されました。
'
'     このファイルを手動で変更すると、アプリケーションで予期しない動作が発生する可能性があります。
'     このファイルに対する手動の変更は、コードが再生成されると上書きされます。
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Namespace db306

    Partial Public Class sampledbEntities
        Inherits DbContext
    
        Public Sub New()
            MyBase.New("name=sampledbEntities")
        End Sub
    
        Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
            Throw New UnintentionalCodeFirstException()
        End Sub
    
        Public Overridable Property Person() As DbSet(Of Person)
    
    End Class

End Namespace
