// See https://aka.ms/new-console-template for more information
bool reachedOperations = false;
//int countStacks;
List<string>[] stacks = new List<string>[9];

for (int i = 0; i<stacks.Length; i++){
    stacks[i] = new List<string>();
}
//bool listInitialized = false;

using (StreamReader reader = new StreamReader("input.txt")){
    string? line;
    while((line = reader.ReadLine())!= null){
        if (line != "" && !reachedOperations){
            //some change
            line = line.Replace("    "," a");
            line = line.Replace("   "," ").Trim();
            var lineSplit = line.Split(' ');
            
            for(int i = 0; i<lineSplit.Length; i++){
                if (lineSplit[i] != "a")
                    stacks[i].Insert(0,lineSplit[i].ToString());
            }
            
        }
        if (reachedOperations){
            var split = line.Split(' ');
            int count = Int32.Parse(split[1]);
            int from = Int32.Parse(split[3]);
            int to = Int32.Parse(split[5]);
            //Console.WriteLine($"{count} {from} {to}");
            string beforeMove = "";
            for (int j = 0; j<stacks.Length; j++){
                string[] array = stacks[j].ToArray();
                beforeMove += array[array.Length-1];
                //Console.WriteLine(array[array.Length-1]);
            }
            //Console.WriteLine("Before Move: "+beforeMove);
            performMultipleMove(count, from, to);
        }
        if (line == "") reachedOperations = true;
    }
}

string result = "";
//Console.WriteLine(stacks.Length);

for (int j = 0; j<stacks.Length; j++){
    string[] array = stacks[j].ToArray();
    result += array[array.Length-1];
    //Console.WriteLine(array[array.Length-1]);
}


result = result.Replace("[","");
result = result.Replace("]","");
Console.WriteLine(result);
//string[] test = stacks[0].ToArray();
//Console.WriteLine(test[test.Length-1]);

void performMove(int count, int from, int to){
    string result = "";
    for(int i = 0; i<count; i++){
        string[] arrayFrom = stacks[from-1].ToArray();
        string[] arrayTo = stacks[to-1].ToArray();
        stacks[to-1].Add(arrayFrom[arrayFrom.Length-1]);
        //Console.WriteLine($"Moving {arrayFrom[arrayFrom.Length-1]} from {from} to {to}");
        //Console.WriteLine($"Removing {arrayFrom[arrayFrom.Length-1]} from {from}");
        stacks[from-1].RemoveAt(arrayFrom.Length-1);
    }
    for (int j = 0; j<stacks.Length; j++){
        string[] array = stacks[j].ToArray();
        result += array[array.Length-1];
        //Console.WriteLine(array[array.Length-1]);
    }
    //Console.WriteLine("After move: " + result);
    //Console.WriteLine("Performing Move");
}

void performMultipleMove(int count, int from, int to){
    string result = "";
    for(int i = 0; i<count; i++){
        string[] arrayFrom = stacks[from-1].ToArray();
        string[] arrayTo = stacks[to-1].ToArray();
        stacks[to-1].Add(arrayFrom[arrayFrom.Length-count+i]);
        //Console.WriteLine($"Moving {arrayFrom[arrayFrom.Length-1]} from {from} to {to}");
        //Console.WriteLine($"Removing {arrayFrom[arrayFrom.Length-1]} from {from}");
        stacks[from-1].RemoveAt(arrayFrom.Length-count+i);
    }
    for (int j = 0; j<stacks.Length; j++){
        string[] array = stacks[j].ToArray();
        result += array[array.Length-1];
        //Console.WriteLine(array[array.Length-1]);
    }
    //Console.WriteLine("After move: " + result);
    //Console.WriteLine("Performing Move");
}
