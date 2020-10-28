# Hospital Management

## Projet

Ce projet a été realise pour le cours de .Net, dans le cadre de la majeure MTI a l'EPITA.

## Groupe de PLIC:

### Federis

* antoine.montes - Antoine Montes
* louis.dufeu - Louis Dufeu
* gauthier.fiorentino - Gauthier Fiorentino
* julien.da-cunha - Julien Da-Cunha

## Pré-requis

* Être sous Windows
* Avoir IIS: https://www.supinfo.com/articles/single/4141-installer-iis-windows-10
* Avoir Visual Studio
* Avoir SQL Server d'installé: https://docs.microsoft.com/fr-fr/sql/database-engine/install-windows/install-sql-server?view=sql-server-ver15
* Avoir Microsoft SQL Server Management Studio


# Comment lancer la solution ?

## Étape 1:

* Récuperer et décompresser l'archive.

## Etape 2:

* Ouvrir le projet dans Visual Studio en cliquant sur le fichier `HospitalManagement.sln`.

## Etape 3:

* Dans la solution HospitalServer, dans le fichier `web.config`, modifiez la `connection string` selon votre systeme.
> La seule partie à modifier devrait normalement être la valeur `Server=...;`.
Cette valeur est le nom de votre serveur SQL, il s'affiche normalement dans Microsoft SQL Server Management Studio.

## Etape 4:

* Ouvrir la console de gestion de packages NuGet.
> Tools => Nuget Package Manager => Package Manager Console

## Etape 5:

* Vérifier que la solution de démarrage est bien `HospitalServer`.
* Vérifier que dans la console, le projet par défault est aussi `HospitalServer`.

## Etape 6:

* Lancer dans la console la commande suivante:

```
PM> Update-Database
```

> Un problème au niveau de SNI.dll peut survenir, c'est un problème récurrent. Installez System.Data.SqlClient dans la solution HospitalServer via le Nuget Package Manager, cela devrait résoudre ce soucis.
> Faire clic droit sur HospitalManagement et Rebuild Solution peut aussi resoudre le soucis.

* La base de donnees vient d'être créee et remplie par des valeurs par defaut.

## Etape 7:

* Vous pouvez lancer la solution `HospitalServer` puis la solution `HospitalClient` (dans cet ordre, le back doit être lancé avant le front) via Visual Studio pour vérifier le bon fonctionnement.

> Une demande d'acceptation du certificat de IIS peut apparaitre, acceptez le certificat.

# Identifiants:

Tous les utilisateurs dans le base de donnees par défaut ont le meme mot de passe: `toto`

# Comment déployer la solution:

Nous allons, pour déployer la solution, utiliser Visual Studio qui fourni un outil pour simplifier le deploiement sur IIS.
Une section Troubleshoot se trouve à la fin pour résoudre les éventuels soucis.

## Etape 1:

* Ouvrir IIS Manager.
* Créer une `Application Pool` avec le nom `HospitalClient` sans .Net CLR Version (`no managed code`),
* Créer une `Application Pool` avec le nom `HospitalServer` avec .Net CLR Version v4.0.X.

## Etape 2:

* Configurer l'identité de l'application pool `HospitalServer` sur votre utilisateur courant.
* Configurer l'identité de l'application pool `HospitalClient` sur `ApplicationPoolIdentity`.

## Etape 3:

* Créer un Website appelé `HospitalServer` avec l'application pool `HospitalServer`.
* Choisissez un chemin pour le contenu.
* Mettez le port à `52107`.

## Etape 4:

* Créer un Website appelé `HospitalClient` avec l'application pool `HospitalClient`.
* Choisissez un chemin pour le contenu,
* Mettez le port à `52413`.

## Etape 5:

* Ouvrir la solution `HospitalManagement.sln` avec un Visual Studio exécute en tant qu'administrateur.
* Dans Visual Studio: clic droit sur `HospitalClient`.
* Publish -> IIS, FTP, etc. -> Create Profile.
* Publish Method: Web Deploy.
* Server: `localhost`.
* Site name: `HospitalClient/`.
* Destination URL: `http://localhost:52413/`.
* You can verify the connection !
* Default settings should be fine.
* Click on Publish.

## Etape 6:

* Dans Visual Studio: clic droit sur `HospitalServer`.
* Publish -> IIS, FTP, etc. -> Create Profile.
* Publish Method: Web Deploy.
* Server: `localhost`.
* Site name: `HospitalServer/`.
* Destination URL: `http://localhost:52107/`.
* You can verify the connection !
* Default settings should be fine.
* Click on Publish.


## Etape 7:

* Votre serveur devrait normalement être déployé !

## Troubleshoot

Si vous avez une erreur 500, il faut activer certaines features de Windows:

* .Net Framework 3.5 (includes .NET 2.0 and 3.0) => Tout cocher à l'intérieur
* .Net Framework 4.8 => WCF Services => Cocher HTTP Activation et TCP Port Sharing
* Internet Information Services => World Wide Web Services => Application Development Features => Tout cocher

Vous devez aussi avoir installé:

https://dotnet.microsoft.com/permalink/dotnetcore-current-windows-runtime-bundle-installer

Une fois installe, redémarrez le système ou exécutez `net stop was /y` suivi de `net start w3svc` à partir d’une invite de commande.
