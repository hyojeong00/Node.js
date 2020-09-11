var Codes=[{name:'JavaScript', age:30},{name:'Python',age:40},{name:'C#',age:50},{name:'C++',age:100}];

console.log('배열 요소의 수 : %d',Codes.length);
console.log('원본 Codes');
console.dir(Codes);

var Codes2=Codes.slice(1,3);

console.log('slice()로 잘라낸 후 Codes2 : %d',Codes2.length);
console.dir(Codes2);

var Codes3=Codes2.slice(1);
console.log('slice()로 잘라낸 후 Codes3 : %d',Codes3.length);
console.dir(Codes3);