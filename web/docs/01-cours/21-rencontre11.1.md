---
id: r21
title: Rencontre 21 - Sécuriser une application
sidebar_label: R21 - Sécuriser une application
draft: true
hide_table_of_contents: false
---

Nous allons explorer l'application fournie pour le cours:
- l'application se trouve dans le repo du cours https://github.com/departement-info-cem/3U4-cybersec
- trouve la section Release 
- tu devrais trouver un fichier vers consoleApp.exe
- il s'agit d'une solution VisualStudio que tu peux ouvrir en double cliquant sur le fichier .sln

Dans les 4 prochaines semaines, nous allons voir comment on peut attaquer un système puis le défendre sur 3 aspects:
- le cassage d'un mot de passe sur une BD fuitée
- le cassage d'une encryption sur une BD fuitée
- l'injection SQL sur l'application (sans BD fuitée)

## Exercice / activité: se familiariser avec l'application

1. Télécharge le repo du cours [ici](https://github.com/departement-info-cem/3U4-cybersec/archive/refs/heads/main.zip)
2. Ouvre le projet et exécute-le.
3. N'hésite pas à poser des questions sur l'utilisation de l'application.

## Lecture du code:

La plupart des correctifs que tu vas appliquer nécessite de modifier le code de l'application. 
Cela vaut donc la peine de passer à travers le code. 

La méthode que nous recommandons est la suivante:
- place un certain nombres de point d'arrêt dans l'application
- note dans un fichier **tracemanuelle.md** par où tu penses que l'exécution va passer pour mettons créer un compte 
dans le format nomfichier ligne. Par exemple:
```text
fichier1.cs ligne 10
fichier2.cs ligne 7
fichier1.cs ligne 15
fichier3.cs ligne 25
```
- valide en effectuant l'opération sur l'application partie en débogage

## Exercice sur le commande strings

Chaque application contient potentiellement des strings qui peuvent être intéressantes pour un attaquant.

Ce type de commandes peut permettre de comprendre quelle 

1. Télécharge https://learn.microsoft.com/fr-ca/sysinternals/downloads/strings
2. Il s'agit d'une application qui cherche toutes les potentielles chaînes UTF-8 ou ASCII dans un exécutable
3. Crée toi un fichier texte avec les chaines trouvées dans une application.
4. Nous te suggérons de tester plusieurs applications présentes sur ta machine pour voir ce que tu peux trouver.

## Exercice de décompilation

Un outil important pour attaquer ou valider la sécurité d'une application est le décompilateur ou déassembleur.

Pour pouvoir décompiler une application, il faut d'abord réussir à savoir avec quelle plateforme elle a été compilée.

1. Dans notre cas, nous pensons que ça a été fait avec .Net
2. On va utiliser dotPeek pour décompiler l'application
3. Télécharge dotPeek 
4. Essaie de décompiler l'application fournie



