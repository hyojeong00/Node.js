var login=function(req,res){
    console.log('user 모듈 안 login 호출됨');

    //요청 파라미터 확인
    var paramId=req.body.id||req.query.id;
    var paramPassword=req.body.password||req.query.password;

    console.log('요청 파라미터 : '+paramId+', '+paramPassword);

    //db객체참조
    var database=req.app.get('database');

    //초기화된 경우, authUser호출하여 인증
    if(database.db){
        authUser(database, paramId, paramPassword, function(err,docs){
            if(err){
                console.error('사용자 로그인 중 에러 발생 : '+err.stack);
                res.writeHead('200',{'Content-Type':'text/html;charset=utf8'});
                res.write('<h2>사용자 로그인 중 에러 발생</h2>');
                res.write('<p>'+err.stack+'</p>');
                res.end();
                return;
            }
            //조회된 레코드가 있으면 성공응답 전송
            if(docs){
                console.dir(docs);
                //조회결과에서 사용자 이름 확인
                var username=docs[0].name;
                res.writeHead('200',{'Content-Type':'text/html;charset=utf8'});
                res.write('<h1>로그인 성공</h1>');
                res.write('<div><p>사용자 아이디 : '+paramId+'</p></div>');
                res.write('<div><p>사용자 이름 : '+username+'</p></div>');
                res.write('<br><br><a href="/public/login.html">다시 로그인하기</a>');
                res.end();
            }else{
                //조회 레코드 없는 경우 실패응답
                res.writeHead('200',{'Content-Type':'text/html;charset=utf8'});
                res.write('<h1>로그인 실패</h1>');
                res.write('<div><p>아이디와 패스워드를 다시 확인하십시오.</p></div>');
                res.write('<br><br><a href="/public/login.html">다시 로그인하기</a>');
                res.end();
            }               
        });
    }else{
        //db 객체가 초기화되지 않은 경우 실패 응답
        res.writeHead('200',{'Content-Type':'text/html;charset=utf8'});
        res.write('<h1>데이터베이스 연결 실패/h1>');
        res.write('<div><p>데이터베이스에 연결하지 못했습니다.</p></div>');
        res.end();
    }
};

//사용자 인증 함수 : 아이디로 찾고 비밀번호로 비교
var authUser=function(database, id, password, callback){
    if(err){
        callback(err,null);
        return;
    }
    console.log('아이디 [%s]로 사용자 검색 결과',id);
    console.dir(results);

    if(results.length>0){
        console.log('아이디와 일치하는 사용자 찾음');

        var user=new database.UserModel({id:id});
        var authenticated=user.authenticate(password, results[0]._doc.salt,results[0]._doc.hashed_password);
        if(authenticated){
            console.log('비밀번호 일치함');
            callback(null,results);
        }else{
            console.log('비밀번호 일치하지 않음');
            callback(null,null);
        }
    }else{
        console.log('아이디와 일치하는 사용자를 찾지 못함');
        callback(null,null);
    }
};

module.exports.login=login;