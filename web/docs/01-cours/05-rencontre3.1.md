---
id: r05
title: Rencontre 5 - Faille, exploit, correctif
sidebar_label: R05 - Faille, exploit, correctif
draft: true
hide_table_of_contents: false
---

# Vulnérabilité, exploit, correctif

## Vulnérabilité

Essentiellement, c'est le morceau faible du système. Cela peut être technologique ou humain.

## Exploit

Là il s'agit des étapes pour exploiter la vulnérabilité. Un exploit est souvent complexe avec beaucoup d'étapes.

Essentiellement il s'agit d'un recette détaillée avec des ingrédients et des étapes qu'une personne qualifiée
peut appliquer pour mener à bien l'attaque en "exploitant" la vulnérabilité.

## Correctif

Il s'agit de la solution pour corriger la vulnérabilité. 

On peut valider un correctif en s'assurant que l'exploit ne fonctionne plus.
- si l'exploit marche toujours ce n'est pas un correctif
- si l'exploit ne marche plus, c'est un correctif

## Exemple 1:

Formuler l'exemple suivant en terme de vulnérabilité, exploit et correctif:

Résumé :
```
on est rendus le 28 décembre et demain c'est la date limite pour remettre les notes. Plusieurs profs
commencent à se plaindre: la plupart du temps, on ne peut pas accéder et quand on accède c'est très lent.
```

### Vulnérabilité

Le système Omnivox est calibré pour l'usage normal mais pas beaucoup plus. 

Les serveurs sont hébergés par le collège dans son infrasctructure réseau sans équipement dédié
au attaques de type déni de service

### Exploit

- J-15, un étudiant modifie un script pour envoyer des requêtes en rafales et en parallèle
  - il se base sur l'article suivant en changeant les URL pour pointer vers Omnivox
  - il teste son logiciel pour valider qu'il peut envoyer 1000 requêtes par seconde sur son PC
  - il limite la durée de l'attaque à 10h ce qui permettra de dépasser la date limite de remise
- J-10, un étudiant a parti un groupe de conversation sur un serveur Discord avec une invitation à joindre
- J-10 à J-1, les participants rejoignent le groupe jusqu'à atteindre 1000 personnes
- H-12, un message est envoyé sur le Discord pour annoncer le début de l'attaque dans 12 heures
- Moment de l'attaque, les 1000 participants lancent le script en même temps 
  - ça produit une charge d'environ 800 000 requêtes par seconde
  - les 1000 participants réalisent en tentant d'accéder à Omnivox que l'attaque est un succès
- H+10, l'attaque cesse quand la plupart des machines arrivent à la fin du script

### Correctif

Il y a souvent plusieurs pistes pour un correctif:
- augmenter la capacité des serveurs
- investir dans un équipement réseau en avant des serveurs qui détecte des pics de requêtes venant d'une IP
et les bannit temporairement
- mettre en place des traces des requêtes pour identifier les attaquants. 
  - Ce correctif n'empêche pas l'attaque en tant que tel
  - Il augmente le risque de conséquences pour l'attaquant
  - On peut alors avoir un risque pour l'attaquant (renvoi du collège) qui garantit quasiment qu'il n'y aura
plus jamais assez d'attaquant pour mener une attaque de ce type

## Exemple 2:

Résumé :
```
un étudiant a placé un keylogger physique sur le poste du prof dans le local D0605. Il a pu récupérer les mots de passe
des 8 profs qui donnent des cours dans ce local. 
Cela inclut son prof pour un cours qu'il est au bord de couler.
```

### Vulnérabilité

L'accès physique aux ordinateurs des profs est possible et il n'y a pas de moyen de surveillance des classes.

### Exploit

- acheter un keylogger physique sur un site de vente en ligne
- attendre une fin de journée un vendredi pour installer le keylogger
  - fermer la porte du local temporairement
  - glisser sa main derrière le poste pour débrancher le clavier
  - brancher le clavier USB du prof dans le keylogger
  - brancher le keylogger dans le port USB du poste
- attendre une période suffisamment longue pour que le keylogger ait enregistré des mots de passe
- revenir pour récupérer le keylogger en procédant à l'inverse de la première étape

### Correctif

Les détails de l'exploit permettent de trouver un correctif:
- on pourrait empêcher une main de passer derrière les postes
  - espace plus serré
  - boite complètement fermée
- on pourrait empêcher l'accès sans être détecté
  - avec des caméras dans les locaux
  - avec une caméra sur l'arrière des postes
- on pourrait limiter la durée de l'attaque
  - s'assurer qu'un technicien passe régulièrement inspecter les postes
  - former les profs pour qu'ils valident que rien n'est branché en arrière en début de cours

### Leçons

- si on ne sait pas comment l'attaque a été menée, on ne peut pas trouver de correctif
- on essaie de se défendre un peu à l'aveugle

## Exercice A par groupe de 4 :  

```
Joris un des profs du département d'informatique a reçu un courriel venant d'un collègue d'un autre
collège. Dedans il y avait un .exe avec supposément la démo d'un TP dans un cours qu'il donne.

En ouvrant le .exe depuis son poste au collège, apparemment rien ne se passe. Il continue ses affaires.

Une heure plus tard, il essaie d'ouvrir un fichier sur son disque réseau Z: et il y a un fichier 
"LIS_MOI.txt" qui accompagne un énorme fichier "stuff.encrypted", tout le reste a disparu.
```


## Exercice B par groupe de 4 :

```
Giacomo après avoir configuré son serveur de courriel et authentifié son domaine avec SPF, DKIM et DMARC 
se rend compte qu'il peut envoyer des courriels "@cegepmontpetit.ca" avec n'importe quel préfixe.

Il commence par envoyer un courriel à son prof de la part de la direction du collège pour lui dire qu'il a
maintenant le droit à 50% de temps supplémentaire pour ses examens.
```
