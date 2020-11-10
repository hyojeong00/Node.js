var express=require('express'), http=require('http'), path=require('path');
var bodyParser=require('body-parser');
var static=require('serve-static');

var app=express();

app.set('port',process.env.PORT || 3000);

app.use(bodyParser.urlencoded({extended:false}));

app.use(bodyParser.json());

app.use('/public',static(path.join(__dirname,'public')));

app.use(function(req,res,next){
    console.log('첫번째 미들웨어에서 요청을 처리함');

    var paramId=req.body.id || req.query.id;
    var paramPassword=req.body.password || req.query.password;

    res.writeHead('200',{'Content-Type':'text/html;charset=utf8'});
    res.write('<h1>Express 서버에서 응답한 결과입니다</h1>');
    res.write('<div><p>Param id : '+ paramId+'</p></div>');
    res.write('<div><p>Param password : '+ paramPassword+'</p></div>');
    res.end();
   
});

app.use('/',function(req,res,next){
    console.log('두번쨰 미들웨어에서 요청을 처리함');

    res.writeHead('200',{'Content-Type':'text/html;charset=utf8'});
    res.end('<h1>Express 서버에서 '+req.user+'가 응답한 결과입니다.</h1>');
})

http.createServer(app).listen(3000,function(){
    console.log('Express서버가 3000번 포트에서 시작됨');
});