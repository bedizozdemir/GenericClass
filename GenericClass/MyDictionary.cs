using System;
using System.Collections.Generic;
using System.Text;

namespace GenericClass
{
    class MyDictionary<T1,T2>
    {
        T1[] dictArray1;
        T2[] dictArray2;
        T1[] keyArray;
        T2[] valueArray;
        public MyDictionary()
        {
            dictArray1 = new T1[0];
            dictArray2 = new T2[0];
        }

        public void Add(T1 item1, T2 item2) 
        {

            keyArray = dictArray1;
            valueArray = dictArray2;

            dictArray1 = new T1[dictArray1.Length+1];
            dictArray2 = new T2[dictArray2.Length + 1];

            for (int i = 0; i < keyArray.Length; i++)
            {
                dictArray1[i] = keyArray[i];

                for (int j = 0; j < valueArray.Length; j++)
                {
                    dictArray2[j] = valueArray[j];
                }
            }

            dictArray1[dictArray1.Length - 1] = item1;
            dictArray2[dictArray2.Length - 1] = item2;
        }

        public int Count1
        {
            get { return dictArray1.Length; }
        }
        public int Count2
        {
            get { return dictArray2.Length; }
        }

        

}
}
