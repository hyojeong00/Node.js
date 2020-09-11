//웹 브라우저에서 요청할 때 어떤 이벤트가 발생하는지 보기 위한 테스트파일

var http=require('http');

//웹서버 객체 만들기
var server=http.createServer();

//3000번 포트에서 대기
var port=3000;
server.listen(port, function()
{
    console.log('웹서버가 시작되었습니다 : %d',port);
});

//클라이언트 연결 이벤트처리
server.on('connection',function(socket)
{
    var addr=socket.address();
    console.log('클라이언트가 접속했습니다 : %s, %d',addr.address, addr.port);
});

//클라이언트 요청 이벤트 처리
server.on('request',function(req,res)
{
    console.log('클라이언트 요청이 들어왔습니다.');
    console.dir(req);
});

//서버 종료 이벤트 처리
server.on('close',function()
{        
    console.log('서버가 종료됩니다');
});