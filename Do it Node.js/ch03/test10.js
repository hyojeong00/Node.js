var Codes=[{name:'JavaScript', age:30},{name:'Python',age:40},{name:'C#',age:50}];

console.log('배열의 요소 수 : %d',Codes.length);

for(var i=0;i<Codes.length;i++)
{
    console.log('배열 요소 #'+i+' : %s',Codes[i].name);
}

console.log('\nforEach 구문 사용하기');
Codes.forEach(function(item,index)
{
    console.log('배열 요소 #'+index+' : %s',item.name);
});