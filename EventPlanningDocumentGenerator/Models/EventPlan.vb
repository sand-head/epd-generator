Public Class EventPlan
    Public Sub New(ObjectName As String, EventTrigger As String, EventProcessing As String)
        Me.ObjectName = ObjectName
        Me.EventTrigger = EventTrigger
        Me.EventProcessing = EventProcessing
    End Sub

    Public Property ObjectName As String
    Public Property EventTrigger As String
    Public Property EventProcessing As String
End Class
