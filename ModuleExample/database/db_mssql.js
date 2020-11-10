var sql=require('mssql');

var dbConfig={
    user:'sa',
    password:'p@ssw0rd!',
    server:'localhost',
    database:'mysite1'
};

exports.getData=function(query){
    var conn=new sql.Connection(dbConfig);
    conn.connect().then(function(){
        var req=new sql.Request(conn);
        req.query(query).then(function(recordset){
            console.log(recordset);
        }).catch(function(err){
            console.log(err);
        });
    }).catch(function(err){
        console.log(err);
    });

    conn.close();
};

exports.execute=function(query,callback){
    var request=new sql.Request();
    request.query(query,function(err,results,fields){
        if(err){
            console.log("Error while querying database : "+err);
        }else{
            return callback(results);
        }
    });
};