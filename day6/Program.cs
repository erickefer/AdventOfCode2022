// See https://aka.ms/new-console-template for more information
using(StreamReader reader = new StreamReader("input.txt")){
    //firstPart(reader.ReadLine());
    secondPart(reader.ReadLine(),14);
}

void firstPart(string input){
    int resultPosition = 0;
    for (int i = 0; i<input.Length-4;i++){
        string subString = input.Substring(i,4);
        Dictionary<char, int> dict = new Dictionary<char, int>();
        bool containsDuplicate = false;
        for(int k = 0; k<subString.Length; k++){
            if(dict.ContainsKey(subString[k])){
                containsDuplicate = true;
            } else {
                dict[subString[k]] = 1;
            }
        }
        if (!containsDuplicate){
            resultPosition = i+4;
            i = input.Length;
        }
    }
    Console.WriteLine(resultPosition);
}

void secondPart(string input, int markerLength){
    int resultPosition = 0;
    for (int i = 0; i<input.Length-markerLength;i++){
        string subString = input.Substring(i,markerLength);
        Dictionary<char, int> dict = new Dictionary<char, int>();
        bool containsDuplicate = false;
        for(int k = 0; k<subString.Length; k++){
            if(dict.ContainsKey(subString[k])){
                containsDuplicate = true;
            } else {
                dict[subString[k]] = 1;
            }
        }
        if (!containsDuplicate){
            resultPosition = i+markerLength;
            i = input.Length;
        }
    }
    Console.WriteLine(resultPosition);
}
