﻿// Write required code.

// Data - do not change it in code!
string[] names = {
    "Mickey Mouse", "Minnie Mouse", "Donald Duck", "Goofy", "Pluto", "Daisy Duck", "Simba", "Nala", 
    "Timon", "Pumbaa", "Mufasa", "Ariel", "Flounder", "Sebastian", "Ursula", "Belle", "Beast", "Gaston", 
    "Cinderella", "Prince Charming", "Aurora", "Maleficent", "Rapunzel", "Flynn Rider", "Elsa", "Anna", 
    "Olaf", "Moana", "Maui", "Hercules"
};


// Print all array elements, *perLine* elements per one line
// After all elements except last one should be ", " - also on the end of lines.
// After last element should be ".".
void PrintGroups(string[] t, int perLine)
{

    for (int i = 0; i < t.Length; i++)
    {
        Console.Write(t[i]);
        if ((i + 1) % perLine == 0 || i == t.Length - 1)
        {
            Console.WriteLine(i == t.Length - 1 ? "." : ", ");
        }
        else
        {
            Console.Write(", ");
        }
    }

}


// Print all array elements in *perLine* columns.
// Each column must have given *width* (number of chars).
// Columns should be separated by "| ".
// If element is too long it should be trimmed.

void PrintColumns(string[] t, int perLine, int width)
{
    int totalItems = t.Length;
    int rowCount = (int)Math.Ceiling((double)totalItems / perLine);

    for (int row = 0; row < rowCount; row++)
    {
        for (int col = 0; col < perLine; col++)
        {
            int index = row * perLine + col;
            if (index < totalItems)
            {
                string item = t[index].Length > width ? t[index].Substring(0, width) : t[index].PadRight(width);
                Console.Write(item);
                if (col < perLine - 1)
                {
                    Console.Write("| ");
                }
            }
        }
        Console.WriteLine();
    }
}


// Test how your functions work. 
// You can temprary comment some lines not needed for current testing.


Console.WriteLine("\nPrintGroups(names, 3):\n");
PrintGroups(names, 3);
/*
Mickey Mouse, Minnie Mouse, Donald Duck,
Goofy, Pluto, Daisy Duck,
Simba, Nala, Timon,
Pumbaa, Mufasa, Ariel,
Flounder, Sebastian, Ursula,
Belle, Beast, Gaston,
Cinderella, Prince Charming, Aurora,
Maleficent, Rapunzel, Flynn Rider,
Elsa, Anna, Olaf,
Moana, Maui, Hercules.
*/

Console.WriteLine("\nPrintGroups(names, 5):\n");
PrintGroups(names, 5);
/*
Mickey Mouse, Minnie Mouse, Donald Duck, Goofy, Pluto,
Daisy Duck, Simba, Nala, Timon, Pumbaa,
Mufasa, Ariel, Flounder, Sebastian, Ursula,
Belle, Beast, Gaston, Cinderella, Prince Charming,
Aurora, Maleficent, Rapunzel, Flynn Rider, Elsa,
Anna, Olaf, Moana, Maui, Hercules. 
*/

Console.WriteLine("\nPrintGroups(names, 7):\n");
PrintGroups(names, 7);
/*
Mickey Mouse, Minnie Mouse, Donald Duck, Goofy, Pluto, Daisy Duck, Simba,
Nala, Timon, Pumbaa, Mufasa, Ariel, Flounder, Sebastian,
Ursula, Belle, Beast, Gaston, Cinderella, Prince Charming, Aurora,
Maleficent, Rapunzel, Flynn Rider, Elsa, Anna, Olaf, Moana,
Maui, Hercules.
*/

// For width = 40 don't worry if result will be wrapped due to screen width.
Console.WriteLine("\nPrintGroups(names, 40):\n");
PrintGroups(names, 40);
/*
Mickey Mouse, Minnie Mouse, Donald Duck, Goofy, Pluto, Daisy Duck, Simba, Nala, Timon, Pumbaa, Mufasa, Ariel, Flounder,
Sebastian, Ursula, Belle, Beast, Gaston, Cinderella, Prince Charming, Aurora, Maleficent, Rapunzel, Flynn Rider, Elsa, A
nna, Olaf, Moana, Maui, Hercules.
*/

Console.WriteLine("\n\nPrintColumns(names, 4, 17):\n");
PrintColumns(names, 4, 17);
/*
Mickey Mouse     | Minnie Mouse     | Donald Duck      | Goofy
Pluto            | Daisy Duck       | Simba            | Nala
Timon            | Pumbaa           | Mufasa           | Ariel
Flounder         | Sebastian        | Ursula           | Belle
Beast            | Gaston           | Cinderella       | Prince Charming
Aurora           | Maleficent       | Rapunzel         | Flynn Rider
Elsa             | Anna             | Olaf             | Moana
Maui             | Hercules         |
*/

Console.WriteLine("\n\nPrintColumns(names, 5, 15):\n");
PrintColumns(names, 5, 15);
/*
Mickey Mouse   | Minnie Mouse   | Donald Duck    | Goofy          | Pluto
Daisy Duck     | Simba          | Nala           | Timon          | Pumbaa
Mufasa         | Ariel          | Flounder       | Sebastian      | Ursula
Belle          | Beast          | Gaston         | Cinderella     | Prince Charming
Aurora         | Maleficent     | Rapunzel       | Flynn Rider    | Elsa
Anna           | Olaf           | Moana          | Maui           | Hercules
*/

Console.WriteLine("\n\nPrintColumns(names, 7, 10):\n");
PrintColumns(names, 8, 10);
/*
Mickey Mou| Minnie Mou| Donald Duc| Goofy     | Pluto     | Daisy Duck| Simba     | Nala
Timon     | Pumbaa    | Mufasa    | Ariel     | Flounder  | Sebastian | Ursula    | Belle
Beast     | Gaston    | Cinderella| Prince Cha| Aurora    | Maleficent| Rapunzel  | Flynn Ride
Elsa      | Anna      | Olaf      | Moana     | Maui      | Hercules  |
*/
Console.ReadLine();
