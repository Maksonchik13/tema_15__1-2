//// номер 1

//string[] mas = new string[12];
//mas[0] = "освоении";
//mas[1]= "остальное";
//mas[2]="по плечу";
//mas[3]="сложный";
//mas[4]=", но если";
//mas[5]="программирования,";
//mas[6]="многие бросают";
//mas[7]="остальное будет";
//mas[8]="освоить их,";
//mas[9]="этап в";
//mas[10]="на этом этапе,";
//mas[11]="Массивы -";
//string[] newmas = new string[12];
//newmas[0] = mas[11];
//newmas[1] = mas[3];
//newmas[2] = mas[9];
//newmas[3] = mas[0];
//newmas[4] = mas[5];
//newmas[5] = mas[10];
//newmas[6] = mas[6];
//newmas[7] = mas[1];
//newmas[8]= mas[4];
//newmas[9]= mas[8];
//newmas[10]= mas[7];
//newmas[11]= mas[2];
//foreach (string s in newmas)
//{
//    Console.Write(s+" ");
//}
//Console.WriteLine();



// номер 2
int count = 0;
int[] mas = new int[10];
Random random = new Random();
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = random.Next(51);
    Console.Write(mas[i]+" ");
    if (mas[i] % 2 == 0)
    { 
    count++;
    }
}
Console.WriteLine();
Console.WriteLine("Количество четных чисел = " + count);