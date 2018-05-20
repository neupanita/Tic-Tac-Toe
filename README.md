Code Sample for Informatics Developers

Instructions:
Write a command-line program to simulate two people playing a game of a tic-tac-toe.
You may write the program in any language you like, but preferably in C#.NET,
VB.NET, C/C++, Visual Basic, or Java. Your code sample is intended to demonstrate
the way you approach programming problems, and should be representative of code you
would develop for a real-life product. You may use runtime libraries commonly used by
programmers using the language you choose. Please submit only the source code for
your program (the executable is not needed). NOTE: This is not an interactive Tic-
Tac-Toe game; it runs without user interaction.
Requirements:
1. The program accepts a single integer argument on the command line representing
the board size. Tic-tac-toe traditionally has a 3x3 board size but your program
should support an NxN board where N is between 2 and 10 inclusive.
2. The program simulates a game of tic-tac-toe between two computer players,
named X and O. The program randomly selects which player goes first.
3. During each player’s turn, the program randomly places an X or an O in one of
the remaining available squares on the board and puts that player’s mark in that
square.
4. If either player fills all the squares horizontally, vertically, or diagonally between
two corners, that player is the winner.
5. The game ends when there is a winner, or when all available squares have been
filled.
6. Your program should display the name of the player who went first, a picture of
the board (use the ‘#’ character to represent unused board squares), and the
winner (unless the game is a draw).
Sample Output #1:
O goes first
XOO
XXX
#OO
X won!
Sample Output #2:
O goes first
XOXOO
OXXXO
XXOOO
OOXOX
XXOOX
It was a draw.
