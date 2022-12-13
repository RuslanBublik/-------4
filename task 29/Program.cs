// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] seq = new int [8];
for(int i = 0; i < seq.Length; i++)
{
    seq[i] = new Random().Next(0, 100);
}
Console.Write("[" + string.Join(", ", seq) + "]");
