const config={
    user:'sa',
    password:'p@ssw0rd!',
    server:'localhost',
    database:'mysite1'
}  

const sql=require('mssql')

(async function(){
    try{
        let pool=await pool.request()
        .input('input_parameter',sql.Int,value)
        .query("SELECT * FROM myboard where id=?")

        console.dir(result1)

        let result2=await pool.request()
        .input('input_parameter',sql.Int,value)
        .output('output_parameter',sql.Varchar(50))
        .execute('procedure_name')

        console.dir(result2)
    } catch(err){
        //errorcheck
    }
})()

sql.on('error',err=>{
    //errorhandler
})