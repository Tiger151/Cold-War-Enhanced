Sub test()
    Dim count As Integer
    Dim count_f As Integer
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
                Cells(i, 36).Value = Cells(i, 36).Value * 0.5
                Cells(i, 27).Value = Cells(i, 27).Value * 3
                Cells(i, 26).Value = Cells(i, 26).Value * 1.85
                count = count + 1
            Case 17
                Cells(i, 27).Value = Cells(i, 27).Value * 1.75
                count = count + 1
                
            Case 21
                If (Cells(i, 1).Value = 21038) Then
                    Cells(i, 28).Value = Cells(i, 28).Value * 0.25
                    count_f = count_f + 1
                End If
                If (Cells(i, 1).Value = 21037) Then
                    Cells(i, 28).Value = Cells(i, 28).Value * 0.25
                    count_f = count_f + 1
                End If
                If (IsNumeric(Cells(i, 113).Value)) Then
                    Cells(i, 113).Value = Cells(i, 113).Value * 2
                    count_f = count_f + 1
                End If
				'Unit productions / research centers
				If (Cells(i, 1).Value = 21212 OR Cells(i, 1).Value = 21211 OR Cells(i, 1).Value = 21210 OR Cells(i, 1).Value = 21213 OR Cells(i, 1).Value = 21100) Then
					Cells(i, 26).Value = Cells(i, 26).Value * 3
					Cells(i, 27).Value = Cells(i, 27).Value * 2
					count_f = count_f + 1
				End If
				
        End Select
        
    Next i
    MsgBox count & " UNITS ALTERED | " & count_f & " FACILITIES ALTERED"
End Sub
