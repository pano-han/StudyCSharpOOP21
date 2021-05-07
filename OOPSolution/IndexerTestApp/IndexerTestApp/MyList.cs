using System;
using System.Collections;

namespace IndexerTestApp
{
    class MyList : IEnumerable, IEnumerator //foreach를 사용할 수 있게해줌. 
    {
        private int[] array;
        private int position = -1; //배열의 현재 위치값. 
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
        //IEnumerator 메소드
        public object Current
        { get { return array[position]; } } //현재값 foreach에만 필요. 

        public MyList()
        {
            array = new int[3];
        }

        //IEnumerable 매소드
        public IEnumerator GetEnumerator()
        {
            return this;
        }

        //IEnumerator 메소드
        public bool MoveNext()
        {
            position++;
            return (position < array.Length);
        }

        public void Reset()
        {
            position = -1; //초기화
        }
    }
}
