Imports System.Runtime.Serialization

Public Class MyQueueException : Inherits System.Exception

    Public Sub New()
        MyBase.New()

    End Sub

    Public Sub New(msg As String)
        MyBase.New(msg)
    End Sub

    Protected Sub New(info As SerializationInfo, context As StreamingContext)
        MyBase.New(info, context)
    End Sub

End Class
