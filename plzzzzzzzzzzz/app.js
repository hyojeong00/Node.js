//Express 기본 모듈
var express = require('express'), http=require('http'),path=require('path');

//미들웨어
var bodyParser=require('body-parser'), cookieParser=require('cookie-Parser'),
    static=require('serve-static'),errorHandler=require('errorhandler');

//에러핸들러
var expressErrorHandler = require('express-error-handler');

//session미들웨어
var expressSession=require('express-session');


//=======================참조=============================//
//설정파일
var config=require('./config');

//db
var database=require('./database/database');

//라우팅
var route_loader=require('./route/route_loader');
//=======================================================//

//익스프레스 객체
var app=express();

//서버변수
console.log('config.server_port : %d',config.server_port);
app.set('port',process.env.PORT || 3000);

//bodyParser , json 파싱
app.use(bodyParser.json())

//static
app.use('/public',static(path.join(__dirname,'public')));

//cookie
app.use(cookieParser());

//session
app.use(expressSession({
    secret:'my key',
    resave:true,
    saveUninitialized:true
}));

//라우팅
route_loader.init(app,express.Router());



//===========404error===========================//
var errorHandler=expressErrorHandler({
    static:{
        '404':'./public/404.html'
    }
});

app.use(expressErrorHandler.httpError(404));
app.use(errorHandler);
//=============================================//


//=====서버시작===============================//

//예외처리
process.on('uncaughtException',function(err){
    console.log('uncaughtException 발생 : '+err);
    console.log('서버 프로세스 종료하지 않고 유지');
    console.log(err.stack);
});

//종료시 db연결 해제
process.on('SIGTERM',function(){
    console.log('프로세스가 종료됩니다');
    app.close();
});

app.on('close',function(){
    console.log('Express 서버 객체가 종료됩니다');
    if(database.db){
        database.db.close();
    }
});

//서버 객체 리턴
var server=http.createServer(app).listen(app.get('port'),function(){
    console.log('서버가 시작되었습니다. 포트 : '+app.get('port'));

    //db 초기화
    database.init(app.config);
});
