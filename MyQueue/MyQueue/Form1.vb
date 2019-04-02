Public Class Form1
    Dim FirstQueue As New MyQueue()
    Dim SecondQueue As New MyQueue()

    Private Sub btnOffer_Click(sender As Object, e As EventArgs) Handles btnOffer.Click
        Dim c As Char = txtFirst.Text

        If FirstQueue.Offer(c) = True Then
            Call UpdateQueue()
        Else
            MsgBox("An error occured while offerring a Char.",, "MyQueue Err")
        End If

        Call UpdateQueue()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim c As Char = txtSecond.Text

        Try
            SecondQueue.Add(c)

        Catch mqex As MyQueueException
            MsgBox(mqex.Message,, "MyQueue Err")

        End Try

        Call UpdateQueue()

    End Sub

    Private Sub btnPoll_Click(sender As Object, e As EventArgs) Handles btnPoll.Click
        Dim c As Char = FirstQueue.Poll()

        If c = Nothing Then
            MsgBox("There is nothing on the first Queue.")
        Else
            MsgBox("A Char " & c & " has been removed from the first Queue.")

        End If

        Call UpdateQueue()

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        Try
            Dim c As Char = SecondQueue.Remove

        Catch mqex As MyQueueException
            MsgBox(mqex.Message,, "MyQueue Err")

        End Try

        Call UpdateQueue()

    End Sub

    Private Sub btnPeek_Click(sender As Object, e As EventArgs) Handles btnPeek.Click
        Dim c As Char = FirstQueue.Peek()

        If c = Nothing Then
            MsgBox("There is nothing on the first Queue.")
        Else
            MsgBox("A Char " & c & " is the next Char on the first Queue.")

        End If

        Call UpdateQueue()
    End Sub

    Private Sub btnElement_Click(sender As Object, e As EventArgs) Handles btnElement.Click
        Try
            Dim c As Char = SecondQueue.Element()

        Catch mqex As MyQueueException
            MsgBox(mqex.Message,, "MyQueue Err")

        End Try

        Call UpdateQueue()
    End Sub

    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        MsgBox("Count: " & FirstQueue.Size(),, "First Queue")
        MsgBox("Count: " & SecondQueue.Size(),, "Second Queue")

    End Sub

    Private Sub btnEmpty_Click(sender As Object, e As EventArgs) Handles btnEmpty.Click
        MsgBox("IsEmpty: " & FirstQueue.IsEmpty(),, "First Queue")
        MsgBox("IsEmpty: " & SecondQueue.IsEmpty(),, "Second Queue")

    End Sub

    Private Sub UpdateQueue()
        lblQueue1Out.Text = FirstQueue.ToString
        lblQueue2Out.Text = SecondQueue.ToString

        lblCountFirst.Text = "Count: " & FirstQueue.Size()
        lblCountSecond.Text = "Count: " & SecondQueue.Size()

    End Sub
End Class
