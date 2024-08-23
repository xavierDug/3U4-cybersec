---
id: r04
title: Rencontre 4 - Évaluation des menaces
sidebar_label: R04 - Évaluation des menaces
draft: true
hide_table_of_contents: false
---

# Évaluation des menaces

Si tu es explosé à 50 menaces de cybersécurité de toutes sortes et que tu dois décider laquelle est la plus importante
à gérer, il faut que tu t'équipes d'outils pour l'évaluer.

Un de ces outils est le **[Common Vulnerability Scoring System (CVSS)](https://en.wikipedia.org/wiki/Common_Vulnerability_Scoring_System)**.

L'outil principal se trouve ici:
- [https://www.first.org/cvss/calculator/3.1](https://www.first.org/cvss/calculator/3.1)


## Exemple 1 : une attaque de déni de service (DDoS) sur le site omnivox pendant la période de remise des notes

Résumé : on est rendus le 28 décembre et demain c'est la date limite pour remettre les notes. Plusieurs profs
commencent à se plaindre: la plupart du temps, on ne peut pas accéder et quand on accède c'est très lent.

On va évaluer ça:
- Vecteur d'attaque: réseau
- Complexité d'attaque: là c'est pas évident, il faut quand même prendre le contrôle de plusieurs postes à moins que ce soit un grand nombre d'étudiants coordonnés
- Niveau de privilège nécessaire: aucun
- Interaction nécessaire de l'utilisateur: aucune
- Portée de l'impact: élevée
- Confidentialité: aucune
- Intégrité: aucune
- Disponibilité: élevée

On va donc avoir un score de 7.5/10. C'est assez élevé, on va donc devoir s'en occuper rapidement.

## Exemple 2 : une attaque de type un étudiant installe un keylogger sur un ordinateur de prof pour avoir accès à ses fichiers

Résumé : un étudiant a placé un keylogger physique sur le poste du prof dans le local D0605. Il a pu récupérer les mots de passe
des 8 profs qui donnent des cours dans ce local. Cela inclut son prof pour un cours qu'il est au bord de couler.




## Exercice par équipe de 2 :

```text



