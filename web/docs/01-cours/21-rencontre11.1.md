---
id: r21
title: Rencontre 21 - Sécuriser une application
sidebar_label: R21 - Sécuriser une application
draft: false
hide_table_of_contents: false
---

# Retour sur l'examen

Nous passerons à travers l'examen 2 pour donner un correctif à l'oral. 

Vous pourrez ensuite demander à revoir votre copie pendant la partie pratique.


# Sécuriser une application

Nous allons explorer l'application fournie pour le cours:
- l'application se trouve dans le repo du cours https://github.com/departement-info-cem/3U4-cybersec
- trouve la section "Releases" 
- tu devrais trouver un fichier vers consoleApp.exe

Dans les 4 prochaines semaines, nous allons voir comment on peut attaquer un système puis le défendre sur 3 aspects:
- le cassage d'un mot de passe sur une BD fuitée
- le cassage d'une encryption sur une BD fuitée
- l'injection SQL sur l'application (sans BD fuitée)

## Exercice / activité: se familiariser avec l'application

1. Télécharge le repo du cours [ici](https://github.com/departement-info-cem/3U4-cybersec/archive/refs/heads/main.zip)
2. Lancez l'application et utilisez là.
  - créer un compte
  - se connecter / déconnecter
  - quitter puis la redémarrer
  - essentiellement tester toutes possibilités de l'application
3. N'hésite pas à poser des questions sur l'utilisation de l'application.

## Exercice: bouger l'application

1. Lancer l'application
2. Créer un compte et s'y connecter
3. Fermer l'application
4. Déplacer le .exe dans un dossier différent
5. Relancer l'application
6. Essayer de se connecter
7. Qu'est-ce qui se passe?

## Exercice sur le commande strings

Chaque application contient potentiellement des strings qui peuvent être intéressantes pour un attaquant.

Ce type de commandes peut permettre de comprendre quelle 

1. Télécharge https://learn.microsoft.com/fr-ca/sysinternals/downloads/strings
2. Il s'agit d'une application qui cherche toutes les potentielles chaînes UTF-8 ou ASCII dans un exécutable
3. Crée toi un fichier texte avec les chaines trouvées dans une application.
4. Essaie de voir si tu peux trouver des chaines utiles
5. Si ce n'est pas le cas, on peut essayer de chercher des options pour avoir un meilleur résultat:
  - `strings -n 8 consoleApp.exe` pour chercher des chaines de 8 caractères ou plus
  - si tu cherches une requête SQL, tu peux essayer de filtrer le résultat en filtrant sur `SELECT` ou `INSERT`
  - etc.

Tu peux tester cette technique sur quelques applications pour voir si tu trouves des informations intéressantes.

## Exercice de décompilation

Un outil important pour attaquer ou valider la sécurité d'une application est le décompilateur ou déassembleur.

Pour pouvoir décompiler une application, il faut d'abord réussir à savoir avec quelle plateforme elle a été compilée.

1. Dans notre cas, nous pensons que ça a été fait avec .Net
2. On va utiliser dotPeek pour décompiler l'application
3. Télécharge dotPeek 
4. Essaie de décompiler l'application fournie
5. Familiarise toi avec l'interface de dotPeek
6. Essaie de retrouver le code important de l'application

## Partir ton TP

Pour ce TP, tu vas devoir:
- effectuer des attaques sur l'application
- modifier le code pour sécuriser l'application

Pour cela, aujourd'hui tu vas devoir:
1. Créer ton repo en utilisant le lien envoyé par ton prof
2. Créer ton fichier rapport.md où tu documenteras les attaques
3. Copier le projet de l'application dans ton repo. C'est là que tu mettras les correctifs.
4. Tu trouveras le projet de l'application [ici](https://github.com/departement-info-cem/3U4-cybersec/)
  - Cherche un peu et tu devrais trouver le projet consoleApp
  - Si tu ne trouves pas, demande à ton prof



