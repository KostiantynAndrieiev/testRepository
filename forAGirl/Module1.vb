Module Module1

    Sub Main()
        Dim i As Integer 'Array index
        Dim j As Integer 'Array index
        Dim minIndex As Integer 'Array index
        Dim maxIndex As Integer 'Array index
        Dim sum As Double 'Sum of the array temp_array
        Dim temp_array(9, 9) As Double 'tha array containing calculations results

        sum = 0
        minIndex = 0
        maxIndex = 9

        Dim A = {{1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                 {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                 {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                 {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                 {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                 {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                 {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                 {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                 {1, 2, 3, 4, 5, 6, 7, 8, 9, 10},
                 {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}}

        Console.WriteLine("Matrix A:")

        For j = 0 To maxIndex Step 1
            For i = 0 To maxIndex Step 1
                Console.Write(A(j, i))
                Console.Write(" ")
            Next
            Console.WriteLine(" ")
        Next

        Console.WriteLine(" ")
        Console.WriteLine("Filtered Matrix B:")

        'Here we smooth the matrix A, as mentioned in the task.
        For j = 0 To maxIndex Step 1
            For i = 0 To maxIndex Step 1
                Select Case j
                    Case 0
                        If i = 0 Then
                            temp_array(j, i) = (A(j, i) + A(j, i + 1) + A(j + 1, i)) / 3
                        ElseIf i = 9 Then
                            temp_array(j, i) = (A(j, i) + A(j, i - 1) + A(j + 1, i)) / 3
                        Else
                            temp_array(j, i) = (A(j, i - 1) + A(j, i) + A(j, i + 1) + A(j + 1, i)) / 4
                        End If
                    Case 9
                        If i = 0 Then
                            temp_array(j, i) = (A(j, i) + A(j, i + 1) + A(j - 1, i)) / 3
                        ElseIf i = 9 Then
                            temp_array(j, i) = (A(j, i) + A(j, i - 1) + A(j - 1, i)) / 3
                        Else
                            temp_array(j, i) = (A(j, i - 1) + A(j, i) + A(j, i + 1) + A(j - 1, i)) / 4
                        End If
                    Case Else
                        If i = 0 Then
                            temp_array(j, i) = (A(j, i) + A(j, i + 1) + A(j + 1, i) + A(j - 1, i)) / 4
                        ElseIf i = 9 Then
                            temp_array(j, i) = (A(j, i) + A(j, i - 1) + A(j + 1, i) + A(j - 1, i)) / 4
                        Else
                            temp_array(j, i) = (A(j, i - 1) + A(j, i) + A(j, i + 1) + A(j + 1, i) + A(j - 1, i)) / 5
                        End If
                End Select
                Console.Write(Math.Round(temp_array(j, i), 2))
                Console.Write(" ")
            Next i
            Console.WriteLine("")
        Next j

        'Here we calcucate the sum of the elements below the main diagonal
        For j = 0 To maxIndex Step 1
            For i = 0 To (j - 1) Step 1
                sum += temp_array(j, i)
            Next i
        Next j

        Console.Write("The sum is: ")
        Console.WriteLine(Math.Round(sum, 2))

        Console.Read()

    End Sub

End Module
