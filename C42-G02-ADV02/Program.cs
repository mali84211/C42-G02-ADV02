using System.Collections;

namespace C42_G02_ADV02
{
    internal class Program
    {
        //public static int SumarrayList(ArrayList arrayList) {
        //    int Sum=0;
        //    if (arrayList is not null)
        //    {
        //        for (int i = 0; i <arrayList.Count; i++)
        //        {
        //            Sum +=(int) arrayList[i];
        //        }
        //        return Sum;
        //    }
        //    return Sum;
        //}
        static void Main(string[] args)
        {
            #region V1
            //ArrayList arrayList = new ArrayList();
            //Console.WriteLine($"Count of arraylist={arrayList.Count},Capacity of arraylist={arrayList.Capacity}");
            //arrayList.Add( 1 );
            //Console.WriteLine("After Adding First Element");
            //Console.WriteLine($"Count of arraylist={arrayList.Count},Capacity of arraylist={arrayList.Capacity}");
            //arrayList.Add(2);
            //arrayList.AddRange(new int[] {3,4} );
            //Console.WriteLine($"Count of arraylist={arrayList.Count},Capacity of arraylist={arrayList.Capacity}");
            //arrayList.Add(5);
            //Console.WriteLine("After Adding 5th Element");
            //Console.WriteLine($"Count of arraylist={arrayList.Count},Capacity of arraylist={arrayList.Capacity}");

            //ArrayList arrayList = new ArrayList(5) {1,2,3,4,5};
            //Console.WriteLine($"Count of arraylist={arrayList.Count},Capacity of arraylist={arrayList.Capacity}");
            //arrayList.Add(6);
            //Console.WriteLine("After Adding 6th Element");
            //Console.WriteLine($"Count of arraylist={arrayList.Count},Capacity of arraylist={arrayList.Capacity}");
            //arrayList.TrimToSize();
            //Console.WriteLine("After Trim");
            //Console.WriteLine($"Count of arraylist={arrayList.Count},Capacity of arraylist={arrayList.Capacity}");
            //arrayList.Add(1);
            //arrayList.Add("mo");
            //foreach (int item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region V2
            //List<int> Numbers = new List<int>();
            //Console.WriteLine($"Count of list={Numbers.Count},Capacity of list={Numbers.Capacity}");
            //Numbers.Add(1);
            //Console.WriteLine($"Count of list={Numbers.Count},Capacity of list={Numbers.Capacity}");
            //Numbers.Add(2);
            //Numbers.AddRange(new int[] {1,2,3});
            //Console.WriteLine($"Count of list={Numbers.Count},Capacity of list={Numbers.Capacity}");
            //Numbers.Add(5);
            //Console.WriteLine("After Adding 5th Element");
            //Console.WriteLine($"Count of list={Numbers.Count},Capacity of list={Numbers.Capacity}");
            //Numbers.TrimExcess();
            //Console.WriteLine("After Trim");
            //Console.WriteLine($"Count of list={Numbers.Count},Capacity of list={Numbers.Capacity}");


            //List<int> Numbers = new List<int>(5) {1,2,3,4,5};
            //Console.WriteLine($"Count of list={Numbers.Count},Capacity of list={Numbers.Capacity}");
            //Numbers.Add(6);
            //Console.WriteLine($"Count of list={Numbers.Count},Capacity of list={Numbers.Capacity}");
            //foreach (int item in Numbers)
            //{
            //    Console.WriteLine(item);
            //}
            //Numbers[3] = 40;
            //for (int i = 0; i < Numbers.Count; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}

            //Numbers[6] = 100;
            #endregion

            #region V3
            //List<int> Numbers = new List<int>(4) { 1, 2, 3, 4};
            //Console.WriteLine($"Count of list={Numbers.Count},Capacity of list={Numbers.Capacity}");
            //Numbers.Add(5);
            //Numbers.AddRange(new int[] {6,7});      
            //foreach (int item in Numbers)
            //{
            //    Console.WriteLine($"{item}");
            //}
            //Console.WriteLine($"Count of list={Numbers.Count},Capacity of list={Numbers.Capacity}");
            //Numbers.Insert(6,8);
            //foreach (int item in Numbers)
            //{
            //    Console.WriteLine($"{item}");
            //}
            //Console.WriteLine($"Count of list={Numbers.Count},Capacity of list={Numbers.Capacity}");
            //Numbers.InsertRange(4, new int[] { 9, 10 });
            //foreach (int item in Numbers)
            //{
            //    Console.WriteLine($"{item}");
            //}
            //Console.WriteLine($"Count of list={Numbers.Count},Capacity of list={Numbers.Capacity}");

            //int index = Numbers.BinarySearch(9);
            //Console.WriteLine(index);
            //Numbers.Clear();
            //Console.WriteLine($"Count of list={Numbers.Count},Capacity of list={Numbers.Capacity}");

            //Console.WriteLine(Numbers.Contains(100));

            //List<int> Numbers = new List<int>(4) { 1, 2};
            //int[] array = new int[2];
            //Numbers.CopyTo(1,array,5,4);
            //foreach (int i in array)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
        }
    }
}
