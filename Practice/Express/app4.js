var express=require('express'), http=require('http');
var app=express();

app.use(function(req,res,next){
    console.log('첫번째 미들웨어에서 요청을 처리함');

    res.send({name:'김효정', age:27});
    //req.user='Evelyn';
    //next();

    //res.writeHead('200',{'Content-Type':'text/html;charset=utf8'});
    //res.end('<h1>Express 서버에서 응답한 결과입니다.</h1>');
});

app.use('/',function(req,res,next){
    console.log('두번쨰 미들웨어에서 요청을 처리함');

    res.writeHead('200',{'Content-Type':'text/html;charset=utf8'});
    res.end('<h1>Express 서버에서 '+req.user+'가 응답한 결과입니다.</h1>');
})

http.createServer(app).listen(3000,function(){
    console.log('Express서버가 3000번 포트에서 시작됨');
});