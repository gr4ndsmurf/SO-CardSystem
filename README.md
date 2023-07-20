# Simple Card System in Unity using ScriptableObjects

## Overview

This project demonstrates a basic card system in Unity, allowing you to create and manage cards using ScriptableObjects. Each card can be dragged and dropped onto the game scene, where a corresponding prefab will be instantiated at the drop location. The project showcases how to implement this functionality using two main scripts: `CardController.cs` and `Card.cs`, along with the ScriptableObject `CardInfo.cs` to store card data.

https://github.com/gr4ndsmurf/SO-CardSystem/assets/83185792/ca08ba70-d141-4b14-a84b-91c65caca36c

## Features

- Create cards using ScriptableObjects, allowing easy customization and management.
- Drag and drop cards onto the game scene to instantiate prefabs.
- Interactive UI for card visualization and interaction.

### How to Use

1. Open the scene `MainScene.unity` located in the `Scenes` folder.
2. Create new card data by right-clicking in the project window, selecting `Create -> CardInfo`, and customize the card's attributes such as name, description, attack, shield, heart, and images.
3. Create a new prefab for the card by dragging the card data into the `prefabs` folder.
4. Attach the `Card.cs` script to the prefab, and assign the corresponding card data to it in the inspector.
5. Run the game in Unity and drag the cards from the project window into the game scene to see them instantiated.

## Script Descriptions

### CardController.cs

This script handles the card instantiation process when a card is dragged and dropped onto the game scene. It uses a singleton pattern to ensure only one instance of the `CardController` exists.

### Card.cs

The `Card.cs` script manages the behavior and interactions of individual cards in the game scene. It implements various interfaces like `IPointerDownHandler`, `IPointerUpHandler`, `IDragHandler`, `IPointerEnterHandler`, and `IPointerExitHandler` to provide functionality such as dragging and scaling the card.

### CardInfo.cs

The `CardInfo.cs` is a ScriptableObject that stores the data for each card. It contains attributes like card name, description, attack, shield, heart, background image, character image, attack photo, and the associated prefab.

### Credit
- Assets = [Cards](https://free-game-assets.itch.io/free-npc-quest-tcg-cards-pixel-art)
         [Icons](https://ravenmore.itch.io/fantasy-icon-pack)
- Developed by [gr4ndsmurf](https://github.com/gr4ndsmurf)
