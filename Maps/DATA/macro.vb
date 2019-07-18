Sub test()
    Dim count As Integer
    For i = 5 To 6538
        Select Case Cells(i, 3)
            Case 0
                If (Cells(i, 9).Value > 0) Then
                    Cells(i, 27).Value = Cells(i, 27).Value * 1.5
                    Cells(i, 26).Value = Cells(i, 26).Value * 1.4
                End If
                count = count + 1
            Case 2
                Cells(i, 27).Value = Cells(i, 27).Value * 1.75
                count = count + 1
                Cells(i, 26).Value = Cells(i, 26).Value * 1.5
                count = count + 1
            Case 3
                Cells(i, 27).Value = Cells(i, 27).Value * 0.9
                count = count + 1
            Case 4
                Cells(i, 27).Value = Cells(i, 27).Value * 1.5
                Cells(i, 26).Value = Cells(i, 26).Value * 1.5
                count = count + 1
            Case 9
                Cells(i, 27).Value = Cells(i, 27).Value * 2
                count = count + 1
            Case 10, 11
                Cells(i, 27).Value = Cells(i, 27).Value * 2.26
                count = count + 1
            Case 12
                Cells(i, 27).Value = Cells(i, 27).Value * 3
                Cells(i, 26).Value = Cells(i, 26).Value * 1.85
                count = count + 1
            Case 17
                Cells(i, 27).Value = Cells(i, 27).Value * 1.75
                count = count + 1
        End Select
    Next i
    MsgBox count & " ALTERED"
End Sub