var Codes=[{name:'JavaScript', age:30}, {name:'Python', age:40}];

var add= function(a,b)
{
    return a+b;
};

Codes.push(add);

console.log('배열 요소의 수 : %d',Codes.length);
console.log('세번째 요소로 추가된 함수 실행 : %d',Codes[2](10,10));