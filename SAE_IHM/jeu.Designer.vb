﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class jeu
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.char_guess = New System.Windows.Forms.Label()
        Me.char_jouable = New System.Windows.Forms.Label()
        Me.btn_deviner = New System.Windows.Forms.Button()
        Me.label_mastermind = New System.Windows.Forms.Label()
        Me.Code_Couleur = New System.Windows.Forms.Label()
        Me.Absent = New System.Windows.Forms.Label()
        Me.Present = New System.Windows.Forms.Label()
        Me.Present_et_Bien_Place = New System.Windows.Forms.Label()
        Me.Btn_revanche = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_textbox = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.textbox10 = New System.Windows.Forms.TextBox()
        Me.Compteur = New System.Windows.Forms.Label()
        Me.Label_e_restant = New System.Windows.Forms.Label()
        Me.Label_temps = New System.Windows.Forms.Label()
        Me.Label_timer = New System.Windows.Forms.Label()
        Me.RichTextBox_deviner = New System.Windows.Forms.RichTextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.its_fine_picture = New System.Windows.Forms.PictureBox()
        Me.lb_pov = New System.Windows.Forms.Label()
        Me.pp_thinking_img = New System.Windows.Forms.PictureBox()
        Me.Panel_textbox.SuspendLayout()
        CType(Me.its_fine_picture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pp_thinking_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'char_guess
        '
        Me.char_guess.AutoSize = True
        Me.char_guess.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.char_guess.Location = New System.Drawing.Point(598, 387)
        Me.char_guess.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.char_guess.Name = "char_guess"
        Me.char_guess.Size = New System.Drawing.Size(61, 15)
        Me.char_guess.TabIndex = 25
        Me.char_guess.Text = "# $ £ % @"
        '
        'char_jouable
        '
        Me.char_jouable.AutoSize = True
        Me.char_jouable.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.char_jouable.Location = New System.Drawing.Point(598, 361)
        Me.char_jouable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.char_jouable.Name = "char_jouable"
        Me.char_jouable.Size = New System.Drawing.Size(122, 15)
        Me.char_jouable.TabIndex = 24
        Me.char_jouable.Text = "Caractères Jouables :"
        '
        'btn_deviner
        '
        Me.btn_deviner.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_deviner.Location = New System.Drawing.Point(598, 182)
        Me.btn_deviner.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_deviner.Name = "btn_deviner"
        Me.btn_deviner.Size = New System.Drawing.Size(85, 27)
        Me.btn_deviner.TabIndex = 10
        Me.btn_deviner.Text = "Deviner"
        Me.btn_deviner.UseVisualStyleBackColor = True
        '
        'label_mastermind
        '
        Me.label_mastermind.AutoSize = True
        Me.label_mastermind.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.label_mastermind.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label_mastermind.Location = New System.Drawing.Point(309, 122)
        Me.label_mastermind.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.label_mastermind.Name = "label_mastermind"
        Me.label_mastermind.Size = New System.Drawing.Size(96, 17)
        Me.label_mastermind.TabIndex = 17
        Me.label_mastermind.Text = "Master Mind"
        '
        'Code_Couleur
        '
        Me.Code_Couleur.AutoSize = True
        Me.Code_Couleur.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Code_Couleur.Location = New System.Drawing.Point(598, 240)
        Me.Code_Couleur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Code_Couleur.Name = "Code_Couleur"
        Me.Code_Couleur.Size = New System.Drawing.Size(81, 15)
        Me.Code_Couleur.TabIndex = 27
        Me.Code_Couleur.Text = "Code Couleur"
        '
        'Absent
        '
        Me.Absent.AutoSize = True
        Me.Absent.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Absent.Location = New System.Drawing.Point(598, 263)
        Me.Absent.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Absent.Name = "Absent"
        Me.Absent.Size = New System.Drawing.Size(44, 15)
        Me.Absent.TabIndex = 28
        Me.Absent.Text = "Absent"
        '
        'Present
        '
        Me.Present.AutoSize = True
        Me.Present.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Present.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Present.Location = New System.Drawing.Point(598, 288)
        Me.Present.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Present.Name = "Present"
        Me.Present.Size = New System.Drawing.Size(46, 15)
        Me.Present.TabIndex = 29
        Me.Present.Text = "Présent"
        '
        'Present_et_Bien_Place
        '
        Me.Present_et_Bien_Place.AutoSize = True
        Me.Present_et_Bien_Place.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Present_et_Bien_Place.ForeColor = System.Drawing.Color.Lime
        Me.Present_et_Bien_Place.Location = New System.Drawing.Point(599, 315)
        Me.Present_et_Bien_Place.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Present_et_Bien_Place.Name = "Present_et_Bien_Place"
        Me.Present_et_Bien_Place.Size = New System.Drawing.Size(125, 15)
        Me.Present_et_Bien_Place.TabIndex = 30
        Me.Present_et_Bien_Place.Text = "Présent et Bien Placé"
        '
        'Btn_revanche
        '
        Me.Btn_revanche.Location = New System.Drawing.Point(649, 666)
        Me.Btn_revanche.Name = "Btn_revanche"
        Me.Btn_revanche.Size = New System.Drawing.Size(93, 23)
        Me.Btn_revanche.TabIndex = 31
        Me.Btn_revanche.Text = "Revanche ? :)"
        Me.Btn_revanche.UseVisualStyleBackColor = True
        Me.Btn_revanche.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Panel_textbox
        '
        Me.Panel_textbox.Controls.Add(Me.TextBox1)
        Me.Panel_textbox.Controls.Add(Me.TextBox2)
        Me.Panel_textbox.Controls.Add(Me.TextBox3)
        Me.Panel_textbox.Controls.Add(Me.TextBox4)
        Me.Panel_textbox.Controls.Add(Me.TextBox5)
        Me.Panel_textbox.Controls.Add(Me.TextBox6)
        Me.Panel_textbox.Controls.Add(Me.TextBox7)
        Me.Panel_textbox.Controls.Add(Me.TextBox8)
        Me.Panel_textbox.Controls.Add(Me.TextBox9)
        Me.Panel_textbox.Controls.Add(Me.textbox10)
        Me.Panel_textbox.Location = New System.Drawing.Point(85, 182)
        Me.Panel_textbox.Name = "Panel_textbox"
        Me.Panel_textbox.Size = New System.Drawing.Size(487, 37)
        Me.Panel_textbox.TabIndex = 34
        Me.Panel_textbox.TabStop = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(40, 23)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(61, 4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(40, 23)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(107, 4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(40, 23)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(153, 4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(40, 23)
        Me.TextBox4.TabIndex = 3
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(199, 4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(40, 23)
        Me.TextBox5.TabIndex = 4
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(245, 4)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(40, 23)
        Me.TextBox6.TabIndex = 5
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(291, 4)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(40, 23)
        Me.TextBox7.TabIndex = 6
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(337, 4)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(40, 23)
        Me.TextBox8.TabIndex = 7
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(383, 4)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(40, 23)
        Me.TextBox9.TabIndex = 8
        '
        'textbox10
        '
        Me.textbox10.Location = New System.Drawing.Point(429, 4)
        Me.textbox10.Name = "textbox10"
        Me.textbox10.Size = New System.Drawing.Size(40, 23)
        Me.textbox10.TabIndex = 9
        '
        'Compteur
        '
        Me.Compteur.AutoSize = True
        Me.Compteur.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Compteur.Location = New System.Drawing.Point(213, 38)
        Me.Compteur.Name = "Compteur"
        Me.Compteur.Size = New System.Drawing.Size(69, 17)
        Me.Compteur.TabIndex = 36
        Me.Compteur.Text = "Compteur"
        '
        'Label_e_restant
        '
        Me.Label_e_restant.AutoSize = True
        Me.Label_e_restant.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label_e_restant.Location = New System.Drawing.Point(32, 38)
        Me.Label_e_restant.Name = "Label_e_restant"
        Me.Label_e_restant.Size = New System.Drawing.Size(175, 17)
        Me.Label_e_restant.TabIndex = 37
        Me.Label_e_restant.Text = "Nombre d'essais restants : "
        '
        'Label_temps
        '
        Me.Label_temps.AutoSize = True
        Me.Label_temps.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label_temps.Location = New System.Drawing.Point(32, 68)
        Me.Label_temps.Name = "Label_temps"
        Me.Label_temps.Size = New System.Drawing.Size(107, 17)
        Me.Label_temps.TabIndex = 38
        Me.Label_temps.Text = "Temps restant : "
        '
        'Label_timer
        '
        Me.Label_timer.AutoSize = True
        Me.Label_timer.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label_timer.Location = New System.Drawing.Point(144, 68)
        Me.Label_timer.Name = "Label_timer"
        Me.Label_timer.Size = New System.Drawing.Size(44, 17)
        Me.Label_timer.TabIndex = 39
        Me.Label_timer.Text = "Timer"
        '
        'RichTextBox_deviner
        '
        Me.RichTextBox_deviner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBox_deviner.Location = New System.Drawing.Point(259, 285)
        Me.RichTextBox_deviner.Name = "RichTextBox_deviner"
        Me.RichTextBox_deviner.ReadOnly = True
        Me.RichTextBox_deviner.Size = New System.Drawing.Size(212, 325)
        Me.RichTextBox_deviner.TabIndex = 40
        Me.RichTextBox_deviner.TabStop = False
        Me.RichTextBox_deviner.Text = ""
        '
        'its_fine_picture
        '
        Me.its_fine_picture.Location = New System.Drawing.Point(1, 361)
        Me.its_fine_picture.Name = "its_fine_picture"
        Me.its_fine_picture.Size = New System.Drawing.Size(252, 201)
        Me.its_fine_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.its_fine_picture.TabIndex = 41
        Me.its_fine_picture.TabStop = False
        '
        'lb_pov
        '
        Me.lb_pov.AutoSize = True
        Me.lb_pov.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lb_pov.Location = New System.Drawing.Point(20, 305)
        Me.lb_pov.Name = "lb_pov"
        Me.lb_pov.Size = New System.Drawing.Size(0, 15)
        Me.lb_pov.TabIndex = 42
        '
        'pp_thinking_img
        '
        Me.pp_thinking_img.Location = New System.Drawing.Point(598, 95)
        Me.pp_thinking_img.Name = "pp_thinking_img"
        Me.pp_thinking_img.Size = New System.Drawing.Size(85, 90)
        Me.pp_thinking_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pp_thinking_img.TabIndex = 43
        Me.pp_thinking_img.TabStop = False
        '
        'jeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(790, 785)
        Me.Controls.Add(Me.pp_thinking_img)
        Me.Controls.Add(Me.lb_pov)
        Me.Controls.Add(Me.its_fine_picture)
        Me.Controls.Add(Me.RichTextBox_deviner)
        Me.Controls.Add(Me.Label_timer)
        Me.Controls.Add(Me.Label_temps)
        Me.Controls.Add(Me.Label_e_restant)
        Me.Controls.Add(Me.Compteur)
        Me.Controls.Add(Me.Panel_textbox)
        Me.Controls.Add(Me.Btn_revanche)
        Me.Controls.Add(Me.Present_et_Bien_Place)
        Me.Controls.Add(Me.Present)
        Me.Controls.Add(Me.Absent)
        Me.Controls.Add(Me.Code_Couleur)
        Me.Controls.Add(Me.char_guess)
        Me.Controls.Add(Me.char_jouable)
        Me.Controls.Add(Me.btn_deviner)
        Me.Controls.Add(Me.label_mastermind)
        Me.Name = "jeu"
        Me.Text = "jeu"
        Me.Panel_textbox.ResumeLayout(False)
        Me.Panel_textbox.PerformLayout()
        CType(Me.its_fine_picture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pp_thinking_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents char_guess As Label
    Friend WithEvents char_jouable As Label
    Friend WithEvents btn_deviner As Button
    Friend WithEvents label_mastermind As Label
    Friend WithEvents Code_Couleur As Label
    Friend WithEvents Absent As Label
    Friend WithEvents Present As Label
    Friend WithEvents Present_et_Bien_Place As Label
    Friend WithEvents Btn_revanche As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel_textbox As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents textbox10 As TextBox
    Friend WithEvents Compteur As Label
    Friend WithEvents Label_e_restant As Label
    Friend WithEvents Label_temps As Label
    Friend WithEvents Label_timer As Label
    Friend WithEvents RichTextBox_deviner As RichTextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents its_fine_picture As PictureBox
    Friend WithEvents lb_pov As Label
    Friend WithEvents pp_thinking_img As PictureBox
End Class
