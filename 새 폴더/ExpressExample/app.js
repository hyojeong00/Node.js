var express=require('express'), http=require('http'),path=require('path');

var bodyParser=require('body-parser'), cookieParser=require('cookie-parser'),
    static=require('serve-static'), errorhandler=require('errorhandler');

var expressErrorHandler=require('express-error-handler');

var expressSession=require('express-session');

var mssql=require('mssql');
var pool=mssql.connect({
    connectionLimit : 10,
    server : '192.168.0.106',
    userName : 'hyojeong',
    password : 'p@ssw0rd!',
    database : 'mysite1',
    debug : false
});

var app=express();
app.set('port',process.env.PORT || 3000);
app.use(bodyParser.urlencoded({extended:false}))
app.use(bodyParser.json())
app.use(express.static(path.join(__dirname,"public")));
app.use(cookieParser());

app.use(expressSession({
    secret:'my key',
    resave:true,
    saveUninitialized:true
}));


var router=express.Router();

router.route('/process/login/admin').post(function(req,res){
    console.log('/process/login 호출됨');
    
    var paramId=req.body.id || req.query.id;
    var paramPassword=req.body.password || req.query.password;
    
    console.log('요청 파라미터 : '+paramId+','+paramPassword);
    if(rows){
        console.dir(rows);
        var username=rows[0].name;
        res.writeHead('200', {'Content-Type':'text/html;charset=utf8'});
        res.write('<h1>로그인 성공</h1>');
        res.write('<div><p>사용자 아이디 : ' + paramId + '</p></div>');
        res.write('<div><p>사용자 이름 : ' + username + '</p></div>');
        res.write("<br><br><a href='/public/login.html'>다시 로그인하기</a>");
        res.end();        
    }
    else{
        res.writeHead('200', {'Content-Type':'text/html;charset=utf8'});
		res.write('<h2>데이터베이스 연결 실패</h2>');
		res.write('<div><p>데이터베이스에 연결하지 못했습니다.</p></div>');
		res.end();
    }
});

app.use('/',router);

var authUser=function(id, password, callback){
    console.log('authUser 호출됨 : '+id+','+password);
    
    pool.getConnection(function(err,conn){
        if(err){
            if(conn){
                conn.release();
            }
            callback(err,null);
            return;
        }
        console.log('DB연결 스레드 아이디 : '+conn.threadId);
        
        var columns=['id','name'];
        var tablename='myboard';
        
        var exec=conn.query("select ?? from ?? where id=? and password=?",
                           [columns, tablename, id, password],function(err,rows){
            console.release();
            console.log('실행대상 SQL :'+exec.sql);
            
            if(rows.length>0){
                console.log('아이디 [%s], 패스워드 [%s]가 일치하는 사용자 찾음.',id,password);
                callback(null,rows);
            }else{
                console.log('일치하는 사용자를 찾지 못함');
                callback(null,null);
            }
        });
        
        conn.on('error',function(err){
            console.log('DB 연결 에러');
            console.dir(err);
            
            callback(err,null);
        });
    });
}
// 프로세스 종료 시에 데이터베이스 연결 해제
process.on('SIGTERM', function () {
    console.log("프로세스가 종료됩니다.");
});

app.on('close', function () {
	console.log("Express 서버 객체가 종료됩니다.");
});

// Express 서버 시작
http.createServer(app).listen(app.get('port'), function(){
  console.log('서버가 시작되었습니다. 포트 : ' + app.get('port'));
});