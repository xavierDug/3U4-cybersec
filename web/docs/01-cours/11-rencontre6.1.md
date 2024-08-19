---
id: r11
title: Rencontre 11 - HTTPS et certificats
sidebar_label: R11 - HTTPS et certificats
draft: true
hide_table_of_contents: false
---
# Rencontre 6.1 : vie privée et cybersécurité

## Une page web, une requête? Qui reçoit des requêtes quand je navigue sur Internet? (5 minutes par toi-même)

Nous allons utiliser l'inspecteur de Chrome pour regarder quels sont les cookies que tu envoies à quels sites.

Pour commencer, pars un fichiers **cookies-suivi.md** dans ton dossier / repo pour le cours
- indique dedans un site d'information que tu consultes parfois
- indique un site de commerce en ligne que tu utilises parfois

Tu vas maintenant explorer un peu les cookies:
- ouvre les outils de dev dans un navigateur Chrome (dans n'importe quelle page, clic droit > inspecter)
- dans les outils de dev, tu trouveras plusieurs onglets (Elements, console, sources etc.)
- on va s'intéresser à **Network** et **Application**
- ouvre d'abord le site d'information que tu as choisi
- choisi l'onglet **Network** dans les outils
- recharge la page, tu devrais voir 1. une ligne du temps qui représente les différentes requêtes réseau 2. une liste en dessous avec chaque requête
- dans le champs **filter** on va taper d'abord **google.com** pour voir si des requêtes sont partis chez Google puis **facebook** pour voir si des requêtes sont allées chez Facebook
- explore les requêtes trouvées et en regardant l'onglet Headers du détail, trouver l'URL demandée (Request URL) pour vérifier que la requête part bien chez Google ou Facebook
- Copie l'url du site que tu demandée (pour moi lapresse.ca) et l'url envoyée à Google dans ton fichier MD

### Retour en classe (5 minutes)

Nous allons discuter ensemble sur les questions suivantes:
1. Pourquoi le site que j'explore envoie autant de requêtes à autant d'autres sites
2. Par exemple, pourquoi un site envoie des requêtes à Google ou Facebook

## Cookies, traqueurs (5 minutes par toi-même)

Une petite histoire sur comment la page Facebook de Catherine lui affiche une annonce pour la pergola qu'elle avait regardé sur le site de Canadian Tire 3 semaines plus tôt.

1. Il y a 10 ans, Catherine a créé son profil Facebook. Depuis elle est toujours connecté sur son Chrome. Elle fait toute sa navigation depuis.
2. Quand elle s'est connectée sur Facebook, un cookie d'authentification s'est ajouté dans son navigateur. Par la suite toutes les requêtes envoyées sur une url en ****.facebook.com envoie ce cookie pour l'authentifier.
3. Il y a 3 semaines en naviguant sur le site de Canadian Tire, Catherine ne le sait pas mais la page envoie une (ou plusieurs requêtes) à Facebook. Là, ça devient intéressant: Canadian Tire ne sait pas que c'est Catherine car le cookie n'est envoyé que dans la requête vers facebook.
   - Catherine pense interagir uniquement avec un site Canadian Tire en regardant les photos d'une super pergola
   - En fait elle envoie des requêtes à plein de site
   - A Facebook elle envoie une requête qui indique l'url du produit et donc le produit
4. Aujourd'hui, elle ouvre sa page Facebook pour voir des photos de sa petite fille
5. Bim, une pub pour ladite pergola:
   - Facebook sait que cette page a été explorée
   - Canadian Tire

### Mode incognito, navigation privée etc.



## NAT, adresse IP et sens de la communication

### C'est quoi NAT?

### Quand je suis à la maison c'est quoi mon adresse IP?



### Le scammer étranger






