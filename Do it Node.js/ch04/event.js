process.on('exit',function()
{
    console.log('exit 이벤트 발생함');
});

console.log('2초 후에 시스템 종료 시도');
setTimeout(function()
{
    process.exit();
},2000);