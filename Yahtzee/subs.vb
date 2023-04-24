Module subs

    Sub calcScore()    'calculates scores

        Dim i As Integer
        Const intMax As Integer = 5
        Dim numOnes As Integer = 0
        Dim numTwos As Integer = 0
        Dim numThrees As Integer = 0
        Dim numFours As Integer = 0
        Dim numFives As Integer = 0
        Dim numSixes As Integer = 0


        Dim numbers(5) As Integer
        numbers(0) = picOneScore
        numbers(1) = picTwoScore
        numbers(2) = picThreeScore
        numbers(3) = picFourScore
        numbers(4) = picFiveScore


        For i = 0 To intMax             'checks how many ones were rolled

            If numbers(i) = 1 Then
                numOnes += 1
            End If

        Next

        For i = 0 To intMax             'checks how many twos were rolled

            If numbers(i) = 2 Then
                numTwos += 1
            End If

        Next

        For i = 0 To intMax              'checks how many threes were rolled

            If numbers(i) = 3 Then
                numThrees += 1
            End If

        Next

        For i = 0 To intMax              'checks how many fours were rolled

            If numbers(i) = 4 Then
                numFours += 1
            End If

        Next

        For i = 0 To intMax              'checks how many fives were rolled

            If numbers(i) = 5 Then
                numFives += 1
            End If

        Next

        For i = 0 To intMax              'checks how many sixes were rolled

            If numbers(i) = 6 Then
                numSixes += 1
            End If

        Next


        totalScoreOnes = functions.Ones(numbers)          'function to calculate total score of ones rolled

        totalScoreTwos = functions.Twos(numbers)          'function to calculate total score of twos rolled

        totalScoreThrees = functions.Threes(numbers)          'function to calculate total score of threes rolled

        totalScoreFours = functions.Fours(numbers)            'function to calculate total score of fours rolled

        totalScoreFives = functions.Fives(numbers)            'function to calculate total score of fives rolled

        totalScoreSixes = functions.Sixes(numbers)            'function to calculate total score of sixes rolled

        totalScoreAllDice = functions.totalOfAllDice(numbers)         'function to calculate total score of all dice rolled



        If numOnes >= 3 Or numTwos >= 3 Or numThrees >= 3 Or numFours >= 3 Or numFives >= 3 Or numSixes >= 3 Then     'checks for three of a kind

            threeOfAKind = True

        End If

        If numOnes >= 4 Or numTwos >= 4 Or numThrees >= 4 Or numFours >= 4 Or numFives >= 4 Or numSixes >= 4 Then     'checks for four of a kind

            fourOfAKind = True

        End If

        If (numOnes = 2 Or numTwos = 2 Or numThrees = 2 Or numFours = 2 Or numFives = 2 Or numSixes = 2) And (numOnes = 3 Or numTwos = 3 Or numThrees = 3 Or numFours = 3 Or numFives = 3 Or numSixes = 3) Then    'checks for full house

            fullHouse = True

        End If

        If (numOnes >= 1 And numTwos >= 1 And numThrees >= 1 And numFours >= 1) Or (numTwos >= 1 And numThrees >= 1 And numFours >= 1 And numFives >= 1) Or (numThrees >= 1 And numFours >= 1 And numFives >= 1 And numSixes >= 1) Then         'checks for small straight

            smallStraight = True

        End If

        If (numOnes = 1 And numTwos = 1 And numThrees = 1 And numFours = 1 And numFives = 1) Or (numTwos = 1 And numThrees = 1 And numFours = 1 And numFives = 1 And numSixes = 1) Then         'checks for large straight

            largeStraight = True

        End If

        If numOnes = 5 Or numTwos = 5 Or numThrees = 5 Or numFours = 5 Or numFives = 5 Or numSixes = 5 Then         'checks for yahtzee
            yahtzeeRoll = True
            numYahtzee += 1
        End If






        If frmGame.lblOnesTotalScore.Enabled Then           'checks if score for Ones is enabled. If it is, then shows possible score in red.
            frmGame.lblOnesTotalScore.Text = totalScoreOnes.ToString
            frmGame.lblOnesTotalScore.ForeColor = Color.Red
        End If

        If frmGame.lblTwosTotalScore.Enabled Then           'checks if score for Twos is enabled. If it is, then shows possible score in red.
            frmGame.lblTwosTotalScore.Text = totalScoreTwos.ToString
            frmGame.lblTwosTotalScore.ForeColor = Color.Red
        End If

        If frmGame.lblThreesTotalScore.Enabled Then         'checks if score for Threes is enabled. If it is, then shows possible score in red.
            frmGame.lblThreesTotalScore.Text = totalScoreThrees.ToString
            frmGame.lblThreesTotalScore.ForeColor = Color.Red
        End If

        If frmGame.lblFoursTotalScore.Enabled Then          'checks if score for Fours is enabled. If it is, then shows possible score in red.
            frmGame.lblFoursTotalScore.Text = totalScoreFours.ToString
            frmGame.lblFoursTotalScore.ForeColor = Color.Red
        End If

        If frmGame.lblFivesTotalScore.Enabled Then          'checks if score for Fives is enabled. If it is, then shows possible score in red.
            frmGame.lblFivesTotalScore.Text = totalScoreFives.ToString
            frmGame.lblFivesTotalScore.ForeColor = Color.Red
        End If

        If frmGame.lblSixesTotalScore.Enabled Then          'checks if score for Sixes is enabled. If it is, then shows possible score in red.
            frmGame.lblSixesTotalScore.Text = totalScoreSixes.ToString
            frmGame.lblSixesTotalScore.ForeColor = Color.Red
        End If

        If (frmGame.lblThreeOfAKindScore.Enabled And threeOfAKind) Or (frmGame.lblThreeOfAKindScore.Enabled And numYahtzee >= 2) Then        'checks if score for Three Of A Kind is enabled. If it is, then shows possible score in red.
            frmGame.lblThreeOfAKindScore.Text = totalScoreAllDice.ToString
            frmGame.lblThreeOfAKindScore.ForeColor = Color.Red
        ElseIf frmGame.lblThreeOfAKindScore.Enabled = True And Not threeOfAKind Then
            frmGame.lblThreeOfAKindScore.Text = 0.ToString
            frmGame.lblThreeOfAKindScore.ForeColor = Color.Red
        End If

        If (frmGame.lblFourOfAKindScore.Enabled And fourOfAKind) Or (frmGame.lblFourOfAKindScore.Enabled And numYahtzee >= 2) Then         'checks if score for Four Of A Kind is enabled. If it is, then shows possible score in red.
            frmGame.lblFourOfAKindScore.Text = totalScoreAllDice.ToString
            frmGame.lblFourOfAKindScore.ForeColor = Color.Red
        ElseIf frmGame.lblThreeOfAKindScore.Enabled And Not threeOfAKind Then
            frmGame.lblFourOfAKindScore.Text = 0.ToString
            frmGame.lblFourOfAKindScore.ForeColor = Color.Red
        End If

        If (frmGame.lblFullHouse.Enabled And fullHouse) Or (frmGame.lblFullHouse.Enabled And numYahtzee >= 2) Then            'checks if score for Full House is enabled. If it is, then shows possible score in red.
            frmGame.lblFullHouse.Text = 25.ToString
            frmGame.lblFullHouse.ForeColor = Color.Red
        ElseIf frmGame.lblFullHouse.Enabled And Not fullHouse Then
            frmGame.lblFullHouse.Text = 0.ToString
            frmGame.lblFullHouse.ForeColor = Color.Red
        End If

        If (frmGame.lblSmallStraight.Enabled And smallStraight) Or (frmGame.lblSmallStraight.Enabled And numYahtzee >= 2) Then            'checks if score for Small Straight is enabled. If it is, then shows possible score in red.
            frmGame.lblSmallStraight.Text = 30.ToString
            frmGame.lblSmallStraight.ForeColor = Color.Red
        ElseIf frmGame.lblSmallStraight.Enabled And Not smallStraight Then
            frmGame.lblSmallStraight.Text = 0.ToString
            frmGame.lblSmallStraight.ForeColor = Color.Red
        End If

        If (frmGame.lblLargeStraight.Enabled And largeStraight) Or (frmGame.lblLargeStraight.Enabled And numYahtzee >= 2) Then            'checks if score for Small Straight is enabled. If it is, then shows possible score in red.
            frmGame.lblLargeStraight.Text = 40.ToString
            frmGame.lblLargeStraight.ForeColor = Color.Red
        ElseIf frmGame.lblLargeStraight.Enabled And Not largeStraight Then
            frmGame.lblLargeStraight.Text = 0.ToString
            frmGame.lblLargeStraight.ForeColor = Color.Red
        End If

        If frmGame.lblYahtzeeRollOne.Enabled And yahtzeeRoll And numYahtzee = 1 Then            'checks if score for Yahtzee is enabled. If it is, then shows possible score in red.
            frmGame.lblYahtzeeRollOne.Text = 50.ToString
            frmGame.lblYahtzeeRollOne.ForeColor = Color.Red
        ElseIf frmGame.lblYahtzeeRollOne.Enabled And Not yahtzeeRoll Then
            frmGame.lblYahtzeeRollOne.Text = 0.ToString
            frmGame.lblYahtzeeRollOne.ForeColor = Color.Red
        End If

        If frmGame.lblChance.Enabled Then          'checks if score for Chance is enabled. If it is, then shows possible score in red.
            frmGame.lblChance.Text = totalScoreAllDice.ToString
            frmGame.lblChance.ForeColor = Color.Red
        End If

    End Sub

    Sub yahtzeeBonus()          ' calculates Yahtzee bonus if more than one Yahtzee is rolled

        If numYahtzee >= 2 Then
            frmGame.lblYahtzeeBonusCheck.Text += checkMark
            yahtzeeBonusScore += 100
            frmGame.lblYahtzeeBonusScore.Text = yahtzeeBonusScore.ToString
        End If

    End Sub

    Sub check()         'just runs a check to see if label is enabled once score is inputed, then puts all the labels back to 0 and black font color

        If frmGame.lblOnesTotalScore.Enabled Then
            frmGame.lblOnesTotalScore.Text = 0.ToString
            frmGame.lblOnesTotalScore.ForeColor = Color.Black
        End If
        If frmGame.lblTwosTotalScore.Enabled Then
            frmGame.lblTwosTotalScore.Text = 0.ToString
            frmGame.lblTwosTotalScore.ForeColor = Color.Black
        End If
        If frmGame.lblThreesTotalScore.Enabled Then
            frmGame.lblThreesTotalScore.Text = 0.ToString
            frmGame.lblThreesTotalScore.ForeColor = Color.Black
        End If
        If frmGame.lblFoursTotalScore.Enabled Then
            frmGame.lblFoursTotalScore.Text = 0.ToString
            frmGame.lblFoursTotalScore.ForeColor = Color.Black
        End If
        If frmGame.lblFivesTotalScore.Enabled Then
            frmGame.lblFivesTotalScore.Text = 0.ToString
            frmGame.lblFivesTotalScore.ForeColor = Color.Black
        End If
        If frmGame.lblSixesTotalScore.Enabled Then
            frmGame.lblSixesTotalScore.Text = 0.ToString
            frmGame.lblSixesTotalScore.ForeColor = Color.Black
        End If
        If frmGame.lblThreeOfAKindScore.Enabled Then
            frmGame.lblThreeOfAKindScore.Text = 0.ToString
            frmGame.lblThreeOfAKindScore.ForeColor = Color.Black
        End If
        If frmGame.lblFourOfAKindScore.Enabled Then
            frmGame.lblFourOfAKindScore.Text = 0.ToString
            frmGame.lblFourOfAKindScore.ForeColor = Color.Black
        End If
        If frmGame.lblFullHouse.Enabled Then
            frmGame.lblFullHouse.Text = 0.ToString
            frmGame.lblFullHouse.ForeColor = Color.Black
        End If
        If frmGame.lblSmallStraight.Enabled Then
            frmGame.lblSmallStraight.Text = 0.ToString
            frmGame.lblSmallStraight.ForeColor = Color.Black
        End If
        If frmGame.lblLargeStraight.Enabled Then
            frmGame.lblLargeStraight.Text = 0.ToString
            frmGame.lblLargeStraight.ForeColor = Color.Black
        End If
        If frmGame.lblYahtzeeRollOne.Enabled Then
            frmGame.lblYahtzeeRollOne.Text = 0.ToString
            frmGame.lblYahtzeeRollOne.ForeColor = Color.Black
        End If
        If frmGame.lblChance.Enabled Then
            frmGame.lblChance.Text = 0.ToString
            frmGame.lblChance.ForeColor = Color.Black
        End If

    End Sub




    Sub nextRoll()          'sets page for next roll



        frmGame.picOne.Visible = True
        frmGame.picDicePickOne.Visible = False
        frmGame.picOne.Enabled = True
        frmGame.picTwo.Visible = True
        frmGame.picDicePickTwo.Visible = False
        frmGame.picTwo.Enabled = True
        frmGame.picThree.Visible = True
        frmGame.picDicePickThree.Visible = False
        frmGame.picThree.Enabled = True
        frmGame.picFour.Visible = True
        frmGame.picDicePickFour.Visible = False
        frmGame.picFour.Enabled = True
        frmGame.picFive.Visible = True
        frmGame.picDicePickFive.Visible = False
        frmGame.picFive.Enabled = True

        frmGame.btnRoll.Visible = True
        frmGame.btnRoll.Enabled = True
        frmGame.picCup.Visible = True

        roll = 0
        turn += 1



    End Sub

    Sub returnToFalse()         'returns booleans back to false

        threeOfAKind = False
        fourOfAKind = False
        fullHouse = False
        smallStraight = False
        largeStraight = False
        yahtzeeRoll = False

    End Sub

    Sub upperScoreCalc()            'calculates the score of the upper scorecard

        upperTotalScore = Integer.Parse(frmGame.lblOnesTotalScore.Text) + Integer.Parse(frmGame.lblTwosTotalScore.Text) + Integer.Parse(frmGame.lblThreesTotalScore.Text) + Integer.Parse(frmGame.lblFoursTotalScore.Text) + Integer.Parse(frmGame.lblFivesTotalScore.Text) + Integer.Parse(frmGame.lblSixesTotalScore.Text)
        frmGame.lblUpperTotal.Text = upperTotalScore.ToString
        If upperTotalScore >= 63 And Not bonus Then
            frmGame.lblTotalUpperScore.Text = (upperTotalScore + 35).ToString
            bonus = True
            frmGame.lblBonusScore.Text = 35.ToString
        Else
            frmGame.lblTotalUpperScore.Text = upperTotalScore.ToString
            bonus = False
            frmGame.lblBonusScore.Text = 0.ToString
        End If

    End Sub

    Sub finalScore()                'calculates final score
        frmGame.btnRoll.Visible = False
        frmGame.picOne.Visible = False
        frmGame.picTwo.Visible = False
        frmGame.picThree.Visible = False
        frmGame.picFour.Visible = False
        frmGame.picFive.Visible = False
        frmGame.picCup.Visible = False
        frmGame.picDicePickOne.Visible = False
        frmGame.picDicePickTwo.Visible = False
        frmGame.picDicePickThree.Visible = False
        frmGame.picDicePickFour.Visible = False
        frmGame.picDicePickFive.Visible = False
        lowerScoreCalc = functions.lowerScoreCalculated(Integer.Parse(frmGame.lblThreeOfAKindScore.Text), Integer.Parse(frmGame.lblFourOfAKindScore.Text), Integer.Parse(frmGame.lblFullHouse.Text), Integer.Parse(frmGame.lblSmallStraight.Text), Integer.Parse(frmGame.lblLargeStraight.Text), Integer.Parse(frmGame.lblYahtzeeRollOne.Text), Integer.Parse(frmGame.lblYahtzeeBonusScore.Text), Integer.Parse(frmGame.lblChance.Text))
        finalScoreCalc = upperTotalScore + lowerScoreCalc
        frmGame.lblFinalScore.Text = finalScoreCalc.ToString
        frmGame.lblFinalScore.Visible = True
        frmGame.lblFinalScoreText.Visible = True
        frmGame.btnPlayAgain.Visible = True
    End Sub

End Module
