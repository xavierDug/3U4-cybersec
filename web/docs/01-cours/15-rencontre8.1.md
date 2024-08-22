---
id: r15
title: Rencontre 15 - Services et accès distant
sidebar_label: R15 - Services et accès distant
draft: true
hide_table_of_contents: false
---

# Intro

Dans cette session, nous allons parler des différentes solutions de prise de controle à distance. 
Nous allons voir les avantages et inconvénients de chaque solution.

## Prise de contrôle à distance



## NAT, services à distance ou scammer

### C'est quoi NAT?

Avec IP v4, nous avions des IP sur 32 bits. Cela faisait 4 milliards d'adresses ce qui semblait énorme au départ. Evidemment avec le succès, on a eu plus de 4 milliards d'appareils nécessitant une IP. Est arrivé NAT pour **Network address translation**:
1. on va distinguer une adresse publique sur l'internet et une adress privée sur un réseau local
2. tout le traffic qui
3. sans doute besoin d'une video la dessus non TODO?

### Quand je suis à la maison c'est quoi mon adresse IP?

### Ce qui marche quand j'initie depuis l'intérieur du NAT mais pas autrement

### Le cas du gars gentil

Paul doit prendre le contrôle de la machine d'un client perdu Jean. Jean est derrière un NAT. Selon vous:
- Est-ce que Paul peut utiliser une application qui envoie directement une demande à la machine de Jean? Mettons qu'il y a un serveur SSH sur la machine de Jean?
- Si ce n'est pas le cas, comment on fait?

Notre responsabilité surtout en IT est de s'assurer que la solution qu'on utilise pour administrer à distance n'ouvre pas une brèche pour hacker à distance.

### Le cas du scammer sans scrupule qui opère de l'étranger

1. Marie-Thérèse reçoit un texto qui lui indique que son compte à la BMO a été piraté.
2. Elle doit cliquer sur un lien pour résoudre le problème.
3. Quand elle clique sur le lien elle arrive sur une page qui décrit le problème et indique au scammer qu'il a une victime potentielle.
4. Il appelle sur le numéro de Marie-Thérèse, elle est devant son ordinateur sur la page du scammer
5. Il lui demande de télécharger un logiciel pour résoudre son problème.
6. Comme le site lui montre une page qui ressemble à celle de sa banque avec un montant de 0$, elle panique
7. La personne est une femme elle parle doucement et Marie-Thérèse est rassurée
8. Elle télécharge le logiciel qui initie une communication avec un serveur à travers son NAT
9. Le scammer peut maintenant via le même serveur communiquer directement avec le poste de Marie-Thérèse

Une fois que c'est fait, le scammer peut:
- collecter toutes les frappes clavier en mode keylogger
- accéder aux fichiers

Il n'est pas obligé d'obtenir des informations personnelles de la personne puisque l'application 
installée peut collecter des données, réinitier des communications plus tard avec le serveur etc.


