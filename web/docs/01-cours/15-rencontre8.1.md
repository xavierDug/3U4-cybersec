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

### Le cas de scammer sans scrupule qui opère de l'étranger


