# sar-rocket-game

In this game, the first player constructs a rocket by dragging and dropping pieces onto a rocket outline. A second person then must construct the same rocket, without looking at the first player's completed rocket. The first player can explain to the second how to construct the same rocket. Finally, the two can compare rockets and see how well the second person matched the first.

The game has three levels, of increasing difficulty. Each consists of the same three stages: each player's turn at construction, and a final comparison between the two.

The majority of the relevant code to this project is located in the TouchInputHandler.cs script. The main modifications from the original game involved the saving of piece locations for the final comparison. TouchInputHandler saves these values to the SavedVariables script, and loads the pieces to the screen during the comparison stage.

