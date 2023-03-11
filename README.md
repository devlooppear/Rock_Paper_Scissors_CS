### * Descrição em Português mais abaixo

# Introduction:
- The ROCKPAPERSCISSORS program is a console-based game where the player plays against the computer in the classic game of rock-paper-scissors. The game is played in a loop until the user chooses to exit.

## Tools and Libraries:
- This program is written in C# and uses the built-in .NET framework libraries. It uses the Console class to get input and output from the user, as well as the Random class to generate a random integer between 1 and 3 to simulate the computer's move.

## Input:
- The user is prompted to input their move by typing in either "rock," "paper," or "scissors" when prompted. The input is then converted to lowercase letters for comparison to the computer's move.

## Output:
- The program outputs the computer's move, as well as the result of the round, which is either a draw or a win for the player or the computer. The program also keeps track of the score, which is displayed after each round. Once a player has reached a score of 3, the game ends and the winner is declared. The user is then prompted to play again or exit.

## Code Walkthrough:

- The program starts by initializing the variable 'playAgain' to true to start the game loop.
The program then enters a while loop that runs until the user chooses to stop playing by setting the 'playAgain' variable to false.
Inside the loop, two variables are initialized to keep track of the player's score and the computer's score, which are set to 1 at the start of each game.
Another while loop runs until either the player or the computer has reached a score of 3.
Inside the loop, the user is prompted to enter their move by typing "rock," "paper," or "scissors", which is stored in the 'inputPlayer' variable after being converted to lowercase letters for comparison.
The computer's move is generated by using the Random class to generate a random integer between 1 and 3, which is then used to select the computer's move using a switch statement.
The program then compares the player's move to the computer's move and outputs the result of the round as well as updating the scores.
After each round, the program displays the current score of the game.
Once a player has reached a score of 3, the program exits the loop and declares the winner.
Finally, the user is prompted to play again or exit by typing "y" or "n," and the program exits or restarts the loop accordingly.
Conclusion:
The ROCKPAPERSCISSORS program is a simple game that demonstrates the use of loops, conditional statements, and input/output in C#. It is a good example of a console-based application that can be used for learning the basics of C# programming.

### In Portuguese:

# Introdução:
- O programa ROCKPAPERSCISSORS é um jogo baseado em console onde o jogador joga contra o computador no jogo clássico de pedra-papel-tesoura. O jogo é jogado em um loop até que o usuário escolha sair.

## Ferramentas e Bibliotecas:

- Este programa é escrito em C# e usa as bibliotecas integradas do framework .NET. Ele usa a classe Console para obter entrada e saída do usuário, bem como a classe Random para gerar um número inteiro aleatório entre 1 e 3 para simular a jogada do computador.

## Input:

- O usuário é solicitado a inserir sua jogada digitando "pedra", "papel" ou "tesoura" quando solicitado. A entrada é então convertida em letras minúsculas para comparação com a jogada do computador.

## Output:

- O programa exibe a jogada do computador, bem como o resultado da rodada, que é um empate ou uma vitória para o jogador ou o computador. O programa também acompanha a pontuação, que é exibida após cada rodada. Quando um jogador alcança uma pontuação de 3, o jogo termina e o vencedor é declarado. O usuário é então solicitado a jogar novamente ou sair.

## Passeio pelo código:

- O programa começa inicializando a variável 'playAgain' como verdadeira para iniciar o loop do jogo.
O programa entra em um loop while que é executado até que o usuário escolha parar de jogar definindo a variável 'playAgain' como falsa.
Dentro do loop, duas variáveis são inicializadas para acompanhar a pontuação do jogador e do computador, que são definidas como 1 no início de cada jogo.
Outro loop while é executado até que o jogador ou o computador tenha alcançado uma pontuação de 3.
Dentro do loop, o usuário é solicitado a inserir sua jogada digitando "rock", "paper" ou "scissors", que é armazenado na variável 'inputPlayer' após ser convertido em letras minúsculas para comparação.
A jogada do computador é gerada usando a classe Random para gerar um número inteiro aleatório entre 1 e 3, que é então usado para selecionar a jogada do computador usando uma declaração switch.
O programa então compara a jogada do jogador com a jogada do computador e exibe o resultado da rodada, bem como atualiza as pontuações.
Após cada rodada, o programa exibe a pontuação atual do jogo.
Quando um jogador alcança uma pontuação de 3, o programa sai do loop e declara o vencedor.
Por fim, o usuário é solicitado a jogar novamente ou sair digitando "y" ou "n", e o programa sai ou reinicia o loop de acordo.
Conclusão:
O programa ROCKPAPERSCISSORS é um jogo simples que demonstra o uso de loops, declarações condicionais e entrada/saída em C#. É um bom exemplo de um aplicativo baseado em console que pode ser usado para aprender os fundamentos da programação em C#.