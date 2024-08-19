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

## Première activité : casser un mot de passe

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


