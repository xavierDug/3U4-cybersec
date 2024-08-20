---
id: r11
title: Rencontre 11 - HTTPS et certificats
sidebar_label: R11 - HTTPS et certificats
draft: true
hide_table_of_contents: false
---
# Rencontre 6.1 : HTTPS

## Activité encryption

Quand on utilise HTTPS, cela signifie qu'une partie des informations est encryptée / non lisible par quelqu'un qui intercepte le traffic réseau.

Quand vous envoyez un paquet HTTP ou HTTPS, il y a:
1. un corps de la requête
2. les entétes http, avec le corps, cela constitue la requête HTTP
3. la requête est découpée en segment TCP pour que TCP puisse envoyer puis reconstituer la requête à destination, on ajoute donc des entêtes TCP
4. chaque segment voyage sous la forme d'un paquet IP qui ajoute les entêtes comme l'adresse IP de la destination ou encore l'adresse de retour pour la réponse

Selon vous, à main levée HTTPS encrypte:
- uniquement 1. soit le corps
- 1 et 2 toute la requête
- 1 2 et 3
- 1 2 3 et 4 ... c'est top secure

## Le cheminement de notre requête

## Attaque de type Man in the Middle

Imaginons que quelqu'un de pas mal équipé a réussi à:
- effectuer un DNS spoofing sur mon url www.superprof.ca
- il a donc réussi à faire en sorte que les serveurs DNS renvoie son adresse IP au lieu de la nôtre pour www.superprof.ca
- l'utilisateur envoie alors sa requête au serveur du pirate qui établit une connection HTTPS
   1. pour chaque requête il la reçoit, l'ouvre pour voir le contenu puis il envoie une requête avec les mêmes informations au serveur réel le nôtre.
   2. quand il reçoit la réponse de ce serveur, il l'ouvre la lit puis produit une réponse identique pour le client.
 
Ce pirate voit tout le traffic, le client ne se rend compte de rien, le serveur non plus ... aaaaaahhhhhhhh le monde moderne s'écroule.

### La solution : le certificat SSL

Quand un site établit des connexions SSL avec des clients, c'est parce qu'il a un certificat SSL. 
Ce certificat est signé par une autorité de certification (CA) qui garantit que le site est bien celui qu'il prétend être.

Il s'agit encore ici d'encryption asymétrique. Le certificat contient une clé publique qu'il publie mais aussi une clé
privée que l'attaquant de type "man in the middle" ne peut pas obtenir en contacter le site réel et il ne 
peut donc pas répliquer entièrement le comportement du serveur.

Avec cette solution, on ne peut plus se placer en "man in the middle" si le certificat est signé et valide. Par contre, si l'attaquant a eu accès à votre poste et que vous avez une version modifiée de Chrome, on ne peut rien garantir. Mais ça on l'a déjà vu:
```
poste client corrompu = tout est foutu
```




