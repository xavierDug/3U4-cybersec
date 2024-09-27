---
id: r12
title: Rencontre 12 - Droits et privilèges
sidebar_label: R12 - Droits et privilèges
draft: true
hide_table_of_contents: false
toc_max_heading_level: 4
---

Dans un système d'information, les termes "droit" et "privilège" sont souvent utilisés de manière interchangeable, mais ils ont des nuances distinctes.

Un **droit**, ou **permission**, est une autorisation accordée à un utilisateur ou à un groupe d'utilisateurs pour effectuer une action spécifique sur une ressource comme un fichier ou un répertoire. Par exemple, Bob aura un accès en lecture seule sur le fichier patate.docx, alors que Alice aura les accès suffisants pour écrire et modifier ce même fichier.

Un **privilège** désigne une autorisation plus large, qui permet à un utilisateur d'effectuer des actions potentiellement sensibles ou critique sur le système, ou pouvant affecter plusieurs utilisateurs. On parlera souvent de privilèges d'administration, qui confèrent à un utilisateur le droit d'installer une application, de modifier des paramètres système ou d'accéder sans restriction à l'ensemble des fichiers de l'ordinateur.

Les systèmes permettent l'attribution des permissions et des privilèges avec un niveau de détail plus ou moins grand. On appelle ce concept la **granularité**. Plus la granularité est fine, plus il est possible de spécifier précisément quelles actions un utilisateur peut effectuer sur quelles ressources. Par exemple, le système de fichiers sous Linux utilisent un système de permissions très simple, composé de trois niveaux (lecture, écriture, exécution) pour trois identités (propriétaire, groupe, tous les autres). Windows, quant à lui, offre un système de permissions beaucoup plus granulaire (et complexe) au moyen de liste de contrôle d'accès (ACL).


## Permissions sous Linux

Le système de permissions de fichiers sous Linux (et autres systèmes de type UNIX comme MacOSX et BSD) est basé sur trois catégories d'utilisateurs et trois types de permissions.


### Fonctionnement des permissions

Chaque fichier et dossier possède un **utilisateur propriétaire**, un **groupe propriétaire** et une **table de permissions** qui définit le niveau d'accès pour ses trois catégories d'utilisateurs:

- L'**utilisateur propriétaire** désigne le compte utilisateur qui possède le fichier ou le dossier. C'est généralement son créateur. Les fichiers appartenant à l'administrateur du système ont pour propriétaire l'utilisateur `root`.
- Le **groupe propriétaire** désigne un ensemble d'utilisateurs qui partagent des permissions communes sur le fichier ou le dossier. Les groupes sont définis dans le fichier `/etc/groups`. Souvent, c'est un groupe qui s'appelle comme l'utilisateur et qui ne contient que l'utilisateur.
- La **table de permissions** contient les permissions conférées à l'utilisateur propriétaire, au groupe propriétaire ainsi qu'à tous les autres utilisateurs.

On peut voir ces trois éléments avec la commande `ls -al`:

```
bob@machine:~$ ls -al
total 5
drwxr-x--x 14 bob  bob  4096 Sep 27 14:35 .
drwxr-xr-x 17 root root 4096 Feb 10  2023 ..
-rw-rw-r--  1 bob  bob   132 Dec 17  2022 allo.txt
-rw-rw-r--  1 bob  bob   176 Dec 18  2022 bonjour.txt
drwxrwxr-x  1 bob  bob   176 Oct 11  2023 mondossier
│└┬┘└┬┘└┬┘   └─┬─┘└─┬─┘
│ │  │  │      │    │
│ │  │  │      │    └── Groupe propriétaire (g)
│ │  │  │      └─────── Utilisateur propriétaire (o)
│ │  │  │               ┌──────────────────────┐
│ │  │  │            ┌──│ TABLE DE PERMISSIONS │────────────────────────────┐
│ │  │  │            │  └──────────────────────┘                            │
│ │  │  └────────────┼─ Permissions (rwx) des autres utilisateurs (o)       │
│ │  └───────────────┼─ Permissions (rwx) du groupe propriétaire (g)        │
│ └──────────────────┼─ Permissions (rwx) de l'utilisateur propriétaire (u) │
│                    └──────────────────────────────────────────────────────┘
└────────────────────── Indique si c'est un répertoire (d) ou non (-)
```

La table de permissions est constituée de 3 parties:
- Utilisateur propriétaire (u)
- Groupe propriétaire (g)
- Autres utilisateurs (o)

Pour chaque catégorie, il existe trois permissions possibles:

|         | Permission | Valeur | Effet sur un fichier             | Effet sur un répertoire                                                     |
| ------- | ---------- | ------ | -------------------------------- | --------------------------------------------------------------------------- |
| **`r`** | lecture    | 4      | Lire le contenu du fichier       | Lister les fichiers et sous-répertoires dans le répertoire                  |
| **`w`** | écriture   | 2      | Modifier le contenu du fichier   | Ajouter et supprimer des fichiers et des répertoires                        |
| **`x`** | exécution  | 1      | Exécuter le fichier ou le script | Traverser le répertoire pour accéder à des fichiers ou des sous-répertoires |


### Modifier les permissions (chmod)

La commande pour modifier les permissions d'un fichier est `chmod` et s'utilise au moyen de deux types de notation: symbolique et numérique.

:::info Permissions nécessaires
Pour effectuer des changements sur la table de permissions, il faut soit:
- Être **propriétaire** du fichier ou du répertoire
- Être le **superutilisateur** du système (*root*) ou précéder la commande de `sudo` (en supposant qu'on dispose du privilège de *sudoer*)
:::

#### Notation symbolique

La notation symbolique utilise des lettres pour représenter les utilisateurs et les types de permissions :
- **`u`** : utilisateur (propriétaire)
- **`g`** : groupe
- **`o`** : autres utilisateurs
- **`a`** : tous (u, g, et o)

Les types de permissions sont représentés par :
- **`r`** : lecture
- **`w`** : écriture
- **`x`** : exécution

Les opérateurs utilisés sont :
- **`+`** : ajouter une permission
- **`-`** : retirer une permission
- **`=`** : définir une permission exacte

:::note Exemples
**`chmod u+r ./fichier.txt`**
> Ajoute (+) la permission de lecture (r) à l'utilisateur propriétaire (u)

**`chmod g-w ./fichier.txt`**
> Retire (-) la permission d'écriture (w) au groupe propriétaire (g)

**`chmod o=x ./fichier.txt`**
> Définit (=) la permission d'exécution (x) aux autres utilisateurs (o)

**`chmod a=rwx ./fichier.txt`**
> Définit (=) tous les droits (rwx) à tout le monde (a)

**`chmod u=rw,og=r ./fichier.txt`**
> Définit (=) des droits en lecture et écriture (rw) à l'utilisateur propriétaire (u) et des droits en lecture seule (r) au groupe et aux autres (og)
:::


#### Notation numérique (octale)

La permission effective peut être toute combinaison de *x*, de *w* et de *r*. Chacune de ces composantes est un *drapeau* qui peut être représenté par un *bit* qui est soit activé (1) ou inactif (0). Il y a donc 3 bits, donc 2^3 possibilités, soit 8 au total. On peut les représenter à l'aide d'un chiffre de 0 à 7.

| Permission | Valeur binaire | Valeur octale | Description                          |
| ---------- | -------------- | ------------- | ------------------------------------ |
| `---`      | `000`          | **0**         | Aucun droit                          |
| `--x`      | `001`          | **1**         | Exécution seulement                  |
| `-w-`      | `010`          | **2**         | Écriture seulement                   |
| `-wx`      | `011`          | **3**         | Écriture et exécution                |
| `r--`      | `100`          | **4**         | Lecteure seulement                   |
| `r-x`      | `101`          | **5**         | Lecture et exécution                 |
| `rw-`      | `110`          | **6**         | Lecture et écriture (sans exécution) |
| `rwx`      | `111`          | **7**         | Accès complet                        |

Comme il y a trois types d'utilisateur, la table de permissions se résume à un nombre constitué de trois chiffres de 0 à 7.
- Le premier pour l'utilisateur propriétaire (u)
- Le deuxième pour le groupe propriétairte (g)
- Le troisième pour les autres utilisateurs (o)

:::note Exemple
La table de permissions `rwxr-x--x` donne **751** en octal, car:
- `rwx` pour l'utilisateur propriétaire, donc **7**
- `r-x` pour le groupe propriétaire, donc **5**
- `--x` pour les autres utilisateurs, donc **1**

Ainsi, la commande `chmod 751 ./fichier.txt`  modifie la table de permissions à `rwxr-x--x`.
:::

:::caution
La commande `chmod 777` ou `chmod a=rwx` affecte des droits complets pour tout le monde. C'est habituellement une mauvaise pratique.
:::


### Modifier le propriétaire (chown)

Pour modifier l'utilisateur propriétaire et/ou le groupe propriétaire d'un fichier ou d'un répertoire, il faut utiliser la commande `chown`. Les privilèges nécessaires sont les mêmes que pour la `chmod`: il faut disposer de privilèges administratifs ou être propriétaire de la ressource.

- Pour modifier l'utilisateur propriétaire pour "bob": `chown bob ./fichier.txt`
- Pour modifier le groupe propriéraire pour "profs": `chown :profs ./fichier.txt`
- Pour modifier les deux en même temps: `chown bob:profs ./fichier.txt`

:::tip
N'oubliez pas! Si vous disposez de privilèges d'administration sur la machine, vous pouvez modifier les permissions et les propriétaires sur n'importe quelle ressource même si vous n'êtes pas propriétaire de celle-ci. Il vous suffit d'utiliser la commande `sudo`.

Exemple:
```bash
sudo chown bob:profs ./fichier.txt
sudo chmod 775 ./fichier.txt
```
:::


### Modification récursive

Pour modifier récurs


## Permissions sous Windows

Le système de permissions du système de fichiers sous Windows utilise des listes de contrôle d'accès (ACL) pour gérer les autorisations. Chaque fichier et dossier possède une ACL qui spécifie les droits d'accès pour les utilisateurs et les groupes. Les permissions courantes incluent la lecture, l'écriture, l'exécution et la modification. Les administrateurs peuvent définir des permissions de manière granulaire pour contrôler précisément qui peut accéder et modifier les ressources.







## Privilèges


## Granularité



```text
On souhaite limiter au maximum les permissions, droits ou privilèges d'un utilisateur. 
On souhaite lui fournir les droits nécessaires mais uniquement ceux-ci.
```

On est parfois tentés quand on commence et qu'on est tannés que ça ne marche pas de lancer un
```bash
chmod 777 -R /dossier
```
Hop le TP fonctionne, super je suis maintenant un admin système Linux expert.

On vient de mettre le doigt sur un des problèmes classiques de la cybersécurité:
- l'informatique ça marche jamais et c'est dur de savoir pourquoi ça marche pas
- dans le processus pour arriver à un système fonctionnel, on peut ouvrir beaucoup trop de droits
- quand le système marche, on est fatigués, le client nous a payé
- et si je change de quoi, peut-être que ça ne marchera plus **si c'est pas brisé, n'y touche pas**

Avance rapide 6 mois plus tard, on se rend compte que le stagiaire de DEC qu'on a pris pour l'été
a eu accès aux comptes de campagne de notre parti et tout s'est retrouvé dans les medias.

En plus on a aucun moyen de prouver que c'est lui, vu que tout le monde a les droits!!!!

## Approche pour limiter les droits

Verifiez que les personnes qui ne devraient pas avoir accès n'ont pas accès.

On va donc voir ça sous l'angle vulnéraibilité / exploit / correctif:
- la vulnérabilité est des permissions trop larges
- l'exploit est un accès non autorisé par un utilisateur sur le poste avec toutes les étapes détaillées
- le correctif est de limiter les permissions, on va pouvoir valider ce correctif comme tous les correctifs
  en s'assurant que l'exploit ne marche plus.

## Travail pratique Linux

Il y a dans le travail pratique Linux un problème qui est dû à des permissions trop larges.

Vous devrez valider avec le prof que vous avez bien identifié le problème et fournir un correctif.

Pour rappel, on valide un correctif en s'assurant que l'exploit prévu :
- fonctionne avant le correctif
- ne fonctionne plus après le correctif


