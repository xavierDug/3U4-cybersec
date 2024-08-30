---
id: r04
title: Rencontre 4 - Évaluation des menaces
sidebar_label: R04 - Évaluation des menaces
draft: true
hide_table_of_contents: false
---

Si tu es exposé à 50 menaces de cybersécurité de toutes sortes et que tu dois décider laquelle est la plus importante
à gérer, il faut que tu t'équipes d'outils pour l'évaluer.

Un de ces outils est le **[Common Vulnerability Scoring System (CVSS)](https://en.wikipedia.org/wiki/Common_Vulnerability_Scoring_System)**.

## Métriques de base du CVSS

Le CVSS est un système permettant d'évaluer le niveau de criticité d'une vulnérabilité. Il vise à nous aider à prioriser notre réponse à des vulnérabilités connues. En évaluant certaines métriques, le CVSS produit un score; plus le score est élevé, plus la vulnérabilité est sérieuse et plus il est urgent de la sécuriser. Vous pouvez utiliser [cet outil](https://www.first.org/cvss/calculator/3.1) pour calculer le score CVSS.

Dans ce cours, nous nous atterderons seulement aux métriques de base.

### Vecteur d'attaque (AV)

Le vecteur d'attaque décrit comment la vulnérabilité peut être exploitée.

#### Réseau (AV:N)
La vulnérabilité est exploitable par le réseau et peut passer à travers un routeur.

#### Adjacent (AV:A)
La vulnérabilité est exploitable par le réseau, mais demande soit une proximité locale (bluetooth, WiFi) soit sur le même segment du réseau local.

#### Local (AV:L)
La vulnérabilité est exploitable seulement avec un accès local au système, soit directement, soit à distance à l'aide de protocole comme SSH ou RDP, ou encore par ingénierie sociale.

#### Physique (AV:P)
La vulnérabilité est exploitable seulement avec un accès physique et direct.

### Complexité de l'attaque (AC)

La métrique de complexité décrit le niveau de difficulté de l'exploit. Il n'est pas ici question du niveau de compétence requis pour exploiter la vulnérabilité ou si l'attaque est "compliquée" à réaliser (par exemple, on doit envoyer du code en assembleur et c'est difficile à apprendre). On parle plutôt des conditions dans laquelle l'attaque doit être réalisée.

#### Bas (AC:L)
L'attaque peut réussir sans circonstances particulières et sans grands efforts de préparation. 

#### Haut (AC:H)
Le succès de l'attaque dépend de circonstances hors du contrôle de l'attaquant, qui devra investir des efforts considérables pour préparer son attaque. 


### Privilèges nécesaires (PR)

La métrique de privilège décrit le niveau de privilège requis par un attaquant afin de réussir son exploit.

#### Aucun (PR:N)
L'attaquant n'a pas besoin de s'authentifier ou de s'identifier pour l'attaque.

#### Bas (PR:L)
L'attaquant doit être authentifié et disposer d'un accès de base.

#### Élevé (PR:H)
L'attaquant doit être authentifié à l'aide d'un compte disposant de privilèges élevés ou significatifs.


### Interaction nécessaire de l'utilisateur (UI)

La métrique d'interaction avec l'utilisateur décrit si le succès d'un exploit dépend d'une action particulière de la part d'un utilisateur tiers (autre que l'attaquant).

#### Aucune (UI:N)
La vulnérabilité peut être exploitée sans dépendre d'une quelconque interaction avec un utilisateur.

#### Requise (UI:R)
Le succès de l'exploit dépend d'une action de la part d'un utilisateur (par exemple, cliquer sur un lien dans un courriel).


### Portée (S)

La métrique de portée décrit si une attaque réalisée avec succès sur le système vulnérable peut causer un impact sur un autre système.

#### Changée (S:C)
Une vulnérabilité exploitée peut avoir des répercussions sur d'autres systèmes.

#### Inchangée (S:U)
Le dommage causé par l'exploitation de la vulnérabilité est limité au système vulnérable.


### Impact sur la confidentialité

La métrique de confidentialité décrit si l'exploitation de la vulnérabilité a le potentiel de permettre l'accès à des données sensibles par des personnes non autorisées.

#### Aucune (C:N)
Aucun impact sur la confidentialité.

#### Faible (C:L)
Il y a un impact sur le confidentialité, mais l'étendue de l'information compromise est partielle ou l'attaquant n'a pas de contrôle sur les données qu'il accède.

#### Élevée (C:H)
Un attaquant peut avoir accès à l'entièreté des données du système, incluant des données sensibles.



### Impact sur l'intégrité

La métrique de confidentialité décrit si l'exploitation de la vulnérabilité a le potentiel de permettre la modification ou l'altération de données.

#### Aucune (I:N)
Aucun impact sur l'intégrité de l'information.

#### Faible (I:L)
L'impact sur l'intégrité de l'information est circonscrit et limité.

#### Élevée (I:H)
Un attaquant peut modifier toutes les données du système compromis.



### Impact sur la disponibilité

La métrique de disponibilité décrit si l'exploitation de la vulnérabilité a le potentiel d'empêcher l'accès à l'information par les personnes autorisées.

#### Aucune (A:N)
Aucun impact sur la disponibilité.

#### Faible (A:L)
La disponibilité est affecté de manière intermittente ou partielle, ou la performance peut être dégradée

#### Élevée (A:H)
Un attaquant peut rendre le système vulnérable complètement indisponible.



## Exemples

### Exemple 1 : une attaque de déni de service (DDoS) sur le site omnivox pendant la période de remise des notes

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

### Exemple 2 : une attaque de type un étudiant installe un keylogger

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

## Exercices par équipe de 3-4 : 

Chaque équipe enverra un membre expliquer les différentes composantes et le score final.

### Exercice 1

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

### Exercice 2

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





