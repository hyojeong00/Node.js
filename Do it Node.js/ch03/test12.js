var Codes=[{name:'JavaScript', age:30},{name:'Python',age:40},{name:'C#',age:50}];
console.log('delete 키워드로 배열 요소 삭제 전 배열 요소의 수 : %d',Codes.length);

delete Codes[1];
console.log('delete 키워드로 배열 요소 삭제 후');
console.dir(Codes);

Codes.splice(1,0,{name:'C++', age:100});
console.log('splice()로 요소를 인덱스 1에 추가한 후');
console.dir(Codes);

Codes.splice(2,1);
console.log('splice()로 인덱스 2의 요소 1개를 삭제한 후');
console.dir(Codes);