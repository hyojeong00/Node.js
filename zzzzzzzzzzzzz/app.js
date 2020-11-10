var sql=require('mssql');

var config={
    user:'sa',
    password:'p@ssword!',
    server:'localhost',
    port:'20500',
    database:'mysite1',
    stream:true
}

sql.connect(config, function(err){
    var request=new sql.Request();
    request.stream=true;
    request.query("SELECT * FROM myboard1");

    request.on('row',function(row){
        console.log('name : '+row.name);
        console.log('id : '+row.id);
        console.log('');
        });

    request.on('error',function(err){
        console.log(err);
    });

    request.on('done',function(returnValue){
        console.log('Data End');
    });
});