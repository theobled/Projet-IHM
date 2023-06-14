﻿Imports System.Runtime.CompilerServices

Public Class Joueur
    Private nom_joueur As String
    Private score_joueur As Integer
    Private best_time_joueur As Integer 'en sec
    Private nb_partie_first_joueur As Integer
    Private nb_partie_second_joueur As Integer
    Private cumul_temps_deviner_combi_joueur As Integer ' en sec



    Private tmp_temps_deviner As Integer


    Sub New(nom As String, score As Integer, best_time As Integer, nb_partie_first As Integer, nb_partie_second As Integer, cumul_temps_deviner_combi As Integer)
        nom_joueur = nom
        score_joueur = score
        best_time_joueur = best_time
        nb_partie_first_joueur = nb_partie_first
        nb_partie_second_joueur = nb_partie_second
        cumul_temps_deviner_combi_joueur = cumul_temps_deviner_combi
        tmp_temps_deviner = 0

    End Sub

    Sub New(attributs_joueur As String())
        Me.New(attributs_joueur(0), CInt(attributs_joueur(1)), CInt(attributs_joueur(2)), CInt(attributs_joueur(3)), CInt(attributs_joueur(4)), CInt(attributs_joueur(5)))
    End Sub

    Public Function get_nom_joueur() As String
        Return nom_joueur
    End Function
    Public Function get_score_joueur() As Integer
        Return score_joueur
    End Function
    Public Function get_best_time_joueur() As Integer
        Return best_time_joueur
    End Function
    Public Function get_nb_partie_first_joueur() As Integer
        Return nb_partie_first_joueur
    End Function
    Public Function get_nb_partie_second_joueur() As Integer
        Return nb_partie_second_joueur
    End Function
    Public Function get_cumul_temps_joueur() As Integer
        Return cumul_temps_deviner_combi_joueur
    End Function
    Public Overrides Function ToString() As String
        Return nom_joueur & ";" & score_joueur & ";" & best_time_joueur & ";" & nb_partie_first_joueur & ";" & nb_partie_second_joueur & ";" & cumul_temps_deviner_combi_joueur
    End Function


    'methode pour fin dpartie
    Public Sub inc_score()
        score_joueur += 1
    End Sub
    Public Sub inc_partie_first()
        nb_partie_first_joueur += 1
    End Sub
    Public Sub inc_partie_second()
        nb_partie_second_joueur += 1
    End Sub

    Public Sub inc_cumul_temps(x As Integer)
        cumul_temps_deviner_combi_joueur += x
    End Sub


    Public Sub inc_tmp_temps_devine()
        tmp_temps_deviner += 1
    End Sub
    Public Function get_tmp_temps_deviner() As Integer
        Return tmp_temps_deviner
    End Function
    Public Sub set_best_time(x As Integer)
        best_time_joueur = x
    End Sub
End Class
