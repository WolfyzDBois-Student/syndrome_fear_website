# Changelog.md

## Dernière version et modification

16h00 - Mise à jour des routes

## Styles

Importation du style : 

```js
---
import "../styles/style.css"; 
---
```

## Liens des navbar

```html
<ul class="navbar-menu">
            <li><a href="../index.html" class="navbar-link">Accueil</a></li>
            <li><a href="../team/index.html" class="navbar-link">Ctrl+Alt+Elite</a></li>
            <li><a href="../project/index.html" class="navbar-link">Déroulement du projet</a></li>
            <li><a href="../downloads/index.html" class="navbar-link">Téléchargements</a></li>
            <li><a href="../links/index.html" class="navbar-link">Liens utiles</a></li>
        </ul>
```html

Attention, ici pour Downloads. Remplacer ../ par ./ pour index.html.

Downloads : 
`./file.pdf`

## Changement pour index.css

Afin de réparer index.html, un second fichier css est créer (index.css).
Ce fichier contient des routes différentes pour le background. 
Toutes les références à des fichiers commençant par `../` sont devenues `./`