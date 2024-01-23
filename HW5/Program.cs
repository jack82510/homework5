using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            //******************************* Q: 利用一維陣列求10個數字的計算平均值 ***************************
            //double[] HelloArrary = new double[10];
            //for (int i = 0; i < HelloArrary.Length; i++)
            //{
            //    HelloArrary[i] = Convert.ToDouble(Console.ReadLine());
            //}
            //double sum = 0;
            //double avg = 0;
            //foreach (double item in HelloArrary)
            //{
            //    sum += item;
            //}
            //avg = sum / HelloArrary.Length;
            //Console.WriteLine("平均數為:"+avg);
            //Console.ReadKey();


            //*************************** Q:利用一維陣列求10個數字的最大值 **************************************

            //int[] maxarray = new int[10];
            //for (int i = 0; i < maxarray.Length; i++)
            //{
            //    maxarray[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int max = int.MinValue;
            //foreach(int item in maxarray)
            //{
            //    if (item > max)
            //    {
            //        max = item;
            //    }
            //}
            //Console.WriteLine("最大值為:"+max);
            //Console.ReadKey();

            //***** Q:搜尋問題：輸入10個數字至A[ ]，再輸入x，判斷x是否存在於A陣列中，如果存在，輸出所在的註標(索引)值，若不存在，則告知不存在 *****

            //int[] A = new int[10];
            //for (int i = 0; i < A.Length; i++)
            //{
            //    A[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("請輸入x的值");
            //int x = Convert.ToInt32(Console.ReadLine());

            //bool check = true;
            //foreach (int item in A)
            //{
            //    if (item == x)
            //    {
            //        x = item;
            //        Console.WriteLine($"{x}");
            //        check = true;
            //        break;
            //    }
            //    else
            //    {
            //        check = false;
            //    }
            //}
            //if (check == false)
            //{
            //    Console.WriteLine("不要瞎掰好嗎?並沒有");
            //}
            //Console.ReadKey();

            //***** Q:搜尋問題：輸入10個數字至A[ ]，再輸入x，判斷x是否存在於A陣列中，如果存在，輸出所在的註標(索引)值，若不存在，則告知不存在 *****
            //學長的方法

            //int[] A = new int[10];
            //for (int i = 0; i < A.Length; i++)
            //{
            //    A[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("請輸入x的值");
            //int x = Convert.ToInt32(Console.ReadLine());

            //for (int j = 0; j < A.Length; j++)
            //{
            //    if (A[j] == x)
            //    {
            //        Console.WriteLine($"{x}");
            //        break;
            //    }
            //    if (j == (A.Length - 1))
            //    {
            //        Console.WriteLine("不要瞎掰好嗎?並沒有");
            //    }
            //}
            //Console.ReadKey();


            // Q:兩個二維矩陣相加。以陣列模擬矩陣，求兩個2乘3的二維矩陣相加之結果，
            // 第一個及第二個矩陣分別以A及B表示，相加之結果存入C矩陣，最後將C矩陣內容顯示出來。 


            //int[,] arrayA = new int[2, 3];
            //int[,] arrayB = new int[2, 3];
            //int[,] arrayC = new int[2, 3];

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        arrayA[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        arrayB[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        arrayC[i, j] += arrayA[i, j] + arrayB[i, j];
            //        Console.WriteLine($"輸出陣列C:{arrayC[i, j]}");
            //    }
            //}
            //Console.ReadKey();


            //************* Q:兩個矩陣相乘。求2乘3的A矩陣乘以3乘1的B矩陣，結果存入2乘1的C矩陣，最後將C矩陣的內容顯示出來 *******************

            //int[,] arrayA = new int[2, 3];
            //int[,] arrayB = new int[3, 1];
            //int[,] arrayC = new int[2, 1];

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        arrayA[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 1; j++)
            //    {
            //        arrayB[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 1; j++)
            //    {
            //        for (int k = 0; k < 3; k++)
            //        {
            //            arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
            //        }
            //        Console.WriteLine($"輸出C陣列= {arrayC[i, j]}");
            //    }
            //}

            //Console.ReadKey();

            //*********** Q:寫一程式，將10個數字讀入A陣列，然後逐一檢查此陣列，如A[i]>5，則令A[i]=A[i]-5，否則A[i]=A[i]+5************************

            //int[] arrayA = new int[10];
            //for (int i = 0; i < arrayA.Length; i++)
            //{
            //    arrayA[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //foreach (int item in arrayA)
            //{
            //    int now = 0;
            //    if (item > 5)
            //    {
            //        now = item - 5;
            //    }
            //    else
            //    {
            //        now = item + 5;
            //    }
            //    Console.WriteLine($"陣列A執行+5-5後的數{now}");
            //}
            //Console.ReadKey();

            //************ Q:寫一程式，將10個數字讀入A陣列，對每一個數字，令A[i]=A[i]+i *********************

            //int[] arrayA = new int[10];
            //Console.WriteLine("請輸入10個數");
            //for (int i = 0; i < arrayA.Length; i++)
            //{
            //    Console.Write($"請輸入第{i + 1}個數字:");
            //    arrayA[i] = Convert.ToInt32(Console.ReadLine());
            //    arrayA[i] = arrayA[i] + i;
            //}

            //foreach (int item in arrayA)
            //{
            //    Console.WriteLine($"答案來囉{item}");
            //}
            //Console.ReadKey();

            //************************* Q:寫一程式，將10個數字讀入A陣列，並建立一個B陣列，如A[i]≥0，令B[i]=1，否則令B[i]=0 *******************************

            //int[] arrayA = new int[10];
            //int[] arrayB = new int[10];
            //Console.WriteLine("請輸入10個數字");
            //for (int i = 0; i < arrayA.Length; i++)
            //{
            //    Console.WriteLine($"請輸入第{i + 1}個數字:");
            //    arrayA[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i = 0; i < arrayB.Length; i++)
            //{

            //    if (arrayA[i] >= 0)
            //    {
            //        arrayB[i] = 1;
            //    }
            //    else
            //    {
            //        arrayB[i] = 0;
            //    }
            //}
            //foreach (int item in arrayB)
            //{
            //    Console.WriteLine($"運算結果為{item}");
            //}


            //Console.ReadKey();


            //****************************** Q:寫一程式，將15數字存入3×5的二維陣列A中，求每一行及每一列數字的和 ************************************************


            //int[,] arrayA = new int[3, 5];
            //Console.WriteLine("請依序輸入15個數字到3x5的二維陣列中");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        arrayA[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("每一行的總和:");
            //for (int i = 0; i < 3; i++)
            //{
            //    int rowsum = 0;
            //    for (int j = 0; j < 5; j++)
            //    {
            //        rowsum += arrayA[i, j];
            //    }
            //    Console.WriteLine($"第{i+1}行的總和為:{rowsum}");
            //}
            //Console.WriteLine("每一列的總和");
            //for (int j = 0; j < 5; j++)
            //{
            //    int colsum = 0;
            //    for (int i = 0; i < 3; i++)
            //    {
            //        colsum += arrayA[i, j];
            //    }
            //    Console.WriteLine($"第{j + 1}列的總和為:{colsum}");
            //}
            //Console.ReadKey();

            //********************************** Q:寫一程式，將15數字存入3×5的二維陣列A中，求每一行及每一列數字的最小值 ***************************************

            //int[,] arrayA = new int[3, 5];
            //Console.WriteLine("請輸入15個數字");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.WriteLine("請輸入數字");
            //        arrayA[i, j] = Convert.ToInt32(Console.ReadLine()); 
            //    }
            //}
            //Console.WriteLine("每一行的最小值");
            //for (int i = 0; i < 3; i++)
            //{
            //    int minrow = arrayA[i,0];
            //    for (int j = 0; j < 5; j++)
            //    {
            //        if (arrayA[i, j] < minrow)
            //        {
            //            minrow = arrayA[i, j];
            //        }

            //    }
            //    Console.WriteLine($"第{i+1}行的最小值{minrow}");
            //}
            //Console.WriteLine("每一列的最小值");
            //for (int i = 0; i < 3; i++)
            //{
            //    int mincolumn = arrayA[0, i];   
            //    for (int j = 0; j < 5; j++) 
            //    {
            //        if (arrayA[i, j] < mincolumn)
            //        {
            //            mincolumn = arrayA[i, j];
            //        }
            //    }
            //    Console.WriteLine($"第{i+1}列的最小值{mincolumn}");
            //}
            //Console.ReadKey();

            //********************** Q:寫一程式，輸入兩組數字：a1,a2,…,a5和b1,b2,…,b5。求ai+bi，i=1到i=5 *******

            //int[] a = new int[5];
            //int[] b = new int[5];

            //// 提示用戶輸入第一組數字
            //Console.WriteLine("請輸入第一組數字（a1, a2, ..., a5）：");
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.Write($"a{i + 1}: ");
            //    a[i] = int.Parse(Console.ReadLine());
            //}

            //// 提示用戶輸入第二組數字
            //Console.WriteLine("請輸入第二組數字（b1, b2, ..., b5）：");
            //for (int i = 0; i < b.Length; i++)
            //{
            //    Console.Write($"b{i + 1}: ");
            //    b[i] = int.Parse(Console.ReadLine());
            //}

            //// 計算並輸出 ai + bi
            //Console.WriteLine("計算結果：");
            //for (int i = 0; i < a.Length; i++)
            //{
            //    int sum = a[i] + b[i];
            //    Console.WriteLine($"a{i + 1} + b{i + 1} = {sum}");
            //}
            //Console.ReadKey();

            //*********** Q:寫一程式，輸入兩組數字： a1,a2,…,a5和b1,b2,…,b5。令x為a中的最大值，令y為b中的最大值，求x與y中較小者 ***********************************************************

            //    int[] a = new int[5];
            //    int[] b = new int[5];

            //    // 提示用戶輸入第一組數字
            //    Console.WriteLine("請輸入第一組數字（a1, a2, ..., a5）：");
            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        Console.Write($"a{i + 1}: ");
            //        a[i] = int.Parse(Console.ReadLine());
            //    }

            //    // 提示用戶輸入第二組數字
            //    Console.WriteLine("請輸入第二組數字（b1, b2, ..., b5）：");
            //    for (int i = 0; i < b.Length; i++)
            //    {
            //        Console.Write($"b{i + 1}: ");
            //        b[i] = int.Parse(Console.ReadLine());
            //    }

            //    // 找出 a 中的最大值
            //    int maxX = int.MinValue;
            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        if (a[i] > maxX)
            //        {
            //            maxX = a[i];
            //        }
            //    }


            //    // 找出 b 中的最大值
            //    int maxY = int.MinValue;
            //    int i = 0;
            //    while (i < b.Length)
            //    {

            //        if (b[i] > maxY)
            //        {
            //            maxY = b[i];
            //        }
            //        i++;
            //    }

            //    for (int i = 0; i < b.Length; i++)
            //    {
            //        if (b[i] > maxY)
            //        {
            //            maxY = b[i];
            //        }
            //    }

            //    // 求 x 與 y 中的較小者
            //    int result = Math.Min(maxX, maxY);

            //    // 輸出結果
            //    Console.WriteLine($"x 與 y 中的較小者為：{result}");
            //    Console.WriteLine($"x 與 y 中的較小者為：{Math.Min(maxX, maxY)}");

            //    Console.ReadKey();

            //5-6.寫一程式，輸入兩組數字：a1,a2,…,a5和b1,b2,…,b5。求ai+bi，i=1到i=5。

            //int[] a = new int[5];
            //int[] b = new int[5];

            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine($"請輸入第{i+1}個數字");
            //    a[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i = 0; i < b.Length; i++)
            //{
            //    Console.WriteLine($"請輸入第{i + 1}個數字");
            //    b[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine($"a{i+1}+b{i+1}:{a[i]+b[i]}");
            //}

            ////int i = 0;
            ////while (i < a.Length)
            ////{
            ////    Console.WriteLine($"{a[i]+b[i]}");
            ////    i++;
            ////}
            //Console.ReadKey();
            //


        }
    }
}
