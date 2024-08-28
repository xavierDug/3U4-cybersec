---
id: r03
title: Rencontre 3 - Concepts et terminologie
sidebar_label: R03 - Concepts et terminologie
draft: false
hide_table_of_contents: false
---

import Tabs from '@theme/Tabs';
import TabItem from '@theme/TabItem';

:::note Plan de la rencontre

<Tabs>

<TabItem value="deroulement" label="👨‍🏫 Déroulement">

1. Concepts et de la terminologie
1. Critères de sensibilité (triade CID)
1. Les types de hackers
1. Les équipes lors de tests de cybersécurité
1. Travail sur le TP1

</TabItem>

<TabItem value="documents" label="📚 Documents">

- [Présentation PowerPoint](/docs/3U4-R03-Terminologie.pptx)

</TabItem>

</Tabs>

:::


## Vulnérabilités et exploits

Une **vulnérabilité** est une faille ou une faiblesse dans un système ou une application.

Une **menace** est un événement potentiel qui pourrait nuire ou entraîner des dommages.

Le **risque** qu’une menace se concrétise est plus grand lorsque des vulnérabilités subsistent.

Une **attaque**, ou **exploit**, est un acte délibéré de concrétiser une menace.


## Pourquoi on attaque?

- Obtenir des données confidentielles?
- Nuire à un ennemi?
- Voler des renseignements personnels?
- Détourner des fonds?
- Modifier des données?


## Types d'attaque

- Hameçonnage (phishing)
- Déni de service (DoS)
- Déni de service distribué (DDoS)
- Rançongiciel (ransomware)
- Exécution de code à distance (remote code exécution)
- *etc.*


## Critères de sensibilité (triade CID)

| Critère         | Définition                                                                                           |
| --------------- | ---------------------------------------------------------------------------------------------------- |
| Confidentialité | L’information n’est accessible qu’aux personnes dont l’accès est autorisé.                           |
| Intégrité       | L’information est authentique, correcte et fiable; elle n’a pas subi d’altération.                   |
| Disponibilité   | L’information est disponible et les utilisateurs peuvent y accéder chaque fois qu’ils en ont besoin. |


## Exercice

Faites une petite recherche sur ces événements et dites quel(s) critère(s) de la triade CID ont été compromis.
- [Desjardins (2019)](https://fr.wikipedia.org/wiki/Caisses_Desjardins#Vol_de_donn%C3%A9es_personnelles)
- [Ashley Madison (2015)](https://fr.wikipedia.org/wiki/Ashley_Madison#Piratage_et_fuite_de_donn%C3%A9es)
- [CrowdStrike (2024)](https://en.wikipedia.org/wiki/2024_CrowdStrike_incident)
- [Equifax (2017)](https://en.wikipedia.org/wiki/2017_Equifax_data_breach)
- [Université de Santa Clara (2011)](https://www.wired.com/2011/11/santa-clara-university-hacked/)
- [L’attaque de Mafiaboy (2000)](https://fr.wikipedia.org/wiki/Michael_Calce)
- [Attaque NotPetya contre l’Ukraine (2017)](https://en.wikipedia.org/wiki/2017_Ukraine_ransomware_attacks)


## Traçabilité

On ajoute parfois à la triade CID un quatrième critère, celui de la traçabilité.
Les entreprises vont mettre en place des mesures pour remonter à la source en cas d’attaque, à l’aide de systèmes de détection et de journalisation.


## Les hackers

Les hackers sont des experts en cybersécurité qui cherchent à **exploiter des vulnérabilités** d’un système informatique. Ce sont des spécialistes de la cybersécurité **offensive**.

Les hackers se déclinent en plusieurs catégories en fonction de leur intention et de leur sens de l’éthique.

- Le ***Black Hat*** est un cybercriminel qui utilise ses compétences dans le but de nuire ou de faire du profit.

- Le ***White Hat***, ou hacker éthique, opère dans la légalité. Il réalise des tests d’intrusion avec la permission ou à la demande d’une organisation pour aider cette dernière à sécuriser ses systèmes et ses données.

- Le ***Grey Hat*** est situé entre les deux. Il perpètre ses attaques, illégalement ou non, sans intention malveillante ou pécuniaire.

- Le ***script kiddie*** est un amateur qui se croit compétent car il a appris une technique de hacking ou découvert un outil qu’il utilise sans comprendre ce qu’il fait. Il perpètre souvent ses attaques dans le but d’accroître sa réputation auprès de ses pairs.

- Le ***hacktiviste*** est un *grey hat* qui utilise des techniques de hacking pour défendre une cause qu’il croit juste et vertueuse, souvent de manière illégale.


## Red Team / Blue Team

Dans les entreprises, des exercices sont parfois organisés pour mettre à l’épreuve leurs cyberdéfenses.

Dans ce jeu, l’équipe rouge (***red team***) est constituée de white hats. Son but est d’attaquer les systèmes de l’entreprise pour en trouver des failles et les exploiter. L’équipe bleue (***blue team***) a pour mission de bloquer ces attaques.

À la fin de la partie, l’équipe rouge **documente** ses découvertes et émet des **recommandations** à l’équipe bleue.

Le ***purple team*** est une équipe mixte composée à la fois de spécialistes offensifs et défensifs.

Voir: https://www.crowdstrike.com/cybersecurity-101/purple-teaming/


