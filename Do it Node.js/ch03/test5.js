var Person={};

Person['age']=20;
Person['name']='break the code';
Person.add=function(a,b)
{
    return a+b;
};

console.log('더하기 : %d',Person.add(10,10));