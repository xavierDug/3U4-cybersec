---
id: r26
title: Rencontre 26 - Injection SQL (attaque)
sidebar_label: R26 - Injection SQL (attaque)
draft: false
hide_table_of_contents: false
---

# Injecter du SQL

Une injection SQL c'est quoi?
- une situation où l'utilisateur peut exécuter du SQL de son choix sur la BD
- PAS LE PROGRAMMEUR mais l'utilisateur, nooooooooooonnnnnnnnnnn
- parce que le programmeur a pris ce que l'utilisateur lui a donné et l'a mélangé sans faire attention 
avec son code.


https://www.w3schools.com/sql/sql_injection.asp
## Pourquoi c'est rare mais très dangereux

Beaucoup d'attaques sont possibles parce qu'il faut faire un effort pour se protéger.

Pour les injections SQL, il faut programmer mal pour que ça arrive.

```
Les programmeurs paresseux sont très nombreux.
Les mauvais programmeurs sont moins nombreux.
Les mauvais programmeurs qui concatènent des données utilisateurs dans des requêtes SQL sont encore moins nombreux.
```

Par contre, quand la faille est là, il n'y a aucune limite au code qu'on peut exécuter. En bref, on est morts.

## Activité / Exemple

1. clone le repo du cours avec ton client git préféré
2. dans le dossier stock
3. dans le dossier escuelle
4. tu trouveras un fichier sln pour une application
5. il s'agit d'une application qui enregistre des comptes et leurs notes
6. familiarise toi avec l'application en créant 2-3 comptes avec chacun 2-3 notes
7. tu peux aussi regarder à quoi ressemble la BD avec DataGrip

Une fois que tu as pris connaissance de l'application, passe à travers le fichier [injections](https://github.com/departement-info-cem/3U4-cybersec/blob/main/stock/esscuelle/injections.md)

N'hésite pas à poser des questions au prof.

## TP3

En t'inspirant un peu / beaucoup de l'activité, tente de voir si tu peux trouver une attaque d'injection SQL sur l'application du TP3.

