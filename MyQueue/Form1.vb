Public Class Form1
    Dim FirstQueue As New MyQueue()
    Dim SecondQueue As New MyQueue()

    Private Sub txtFirst_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFirst.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Me.OfferVal()
            e.Handled = True
        End If

    End Sub

    Private Sub OfferVal()
        Dim c As Char = txtFirst.Text
        txtFirst.Text = ""

        If FirstQueue.Offer(c) = True Then
            Call UpdateQueue()
        Else
            MsgBox("An error occured while offerring a Char.",, "MyQueue Err")
        End If

        'Call UpdateQueue()
        txtFirst.Focus()
    End Sub

    Private Sub btnOffer_Click(sender As Object, e As EventArgs) Handles btnOffer.Click
        Call Me.OfferVal()

    End Sub

    Private Sub txtSecond_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSecond.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Me.AddVal()
            e.Handled = True
        End If
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Call Me.AddVal()
    End Sub

    Private Sub AddVal()
        Dim c As Char = txtSecond.Text
        txtSecond.Text = ""

        Try
            SecondQueue.Add(c)

        Catch mqex As MyQueueException
            MsgBox(mqex.Message,, "MyQueue Err")

        End Try

        Call UpdateQueue()
        txtSecond.Focus()
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

            MsgBox("A Char " & c & " has been removed from the first Queue.")

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

            MsgBox("A Char " & c & " is the next Char on the first Queue.")

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

    Private Sub btnActual_Click(sender As Object, e As EventArgs) Handles btnActual.Click
        MsgBox(FirstQueue.ActualArray,, "First Queue")
        MsgBox(SecondQueue.ActualArray,, "Second Queue")

    End Sub
End Class
