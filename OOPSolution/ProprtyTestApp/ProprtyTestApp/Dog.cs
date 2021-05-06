using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProprtyTestApp
{
    class Dog
    {
        private int age;
        //private string name; 
        //name은 값을 입력받아 그래로 출력하는 역할만함. age처럼 다른 필터링이 필요하지 않음. 
        /*public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }*/
        //그래서 이렇게 줄여버림. 
        public string Name { get; set; } = "멍멍이"; //이게 초기값
        public string Color { get; set; } = "누런색";

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    this.age = 1;
                }
                else if(value > 15)
                {
                    this.age = 15;
                }
                else
                {
                    this.age = value;
                }
            }
        }
        /*public string GetName() { return this.name; }
        public void SetName(string name) { this.name = name; }

        //값을 사용.
        public string GetAge() { return $"{this.age}세"; }

        //값을 설정.
        public void SetAge(int age) {
            /*if (age < 0)
            {
                this.age = 1;
            }
            else if (age > 15)
            {
                this.age = 15;
            }
            else
            {
                this.age = age;
            }*/
            //this.age = age; }
    }
}
