var url=require('url'); //내장 모듈
const { cursorTo } = require('readline');

//주소 문자열을 URL객체로 만들기
var curURL = url.parse('https://search.naver.com/search.naver?sm=top_hty&fbm=1&ie=utf8&query=%EC%9E%90%EB%B0%94%EC%8A%A4%ED%81%AC%EB%A6%BD%ED%8A%B8');

//URL 객체를 주소 문자열로 만들기
var curStr = url.format(curURL);

console.log('주소 문자열 : %s',curStr);
console.dir(curURL);

//요청 파라미터 구분하기
var querystring = require('querystring');
var param=querystring.parse(curURL.query);

console.log('요청 파라미터 중 query의 값 : %s',param.query);
console.log('원본 요청 파라미터 : %s',querystring.stringify(param));
