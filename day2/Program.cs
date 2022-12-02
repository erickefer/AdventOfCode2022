// See https://aka.ms/new-console-template for more information
//main program
/*
- Rock beats Sciccors, Paper beats Rock, Sciccors beats Paper 
- first column is what opponent is playing
- A = Rock, B = Paper, C = Scissors
- second column response
- X = Loss, Y = Draw, Z = Win
- 1 point for Rock, 2 points for Paper, 3 points for Scissors
- 0 point for loss, 3 points for draw, 6 points for win
*/
Dictionary<string, int> dict = new Dictionary<string, int>();
dict["AX"] = 3; // Loss 
dict["AY"] = 4; // Draw
dict["AZ"] = 8; // Win
dict["BX"] = 1; // Loss
dict["BY"] = 5; // Draw
dict["BZ"] = 9; // Win
dict["CX"] = 2; // Loss
dict["CY"] = 6; // Draw
dict["CZ"] = 7; // Win

using (StreamReader reader = new StreamReader("input.txt")){
    string line;
    int totalScore = 0;
    while ((line = reader.ReadLine()) != null){
        var lineSplit = line.Split(" ");
        string opponent = lineSplit[0];
        string own = lineSplit[1];
        //Console.WriteLine($"Opponent: {opponent}, Own: {own}");
        //if (own == "X") totalScore += 1;
        //if (own == "Y") totalScore += 2;
        //if (own == "Z") totalScore += 3;
        string dictEntry = opponent+own;
        totalScore += dict[dictEntry];
    }
    Console.WriteLine(totalScore);
}

//Methods
