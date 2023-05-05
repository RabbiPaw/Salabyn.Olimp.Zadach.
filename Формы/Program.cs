using System;
class Forms
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] det = new int[n, 20];
        int[,] detrev = new int[n, 20];
        int[,] form = new int[n * 2, 15];
        int[,] rez = new int[n, n * 2];
        for (int i = 0; i < n; i++)
        {
            string[] s = Console.ReadLine().Split();
            string[] s1 = new string[20];
            s.CopyTo(s1, 0);
            Array.Reverse(s1);
            for (int j = 0; j < 20; j++)
            {
                det[i, j] = Convert.ToInt32(s[j]);
                detrev[i, j] = Convert.ToInt32(s1[j]);
            }
        }
        for (int i = 0; i < n * 2; i++)
        {
            string[] s = Console.ReadLine().Split();
            for (int j = 0; j < 15; j++)
            {
                form[i, j] = Convert.ToInt32(s[j]);
            }
            for (int h = 0; h < n; h++)
            {
                if (form[i, 0] == det[h, 0] && form[i, 1] == det[h, 1] && form[i, 2] == det[h, 2] && form[i, 3] == det[h, 3] && form[i, 4] == det[h, 4])
                {
                    if (form[i, 10] == det[h, 10] && form[i, 11] == det[h, 11] && form[i, 12] == det[h, 12] && form[i, 13] == det[h, 13] && form[i, 14] == det[h, 14])
                    {
                        if ((form[i, 5] == det[h, 5] && form[i, 6] == det[h, 5] && form[i, 7] == det[h, 5] && form[i, 8] == det[h, 5] && form[i, 9] == det[h, 5]) || (form[i, 5] == det[h, 15] && form[i, 6] == det[h, 16] && form[i, 7] == det[h, 17] && form[i, 8] == det[h, 18] && form[i, 9] == det[h, 19]))
                        {
                            rez[h, i] = i + 1;
                            break;
                        }
                    }
                }
                if (form[i, 0] == detrev[h, 15] && form[i, 1] == detrev[h, 16] && form[i, 2] == detrev[h, 17] && form[i, 3] == detrev[h, 18] && form[i, 4] == detrev[h, 19])
                {
                    if (form[i, 10] == detrev[h, 5] && form[i, 11] == detrev[h, 6] && form[i, 12] == detrev[h, 7] && form[i, 13] == detrev[h, 8] && form[i, 14] == detrev[h, 9])
                    {
                        if ((form[i, 5] == detrev[h, 0] && form[i, 6] == detrev[h, 1] && form[i, 7] == detrev[h, 2] && form[i, 8] == detrev[h, 3] && form[i, 9] == detrev[h, 4]) || (form[i, 5] == detrev[h, 10] && form[i, 6] == detrev[h, 11] && form[i, 7] == detrev[h, 12] && form[i, 8] == detrev[h, 13] && form[i, 9] == detrev[h, 14]))
                        {
                            rez[h, i] = i + 1;
                            break;
                        }
                    }
                }
                if (form[i, 0] == det[h, 5] && form[i, 1] == det[h, 6] && form[i, 2] == det[h, 7] && form[i, 3] == det[h, 8] && form[i, 4] == det[h, 9])
                {
                    if (form[i, 10] == det[h, 15] && form[i, 11] == det[h, 16] && form[i, 12] == det[h, 17] && form[i, 13] == det[h, 18] && form[i, 14] == det[h, 19])
                    {
                        if ((form[i, 5] == det[h, 1] && form[i, 6] == det[h, 2] && form[i, 7] == det[h, 3] && form[i, 8] == det[h, 4] && form[i, 9] == det[h, 0]) || (form[i, 5] == det[h, 10] && form[i, 6] == det[h, 11] && form[i, 7] == det[h, 12] && form[i, 8] == det[h, 13] && form[i, 9] == det[h, 14]))
                        {
                            rez[h, i] = i + 1;
                            break;
                        }
                    }
                }
                if (form[i, 0] == detrev[h, 10] && form[i, 1] == detrev[h, 11] && form[i, 2] == detrev[h, 12] && form[i, 3] == detrev[h, 13] && form[i, 4] == detrev[h, 14])
                {
                    if (form[i, 10] == detrev[h, 0] && form[i, 10] == detrev[h, 1] && form[i, 10] == detrev[h, 2] && form[i, 13] == detrev[h, 3] && form[i, 14] == detrev[h, 4])
                    {
                        if ((form[i, 5] == detrev[h, 5] && form[i, 6] == detrev[h, 6] && form[i, 7] == detrev[h, 7] && form[i, 8] == detrev[h, 8] && form[i, 9] == detrev[h, 9]) || (form[i, 5] == detrev[h, 15] && form[i, 6] == detrev[h, 16] && form[i, 7] == detrev[h, 17] && form[i, 8] == detrev[h, 18] && form[i, 9] == detrev[h, 19]))
                        {
                            rez[h, i] = i + 1;
                            break;
                        }
                    }
                }
                if (form[i, 0] == det[h, 10] && form[i, 1] == det[h, 11] && form[i, 2] == det[h, 12] && form[i, 3] == det[h, 13] && form[i, 4] == det[h, 14])
                {
                    if (form[i, 10] == det[h, 0] && form[i, 11] == det[h, 1] && form[i, 12] == det[h, 2] && form[i, 13] == det[h, 3] && form[i, 14] == det[h, 4])
                    {
                        if ((form[i, 5] == det[h, 5] && form[i, 6] == det[h, 6] && form[i, 7] == det[h, 7] && form[i, 8] == det[h, 8] && form[i, 9] == det[h, 9]) || (form[i, 5] == det[h, 15] && form[i, 6] == det[h, 16] && form[i, 7] == det[h, 17] && form[i, 8] == det[h, 18] && form[i, 9] == det[h, 19]))
                        {
                            rez[h, i] = i + 1;
                            break;
                        }
                    }
                }
                if (form[i, 0] == detrev[h, 5] && form[i, 1] == detrev[h, 6] && form[i, 2] == detrev[h, 7] && form[i, 3] == detrev[h, 8] && form[i, 4] == detrev[h, 9])
                {
                    if (form[i, 10] == detrev[h, 15] && form[i, 10] == detrev[h, 16] && form[i, 10] == detrev[h, 17] && form[i, 13] == detrev[h, 18] && form[i, 14] == detrev[h, 19])
                    {
                        if ((form[i, 5] == detrev[h, 1] && form[i, 6] == detrev[h, 2] && form[i, 7] == detrev[h, 3] && form[i, 8] == detrev[h, 4] && form[i, 9] == detrev[h, 0]) || (form[i, 5] == detrev[h, 10] && form[i, 6] == detrev[h, 11] && form[i, 7] == detrev[h, 12] && form[i, 8] == detrev[h, 13] && form[i, 9] == detrev[h, 14]))
                        {
                            rez[h, i] = i + 1;
                            break;
                        }
                    }
                }
                if (form[i, 0] == det[h, 15] && form[i, 1] == det[h, 16] && form[i, 2] == det[h, 17] && form[i, 3] == det[h, 18] && form[i, 4] == det[h, 19])
                {
                    if (form[i, 10] == det[h, 5] && form[i, 11] == det[h, 6] && form[i, 12] == det[h, 7] && form[i, 13] == det[h, 8] && form[i, 14] == det[h, 9])
                    {
                        if ((form[i, 5] == det[h, 0] && form[i, 6] == det[h, 1] && form[i, 7] == det[h, 2] && form[i, 8] == det[h, 3] && form[i, 9] == det[h, 4]) || (form[i, 5] == det[h, 10] && form[i, 6] == det[h, 11] && form[i, 7] == det[h, 12] && form[i, 8] == det[h, 13] && form[i, 9] == det[h, 14]))
                        {
                            rez[h, i] = i + 1;
                            break;
                        }
                    }
                }
                if (form[i, 0] == detrev[h, 0] && form[i, 1] == detrev[h, 1] && form[i, 2] == detrev[h, 2] && form[i, 3] == detrev[h, 3] && form[i, 4] == detrev[h, 4])
                {
                    if (form[i, 10] == detrev[h, 10] && form[i, 11] == detrev[h, 11] && form[i, 12] == detrev[h, 12] && form[i, 13] == detrev[h, 13] && form[i, 14] == detrev[h, 14])
                    {
                        if ((form[i, 5] == detrev[h, 5] && form[i, 6] == detrev[h, 6] && form[i, 7] == detrev[h, 7] && form[i, 8] == detrev[h, 8] && form[i, 9] == detrev[h, 9]) || (form[i, 5] == detrev[h, 15] && form[i, 6] == detrev[h, 16] && form[i, 7] == detrev[h, 17] && form[i, 8] == detrev[h, 18] && form[i, 9] == detrev[h, 19]))
                        {
                            rez[h, i] = i + 1;
                            break;
                        }
                    }
                }
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n * 2; j++)
            {
                if (rez[i, j] != 0)
                {
                    Console.Write(rez[i, j] + " ");
                }
            }
            Console.Write("\n");
        }
    }
}