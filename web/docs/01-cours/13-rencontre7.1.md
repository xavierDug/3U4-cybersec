---
id: r13
title: Rencontre 13 - Stratégies de sauvegarde
sidebar_label: R13 - Stratégies de sauvegarde
draft: true
hide_table_of_contents: false
---

Quand on parle de sauvegarde, on parle de défendre l'intégrité des données principalement:
> *&laquo; J'ai quelque chose de précieux, je ne veux pas le perdre pour toujours &raquo;*


Quand on parle de stratégie de sauvegarde, on va principalement répondre aux questions suivantes:
- **Quoi?** Qu'est-ce que je sauvegarde? ... ordinateur au complet, dossiers de contenu, configurations
- **Quand?** À quelle fréquence ... combien de travail suis prêt à perdre? horaire, quotidien, mensuel, annuel
- **Où?** sur le même disque? sur le même ordi? dans le même batiment? même pays? même continent? même planète?


## Exemples à discuter en classe

Nous allons discuter des scénarios suivants:

### Scénario 1: Le lanceur d'alerte

A.A. (on ne gardera que ses initiales pour conserver son anonymat) a trouvé 30 Go de données
ultra compromettantes pour un gouvernement corrompu. Il souhaite absolument s'assurer que rien ne
disparaitra jamais.

Quelle stratégie adopter pour sa sauvegarde (quoi? fréquence? où?)


### Scénario 2: L'étudiant et ses travaux

Andy a mis beaucoup d'efforts dans ses travaux. Il y a même des TP qui fonctionnent c'est fou.
Du coup, il aimerait vraiment beaucoup ne pas les perdre.
- Il a un ordi à la maison mais avec un seul disque.
- Il voudrait vraiment que ça soit pas cher, genre gratuit en fait

Quelle stratégie adopter pour sa sauvegarde (quoi? fréquence? où?)


### Scénario 3: L'admin et son site web

John Jean est administrateur d'un site web tout petit qui change jamais. Il a passé un peu de temps
à faire la configuration de Apache. Le contenu du site a été fait par un jeune génie mais on ne sait plus
trop où il est est John Jean bah il comprend rien en HTML.

Quelle stratégie adopter pour sa sauvegarde (quoi? fréquence? où?)


## Médiums de stockage pour les sauvegardes

Les sauvegardes peuvent s'effectuer sur différents médiums, chacune possédant leurs avantages en inconvénients en termes de coût, quantité de stockage et vitesse de traitement:
- Disques durs conventionnels (support magnétique à plateaux)
- Disques SSD
- Infonuagique
- Médiums de stockage amovible (clé USB)
- Stockage optique (CD, DVD, Blu-Ray)
- Bandes magnétiques (*tape-drive*)

:::info Exercice
Plusieurs solutions de sauvegarde utilisent des cassettes à bandes magnétiques. Est-ce une technologie désuète? 

Selon vous, quelle taille peut-on atteindre avec un système à bande? 

**Faites une petite recherche sur Internet d'un modèle / marque de système de back-up à bandes.**
:::


## Emplacement du stockage de sauvegarde

Lorsqu'on élabore une stratégie de sauvegarde, on doit déterminer si les données sauvegardées seront sur le même site physique ou sur un site éloigné. Si les sauvegardes se font sur site, elles sont très rapides à récupérer en cas de panne, et ça coûte moins cher à maintenir car on garde tout chez nous. Cependant, si un incident touche le site (incendie, inondation, etc.) on peut facilement perdre à la fois les données principales et leur sauvegarde. 

C'est pourquoi plusieurs entreprises choisissent de stocker leurs sauvegarde dans un lieu extérieur. Si les sauvegardes sont prises sur un médium physique (optique, bande magnétique, etc.), on peut les expédier dans une voute sécurisée à une bonne distance géographique. On peut aussi opter pour envoyer les sauvegardes par le réseau dans le *cloud* ou chez un fournisseur.

Il arrive souvent qu'on veuille avoir le meilleur des deux mondes. Certains systèmes seront pris en sauvegarde au sein de la même machine avec des disques durs en miroir (une technologique qu'on nomme RAID), en plus d'être envoyé sur un autre serveur localement, en plus d'être pris sur des bandes en envoyé en voûte chez un fournisseur externe. On parlera alors de **redondance**.


## Optimisation de l'espace

Pour être efficaces, les sauvegardes doivent s'effectuer régulièrement. Plus il s'est écoulé de temps entre le moment où la sauvegarde a été effectuée et le moment où on doit la restaurer, plus l'étendue des pertes de données est grande, particulièrement lorsque de nombreux changements ont été faits après la dernière sauvegarde. En fonction de la criticité des données ou de la fréquence à laquelle elles sont modifiées, on peut décider de sauvegarder les données à chaque mois, à chaque semaine, à chaque jour, ou même en continu. De plus, il existe plusieurs méthodes pour réduire l'utilisation de l'espace de stockage.


### Sauvegarde complète

Une sauvegarde complète copie tous les fichiers et données sélectionnés à chaque fois qu'une sauvegarde est effectuée. C'est la forme la plus simple de sauvegarde et facilite la récupération des données, simple à gérer et à comprendre. Mais cette méthode est très exigente en ressources et en temps, car elle implique de copier de fichiers intégralement à chaque fois, même si ce fichier n'a pas changé.


### Sauvegarde incrémentielle

La sauvegarde incrémentielle copie uniquement les fichiers qui ont changé depuis la dernière sauvegarde. Cette méthode peut être très efficace en temps et en stockage, surtout si les données changent peu ou très partiellement. Cependant, cela complique la gestion et la récupération, car il faut avoir toutes les sauvegardes.


### Sauvegarde différentielle

La sauvegarde différentielle est un compromis entre la sauvegarde complète et la sauvegarde incrémentielle. Elle inclut tous les fichiers ou éléments d'information qui ont changé depuis la dernière sauvegarde complète. Elle est plus rapide que la sauvegarde complète mais moins que la sauvegarde incrémentielle.

Souvent, on opte pour un mode de sauvegarde hybride. Par exemple, une sauvegarde complète chaque dimanche et une sauvegarde différentielle pour les autres jours. Pour récupérer les backups, on aura donc simplement à rappeler le backup de la veille et celui du dernier dimanche pour reconstituer le système au complet.


### Sauvegarde en miroir

Une sauvegarde en miroir crée une copie des données immédiatement au moment une sauvegarde a lieu. C'est très fiable mais ça demande un très haut débit entre les système. On va voir ce type de sauvegarde au sein du même serveur (équipe de deux disques durs écrits en même temps) ou entre deux serveurs très proche l'un de l'autre sur le réseau. C'est une solution souvent très coûteuse puisqu'il implique de doubler l'espace de stockage et exige que le médium soit à haute performance.


### Sauvegarde en continu

Une sauvegarde en continu sauvegarde les fichiers en temps réel ou à intervalles très courts. Tout comme pour le miroir, les données sont toujours à jour, ou presque (on va peut-être perdre les modifications qui ont eu lieu 5 minutes après la panne). Mais ça peut consommer beaucoup de ressources système pour gérer les cycles de synchronisation, l'intégrité des fichiers, etc. L'infrastructure nécessaire pour ce type de sauvegarde est aussi plus complexe.


### La compression

Pour économiser de l'espace, il arrive souvent qu'on compresse les données avant de les stocker. Toutefois, certains formats de données se compressent plus efficacement que d'autres; par exemple, un fichier texte se compresse très bien à un très haut ratio, alors qu'une image JPEG ou une vidéo H.265 se compressera très mal (car elle est déjà compressée). Par ailleurs, les opérations de compression et de décompression demandent du calcul de la part du processeur.


### La déduplication

La déduplication de données est une technique d'optimisation de stockage qui vise à éliminer les copies redondantes de données pour réduire l'espace de stockage nécessaire. Elle fonctionne par l'identification de doublons dans des parties des fichiers. Les données sont séparés en blocs de données plus ou moins volumineux selon l'algorithme utilisé, et si le système voit de la répétition, il stocke ce bloc à un seul endroit. C'est particulièrement utile pour stocker des gros fichiers qui changent souvent mais légèrement à chaque fois, ou lorsqu'il y a un grand nombre de fichiers qui sont "presque" identiques avec seulement des différences mineures. Par contre, la déduplication implique l'utilisation d'algorithmes complexes et de systèmes sophistiqués, qui exigent beaucoup de traitement de la part du processeur, ce qui peut avoir un impact sur la performance.



## Discussions

- Est-ce que **OneDrive** est un système de sauvegarde?

- Est-ce que **Git / Github** est un système de sauvegarde?

- Quel type de sauvegarde nous protège contre un *ransomware* qui chiffre nos données?


## ANNEXE: Chiffrement

Le chiffrement (encryption) des données stockées est un moyen de protéger ces dernières contre le vol ou l'accès non autorisé. Contrairement au hachage, le chiffrement est un processus bidirectionnel. Les opérations mathématiques qui convertissent les données en charabia sont réversibles pour quiconque possédant une **clé**. Nous reviendrons sur les détails du chiffrement plus tard dans la session.

Le chiffrement peut être implémenté à différents niveaux:
- Au niveau du stockage des données, dans le médium qui les contient
- Au niveau de la transmission des données, pendant leur envoi et leur réception

Le chiffrement de la transmission sera abordé plus tard dans la session. Le chiffrement des données stockées peut se faire de plus d'une manière. Par exemple:
- Au niveau d'une application spécifique (base de données, fichier Zip, PGP, VeraCrypt, etc.)
- Au niveau du système de fichiers (NTFS EFS sous Windows, ZFS sous Linux, FreeBSD et MacOSX)
- Au niveau des blocs sur le disque (BitLocker sous Windows, FileVault)
- Au niveau physique (SED, OPAL)

Pour protéger les fichiers contenus sur un disque dur, on optera généralement pour le chiffrement du système de fichiers ou au niveau des blocs. Il est important de noter certaines différences entre les deux:
- Le chiffrement au niveau du système de fichiers ne chiffre que le **contenu** des fichiers. Les métadonnées comme le nom du fichier, sa taille ou son emplacement dans l'arborescence ne sont pas chiffrées.
- Le chiffrement au niveau des blocs (chiffrement intégral du disque) a besoin que la clé de déchiffrement soit stockée à l'extérieur du système, du moins en partie, autrement le système d'exploitation ne pourra pas démarrer. Cela se fait habituellement soit en demandant à l'utilisateur de fournir l'élément manquant à la clé (NIP, mot de passe, clé USB, SmartCard, etc.) avant que le système d'exploitation ne puisse démarrer, soit en la stockant dans une puce appelée TPM connectée à la carte mère.

L'exemple de l'accès physique au disque dur et du boot avec un médium de démarrage auraient tous deux pu être évités à l'aide de ces deux stratégies de chiffrement.

:::caution
Il est essentiel de posséder la clé de déchiffrement afin de déchiffrer des données chiffrées. Si on perd la clé, les données sont perdues à tout jamais.
:::


