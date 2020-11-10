var Connection=require('tedious').Connection;
var Request=require('tedious').Request;
var TYPES=require('tedious').TYPES;

var config={
    server:'192.168.0.106',
    authentication:{
        type: 'default',
        options:{
            userName:'sa',
            password:'p@ssw0rd!'
        }
    },
    options:{
        database:'mysite1'
    }
}

var connection=new Connection(config);

connection.on('connect',function(err){
    if(err){
        console.log(err);
    }else{
        console.log('Connected');
    }
});