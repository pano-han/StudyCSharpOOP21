using System;

namespace IndexerTestApp
{
    class MyList
    {
        private int[] array;
        //배열화(배열이 아닌 MY LIST를 배열처럼 만들어주는 프러퍼티.
        public int this[int index] //==MyList[i]==arrsy[i] array에 있는 i값을 가져오겠다는 뜻. 
        {
            get
            { 
                return array[index]; 
            }
            set
            {
                if (index >= array.Length)
                {
                    System.Array.Resize(ref array, index + 1);
                    Console.WriteLine($"Array resized : {array.Length}");
                }
                array[index] = value;
            }
        }

        public int Length
        {
            get
            {
                return array.Length;
            } // array = new int[3];으로 지정했기 때문에 3이 넘어올 것. 
        }

        public MyList()
        {
            array = new int[3];
        }
    }
}
