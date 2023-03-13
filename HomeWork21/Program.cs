namespace HomeWork21;
class Program
{
    static void Main(string[] args)
    {
        MyStruct myStruct1 = new MyStruct();
        myStruct1.Number = 1;
        myStruct1.Description = "First Structure";
        MyStruct myStruct2 = new MyStruct { Number = 2};
        myStruct2.Description = "Second Structure";
        MyStruct myStruct3 = new MyStruct { Number = 3, Description = "Third Structure" };
        MyStruct myStruct4 = myStruct3 with { Description = "Last Structure" };

        SetName(ref myStruct1);
        SetName(ref myStruct2);
        SetName(ref myStruct3);
        SetName(ref myStruct4);

        MyClass myClass1 = new MyClass();
        myClass1.Number = 1;
        MyClass myClass2 = new MyClass(2);
        MyClass myClass3 = new MyClass { Number = 3 };

        //SetName(myClass1, myClass2, myClass3);     ???

        PrintSorted(new IComparable[] { myStruct1, myStruct2, myStruct3, myStruct4, myClass1, myClass2, myClass3});
    }

    static void SetName( ref MyStruct structure)
    {
        structure.Name = $"Struct{structure.Number}";
    }

    //static void SetName(MyClass[] classes)       ???
    //{
    //    foreach (var item in classes)
    //    {
    //        item.Name = $"Class{item.Number}";
    //    }
    //}

    static void PrintSorted(IComparable[] array)
    {
        int maxIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[maxIndex])
            {
                IComparable saved = array[i];
                array[i] = array[maxIndex];
                array[maxIndex] = saved;
            }
        }

        foreach (var item in array)
        {
            ((IPrint)item).Print();
        }
    }
}

