﻿Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class Pattern_a_deviner

    Private Sub Pattern_a_deviner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Recenter_panel()

        char_guess.Text = get_caractere_possibles()
        pp_bigbrain.Image = Image.FromFile("..\..\..\img\pp_big_brain.png")
        patrick_img.Image = Image.FromFile("..\..\..\img\patrick.png")
        For Each textBox As TextBox In Panel_textbox.Controls.OfType(Of TextBox)()
            textBox.MaxLength = 1
            AddHandler textBox.KeyPress, AddressOf RestrictCharacters
        Next
        AfficherTextBox()
        set_fermer_pattern(True)



    End Sub



    Public Sub Pattern_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing

        If get_fermer_pattern() = True Then

            Dim result As DialogResult = MessageBox.Show("Revenir à l'accueil ?", "Confirmation de fermeture", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.No Then
                e.Cancel = True
            Else
                Accueil.Show()


            End If

        End If


    End Sub

    Private Sub AfficherTextBox()

        Dim nbTextBox As Integer = get_nb_case()

        For i As Integer = 0 To Panel_textbox.Controls.Count - 1

            If TypeOf Panel_textbox.Controls(i) Is TextBox Then
                Dim textBox As TextBox = Panel_textbox.Controls(i)

                If i < nbTextBox Then
                    textBox.Visible = True
                Else
                    textBox.Visible = False
                End If
            End If
        Next

    End Sub

    Private Sub RestrictCharacters(sender As Object, e As KeyPressEventArgs)

        Dim allowedChars As String = mod_param.get_caractere_possibles


        If Not allowedChars.Contains(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            Me.SelectNextControl(DirectCast(sender, Control), True, True, True, True)

        End If
    End Sub



    Private Sub btn_cacher_Click(sender As Object, e As EventArgs) Handles btn_cacher.Click

        redim_tab_pattern1(get_nb_case() - 1)

        For Each textBox As TextBox In Panel_textbox.Controls.OfType(Of TextBox)()
            If textBox.Visible AndAlso String.IsNullOrEmpty(textBox.Text) Then
                MessageBox.Show("Veuillez remplir toutes les cases pour passer à la suite.")
                Return
            End If


        Next
        ' Parcourez les TextBox visibles et stockez les données dans le tableau
        Dim index As Integer = 0
        For Each control As Control In Panel_textbox.Controls
            If TypeOf control Is TextBox AndAlso control.Visible Then
                set_tab_pattern1(index, DirectCast(control, TextBox).Text)
                index += 1
            End If
        Next

        jeu.Show()
        set_fermer_pattern(False)
        Me.Close()

    End Sub

    Private Sub Recenter_panel()
        Dim master_mind_x_location As Integer = Me.label_mastermind.Location.X

        Panel_textbox.Width = mod_param.get_nb_case * (TextBox1.Width + 10)
        Dim x As Integer = (master_mind_x_location - Panel_textbox.Width / 2) + TextBox1.Width
        Panel_textbox.Location = New System.Drawing.Point(x, 182)

    End Sub


End Class
