using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassTestApp
{
    class Derived : AbstractBase
    {
        public override void AbstractMethod() ﻿// -> 여기서 override를 써서 반드시 재정의 해줘야함. 왜냐하면 MS에서 이렇게 만듦.
        {
            Console.WriteLine("Derived.AbstractMethod() 실행!");
            base.ProtectedMethod(); //필수는 아님. 이렇게 쓸 수도 있음. 
            //this.가 자기자신을 말하는 것 처럼 base.는 부모를 지칭하는 키워드를 말함. 
        }
    }
}
