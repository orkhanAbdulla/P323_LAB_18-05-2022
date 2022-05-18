using System;

namespace P323_Lab_18._05._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task-1
            string[] names = { "Hikmet Abbasov", "Abdulla Qulamov", "Cemile Hikmetova" };
            getNames(names);
            //Task-2
            int[] arr = { 1, 5, 7, 9, 10, 15, 12, 14 };
            AddToArray(ref arr, 5);
            //Task-3
            ChangeEven(ref arr);
            //Task-4
            isPolidrom("level");
        }
       
        //Task-1
        static string[] getNames(string[] fullNames)
        {
            string[] names = new string[fullNames.Length];
          
            for (int i = 0; i < fullNames.Length; i++)
            {
                names[i]=fullNames[i].Substring(0, fullNames[i].IndexOf(' '));
            }
            return names;
        }
        //Task-2
        static void AddToArray(ref int[] arr,int item)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = item;
        }
        //Task-3
        static void ChangeEven(ref int[] arr)
        {
            int[] evenArr = new int[2];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2==0)
                {
                    Array.Resize(ref evenArr, evenArr.Length + 1);
                    evenArr[evenArr.Length - 1] = arr[i];
                }
            }
            arr = evenArr;
        }
        //Task-4
        static bool isPolidrom(string str)  //level
        {
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

    }
}
