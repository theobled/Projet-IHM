<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Accueil
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
        background_accueil = New PictureBox()
        btn_stat = New Button()
        btn_param = New Button()
        Label2 = New Label()
        Label1 = New Label()
        btn_lancer_jeu = New Button()
        cb_box_p2 = New ComboBox()
        cb_box_p1 = New ComboBox()
        CType(background_accueil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' background_accueil
        ' 
        background_accueil.Location = New Point(0, 3)
        background_accueil.Margin = New Padding(3, 4, 3, 4)
        background_accueil.Name = "background_accueil"
        background_accueil.Size = New Size(915, 597)
        background_accueil.SizeMode = PictureBoxSizeMode.StretchImage
        background_accueil.TabIndex = 15
        background_accueil.TabStop = False
        ' 
        ' btn_stat
        ' 
        btn_stat.Location = New Point(776, 396)
        btn_stat.Margin = New Padding(3, 4, 3, 4)
        btn_stat.Name = "btn_stat"
        btn_stat.Size = New Size(86, 31)
        btn_stat.TabIndex = 22
        btn_stat.Text = "Statistiques"
        btn_stat.UseVisualStyleBackColor = True
        ' 
        ' btn_param
        ' 
        btn_param.Location = New Point(776, 463)
        btn_param.Margin = New Padding(3, 4, 3, 4)
        btn_param.Name = "btn_param"
        btn_param.Size = New Size(86, 31)
        btn_param.TabIndex = 21
        btn_param.Text = "Paramètres"
        btn_param.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(255), CByte(232), CByte(45))
        Label2.Location = New Point(601, 228)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 20)
        Label2.TabIndex = 20
        Label2.Text = "PLAYER 2"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(255), CByte(232), CByte(45))
        Label1.Location = New Point(601, 101)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 20)
        Label1.TabIndex = 19
        Label1.Text = "PLAYER 1"
        ' 
        ' btn_lancer_jeu
        ' 
        btn_lancer_jeu.AccessibleName = ""
        btn_lancer_jeu.Location = New Point(561, 413)
        btn_lancer_jeu.Margin = New Padding(3, 4, 3, 4)
        btn_lancer_jeu.Name = "btn_lancer_jeu"
        btn_lancer_jeu.Size = New Size(138, 45)
        btn_lancer_jeu.TabIndex = 18
        btn_lancer_jeu.Text = "C'est parti !" & vbCrLf
        btn_lancer_jeu.UseVisualStyleBackColor = True
        ' 
        ' cb_box_p2
        ' 
        cb_box_p2.FormattingEnabled = True
        cb_box_p2.Location = New Point(561, 289)
        cb_box_p2.Margin = New Padding(3, 4, 3, 4)
        cb_box_p2.Name = "cb_box_p2"
        cb_box_p2.Size = New Size(138, 28)
        cb_box_p2.TabIndex = 17
        ' 
        ' cb_box_p1
        ' 
        cb_box_p1.BackColor = SystemColors.Window
        cb_box_p1.FormattingEnabled = True
        cb_box_p1.Location = New Point(561, 167)
        cb_box_p1.Margin = New Padding(3, 4, 3, 4)
        cb_box_p1.Name = "cb_box_p1"
        cb_box_p1.Size = New Size(138, 28)
        cb_box_p1.TabIndex = 16
        ' 
        ' Accueil
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(btn_stat)
        Controls.Add(btn_param)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn_lancer_jeu)
        Controls.Add(cb_box_p2)
        Controls.Add(cb_box_p1)
        Controls.Add(background_accueil)
        ForeColor = Color.Black
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(3, 4, 3, 4)
        Name = "Accueil"
        CType(background_accueil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents background_accueil As PictureBox
    Friend WithEvents btn_stat As Button
    Friend WithEvents btn_param As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_lancer_jeu As Button
    Friend WithEvents cb_box_p2 As ComboBox
    Friend WithEvents cb_box_p1 As ComboBox
End Class
