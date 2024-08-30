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

Résumé : 
```
on est rendus le 28 décembre et demain c'est la date limite pour remettre les notes. Plusieurs profs
commencent à se plaindre: la plupart du temps, on ne peut pas accéder et quand on accède c'est très lent.
```
On va évaluer ça:
- Vecteur d'attaque: réseau
- Complexité d'attaque: là c'est pas évident, il faut quand même prendre le contrôle de plusieurs postes à moins que ce soit un grand nombre d'étudiants coordonnés
- Niveau de privilège nécessaire: aucun
- Interaction nécessaire de l'utilisateur: aucune
- Portée de l'impact: inchangée
- Confidentialité: aucune
- Intégrité: aucune
- Disponibilité: élevée

On va donc avoir un score de 7.5/10. C'est assez élevé, on va donc devoir s'en occuper rapidement.

## Exemple 2 : une attaque de type un étudiant installe un keylogger

Résumé : 
```
un étudiant a placé un keylogger physique sur le poste du prof dans le local D0605. Il a pu récupérer les mots de passe
des 8 profs qui donnent des cours dans ce local. 
Cela inclut son prof pour un cours qu'il est au bord de couler.
```
On va évaluer ça:
- Vecteur d'attaque: physique
- Complexité d'attaque: faible
- Niveau de privilège nécessaire: aucun
- Interaction nécessaire de l'utilisateur: requise
- Portée de l'impact: inchangée
- Confidentialité: élevée
- Intégrité: élevée
- Disponibilité: aucune (à moins que le pirate détruise des fichiers sans backup mais là il y a un backup)

On va donc avoir un score de 5.9 / 10. 

On voit que le score est un indicateur mais également qu'on est forcé de réfléchir selon des critères partagés avec le 
reste de la communauté cybersecurité.

On voit aussi que la disponibilité change selon la présence de sauvegardes ou pas ce qui peut donner des idées d'amélioration pour
limiter l'impact d'une attaque.

## Exercice par équipe de 3-4 : 

Chaque équipe enverra un membre expliquer les différentes composantes et le score final.

Résumé :
```
Joris un des profs du département d'informatique a reçu un courriel venant d'un collègue d'un autre
collège. Dedans il y avait un .exe avec supposément la démo d'un TP dans un cours qu'il donne.

En ouvrant le .exe depuis son poste au collège, apparemment rien ne se passe. Il continue ses affaires.

Une heure plus tard, il essaie d'ouvrir un fichier sur son disque réseau Z: et il y a un fichier 
"LIS_MOI.txt" qui accompagne un énorme fichier "stuff.encrypted", tout le reste a disparu.
```

Déterminer chaque composante du CVSS 3.1 et le score final. Pensez à prendre en note, ça pourrait servir
pour les révisions pour l'examen.

## Exercice par équipe de 3-4 :

Chaque équipe enverra un membre expliquer les différentes composantes et le score final.

Résumé
```
Giacomo après avoir configuré son serveur de courriel et authentifié son domaine avec SPF, DKIM et DMARC 
se rend compte qu'il peut envoyer des courriels "@cegepmontpetit.ca" avec n'importe quel préfixe.

Il commence par envoyer un courriel à son prof de la part de la direction du collège pour lui dire qu'il a
maintenant le droit à 50% de temps supplémentaire pour ses examens.
```

Déterminer chaque composante du CVSS 3.1 et le score final. Pensez à prendre en note, ça pourrait servir
pour les révisions pour l'examen.





