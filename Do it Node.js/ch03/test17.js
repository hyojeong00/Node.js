function Person(name, age)
{
    this.name=name;
    this.age=age;
}

Person.prototype.walk=function(speed)
{
    console.log(speed+'km 속도로 걸어갑니다');
}

var Person01=new Person('김철수',40);
var Person02=new Person('김영희',50);

console.log(Person01.name+'객체의 walk(10)을 호출합니다');
Person01.walk(10);