using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTestApp
{
    class Cat : Animal
    {
        //public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public Cat() {  /*Nothing */}//기본 생성자
        public Cat(string name, string color, int age) //이건 이렇게 써도 되고 안 써도 되는 것.  () 안에 들어있는게 매개변수 목록임. 
        {
            //초기화
            this.Name = name;
            this.Color = color;
            this.Age = age;
        }
        public Cat(string name, string color)
        {
            this.Name = name;
            this.Color = color;
        }
        public Cat(string color, int age)
        {
            this.Color = color;
            this.Age = age;
        }
        public void Meow() { Console.WriteLine($"{this.Color} {this.Name}, 야옹!");}
        public override void Sleep() // virtual을 쓰지 않으면 재정의할 수 없음. 
        {
            base.Sleep(); //부모의 sleep 실행.
            //이후 자식 클래스의 sleep 내용 실행. 
            Console.WriteLine($"{this.Color}고양이 {this.Name}이(가) zz잡니다!");
        }
    }
}
