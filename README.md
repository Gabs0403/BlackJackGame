# 🃏 Blackjack Game (C# - Windows Forms)

This is a simple Blackjack game implemented using C# and Windows Forms. The game supports basic Blackjack rules including hitting, standing, hidden dealer cards, and win/loss detection.

## 🎮 Features

- Draw cards (Hit) or stand
- Dealer logic (automatically draws until at least 17)
- Cards have images and hidden states
- Blackjack detection
- Bust detection for player and dealer
- UI built with Windows Forms
- Game restart support

## 🛠️ Tech Stack

- Language: C#
- Framework: .NET (Windows Forms)
- IDE: Visual Studio

## 🔄 How to Play

1. Clone or download this repository.
2. Open the solution in Visual Studio.
3. Ensure the `images` folder contains all card images in the format: `CardName_of_Suit.png`
   - Example: `10_of_Spades.png`, `King_of_Hearts.png`, etc.
4. Run the project.
5. Use the **Hit** button to draw a card or **Stand** to end your turn.
6. The dealer plays automatically after you stand.

## 🧠 Rules

- Blackjack is 21.
- Face cards count as 10.
- Ace can be 11 (soft-hand logic implemented).
- Dealer draws until reaching 17 or more.
- Player wins by getting closer to 21 than the dealer without going over.

## 🚀 Future Improvements

- Add betting system and chip count.
- Track score across rounds.
- Sound effects and animations.
- Multiplayer support.






