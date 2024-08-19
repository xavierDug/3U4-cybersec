---
id: r01
title: Rencontre 1 - Accueil
sidebar_label: R01 - Accueil
draft: false
hide_table_of_contents: false
---


On va passer à travers le plan de cours ensemble.

Le cours se divise en 3 parties:
- introduction aux fondements de la cybersécurité
- cybersécurité des réseaux et postes de travail
- cybersécurité applicative

## Créer le hash d'un mot de passe avec MD5

On va y revenir plus tard mais avant de stocker un mot de passe en BD, on le hash. [wikipedia](https://fr.wikipedia.org/wiki/Fonction_de_hachage_cryptographique)

Pour aujourd'hui on va utiliser l'algorithme MD5.

ATTENTION : pour les activités d'aujourd'hui, n'entre jamais un mot de passe que tu utilises réellement.

## Activité créer des hash (5 minutes)

1. Va sur le site https://www.md5hashgenerator.com
2. Entre un premier exemple de mot de passe, par exemple : **ceci est mon super mot de passe** et regarde le hash MD5
3. Maintenant ajoute simplement un caractère à la fin (pour moi **ceci est mon super mot de passe!**) et regarde le hash
   - les mots de passe sont similaires
   - est-ce que les hash sont similaires?
4. Fais-toi une liste de plusieurs mots de passe que tu penses faciles à craquer, d'autres moins simples et un ou 2 que tu penses vraiment hardcore. Note le mot de passe et le hash correspondant dans un fichier texte.
   - un nombre de 10 chiffres
   - un nombre de 20 chiffres
   - essaie un mot de passe long mais simple comme **ceci est mon secret le plus secret ahah**
   - essaie un mot de passe court (5-6 caractères) mais avec des trucs spéciaux **P%9Ab8$**


### Retour sur l'activité
Quelques questions qu'on discutera à la fin de l'activité:
- Est-ce que tous les hashs ont la même longueur? (tu peux les aligner dans notepad++ pour mieux voir le nombre de caractères de chacun)
- Du coup, il y a un nombre de hash limité?
- Est-ce que le nombre de mot de passe est limité?
- Est-ce qu'il y a des mots de passe différents qui auraient le même hash?
- Est-ce que ça semble facile de deviner le mot de passe si je te donne le hash?

## Activité : craquer un mot de passe

On va utiliser le site [Crack Station](https://crackstation.net) pour cette activité:

1. On va commencer en entrant les hash suivant dans le site:
```text
dc647eb65e6711e155375218212b3964
eb61eead90e3b899c6bcbe27ac581660
958152288f2d2303ae045cffc43a02cd
2c9341ca4cf3d87b9e4eb905d6a3ec45
75b71aa6842e450f12aca00fdf54c51d
031cbcccd3ba6bd4d1556330995b8d08
b5af0b804ff7238bce48adef1e0c213f
```
2. Tu devrais voir que certains mots de passe ont été craqués d'autres non.
3. Maintenant en prenant les md5 que tu as générés dans la première activité en les mettant dans le même format que le bloc de l'étape 1 regarde quels sont ceux qui ont été craqués ou pas.

### Retour sur l'activité

- Selon vous, comment marche le site Crack Station?
- Qu'est-ce qui semble important pour qu'un mot de passe soit sécuritaire? Sa longueur? Autre?

## Activité **salage**











#### zzzz
Pour se mettre dedans:
1. copie le fichier \\ed5depinfo\Logiciels\_Cours\3U4\kali-linux.........7z sur ton poste
2. décompresse le
3. ouvre la machine virtuelle (.vmx) avec VMWare Workstation
4. une fois la machine virtuelle partie, connecte toi avec kali (utilisateur) puis kali (mot de passe)

Tu viens de partir Kali, une distribution linux spécialisée pour la cybersec. 

Elle contient de nombreux outils qui seront bien utiles.

Craquons quelques mots de passe:
- tu as récupéré un dump de la base de données d'un vieux site en PHP MySQL
- tu as la colonne des passwords de cette bd
- tu as mis tous les hashs de mot de passe dans un fichier texte
- tu sais que ce site utilise l'algo de hachage MD5

```text
dc647eb65e6711e155375218212b3964
eb61eead90e3b899c6bcbe27ac581660
958152288f2d2303ae045cffc43a02cd
2c9341ca4cf3d87b9e4eb905d6a3ec45
75b71aa6842e450f12aca00fdf54c51d
031cbcccd3ba6bd4d1556330995b8d08
b5af0b804ff7238bce48adef1e0c213f
```

### Avec la liste de mot de passe rockyou

La liste rockyou est une liste de plus de 14 millions de mots de passe qui ont déjà fuité dans des 
fuite de données. Elle se trouve dans Kali mais compressée. On va la décompresser:
- tape **gunzip /usr/share/wordlists/rockyou.txt.gz**
- le fichier produit va se retrouver dasn /usr/share/wordlists/rockyou.txt
- tape **less /usr/share/wordlists/rockyou.txt**

Maintenant, on va pouvoir demander à hashcat de casser les mots de passe avec ce dictionnaire.


