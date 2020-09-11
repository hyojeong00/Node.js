var Codes=[{name:'JavaScript', age:30},{name:'Python',age:40},{name:'C#',age:50}];
console.log('push() 호출 전 배열 요소의 수 : %d',Codes.length);

Codes.push({name:'Java', age:80});
console.log('push() 호출 후 배열 요소의 수 : %d',Codes.length);

Codes.pop();
console.log('push() 호출 후 배열 요소의 수 : %d',Codes.length);