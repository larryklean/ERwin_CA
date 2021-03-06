﻿Public Class VBCon
    'Public Function VBWriteLine(ByVal text As String)
    '    Console.WriteLine(text)
    'End Function

    'Public Function AddNumber(ByVal num1 As Integer,
    'ByVal num2 As Integer) As Integer
    '    Return num1 + num2
    'End Function


    ''' <summary>
    ''' Assign a STRING value to a model
    ''' </summary>
    ''' <param name="model"></param>
    ''' <param name="prop"></param>
    ''' <param name="value"></param>
    ''' <returns></returns>
    Public Function AssignToObjModel(ByRef model As SCAPI.ModelObject,
                                     prop As String, value As String) As Boolean
        Try
            If model.Properties.HasProperty(prop) Then
                model.Properties(prop).Value = value
                Return True
            Else
                model.Properties(prop).Value = value
                Return True
            End If
        Catch
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Assign an INTEGER value to a model
    ''' </summary>
    ''' <param name="model"></param>
    ''' <param name="prop"></param>
    ''' <param name="value"></param>
    ''' <returns></returns>
    Public Function AssignToObjModelInt(ByRef model As SCAPI.ModelObject,
                                     prop As String, value As Integer) As Boolean
        Try
            model.Properties(prop).Value = value
            Return True
        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function

    Public Function RetriveEntity(ByRef model As SCAPI.ModelObject,
                                  collection As SCAPI.ModelObjects,
                                  entityName As String) As Boolean
        Try
            model = collection.Item(entityName, "Entity")
            '            model.Properties.Add()
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Function RetriveAttribute(ByRef model As SCAPI.ModelObject,
                                  collection As SCAPI.ModelObjects,
                                  entityName As String) As Boolean
        Try
            model = collection.Item(entityName, "Attribute")
            '            model.Properties.Add()
            Return True
        Catch
            Return False
        End Try
    End Function


End Class
