# Rencontre 13.1 Implanter crypto symétrique

Implanter le code C# pour faire la crypto symétrique est assez simple, on peut:
- chercher un peu dans la doc officielle : lien
- chercher sur Google et sauter sur le premier StackOverflow qui a de l'allure
- demander à ChatGPT "comment encrypter avec BlowFish en .NET"
- demander à Github Copilot direct dans mon VisualStudio

Il nous reste à choisir une clé d'encryption pour la plupart des algorithmes:
- il faut que la clé soit difficile à deviner (un pirate pourrait essayer des clés comme il essaie des mot de passe)
- il faut s'assurer qu'on stocke la clé dans un endroit peu accessible

## Décompiler le .exe et trouver la clé

La question du jour, si je connais la clé, je peux ensuite tout lire.

Si on a accès à l'exécutable, dans le code on peut trouver la clé

https://www.jetbrains.com/decompiler/

## Quelles solutions pour cacher la clé

1. Principe #1, la clé ne doit pas être accessible aux utilisateurs. Il faut donc que la partie de la plateforme
qui encrypte se trouve dans les infrastructures de l'entreprise, pas chez les utilisateurs
2. Principe #2, moins il y a de gens qui ont la clé, moins il y a de chances de fuites.
3. On peut donc imaginer que seul le responsable du système en prod a accès à la clé de prod. Les dév peuvent 
avoir accès à une clé différente sur leur environnement de développement.

### Le cas classique du client-serveur

1. L'application cliente envoie les données au serveur, la sécurité des données repose sur HTTPS.
2. Le serveur encrypte les données avant de les stocker en BD, la sécurité repose sur le secret de la clé.


