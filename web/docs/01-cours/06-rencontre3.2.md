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


## Chiffrement

Le chiffrement (encryption) des données stockées est un moyen de protéger ces dernières contre le vol ou l'accès non autorisé. Contrairement au hachage, le chiffrement est un processus bidirectionnel. Les opérations mathématiques qui convertissent les données en charabia sont réversibles pour quiconque possédant une **clé**. Nous reviendrons sur les détails du chiffrement plus tard dans la session.

Le chiffrement peut être implémenté à différents niveaux:
- Au niveau du stockage des données, dans le médium qui les contient
- Au niveau de la transmission des données, pendant leur envoi et leur réception

Le chiffrement de la transmission sera abordé plus tard dans la session. Le chiffrement des données stockées peut se faire de plus d'une manière. Par exemple:
- Au niveau d'une application spécifique (base de données, fichier Zip, PGP, VeraCrypt, etc.)
- Au niveau du système de fichiers (NTFS EFS sous Windows, ZFS sous Linux, FreeBSD et MacOSX)
- Au niveau des blocs sur le disque (BitLocker sous Windows, FileVault)
- Au niveau physique (SED, OPAL)

Pour protéger les fichiers contenus sur un disque dur, on optera généralement pour le chiffrement du système de fichiers ou au niveau des blocs. Il est important de noter certaines différences entre les deux:
- Le chiffrement au niveau du système de fichiers ne chiffre que le **contenu** des fichiers. Les métadonnées comme le nom du fichier, sa taille ou son emplacement dans l'arborescence ne sont pas chiffrées.
- Le chiffrement au niveau des blocs (chiffrement intégral du disque) a besoin que la clé de déchiffrement soit stockée à l'extérieur du système, du moins en partie, autrement le système d'exploitation ne pourra pas démarrer. Cela se fait habituellement soit en demandant à l'utilisateur de fournir l'élément manquant à la clé (NIP, mot de passe, clé USB, SmartCard, etc.) avant que le système d'exploitation ne puisse démarrer, soit en la stockant dans une puce appelée TPM connectée à la carte mère.

L'exemple de l'accès physique au disque dur et du boot avec un médium de démarrage auraient tous deux pu être évités à l'aide de ces deux stratégies de chiffrement.


## Clés USB abandonnées, clés passives, clés actives



Regarder la video suivante en préparation: https://www.youtube.com/watch?v=XJCQBqTmGUU







