// See https://aka.ms/new-console-template for more information
Random dice = new();
int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice Roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {
    if ((roll1 == roll2) && (roll2 == roll3)) {
    Console.WriteLine("You rolled triples! +6 bonus to total.");
    total += 6;
    } else {
        Console.WriteLine("You Rolled doubles! +2 bonus to total!");
        total += 2;
    }     
}

if (total < 14) {
    Console.WriteLine($"You Lose. Roll Total: {total}");
    
} else {
    Console.WriteLine($"You Win. Roll Total: {total}");
}

