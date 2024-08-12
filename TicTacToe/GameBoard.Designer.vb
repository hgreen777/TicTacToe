<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameBoard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameBoard))
        PictureBox1 = New PictureBox()
        es1 = New PictureBox()
        es2 = New PictureBox()
        es3 = New PictureBox()
        es6 = New PictureBox()
        es5 = New PictureBox()
        es4 = New PictureBox()
        es8 = New PictureBox()
        es9 = New PictureBox()
        es7 = New PictureBox()
        turn = New PictureBox()
        Reset = New PictureBox()
        blurScreen = New PictureBox()
        Home = New PictureBox()
        winText = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(es1, ComponentModel.ISupportInitialize).BeginInit()
        CType(es2, ComponentModel.ISupportInitialize).BeginInit()
        CType(es3, ComponentModel.ISupportInitialize).BeginInit()
        CType(es6, ComponentModel.ISupportInitialize).BeginInit()
        CType(es5, ComponentModel.ISupportInitialize).BeginInit()
        CType(es4, ComponentModel.ISupportInitialize).BeginInit()
        CType(es8, ComponentModel.ISupportInitialize).BeginInit()
        CType(es9, ComponentModel.ISupportInitialize).BeginInit()
        CType(es7, ComponentModel.ISupportInitialize).BeginInit()
        CType(turn, ComponentModel.ISupportInitialize).BeginInit()
        CType(Reset, ComponentModel.ISupportInitialize).BeginInit()
        CType(blurScreen, ComponentModel.ISupportInitialize).BeginInit()
        CType(Home, ComponentModel.ISupportInitialize).BeginInit()
        CType(winText, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.gameCross1
        PictureBox1.Location = New Point(0, 100)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(500, 500)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' es1
        ' 
        es1.BackColor = Color.Transparent
        es1.Image = My.Resources.Resources.emptySquare
        es1.Location = New Point(0, 115)
        es1.Name = "es1"
        es1.Size = New Size(145, 137)
        es1.SizeMode = PictureBoxSizeMode.AutoSize
        es1.TabIndex = 1
        es1.TabStop = False
        ' 
        ' es2
        ' 
        es2.BackColor = Color.Transparent
        es2.Image = My.Resources.Resources.emptySquare
        es2.Location = New Point(184, 115)
        es2.Name = "es2"
        es2.Size = New Size(145, 137)
        es2.SizeMode = PictureBoxSizeMode.AutoSize
        es2.TabIndex = 2
        es2.TabStop = False
        ' 
        ' es3
        ' 
        es3.BackColor = Color.Transparent
        es3.Image = My.Resources.Resources.emptySquare
        es3.Location = New Point(365, 116)
        es3.Name = "es3"
        es3.Size = New Size(145, 137)
        es3.SizeMode = PictureBoxSizeMode.AutoSize
        es3.TabIndex = 3
        es3.TabStop = False
        ' 
        ' es6
        ' 
        es6.BackColor = Color.Transparent
        es6.Image = My.Resources.Resources.emptySquare
        es6.Location = New Point(365, 291)
        es6.Name = "es6"
        es6.Size = New Size(145, 137)
        es6.SizeMode = PictureBoxSizeMode.AutoSize
        es6.TabIndex = 4
        es6.TabStop = False
        ' 
        ' es5
        ' 
        es5.BackColor = Color.Transparent
        es5.Image = My.Resources.Resources.emptySquare
        es5.Location = New Point(184, 291)
        es5.Name = "es5"
        es5.Size = New Size(145, 137)
        es5.SizeMode = PictureBoxSizeMode.AutoSize
        es5.TabIndex = 5
        es5.TabStop = False
        ' 
        ' es4
        ' 
        es4.BackColor = Color.Transparent
        es4.Image = My.Resources.Resources.emptySquare
        es4.Location = New Point(0, 291)
        es4.Name = "es4"
        es4.Size = New Size(145, 137)
        es4.SizeMode = PictureBoxSizeMode.AutoSize
        es4.TabIndex = 6
        es4.TabStop = False
        ' 
        ' es8
        ' 
        es8.BackColor = Color.Transparent
        es8.Image = My.Resources.Resources.emptySquare
        es8.Location = New Point(184, 464)
        es8.Name = "es8"
        es8.Size = New Size(145, 137)
        es8.SizeMode = PictureBoxSizeMode.AutoSize
        es8.TabIndex = 7
        es8.TabStop = False
        ' 
        ' es9
        ' 
        es9.BackColor = Color.Transparent
        es9.Image = My.Resources.Resources.emptySquare
        es9.Location = New Point(365, 464)
        es9.Name = "es9"
        es9.Size = New Size(145, 137)
        es9.SizeMode = PictureBoxSizeMode.AutoSize
        es9.TabIndex = 8
        es9.TabStop = False
        ' 
        ' es7
        ' 
        es7.BackColor = Color.Transparent
        es7.Image = My.Resources.Resources.emptySquare
        es7.Location = New Point(0, 464)
        es7.Name = "es7"
        es7.Size = New Size(145, 137)
        es7.SizeMode = PictureBoxSizeMode.AutoSize
        es7.TabIndex = 9
        es7.TabStop = False
        ' 
        ' turn
        ' 
        turn.BackColor = Color.Transparent
        turn.Image = My.Resources.Resources.turn_text
        turn.Location = New Point(374, 63)
        turn.Name = "turn"
        turn.Size = New Size(124, 39)
        turn.SizeMode = PictureBoxSizeMode.AutoSize
        turn.TabIndex = 10
        turn.TabStop = False
        ' 
        ' Reset
        ' 
        Reset.Image = My.Resources.Resources.new_reset
        Reset.Location = New Point(270, 422)
        Reset.Name = "Reset"
        Reset.Size = New Size(164, 53)
        Reset.SizeMode = PictureBoxSizeMode.AutoSize
        Reset.TabIndex = 11
        Reset.TabStop = False
        ' 
        ' blurScreen
        ' 
        blurScreen.BackColor = Color.Transparent
        blurScreen.Image = My.Resources.Resources.blurScreen
        blurScreen.Location = New Point(0, 100)
        blurScreen.Name = "blurScreen"
        blurScreen.Size = New Size(500, 500)
        blurScreen.SizeMode = PictureBoxSizeMode.AutoSize
        blurScreen.TabIndex = 12
        blurScreen.TabStop = False
        blurScreen.Visible = False
        ' 
        ' Home
        ' 
        Home.BackColor = Color.Transparent
        Home.Image = My.Resources.Resources.new_home
        Home.Location = New Point(79, 422)
        Home.Name = "Home"
        Home.Size = New Size(164, 53)
        Home.SizeMode = PictureBoxSizeMode.AutoSize
        Home.TabIndex = 14
        Home.TabStop = False
        ' 
        ' winText
        ' 
        winText.BackColor = Color.Transparent
        winText.Image = My.Resources.Resources.newXwins
        winText.Location = New Point(0, 227)
        winText.Name = "winText"
        winText.Size = New Size(500, 147)
        winText.SizeMode = PictureBoxSizeMode.AutoSize
        winText.TabIndex = 15
        winText.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.smaller_backbutton
        PictureBox2.Location = New Point(12, 7)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(75, 47)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 16
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = My.Resources.Resources.gbtitle
        PictureBox3.Location = New Point(107, 7)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(301, 55)
        PictureBox3.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox3.TabIndex = 17
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = My.Resources.Resources.smallersettings
        PictureBox4.Location = New Point(438, 7)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(50, 50)
        PictureBox4.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox4.TabIndex = 18
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.Image = My.Resources.Resources.winScore
        PictureBox5.Location = New Point(-2, 60)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(361, 39)
        PictureBox5.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox5.TabIndex = 19
        PictureBox5.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Calibri", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(139, 65)
        Label2.Margin = New Padding(0)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 34)
        Label2.TabIndex = 21
        Label2.Text = "200"
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Calibri", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(320, 65)
        Label1.Margin = New Padding(0)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 34)
        Label1.TabIndex = 23
        Label1.Text = "200"
        ' 
        ' GameBoard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        BackgroundImage = My.Resources.Resources.bricks2
        ClientSize = New Size(500, 599)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(winText)
        Controls.Add(Home)
        Controls.Add(Reset)
        Controls.Add(blurScreen)
        Controls.Add(turn)
        Controls.Add(es7)
        Controls.Add(es9)
        Controls.Add(es8)
        Controls.Add(es4)
        Controls.Add(es5)
        Controls.Add(es6)
        Controls.Add(es3)
        Controls.Add(es2)
        Controls.Add(es1)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox5)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximumSize = New Size(516, 638)
        MinimumSize = New Size(516, 638)
        Name = "GameBoard"
        Text = "GameBoard"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(es1, ComponentModel.ISupportInitialize).EndInit()
        CType(es2, ComponentModel.ISupportInitialize).EndInit()
        CType(es3, ComponentModel.ISupportInitialize).EndInit()
        CType(es6, ComponentModel.ISupportInitialize).EndInit()
        CType(es5, ComponentModel.ISupportInitialize).EndInit()
        CType(es4, ComponentModel.ISupportInitialize).EndInit()
        CType(es8, ComponentModel.ISupportInitialize).EndInit()
        CType(es9, ComponentModel.ISupportInitialize).EndInit()
        CType(es7, ComponentModel.ISupportInitialize).EndInit()
        CType(turn, ComponentModel.ISupportInitialize).EndInit()
        CType(Reset, ComponentModel.ISupportInitialize).EndInit()
        CType(blurScreen, ComponentModel.ISupportInitialize).EndInit()
        CType(Home, ComponentModel.ISupportInitialize).EndInit()
        CType(winText, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents es1 As PictureBox
    Friend WithEvents es2 As PictureBox
    Friend WithEvents es3 As PictureBox
    Friend WithEvents es6 As PictureBox
    Friend WithEvents es5 As PictureBox
    Friend WithEvents es4 As PictureBox
    Friend WithEvents es8 As PictureBox
    Friend WithEvents es9 As PictureBox
    Friend WithEvents es7 As PictureBox
    Friend WithEvents turn As PictureBox
    Friend WithEvents Reset As PictureBox
    Friend WithEvents blurScreen As PictureBox
    Friend WithEvents Home As PictureBox
    Friend WithEvents winText As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
