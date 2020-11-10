// Express 기본 모듈 불러오기
var express = require('express')
  , http = require('http')
  , path = require('path');

// Express의 미들웨어 불러오기
var bodyParser = require('body-parser')
  , static = require('serve-static');
var cookieParser=require('cookie-parser');
var expressSession=require('express-session');

// 익스프레스 객체 생성
var app = express();

// 기본 속성 설정
app.set('port', process.env.PORT || 3000);

// body-parser를 이용해 application/x-www-form-urlencoded 파싱
app.use(bodyParser.urlencoded({ extended: false }))

// body-parser를 이용해 application/json 파싱
app.use(bodyParser.json())

app.use('/public', static(path.join(__dirname, 'public')));

app.use(cookieParser());
app.use(expressSession({
    secret:'my key',
    resave:true,
    saveUninitialized:true
}));


// 라우터 사용하여 라우팅 함수 등록
var router = express.Router();

router.route('/process/showCookie').get(function(req, res) {
	console.log('/process/showCookie 호출됨.');

   res.send(req.cookies);
});

router.route('/process/setUserCookie').get(function(req,res){
    console.log('/process/setUserCookie 호출됨');

    res.cookie('user',{
        id:'evelyn',
        name:'evelyn',
        authorized:true
    });
    res.redirect('/process/showCookie');
});

//상품정보 라우팅
router.route('/process/product').get(function(req,res){
  console.log('/process/product 호출됨');

  if(req.session.user){
    res.redirect('/public/product.html');
  }else{
    res.redirect('/public/login2.html');
  }
});

router.route('/process/login').post(function(req,res){
  console.log('/process/login 호출됨');

  var paramId= req.body.id || req.query.id;
  var paramPassword= req.body.password || req.query.password;

  if(req.session.user){
    console.log('이미 로그인되어 상품 페이지로 이동합니다');

    res.redirect('/public/product.html');
  }else{
    req.session.user={
      id: paramId,
      name: 'evelyn',
      authorized: true
    };

    res.writeHead('200',{'Content-Type':'text/html;charset=utf8'});
    res.write('<h1>로그인 성공</h1>');
    res.write('<div><p>Param id : '+ paramId + '</p></div>');
    res.write('<div><p>Param password : '+ paramPassword + '</p></div>');
    res.write('<br><br><a href="/process/product">상품페이지로 이동하기</a>');
    res.end();
  }
});

//로그아웃 라우팅
router.route('/process/logout').get(function(req,res){
  console.log('/process/logout 호출됨');

  if(req.session.user){
    console.log('로그아웃합니다.');

    req.session.destroy(function(err){
      if(err){throw err;}

      console.log('세션을 삭제하고 로그아웃되었습니다');
      res.redirect('/public/login2.html');
    })
  }else{
    console.log('아직 로그인되어 있지 않습니다');
    res.redirect('/public/login2.html');
  }
});

app.use('/', router);


// 등록되지 않은 패스에 대해 페이지 오류 응답
app.all('*', function(req, res) {
	res.status(404).send('<h1>ERROR - 페이지를 찾을 수 없습니다.</h1>');
});


// Express 서버 시작
http.createServer(app).listen(app.get('port'), function(){
  console.log('Express 서버가 ' + app.get('port')+'포트에서 열렸습니다');
});
