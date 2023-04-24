Module functions

    Function Ones(ByVal numbers() As Integer) As Integer 'gets the total of ones rolled

        Dim scoreOnes As Integer = 0
        Dim i As Integer
        Const max As Integer = 5

        For i = 0 To max
            If numbers(i) = 1 Then
                scoreOnes += numbers(i)
            End If
        Next

        Return scoreOnes
    End Function

    Function Twos(ByVal numbers() As Integer) As Integer  ' gets the total of twos rolled

        Dim scoreTwos As Integer = 0
        Dim i As Integer
        Const max As Integer = 5

        For i = 0 To max
            If numbers(i) = 2 Then
                scoreTwos += numbers(i)
            End If
        Next

        Return scoreTwos
    End Function


    Function Threes(ByVal numbers() As Integer) As Integer   ' gets the total of threes rolled

        Dim scoreThrees As Integer = 0
        Dim i As Integer
        Const max As Integer = 5

        For i = 0 To max
            If numbers(i) = 3 Then
                scoreThrees += numbers(i)
            End If
        Next

        Return scoreThrees
    End Function

    Function Fours(ByVal numbers() As Integer) As Integer    ' gets the total of fours rolled

        Dim scoreFours As Integer = 0
        Dim i As Integer
        Const max As Integer = 5

        For i = 0 To max
            If numbers(i) = 4 Then
                scoreFours += numbers(i)
            End If
        Next

        Return scoreFours
    End Function

    Function Fives(ByVal numbers() As Integer) As Integer    ' gets the total of fives rolled

        Dim scoreFives As Integer = 0
        Dim i As Integer
        Const max As Integer = 5

        For i = 0 To max
            If numbers(i) = 5 Then
                scoreFives += numbers(i)
            End If
        Next

        Return scoreFives
    End Function

    Function Sixes(ByVal numbers() As Integer) As Integer    ' gets the total of sixes rolled

        Dim scoreSixes As Integer = 0
        Dim i As Integer
        Const max As Integer = 5

        For i = 0 To max
            If numbers(i) = 6 Then
                scoreSixes += numbers(i)
            End If
        Next
        Return scoreSixes
    End Function

    Function totalOfAllDice(ByVal numbers() As Integer) As Integer       'calculates total of all dice
        Dim totalScore As Integer = 0
        Dim i As Integer
        Dim max As Integer = 5

        For i = 0 To max
            totalScore += numbers(i)
        Next

        Return totalScore
    End Function

    Function lowerScoreCalculated(ByVal threeOfAKind As Integer, ByVal fourOfAKind As Integer, ByVal fullHouse As Integer, ByVal smallStraight As Integer, ByVal largeStraight As Integer, ByVal yahtzee As Integer, ByVal bonus As Integer, ByVal chance As Integer) As Integer        'calculates lower score card

        Dim lowerScoreCalc As Integer = 0

        lowerScoreCalc = threeOfAKind + fourOfAKind + fullHouse + smallStraight + largeStraight + yahtzee + bonus + chance


        Return lowerScoreCalc
    End Function

End Module
