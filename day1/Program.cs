using System;
using System.IO;

namespace day1
{
    class Program
    {
        static void Main(string[] args)
        {
            int countElfs = 0;
            int currentElf = 0;
            string inputLine;
            int elfSumCalories = 0;
            using (StreamReader reader = new StreamReader("input.txt")){
                while((inputLine = reader.ReadLine()) != null){
                    if (inputLine == ""){
                        //Console.WriteLine("Leere Zeile");
                    } else {
                        //Console.WriteLine(inputLine);
                        countElfs++;
                    }
                }
            }
            int[] elfCalories = new int[countElfs];
            using (StreamReader reader = new StreamReader("input.txt")){
                while((inputLine = reader.ReadLine()) != null){
                    if (inputLine == ""){
                        //Console.WriteLine("Leere Zeile");
                        elfCalories[currentElf] = elfSumCalories;
                        //Console.WriteLine($"Added {elfSumCalories} calories to elf {currentElf}");
                        elfSumCalories = 0;
                        currentElf++;
                    } else {
                        //Console.WriteLine(inputLine);
                        elfSumCalories = elfSumCalories + Int32.Parse(inputLine);
                    }
                }
            }

            int topElf = getMostCalories(elfCalories);
            int secondElf = getMostCalories(elfCalories);
            int thirdElf = getMostCalories(elfCalories);
            Console.WriteLine($"Der Elf {topElf} trägt die meisten Kalorien");
            Console.WriteLine($"Der Elf {secondElf} trägt die meisten Kalorien");
            Console.WriteLine($"Der Elf {thirdElf} trägt die meisten Kalorien");
            int sum = topElf + secondElf + thirdElf;
            Console.WriteLine(sum);
        }

        public static int getMostCalories(int[] caloriesArray){
            //Console.WriteLine("Hallo Welt!");
            int mostCalories = 0;
            int elfMostCalories = 0;
            for (int i = 0; i<caloriesArray.Length; i++){
                if (caloriesArray[i] > mostCalories){
                    elfMostCalories = i+1;
                    mostCalories = caloriesArray[i];
                    //Console.WriteLine(i);
                }
            }
            caloriesArray[elfMostCalories-1] = 0;
            return mostCalories;
        }
    }
}
