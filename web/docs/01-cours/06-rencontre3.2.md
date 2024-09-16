---
id: r06
title: Rencontre 6 - Accès physique
sidebar_label: R06 - Accès physique
draft: false
hide_table_of_contents: false
---

import Tabs from '@theme/Tabs';
import TabItem from '@theme/TabItem';

:::note Plan de la rencontre 6

<Tabs>

<TabItem value="deroulement" label="👨‍🏫 Déroulement">

1. Démonstration BadUSB
1. Vol de données sur un disque dur
1. Utilitaire de boot externe
1. Exercices
1. Travail sur le TP

</TabItem>

<TabItem value="documents" label="📚 Documents">

- [Vidéo à visionner pour le prochain cours](https://www.youtube.com/watch?v=XJCQBqTmGUU)

</TabItem>

<TabItem value="outils" label="🛠 Outils">

- [Hiren's BootCD PE](https://www.hirensbootcd.org/)
- [Flipper Zero Bad USB](https://docs.flipper.net/bad-usb)
  - [Script utilisé pour la démo](https://raw.githubusercontent.com/departement-info-cem/3U4-cybersec/main/stock/demoBadUSB/demo3u4.txt)

</TabItem>

</Tabs>

:::


## Démonstration: BadUSB

Le prof fera une démonstration d'une attaque de type BadUSB à l'aide de l'outil Flipper Zero.


## Accéder à un fichier physique

Nous allons voir comment formuler en faille exploit et correctif les 3 attaques suivantes pour accéder
à un fichier sur le poste d'un utilisateur:
1. attaque avec un keylogger physique
2. attaque avec un boot sur clé externe
3. attaque avec un accès physique au disque dur


### Rappel

Formuler en faille, exploit et correctif l'attaque par keylogger physique (5 minutes)

### Accès physique au disque dur

Faille: un disque dur est protégé en accès par le système d'exploitation qui a démarré sur le poste. 
Si on retire le disque dur et qu'on le branche sur un autre ordinateur auquel on a accès, le système d'exploitation 
ne peut plus contrôler l'accès aux données.

Exploit:
- un attaquant prépare un tournevis, un ordinateur portable et un adapteur USB-SATA et USB-M.2
- il éteint l'ordinateur de la victime en appuyant sur le bouton "Power" pendant 5 secondes
- il ouvre le boitier (à l'aide d'un tournevis si nécessaire)
- il débranche et retire le disque dur du boitier (à l'aide d'un tournevis si nécessaire)
- il connecte le disque sur son ordinateur portable à l'aide de l'adapteur
- il monte le disque dur
- il trouve les fichiers souhaités et les copie sur le disque de son portable
- il débranche le disque de l'adapteur, le rebranche dans l'ordinateur et referme le boitier

Exercice: formuler vos idées sur le ou les correctifs à apporter pour contrer cette attaque.


### Boot sur une clé externe pour voler les données

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
- il trouve les fichiers souhaités et les copie sur un support externe

Exercice: formuler vos idées sur le ou les correctifs à apporter pour contrer cette attaque.

## Démonstration: 
- Boot sur clé externe et accès à un fichier
- Boot sur une clé externe pour accéder au système

## Quelques questions / réflexions (10 minutes)

Par groupe de 4, préparez des réponses aux questions suivantes:
- pourquoi certains systèmes n'ont aucun connexion internet? Centrales nucléaires, barrages, raffineries ...
- Pourquoi on met un cadenas sur les boitiers?
- Pourquoi un met un mot de passe sur le BIOS?
- Pourquoi on met un cadenas / carte d'accès sur les salles des serveurs?

## Vidéo à visionner pour le prochain cours

Regardez cette vidéo portant sur les clés USB abandonnées, les clés passives et les clés actives. Nous en discutons au prochain cours.

Regarder la video suivante en préparation: https://www.youtube.com/watch?v=XJCQBqTmGUU







