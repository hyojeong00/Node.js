const e = require("express");
const { runInNewContext } = require("vm");

var login=function(req,res){
    console.log('user(user2.js)모듈 안에 있는 login 호출');

    var paramId=req.body.id || req.query.id;
    var paramPassword=req.body.password || req.query.password;

    console.log('요청 파라미터 : '+paramId+', '+paramPassword);

    var database = req.app.get('database');

    if(database.db){
        authUser(database,paramId, paramPassword, function(err,docs){
            if(err){
                console.log('로그인 중 에러 발생 : '+err.stack);
                res.redirect('../public/login_fail.html');
                res.end();

                return;
            }

            if(docs){
                console.dir(docs);

                var username=docs[0].name;
                res.redirect('../public/menu.html');
                res.end();
            }else{
                res.redirect('../public/login.html');
                res.end();
                alert('아이디와 패스워드를 다시 확인하세요');
            }
        });
    }
}