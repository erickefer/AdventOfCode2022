// See https://aka.ms/new-console-template for more information
int totalSum = 0;

using (StreamReader reader = new StreamReader("input.txt")){
    string readLine;
    while((readLine = reader.ReadLine()) != null){
        Console.WriteLine($"{readLine} + {readLine.Length}");
        int half = readLine.Length/2;
        string firstHalf = readLine.Substring(0, half);
        string secondHalf = readLine.Substring(half, half);
        Console.WriteLine($"{firstHalf} . {secondHalf}");
        string duplicates = getDuplicates(firstHalf, secondHalf);
        for (int j = 0; j<duplicates.Length; j++){
            int currentPriority = getPriority(duplicates[j]);
            Console.WriteLine($"Current Priority: {currentPriority}"); 
            totalSum += currentPriority;
        }
    }
    Console.WriteLine($"Total: {totalSum}");
    //getDuplicates(firstHalf, secondHalf);
}

//Methods
string getDuplicates (string first, string second) {
    string duplicates = "";
    for(int i = 0; i<first.Length; i++){
        if (second.Contains(first[i]) && !duplicates.Contains(first[i])){
            duplicates += first[i];
            Console.WriteLine($"Found duplicate {first[i]}");
        }
    }
    return duplicates;
}

int getPriority (char input) {
    string aplhabet = "0abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    int result = 0;
    for(int i = 0; i<aplhabet.Length; i++){
        if (input == aplhabet[i]){
            result = i;
        }
    }
    return result;
}