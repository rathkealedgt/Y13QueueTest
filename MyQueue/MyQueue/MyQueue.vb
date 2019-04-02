''' <summary>
'''----------------------Interface Structure----------------------
'''Type of Operation	    Throws exception    Returns special value
'''Insert	                    add(val)	        offer(val)
'''Remove	                    remove()	        poll()
'''Examine	                    element()	        peek()
'''----------------------------------------------------------------
''' </summary>
''' <author>Y12/Y13 Rathkeale College</author>
''' <date>March 2019</date>

Public Class MyQueue

    Private intFront As Integer = 0
    Private intBack As Integer = 0
    Private intCount As Integer = 0
    Private chrData(9) As Char

    Public Sub New()

    End Sub

    ''' <summary>
    '''     This method Is used To add elements at the tail Of queue (or according To the priority in the case of a priority queue implementation). Throws an exception
    '''     if an error occurs.
    ''' </summary>
    ''' <param name="val"> The Char to add to the Queue. </param>
    ''' <throws> MyQueueException </throws>

    Public Sub Add(val As Char)
        If intBack = 0 Then
                    chrData(intBack) = val
                    intCount = intCount + 1
                    intBack = intBack + 1
                    MsgBox("your figure is added")

                ElseIf intBack = 9 Then
                    Call ExpandQueue()
                    chrData(intBack) = val
                    intCount = intCount + 1
                    intBack = intBack + 1
                    MsgBox("expanded queue and your figure is added")


                Else

                    chrData(intCount) = val
                    intCount = intCount + 1
                    intBack = intBack + 1
                    MsgBox("your figure is added")

                End If
    End Sub

    ''' <summary>
    '''     This method is used to add elements at the tail of queue. 
    ''' </summary>
    ''' <param name="val"> The Char to add to the Queue. </param>
    ''' <returns> True if successfull. False otherwise. </returns>

    Public Function Offer(val As Char) As Boolean

    End Function


    ''' <summary>
    '''     This method is used to view the head of queue without removing it. It returns Nothing if the queue is empty.
    ''' </summary>
    ''' <returns> A copy of the value at the head of the Queue. Or Nothing if Queue is empty. </returns>

    Public Function Peek() As Char

        If IsEmpty() = True Then
            Return Nothing

        Else
            Return chrData(intCount)

        End If

    End Function

    ''' <summary>
    '''     This method is similar to peek(). It throws MyQueueException when the queue is empty.
    ''' </summary>
    ''' <throws> MyQueueException </throws>
    ''' <returns> A copy of the value at the head of the Queue. </returns>

    Public Function Element() As Char

    End Function

    ''' <summary>
    '''     This method removes and returns the head of the queue. It throws MyQueueException when the Queue is impty.
    ''' </summary>
    ''' <throws> MyQueueException </throws>
    ''' <returns> The value at the head of the Queue. </returns>

    Public Function Remove() As Char

        Dim removed As String

        If IsEmpty() = True Then

            Throw New MyQueueException("There is nothing in the queue.")

        End If

        While intCount > 0 And intFront = intBack

            Throw New MyQueueException("There is nothing in the queue.")

            Exit Function

        End While

        removed = chrData(intFront)

        chrData(intFront) = ""

        intFront = intFront + 1

        MsgBox(removed & ", has been removed from the queue",, "Alert!")

        Return removed

    End Function
    ''' <summary>
    '''     This method removes and returns the head of the queue. It returns Nothing if the Queue is empty.
    ''' </summary>
    ''' <returns> The value at the head of the Queue. </returns>

    Public Function Poll() As Char

    End Function

    ''' <summary>
    '''     This method return the number of elements in the Queue.
    ''' </summary>
    ''' <returns> the number of elements in the Queue. </returns>

    Public Function Size() As Integer
        Dim c As Integer = 0
        c = intCount
        Return (c)
    End Function

    ''' <summary>
    '''     Checks if the Queue is empty.
    ''' </summary>
    ''' <returns> True iff there are no elements in the Queue. Otherwise False. </returns>

    Public Function IsEmpty() As Boolean
       If intCount = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    '''     Returns the Queue as a String object in order from right to left.
    ''' </summary>
    ''' <returns> The Queue as a String object. </returns>
    Public Overrides Function ToString() As String
        Dim strQueue As String = ""

        Return strQueue
    End Function

    ''' <summary>
    '''     Doubles the size of the queue when full.
    ''' </summary>
    Private Sub ExpandQueue()

    End Sub

End Class
