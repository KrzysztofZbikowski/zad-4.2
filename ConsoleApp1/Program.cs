class Zad
{
    static void Main(string[] args)
    {
        int[] tablica = { 4, 2, 5, 6, 3, -6, -4, 2, 0, -1 };
        int[] tablica2 = new int[tablica.Length];
        int j = 0;
        for (int i = 0; i<tablica.Length;i++)
        {
            if (tablica[i] > 0)
            {
                tablica2[j++] = tablica[i];
            }
        }
        for (int i = 0; i<j;i++)
        {
            Console.Write(tablica2[i] + " ");
        }
        Console.ReadKey();
    }
}