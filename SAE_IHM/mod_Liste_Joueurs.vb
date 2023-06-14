﻿Module mod_Liste_Joueurs
    Private Joueurs As New List(Of Joueur)
    Delegate Function getter_delegate(j As Joueur) As Object

    Private Joueur1 As Joueur
    Private Joueur2 As Joueur

    Sub add_joueur(j As Joueur)
        Joueurs.Add(j)
    End Sub

    Public Function get_joueurs() As List(Of Joueur)
        Return Joueurs
    End Function
    Public Function get_joueurs_str() As String()
        Dim joueurs_str As New List(Of String)

        For Each j As Joueur In mod_Liste_Joueurs.get_joueurs
            joueurs_str.Add(j.ToString)
        Next
        Return joueurs_str.ToArray
    End Function
    Public Function get_attributs_joueurs(getter_attribut As getter_delegate) As List(Of Object)
        Dim list_attribut As New List(Of Object)
        For Each j As Joueur In Joueurs
            list_attribut.Add(getter_attribut.Invoke(j))
        Next
        Return list_attribut
    End Function

    Public Function get_nom_joueurs() As List(Of String)
        Dim liste_nom As New List(Of String)
        For Each j As Joueur In Joueurs
            liste_nom.Add(j.get_nom_joueur())
        Next
        Return liste_nom
    End Function



    Public Function get_index_joueur(pseudo_joueur As String) As Integer
        Dim nom_joueurs As List(Of Object) = get_attributs_joueurs(AddressOf mod_Liste_Joueurs.get_nom)
        Return get_nom_joueurs.IndexOf(pseudo_joueur)
    End Function

    Public Function get_nom(j As Joueur) As String
        Return j.get_nom_joueur
    End Function

    Public Function get_score(j As Joueur) As Integer
        Return j.get_score_joueur()
    End Function

    Public Function get_best_time(j As Joueur) As Integer
        Return j.get_best_time_joueur
    End Function
    Public Function get_nb_partie_first(j As Joueur) As Integer
        Return j.get_nb_partie_first_joueur
    End Function
    Public Function get_nb_partie_second(j As Joueur) As Integer
        Return j.get_nb_partie_second_joueur
    End Function
    Public Function get_temps_cumul(j As Joueur) As Integer
        Return j.get_cumul_temps_joueur
    End Function

    Public Function get_joueur1() As Joueur
        Return Joueur1
    End Function

    Public Function get_joueur2() As Joueur
        Return Joueur2
    End Function


    Public Sub set_joueur1(j As Joueur)
        Joueur1 = j

    End Sub

    Public Sub set_joueur2(j As Joueur)
        Joueur2 = j

    End Sub
End Module
