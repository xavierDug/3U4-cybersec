---
sidebar_position: 1
slug: /
---

# 3U4 : Introduction à la cybersécurité

Dans ce cours, nous allons aborder la cybersécurité en 3 morceaux:
- la cybersec en général, les grands principes, le jargon technique etc.
- des attaques et la défense d'un réseau (équipements et serveurs)
- des attaques et la défense d'une application (application fournie en C#)


## Séances (30 * 2h)

| Semaine                       | Séquence des cours                      | Travaux pratiques  |
|-------------------------------|-----------------------------------------|--------------------|
| [1.1 →](cours/rencontre1.1)   | Plan de cours, premier hack             | --                 |
| [1.2 →](cours/rencontre1.2)   | TODO                                    | Présentation TP 1  |
| [2.1 →](cours/rencontre2.1)   | TODO                                    | 5%                 |
| [2.2 →](cours/rencontre2.2)   | TODO                                    | 10%                |
| [3.1 →](cours/rencontre3.1)   | TODO                                    | 25%                |
| [3.2 →](cours/rencontre3.2)   | TODO                                    | 50%                |
| [4.1 →](cours/rencontre4.1)   | TODO                                    | 75%                |
| [4.2 →](cours/rencontre4.2)   | Intégration                             | 100% remise        |
| [5.1 →](cours/rencontre5.1)   | Formatif cybersec                       | TP2 : cybersec réseau       |
| [5.2 →](cours/rencontre5.2)   | **Examen cybersec**                     | 10%                |
| [6.1 →](cours/rencontre6.1)   | TODO                                    | 20%                |
| [6.2 →](cours/rencontre6.2)   | TODO                                    | 35%                |
| [7.1 →](cours/rencontre7.1)   | TODO                                    | 35%                |
| [7.2 →](cours/rencontre7.2)   | TODO                                    | --                 |
| [8.1 →](cours/rencontre8.1)   | TODO                                    | 60%                |
| [8.2 →](cours/rencontre8.2)   | TODO                                    | 80%                |
| [9.1 →](cours/rencontre9.1)   | TODO                                    | 100% remise        |
| [9.2 →](cours/rencontre9.2)   | TODO                                    | --                 |
| [10.1 →](cours/rencontre10.1) | Formatif cybersec infra                 | --                 |
| [10.2 →](cours/rencontre10.2) | **Examen cybersec infra**               | --                 |
| [11.1 →](cours/rencontre11.1) | Présentation de l'application           | TP3 : cybersec application  |
| [11.2 →](cours/rencontre11.2) | Hachage : attaque                       | 0%                 |
| [12.1 →](cours/rencontre12.1) | Hachage : défense et implantation       | 30%                |
| [12.2 →](cours/rencontre12.2) | Encryption : attaque                    | 30%                |
| [13.1 →](cours/rencontre13.1) | Encryption : défense et implantation    | 60%                |
| [13.2 →](cours/rencontre13.2) | Injection SQL : attaque                 | 60%                |
| [14.1 →](cours/rencontre14.1) | Injection SQL : défense et implantation | 90%                |
| [14.2 →](cours/rencontre14.2) | Intégration                             | 100% remise        |
| [15.1 →](cours/rencontre15.1) | Formatif cybersec applicatif            |                    |
| [15.2 →](cours/rencontre15.2) | **Examen cybersec applicatif**          |                    |



## Liste de courses:
- Flipper Zero (déjà au MAOB)
- Keylogger physique USB A (déjà au MAOB)
- des clés USB avec un linux live pour booter sur une machine et accéder à ses fichiers
- des adapteurs USB-SATA pour sortir le disque, le brancher le copier
- anciens postes avec configuration pour les démo
- https://shop.hak5.org/ => Simuler un Man-in-the-middle avec un Pinapple Wifi, Bash Bunny pour simuler une attaque USB, Lan Turtle comme dans Mr. robot

## Banque d'idées

1. Accueil et plan de cours, premier cassage de mot de passe
2. Ateliers sur keylogger physique, boot externe pour accéder un fichier
3. Atelier sur un fichier physique par groupe de 4 (besoin de 6 postes sur un chariot):
- boot OS externe
- retirer disque et le brancher externe sur un poste
- exemple cassé avec un disque encrypté
4. Nos traces sur Internet (mode incognito, TOR, VPN etc.)
- WHOIS et les recherches "Reverse IP" pour trouver de l'info sur un nom de domaine ou une IP
- VPN, ce que ça fait, est-ce utile pour le citoyen de base? en entreprise? en télé-travail?
- Les cookies, qu'est-ce que ça collecte, comment on nous présente les mêmes pubs sur Facebook et MétéoMedia
5. Catalogues des piratages qui nécessite un accès physique au client :
- sim card cloning
- boot externe
- installation d'un keylogger physique
- Utiliser Hiren's en clé USB pour aller bypasser/reset le mot de passe d'un compte admin local sur un Windows et accéder à tout le disque dur!
- etc.
6. Flipper Zero, démo des fonctionnalités (à voir quand on l'aura reçu) avec morale de cette histoire, ne clique jamais sur le lien
7. Phishing, démo avec :
- un site qu'on leur envoie par MIO avec une url (on peut acheter omnlvox.ca)
- avec l'url d'un clone de Omnivox
- ils rentrent leur login et mot de passe
- ensuite on leur fait changer leur password
- Installer et utiliser un gestionnaire de mot de passe et partager la voûte avec quelqu'un (pico "droits d'accès" dans la 00Q8)
8. Quelques exemples de films / séries et est-ce que c'est plausible ou clairement pas.
- M. Robot
- Die Hard 4
- CSI https://www.youtube.com/watch?v=hkDD03yeLnU&t
9. Formatif
10. Examen sur Analyser des risques en matière de sécurité de l’information
11. Prendre le contrôle d’un routeur /d’un serveur (admin admin) en utilisant le mot de passe par défaut.
12. Intercepter des informations en transit sur un canal non protégé (ex. Requête DNS, IP dest/IP src, FTP/HTTP/telnet, Wifi non chiffré, WireShark). Utiliser le HTTP Stream dans Wireshark pour retrouver une image. Utiliser un filtre dans WireShark pour trouver un mot de passe dans un formulaire http. Examen: donner un .pcap et demander de trouver de l'info dedans.
13. Atelier syn flood
14. Ingénierie sociale et OSINT, deviner le password d’un utilisateur à partir d’un profil (nom date de naissance, loisirs, prénoms enfant)
15. Les courriels:
- empêcher un pirate d'envoyer un courriel depuis mes domaines
- encryption des courriels, quelle est la situation?
16. Récupérer des données sur une vieille clé USB ou un disque
    - Utiliser un outil pour ça (ex. dans les enquêtes numérique pour conserver la preuve)
    - Utiliser Dropbox pour faire des sauvegardes chiffrées de ses fichiers avec CryptoMator ou Veracrypt
    - Durée de vie des différents médium (CD-ROM, tape backup, clé USB, disque SSD, etc.) + Stratégie de sauvegarde 3-2-1
17. Configuration d'un pare-feu
    - Configuration du pare-feu Windows local (ou linux) pour laisser passer une app vers Internet
    - Config du pare-feu Windows local pour qu'un serveur puisse répondre aux ping (ICMP)
    - Utilisation d'un pare-feu pour faire un port-fowarding et atteindre un serveur web local (ex. petit routeur Linksys ou pfSense virtuel)
    - Utiliser nmap pour faire un scan des ports ouverts sur une machine
    - Utiliser SheildsUp! pour faire un scan de ports sur son adresse IP publique (ex. https://www.grc.com/x/ne.dll?bh0bkyd2) et voir la différence entre les résultats du scan local vs public
18. Formatif
19. Examen sur Appliquer des mesures de sécurité reconnues pour protéger le réseau. 
20. Présentation de l’application à sécuriser pour le cours, exécution et débogage d’une fonctionnalité pour se remettre dedans (cible = étudiant de réseau)
21. Identification des failles de l’application en atelier et par groupe, mise en place d’exploit
    - comment un antivirus détecte un exploit (utiliser une signature MD5 + virustotal)
22. Présentation des différents algorithmes de hash et les variantes avec salage
23. Exercices de programmation sur les hachages
24. Période pour implantation dans le travail 3
25. Présentation des algorithmes d’encryption symétrique, différence sym asym
26. Technique pour casser quelques schémas d’encryption primitifs
27. Implantation dans le travail des techniques d’encryption symétrique
28. Séance absence / intégration

