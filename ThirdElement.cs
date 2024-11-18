// Escreva uma função que receba um array de números e retorne o terceiro maior e o terceiro menor elemento desse array.
// Por exemplo, se o array for [1, 2, 3, 4, 5,6,7], a função deve retornar [3,5].

static int[] ThirdElement(int[] arrayNumbers)
{
    Array.Sort(arrayNumbers);
    int thirdMinorElement = arrayNumbers[2];
    int thirdMajorElement = arrayNumbers[^3];

    return [thirdMinorElement, thirdMajorElement];
}

int[] arrayNumbers = [1, 2, 3, 4, 5, 6, 7];
int[] result = ThirdElement(arrayNumbers);

Console.WriteLine($"[{result[0]},{result[1]}]");