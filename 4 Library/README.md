# Library 📚

A simple console program for managing a library database of books and magazines.

## Description ℹ️

The program allows adding new items to the database, displaying existing items, and saving/loading the database from a text file.

## How to Use 🛠️

1. Run the program to start working with the library.
2. Choose one of the available options:
    - **Add a Book**: Allows adding a new book to the database. Provide the author's name, book title, publication year, publisher name, and ISBN number.
    - **Add a Magazine**: Allows adding a new magazine to the database. Provide the magazine title, issue number, publication year, and type (e.g., quarterly, monthly).
    - **Display the Database**: Displays all items currently in the library database.
    - **Save the Database to File**: Saves the current database to a text file named "database.txt".
    - **Load the Database from File**: Loads the database from a text file named "database.txt" and adds its contents to the current database.
    - **Exit**: Quits the program.
3. Follow the instructions displayed on the screen.

## Project Structure 📁

- **MaterialBiblioteczny.cs**: An abstract class representing library materials.
- **Ksiazka.cs**: A class representing a book, inheriting from the MaterialBiblioteczny class.
- **Czasopismo.cs**: A class representing a magazine, inheriting from the MaterialBiblioteczny class.
- **Program.cs**: The main program class containing the `Main` method and user interaction logic.
