Option Explicit On
Option Strict On

Public Class frmGame


    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click  'rolls the dice



        picCup.Visible = False

        Const intMax As Integer = 5
        Dim intRoll(intMax) As Integer
        Dim intCount As Integer
        Dim rand As New Random

        Dim dice(6) As Image    'array of dice png's

        dice(0) = Yahtzee.My.Resources.Resources.dice1
        dice(1) = Yahtzee.My.Resources.Resources.dice2
        dice(2) = Yahtzee.My.Resources.Resources.dice3
        dice(3) = Yahtzee.My.Resources.Resources.dice4
        dice(4) = Yahtzee.My.Resources.Resources.dice5
        dice(5) = Yahtzee.My.Resources.Resources.dice6

        threeOfAKind = False
        fourOfAKind = False
        fullHouse = False
        smallStraight = False
        largeStraight = False


        If roll <= 2 Then


            btnRoll.Visible = True


            For intCount = 0 To intMax
                intRoll(intCount) = rand.Next(6)
            Next

            If picOne.Enabled = True Then
                picOne.Image = dice(intRoll(0))
                picDicePickOne.Image = dice(intRoll(0))
                picOneScore = intRoll(0) + 1
            End If

            If picTwo.Enabled = True Then
                picTwo.Image = dice(intRoll(1))
                picDicePickTwo.Image = dice(intRoll(1))
                picTwoScore = intRoll(1) + 1
            End If

            If picThree.Enabled = True Then
                picThree.Image = dice(intRoll(2))
                picDicePickThree.Image = dice(intRoll(2))
                picThreeScore = intRoll(2) + 1
            End If

            If picFour.Enabled = True Then
                picFour.Image = dice(intRoll(3))
                picDicePickFour.Image = dice(intRoll(3))
                picFourScore = intRoll(3) + 1
            End If

            If picFive.Enabled = True Then
                picFive.Image = dice(intRoll(4))
                picDicePickFive.Image = dice(intRoll(4))
                picFiveScore = intRoll(4) + 1
            End If


            roll += 1

        End If

        If roll = 3 Then


            btnRoll.Visible = False


            For intCount = 0 To intMax
                intRoll(intCount) = rand.Next(6)
            Next

            If picOne.Enabled = True Then
                picOne.Image = dice(intRoll(0))
                picOneScore = intRoll(0) + 1
            End If

            If picTwo.Enabled = True Then
                picTwo.Image = dice(intRoll(1))
                picTwoScore = intRoll(1) + 1
            End If

            If picThree.Enabled = True Then
                picThree.Image = dice(intRoll(2))
                picThreeScore = intRoll(2) + 1
            End If

            If picFour.Enabled = True Then
                picFour.Image = dice(intRoll(3))
                picFourScore = intRoll(3) + 1
            End If

            If picFive.Enabled = True Then
                picFive.Image = dice(intRoll(4))
                picFiveScore = intRoll(4) + 1
            End If

            btnRoll.Enabled = False
            btnRoll.Visible = False


            picOne.Enabled = False
            picTwo.Enabled = False
            picThree.Enabled = False
            picFour.Enabled = False
            picFive.Enabled = False

        End If



        calcScore()



    End Sub



    Private Sub lblOnesScore_Click(sender As Object, e As EventArgs) Handles lblOnesTotalScore.Click    ' set's score for Ones
        check()
        If numYahtzee >= 2 And totalScoreOnes = 0 Then
            lblOnesTotalScore.Text = 0.ToString
        ElseIf numYahtzee >= 2 And totalScoreOnes > 0 Then
            lblOnesTotalScore.Text = totalScoreOnes.ToString
        Else
            lblOnesTotalScore.Text = totalScoreOnes.ToString
        End If

        lblOnesTotalScore.ForeColor = Color.Black
        lblOnesTotalScore.Enabled = False
        upperScoreCalc()
        yahtzeeBonus()
        returnToFalse()
        If turn <= 12 Then
            nextRoll()
        Else
            finalScore()
        End If
    End Sub

    Private Sub lblTwosTotalScore_Click(sender As Object, e As EventArgs) Handles lblTwosTotalScore.Click           'set's score for Twos
        check()
        If numYahtzee >= 2 And totalScoreTwos = 0 Then
            lblTwosTotalScore.Text = 0.ToString
        ElseIf numYahtzee >= 2 And totalScoreTwos > 0 Then
            lblTwosTotalScore.Text = totalScoreTwos.ToString
        Else
            lblTwosTotalScore.Text = totalScoreTwos.ToString
        End If

        lblTwosTotalScore.ForeColor = Color.Black
        lblTwosTotalScore.Enabled = False
        upperScoreCalc()
        yahtzeeBonus()
        returnToFalse()
        If turn <= 12 Then
            nextRoll()
        Else
            finalScore()
        End If

    End Sub

    Private Sub lblThreesTotalScore_Click(sender As Object, e As EventArgs) Handles lblThreesTotalScore.Click           'set's score for Threes
        check()
        If numYahtzee >= 2 And totalScoreThrees = 0 Then
            lblThreesTotalScore.Text = 0.ToString
        ElseIf numYahtzee >= 2 And totalScoreThrees > 0 Then
            lblThreesTotalScore.Text = totalScoreThrees.ToString
        Else
            lblThreesTotalScore.Text = totalScoreThrees.ToString
        End If

        lblThreesTotalScore.ForeColor = Color.Black
        lblThreesTotalScore.Enabled = False
        upperScoreCalc()
        yahtzeeBonus()
        returnToFalse()
        If turn <= 12 Then
            nextRoll()
        Else
            finalScore()
        End If

    End Sub

    Private Sub lblFoursTotalScore_Click(sender As Object, e As EventArgs) Handles lblFoursTotalScore.Click         'set's score for Fours
        check()
        If numYahtzee >= 2 And totalScoreFours = 0 Then
            lblFoursTotalScore.Text = 0.ToString
        ElseIf numYahtzee >= 2 And totalScoreFours > 0 Then
            lblFoursTotalScore.Text = totalScoreFours.ToString
        Else
            lblFoursTotalScore.Text = totalScoreFours.ToString
        End If

        lblFoursTotalScore.ForeColor = Color.Black
        lblFoursTotalScore.Enabled = False
        upperScoreCalc()
        yahtzeeBonus()
        returnToFalse()
        If turn <= 12 Then
            nextRoll()
        Else
            finalScore()
        End If
    End Sub

    Private Sub lblFivesTotalScore_Click(sender As Object, e As EventArgs) Handles lblFivesTotalScore.Click         'set's score for Fives
        check()
        If numYahtzee >= 2 And totalScoreFives = 0 Then
            lblFivesTotalScore.Text = 0.ToString
        ElseIf numYahtzee >= 2 And totalScoreFives > 0 Then
            lblFivesTotalScore.Text = totalScoreFives.ToString
        Else
            lblFivesTotalScore.Text = totalScoreFives.ToString
        End If

        lblFivesTotalScore.ForeColor = Color.Black
        lblFivesTotalScore.Enabled = False
        upperScoreCalc()
        yahtzeeBonus()
        returnToFalse()
        If turn <= 12 Then
            nextRoll()
        Else
            finalScore()
        End If
    End Sub

    Private Sub lblSixesTotalScore_Click(sender As Object, e As EventArgs) Handles lblSixesTotalScore.Click         'set's score for Sixes
        check()
        If numYahtzee >= 2 And totalScoreSixes = 0 Then
            lblSixesTotalScore.Text = 0.ToString
        ElseIf numYahtzee >= 2 And totalScoreSixes > 0 Then
            lblSixesTotalScore.Text = totalScoreSixes.ToString
        Else
            lblSixesTotalScore.Text = totalScoreSixes.ToString
        End If

        lblSixesTotalScore.ForeColor = Color.Black
        lblSixesTotalScore.Enabled = False
        upperScoreCalc()
        yahtzeeBonus()
        returnToFalse()
        If turn <= 12 Then
            nextRoll()
        Else
            finalScore()
        End If
    End Sub

    Private Sub lblThreeOfAKindScore_Click(sender As Object, e As EventArgs) Handles lblThreeOfAKindScore.Click         'set's score for Three of A Kind
        check()
        If threeOfAKind Or numYahtzee > 0 Then
            lblThreeOfAKindScore.Text = totalScoreAllDice.ToString
        Else
            lblThreeOfAKindScore.Text = 0.ToString
        End If
        lblThreeOfAKindScore.ForeColor = Color.Black
        lblThreeOfAKindScore.Enabled = False
        upperScoreCalc()
        yahtzeeBonus()
        returnToFalse()
        If turn <= 12 Then
            nextRoll()
        Else
            finalScore()
        End If
    End Sub

    Private Sub lblFourOfAKindScore_Click(sender As Object, e As EventArgs) Handles lblFourOfAKindScore.Click           'set's score for Four of A Kind
        check()
        If fourOfAKind Or numYahtzee > 0 Then
            lblFourOfAKindScore.Text = totalScoreAllDice.ToString
        Else
            lblFourOfAKindScore.Text = 0.ToString
        End If
        lblFourOfAKindScore.ForeColor = Color.Black
        lblFourOfAKindScore.Enabled = False
        upperScoreCalc()
        yahtzeeBonus()
        returnToFalse()
        If turn <= 12 Then
            nextRoll()
        Else
            finalScore()
        End If

    End Sub

    Private Sub lblFullHouse_Click(sender As Object, e As EventArgs) Handles lblFullHouse.Click         'set's score for Full House
        check()
        If fullHouse Or numYahtzee > 0 Then
            lblFullHouse.Text = 25.ToString
        Else
            lblFullHouse.Text = 0.ToString
        End If
        lblFullHouse.ForeColor = Color.Black
        lblFullHouse.Enabled = False
        upperScoreCalc()
        yahtzeeBonus()
        returnToFalse()
        If turn <= 12 Then
            nextRoll()
        Else
            finalScore()
        End If


    End Sub

    Private Sub lblSmallStraight_Click(sender As Object, e As EventArgs) Handles lblSmallStraight.Click         'set's score for Small Straight
        check()
        If smallStraight Or numYahtzee > 0 Then
            lblSmallStraight.Text = 30.ToString
        Else
            lblSmallStraight.Text = 0.ToString
        End If
        lblSmallStraight.ForeColor = Color.Black
        lblSmallStraight.Enabled = False
        upperScoreCalc()
        yahtzeeBonus()
        returnToFalse()
        If turn <= 12 Then
            nextRoll()
        Else
            finalScore()
        End If
    End Sub

    Private Sub lblLargeStraight_Click(sender As Object, e As EventArgs) Handles lblLargeStraight.Click             'set's score for Large Straight
        check()
        If largeStraight Or numYahtzee > 0 Then
            lblLargeStraight.Text = 40.ToString
        Else
            lblLargeStraight.Text = 0.ToString
        End If
        lblLargeStraight.ForeColor = Color.Black
        lblLargeStraight.Enabled = False
        upperScoreCalc()
        yahtzeeBonus()
        returnToFalse()
        If turn <= 12 Then
            nextRoll()
        Else
            finalScore()
        End If
    End Sub

    Private Sub lblYahtzeeRollOne_Click(sender As Object, e As EventArgs) Handles lblYahtzeeRollOne.Click       'set's score for Yahtzee
        check()
        If yahtzeeRoll Then
            lblYahtzeeRollOne.Text = 50.ToString
        Else
            lblYahtzeeRollOne.Text = 0.ToString
        End If
        lblYahtzeeRollOne.ForeColor = Color.Black
        lblYahtzeeRollOne.Enabled = False
        upperScoreCalc()
        yahtzeeBonus()
        returnToFalse()
        If turn <= 12 Then
            nextRoll()
        Else
            finalScore()
        End If
    End Sub

    Private Sub lblChance_Click(sender As Object, e As EventArgs) Handles lblChance.Click           'set's score for Chance
        check()
        lblChance.Text = totalScoreAllDice.ToString
        lblChance.ForeColor = Color.Black
        lblChance.Enabled = False
        upperScoreCalc()
        yahtzeeBonus()
        returnToFalse()
        If turn <= 12 Then
            nextRoll()
        Else
            finalScore()
        End If
    End Sub

    Private Sub picDicePickOne_Click(sender As Object, e As EventArgs) Handles picDicePickOne.Click     'swaps dice one from bottom to top
        picDicePickOne.Visible = False
        picOne.Visible = True
        chkOne.Checked = False
        picOne.Enabled = True
    End Sub

    Private Sub picDicePickTwo_Click(sender As Object, e As EventArgs) Handles picDicePickTwo.Click     'swaps dice two from bottom to top
        picDicePickTwo.Visible = False
        picTwo.Visible = True
        chkTwo.Checked = False
        picTwo.Enabled = True
    End Sub

    Private Sub picDicePickThree_Click(sender As Object, e As EventArgs) Handles picDicePickThree.Click     'swaps dice three from bottom to top
        picDicePickThree.Visible = False
        picThree.Visible = True
        chkThree.Checked = False
        picThree.Enabled = True
    End Sub

    Private Sub picDicePickFour_Click(sender As Object, e As EventArgs) Handles picDicePickFour.Click       'swaps dice four from bottom to top
        picDicePickFour.Visible = False
        picFour.Visible = True
        chkFour.Checked = False
        picFour.Enabled = True
    End Sub

    Private Sub picDicePickFive_Click(sender As Object, e As EventArgs) Handles picDicePickFive.Click       'swaps dice five from bottom to top
        picDicePickFive.Visible = False
        picFive.Visible = True
        chkFive.Checked = False
        picFive.Enabled = True
    End Sub

    Private Sub picOne_Click(sender As Object, e As EventArgs) Handles picOne.Click     'swaps dice one from top to bottom

        picOne.Enabled = False
        picOne.Visible = False
        chkOne.Visible = False
        picDicePickOne.Visible = True

    End Sub

    Private Sub picTwo_Click(sender As Object, e As EventArgs) Handles picTwo.Click     'swaps dice two from top to bottom
        picTwo.Enabled = False
        picTwo.Visible = False
        chkTwo.Visible = False
        picDicePickTwo.Visible = True
    End Sub

    Private Sub picThree_Click(sender As Object, e As EventArgs) Handles picThree.Click     'swaps dice three from top to bottom
        picThree.Enabled = False
        picThree.Visible = False
        chkThree.Visible = False
        picDicePickThree.Visible = True
    End Sub

    Private Sub picFour_Click(sender As Object, e As EventArgs) Handles picFour.Click       'swaps dice four from top to bottom
        picFour.Enabled = False
        picFour.Visible = False
        chkFour.Visible = False
        picDicePickFour.Visible = True
    End Sub

    Private Sub picFive_Click(sender As Object, e As EventArgs) Handles picFive.Click       'swaps dice five from top to bottom
        picFive.Enabled = False
        picFive.Visible = False
        chkFive.Visible = False
        picDicePickFive.Visible = True
    End Sub

    Private Sub btnPlayAgain_Click(sender As Object, e As EventArgs) Handles btnPlayAgain.Click         'restarts the application
        Application.Restart()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click 'closes the program
        Me.Close()
        frmMain.Close()
    End Sub

    Private Sub game_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
End Class