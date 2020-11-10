//const { connect } = require('http2');
var mssql=require('mssql');

var database={};

//초기화
database.init=function(app,config){
    console.log('init() 호출됨');
    connect(app,config);
}

//db에 연결하고 응답 객체의 속성으로 db객체 추가
function connect(app,config){
    console.log('connect() 호출됨');

    //config설정 사용
    mssql.Promise=global.Promise;
    mssql.Connect(config.db_url);
    //mssql.Connect(config.mssql_pool);
    database.db=mssql.connection;

    database.db.on('error',console.error.bind(console,'mssql connection error'));
    database.db.on('open',function(){
        console.log('데이터베이스에 연결되었습니다 : '+config.db_url);
        //console.log('데이터베이스를 연결합니다 : '+config.mssql_pool);
    });
    database.db.on('disconnected',connect);
}

module.exports=database;