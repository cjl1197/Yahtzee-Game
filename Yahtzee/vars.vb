Module vars

    Public roll As Integer = 0 'keeps track of the number of rolls per turn

    Public numYahtzee As Integer = 0
    Public checkMark As Char = ChrW(&H2713)
    Public yahtzeeBonusScore As Integer = 0
    Public turn As Integer = 1

    ' variable holds the number of the dice rolled
    Public picOneScore As Integer = 0
    Public picTwoScore As Integer = 0
    Public picThreeScore As Integer = 0
    Public picFourScore As Integer = 0
    Public picFiveScore As Integer = 0


    ' variables for holding scores
    Public totalScoreOnes As Integer = 0
    Public totalScoreTwos As Integer = 0
    Public totalScoreThrees As Integer = 0
    Public totalScoreFours As Integer = 0
    Public totalScoreFives As Integer = 0
    Public totalScoreSixes As Integer = 0
    Public totalScoreAllDice As Integer = 0
    Public lowerScoreCalc As Integer = 0
    Public upperTotalScore As Integer = 0
    Public finalScoreCalc As Integer = 0

    ' boolean variables for checking if certain scores are met
    Public threeOfAKind As Boolean = False
    Public fourOfAKind As Boolean = False
    Public fullHouse As Boolean = False
    Public smallStraight As Boolean = False
    Public largeStraight As Boolean = False
    Public yahtzeeRoll As Boolean = False
    Public bonus As Boolean = False

End Module
