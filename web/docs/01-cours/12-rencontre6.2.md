---
id: r12
title: Rencontre 12 - Droits et privilèges
sidebar_label: R12 - Droits et privilèges
draft: true
hide_table_of_contents: false
---


# Droits et privilèges

```text
On souhaite limiter au maximum les permissions, droits ou privilèges d'un utilisateur. 
On souhaite lui fournir les droits nécessaires mais uniquement ceux-ci.
```

On est parfois tentés quand on commence et qu'on est tannés que ça ne marche pas de lancer un
```bash
chmod 777 -R /dossier
```
Hop le TP fonctionne, super je suis maintenant un admin système Linux expert.

On vient de mettre le doigt sur un des problèmes classiques de la cybersécurité:
- l'informatique ça marche jamais et c'est dur de savoir pourquoi ça marche pas
- dans le processus pour arriver à un système fonctionnel, on peut ouvrir beaucoup trop de droits
- quand le système marche, on est fatigués, le client nous a payé
- et si je change de quoi, peut-être que ça ne marchera plus **si c'est pas brisé, n'y touche pas**

Avance rapide 6 mois plus tard, on se rend compte que le stagiaire de DEC qu'on a pris pour l'été
a eu accès aux comptes de campagne de notre parti et tout s'est retrouvé dans les medias.

En plus on a aucun moyen de prouver que c'est lui, vu que tout le monde a les droits!!!!

## Approche pour limiter les droits

Verifiez que les personnes qui ne devraient pas avoir accès n'ont pas accès.

On va donc voir ça sous l'angle vulnéraibilité / exploit / correctif:
- la vulnérabilité est des permissions trop larges
- l'exploit est un accès non autorisé par un utilisateur sur le poste avec toutes les étapes détaillées
- le correctif est de limiter les permissions, on va pouvoir valider ce correctif comme tous les correctifs
  en s'assurant que l'exploit ne marche plus.

## Travail pratique Linux

Il y a dans le travail pratique Linux un problème qui est dû à des permissions trop larges.

Vous devrez valider avec le prof que vous avez bien identifié le problème et fournir un correctif.

Pour rappel, on valide un correctif en s'assurant que l'exploit prévu :
- fonctionne avant le correctif
- ne fonctionne plus après le correctif


