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

## FAIRE SCHEMA QUI EST SUR LE CHEMIN

## FAIRE LE 




