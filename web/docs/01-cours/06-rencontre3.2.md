---
id: r06
title: Rencontre 6 - Accès physique et chiffrement du stockage
sidebar_label: R06 - Accès physique et chiffrement du stockage
draft: true
hide_table_of_contents: false
---



# Sécurité physique

## Accéder à un fichier physique

Nous allons voir comment formuler en faille exploit et correctif les 3 attaques suivantes pour accéder
à un fichier sur le poste d'un utilisateur:
1. attaque avec un keylogger physique
2. attaque avec un boot sur clé externe
3. attaque avec un accès physique au disque dur


### Exercice de rappel: formuler en faille, exploit et correctif l'attaque par keylogger physique (5 minutes)

### Boot sur une clé externe

Faille: un disque dur est protégé en accès par le système d'exploitation qui a démarré sur le poste.
Si un autre OS démarre sur la machine, rien ne lui interdit d'accès à un disque ou une partition.

Exploit: 
- un attaquant prépare une clé USB ou un disque externe avec un OS bootable
- il insère la clé dans le poste de la victime
- il redémarre la machine
- si son OS est prioritaire dans l'ordre de boot, il a réussi
- sinon il redémarre l'ordinateur et entre dans le BIOS pour changer l'ordre de boot
- il redémarre et embarque sur son OS
- il monte le disque dur déjà présent dans la machine
- il trouve les fichiers souhaités et les copies sur un support externe

Exercice: formuler vos idées sur le ou les correctifs à apporter pour contrer cette attaque

### Accès physique au disque dur

TODO

## Démo avec un boot sur clé externe et accès à un fichier

Y aller avec des questions concrètes et apporter la réponse après

## Quelques questions / réflexions (10 minutes)

Par groupe de 4, préparez des réponses aux questions suivantes:
- pourquoi certains systèmes n'ont aucun connexion internet? Centrales nucléaires, barrages, raffineries ...
- Pourquoi on met un cadenas sur les boitiers?
- Pourquoi un met un mot de passe sur le BIOS?
- Pourquoi on met un cadenas / carte d'accès sur les salles des serveurs?

## Clés USB abandonnées, clés passives, clés actives

Regarder la video suivante en préparation:
https://www.youtube.com/watch?v=XJCQBqTmGUU







