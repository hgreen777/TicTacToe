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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.es1 = New System.Windows.Forms.PictureBox()
        Me.es2 = New System.Windows.Forms.PictureBox()
        Me.es3 = New System.Windows.Forms.PictureBox()
        Me.es6 = New System.Windows.Forms.PictureBox()
        Me.es5 = New System.Windows.Forms.PictureBox()
        Me.es4 = New System.Windows.Forms.PictureBox()
        Me.es8 = New System.Windows.Forms.PictureBox()
        Me.es9 = New System.Windows.Forms.PictureBox()
        Me.es7 = New System.Windows.Forms.PictureBox()
        Me.turn = New System.Windows.Forms.PictureBox()
        Me.Reset = New System.Windows.Forms.PictureBox()
        Me.blurScreen = New System.Windows.Forms.PictureBox()
        Me.Home = New System.Windows.Forms.PictureBox()
        Me.winText = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.es1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.es2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.es3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.es6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.es5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.es4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.es8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.es9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.es7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.turn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blurScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Home, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.winText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.TicTacToe.My.Resources.Resources.gameCross1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 100)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(500, 500)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'es1
        '
        Me.es1.BackColor = System.Drawing.Color.Transparent
        Me.es1.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        Me.es1.Location = New System.Drawing.Point(0, 115)
        Me.es1.Name = "es1"
        Me.es1.Size = New System.Drawing.Size(145, 137)
        Me.es1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.es1.TabIndex = 1
        Me.es1.TabStop = False
        '
        'es2
        '
        Me.es2.BackColor = System.Drawing.Color.Transparent
        Me.es2.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        Me.es2.Location = New System.Drawing.Point(184, 115)
        Me.es2.Name = "es2"
        Me.es2.Size = New System.Drawing.Size(145, 137)
        Me.es2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.es2.TabIndex = 2
        Me.es2.TabStop = False
        '
        'es3
        '
        Me.es3.BackColor = System.Drawing.Color.Transparent
        Me.es3.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        Me.es3.Location = New System.Drawing.Point(365, 116)
        Me.es3.Name = "es3"
        Me.es3.Size = New System.Drawing.Size(145, 137)
        Me.es3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.es3.TabIndex = 3
        Me.es3.TabStop = False
        '
        'es6
        '
        Me.es6.BackColor = System.Drawing.Color.Transparent
        Me.es6.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        Me.es6.Location = New System.Drawing.Point(365, 291)
        Me.es6.Name = "es6"
        Me.es6.Size = New System.Drawing.Size(145, 137)
        Me.es6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.es6.TabIndex = 4
        Me.es6.TabStop = False
        '
        'es5
        '
        Me.es5.BackColor = System.Drawing.Color.Transparent
        Me.es5.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        Me.es5.Location = New System.Drawing.Point(184, 291)
        Me.es5.Name = "es5"
        Me.es5.Size = New System.Drawing.Size(145, 137)
        Me.es5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.es5.TabIndex = 5
        Me.es5.TabStop = False
        '
        'es4
        '
        Me.es4.BackColor = System.Drawing.Color.Transparent
        Me.es4.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        Me.es4.Location = New System.Drawing.Point(0, 291)
        Me.es4.Name = "es4"
        Me.es4.Size = New System.Drawing.Size(145, 137)
        Me.es4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.es4.TabIndex = 6
        Me.es4.TabStop = False
        '
        'es8
        '
        Me.es8.BackColor = System.Drawing.Color.Transparent
        Me.es8.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        Me.es8.Location = New System.Drawing.Point(184, 464)
        Me.es8.Name = "es8"
        Me.es8.Size = New System.Drawing.Size(145, 137)
        Me.es8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.es8.TabIndex = 7
        Me.es8.TabStop = False
        '
        'es9
        '
        Me.es9.BackColor = System.Drawing.Color.Transparent
        Me.es9.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        Me.es9.Location = New System.Drawing.Point(365, 464)
        Me.es9.Name = "es9"
        Me.es9.Size = New System.Drawing.Size(145, 137)
        Me.es9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.es9.TabIndex = 8
        Me.es9.TabStop = False
        '
        'es7
        '
        Me.es7.BackColor = System.Drawing.Color.Transparent
        Me.es7.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        Me.es7.Location = New System.Drawing.Point(0, 464)
        Me.es7.Name = "es7"
        Me.es7.Size = New System.Drawing.Size(145, 137)
        Me.es7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.es7.TabIndex = 9
        Me.es7.TabStop = False
        '
        'turn
        '
        Me.turn.BackColor = System.Drawing.Color.Transparent
        Me.turn.Image = Global.TicTacToe.My.Resources.Resources.turn_text
        Me.turn.Location = New System.Drawing.Point(374, 63)
        Me.turn.Name = "turn"
        Me.turn.Size = New System.Drawing.Size(124, 39)
        Me.turn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.turn.TabIndex = 10
        Me.turn.TabStop = False
        '
        'Reset
        '
        Me.Reset.Image = Global.TicTacToe.My.Resources.Resources.new_reset
        Me.Reset.Location = New System.Drawing.Point(270, 422)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(164, 53)
        Me.Reset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Reset.TabIndex = 11
        Me.Reset.TabStop = False
        '
        'blurScreen
        '
        Me.blurScreen.BackColor = System.Drawing.Color.Transparent
        Me.blurScreen.Image = Global.TicTacToe.My.Resources.Resources.blurScreen
        Me.blurScreen.Location = New System.Drawing.Point(0, 100)
        Me.blurScreen.Name = "blurScreen"
        Me.blurScreen.Size = New System.Drawing.Size(500, 500)
        Me.blurScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.blurScreen.TabIndex = 12
        Me.blurScreen.TabStop = False
        '
        'Home
        '
        Me.Home.BackColor = System.Drawing.Color.Transparent
        Me.Home.Image = Global.TicTacToe.My.Resources.Resources.new_home
        Me.Home.Location = New System.Drawing.Point(79, 422)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(164, 53)
        Me.Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Home.TabIndex = 14
        Me.Home.TabStop = False
        '
        'winText
        '
        Me.winText.BackColor = System.Drawing.Color.Transparent
        Me.winText.Image = Global.TicTacToe.My.Resources.Resources.newXwins
        Me.winText.Location = New System.Drawing.Point(0, 227)
        Me.winText.Name = "winText"
        Me.winText.Size = New System.Drawing.Size(500, 147)
        Me.winText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.winText.TabIndex = 15
        Me.winText.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.TicTacToe.My.Resources.Resources.smaller_backbutton
        Me.PictureBox2.Location = New System.Drawing.Point(12, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 47)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.TicTacToe.My.Resources.Resources.gbtitle
        Me.PictureBox3.Location = New System.Drawing.Point(107, 7)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(301, 55)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 17
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.TicTacToe.My.Resources.Resources.smallersettings
        Me.PictureBox4.Location = New System.Drawing.Point(438, 7)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 18
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = Global.TicTacToe.My.Resources.Resources.winScore
        Me.PictureBox5.Location = New System.Drawing.Point(-2, 60)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(361, 39)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 19
        Me.PictureBox5.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(139, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 34)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "200"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(320, 65)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 34)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "200"
        '
        'GameBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.TicTacToe.My.Resources.Resources.bricks2
        Me.ClientSize = New System.Drawing.Size(500, 599)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.winText)
        Me.Controls.Add(Me.Home)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.blurScreen)
        Me.Controls.Add(Me.turn)
        Me.Controls.Add(Me.es7)
        Me.Controls.Add(Me.es9)
        Me.Controls.Add(Me.es8)
        Me.Controls.Add(Me.es4)
        Me.Controls.Add(Me.es5)
        Me.Controls.Add(Me.es6)
        Me.Controls.Add(Me.es3)
        Me.Controls.Add(Me.es2)
        Me.Controls.Add(Me.es1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(516, 638)
        Me.MinimumSize = New System.Drawing.Size(516, 638)
        Me.Name = "GameBoard"
        Me.Text = "GameBoard"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.es1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.es2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.es3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.es6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.es5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.es4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.es8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.es9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.es7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.turn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blurScreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Home, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.winText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
