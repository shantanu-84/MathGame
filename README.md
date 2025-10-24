# MathGame

A console-based math game application built with C# that helps users practice basic arithmetic operations through an interactive command-line interface.

## Features

- **Multiple Game Modes**: Addition, Subtraction, Multiplication, and Division
- **Game History**: Track your progress and view past game results
- **Score Tracking**: Monitor your performance with detailed scoring
- **User-Friendly Interface**: Clean console-based menu system

## Screenshots

### Main Menu
![Main Menu](screenshots/main-menu.png)
*The main menu displays all available game options and navigation choices*

### Gameplay Example - Addition Game
![Addition Game](screenshots/addition-game.png)
*Interactive addition game showing problem-solving and score tracking*

### Game History
![Game History](screenshots/game-history.png)
*View your past game results with timestamps and scores*

## How to Play

1. **Launch the Application**: Run the executable to start the game
2. **Choose Your Game**: Select from the main menu:
   - `V` - View Game History
   - `A` - Addition
   - `S` - Subtraction  
   - `M` - Multiplication
   - `D` - Division
   - `Q` - Quit the program
3. **Answer Questions**: Solve the math problems as they appear
4. **Track Progress**: View your final score and game history

## Getting Started

### Prerequisites
- .NET 9.0 or later
- Windows, macOS, or Linux

### Running the Application
```bash
# Navigate to the project directory
cd MathGame

# Run the application
dotnet run
```

## Project Structure

```
MathGame/
├── MathGame/
│   ├── Program.cs          # Main application logic
│   └── MathGame.csproj     # Project configuration
├── MathGame.sln            # Solution file
└── README.md               # This file
```

## Features in Detail

- **Interactive Menu System**: Easy navigation with single-key commands
- **Score Tracking**: Each game tracks correct answers out of total questions
- **Persistent History**: Game results are saved with timestamps
- **Multiple Difficulty Levels**: Various arithmetic operations to practice
- **Clean Console Interface**: Dark-themed, easy-to-read display

## Contributing

Feel free to contribute to this project by:
- Adding new game modes
- Improving the user interface
- Adding difficulty levels
- Implementing new features

## License

This project is open source and available under the MIT License.
