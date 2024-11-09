---
id: r22
title: Rencontre 22 - Hachage (attaque)
sidebar_label: R22 - Hachage (attaque)
draft: false
hide_table_of_contents: false
---
# Hachage (attaque)

Dans notre application, la BD peut éventuellement fuitée:
- on a mal protégé un serveur qui héberge la BD
- un employé fâché a copié la BD sur une clé USB et l'a emportée
- on a revendu un serveur de backup sans effacer les données et il y a uns sauvegarde de la BD il y a un mois
- etc.

Pour le cas du TP3, la BD est directement dans un fichier quelque part sur l'ordinateur.

## Activité : Mais où est la BD?

Après avoir lancé l'application:
1. pars l'application
2. crée quelques utilisateurs etc.
3. dans les fichiers du projet, essaie de trouver dans quel fichier se trouve la BD

## Activité : Ouvrir une BD

Une fois qu'on a trouvé le fichier d'une BD, on veut trouver une application qui permet de l'ouvrir.

**DataGrip** est une application qui va pouvoir ouvrir une BD même si vous ne connaissez pas son format.

1. Téléchargez DataGrip soit par JetBrains Toolbox ou directement sur le site de JetBrains
2. Ouvrir / Lancer DataGrip
3. Ouvrir le fichier de la BD que tu as trouvé

Tu devrais maintenant savoir quelle moteur de base de données est utilisé et voir les tables.

Tu peux prendre en notes tes manipulations pour les inclure dans ton rapport du TP3.

## Activité: sortir les hash

Tu vas trouver dans le dossier stock du repo un fichier appelé **leaked.db**.

En utilisant une appli pour ouvrir la BD, tu peux l'ouvrir et la parcourir.

En regardant la bonne table tu vas trouver les hash des mots de passe.

Essaie de craquer ces mots de passe et prends en note les mots de passe que tu as réussi à récupérer.

## Avancer mon TP3

Tu devrais maintenant avoir une piste pour attaquer les mots de passe des premiers ministres.





