//Peer review: Zac Rice
//Very well done and works perfectly

bool playAgain = true;
bool validResponse = true;
bool isNum;

string? userAnswer;//
string? userNum;
                      //Fast Food//                                                                                                                        // Local Restaurants //                                                                                                                         // Made Up Restaurants //
// index                   0            1              2            3           4           5           6               7               8           9               10             11         12           13               14                  15             16        17         18              19                  20                      21                  22              23               24                 25                         26                          27                 28                    29  
string[] restaurants = {"Arby's", "Burger King", "Chick fil A", "Chipotle", "Five Guys", "Hardees", "Mc Donalds", "Panda Express", "Taco Bell", "Wendy's", "Cabo Fish Taco", "Green Goat", "Kabuki", "Olive Garden", "Outback Steakhouse", "Pueblo Chico", "Sakura", "Viet sub", "Wild Flour", "Wok n Roll", "Anya's Peanut Gallery", "Chika's Orange Shop", "FNAF Pizzeria", "Kirby's Buffet", "Luka's Tako", "Miku's Lemonade Stand", "Nagisa's Cheese Factory", "Rengoku's Bento Booth", "Sasha's Bakery", "Usagi's Meatball"};

Random ranNum = new Random();
int num;

    while(playAgain == true )
    {
        validResponse = true; // incase user wants to play again

        Console.WriteLine("//==========Pick a Catagory!===========//");
        Console.Write("^v^v^v^FASTFOOD RESTAURANTS^v^v^v^ Press '1': \n^v^v^v^LOCAL RESTAURANTS^v^v^v^    Press '2': \n^v^v^v^MADE-UP RESTAURANTS^v^v^v^  Press '3': \n^v^v^v^RANDOM RESTAURANTS^v^v^v^   Press '4': ");

        do
        {
            userNum = Console.ReadLine();
            isNum = int.TryParse(userNum, out num);

            if(isNum != true || num >= 5)
            {
                Console.Write("ENTER A VALID NUMBER!!!! ENTER A NUMBER: ");
            }
        }
        while(isNum != true || num >= 5);

        if(num == 1)
        {
            int ranGen = ranNum.Next(0, 10);

            Console.WriteLine("Your restaurant is: " + restaurants[ranGen]);
        }
        else if(num == 2)
        {
            int ranGen2 = ranNum.Next(10, 20);

            Console.WriteLine("Your restaurant is: " + restaurants[ranGen2]);
        }
        else if(num == 3)
        {
            int ranGen3 = ranNum.Next(20, 30);

            Console.WriteLine("Your restaurant is: " + restaurants[ranGen3]);
        }
        else if(num == 4)
        {
            int ranGen4 = ranNum.Next(0, 30);

            Console.WriteLine("Your restaurant is: " + restaurants[ranGen4]);
        }





        while(validResponse == true)
        {
            Console.Write("Do you want to run the program again? (Y/N): "); // console asks if the user wants to run the program again

            userAnswer = Console.ReadLine().ToUpper();

            if(userAnswer == "Y")
            {
                playAgain = true;
                validResponse = false;
            }
            else if(userAnswer == "N")
            {
                playAgain = false;
                validResponse = false;
            }
            else
            {   
                playAgain = false;
                validResponse = true;
                Console.WriteLine(userAnswer + " isn't a valid response. Please Enter an actual valid response please.");
            }
        }
    }