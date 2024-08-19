---
title: Rencontre 24 - Chiffrement symétrique (attaque)
sidebar_label: R24 - Chiffrement symétrique (attaque)
draft: true
hide_table_of_contents: false
---



# Rencontre 12.2 : Encryption symmétrique, on attaque

## Un algo d'encryption symmétrique

Un couple de fonctions *encrypt(key, message)* et *decrypt(key, message)* qui permettent de 
1. transformer une message en bouillie illisible
2. récupérer le message à partir de la bouillie illisible pour peu qu'on utilise la même clé

## Le code de César, un vieil exemple

Un exemple avec un code de décalage (aussi appelé le code de César):
- "Upk35t3k350p2knzy4py4kopk4pk6zt2k" est le message encrypté, la bouillie
- la clé d'encryption est 11
- la personne qui décode doit en fait prendre la lettre qui est 11 rang plus bas sur la table d'encryptio
- https://jorisdeguet.github.io/cesar.html

## Comment on peut casser ça

```
Le secret ne repose pas dans l'ignorance de l'algorithme mais dans l'ignorance de la clé!!
```

Donc essentiellement, pour casser le code de César, il suffit de trouver la clé. 

Pour cela on peut utiliser plusieurs techniques:
- essayer d'être malin
- y aller comme une grosse brute

### Exemple malin

Reprenons notre exemple de "Upk35t3k350p2knzy4py4kopk4pk6zt2k"
- il y a 2 symboles très très fréquents en français: l'espace et le 'e'
- on va compter les caractères dans la chaîne cryptée:
  - il y a 7 'k'
  - il y a 5 'p'
- on peut imaginer que le 'k' est l'espace ou que le 'k' est le 'e'
- la clé qui transforme espace en 'k' est 11
- la clé qui transforme 'e' en 'k' est 60
- si on décode avec la clé 11 on obtient "Je suis super content de te voir "
- si on décode avec la clé 60 on obtient ""


### Exemple brutal

### Exercices

Etant donné un message encrypté avec le code de César, essaie de 

## Si il y a symétrique, il doit y avoir asymétrique



