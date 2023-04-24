<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.picCup = New System.Windows.Forms.PictureBox()
        Me.picFive = New System.Windows.Forms.PictureBox()
        Me.picFour = New System.Windows.Forms.PictureBox()
        Me.picThree = New System.Windows.Forms.PictureBox()
        Me.picTwo = New System.Windows.Forms.PictureBox()
        Me.picOne = New System.Windows.Forms.PictureBox()
        Me.lblBonusScore = New System.Windows.Forms.Label()
        Me.lblTotalUpperScore = New System.Windows.Forms.Label()
        Me.lblUpperTotal = New System.Windows.Forms.Label()
        Me.lblFourOfAKindScore = New System.Windows.Forms.Label()
        Me.lblThreeOfAKindScore = New System.Windows.Forms.Label()
        Me.lblSixesTotalScore = New System.Windows.Forms.Label()
        Me.lblFivesTotalScore = New System.Windows.Forms.Label()
        Me.lblFoursTotalScore = New System.Windows.Forms.Label()
        Me.lblThreesTotalScore = New System.Windows.Forms.Label()
        Me.lblTwosTotalScore = New System.Windows.Forms.Label()
        Me.lblOnesTotalScore = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picDicePickFive = New System.Windows.Forms.PictureBox()
        Me.picDicePickFour = New System.Windows.Forms.PictureBox()
        Me.picDicePickThree = New System.Windows.Forms.PictureBox()
        Me.picDicePickTwo = New System.Windows.Forms.PictureBox()
        Me.picDicePickOne = New System.Windows.Forms.PictureBox()
        Me.chkThree = New System.Windows.Forms.CheckBox()
        Me.chkFive = New System.Windows.Forms.CheckBox()
        Me.chkFour = New System.Windows.Forms.CheckBox()
        Me.chkTwo = New System.Windows.Forms.CheckBox()
        Me.chkOne = New System.Windows.Forms.CheckBox()
        Me.lblFullHouse = New System.Windows.Forms.Label()
        Me.lblSmallStraight = New System.Windows.Forms.Label()
        Me.lblLargeStraight = New System.Windows.Forms.Label()
        Me.lblYahtzeeRollOne = New System.Windows.Forms.Label()
        Me.lblChance = New System.Windows.Forms.Label()
        Me.lblYahtzeeBonusCheck = New System.Windows.Forms.Label()
        Me.lblYahtzeeBonusScore = New System.Windows.Forms.Label()
        Me.lblFinalScoreText = New System.Windows.Forms.Label()
        Me.lblFinalScore = New System.Windows.Forms.Label()
        Me.btnPlayAgain = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        CType(Me.picCup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picThree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDicePickFive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDicePickFour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDicePickThree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDicePickTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDicePickOne, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(12, 734)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnRoll
        '
        Me.btnRoll.BackColor = System.Drawing.Color.Maroon
        Me.btnRoll.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoll.ForeColor = System.Drawing.Color.White
        Me.btnRoll.Location = New System.Drawing.Point(308, 539)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(124, 34)
        Me.btnRoll.TabIndex = 2
        Me.btnRoll.Text = "Roll"
        Me.btnRoll.UseVisualStyleBackColor = False
        '
        'picCup
        '
        Me.picCup.Image = Global.Yahtzee.My.Resources.Resources.yahtzee_cup
        Me.picCup.Location = New System.Drawing.Point(164, 153)
        Me.picCup.Name = "picCup"
        Me.picCup.Size = New System.Drawing.Size(427, 330)
        Me.picCup.TabIndex = 15
        Me.picCup.TabStop = False
        '
        'picFive
        '
        Me.picFive.Location = New System.Drawing.Point(430, 343)
        Me.picFive.Name = "picFive"
        Me.picFive.Size = New System.Drawing.Size(97, 97)
        Me.picFive.TabIndex = 7
        Me.picFive.TabStop = False
        '
        'picFour
        '
        Me.picFour.Location = New System.Drawing.Point(267, 310)
        Me.picFour.Name = "picFour"
        Me.picFour.Size = New System.Drawing.Size(97, 97)
        Me.picFour.TabIndex = 6
        Me.picFour.TabStop = False
        '
        'picThree
        '
        Me.picThree.Location = New System.Drawing.Point(446, 216)
        Me.picThree.Name = "picThree"
        Me.picThree.Size = New System.Drawing.Size(97, 97)
        Me.picThree.TabIndex = 5
        Me.picThree.TabStop = False
        '
        'picTwo
        '
        Me.picTwo.Location = New System.Drawing.Point(321, 153)
        Me.picTwo.Name = "picTwo"
        Me.picTwo.Size = New System.Drawing.Size(97, 97)
        Me.picTwo.TabIndex = 4
        Me.picTwo.TabStop = False
        '
        'picOne
        '
        Me.picOne.BackColor = System.Drawing.Color.Cornsilk
        Me.picOne.Location = New System.Drawing.Point(164, 199)
        Me.picOne.Name = "picOne"
        Me.picOne.Size = New System.Drawing.Size(97, 97)
        Me.picOne.TabIndex = 3
        Me.picOne.TabStop = False
        '
        'lblBonusScore
        '
        Me.lblBonusScore.AutoSize = True
        Me.lblBonusScore.BackColor = System.Drawing.Color.White
        Me.lblBonusScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBonusScore.Location = New System.Drawing.Point(984, 348)
        Me.lblBonusScore.Name = "lblBonusScore"
        Me.lblBonusScore.Size = New System.Drawing.Size(18, 20)
        Me.lblBonusScore.TabIndex = 47
        Me.lblBonusScore.Text = "0"
        '
        'lblTotalUpperScore
        '
        Me.lblTotalUpperScore.AutoSize = True
        Me.lblTotalUpperScore.BackColor = System.Drawing.Color.White
        Me.lblTotalUpperScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalUpperScore.Location = New System.Drawing.Point(975, 377)
        Me.lblTotalUpperScore.Name = "lblTotalUpperScore"
        Me.lblTotalUpperScore.Size = New System.Drawing.Size(18, 20)
        Me.lblTotalUpperScore.TabIndex = 46
        Me.lblTotalUpperScore.Text = "0"
        '
        'lblUpperTotal
        '
        Me.lblUpperTotal.AutoSize = True
        Me.lblUpperTotal.BackColor = System.Drawing.Color.White
        Me.lblUpperTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpperTotal.Location = New System.Drawing.Point(985, 319)
        Me.lblUpperTotal.Name = "lblUpperTotal"
        Me.lblUpperTotal.Size = New System.Drawing.Size(18, 20)
        Me.lblUpperTotal.TabIndex = 45
        Me.lblUpperTotal.Text = "0"
        '
        'lblFourOfAKindScore
        '
        Me.lblFourOfAKindScore.AutoSize = True
        Me.lblFourOfAKindScore.BackColor = System.Drawing.Color.White
        Me.lblFourOfAKindScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFourOfAKindScore.Location = New System.Drawing.Point(984, 473)
        Me.lblFourOfAKindScore.Name = "lblFourOfAKindScore"
        Me.lblFourOfAKindScore.Size = New System.Drawing.Size(18, 20)
        Me.lblFourOfAKindScore.TabIndex = 43
        Me.lblFourOfAKindScore.Text = "0"
        '
        'lblThreeOfAKindScore
        '
        Me.lblThreeOfAKindScore.AutoSize = True
        Me.lblThreeOfAKindScore.BackColor = System.Drawing.Color.White
        Me.lblThreeOfAKindScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThreeOfAKindScore.Location = New System.Drawing.Point(984, 441)
        Me.lblThreeOfAKindScore.Name = "lblThreeOfAKindScore"
        Me.lblThreeOfAKindScore.Size = New System.Drawing.Size(18, 20)
        Me.lblThreeOfAKindScore.TabIndex = 42
        Me.lblThreeOfAKindScore.Text = "0"
        '
        'lblSixesTotalScore
        '
        Me.lblSixesTotalScore.AutoSize = True
        Me.lblSixesTotalScore.BackColor = System.Drawing.Color.White
        Me.lblSixesTotalScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSixesTotalScore.Location = New System.Drawing.Point(984, 288)
        Me.lblSixesTotalScore.Name = "lblSixesTotalScore"
        Me.lblSixesTotalScore.Size = New System.Drawing.Size(18, 20)
        Me.lblSixesTotalScore.TabIndex = 41
        Me.lblSixesTotalScore.Text = "0"
        '
        'lblFivesTotalScore
        '
        Me.lblFivesTotalScore.AutoSize = True
        Me.lblFivesTotalScore.BackColor = System.Drawing.Color.White
        Me.lblFivesTotalScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFivesTotalScore.Location = New System.Drawing.Point(984, 255)
        Me.lblFivesTotalScore.Name = "lblFivesTotalScore"
        Me.lblFivesTotalScore.Size = New System.Drawing.Size(18, 20)
        Me.lblFivesTotalScore.TabIndex = 40
        Me.lblFivesTotalScore.Text = "0"
        '
        'lblFoursTotalScore
        '
        Me.lblFoursTotalScore.AutoSize = True
        Me.lblFoursTotalScore.BackColor = System.Drawing.Color.White
        Me.lblFoursTotalScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFoursTotalScore.Location = New System.Drawing.Point(984, 227)
        Me.lblFoursTotalScore.Name = "lblFoursTotalScore"
        Me.lblFoursTotalScore.Size = New System.Drawing.Size(18, 20)
        Me.lblFoursTotalScore.TabIndex = 39
        Me.lblFoursTotalScore.Text = "0"
        '
        'lblThreesTotalScore
        '
        Me.lblThreesTotalScore.AutoSize = True
        Me.lblThreesTotalScore.BackColor = System.Drawing.Color.White
        Me.lblThreesTotalScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThreesTotalScore.Location = New System.Drawing.Point(984, 197)
        Me.lblThreesTotalScore.Name = "lblThreesTotalScore"
        Me.lblThreesTotalScore.Size = New System.Drawing.Size(18, 20)
        Me.lblThreesTotalScore.TabIndex = 38
        Me.lblThreesTotalScore.Text = "0"
        '
        'lblTwosTotalScore
        '
        Me.lblTwosTotalScore.AutoSize = True
        Me.lblTwosTotalScore.BackColor = System.Drawing.Color.White
        Me.lblTwosTotalScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTwosTotalScore.Location = New System.Drawing.Point(984, 166)
        Me.lblTwosTotalScore.Name = "lblTwosTotalScore"
        Me.lblTwosTotalScore.Size = New System.Drawing.Size(18, 20)
        Me.lblTwosTotalScore.TabIndex = 37
        Me.lblTwosTotalScore.Text = "0"
        '
        'lblOnesTotalScore
        '
        Me.lblOnesTotalScore.AutoSize = True
        Me.lblOnesTotalScore.BackColor = System.Drawing.Color.White
        Me.lblOnesTotalScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnesTotalScore.Location = New System.Drawing.Point(984, 134)
        Me.lblOnesTotalScore.Name = "lblOnesTotalScore"
        Me.lblOnesTotalScore.Size = New System.Drawing.Size(18, 20)
        Me.lblOnesTotalScore.TabIndex = 36
        Me.lblOnesTotalScore.Text = "0"
        Me.lblOnesTotalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Yahtzee.My.Resources.Resources.Yahtzee_Scoreboard_1_01_1_small
        Me.PictureBox1.Location = New System.Drawing.Point(726, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(551, 716)
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'picDicePickFive
        '
        Me.picDicePickFive.Location = New System.Drawing.Point(583, 631)
        Me.picDicePickFive.Name = "picDicePickFive"
        Me.picDicePickFive.Size = New System.Drawing.Size(97, 97)
        Me.picDicePickFive.TabIndex = 53
        Me.picDicePickFive.TabStop = False
        Me.picDicePickFive.Visible = False
        '
        'picDicePickFour
        '
        Me.picDicePickFour.Location = New System.Drawing.Point(460, 631)
        Me.picDicePickFour.Name = "picDicePickFour"
        Me.picDicePickFour.Size = New System.Drawing.Size(97, 97)
        Me.picDicePickFour.TabIndex = 52
        Me.picDicePickFour.TabStop = False
        Me.picDicePickFour.Visible = False
        '
        'picDicePickThree
        '
        Me.picDicePickThree.Location = New System.Drawing.Point(335, 631)
        Me.picDicePickThree.Name = "picDicePickThree"
        Me.picDicePickThree.Size = New System.Drawing.Size(97, 97)
        Me.picDicePickThree.TabIndex = 51
        Me.picDicePickThree.TabStop = False
        Me.picDicePickThree.Visible = False
        '
        'picDicePickTwo
        '
        Me.picDicePickTwo.Location = New System.Drawing.Point(199, 631)
        Me.picDicePickTwo.Name = "picDicePickTwo"
        Me.picDicePickTwo.Size = New System.Drawing.Size(97, 97)
        Me.picDicePickTwo.TabIndex = 50
        Me.picDicePickTwo.TabStop = False
        Me.picDicePickTwo.Visible = False
        '
        'picDicePickOne
        '
        Me.picDicePickOne.BackColor = System.Drawing.Color.Cornsilk
        Me.picDicePickOne.Location = New System.Drawing.Point(66, 631)
        Me.picDicePickOne.Name = "picDicePickOne"
        Me.picDicePickOne.Size = New System.Drawing.Size(97, 97)
        Me.picDicePickOne.TabIndex = 49
        Me.picDicePickOne.TabStop = False
        Me.picDicePickOne.Visible = False
        '
        'chkThree
        '
        Me.chkThree.AutoSize = True
        Me.chkThree.Location = New System.Drawing.Point(446, 299)
        Me.chkThree.Name = "chkThree"
        Me.chkThree.Size = New System.Drawing.Size(15, 14)
        Me.chkThree.TabIndex = 12
        Me.chkThree.UseVisualStyleBackColor = True
        Me.chkThree.Visible = False
        '
        'chkFive
        '
        Me.chkFive.AutoSize = True
        Me.chkFive.Location = New System.Drawing.Point(430, 426)
        Me.chkFive.Name = "chkFive"
        Me.chkFive.Size = New System.Drawing.Size(15, 14)
        Me.chkFive.TabIndex = 14
        Me.chkFive.UseVisualStyleBackColor = True
        Me.chkFive.Visible = False
        '
        'chkFour
        '
        Me.chkFour.AutoSize = True
        Me.chkFour.Location = New System.Drawing.Point(267, 393)
        Me.chkFour.Name = "chkFour"
        Me.chkFour.Size = New System.Drawing.Size(15, 14)
        Me.chkFour.TabIndex = 13
        Me.chkFour.UseVisualStyleBackColor = True
        Me.chkFour.Visible = False
        '
        'chkTwo
        '
        Me.chkTwo.AutoSize = True
        Me.chkTwo.Location = New System.Drawing.Point(321, 236)
        Me.chkTwo.Name = "chkTwo"
        Me.chkTwo.Size = New System.Drawing.Size(15, 14)
        Me.chkTwo.TabIndex = 11
        Me.chkTwo.UseVisualStyleBackColor = True
        Me.chkTwo.Visible = False
        '
        'chkOne
        '
        Me.chkOne.AutoSize = True
        Me.chkOne.Location = New System.Drawing.Point(164, 282)
        Me.chkOne.Name = "chkOne"
        Me.chkOne.Size = New System.Drawing.Size(15, 14)
        Me.chkOne.TabIndex = 8
        Me.chkOne.UseVisualStyleBackColor = True
        Me.chkOne.Visible = False
        '
        'lblFullHouse
        '
        Me.lblFullHouse.AutoSize = True
        Me.lblFullHouse.BackColor = System.Drawing.Color.White
        Me.lblFullHouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullHouse.Location = New System.Drawing.Point(984, 503)
        Me.lblFullHouse.Name = "lblFullHouse"
        Me.lblFullHouse.Size = New System.Drawing.Size(18, 20)
        Me.lblFullHouse.TabIndex = 54
        Me.lblFullHouse.Text = "0"
        Me.lblFullHouse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSmallStraight
        '
        Me.lblSmallStraight.AutoSize = True
        Me.lblSmallStraight.BackColor = System.Drawing.Color.White
        Me.lblSmallStraight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSmallStraight.Location = New System.Drawing.Point(985, 532)
        Me.lblSmallStraight.Name = "lblSmallStraight"
        Me.lblSmallStraight.Size = New System.Drawing.Size(18, 20)
        Me.lblSmallStraight.TabIndex = 61
        Me.lblSmallStraight.Text = "0"
        Me.lblSmallStraight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLargeStraight
        '
        Me.lblLargeStraight.AutoSize = True
        Me.lblLargeStraight.BackColor = System.Drawing.Color.White
        Me.lblLargeStraight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLargeStraight.Location = New System.Drawing.Point(984, 562)
        Me.lblLargeStraight.Name = "lblLargeStraight"
        Me.lblLargeStraight.Size = New System.Drawing.Size(18, 20)
        Me.lblLargeStraight.TabIndex = 62
        Me.lblLargeStraight.Text = "0"
        Me.lblLargeStraight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblYahtzeeRollOne
        '
        Me.lblYahtzeeRollOne.AutoSize = True
        Me.lblYahtzeeRollOne.BackColor = System.Drawing.Color.White
        Me.lblYahtzeeRollOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYahtzeeRollOne.Location = New System.Drawing.Point(984, 591)
        Me.lblYahtzeeRollOne.Name = "lblYahtzeeRollOne"
        Me.lblYahtzeeRollOne.Size = New System.Drawing.Size(18, 20)
        Me.lblYahtzeeRollOne.TabIndex = 63
        Me.lblYahtzeeRollOne.Text = "0"
        Me.lblYahtzeeRollOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblChance
        '
        Me.lblChance.AutoSize = True
        Me.lblChance.BackColor = System.Drawing.Color.White
        Me.lblChance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChance.Location = New System.Drawing.Point(984, 620)
        Me.lblChance.Name = "lblChance"
        Me.lblChance.Size = New System.Drawing.Size(18, 20)
        Me.lblChance.TabIndex = 64
        Me.lblChance.Text = "0"
        Me.lblChance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblYahtzeeBonusCheck
        '
        Me.lblYahtzeeBonusCheck.AutoSize = True
        Me.lblYahtzeeBonusCheck.BackColor = System.Drawing.Color.White
        Me.lblYahtzeeBonusCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYahtzeeBonusCheck.Location = New System.Drawing.Point(973, 649)
        Me.lblYahtzeeBonusCheck.Name = "lblYahtzeeBonusCheck"
        Me.lblYahtzeeBonusCheck.Size = New System.Drawing.Size(0, 24)
        Me.lblYahtzeeBonusCheck.TabIndex = 65
        Me.lblYahtzeeBonusCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblYahtzeeBonusScore
        '
        Me.lblYahtzeeBonusScore.AutoSize = True
        Me.lblYahtzeeBonusScore.BackColor = System.Drawing.Color.White
        Me.lblYahtzeeBonusScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYahtzeeBonusScore.Location = New System.Drawing.Point(973, 683)
        Me.lblYahtzeeBonusScore.Name = "lblYahtzeeBonusScore"
        Me.lblYahtzeeBonusScore.Size = New System.Drawing.Size(18, 20)
        Me.lblYahtzeeBonusScore.TabIndex = 66
        Me.lblYahtzeeBonusScore.Text = "0"
        Me.lblYahtzeeBonusScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFinalScoreText
        '
        Me.lblFinalScoreText.AutoSize = True
        Me.lblFinalScoreText.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalScoreText.Location = New System.Drawing.Point(154, 129)
        Me.lblFinalScoreText.Name = "lblFinalScoreText"
        Me.lblFinalScoreText.Size = New System.Drawing.Size(441, 55)
        Me.lblFinalScoreText.TabIndex = 67
        Me.lblFinalScoreText.Text = "Your Final Score is:"
        Me.lblFinalScoreText.Visible = False
        '
        'lblFinalScore
        '
        Me.lblFinalScore.AutoSize = True
        Me.lblFinalScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalScore.ForeColor = System.Drawing.Color.Red
        Me.lblFinalScore.Location = New System.Drawing.Point(313, 258)
        Me.lblFinalScore.Name = "lblFinalScore"
        Me.lblFinalScore.Size = New System.Drawing.Size(105, 55)
        Me.lblFinalScore.TabIndex = 68
        Me.lblFinalScore.Text = "111"
        Me.lblFinalScore.Visible = False
        '
        'btnPlayAgain
        '
        Me.btnPlayAgain.BackColor = System.Drawing.Color.Maroon
        Me.btnPlayAgain.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayAgain.ForeColor = System.Drawing.Color.White
        Me.btnPlayAgain.Location = New System.Drawing.Point(272, 539)
        Me.btnPlayAgain.Name = "btnPlayAgain"
        Me.btnPlayAgain.Size = New System.Drawing.Size(173, 34)
        Me.btnPlayAgain.TabIndex = 69
        Me.btnPlayAgain.Text = "Play Again"
        Me.btnPlayAgain.UseVisualStyleBackColor = False
        Me.btnPlayAgain.Visible = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(995, 64)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(49, 20)
        Me.lblName.TabIndex = 70
        Me.lblName.Text = "name"
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(1289, 768)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnPlayAgain)
        Me.Controls.Add(Me.lblFinalScore)
        Me.Controls.Add(Me.lblFinalScoreText)
        Me.Controls.Add(Me.lblYahtzeeBonusScore)
        Me.Controls.Add(Me.lblYahtzeeBonusCheck)
        Me.Controls.Add(Me.lblChance)
        Me.Controls.Add(Me.lblYahtzeeRollOne)
        Me.Controls.Add(Me.lblLargeStraight)
        Me.Controls.Add(Me.lblSmallStraight)
        Me.Controls.Add(Me.lblFullHouse)
        Me.Controls.Add(Me.picDicePickFive)
        Me.Controls.Add(Me.picDicePickFour)
        Me.Controls.Add(Me.picDicePickThree)
        Me.Controls.Add(Me.picDicePickTwo)
        Me.Controls.Add(Me.picDicePickOne)
        Me.Controls.Add(Me.lblBonusScore)
        Me.Controls.Add(Me.lblTotalUpperScore)
        Me.Controls.Add(Me.lblUpperTotal)
        Me.Controls.Add(Me.lblFourOfAKindScore)
        Me.Controls.Add(Me.lblThreeOfAKindScore)
        Me.Controls.Add(Me.lblSixesTotalScore)
        Me.Controls.Add(Me.lblFivesTotalScore)
        Me.Controls.Add(Me.lblFoursTotalScore)
        Me.Controls.Add(Me.lblThreesTotalScore)
        Me.Controls.Add(Me.lblTwosTotalScore)
        Me.Controls.Add(Me.lblOnesTotalScore)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picCup)
        Me.Controls.Add(Me.chkFive)
        Me.Controls.Add(Me.chkFour)
        Me.Controls.Add(Me.chkThree)
        Me.Controls.Add(Me.chkTwo)
        Me.Controls.Add(Me.chkOne)
        Me.Controls.Add(Me.picFive)
        Me.Controls.Add(Me.picFour)
        Me.Controls.Add(Me.picThree)
        Me.Controls.Add(Me.picTwo)
        Me.Controls.Add(Me.picOne)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "frmGame"
        Me.Text = "Yahtzee"
        CType(Me.picCup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picThree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDicePickFive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDicePickFour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDicePickThree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDicePickTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDicePickOne, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnRoll As Button
    Friend WithEvents picOne As PictureBox
    Friend WithEvents picTwo As PictureBox
    Friend WithEvents picThree As PictureBox
    Friend WithEvents picFour As PictureBox
    Friend WithEvents picFive As PictureBox
    Friend WithEvents picCup As PictureBox
    Friend WithEvents lblBonusScore As Label
    Friend WithEvents lblTotalUpperScore As Label
    Friend WithEvents lblUpperTotal As Label
    Friend WithEvents lblFourOfAKindScore As Label
    Friend WithEvents lblThreeOfAKindScore As Label
    Friend WithEvents lblSixesTotalScore As Label
    Friend WithEvents lblFivesTotalScore As Label
    Friend WithEvents lblFoursTotalScore As Label
    Friend WithEvents lblThreesTotalScore As Label
    Friend WithEvents lblTwosTotalScore As Label
    Friend WithEvents lblOnesTotalScore As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents picDicePickFive As PictureBox
    Friend WithEvents picDicePickFour As PictureBox
    Friend WithEvents picDicePickThree As PictureBox
    Friend WithEvents picDicePickTwo As PictureBox
    Friend WithEvents picDicePickOne As PictureBox
    Friend WithEvents chkThree As CheckBox
    Friend WithEvents chkFive As CheckBox
    Friend WithEvents chkFour As CheckBox
    Friend WithEvents chkTwo As CheckBox
    Friend WithEvents chkOne As CheckBox
    Friend WithEvents lblFullHouse As Label
    Friend WithEvents lblSmallStraight As Label
    Friend WithEvents lblLargeStraight As Label
    Friend WithEvents lblYahtzeeRollOne As Label
    Friend WithEvents lblChance As Label
    Friend WithEvents lblYahtzeeBonusCheck As Label
    Friend WithEvents lblYahtzeeBonusScore As Label
    Friend WithEvents lblFinalScoreText As Label
    Friend WithEvents lblFinalScore As Label
    Friend WithEvents btnPlayAgain As Button
    Friend WithEvents lblName As Label
End Class
