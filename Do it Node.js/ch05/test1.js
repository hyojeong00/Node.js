var http=require('http');

//웹서버 객체 만들기
var server=http.createServer();

//웹서버 만들어서 3000포트에서 대기
//ar port=3000;
/*
server.listen(port, function()
{
    console.log('서버가 시작되었습니다 : %d',port);
});
*/
var host='192.168.0.106';
var port=3000;
server.listen(port, host, '50000',function()
{
    console.log('웹 서버가 시작되었습니다 : %s, %d',host,port);
});