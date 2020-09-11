process.on('tick',function(count)
{
    console.log('tick 이벤트 발생 : %s',count);
});

console.log('2초 후에 tick이벤트 전달 시도');
setTimeout(function()
{
    process.emit('tick','2');
},2000);