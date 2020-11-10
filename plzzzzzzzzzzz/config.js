module.exports={ 


    db_url:'mssql://sa:p@ssw0rd!@127.0.0.1/mysite1',
	
    server_port:3000,
    route_info: [
	    {file:'./user', path:'/process/login', method:'login', type:'post'}					// user.login 
    ]}

    //Json 데이터는 오브젝트(Parsing하면)
    //괄호안에서도 이름 줄 수 있음 


    /*
var mssql=require('mssql');
var config;
config={
    mssql_pool:mssql.connect({
        //createPool 안됨, ConnectionPool 안됨, Connection 안됨
        host:'localhost',
        user:'sa',
        password:'p@ssw0rd!',
        database:'mysite1'
    })
};
module.exports=config;*/
