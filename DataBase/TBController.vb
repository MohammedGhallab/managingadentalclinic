Public Class TBController
    Private teeth_status As List(Of TeethStatus)

    Public Async Function GetAllteeth_status() As Task(Of List(Of TeethStatus))
        Await Task.Run(Function()

                           Using context = New DataBaseContext()

                               If context.teeth_status.Count() > 0 Then
                                   teeth_status = context.teeth_status.ToList()
                               Else
                                   teeth_status = Nothing
                               End If
                           End Using
                       End Function)
        Return teeth_status
    End Function
    Public Sub AddStudent(ByVal teethstatus As TeethStatus)
        Try

            Using context = New DataBaseContext()
                context.teeth_status.AddRange(teethstatus)
                context.SaveChanges()
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function SearchByName(ByVal name As String) As List(Of TeethStatus)
        Using context = New DataBaseContext()
            teeth_status = context.teeth_status.Where(Function(x) x.crown_type.CompareTo(name)).ToList()
        End Using

        Return teeth_status
    End Function

    Public Function SearchById(ByVal id As Integer) As List(Of TeethStatus)
        Using context = New DataBaseContext()
            teeth_status = context.teeth_status.Where(Function(x) x.status_id.Equals(id)).ToList()
        End Using

        Return teeth_status
    End Function
End Class
