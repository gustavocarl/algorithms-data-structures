var numbers = new int[10] {1, 2,3,4,5,6,7,8,9,10 };
const int searchValue = 8;

for (var i = 0; i < numbers.Length; i++){
    if (searchValue == numbers[i])
    {
        Console.WriteLine($"O elemento {numbers[i]} foi encontrado!");
        break;
    }
}

Console.ReadLine();