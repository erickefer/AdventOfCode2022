// See https://aka.ms/new-console-template for more information
int totalCount = 0;
using (StreamReader reader = new StreamReader("input.txt")){
    string? readLine;
    while((readLine = reader.ReadLine())!= null){
        var groups = readLine.Split(',');
        var firstGroup = groups[0];
        var secondGroup = groups[1];
        var firstGroupSplit = firstGroup.Split('-');
        var secondGroupSplit = secondGroup.Split('-');
        int firstGroupMin = Int32.Parse(firstGroupSplit[0]);
        int firstGroupMax = Int32.Parse(firstGroupSplit[1]);
        int secondGroupMin = Int32.Parse(secondGroupSplit[0]);
        int secondGroupMax = Int32.Parse(secondGroupSplit[1]);
        //Console.WriteLine($"{firstGroupMin} {firstGroupMax} {secondGroupMin} {secondGroupMax}");

        //bool result = checkOverlappingSections(firstGroupMin,firstGroupMax,secondGroupMin,secondGroupMax);
        bool result = checkIfOverlapExists(firstGroupMin, firstGroupMax, secondGroupMin, secondGroupMax);

        if (result) {
            totalCount++;
            Console.WriteLine($"{firstGroupMin} {firstGroupMax} {secondGroupMin} {secondGroupMax}");
        }

        //Console.WriteLine(totalCount);
    }
}
Console.WriteLine(totalCount);

/*
bool checkOverlappingSections(int firstMin, int firstMax, int secondMin, int secondMax){
    //check first includes second
    bool firstSecond = false;
    bool secondFirst = false;
    bool result = false;
    if (firstMin <= secondMin && secondMin <= firstMax && secondMax <= firstMax) firstSecond = true;
    //check second includes first
    if (secondMin <= firstMin && firstMin <= secondMax && firstMax <= secondMax) secondFirst = true;
    if (firstSecond || secondFirst) result = true;
    return result;
}
*/

bool checkIfOverlapExists (int firstMin, int firstMax, int secondMin, int secondMax) {
    bool result = false;
    if (firstMin >= secondMin && firstMin <= secondMax) result = true;
    if (firstMax >= secondMin && firstMax <= secondMax) result = true;
    if (secondMin >= firstMin && secondMin <= firstMax) result = true;
    if (secondMax >= firstMin && secondMax <= firstMax) result = true;
    return result;
}