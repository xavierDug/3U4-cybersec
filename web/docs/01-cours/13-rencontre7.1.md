---
id: r13
title: Rencontre 13 - Stratégies de sauvegarde
sidebar_label: R13 - Stratégies de sauvegarde
draft: true
hide_table_of_contents: false
---

# Sauvegardes et stratégies

Quand on parle de sauvegarde, on parle de défendre l'intégrité des données principalement:
```
J'ai quelque chose de précieux, je ne veux pas le perdre pour toujours
```

Quand on parle de stratégie de sauvegarde, on va principalement répondre aux questions suivantes:
- Quoi? ce que je sauvegarde ... ordinateur au complet, dossiers de contenu, configurations
- Quand? à quelle fréquence ... combien de travail suis prêt à perdre? horaire, quotidien, mensuel, annuel
- Où? sur le même disque? sur le même ordi? dans le même batiment? même pays? même continent? même planète?

## Exemple 1 / discussion : le donneur d'alerte

A.A. (on ne gardera que ses initiales pour conserver son anonymat) a trouvé 30 Go de données
ultra compromettantes pour un gouvernement corrompu. Il souhaite absolument s'assurer que rien ne
disparaitra jamais.

Quelle stratégie adopter pour sa sauvegarde (quoi? fréquence? où?)

## Exemple 2 / discussion : l'étudiant et ses travaux

Andy a mis beaucoup d'efforts dans ses travaux. Il y a même des TP qui fonctionnent c'est fou.
Du coup, il aimerait vraiment beaucoup ne pas les perdre.
- Il a un ordi à la maison mais avec un seul disque.
- Il voudrait vraiment que ça soit pas cher, genre gratuit en fait

Quelle stratégie adopter pour sa sauvegarde (quoi? fréquence? où?)

## Exemple 3 / discussion : l'admin et son site web

John Jean est administrateur d'un site web tout petit qui change jamais. Il a passé un peu de temps
à faire la configuration de Apache. Le contenu du site a été fait par un jeune génie mais on ne sait plus
trop où il est est John Jean bah il comprend rien en HTML.

Quelle stratégie adopter pour sa sauvegarde (quoi? fréquence? où?)

## Espace disponible et vitesse, ssd, disque dur, bandes (tape)

Il existe des systèmes à bande. Selon vous, quelle taille peut-on atteindre avec un système à bande?

Recherche Internet d'un modèle / marque de système de back-up à bandes.

## Discussion : est-ce que OneDrive est un système de sauvegarde

## Discussion : est-ce que Git / Github est un système de sauvegarde






## Chiffrement (ébauche)

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

:::caution
Il est essentiel de posséder la clé de déchiffrement afin de déchiffrer des données chiffrées. Si on perd la clé, les données sont perdues à tout jamais.
:::

### En général exercice de stratégie de sauvegarde pour une situation donnée

### Pour Linux, exercice de rsync pour implanter une stratégie de sauvegarde

### Un exercice de recherche sur un backup avec tape et quelle est la plus grosse capacité qu'ils trouvent par équipe