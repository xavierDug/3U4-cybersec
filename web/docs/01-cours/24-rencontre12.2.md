# Rencontre 12.2 : Encryption symmétrique, on attaque

## Un algo d'encryption symmétrique

Un couple de fonctions *encrypt(key, message)* et *decrypt(key, message)* qui permettent de 
1. transformer une message en bouillie illisible
2. récupérer le message à partir de la bouillie illisible pour peu qu'on utilise la même clé

Un exemple avec un code de décalage (aussi appelé le code de César):
- "Upk35t3k350p2knzy4py4kopk4pk6zt2k" est le message encrypté, la bouillie
- la clé d'encryption est 11
- la personne qui décode doit en fait prendre la lettre qui est 11 rang plus bas sur la table d'encryptio
- https://jorisdeguet.github.io/cesar.html



