var http=require('http');

//클라이언트 요청을 처리하는 콜백함수를 파라미터로 전달
var server=http.createServer(function(req,res)
{
    console.log('클라이언트 요청이 들어왔습니다.');

    res.writeHead(200,{"Content-Type" : "text/html; charset=utf-8"});
    res.write("<!DOCKTYPE html>");
    res.write("<html>");
    res.write(" <head>");
    res.write("     <title>응답 페이지</title>");
    res.write(" </head>");
    res.write(" <body>");
    res.write("     <h1>노드제이에스로부터의 응답 페이지</h1>");
    res.write(" </body>");
    res.write("</html>");
    res.end();
});

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


//서버 종료 이벤트 처리
server.on('close',function()
{        
    console.log('서버가 종료됩니다');
});